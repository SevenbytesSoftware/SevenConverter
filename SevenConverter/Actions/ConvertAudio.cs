using SevenConverter.Forms;
using SevenConverter.Utils;
using System;
using System.Collections.Generic;
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

        private readonly string[] LoudnessTypes =
        {
            //US Broadcast (ATSC A/A85)
            "loudnorm=I=-24:TP=-2:LRA=7",
            //EU Broadcast (EBU R128)
            "loudnorm=I=-23:TP=-1.5:LRA=16",
            //Podcasts
            "loudnorm=I=-10:TP=-0:LRA=16",
            //Dynamic
            "dynaudnorm"
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

                    command.Append(GetAudioFilters());

                    if (cbFormat.SelectedIndex == 0 || cbFormat.SelectedIndex == 1)
                        command.AppendFormat(" -ab {0} -ar {1}", cbQuality.Text, cbFreq.Text);

                    command.AppendFormat(" -threads 0 \"{0}\"", destFile);

                    using (RunForm runForm = new RunForm())
                    {
                        runForm.Command = String.Concat("\"", Path.Combine(ffmpeg_path, Files.FFmpeg_Exe_Name), "\"");
                        runForm.Args = command.ToString();
                        runForm.ShowDialog();
                        result = !runForm.ErrorState;
                    }
                }
                else
                    MessageBox.Show(String.Format(Properties.strings.FolderDoesNotExistParam, dest_path));
            }
            return result;
        }

        private string GetAudioFilters()
        {
            List<string> filters = new List<string>();

            if (cbLoudness.SelectedIndex > 0)
            {
                filters.Add(LoudnessTypes[cbLoudness.SelectedIndex - 1]);
            }

            if (cbLowpass.SelectedIndex > 0)
            {
                filters.Add(String.Concat("lowpass=", cbLowpass.Text));
            }

            if (cbHighpass.SelectedIndex > 0)
            {
                filters.Add(String.Concat("highpass=", cbHighpass.Text));
            }

            if (filters.Count > 0)
                return String.Concat(" -af \"", String.Join(",", filters), "\"");
            else
                return String.Empty;
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

            label1.Visible = false;
            cbHDR.Visible = false;

            TurnOffPanels();
        }

        #endregion Private Methods
    }
}