using SevenConverter.Utils;
using System;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace SevenConverter
{
    public partial class Main : Form
    {
        #region Private Methods

        private readonly string[] AudioFormats =
        {
            "MP3",
            "OGG",
            "FLAC",
            "WAV"
        };

        private bool ConvertAudio(string sourceFile, string destFile, bool quoted = true)
        {
            bool result = false;
            if (!String.IsNullOrEmpty(destFile))
            {
                string dest_path = Path.GetDirectoryName(destFile);
                if (Directory.Exists(dest_path))
                {
                    StringBuilder command = new StringBuilder();
                    command.AppendFormat("-i {0} -y -v info",
                        quoted ? String.Concat("\"", sourceFile, "\"") : sourceFile);

                    if (cbFormat.SelectedIndex == 1)
                        command.Append(" -acodec libvorbis");

                    if (cbFormat.SelectedIndex == 0 || cbFormat.SelectedIndex == 1)
                        command.AppendFormat(" -ab {0} -ar {1}", cbQuality.Text, cbFreq.Text);

                    command.AppendFormat(" -threads 0 \"{0}\"", destFile);

                    result = Execute.RunApp(
                        String.Concat("\"", Path.Combine(ffmpeg_path, Files.FFmpeg_Exe_Name), "\""),
                        command.ToString());
                }
                else
                    MessageBox.Show(String.Format(Properties.strings.FolderDoesNotExistParam, dest_path));
            }
            return result;
        }

        private void TurnAudio()
        {
            openFileDialog.Filter = Properties.strings.AudioFileFilter;

            cbFormat.Items.Clear();
            foreach (string s in AudioFormats)
            {
                cbFormat.Items.Add(s);
            }

            if (cbFormat.Items.Count > 0)
                cbFormat.SelectedIndex = 0;

            cbVideoCodec.Visible = false;
            lblVideoCodec.Visible = false;
            lblAudioCodec.Visible = false;
            cbAudioCodec.Visible = false;
            cbTrack.Visible = false;
            lblAudioTrack.Visible = false;
            cbBitrate.Visible = false;
            label12.Visible = false;

            btnAudioSet.Top = cbFormat.Top;
            btnVideoSet.Visible = false;

            TurnOffPanels();
        }

        #endregion Private Methods
    }
}