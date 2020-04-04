using SevenConverter.Utils;
using System;
using System.Drawing;
using System.IO;
using System.Media;
using System.Windows.Forms;

namespace SevenConverter
{
    public partial class Main : Form
    {
        #region Public Constructors

        public Main()
        {
            // localization debug
            //System.Threading.Thread.CurrentThread.CurrentUICulture =
            //    System.Globalization.CultureInfo.GetCultureInfo("ru-RU");
            InitializeComponent();
        }

        #endregion Public Constructors

        #region Public Delegates

        public delegate void AddLog();

        #endregion Public Delegates

        #region Private Fields

        private int audioPanelHeight;
        private string config_path;
        private string ffmpeg_path, currentPath;

        private Settings settings;

        private int videoPanelHeight;

        #endregion Private Fields

        #region Private Methods

        private void AddFile(string fileName)
        {
            listSoruceFiles.Items.Add(fileName, 0);
            settings.lastSourcePath = Path.GetDirectoryName(fileName);
            if (String.IsNullOrEmpty(tbDestFilePath.Text))
                tbDestFilePath.Text = Path.GetDirectoryName(fileName);
            btnAdd.Visible = false;
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            MenuItemAdd_Click(sender, e);
        }

        private void BtnAudioSet_Click(object sender, EventArgs e)
        {
            TurnOffPanels();
            Tools.ShowPanel(btnAudioSet, pnlAudio, !pnlAudio.Visible, audioPanelHeight);
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            TurnOffPanels();
            SaveConfig();

            bool result = false;

            if (listSoruceFiles.Items.Count > 0)
            {
                if (!String.IsNullOrEmpty(tbDestFilePath.Text)
                    && !Directory.Exists(tbDestFilePath.Text))
                {
                    try
                    {
                        Directory.CreateDirectory(tbDestFilePath.Text);
                    }
                    catch (IOException exception)
                    {
                        MessageBox.Show(exception.Message,
                            Properties.strings.Error, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                if (!String.IsNullOrEmpty(tbDestFilePath.Text)
                    && Directory.Exists(tbDestFilePath.Text))
                {
                    // Run

                    // single output file (joined)
                    if (cbJoin.Checked)
                    {
                        string inputFiles = Files.GetConcatFileNames(listSoruceFiles.Items);
                        string outputFile = Files.OfferDstFileName(
                            listSoruceFiles.Items[0].Text,
                            tbDestFilePath.Text,
                            cbFormat.Text.ToLower());

                        result = Convert(inputFiles, outputFile, false, rbVideo.Checked);
                    }
                    else
                    {
                        // multiple output files
                        foreach (ListViewItem item in listSoruceFiles.Items)
                        {
                            string outputFile = Files.OfferDstFileName(
                                item.Text,
                                tbDestFilePath.Text,
                                cbFormat.Text.ToLower());

                            result = Convert(item.Text, outputFile, true, rbVideo.Checked);

                            if (!result)
                                break;

                            // paint green if all ok
                            item.ForeColor = Color.LightGreen;
                        }
                    }

                    // done!
                    if (result)
                        SystemSounds.Exclamation.Play();
                }
                else
                    MessageBox.Show(Properties.strings.FolderDoesNotExist);
            }
            else
                MessageBox.Show(Properties.strings.YouMustSelectSourceFile);
        }

        private bool Convert(string inputFiles, string outputFile, bool quote, bool video)
        {
            if (video)
                return ConvertVideo(inputFiles, outputFile, quote);
            else
                return ConvertAudio(inputFiles, outputFile, quote);
        }

        private void BtnVideoSet_Click(object sender, EventArgs e)
        {
            TurnOffPanels();
            Tools.ShowPanel(btnVideoSet, pnlVideo, !pnlVideo.Visible, videoPanelHeight);
        }

        private void BtnFolder_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(folderBrowserDialog.SelectedPath))
                folderBrowserDialog.SelectedPath = settings.lastSourcePath;
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                tbDestFilePath.Text = folderBrowserDialog.SelectedPath;
        }

        private void CbAudioCodec_SelectedIndexChanged(object sender, EventArgs e)
        {
            TurnOffPanels();
            cbFreq.Enabled = cbAudioCodec.SelectedIndex != 0 && cbAudioCodec.SelectedIndex != 4;
            cbQuality.Enabled = cbFreq.Enabled;
            btnAudioSet.Enabled = cbFreq.Enabled;
        }

        private void CbFormat_SelectedIndexChanged(object sender, EventArgs e)
        {
            TurnOffPanels();
            if (rbAudio.Checked)
            {
                cbFreq.Enabled = cbFormat.SelectedIndex == 0 || cbFormat.SelectedIndex == 1;
                cbQuality.Enabled = cbFreq.Enabled;
                btnAudioSet.Enabled = cbFreq.Enabled;
            }
        }

        private void CbVideoCodec_SelectedIndexChanged(object sender, EventArgs e)
        {
            TurnOffPanels();
            cbAspect.Enabled = cbVideoCodec.SelectedIndex != 0;
            cbLines.Enabled = cbAspect.Enabled;
            btnVideoSet.Enabled = cbAspect.Enabled;
        }

        private void ContextMenuFile_Opened(object sender, EventArgs e)
        {
            contextMenuFile.Items[5].Visible = !(listSoruceFiles.SelectedItems.Count == 0);
            contextMenuFile.Items[2].Visible = (listSoruceFiles.SelectedItems.Count == 1);
            contextMenuFile.Items[3].Visible = contextMenuFile.Items[5].Visible;
            contextMenuFile.Items[4].Visible = contextMenuFile.Items[5].Visible;
        }

        private void DeleteAll(object sender, EventArgs e)
        {
            listSoruceFiles.Clear();
            tbDestFilePath.Text = String.Empty;
            btnAdd.Visible = true;
        }

        private void DeleteSelected(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listSoruceFiles.SelectedItems)
                listSoruceFiles.Items.Remove(item);
            btnAdd.Visible = (listSoruceFiles.Items.Count == 0);
        }

        private void LabelTitle_Click(object sender, EventArgs e)
        {
            using (About about = new About())
            {
                about.ShowDialog();
            }
        }

        private void ListSoruceFiles_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
                foreach (string file in files)
                    AddFile(file);
            }
        }

        private void ListSoruceFiles_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy;
        }

        private void Main_Click(object sender, EventArgs e)
        {
            TurnOffPanels();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            this.Text = this.Text + " " + Tools.GetProgramVersion();
            audioPanelHeight = pnlAudio.Height;
            videoPanelHeight = pnlVideo.Height;
            listSoruceFiles.Clear();
            this.LoadConfig();
        }

        private void MenuItemAdd_Click(object sender, EventArgs e)
        {
            openFileDialog.InitialDirectory = settings.lastSourcePath;
            openFileDialog.FileName = String.Empty;
            openFileDialog.Multiselect = true;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
                foreach (string fileName in openFileDialog.FileNames)
                    AddFile(fileName);
        }

        private void MenuItemInfo_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listSoruceFiles.SelectedItems)
                FileInfo(item.Text);
        }

        private void OpenFolder_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(tbDestFilePath.Text))
            {
                try
                {
                    System.Diagnostics.Process.Start(tbDestFilePath.Text);
                }
                catch
                {
                }
            }
        }

        private void PlayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listSoruceFiles.SelectedItems)
                PlayFile(item.Text);
        }

        private void PnlAudio_Click(object sender, EventArgs e)
        {
            TurnOffPanels();
            Tools.ShowPanel(btnAudioSet, pnlAudio, false, audioPanelHeight);
        }

        private void PnlVideo_Click(object sender, EventArgs e)
        {
            TurnOffPanels();
            Tools.ShowPanel(btnVideoSet, pnlVideo, false, videoPanelHeight);
        }

        private void RbAudio_Click(object sender, EventArgs e)
        {
            TurnAudio();
        }

        private void RbVideo_Click(object sender, EventArgs e)
        {
            TurnVideo();
        }

        private void TurnOffPanels()
        {
            if (pnlAudio.Visible)
                Tools.ShowPanel(btnAudioSet, pnlAudio, false, audioPanelHeight);
            if (pnlVideo.Visible)
                Tools.ShowPanel(btnVideoSet, pnlVideo, false, videoPanelHeight);
        }

        private void Main_MouseClick(object sender, MouseEventArgs e)
        {
            TurnOffPanels();
        }

        #endregion Private Methods
    }
}