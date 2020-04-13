using SevenConverter.Forms;
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

        private readonly string[] bitRate =
        {
            " -b:v 2M -minrate 2M -maxrate 2M -bufsize 2M",
            " -b:v 5M -minrate 5M -maxrate 5M -bufsize 2M",
            " -b:v 8M -minrate 8M -maxrate 8M -bufsize 2M",
            " -b:v 10M -minrate 10M -maxrate 10M -bufsize 2M",
            " -b:v 10M -minrate 10M -maxrate 20M -bufsize 2M",
            " -b:v 20M -minrate 20M -maxrate 40M -bufsize 2M",
            " -b:v 40M -minrate 40M -maxrate 80M -bufsize 2M"
        };

        private readonly string[] interlaced =
        {
            " -deinterlace",
            " -flags ildct+ilme -top 0",
            " -flags ildct+ilme -top 1"
        };

        private readonly string[] videoCodec =
        {
            "copy",
            "mjpeg -qmin 1 -qmax 1",
            "libx264",
            "h264_nvenc -global_quality 25",
            "h264_qsv -global_quality 25",
            "libx265",
            "libxvid",
            "mpeg2video"
        };

        private readonly string[] VideoFormats =
        {
            "AVI",
            "MOV",
            "MKV",
            "TS",
            "MP4"
        };

        private bool ConvertVideo(string sourceFile, string destFile, bool quoted = true)
        {
            bool result = false;
            if (!String.IsNullOrEmpty(destFile))
            {
                string dest_path = Path.GetDirectoryName(destFile);
                if (Directory.Exists(dest_path))
                {
                    StringBuilder command = new StringBuilder();
                    // input file and video codec
                    command.AppendFormat("-hwaccel auto -i {0} -y -v error -vcodec {1}",
                        quoted ? String.Concat("\"", sourceFile, "\"") : sourceFile,
                        videoCodec[cbVideoCodec.SelectedIndex]);

                    // TS format
                    if (cbFormat.SelectedIndex == 3)
                    {
                        command.Append(" -f mpegts ");
                        // copy
                        if (cbVideoCodec.SelectedIndex == 0)
                        {
                            command.Append(" -bsf:v h264_mp4toannexb");
                        }
                    }

                    // framerate
                    if (cbFramerate.SelectedIndex > 0)
                    {
                        command.Append(" -r ").Append(cbFramerate.Text);
                    }

                    // interlace
                    if (cbInterlaced.SelectedIndex > 0)
                    {
                        command.Append(interlaced[cbInterlaced.SelectedIndex - 1]);
                    }

                    // audio codec
                    switch (cbAudioCodec.SelectedIndex)
                    {
                        case 0:
                            command.Append(" -acodec copy");
                            break;

                        case 1:
                            command.AppendFormat(" -acodec libmp3lame -ab {0} -ar {1} -ac 2", cbQuality.Text, cbFreq.Text);
                            break;

                        case 2:
                            command.AppendFormat(" -acodec ac3 -ab {0} -ar {1}", cbQuality.Text, cbFreq.Text);
                            break;

                        case 3:
                            command.AppendFormat(" -acodec pcm_s16be -ar {0}", cbFreq.Text);
                            break;

                        default:
                            command.Append(" -an");
                            break;
                    }

                    // aspect
                    if (cbAspect.SelectedIndex > 0)
                    {
                        command.AppendFormat(" -aspect {0}", cbAspect.Text);
                    }

                    if (cbLines.SelectedIndex > 0 || cbHDR.SelectedIndex > 0)
                    {
                        string rows = String.Empty;
                        string delim = String.Empty;

                        // scale
                        if (cbLines.SelectedIndex > 0)
                        {
                            rows = String.Format("scale=-1:{0}", cbLines.Text);
                        }

                        string hdr = String.Empty;
                        if (cbHDR.SelectedIndex == 1)
                        {
                            if (cbLines.SelectedIndex > 0)
                                delim = ",";
                            hdr = "zscale=t=linear:npl=100,format=gbrpf32le,zscale=p=bt709,tonemap=tonemap=hable:desat=0,zscale=t=bt709:m=bt709:r=tv,format=yuv420p";
                        }

                        command.AppendFormat(" -vf {0}{1}{2}", rows, delim, hdr);
                    }

                    command.Append(GetAudioFilters());

                    // bitrate
                    if (cbBitrate.SelectedIndex > 0)
                    {
                        command.Append(bitRate[cbBitrate.SelectedIndex - 1]);
                    }

                    // select track
                    if (cbTrack.SelectedIndex > 0)
                    {
                        command.AppendFormat(" -map 0:v? -map 0:s? -map 0:a:{0}", (cbTrack.SelectedIndex - 1).ToString());
                    }
                    else
                    {
                        command.Append(" -map 0:v? -map 0:s? -map 0:a?");
                    }

                    // multithreads
                    command.AppendFormat(" -stats -scodec copy -threads 0 \"{0}\"", destFile);

                    // run ffmpeg
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

        private void TurnVideo()
        {
            openFileDialog.Filter = Properties.strings.VideoFileFilter;

            cbFormat.Items.Clear();
            foreach (string s in VideoFormats)
            {
                cbFormat.Items.Add(s);
            }

            cbVideoCodec.Visible = true;
            lblVideoCodec.Visible = true;
            lblAudioCodec.Visible = true;
            cbAudioCodec.Visible = true;

            lblAudioTrack.Visible = true;
            cbTrack.Visible = true;
            cbTrack.Items.Clear();
            cbTrack.Items.Add(Properties.strings.All);

            for (int i = 0; i < 10; i++)
            {
                cbTrack.Items.Add((i + 1).ToString());
            }
            cbTrack.SelectedIndex = 0;

            label12.Visible = true;
            cbBitrate.Visible = true;
            cbBitrate.SelectedIndex = 0;

            label1.Visible = true;
            cbHDR.Visible = true;
            cbHDR.SelectedIndex = 0;

            btnVideoSet.Visible = true;

            cbLoudness.SelectedIndex = 0;
            cbLowpass.SelectedIndex = 0;
            cbHighpass.SelectedIndex = 0;

            cbAudioCodec.SelectedIndex = settings.outputAudioCodec;
            cbVideoCodec.SelectedIndex = settings.outputVideoCodec;
            cbFormat.SelectedIndex = settings.outputVideoFormat;
            cbFreq.Text = "44100";
            cbQuality.Text = "320k";
            cbFramerate.SelectedIndex = 0;
            cbInterlaced.SelectedIndex = 0;

            cbLines.SelectedIndex = 0;
            cbAspect.SelectedIndex = 0;

            btnAudioSet.Top = cbAudioCodec.Top;

            TurnOffPanels();
        }

        #endregion Private Methods
    }
}