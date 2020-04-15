namespace SevenConverter
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.tbDestFilePath = new System.Windows.Forms.TextBox();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.cbVideoCodec = new System.Windows.Forms.ComboBox();
            this.lblVideoCodec = new System.Windows.Forms.Label();
            this.lblAudioCodec = new System.Windows.Forms.Label();
            this.cbAudioCodec = new System.Windows.Forms.ComboBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.contextMenuFile = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuItemAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.menuItemInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.playToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuItemDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemDeleteAll = new System.Windows.Forms.ToolStripMenuItem();
            this.imageListButtons = new System.Windows.Forms.ImageList(this.components);
            this.lblFolder = new System.Windows.Forms.Label();
            this.rbVideo = new System.Windows.Forms.RadioButton();
            this.rbAudio = new System.Windows.Forms.RadioButton();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.cbQuality = new System.Windows.Forms.ComboBox();
            this.cbFreq = new System.Windows.Forms.ComboBox();
            this.cbJoin = new System.Windows.Forms.CheckBox();
            this.pnlAudio = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.cbLowpass = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbHighpass = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbLoudness = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlVideo = new System.Windows.Forms.Panel();
            this.cbHDR = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbBitrate = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cbInterlaced = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cbFramerate = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cbLines = new System.Windows.Forms.ComboBox();
            this.cbAspect = new System.Windows.Forms.ComboBox();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblOutputFormat = new System.Windows.Forms.Label();
            this.cbFormat = new System.Windows.Forms.ComboBox();
            this.cbTrack = new System.Windows.Forms.ComboBox();
            this.lblAudioTrack = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnVideoSet = new System.Windows.Forms.Button();
            this.btnAudioSet = new System.Windows.Forms.Button();
            this.btnOpenFolder = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnFolder = new System.Windows.Forms.Button();
            this.listSoruceFiles = new System.Windows.Forms.ListView();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnAbout = new System.Windows.Forms.Button();
            this.btnGIF = new System.Windows.Forms.Button();
            this.pnlGIF = new System.Windows.Forms.Panel();
            this.tbGIFWidth = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.tbGIFFPS = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tbGIFDuration = new System.Windows.Forms.TextBox();
            this.tbGIFStart = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.contextMenuFile.SuspendLayout();
            this.pnlAudio.SuspendLayout();
            this.pnlVideo.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.pnlGIF.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbDestFilePath
            // 
            resources.ApplyResources(this.tbDestFilePath, "tbDestFilePath");
            this.tbDestFilePath.Name = "tbDestFilePath";
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "video-x-generic.ico");
            this.imageList.Images.SetKeyName(1, "edit-add-2.ico");
            this.imageList.Images.SetKeyName(2, "arrow-right-double-3.ico");
            this.imageList.Images.SetKeyName(3, "go-next-8.ico");
            this.imageList.Images.SetKeyName(4, "edit-redo-2.ico");
            this.imageList.Images.SetKeyName(5, "runit.ico");
            this.imageList.Images.SetKeyName(6, "dialog-cancel-2.ico");
            this.imageList.Images.SetKeyName(7, "icons8-plus-32.png");
            this.imageList.Images.SetKeyName(8, "icons8-down-right-30.png");
            // 
            // cbVideoCodec
            // 
            resources.ApplyResources(this.cbVideoCodec, "cbVideoCodec");
            this.cbVideoCodec.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbVideoCodec.FormattingEnabled = true;
            this.cbVideoCodec.Items.AddRange(new object[] {
            resources.GetString("cbVideoCodec.Items"),
            resources.GetString("cbVideoCodec.Items1"),
            resources.GetString("cbVideoCodec.Items2"),
            resources.GetString("cbVideoCodec.Items3"),
            resources.GetString("cbVideoCodec.Items4"),
            resources.GetString("cbVideoCodec.Items5"),
            resources.GetString("cbVideoCodec.Items6"),
            resources.GetString("cbVideoCodec.Items7")});
            this.cbVideoCodec.Name = "cbVideoCodec";
            this.cbVideoCodec.SelectedIndexChanged += new System.EventHandler(this.CbVideoCodec_SelectedIndexChanged);
            // 
            // lblVideoCodec
            // 
            resources.ApplyResources(this.lblVideoCodec, "lblVideoCodec");
            this.lblVideoCodec.Name = "lblVideoCodec";
            // 
            // lblAudioCodec
            // 
            resources.ApplyResources(this.lblAudioCodec, "lblAudioCodec");
            this.lblAudioCodec.Name = "lblAudioCodec";
            // 
            // cbAudioCodec
            // 
            resources.ApplyResources(this.cbAudioCodec, "cbAudioCodec");
            this.cbAudioCodec.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAudioCodec.FormattingEnabled = true;
            this.cbAudioCodec.Items.AddRange(new object[] {
            resources.GetString("cbAudioCodec.Items"),
            resources.GetString("cbAudioCodec.Items1"),
            resources.GetString("cbAudioCodec.Items2"),
            resources.GetString("cbAudioCodec.Items3"),
            resources.GetString("cbAudioCodec.Items4")});
            this.cbAudioCodec.Name = "cbAudioCodec";
            this.cbAudioCodec.SelectedIndexChanged += new System.EventHandler(this.CbAudioCodec_SelectedIndexChanged);
            // 
            // contextMenuFile
            // 
            this.contextMenuFile.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemAdd,
            this.toolStripSeparator2,
            this.menuItemInfo,
            this.playToolStripMenuItem,
            this.toolStripSeparator1,
            this.menuItemDelete,
            this.menuItemDeleteAll});
            this.contextMenuFile.Name = "contextMenuFile";
            resources.ApplyResources(this.contextMenuFile, "contextMenuFile");
            this.contextMenuFile.Opened += new System.EventHandler(this.ContextMenuFile_Opened);
            // 
            // menuItemAdd
            // 
            this.menuItemAdd.Name = "menuItemAdd";
            resources.ApplyResources(this.menuItemAdd, "menuItemAdd");
            this.menuItemAdd.Click += new System.EventHandler(this.MenuItemAdd_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            resources.ApplyResources(this.toolStripSeparator2, "toolStripSeparator2");
            // 
            // menuItemInfo
            // 
            this.menuItemInfo.Name = "menuItemInfo";
            resources.ApplyResources(this.menuItemInfo, "menuItemInfo");
            this.menuItemInfo.Click += new System.EventHandler(this.MenuItemInfo_Click);
            // 
            // playToolStripMenuItem
            // 
            this.playToolStripMenuItem.Name = "playToolStripMenuItem";
            resources.ApplyResources(this.playToolStripMenuItem, "playToolStripMenuItem");
            this.playToolStripMenuItem.Click += new System.EventHandler(this.PlayToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            resources.ApplyResources(this.toolStripSeparator1, "toolStripSeparator1");
            // 
            // menuItemDelete
            // 
            this.menuItemDelete.Name = "menuItemDelete";
            resources.ApplyResources(this.menuItemDelete, "menuItemDelete");
            this.menuItemDelete.Click += new System.EventHandler(this.DeleteSelected);
            // 
            // menuItemDeleteAll
            // 
            this.menuItemDeleteAll.Name = "menuItemDeleteAll";
            resources.ApplyResources(this.menuItemDeleteAll, "menuItemDeleteAll");
            this.menuItemDeleteAll.Click += new System.EventHandler(this.DeleteAll);
            // 
            // imageListButtons
            // 
            this.imageListButtons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListButtons.ImageStream")));
            this.imageListButtons.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListButtons.Images.SetKeyName(0, "applications-system-2.ico");
            this.imageListButtons.Images.SetKeyName(1, "go-home-8.ico");
            this.imageListButtons.Images.SetKeyName(2, "folder-new-7.ico");
            this.imageListButtons.Images.SetKeyName(3, "icons8-gear-16.png");
            // 
            // lblFolder
            // 
            resources.ApplyResources(this.lblFolder, "lblFolder");
            this.lblFolder.Name = "lblFolder";
            // 
            // rbVideo
            // 
            resources.ApplyResources(this.rbVideo, "rbVideo");
            this.rbVideo.Checked = true;
            this.rbVideo.Name = "rbVideo";
            this.rbVideo.TabStop = true;
            this.toolTip1.SetToolTip(this.rbVideo, resources.GetString("rbVideo.ToolTip"));
            this.rbVideo.UseVisualStyleBackColor = true;
            this.rbVideo.Click += new System.EventHandler(this.RbVideo_Click);
            // 
            // rbAudio
            // 
            resources.ApplyResources(this.rbAudio, "rbAudio");
            this.rbAudio.Name = "rbAudio";
            this.toolTip1.SetToolTip(this.rbAudio, resources.GetString("rbAudio.ToolTip"));
            this.rbAudio.UseVisualStyleBackColor = true;
            this.rbAudio.Click += new System.EventHandler(this.RbAudio_Click);
            // 
            // cbQuality
            // 
            resources.ApplyResources(this.cbQuality, "cbQuality");
            this.cbQuality.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbQuality.FormattingEnabled = true;
            this.cbQuality.Items.AddRange(new object[] {
            resources.GetString("cbQuality.Items"),
            resources.GetString("cbQuality.Items1"),
            resources.GetString("cbQuality.Items2"),
            resources.GetString("cbQuality.Items3")});
            this.cbQuality.Name = "cbQuality";
            // 
            // cbFreq
            // 
            resources.ApplyResources(this.cbFreq, "cbFreq");
            this.cbFreq.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFreq.FormattingEnabled = true;
            this.cbFreq.Items.AddRange(new object[] {
            resources.GetString("cbFreq.Items"),
            resources.GetString("cbFreq.Items1"),
            resources.GetString("cbFreq.Items2"),
            resources.GetString("cbFreq.Items3")});
            this.cbFreq.Name = "cbFreq";
            // 
            // cbJoin
            // 
            resources.ApplyResources(this.cbJoin, "cbJoin");
            this.cbJoin.Name = "cbJoin";
            this.toolTip1.SetToolTip(this.cbJoin, resources.GetString("cbJoin.ToolTip"));
            this.cbJoin.UseVisualStyleBackColor = true;
            // 
            // pnlAudio
            // 
            this.pnlAudio.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnlAudio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlAudio.Controls.Add(this.label5);
            this.pnlAudio.Controls.Add(this.cbLowpass);
            this.pnlAudio.Controls.Add(this.label4);
            this.pnlAudio.Controls.Add(this.cbHighpass);
            this.pnlAudio.Controls.Add(this.label3);
            this.pnlAudio.Controls.Add(this.cbLoudness);
            this.pnlAudio.Controls.Add(this.label6);
            this.pnlAudio.Controls.Add(this.label2);
            this.pnlAudio.Controls.Add(this.cbFreq);
            this.pnlAudio.Controls.Add(this.cbQuality);
            resources.ApplyResources(this.pnlAudio, "pnlAudio");
            this.pnlAudio.Name = "pnlAudio";
            this.pnlAudio.Click += new System.EventHandler(this.PnlAudio_Click);
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // cbLowpass
            // 
            resources.ApplyResources(this.cbLowpass, "cbLowpass");
            this.cbLowpass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLowpass.FormattingEnabled = true;
            this.cbLowpass.Items.AddRange(new object[] {
            resources.GetString("cbLowpass.Items"),
            resources.GetString("cbLowpass.Items1"),
            resources.GetString("cbLowpass.Items2"),
            resources.GetString("cbLowpass.Items3"),
            resources.GetString("cbLowpass.Items4"),
            resources.GetString("cbLowpass.Items5"),
            resources.GetString("cbLowpass.Items6"),
            resources.GetString("cbLowpass.Items7"),
            resources.GetString("cbLowpass.Items8"),
            resources.GetString("cbLowpass.Items9")});
            this.cbLowpass.Name = "cbLowpass";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // cbHighpass
            // 
            resources.ApplyResources(this.cbHighpass, "cbHighpass");
            this.cbHighpass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbHighpass.FormattingEnabled = true;
            this.cbHighpass.Items.AddRange(new object[] {
            resources.GetString("cbHighpass.Items"),
            resources.GetString("cbHighpass.Items1"),
            resources.GetString("cbHighpass.Items2"),
            resources.GetString("cbHighpass.Items3"),
            resources.GetString("cbHighpass.Items4"),
            resources.GetString("cbHighpass.Items5"),
            resources.GetString("cbHighpass.Items6"),
            resources.GetString("cbHighpass.Items7"),
            resources.GetString("cbHighpass.Items8")});
            this.cbHighpass.Name = "cbHighpass";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // cbLoudness
            // 
            resources.ApplyResources(this.cbLoudness, "cbLoudness");
            this.cbLoudness.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLoudness.FormattingEnabled = true;
            this.cbLoudness.Items.AddRange(new object[] {
            resources.GetString("cbLoudness.Items"),
            resources.GetString("cbLoudness.Items1"),
            resources.GetString("cbLoudness.Items2"),
            resources.GetString("cbLoudness.Items3"),
            resources.GetString("cbLoudness.Items4")});
            this.cbLoudness.Name = "cbLoudness";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            this.label6.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Main_MouseClick);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            this.label2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Main_MouseClick);
            // 
            // pnlVideo
            // 
            this.pnlVideo.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnlVideo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlVideo.Controls.Add(this.cbHDR);
            this.pnlVideo.Controls.Add(this.label1);
            this.pnlVideo.Controls.Add(this.cbBitrate);
            this.pnlVideo.Controls.Add(this.label12);
            this.pnlVideo.Controls.Add(this.label10);
            this.pnlVideo.Controls.Add(this.cbInterlaced);
            this.pnlVideo.Controls.Add(this.label9);
            this.pnlVideo.Controls.Add(this.cbFramerate);
            this.pnlVideo.Controls.Add(this.label7);
            this.pnlVideo.Controls.Add(this.label8);
            this.pnlVideo.Controls.Add(this.cbLines);
            this.pnlVideo.Controls.Add(this.cbAspect);
            resources.ApplyResources(this.pnlVideo, "pnlVideo");
            this.pnlVideo.Name = "pnlVideo";
            this.pnlVideo.Click += new System.EventHandler(this.PnlVideo_Click);
            // 
            // cbHDR
            // 
            this.cbHDR.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbHDR.FormattingEnabled = true;
            this.cbHDR.Items.AddRange(new object[] {
            resources.GetString("cbHDR.Items"),
            resources.GetString("cbHDR.Items1")});
            resources.ApplyResources(this.cbHDR, "cbHDR");
            this.cbHDR.Name = "cbHDR";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // cbBitrate
            // 
            this.cbBitrate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBitrate.FormattingEnabled = true;
            this.cbBitrate.Items.AddRange(new object[] {
            resources.GetString("cbBitrate.Items"),
            resources.GetString("cbBitrate.Items1"),
            resources.GetString("cbBitrate.Items2"),
            resources.GetString("cbBitrate.Items3"),
            resources.GetString("cbBitrate.Items4"),
            resources.GetString("cbBitrate.Items5"),
            resources.GetString("cbBitrate.Items6"),
            resources.GetString("cbBitrate.Items7")});
            resources.ApplyResources(this.cbBitrate, "cbBitrate");
            this.cbBitrate.Name = "cbBitrate";
            // 
            // label12
            // 
            resources.ApplyResources(this.label12, "label12");
            this.label12.Name = "label12";
            this.label12.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Main_MouseClick);
            // 
            // label10
            // 
            resources.ApplyResources(this.label10, "label10");
            this.label10.Name = "label10";
            this.label10.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Main_MouseClick);
            // 
            // cbInterlaced
            // 
            resources.ApplyResources(this.cbInterlaced, "cbInterlaced");
            this.cbInterlaced.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbInterlaced.FormattingEnabled = true;
            this.cbInterlaced.Items.AddRange(new object[] {
            resources.GetString("cbInterlaced.Items"),
            resources.GetString("cbInterlaced.Items1"),
            resources.GetString("cbInterlaced.Items2"),
            resources.GetString("cbInterlaced.Items3")});
            this.cbInterlaced.Name = "cbInterlaced";
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.Name = "label9";
            this.label9.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Main_MouseClick);
            // 
            // cbFramerate
            // 
            resources.ApplyResources(this.cbFramerate, "cbFramerate");
            this.cbFramerate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFramerate.FormattingEnabled = true;
            this.cbFramerate.Items.AddRange(new object[] {
            resources.GetString("cbFramerate.Items"),
            resources.GetString("cbFramerate.Items1"),
            resources.GetString("cbFramerate.Items2"),
            resources.GetString("cbFramerate.Items3"),
            resources.GetString("cbFramerate.Items4"),
            resources.GetString("cbFramerate.Items5"),
            resources.GetString("cbFramerate.Items6"),
            resources.GetString("cbFramerate.Items7"),
            resources.GetString("cbFramerate.Items8"),
            resources.GetString("cbFramerate.Items9"),
            resources.GetString("cbFramerate.Items10"),
            resources.GetString("cbFramerate.Items11")});
            this.cbFramerate.Name = "cbFramerate";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            this.label7.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Main_MouseClick);
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            this.label8.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Main_MouseClick);
            // 
            // cbLines
            // 
            resources.ApplyResources(this.cbLines, "cbLines");
            this.cbLines.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLines.FormattingEnabled = true;
            this.cbLines.Items.AddRange(new object[] {
            resources.GetString("cbLines.Items"),
            resources.GetString("cbLines.Items1"),
            resources.GetString("cbLines.Items2"),
            resources.GetString("cbLines.Items3"),
            resources.GetString("cbLines.Items4")});
            this.cbLines.Name = "cbLines";
            // 
            // cbAspect
            // 
            resources.ApplyResources(this.cbAspect, "cbAspect");
            this.cbAspect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAspect.FormattingEnabled = true;
            this.cbAspect.Items.AddRange(new object[] {
            resources.GetString("cbAspect.Items"),
            resources.GetString("cbAspect.Items1"),
            resources.GetString("cbAspect.Items2"),
            resources.GetString("cbAspect.Items3"),
            resources.GetString("cbAspect.Items4"),
            resources.GetString("cbAspect.Items5"),
            resources.GetString("cbAspect.Items6"),
            resources.GetString("cbAspect.Items7"),
            resources.GetString("cbAspect.Items8")});
            this.cbAspect.Name = "cbAspect";
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel});
            resources.ApplyResources(this.statusStrip, "statusStrip");
            this.statusStrip.Name = "statusStrip";
            // 
            // statusLabel
            // 
            this.statusLabel.Name = "statusLabel";
            resources.ApplyResources(this.statusLabel, "statusLabel");
            this.statusLabel.Spring = true;
            // 
            // lblOutputFormat
            // 
            resources.ApplyResources(this.lblOutputFormat, "lblOutputFormat");
            this.lblOutputFormat.Name = "lblOutputFormat";
            // 
            // cbFormat
            // 
            resources.ApplyResources(this.cbFormat, "cbFormat");
            this.cbFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFormat.FormattingEnabled = true;
            this.cbFormat.Items.AddRange(new object[] {
            resources.GetString("cbFormat.Items"),
            resources.GetString("cbFormat.Items1"),
            resources.GetString("cbFormat.Items2")});
            this.cbFormat.Name = "cbFormat";
            this.cbFormat.SelectedIndexChanged += new System.EventHandler(this.CbFormat_SelectedIndexChanged);
            // 
            // cbTrack
            // 
            resources.ApplyResources(this.cbTrack, "cbTrack");
            this.cbTrack.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTrack.FormattingEnabled = true;
            this.cbTrack.Items.AddRange(new object[] {
            resources.GetString("cbTrack.Items"),
            resources.GetString("cbTrack.Items1"),
            resources.GetString("cbTrack.Items2"),
            resources.GetString("cbTrack.Items3"),
            resources.GetString("cbTrack.Items4"),
            resources.GetString("cbTrack.Items5"),
            resources.GetString("cbTrack.Items6")});
            this.cbTrack.Name = "cbTrack";
            // 
            // lblAudioTrack
            // 
            resources.ApplyResources(this.lblAudioTrack, "lblAudioTrack");
            this.lblAudioTrack.Name = "lblAudioTrack";
            // 
            // btnAdd
            // 
            resources.ApplyResources(this.btnAdd, "btnAdd");
            this.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnAdd.ImageList = this.imageList;
            this.btnAdd.Name = "btnAdd";
            this.toolTip1.SetToolTip(this.btnAdd, resources.GetString("btnAdd.ToolTip"));
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // btnVideoSet
            // 
            resources.ApplyResources(this.btnVideoSet, "btnVideoSet");
            this.btnVideoSet.ImageList = this.imageListButtons;
            this.btnVideoSet.Name = "btnVideoSet";
            this.toolTip1.SetToolTip(this.btnVideoSet, resources.GetString("btnVideoSet.ToolTip"));
            this.btnVideoSet.UseVisualStyleBackColor = true;
            this.btnVideoSet.Click += new System.EventHandler(this.BtnVideoSet_Click);
            // 
            // btnAudioSet
            // 
            resources.ApplyResources(this.btnAudioSet, "btnAudioSet");
            this.btnAudioSet.ImageList = this.imageListButtons;
            this.btnAudioSet.Name = "btnAudioSet";
            this.toolTip1.SetToolTip(this.btnAudioSet, resources.GetString("btnAudioSet.ToolTip"));
            this.btnAudioSet.UseVisualStyleBackColor = true;
            this.btnAudioSet.Click += new System.EventHandler(this.BtnAudioSet_Click);
            // 
            // btnOpenFolder
            // 
            resources.ApplyResources(this.btnOpenFolder, "btnOpenFolder");
            this.btnOpenFolder.ImageList = this.imageListButtons;
            this.btnOpenFolder.Name = "btnOpenFolder";
            this.toolTip1.SetToolTip(this.btnOpenFolder, resources.GetString("btnOpenFolder.ToolTip"));
            this.btnOpenFolder.UseVisualStyleBackColor = true;
            this.btnOpenFolder.Click += new System.EventHandler(this.OpenFolder_Click);
            // 
            // btnStart
            // 
            resources.ApplyResources(this.btnStart, "btnStart");
            this.btnStart.ImageList = this.imageList;
            this.btnStart.Name = "btnStart";
            this.toolTip1.SetToolTip(this.btnStart, resources.GetString("btnStart.ToolTip"));
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // btnFolder
            // 
            resources.ApplyResources(this.btnFolder, "btnFolder");
            this.btnFolder.ImageList = this.imageListButtons;
            this.btnFolder.Name = "btnFolder";
            this.toolTip1.SetToolTip(this.btnFolder, resources.GetString("btnFolder.ToolTip"));
            this.btnFolder.UseVisualStyleBackColor = true;
            this.btnFolder.Click += new System.EventHandler(this.BtnFolder_Click);
            // 
            // listSoruceFiles
            // 
            this.listSoruceFiles.AllowDrop = true;
            resources.ApplyResources(this.listSoruceFiles, "listSoruceFiles");
            this.listSoruceFiles.BackgroundImageTiled = true;
            this.listSoruceFiles.ContextMenuStrip = this.contextMenuFile;
            this.listSoruceFiles.HideSelection = false;
            this.listSoruceFiles.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            ((System.Windows.Forms.ListViewItem)(resources.GetObject("listSoruceFiles.Items"))),
            ((System.Windows.Forms.ListViewItem)(resources.GetObject("listSoruceFiles.Items1"))),
            ((System.Windows.Forms.ListViewItem)(resources.GetObject("listSoruceFiles.Items2")))});
            this.listSoruceFiles.LargeImageList = this.imageList;
            this.listSoruceFiles.Name = "listSoruceFiles";
            this.listSoruceFiles.SmallImageList = this.imageList;
            this.listSoruceFiles.UseCompatibleStateImageBehavior = false;
            this.listSoruceFiles.DragDrop += new System.Windows.Forms.DragEventHandler(this.ListSoruceFiles_DragDrop);
            this.listSoruceFiles.DragEnter += new System.Windows.Forms.DragEventHandler(this.ListSoruceFiles_DragEnter);
            this.listSoruceFiles.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Main_MouseClick);
            // 
            // btnAbout
            // 
            resources.ApplyResources(this.btnAbout, "btnAbout");
            this.btnAbout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnAbout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAbout.FlatAppearance.BorderSize = 0;
            this.btnAbout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleTurquoise;
            this.btnAbout.Name = "btnAbout";
            this.toolTip1.SetToolTip(this.btnAbout, resources.GetString("btnAbout.ToolTip"));
            this.btnAbout.UseVisualStyleBackColor = false;
            this.btnAbout.Click += new System.EventHandler(this.BtnAbout_Click);
            // 
            // btnGIF
            // 
            resources.ApplyResources(this.btnGIF, "btnGIF");
            this.btnGIF.ImageList = this.imageListButtons;
            this.btnGIF.Name = "btnGIF";
            this.toolTip1.SetToolTip(this.btnGIF, resources.GetString("btnGIF.ToolTip"));
            this.btnGIF.UseVisualStyleBackColor = true;
            this.btnGIF.Click += new System.EventHandler(this.btnGIF_Click);
            // 
            // pnlGIF
            // 
            this.pnlGIF.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnlGIF.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlGIF.Controls.Add(this.tbGIFWidth);
            this.pnlGIF.Controls.Add(this.label13);
            this.pnlGIF.Controls.Add(this.tbGIFFPS);
            this.pnlGIF.Controls.Add(this.label11);
            this.pnlGIF.Controls.Add(this.tbGIFDuration);
            this.pnlGIF.Controls.Add(this.tbGIFStart);
            this.pnlGIF.Controls.Add(this.label14);
            this.pnlGIF.Controls.Add(this.label15);
            resources.ApplyResources(this.pnlGIF, "pnlGIF");
            this.pnlGIF.Name = "pnlGIF";
            this.pnlGIF.Click += new System.EventHandler(this.pnlGIF_Click);
            // 
            // tbGIFWidth
            // 
            resources.ApplyResources(this.tbGIFWidth, "tbGIFWidth");
            this.tbGIFWidth.Name = "tbGIFWidth";
            this.tbGIFWidth.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbGIFStart_KeyPress);
            // 
            // label13
            // 
            resources.ApplyResources(this.label13, "label13");
            this.label13.Name = "label13";
            // 
            // tbGIFFPS
            // 
            resources.ApplyResources(this.tbGIFFPS, "tbGIFFPS");
            this.tbGIFFPS.Name = "tbGIFFPS";
            this.tbGIFFPS.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbGIFStart_KeyPress);
            // 
            // label11
            // 
            resources.ApplyResources(this.label11, "label11");
            this.label11.Name = "label11";
            // 
            // tbGIFDuration
            // 
            resources.ApplyResources(this.tbGIFDuration, "tbGIFDuration");
            this.tbGIFDuration.Name = "tbGIFDuration";
            this.tbGIFDuration.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbGIFStart_KeyPress);
            // 
            // tbGIFStart
            // 
            resources.ApplyResources(this.tbGIFStart, "tbGIFStart");
            this.tbGIFStart.Name = "tbGIFStart";
            this.tbGIFStart.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbGIFStart_KeyPress);
            // 
            // label14
            // 
            resources.ApplyResources(this.label14, "label14");
            this.label14.Name = "label14";
            // 
            // label15
            // 
            resources.ApplyResources(this.label15, "label15");
            this.label15.Name = "label15";
            // 
            // Main
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlGIF);
            this.Controls.Add(this.btnGIF);
            this.Controls.Add(this.btnAbout);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnVideoSet);
            this.Controls.Add(this.btnAudioSet);
            this.Controls.Add(this.pnlVideo);
            this.Controls.Add(this.pnlAudio);
            this.Controls.Add(this.btnOpenFolder);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.rbVideo);
            this.Controls.Add(this.lblFolder);
            this.Controls.Add(this.btnFolder);
            this.Controls.Add(this.tbDestFilePath);
            this.Controls.Add(this.cbVideoCodec);
            this.Controls.Add(this.cbFormat);
            this.Controls.Add(this.rbAudio);
            this.Controls.Add(this.cbAudioCodec);
            this.Controls.Add(this.listSoruceFiles);
            this.Controls.Add(this.lblOutputFormat);
            this.Controls.Add(this.lblVideoCodec);
            this.Controls.Add(this.lblAudioCodec);
            this.Controls.Add(this.cbJoin);
            this.Controls.Add(this.cbTrack);
            this.Controls.Add(this.lblAudioTrack);
            this.KeyPreview = true;
            this.Name = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.Click += new System.EventHandler(this.Main_Click);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Main_MouseClick);
            this.contextMenuFile.ResumeLayout(false);
            this.pnlAudio.ResumeLayout(false);
            this.pnlAudio.PerformLayout();
            this.pnlVideo.ResumeLayout(false);
            this.pnlVideo.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.pnlGIF.ResumeLayout(false);
            this.pnlGIF.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbDestFilePath;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.ComboBox cbVideoCodec;
        private System.Windows.Forms.Label lblVideoCodec;
        private System.Windows.Forms.Label lblAudioCodec;
        private System.Windows.Forms.ComboBox cbAudioCodec;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.ListView listSoruceFiles;
        private System.Windows.Forms.ImageList imageList;
        private System.Windows.Forms.ContextMenuStrip contextMenuFile;
        private System.Windows.Forms.ToolStripMenuItem menuItemDelete;
        private System.Windows.Forms.ToolStripMenuItem menuItemAdd;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem menuItemDeleteAll;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem menuItemInfo;
        private System.Windows.Forms.Button btnFolder;
        private System.Windows.Forms.Label lblFolder;
        private System.Windows.Forms.RadioButton rbVideo;
        private System.Windows.Forms.RadioButton rbAudio;
        private System.Windows.Forms.Button btnOpenFolder;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.ComboBox cbQuality;
        private System.Windows.Forms.ComboBox cbFreq;
        private System.Windows.Forms.ToolStripMenuItem playToolStripMenuItem;
        private System.Windows.Forms.CheckBox cbJoin;
        private System.Windows.Forms.Panel pnlAudio;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAudioSet;
        private System.Windows.Forms.Button btnVideoSet;
        private System.Windows.Forms.Panel pnlVideo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbLines;
        private System.Windows.Forms.ComboBox cbAspect;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ImageList imageListButtons;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbInterlaced;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbFramerate;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel;
        private System.Windows.Forms.Label lblOutputFormat;
        private System.Windows.Forms.ComboBox cbFormat;
        private System.Windows.Forms.ComboBox cbTrack;
        private System.Windows.Forms.Label lblAudioTrack;
        private System.Windows.Forms.ComboBox cbBitrate;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ComboBox cbHDR;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbLowpass;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbHighpass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbLoudness;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.Button btnGIF;
        private System.Windows.Forms.Panel pnlGIF;
        private System.Windows.Forms.TextBox tbGIFStart;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox tbGIFWidth;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tbGIFFPS;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbGIFDuration;
    }
}

