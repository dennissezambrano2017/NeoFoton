namespace NeoFoton
{
    partial class MainUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainUI));
            this.btnOpen = new System.Windows.Forms.Button();
            this.trkCompress = new System.Windows.Forms.TrackBar();
            this.grpCompress = new System.Windows.Forms.GroupBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cmbKBMB = new System.Windows.Forms.ComboBox();
            this.txtSize = new System.Windows.Forms.TextBox();
            this.chkFileSize = new System.Windows.Forms.CheckBox();
            this.numtxtCompress = new System.Windows.Forms.NumericUpDown();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbKeepOriginal = new System.Windows.Forms.RadioButton();
            this.rbJpeg = new System.Windows.Forms.RadioButton();
            this.rbPng = new System.Windows.Forms.RadioButton();
            this.pnlSizePix = new System.Windows.Forms.Panel();
            this.numTxtHeight = new System.Windows.Forms.NumericUpDown();
            this.rbSizeInPixels = new System.Windows.Forms.RadioButton();
            this.rbSizePercentage = new System.Windows.Forms.RadioButton();
            this.pnlSizePerc = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.numtxtSize = new System.Windows.Forms.NumericUpDown();
            this.trkSize = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.txtOpen = new System.Windows.Forms.TextBox();
            this.btnCompress = new System.Windows.Forms.Button();
            this.grpOpen = new System.Windows.Forms.GroupBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.lblTakeBackup = new System.Windows.Forms.Label();
            this.chkCompressAll = new System.Windows.Forms.CheckBox();
            this.grpSave = new System.Windows.Forms.GroupBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtSave = new System.Windows.Forms.TextBox();
            this.folderBrowser = new System.Windows.Forms.FolderBrowserDialog();
            this.btnZoomIn = new System.Windows.Forms.Button();
            this.btnZoomOut = new System.Windows.Forms.Button();
            this.webBroPicView = new System.Windows.Forms.WebBrowser();
            this.grpPicPreview = new System.Windows.Forms.GroupBox();
            this.chkAutoUpdatePreview = new System.Windows.Forms.CheckBox();
            this.linkToRate = new System.Windows.Forms.LinkLabel();
            this.linkToDownload = new System.Windows.Forms.LinkLabel();
            this.linkToDonate = new System.Windows.Forms.LinkLabel();
            this.lblPreview = new System.Windows.Forms.Label();
            this.btnRefreshPreview = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrev = new System.Windows.Forms.Button();
            this.linkToFeedback = new System.Windows.Forms.LinkLabel();
            this.linkToBlog = new System.Windows.Forms.LinkLabel();
            this.btnNormalSize = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trkCompress)).BeginInit();
            this.grpCompress.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numtxtCompress)).BeginInit();
            this.panel1.SuspendLayout();
            this.pnlSizePix.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTxtHeight)).BeginInit();
            this.pnlSizePerc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numtxtSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkSize)).BeginInit();
            this.grpOpen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.grpSave.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.grpPicPreview.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOpen
            // 
            this.btnOpen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOpen.Location = new System.Drawing.Point(721, 14);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(59, 31);
            this.btnOpen.TabIndex = 2;
            this.btnOpen.Text = "...";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // trkCompress
            // 
            this.trkCompress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trkCompress.Location = new System.Drawing.Point(109, 17);
            this.trkCompress.Maximum = 100;
            this.trkCompress.Name = "trkCompress";
            this.trkCompress.Size = new System.Drawing.Size(211, 45);
            this.trkCompress.TabIndex = 1;
            this.trkCompress.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trkCompress.Value = 80;
            this.trkCompress.Scroll += new System.EventHandler(this.trkCompress_Scroll);
            // 
            // grpCompress
            // 
            this.grpCompress.Controls.Add(this.pictureBox4);
            this.grpCompress.Controls.Add(this.pictureBox3);
            this.grpCompress.Controls.Add(this.pictureBox1);
            this.grpCompress.Controls.Add(this.panel3);
            this.grpCompress.Controls.Add(this.panel2);
            this.grpCompress.Controls.Add(this.cmbKBMB);
            this.grpCompress.Controls.Add(this.txtSize);
            this.grpCompress.Controls.Add(this.chkFileSize);
            this.grpCompress.Controls.Add(this.numtxtCompress);
            this.grpCompress.Controls.Add(this.panel1);
            this.grpCompress.Controls.Add(this.pnlSizePix);
            this.grpCompress.Controls.Add(this.rbSizeInPixels);
            this.grpCompress.Controls.Add(this.rbSizePercentage);
            this.grpCompress.Controls.Add(this.pnlSizePerc);
            this.grpCompress.Controls.Add(this.label2);
            this.grpCompress.Controls.Add(this.trkCompress);
            this.grpCompress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpCompress.Location = new System.Drawing.Point(9, 82);
            this.grpCompress.Name = "grpCompress";
            this.grpCompress.Size = new System.Drawing.Size(853, 119);
            this.grpCompress.TabIndex = 2;
            this.grpCompress.TabStop = false;
            this.grpCompress.Text = "Compression Parameters";
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox4.BackgroundImage")));
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox4.Location = new System.Drawing.Point(792, 77);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(22, 19);
            this.pictureBox4.TabIndex = 20;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(792, 18);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(22, 19);
            this.pictureBox3.TabIndex = 19;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(371, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(22, 19);
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel3.Location = new System.Drawing.Point(0, 46);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(853, 1);
            this.panel3.TabIndex = 17;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel2.Location = new System.Drawing.Point(404, 6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1, 110);
            this.panel2.TabIndex = 16;
            // 
            // cmbKBMB
            // 
            this.cmbKBMB.Enabled = false;
            this.cmbKBMB.FormattingEnabled = true;
            this.cmbKBMB.Items.AddRange(new object[] {
            "KB",
            "MB"});
            this.cmbKBMB.Location = new System.Drawing.Point(721, 15);
            this.cmbKBMB.Name = "cmbKBMB";
            this.cmbKBMB.Size = new System.Drawing.Size(65, 23);
            this.cmbKBMB.TabIndex = 9;
            this.cmbKBMB.Text = "KB";
            this.cmbKBMB.SelectedIndexChanged += new System.EventHandler(this.cmbKBMB_SelectedIndexChanged);
            // 
            // txtSize
            // 
            this.txtSize.Enabled = false;
            this.txtSize.Location = new System.Drawing.Point(629, 15);
            this.txtSize.MaxLength = 9;
            this.txtSize.Name = "txtSize";
            this.txtSize.Size = new System.Drawing.Size(86, 21);
            this.txtSize.TabIndex = 8;
            this.txtSize.TextChanged += new System.EventHandler(this.txtSize_TextChanged);
            // 
            // chkFileSize
            // 
            this.chkFileSize.AutoSize = true;
            this.chkFileSize.Location = new System.Drawing.Point(411, 15);
            this.chkFileSize.Name = "chkFileSize";
            this.chkFileSize.Size = new System.Drawing.Size(212, 19);
            this.chkFileSize.TabIndex = 7;
            this.chkFileSize.Text = "Compress if File Size Greater than";
            this.chkFileSize.UseVisualStyleBackColor = true;
            this.chkFileSize.CheckedChanged += new System.EventHandler(this.chkFileSize_CheckedChanged);
            // 
            // numtxtCompress
            // 
            this.numtxtCompress.Location = new System.Drawing.Point(322, 15);
            this.numtxtCompress.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numtxtCompress.Name = "numtxtCompress";
            this.numtxtCompress.Size = new System.Drawing.Size(42, 21);
            this.numtxtCompress.TabIndex = 2;
            this.numtxtCompress.Value = new decimal(new int[] {
            80,
            0,
            0,
            0});
            this.numtxtCompress.ValueChanged += new System.EventHandler(this.msktxtCompress_TextChanged);
            this.numtxtCompress.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numtxtCompress_KeyPress);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rbKeepOriginal);
            this.panel1.Controls.Add(this.rbJpeg);
            this.panel1.Controls.Add(this.rbPng);
            this.panel1.Location = new System.Drawing.Point(411, 51);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(379, 61);
            this.panel1.TabIndex = 11;
            // 
            // rbKeepOriginal
            // 
            this.rbKeepOriginal.AccessibleDescription = "";
            this.rbKeepOriginal.AutoSize = true;
            this.rbKeepOriginal.Checked = true;
            this.rbKeepOriginal.Location = new System.Drawing.Point(4, 29);
            this.rbKeepOriginal.Name = "rbKeepOriginal";
            this.rbKeepOriginal.Size = new System.Drawing.Size(370, 19);
            this.rbKeepOriginal.TabIndex = 12;
            this.rbKeepOriginal.TabStop = true;
            this.rbKeepOriginal.Tag = "";
            this.rbKeepOriginal.Text = "Don\'t Change Type (RAW images will be compressed as JPEG)";
            this.rbKeepOriginal.UseVisualStyleBackColor = true;
            this.rbKeepOriginal.CheckedChanged += new System.EventHandler(this.UpdatePreview);
            // 
            // rbJpeg
            // 
            this.rbJpeg.AccessibleDescription = "";
            this.rbJpeg.AutoSize = true;
            this.rbJpeg.Location = new System.Drawing.Point(3, 5);
            this.rbJpeg.Name = "rbJpeg";
            this.rbJpeg.Size = new System.Drawing.Size(102, 19);
            this.rbJpeg.TabIndex = 10;
            this.rbJpeg.Tag = "JPEG is commonly used format for photographs";
            this.rbJpeg.Text = "Save as JPEG";
            this.rbJpeg.UseVisualStyleBackColor = true;
            this.rbJpeg.CheckedChanged += new System.EventHandler(this.UpdatePreview);
            // 
            // rbPng
            // 
            this.rbPng.AccessibleDescription = "";
            this.rbPng.AutoSize = true;
            this.rbPng.Location = new System.Drawing.Point(109, 5);
            this.rbPng.Name = "rbPng";
            this.rbPng.Size = new System.Drawing.Size(97, 19);
            this.rbPng.TabIndex = 11;
            this.rbPng.Tag = "PNG is best for images which are not photographs";
            this.rbPng.Text = "Save as PNG";
            this.rbPng.UseVisualStyleBackColor = true;
            this.rbPng.CheckedChanged += new System.EventHandler(this.UpdatePreview);
            // 
            // pnlSizePix
            // 
            this.pnlSizePix.Controls.Add(this.numTxtHeight);
            this.pnlSizePix.Location = new System.Drawing.Point(8, 69);
            this.pnlSizePix.Name = "pnlSizePix";
            this.pnlSizePix.Size = new System.Drawing.Size(84, 38);
            this.pnlSizePix.TabIndex = 8;
            // 
            // numTxtHeight
            // 
            this.numTxtHeight.Location = new System.Drawing.Point(3, 12);
            this.numTxtHeight.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numTxtHeight.Name = "numTxtHeight";
            this.numTxtHeight.Size = new System.Drawing.Size(78, 21);
            this.numTxtHeight.TabIndex = 4;
            this.numTxtHeight.Value = new decimal(new int[] {
            1920,
            0,
            0,
            0});
            this.numTxtHeight.ValueChanged += new System.EventHandler(this.UpdatePreview);
            // 
            // rbSizeInPixels
            // 
            this.rbSizeInPixels.AutoSize = true;
            this.rbSizeInPixels.Location = new System.Drawing.Point(8, 52);
            this.rbSizeInPixels.Name = "rbSizeInPixels";
            this.rbSizeInPixels.Size = new System.Drawing.Size(89, 19);
            this.rbSizeInPixels.TabIndex = 3;
            this.rbSizeInPixels.TabStop = true;
            this.rbSizeInPixels.Text = "Fixed Width";
            this.rbSizeInPixels.UseVisualStyleBackColor = true;
            this.rbSizeInPixels.CheckedChanged += new System.EventHandler(this.rbSizeInPixels_CheckedChanged);
            // 
            // rbSizePercentage
            // 
            this.rbSizePercentage.AutoSize = true;
            this.rbSizePercentage.Location = new System.Drawing.Point(115, 52);
            this.rbSizePercentage.Name = "rbSizePercentage";
            this.rbSizePercentage.Size = new System.Drawing.Size(140, 19);
            this.rbSizePercentage.TabIndex = 3;
            this.rbSizePercentage.TabStop = true;
            this.rbSizePercentage.Text = "New Dimension in %";
            this.rbSizePercentage.UseVisualStyleBackColor = true;
            this.rbSizePercentage.CheckedChanged += new System.EventHandler(this.rbSizePercentage_CheckedChanged);
            // 
            // pnlSizePerc
            // 
            this.pnlSizePerc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlSizePerc.Controls.Add(this.pictureBox2);
            this.pnlSizePerc.Controls.Add(this.numtxtSize);
            this.pnlSizePerc.Controls.Add(this.trkSize);
            this.pnlSizePerc.Location = new System.Drawing.Point(92, 69);
            this.pnlSizePerc.Name = "pnlSizePerc";
            this.pnlSizePerc.Size = new System.Drawing.Size(310, 38);
            this.pnlSizePerc.TabIndex = 7;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(279, 14);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(22, 19);
            this.pictureBox2.TabIndex = 19;
            this.pictureBox2.TabStop = false;
            // 
            // numtxtSize
            // 
            this.numtxtSize.Location = new System.Drawing.Point(230, 12);
            this.numtxtSize.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numtxtSize.Name = "numtxtSize";
            this.numtxtSize.Size = new System.Drawing.Size(42, 21);
            this.numtxtSize.TabIndex = 6;
            this.numtxtSize.Value = new decimal(new int[] {
            70,
            0,
            0,
            0});
            this.numtxtSize.ValueChanged += new System.EventHandler(this.msktxtSize_TextChanged);
            // 
            // trkSize
            // 
            this.trkSize.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trkSize.Location = new System.Drawing.Point(15, 14);
            this.trkSize.Maximum = 100;
            this.trkSize.Name = "trkSize";
            this.trkSize.Size = new System.Drawing.Size(211, 45);
            this.trkSize.TabIndex = 5;
            this.trkSize.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trkSize.Value = 70;
            this.trkSize.Scroll += new System.EventHandler(this.trkSize_Scroll);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Quality (in %)";
            // 
            // txtOpen
            // 
            this.txtOpen.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOpen.Location = new System.Drawing.Point(6, 19);
            this.txtOpen.Name = "txtOpen";
            this.txtOpen.Size = new System.Drawing.Size(709, 21);
            this.txtOpen.TabIndex = 1;
            this.txtOpen.TextChanged += new System.EventHandler(this.txtOpen_TextChanged);
            // 
            // btnCompress
            // 
            this.btnCompress.Location = new System.Drawing.Point(749, 210);
            this.btnCompress.Name = "btnCompress";
            this.btnCompress.Size = new System.Drawing.Size(113, 50);
            this.btnCompress.TabIndex = 5;
            this.btnCompress.Tag = "";
            this.btnCompress.Text = "&Compress All";
            this.btnCompress.UseVisualStyleBackColor = true;
            this.btnCompress.Click += new System.EventHandler(this.btnCompress_Click);
            // 
            // grpOpen
            // 
            this.grpOpen.Controls.Add(this.pictureBox5);
            this.grpOpen.Controls.Add(this.lblTakeBackup);
            this.grpOpen.Controls.Add(this.chkCompressAll);
            this.grpOpen.Controls.Add(this.txtOpen);
            this.grpOpen.Controls.Add(this.btnOpen);
            this.grpOpen.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpOpen.Location = new System.Drawing.Point(9, 10);
            this.grpOpen.Name = "grpOpen";
            this.grpOpen.Size = new System.Drawing.Size(814, 72);
            this.grpOpen.TabIndex = 1;
            this.grpOpen.TabStop = false;
            this.grpOpen.Text = "Open Directory To Compress All Images within";
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox5.BackgroundImage")));
            this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox5.Location = new System.Drawing.Point(786, 20);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(22, 19);
            this.pictureBox5.TabIndex = 20;
            this.pictureBox5.TabStop = false;
            // 
            // lblTakeBackup
            // 
            this.lblTakeBackup.AutoSize = true;
            this.lblTakeBackup.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTakeBackup.Location = new System.Drawing.Point(455, 46);
            this.lblTakeBackup.Name = "lblTakeBackup";
            this.lblTakeBackup.Size = new System.Drawing.Size(267, 13);
            this.lblTakeBackup.TabIndex = 4;
            this.lblTakeBackup.Text = "ENSURE YOU HAVE TAKEN BACKUP FIRST.";
            this.lblTakeBackup.Visible = false;
            // 
            // chkCompressAll
            // 
            this.chkCompressAll.AutoSize = true;
            this.chkCompressAll.Location = new System.Drawing.Point(6, 45);
            this.chkCompressAll.Name = "chkCompressAll";
            this.chkCompressAll.Size = new System.Drawing.Size(450, 18);
            this.chkCompressAll.TabIndex = 3;
            this.chkCompressAll.Text = "Compress Images of All Child Directories (WARNING! It Overwrites Existing Images)" +
    ".";
            this.chkCompressAll.UseVisualStyleBackColor = true;
            this.chkCompressAll.CheckedChanged += new System.EventHandler(this.chkCompressAll_CheckedChanged);
            // 
            // grpSave
            // 
            this.grpSave.Controls.Add(this.pictureBox6);
            this.grpSave.Controls.Add(this.btnSave);
            this.grpSave.Controls.Add(this.txtSave);
            this.grpSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpSave.Location = new System.Drawing.Point(9, 207);
            this.grpSave.Name = "grpSave";
            this.grpSave.Size = new System.Drawing.Size(734, 50);
            this.grpSave.TabIndex = 3;
            this.grpSave.TabStop = false;
            this.grpSave.Text = "Save Compressed Images to Directory (optional)";
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox6.BackgroundImage")));
            this.pictureBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox6.Location = new System.Drawing.Point(700, 19);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(22, 19);
            this.pictureBox6.TabIndex = 21;
            this.pictureBox6.TabStop = false;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(631, 13);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(59, 31);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "...";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtSave
            // 
            this.txtSave.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSave.Location = new System.Drawing.Point(6, 19);
            this.txtSave.Name = "txtSave";
            this.txtSave.Size = new System.Drawing.Size(617, 21);
            this.txtSave.TabIndex = 7;
            // 
            // btnZoomIn
            // 
            this.btnZoomIn.Location = new System.Drawing.Point(31, 28);
            this.btnZoomIn.Name = "btnZoomIn";
            this.btnZoomIn.Size = new System.Drawing.Size(70, 23);
            this.btnZoomIn.TabIndex = 15;
            this.btnZoomIn.Text = "Zoom In";
            this.btnZoomIn.UseVisualStyleBackColor = true;
            this.btnZoomIn.Click += new System.EventHandler(this.btnZoomIn_Click);
            // 
            // btnZoomOut
            // 
            this.btnZoomOut.Location = new System.Drawing.Point(213, 28);
            this.btnZoomOut.Name = "btnZoomOut";
            this.btnZoomOut.Size = new System.Drawing.Size(70, 23);
            this.btnZoomOut.TabIndex = 17;
            this.btnZoomOut.Text = "Zoom Out";
            this.btnZoomOut.UseVisualStyleBackColor = true;
            this.btnZoomOut.Click += new System.EventHandler(this.btnZoomOut_Click);
            // 
            // webBroPicView
            // 
            this.webBroPicView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.webBroPicView.Location = new System.Drawing.Point(6, 57);
            this.webBroPicView.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBroPicView.Name = "webBroPicView";
            this.webBroPicView.Size = new System.Drawing.Size(847, 259);
            this.webBroPicView.TabIndex = 108;
            // 
            // grpPicPreview
            // 
            this.grpPicPreview.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpPicPreview.Controls.Add(this.chkAutoUpdatePreview);
            this.grpPicPreview.Controls.Add(this.linkToRate);
            this.grpPicPreview.Controls.Add(this.linkToDownload);
            this.grpPicPreview.Controls.Add(this.linkToDonate);
            this.grpPicPreview.Controls.Add(this.lblPreview);
            this.grpPicPreview.Controls.Add(this.btnRefreshPreview);
            this.grpPicPreview.Controls.Add(this.btnNext);
            this.grpPicPreview.Controls.Add(this.btnPrev);
            this.grpPicPreview.Controls.Add(this.linkToFeedback);
            this.grpPicPreview.Controls.Add(this.linkToBlog);
            this.grpPicPreview.Controls.Add(this.btnNormalSize);
            this.grpPicPreview.Controls.Add(this.btnZoomOut);
            this.grpPicPreview.Controls.Add(this.btnZoomIn);
            this.grpPicPreview.Controls.Add(this.label3);
            this.grpPicPreview.Controls.Add(this.webBroPicView);
            this.grpPicPreview.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpPicPreview.Location = new System.Drawing.Point(9, 266);
            this.grpPicPreview.Name = "grpPicPreview";
            this.grpPicPreview.Size = new System.Drawing.Size(859, 339);
            this.grpPicPreview.TabIndex = 10;
            this.grpPicPreview.TabStop = false;
            this.grpPicPreview.Text = "Compression Preview";
            // 
            // chkAutoUpdatePreview
            // 
            this.chkAutoUpdatePreview.AutoSize = true;
            this.chkAutoUpdatePreview.Checked = true;
            this.chkAutoUpdatePreview.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAutoUpdatePreview.Location = new System.Drawing.Point(527, 13);
            this.chkAutoUpdatePreview.Name = "chkAutoUpdatePreview";
            this.chkAutoUpdatePreview.Size = new System.Drawing.Size(139, 19);
            this.chkAutoUpdatePreview.TabIndex = 20;
            this.chkAutoUpdatePreview.Text = "Auto Update Preview";
            this.chkAutoUpdatePreview.UseVisualStyleBackColor = true;
            this.chkAutoUpdatePreview.CheckedChanged += new System.EventHandler(this.chkAutoUpdatePreview_CheckedChanged);
            // 
            // linkToRate
            // 
            this.linkToRate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.linkToRate.AutoSize = true;
            this.linkToRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkToRate.Location = new System.Drawing.Point(257, 320);
            this.linkToRate.Name = "linkToRate";
            this.linkToRate.Size = new System.Drawing.Size(58, 16);
            this.linkToRate.TabIndex = 24;
            this.linkToRate.TabStop = true;
            this.linkToRate.Text = "Rate me";
            this.linkToRate.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkToBlog_LinkClicked);
            // 
            // linkToDownload
            // 
            this.linkToDownload.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.linkToDownload.AutoSize = true;
            this.linkToDownload.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkToDownload.Location = new System.Drawing.Point(696, 320);
            this.linkToDownload.Name = "linkToDownload";
            this.linkToDownload.Size = new System.Drawing.Size(152, 16);
            this.linkToDownload.TabIndex = 26;
            this.linkToDownload.TabStop = true;
            this.linkToDownload.Text = "Latest Version Available";
            this.linkToDownload.Visible = false;
            this.linkToDownload.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkToBlog_LinkClicked);
            // 
            // linkToDonate
            // 
            this.linkToDonate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.linkToDonate.AutoSize = true;
            this.linkToDonate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkToDonate.Location = new System.Drawing.Point(368, 320);
            this.linkToDonate.Name = "linkToDonate";
            this.linkToDonate.Size = new System.Drawing.Size(97, 16);
            this.linkToDonate.TabIndex = 25;
            this.linkToDonate.TabStop = true;
            this.linkToDonate.Text = "Buy me a beer!";
            this.linkToDonate.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkToBlog_LinkClicked);
            // 
            // lblPreview
            // 
            this.lblPreview.AutoSize = true;
            this.lblPreview.Location = new System.Drawing.Point(524, 33);
            this.lblPreview.Name = "lblPreview";
            this.lblPreview.Size = new System.Drawing.Size(210, 15);
            this.lblPreview.TabIndex = 24;
            this.lblPreview.Text = "Changed Compression Parameters? ";
            this.lblPreview.Visible = false;
            // 
            // btnRefreshPreview
            // 
            this.btnRefreshPreview.Location = new System.Drawing.Point(740, 28);
            this.btnRefreshPreview.Name = "btnRefreshPreview";
            this.btnRefreshPreview.Size = new System.Drawing.Size(103, 23);
            this.btnRefreshPreview.TabIndex = 21;
            this.btnRefreshPreview.Text = "Refresh Preview";
            this.btnRefreshPreview.UseVisualStyleBackColor = true;
            this.btnRefreshPreview.Visible = false;
            this.btnRefreshPreview.Click += new System.EventHandler(this.btnRefreshPreview_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(398, 28);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(70, 23);
            this.btnNext.TabIndex = 19;
            this.btnNext.Text = "Next >";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrev
            // 
            this.btnPrev.Location = new System.Drawing.Point(322, 28);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(70, 23);
            this.btnPrev.TabIndex = 18;
            this.btnPrev.Text = "< Previous";
            this.btnPrev.UseVisualStyleBackColor = true;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // linkToFeedback
            // 
            this.linkToFeedback.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.linkToFeedback.AutoSize = true;
            this.linkToFeedback.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkToFeedback.Location = new System.Drawing.Point(102, 320);
            this.linkToFeedback.Name = "linkToFeedback";
            this.linkToFeedback.Size = new System.Drawing.Size(104, 16);
            this.linkToFeedback.TabIndex = 23;
            this.linkToFeedback.TabStop = true;
            this.linkToFeedback.Text = "Send Feedback";
            this.linkToFeedback.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkToBlog_LinkClicked);
            // 
            // linkToBlog
            // 
            this.linkToBlog.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.linkToBlog.AutoSize = true;
            this.linkToBlog.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkToBlog.Location = new System.Drawing.Point(6, 320);
            this.linkToBlog.Name = "linkToBlog";
            this.linkToBlog.Size = new System.Drawing.Size(63, 16);
            this.linkToBlog.TabIndex = 22;
            this.linkToBlog.TabStop = true;
            this.linkToBlog.Text = "Visit Blog";
            this.linkToBlog.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkToBlog_LinkClicked);
            // 
            // btnNormalSize
            // 
            this.btnNormalSize.Location = new System.Drawing.Point(107, 28);
            this.btnNormalSize.Name = "btnNormalSize";
            this.btnNormalSize.Size = new System.Drawing.Size(100, 23);
            this.btnNormalSize.TabIndex = 16;
            this.btnNormalSize.Text = "100% Zoom";
            this.btnNormalSize.UseVisualStyleBackColor = true;
            this.btnNormalSize.Click += new System.EventHandler(this.btnNormalSize_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(144, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(10, 15);
            this.label3.TabIndex = 17;
            this.label3.Text = " ";
            // 
            // MainUI
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 607);
            this.Controls.Add(this.grpCompress);
            this.Controls.Add(this.grpPicPreview);
            this.Controls.Add(this.grpSave);
            this.Controls.Add(this.grpOpen);
            this.Controls.Add(this.btnCompress);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "[Mass Image Compressor 3.1] Compress Images of Directory";
            this.Load += new System.EventHandler(this.MainUI_Load);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.MainUI_DragEnter);
            ((System.ComponentModel.ISupportInitialize)(this.trkCompress)).EndInit();
            this.grpCompress.ResumeLayout(false);
            this.grpCompress.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numtxtCompress)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlSizePix.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numTxtHeight)).EndInit();
            this.pnlSizePerc.ResumeLayout(false);
            this.pnlSizePerc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numtxtSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkSize)).EndInit();
            this.grpOpen.ResumeLayout(false);
            this.grpOpen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.grpSave.ResumeLayout(false);
            this.grpSave.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.grpPicPreview.ResumeLayout(false);
            this.grpPicPreview.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.TrackBar trkCompress;
        private System.Windows.Forms.GroupBox grpCompress;
        private System.Windows.Forms.TextBox txtOpen;
        private System.Windows.Forms.Button btnCompress;
        private System.Windows.Forms.GroupBox grpOpen;
        private System.Windows.Forms.GroupBox grpSave;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtSave;
        private System.Windows.Forms.FolderBrowserDialog folderBrowser;
        private System.Windows.Forms.Button btnZoomIn;
        private System.Windows.Forms.Button btnZoomOut;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar trkSize;
        private System.Windows.Forms.WebBrowser webBroPicView;
        private System.Windows.Forms.GroupBox grpPicPreview;
        private System.Windows.Forms.Button btnNormalSize;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel pnlSizePerc;
        private System.Windows.Forms.RadioButton rbSizeInPixels;
        private System.Windows.Forms.RadioButton rbSizePercentage;
        private System.Windows.Forms.Panel pnlSizePix;
		private System.Windows.Forms.RadioButton rbPng;
		private System.Windows.Forms.RadioButton rbJpeg;
		private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.LinkLabel linkToBlog;
        private System.Windows.Forms.LinkLabel linkToFeedback;
        private System.Windows.Forms.RadioButton rbKeepOriginal;
        private System.Windows.Forms.CheckBox chkCompressAll;
        private System.Windows.Forms.Label lblTakeBackup;
        private System.Windows.Forms.NumericUpDown numTxtHeight;
        private System.Windows.Forms.NumericUpDown numtxtCompress;
        private System.Windows.Forms.NumericUpDown numtxtSize;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.ComboBox cmbKBMB;
        private System.Windows.Forms.TextBox txtSize;
        private System.Windows.Forms.CheckBox chkFileSize;
        private System.Windows.Forms.Label lblPreview;
        private System.Windows.Forms.Button btnRefreshPreview;
        private System.Windows.Forms.LinkLabel linkToDonate;
        private System.Windows.Forms.LinkLabel linkToDownload;
        private System.Windows.Forms.LinkLabel linkToRate;
        private System.Windows.Forms.CheckBox chkAutoUpdatePreview;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
    }
}

