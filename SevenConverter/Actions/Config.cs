using SevenConverter.Utils;
using System;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace SevenConverter
{
    public partial class Main : Form
    {
        #region Private Methods

        private void LoadConfig()
        {
            currentPath = Path.GetDirectoryName(Application.ExecutablePath);
            ffmpeg_path = Path.Combine(currentPath, Files.FFmpeg_Dir_Name);
            if (!File.Exists(Path.Combine(ffmpeg_path, Files.FFmpeg_Exe_Name)))
                ffmpeg_path = Path.Combine(Path.Combine(currentPath, "..\\.."), Files.FFmpeg_Dir_Name);
            if (!File.Exists(Path.Combine(ffmpeg_path, Files.FFmpeg_Exe_Name)))
                ffmpeg_path = Path.Combine(Path.Combine(currentPath, "..\\..\\.."), Files.FFmpeg_Dir_Name);
            if (!File.Exists(Path.Combine(ffmpeg_path, Files.FFmpeg_Exe_Name)))
            {
                MessageBox.Show(Properties.strings.FFMPEGNotFound);
                btnStart.Enabled = false;
            }
            config_path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), Files.Config_Folder);
            if (File.Exists(Path.Combine(config_path, Files.Config_Filename)))
            {
                try
                {
                    using (FileStream file = new FileStream(Path.Combine(config_path, Files.Config_Filename), FileMode.Open))
                    {
                        XmlSerializer xml = new XmlSerializer(typeof(Settings));
                        settings = xml.Deserialize(file) as Settings;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error loading config file: {ex.Message}. A new default config will be created.");
                    settings = new Settings();
                }
            }
            else
                settings = new Settings();

            rbVideo.Checked = true;
            TurnVideo();
        }

        private void SaveConfig()
        {
            settings.outputAudioCodec = cbAudioCodec.SelectedIndex;
            settings.outputVideoCodec = cbVideoCodec.SelectedIndex;
            settings.outputVideoFormat = cbFormat.SelectedIndex;
            settings.outputAudioFreq = cbFreq.Text;
            settings.outputAudioQuality = cbQuality.Text;

            if (!Directory.Exists(config_path))
                Directory.CreateDirectory(config_path);
            using (FileStream file = new FileStream(Path.Combine(config_path, Files.Config_Filename), FileMode.Create))
            {
                XmlSerializer xml = new XmlSerializer(typeof(Settings));
                xml.Serialize(file, settings);
            }
        }

        #endregion Private Methods
    }
}
