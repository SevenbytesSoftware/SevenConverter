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

        private void PlayFile(string path)
        {
            if (File.Exists(path))
            {
                using (RunForm runForm = new RunForm())
                {
                    runForm.Text = Properties.strings.Play;
                    runForm.Command = String.Concat("\"", Path.Combine(ffmpeg_path, Files.FFplay_Exe_Name), "\"");
                    runForm.Args = String.Concat(" -autoexit -i \"", path, "\"");
                    runForm.ShowDialog();
                }
            }
        }

        #endregion Private Methods
    }
}