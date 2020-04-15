using SevenConverter.Utils;
using System;
using System.Diagnostics;
using System.Reflection;
using System.Windows.Forms;

namespace SevenConverter
{
    partial class About : Form
    {
        #region Public Constructors

        private const string latestURL = "https://github.com/SevenbytesSoftware/SevenConverter/releases/latest";
        private const string updateURL = "http://converter.sevenbytes.com/download/";

        public About()
        {
            InitializeComponent();
            this.Text = String.Format(Properties.strings.About, AssemblyTitle);
            this.labelVersion.Text = String.Format(Properties.strings.Version, AssemblyVersion);
            this.labelCopyright.Text = AssemblyCopyright;
        }

        #endregion Public Constructors

        #region Assembly Attribute Accessors

        public string AssemblyCompany
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCompanyAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyCompanyAttribute)attributes[0]).Company;
            }
        }

        public string AssemblyCopyright
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCopyrightAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyCopyrightAttribute)attributes[0]).Copyright;
            }
        }

        public string AssemblyDescription
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyDescriptionAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyDescriptionAttribute)attributes[0]).Description;
            }
        }

        public string AssemblyProduct
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyProductAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyProductAttribute)attributes[0]).Product;
            }
        }

        public string AssemblyTitle
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyTitleAttribute), false);
                if (attributes.Length > 0)
                {
                    AssemblyTitleAttribute titleAttribute = (AssemblyTitleAttribute)attributes[0];
                    if (!string.IsNullOrEmpty(titleAttribute.Title))
                    {
                        return titleAttribute.Title;
                    }
                }
                return System.IO.Path.GetFileNameWithoutExtension(Assembly.GetExecutingAssembly().CodeBase);
            }
        }

        public string AssemblyVersion
        {
            get
            {
                return Tools.GetProgramVersion();
            }
        }

        #endregion Assembly Attribute Accessors

        #region Private Methods

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(linkLabel1.Text);
        }

        #endregion Private Methods

        private void btnUpdates_Click(object sender, EventArgs e)
        {
            Update update = new Update(latestURL);
            bool checkResult = false;
            try
            {
                try
                {
                    this.Cursor = Cursors.WaitCursor;
                    checkResult = update.Check(
                        AssemblyVersion.Substring(0, AssemblyVersion.LastIndexOf('.')));
                }
                finally
                {
                    this.Cursor = Cursors.Default;
                }

                if (checkResult)
                {
                    MessageBox.Show(
                        Properties.strings.SevenConverterIsUpToDate,
                        Properties.strings.UpToDate,
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                else
                {
                    if (MessageBox.Show(
                        String.Format(Properties.strings.SevenConverterIsAvailable, update.AvailableVersion),
                        String.Format(Properties.strings.NewVersionIsAvailable, update.AvailableVersion),
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Information,
                        MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                    {
                        Process.Start(updateURL);
                    }
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
    }
}