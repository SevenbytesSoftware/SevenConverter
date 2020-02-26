using System;
using System.Collections;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace SevenConverter.Utils
{
    public static class Files
    {
        public const string Config_Filename = "sc_config.xml";
        public const string Config_Folder = "SevenConverter";
        public const string FFmpeg_Dir_Name = "ffmpeg";
        public const string FFmpeg_Exe_Name = @"bin\ffmpeg.exe";
        public const string FFplay_Exe_Name = @"bin\ffplay.exe";
        public const string FFprobe_Exe_Name = @"bin\ffprobe.exe";

        public static string GetConcatFileNames(IList items)
        {
            StringBuilder input = new StringBuilder("concat:\"");
            foreach (ListViewItem item in items)
            {
                input.Append(item.Text).Append("|");
            }
            input.Append("\"");

            return input.ToString();
        }

        public static string OfferDstFileName(string source_filename, string dest_path, string format)
        {
            string result = String.Empty;
            if (!String.IsNullOrEmpty(source_filename))
            {
                string filename_wo_ext = Path.GetFileNameWithoutExtension(source_filename);
                string extension = String.Concat(".", format);

                result = Path.Combine(dest_path, String.Concat(filename_wo_ext, extension));
                int i = 1;
                while (File.Exists(result))
                {
                    result = Path.Combine(
                        dest_path,
                        String.Concat(filename_wo_ext, "_", (i++).ToString(), extension)
                        );
                }
            }
            return result;
        }
    }
}