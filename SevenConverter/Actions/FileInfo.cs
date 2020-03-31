using SevenConverter.Forms;
using SevenConverter.Utils;
using System;
using System.IO;
using System.Windows.Forms;

namespace SevenConverter
{
    public partial class Main : Form
    {
        #region Private Methods

        private void FileInfo(string path)
        {
            if (File.Exists(path))
            {
                using (RunForm runForm = new RunForm())
                {
                    runForm.Text = Properties.strings.FileInformation;
                    runForm.Pause = true;
                    runForm.Command = String.Concat("\"",
                        Path.Combine(ffmpeg_path, Files.FFprobe_Exe_Name), "\"");
                    runForm.Args = String.Concat(" -hide_banner -loglevel fatal -pretty -show_format -show_streams -show_entries stream=codec_type,r_frame_rate,width,height,sample_aspect_ratio:stream_disposition=:format_tags=timecode,company_name,product_name,product_version -i \"", path, "\"");
                    runForm.ShowDialog();
                }
            }
        }

        #endregion Private Methods
    }
}