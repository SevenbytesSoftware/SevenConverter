using System;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SevenConverter.Forms
{
    public partial class RunForm : Form
    {
        #region Public Constructors

        public RunForm()
        {
            InitializeComponent();
            tbConsole.Clear();
            app = new Process();
            ErrorState = false;
            Pause = false;
        }

        #endregion Public Constructors

        #region Public Properties

        public string Args { get; set; }
        public string Command { get; set; }
        public bool ErrorState { get; set; }
        public bool Pause { get; set; }

        #endregion Public Properties

        #region Public Methods

        public void Start()
        {
            if (!String.IsNullOrEmpty(Command))
            {
                app.StartInfo.FileName = Command;
                app.StartInfo.Arguments = Args;
                app.StartInfo.UseShellExecute = false;
                app.StartInfo.CreateNoWindow = true;
                app.StartInfo.RedirectStandardError = true;
                app.StartInfo.RedirectStandardOutput = true;

                app.EnableRaisingEvents = true;
                app.OutputDataReceived += App_OutputDataReceived;
                app.ErrorDataReceived += App_OutputDataReceived;
                app.Exited += App_Exited;

                app.Start();

                app.BeginOutputReadLine();
                app.BeginErrorReadLine();
            }
        }

        #endregion Public Methods

        #region Private Fields

        private Process app;

        #endregion Private Fields

        #region Private Methods

        private void App_Exited(object sender, EventArgs e)
        {
            if (app != null)
                ErrorState = app.ExitCode != 0;

            Action close = () =>
            {
                if (!ErrorState && !Pause)
                {
                    this.Close();
                }
                else
                {
                    btnStop.Text = Properties.strings.Close;
                    if (ErrorState)
                        tbConsole.ForeColor = Color.Red;
                }
            };

            BeginInvoke(close);
        }

        private void App_OutputDataReceived(object sender, DataReceivedEventArgs e)
        {
            if (e.Data != null)
            {
                DoUpdateConsole(e.Data);
            }
        }

        private void AppendLog(string line)
        {
            byte[] bufLine = Encoding.Default.GetBytes(line);
            string utfString = Encoding.UTF8.GetString(bufLine);

            tbConsole.AppendText(String.Concat(utfString, "\r\n"));
        }

        private void DoUpdateConsole(string line)
        {
            Action action = () => AppendLog(line);

            if (InvokeRequired)
                BeginInvoke(action);
            else
                action();
        }

        private void RunForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!String.IsNullOrEmpty(app.StartInfo.FileName) && !app.HasExited)
            {
                app.Kill();
                app.WaitForExit();
            }
            app.Dispose();
            app = null;
        }

        private void RunForm_Shown(object sender, EventArgs e)
        {
            Start();
        }

        #endregion Private Methods
    }
}