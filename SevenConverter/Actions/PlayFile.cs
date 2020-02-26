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
                Execute.RunApp(String.Concat("\"", Path.Combine(ffmpeg_path, Files.FFplay_Exe_Name), "\""),
                    String.Concat(" -autoexit -i \"", path, "\""));
        }

        #endregion Private Methods
    }
}