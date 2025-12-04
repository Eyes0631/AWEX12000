// ============================================================================
// Copyright (c) 2010  IOSS GmbH
// All Rights Reserved.
// ============================================================================


// ============================================================================
//
//      AppCsForm  -  C# based library, designer part
//
// ============================================================================
//
//      File:     Form1.Designer.cs          Type:         Implementation
//
//      Date:     04.02.2010                 Last Change:  01.03.2010
//
//      Author:   Thomas M. Schlageter
//
//      Methods:  Dispose               -  clean up used resources on close
//
//                Dispose               -  remove all graphical components
//                InitializeComponent   -  initialize all graphical components
//
// ============================================================================

using Wid110LibConstUser;
using AppCsConstDevel;


namespace AppCs
{
    partial class AppCsDevel
    {
        // ====================================================================
        /// <summary>
        /// Required designer variable.
        /// </summary>
        // ====================================================================

        private System.ComponentModel.IContainer components = null;


        // ====================================================================
        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        // ====================================================================

        protected override void Dispose( bool disposing )
        {
            if ( disposing && ( components != null ) )
            {
                components.Dispose();
            }
            base.Dispose( disposing );
        }

        #region Windows Form Designer generated code


        // ====================================================================
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        // ====================================================================

        private void InitializeComponent()
        {
            this.configButton = new System.Windows.Forms.Button();
            this.processButton = new System.Windows.Forms.Button();
            this.codeButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.snapButton = new System.Windows.Forms.Button();
            this.decodeButton = new System.Windows.Forms.Button();
            this.showBestButton = new System.Windows.Forms.Button();
            this.showButton = new System.Windows.Forms.Button();
            this.slotTextBox = new System.Windows.Forms.TextBox();
            this.resultTextBox = new System.Windows.Forms.TextBox();
            this.qualityTextBox = new System.Windows.Forms.TextBox();
            this.colorBox = new System.Windows.Forms.ComboBox();
            this.channelBox = new System.Windows.Forms.ComboBox();
            this.codeBox = new System.Windows.Forms.ComboBox();
            this.confLabel = new System.Windows.Forms.Label();
            this.colorLabel = new System.Windows.Forms.Label();
            this.chanLabel = new System.Windows.Forms.Label();
            this.intensLabel = new System.Windows.Forms.Label();
            this.resultLabel = new System.Windows.Forms.Label();
            this.codeLabel = new System.Windows.Forms.Label();
            this.openDialog = new System.Windows.Forms.OpenFileDialog();
            this.connBox = new System.Windows.Forms.GroupBox();
            this.ipTextBox = new System.Windows.Forms.TextBox();
            this.ipLabel = new System.Windows.Forms.Label();
            this.connectButton = new System.Windows.Forms.Button();
            this.confBox = new System.Windows.Forms.GroupBox();
            this.checkConnection = new System.Windows.Forms.Button();
            this.liveBox = new System.Windows.Forms.GroupBox();
            this.BtCaptureGet = new System.Windows.Forms.Button();
            this.ChkFlipped = new System.Windows.Forms.CheckBox();
            this.BtCaptureSet = new System.Windows.Forms.Button();
            this.ChkRotated = new System.Windows.Forms.CheckBox();
            this.intensityUpDown = new System.Windows.Forms.NumericUpDown();
            this.procBox = new System.Windows.Forms.GroupBox();
            this.ActivateConfig = new System.Windows.Forms.Button();
            this.evalBox = new System.Windows.Forms.GroupBox();
            this.TxtProcessTime = new System.Windows.Forms.TextBox();
            this.BtShowProcessTime = new System.Windows.Forms.Button();
            this.infoTextBox = new System.Windows.Forms.TextBox();
            this.logMessage = new System.Windows.Forms.TextBox();
            this.BtSave = new System.Windows.Forms.Button();
            this.BtSaveJob = new System.Windows.Forms.Button();
            this.BtLoadJob = new System.Windows.Forms.Button();
            this.jobPanel = new System.Windows.Forms.Panel();
            this.roiBox = new System.Windows.Forms.GroupBox();
            this.TxtYLength = new System.Windows.Forms.TextBox();
            this.TxtYStart = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtXLength = new System.Windows.Forms.TextBox();
            this.TxtXStart = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtGetConfigROI = new System.Windows.Forms.Button();
            this.BtSetConfigROI = new System.Windows.Forms.Button();
            this.ocrParamBox = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.TxtCharPosY = new System.Windows.Forms.TextBox();
            this.TxtCharPosX = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.TxtRotation = new System.Windows.Forms.TextBox();
            this.TxtCharSizeY = new System.Windows.Forms.TextBox();
            this.TxtCharSizeX = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.chkFineScan = new System.Windows.Forms.CheckBox();
            this.TxtSpacing = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.ChkAdjustSize = new System.Windows.Forms.CheckBox();
            this.TxtAccSimilarity = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ChkAdjustSpace = new System.Windows.Forms.CheckBox();
            this.TxtMinSimilarity = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtFormat = new System.Windows.Forms.TextBox();
            this.TxtFilter = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtFielding = new System.Windows.Forms.TextBox();
            this.cbFontName = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.teachingBox = new System.Windows.Forms.GroupBox();
            this.LbDmrLearn = new System.Windows.Forms.Label();
            this.LbBcrLearn = new System.Windows.Forms.Label();
            this.LbDmrTeach = new System.Windows.Forms.Label();
            this.LbBcrTeach = new System.Windows.Forms.Label();
            this.BtResetCycle = new System.Windows.Forms.Button();
            this.BtDeleteConfig = new System.Windows.Forms.Button();
            this.LbOcrLearn = new System.Windows.Forms.Label();
            this.BtConfigureDMR = new System.Windows.Forms.Button();
            this.BtConfigureOCR = new System.Windows.Forms.Button();
            this.BtConfigureBCR = new System.Windows.Forms.Button();
            this.BtConfigPreset = new System.Windows.Forms.Button();
            this.LbOcrTeach = new System.Windows.Forms.Label();
            this.txtConfigName = new System.Windows.Forms.TextBox();
            this.BtTeachDMR = new System.Windows.Forms.Button();
            this.BtTeachOCR = new System.Windows.Forms.Button();
            this.BtTeachBCR = new System.Windows.Forms.Button();
            this.saveDialog = new System.Windows.Forms.SaveFileDialog();
            this.imgaeBox = new System.Windows.Forms.GroupBox();
            this.TxtImageSizeY = new System.Windows.Forms.TextBox();
            this.TxtImageSizeX = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.bcrParamBox = new System.Windows.Forms.GroupBox();
            this.TxtBCRFormat = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.TxtBCRTable = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.ChkBcrAltis = new System.Windows.Forms.CheckBox();
            this.ChkBcrLowContrast = new System.Windows.Forms.CheckBox();
            this.ChkBcrChecksum = new System.Windows.Forms.CheckBox();
            this.CbBcrResolution = new System.Windows.Forms.ComboBox();
            this.CbBcrSeparator = new System.Windows.Forms.ComboBox();
            this.CbBcrDigits = new System.Windows.Forms.ComboBox();
            this.CbBcrChars = new System.Windows.Forms.ComboBox();
            this.CbBcrTiConv = new System.Windows.Forms.ComboBox();
            this.ChkBcrSemi = new System.Windows.Forms.CheckBox();
            this.CbBcrIbmConv = new System.Windows.Forms.ComboBox();
            this.ChkBcrLTOR = new System.Windows.Forms.CheckBox();
            this.ChkBcrRTOL = new System.Windows.Forms.CheckBox();
            this.dmrParamBox = new System.Windows.Forms.GroupBox();
            this.TxtDMRFormat = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.ChkDmrLinInv = new System.Windows.Forms.CheckBox();
            this.ChkDmrLinNrm = new System.Windows.Forms.CheckBox();
            this.ChkDmrDotInv = new System.Windows.Forms.CheckBox();
            this.ChkDmrDotNrm = new System.Windows.Forms.CheckBox();
            this.CbDmrCodeSize = new System.Windows.Forms.ComboBox();
            this.CbDmrMirror = new System.Windows.Forms.ComboBox();
            this.CbDmrSymbol = new System.Windows.Forms.ComboBox();
            this.connBox.SuspendLayout();
            this.confBox.SuspendLayout();
            this.liveBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.intensityUpDown)).BeginInit();
            this.procBox.SuspendLayout();
            this.evalBox.SuspendLayout();
            this.jobPanel.SuspendLayout();
            this.roiBox.SuspendLayout();
            this.ocrParamBox.SuspendLayout();
            this.teachingBox.SuspendLayout();
            this.imgaeBox.SuspendLayout();
            this.bcrParamBox.SuspendLayout();
            this.dmrParamBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // configButton
            // 
            this.configButton.Location = new System.Drawing.Point(27, 29);
            this.configButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.configButton.Name = "configButton";
            this.configButton.Size = new System.Drawing.Size(100, 27);
            this.configButton.TabIndex = 0;
            this.configButton.Text = "Load Config";
            this.configButton.UseVisualStyleBackColor = true;
            this.configButton.Click += new System.EventHandler(this.confButtonClick);
            // 
            // processButton
            // 
            this.processButton.Location = new System.Drawing.Point(27, 32);
            this.processButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.processButton.Name = "processButton";
            this.processButton.Size = new System.Drawing.Size(127, 27);
            this.processButton.TabIndex = 0;
            this.processButton.Text = "Process Trigger";
            this.processButton.UseVisualStyleBackColor = true;
            this.processButton.Click += new System.EventHandler(this.processButtonClick);
            // 
            // codeButton
            // 
            this.codeButton.Location = new System.Drawing.Point(27, 58);
            this.codeButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.codeButton.Name = "codeButton";
            this.codeButton.Size = new System.Drawing.Size(151, 27);
            this.codeButton.TabIndex = 0;
            this.codeButton.Text = "Show Code Quality";
            this.codeButton.UseVisualStyleBackColor = true;
            this.codeButton.Click += new System.EventHandler(this.showCodeButtonClick);
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(353, 32);
            this.closeButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(68, 27);
            this.closeButton.TabIndex = 5;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButtonClick);
            // 
            // snapButton
            // 
            this.snapButton.Location = new System.Drawing.Point(44, 119);
            this.snapButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.snapButton.Name = "snapButton";
            this.snapButton.Size = new System.Drawing.Size(123, 27);
            this.snapButton.TabIndex = 0;
            this.snapButton.Text = "Snap Image";
            this.snapButton.UseVisualStyleBackColor = true;
            this.snapButton.Click += new System.EventHandler(this.snapButtonClick);
            // 
            // decodeButton
            // 
            this.decodeButton.Location = new System.Drawing.Point(175, 119);
            this.decodeButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.decodeButton.Name = "decodeButton";
            this.decodeButton.Size = new System.Drawing.Size(123, 27);
            this.decodeButton.TabIndex = 1;
            this.decodeButton.Text = "Snap + Decode";
            this.decodeButton.UseVisualStyleBackColor = true;
            this.decodeButton.Visible = false;
            this.decodeButton.Click += new System.EventHandler(this.decodeButtonClick);
            // 
            // showBestButton
            // 
            this.showBestButton.Location = new System.Drawing.Point(236, 32);
            this.showBestButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.showBestButton.Name = "showBestButton";
            this.showBestButton.Size = new System.Drawing.Size(185, 27);
            this.showBestButton.TabIndex = 1;
            this.showBestButton.Text = "Show Best Process Image";
            this.showBestButton.UseVisualStyleBackColor = true;
            this.showBestButton.Click += new System.EventHandler(this.showBestButtonClick);
            // 
            // showButton
            // 
            this.showButton.Location = new System.Drawing.Point(236, 66);
            this.showButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.showButton.Name = "showButton";
            this.showButton.Size = new System.Drawing.Size(185, 27);
            this.showButton.TabIndex = 2;
            this.showButton.Text = "Show Process Images";
            this.showButton.UseVisualStyleBackColor = true;
            this.showButton.Click += new System.EventHandler(this.showProcButtonClick);
            // 
            // slotTextBox
            // 
            this.slotTextBox.Location = new System.Drawing.Point(180, 31);
            this.slotTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.slotTextBox.Name = "slotTextBox";
            this.slotTextBox.Size = new System.Drawing.Size(39, 25);
            this.slotTextBox.TabIndex = 2;
            this.slotTextBox.Text = "0";
            this.slotTextBox.Visible = false;
            this.slotTextBox.TextChanged += new System.EventHandler(this.textSlotChanged);
            // 
            // resultTextBox
            // 
            this.resultTextBox.Location = new System.Drawing.Point(117, 24);
            this.resultTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.resultTextBox.Name = "resultTextBox";
            this.resultTextBox.ReadOnly = true;
            this.resultTextBox.Size = new System.Drawing.Size(303, 25);
            this.resultTextBox.TabIndex = 3;
            // 
            // qualityTextBox
            // 
            this.qualityTextBox.Enabled = false;
            this.qualityTextBox.Location = new System.Drawing.Point(369, 61);
            this.qualityTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.qualityTextBox.Name = "qualityTextBox";
            this.qualityTextBox.ReadOnly = true;
            this.qualityTextBox.Size = new System.Drawing.Size(51, 25);
            this.qualityTextBox.TabIndex = 4;
            // 
            // colorBox
            // 
            this.colorBox.FormattingEnabled = true;
            this.colorBox.Location = new System.Drawing.Point(92, 29);
            this.colorBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.colorBox.Name = "colorBox";
            this.colorBox.Size = new System.Drawing.Size(160, 23);
            this.colorBox.TabIndex = 4;
            this.colorBox.SelectedIndexChanged += new System.EventHandler(this.colorIndexChanged);
            // 
            // channelBox
            // 
            this.channelBox.FormattingEnabled = true;
            this.channelBox.Location = new System.Drawing.Point(92, 59);
            this.channelBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.channelBox.Name = "channelBox";
            this.channelBox.Size = new System.Drawing.Size(160, 23);
            this.channelBox.TabIndex = 5;
            this.channelBox.SelectedIndexChanged += new System.EventHandler(this.chanIndexChanged);
            // 
            // codeBox
            // 
            this.codeBox.FormattingEnabled = true;
            this.codeBox.Location = new System.Drawing.Point(283, 60);
            this.codeBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.codeBox.Name = "codeBox";
            this.codeBox.Size = new System.Drawing.Size(81, 23);
            this.codeBox.TabIndex = 6;
            this.codeBox.SelectedIndexChanged += new System.EventHandler(this.typeIndexChanged);
            // 
            // confLabel
            // 
            this.confLabel.AutoSize = true;
            this.confLabel.Location = new System.Drawing.Point(131, 36);
            this.confLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.confLabel.Name = "confLabel";
            this.confLabel.Size = new System.Drawing.Size(45, 15);
            this.confLabel.TabIndex = 3;
            this.confLabel.Text = "to Slot";
            this.confLabel.Visible = false;
            // 
            // colorLabel
            // 
            this.colorLabel.AutoSize = true;
            this.colorLabel.Location = new System.Drawing.Point(23, 32);
            this.colorLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.colorLabel.Name = "colorLabel";
            this.colorLabel.Size = new System.Drawing.Size(39, 15);
            this.colorLabel.TabIndex = 6;
            this.colorLabel.Text = "Color";
            // 
            // chanLabel
            // 
            this.chanLabel.AutoSize = true;
            this.chanLabel.Location = new System.Drawing.Point(23, 62);
            this.chanLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.chanLabel.Name = "chanLabel";
            this.chanLabel.Size = new System.Drawing.Size(53, 15);
            this.chanLabel.TabIndex = 7;
            this.chanLabel.Text = "Channel";
            // 
            // intensLabel
            // 
            this.intensLabel.AutoSize = true;
            this.intensLabel.Location = new System.Drawing.Point(23, 91);
            this.intensLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.intensLabel.Name = "intensLabel";
            this.intensLabel.Size = new System.Drawing.Size(56, 15);
            this.intensLabel.TabIndex = 8;
            this.intensLabel.Text = "Intensity";
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Location = new System.Drawing.Point(23, 28);
            this.resultLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(75, 15);
            this.resultLabel.TabIndex = 7;
            this.resultLabel.Text = "Code Result";
            // 
            // codeLabel
            // 
            this.codeLabel.AutoSize = true;
            this.codeLabel.Location = new System.Drawing.Point(185, 63);
            this.codeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.codeLabel.Name = "codeLabel";
            this.codeLabel.Size = new System.Drawing.Size(85, 15);
            this.codeLabel.TabIndex = 8;
            this.codeLabel.Text = "of Code Type";
            // 
            // openDialog
            // 
            this.openDialog.Filter = "JOB Files (*.job)|*.job|CFG Files (*.cfg)|*.cfg";
            this.openDialog.Title = "Load Configuration or Job File";
            this.openDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.openDialog_FileOk);
            // 
            // connBox
            // 
            this.connBox.Controls.Add(this.ipTextBox);
            this.connBox.Controls.Add(this.ipLabel);
            this.connBox.Controls.Add(this.connectButton);
            this.connBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.connBox.Location = new System.Drawing.Point(16, 14);
            this.connBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.connBox.Name = "connBox";
            this.connBox.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.connBox.Size = new System.Drawing.Size(425, 68);
            this.connBox.TabIndex = 6;
            this.connBox.TabStop = false;
            this.connBox.Text = "Connection";
            // 
            // ipTextBox
            // 
            this.ipTextBox.Location = new System.Drawing.Point(239, 29);
            this.ipTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ipTextBox.Name = "ipTextBox";
            this.ipTextBox.Size = new System.Drawing.Size(165, 25);
            this.ipTextBox.TabIndex = 1;
            this.ipTextBox.Text = "192.168.0.65";
            this.ipTextBox.TextChanged += new System.EventHandler(this.textIPChanged);
            // 
            // ipLabel
            // 
            this.ipLabel.AutoSize = true;
            this.ipLabel.Location = new System.Drawing.Point(133, 32);
            this.ipLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ipLabel.Name = "ipLabel";
            this.ipLabel.Size = new System.Drawing.Size(89, 15);
            this.ipLabel.TabIndex = 2;
            this.ipLabel.Text = "To IP Address";
            // 
            // connectButton
            // 
            this.connectButton.Location = new System.Drawing.Point(27, 27);
            this.connectButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(100, 27);
            this.connectButton.TabIndex = 0;
            this.connectButton.Text = "Connect";
            this.connectButton.UseVisualStyleBackColor = true;
            this.connectButton.Click += new System.EventHandler(this.connButtonClick);
            // 
            // confBox
            // 
            this.confBox.Controls.Add(this.checkConnection);
            this.confBox.Controls.Add(this.slotTextBox);
            this.confBox.Controls.Add(this.confLabel);
            this.confBox.Controls.Add(this.configButton);
            this.confBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.confBox.Location = new System.Drawing.Point(16, 89);
            this.confBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.confBox.Name = "confBox";
            this.confBox.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.confBox.Size = new System.Drawing.Size(425, 70);
            this.confBox.TabIndex = 7;
            this.confBox.TabStop = false;
            this.confBox.Text = "Configuration";
            // 
            // checkConnection
            // 
            this.checkConnection.Location = new System.Drawing.Point(239, 29);
            this.checkConnection.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.checkConnection.Name = "checkConnection";
            this.checkConnection.Size = new System.Drawing.Size(167, 27);
            this.checkConnection.TabIndex = 4;
            this.checkConnection.Text = "Check Connection";
            this.checkConnection.UseVisualStyleBackColor = true;
            this.checkConnection.Click += new System.EventHandler(this.CheckConnection_Click);
            // 
            // liveBox
            // 
            this.liveBox.Controls.Add(this.BtCaptureGet);
            this.liveBox.Controls.Add(this.ChkFlipped);
            this.liveBox.Controls.Add(this.BtCaptureSet);
            this.liveBox.Controls.Add(this.ChkRotated);
            this.liveBox.Controls.Add(this.intensityUpDown);
            this.liveBox.Controls.Add(this.decodeButton);
            this.liveBox.Controls.Add(this.snapButton);
            this.liveBox.Controls.Add(this.channelBox);
            this.liveBox.Controls.Add(this.intensLabel);
            this.liveBox.Controls.Add(this.colorBox);
            this.liveBox.Controls.Add(this.colorLabel);
            this.liveBox.Controls.Add(this.chanLabel);
            this.liveBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.liveBox.Location = new System.Drawing.Point(16, 166);
            this.liveBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.liveBox.Name = "liveBox";
            this.liveBox.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.liveBox.Size = new System.Drawing.Size(425, 170);
            this.liveBox.TabIndex = 8;
            this.liveBox.TabStop = false;
            this.liveBox.Text = "Live Reading";
            // 
            // BtCaptureGet
            // 
            this.BtCaptureGet.Location = new System.Drawing.Point(305, 89);
            this.BtCaptureGet.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BtCaptureGet.Name = "BtCaptureGet";
            this.BtCaptureGet.Size = new System.Drawing.Size(100, 27);
            this.BtCaptureGet.TabIndex = 23;
            this.BtCaptureGet.Text = "Capture Get";
            this.BtCaptureGet.UseVisualStyleBackColor = true;
            this.BtCaptureGet.Click += new System.EventHandler(this.BtCaptureGet_Click);
            // 
            // ChkFlipped
            // 
            this.ChkFlipped.AutoSize = true;
            this.ChkFlipped.Location = new System.Drawing.Point(265, 61);
            this.ChkFlipped.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ChkFlipped.Name = "ChkFlipped";
            this.ChkFlipped.Size = new System.Drawing.Size(72, 19);
            this.ChkFlipped.TabIndex = 11;
            this.ChkFlipped.Text = "Flipped";
            this.ChkFlipped.UseVisualStyleBackColor = true;
            this.ChkFlipped.CheckedChanged += new System.EventHandler(this.ChkFlipped_CheckedChanged);
            // 
            // BtCaptureSet
            // 
            this.BtCaptureSet.Location = new System.Drawing.Point(305, 119);
            this.BtCaptureSet.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BtCaptureSet.Name = "BtCaptureSet";
            this.BtCaptureSet.Size = new System.Drawing.Size(100, 27);
            this.BtCaptureSet.TabIndex = 22;
            this.BtCaptureSet.Text = "Capture Set";
            this.BtCaptureSet.UseVisualStyleBackColor = true;
            this.BtCaptureSet.Click += new System.EventHandler(this.BtCaptureSet_Click);
            // 
            // ChkRotated
            // 
            this.ChkRotated.AutoSize = true;
            this.ChkRotated.Location = new System.Drawing.Point(265, 33);
            this.ChkRotated.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ChkRotated.Name = "ChkRotated";
            this.ChkRotated.Size = new System.Drawing.Size(72, 19);
            this.ChkRotated.TabIndex = 10;
            this.ChkRotated.Text = "Rotated";
            this.ChkRotated.UseVisualStyleBackColor = true;
            this.ChkRotated.CheckedChanged += new System.EventHandler(this.ChkRotated_CheckedChanged);
            // 
            // intensityUpDown
            // 
            this.intensityUpDown.Location = new System.Drawing.Point(92, 89);
            this.intensityUpDown.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.intensityUpDown.Maximum = new decimal(new int[] {
            180,
            0,
            0,
            0});
            this.intensityUpDown.Name = "intensityUpDown";
            this.intensityUpDown.Size = new System.Drawing.Size(161, 25);
            this.intensityUpDown.TabIndex = 9;
            this.intensityUpDown.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.intensityUpDown.ValueChanged += new System.EventHandler(this.intensityChanged);
            // 
            // procBox
            // 
            this.procBox.Controls.Add(this.ActivateConfig);
            this.procBox.Controls.Add(this.showBestButton);
            this.procBox.Controls.Add(this.showButton);
            this.procBox.Controls.Add(this.processButton);
            this.procBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.procBox.Location = new System.Drawing.Point(16, 343);
            this.procBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.procBox.Name = "procBox";
            this.procBox.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.procBox.Size = new System.Drawing.Size(425, 100);
            this.procBox.TabIndex = 9;
            this.procBox.TabStop = false;
            this.procBox.Text = "Process Reading";
            // 
            // ActivateConfig
            // 
            this.ActivateConfig.Location = new System.Drawing.Point(27, 67);
            this.ActivateConfig.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ActivateConfig.Name = "ActivateConfig";
            this.ActivateConfig.Size = new System.Drawing.Size(127, 27);
            this.ActivateConfig.TabIndex = 3;
            this.ActivateConfig.Text = "Process Config";
            this.ActivateConfig.UseVisualStyleBackColor = true;
            this.ActivateConfig.Click += new System.EventHandler(this.ActivateConfig_Click);
            // 
            // evalBox
            // 
            this.evalBox.Controls.Add(this.TxtProcessTime);
            this.evalBox.Controls.Add(this.BtShowProcessTime);
            this.evalBox.Controls.Add(this.qualityTextBox);
            this.evalBox.Controls.Add(this.codeBox);
            this.evalBox.Controls.Add(this.codeLabel);
            this.evalBox.Controls.Add(this.resultLabel);
            this.evalBox.Controls.Add(this.resultTextBox);
            this.evalBox.Controls.Add(this.codeButton);
            this.evalBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.evalBox.Location = new System.Drawing.Point(16, 450);
            this.evalBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.evalBox.Name = "evalBox";
            this.evalBox.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.evalBox.Size = new System.Drawing.Size(425, 141);
            this.evalBox.TabIndex = 10;
            this.evalBox.TabStop = false;
            this.evalBox.Text = "Evaluation";
            // 
            // TxtProcessTime
            // 
            this.TxtProcessTime.Location = new System.Drawing.Point(185, 93);
            this.TxtProcessTime.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TxtProcessTime.Name = "TxtProcessTime";
            this.TxtProcessTime.ReadOnly = true;
            this.TxtProcessTime.Size = new System.Drawing.Size(132, 25);
            this.TxtProcessTime.TabIndex = 10;
            // 
            // BtShowProcessTime
            // 
            this.BtShowProcessTime.Location = new System.Drawing.Point(27, 91);
            this.BtShowProcessTime.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BtShowProcessTime.Name = "BtShowProcessTime";
            this.BtShowProcessTime.Size = new System.Drawing.Size(151, 27);
            this.BtShowProcessTime.TabIndex = 9;
            this.BtShowProcessTime.Text = "Show Process Time";
            this.BtShowProcessTime.UseVisualStyleBackColor = true;
            this.BtShowProcessTime.Click += new System.EventHandler(this.BtShowProcessTime_Click);
            // 
            // infoTextBox
            // 
            this.infoTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.infoTextBox.CausesValidation = false;
            this.infoTextBox.Location = new System.Drawing.Point(4, 3);
            this.infoTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.infoTextBox.Multiline = true;
            this.infoTextBox.Name = "infoTextBox";
            this.infoTextBox.ReadOnly = true;
            this.infoTextBox.ShortcutsEnabled = false;
            this.infoTextBox.Size = new System.Drawing.Size(228, 55);
            this.infoTextBox.TabIndex = 12;
            // 
            // logMessage
            // 
            this.logMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.logMessage.CausesValidation = false;
            this.logMessage.Location = new System.Drawing.Point(16, 664);
            this.logMessage.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.logMessage.Multiline = true;
            this.logMessage.Name = "logMessage";
            this.logMessage.ReadOnly = true;
            this.logMessage.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.logMessage.Size = new System.Drawing.Size(1170, 285);
            this.logMessage.TabIndex = 13;
            this.logMessage.Text = "AppCs Log Messages:";
            // 
            // BtSave
            // 
            this.BtSave.Location = new System.Drawing.Point(353, 3);
            this.BtSave.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BtSave.Name = "BtSave";
            this.BtSave.Size = new System.Drawing.Size(68, 27);
            this.BtSave.TabIndex = 15;
            this.BtSave.Text = "Save";
            this.BtSave.UseVisualStyleBackColor = true;
            this.BtSave.Click += new System.EventHandler(this.BtSave_Click);
            // 
            // BtSaveJob
            // 
            this.BtSaveJob.Location = new System.Drawing.Point(239, 3);
            this.BtSaveJob.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BtSaveJob.Name = "BtSaveJob";
            this.BtSaveJob.Size = new System.Drawing.Size(112, 27);
            this.BtSaveJob.TabIndex = 16;
            this.BtSaveJob.Text = "Save Job/Cfg";
            this.BtSaveJob.UseVisualStyleBackColor = true;
            this.BtSaveJob.Click += new System.EventHandler(this.BtSaveJob_Click);
            // 
            // BtLoadJob
            // 
            this.BtLoadJob.Location = new System.Drawing.Point(239, 32);
            this.BtLoadJob.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BtLoadJob.Name = "BtLoadJob";
            this.BtLoadJob.Size = new System.Drawing.Size(112, 27);
            this.BtLoadJob.TabIndex = 17;
            this.BtLoadJob.Text = "Load Job/Cfg";
            this.BtLoadJob.UseVisualStyleBackColor = true;
            this.BtLoadJob.Click += new System.EventHandler(this.BtLoadJob_Click);
            // 
            // jobPanel
            // 
            this.jobPanel.Controls.Add(this.infoTextBox);
            this.jobPanel.Controls.Add(this.BtLoadJob);
            this.jobPanel.Controls.Add(this.closeButton);
            this.jobPanel.Controls.Add(this.BtSaveJob);
            this.jobPanel.Controls.Add(this.BtSave);
            this.jobPanel.Location = new System.Drawing.Point(16, 595);
            this.jobPanel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.jobPanel.Name = "jobPanel";
            this.jobPanel.Size = new System.Drawing.Size(425, 63);
            this.jobPanel.TabIndex = 18;
            // 
            // roiBox
            // 
            this.roiBox.Controls.Add(this.TxtYLength);
            this.roiBox.Controls.Add(this.TxtYStart);
            this.roiBox.Controls.Add(this.label2);
            this.roiBox.Controls.Add(this.TxtXLength);
            this.roiBox.Controls.Add(this.TxtXStart);
            this.roiBox.Controls.Add(this.label1);
            this.roiBox.Controls.Add(this.BtGetConfigROI);
            this.roiBox.Controls.Add(this.BtSetConfigROI);
            this.roiBox.Location = new System.Drawing.Point(449, 188);
            this.roiBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.roiBox.Name = "roiBox";
            this.roiBox.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.roiBox.Size = new System.Drawing.Size(379, 128);
            this.roiBox.TabIndex = 19;
            this.roiBox.TabStop = false;
            this.roiBox.Text = "Region of Interest";
            // 
            // TxtYLength
            // 
            this.TxtYLength.Location = new System.Drawing.Point(224, 92);
            this.TxtYLength.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TxtYLength.Name = "TxtYLength";
            this.TxtYLength.Size = new System.Drawing.Size(73, 25);
            this.TxtYLength.TabIndex = 7;
            this.TxtYLength.Text = "304";
            // 
            // TxtYStart
            // 
            this.TxtYStart.Location = new System.Drawing.Point(141, 92);
            this.TxtYStart.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TxtYStart.Name = "TxtYStart";
            this.TxtYStart.Size = new System.Drawing.Size(73, 25);
            this.TxtYStart.TabIndex = 6;
            this.TxtYStart.Text = "32";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 96);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Y-Start / Length";
            // 
            // TxtXLength
            // 
            this.TxtXLength.Location = new System.Drawing.Point(224, 62);
            this.TxtXLength.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TxtXLength.Name = "TxtXLength";
            this.TxtXLength.Size = new System.Drawing.Size(73, 25);
            this.TxtXLength.TabIndex = 4;
            this.TxtXLength.Text = "960";
            // 
            // TxtXStart
            // 
            this.TxtXStart.Location = new System.Drawing.Point(141, 62);
            this.TxtXStart.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TxtXStart.Name = "TxtXStart";
            this.TxtXStart.Size = new System.Drawing.Size(73, 25);
            this.TxtXStart.TabIndex = 3;
            this.TxtXStart.Text = "32";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 66);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "X-Start / Length";
            // 
            // BtGetConfigROI
            // 
            this.BtGetConfigROI.Location = new System.Drawing.Point(157, 22);
            this.BtGetConfigROI.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BtGetConfigROI.Name = "BtGetConfigROI";
            this.BtGetConfigROI.Size = new System.Drawing.Size(141, 27);
            this.BtGetConfigROI.TabIndex = 1;
            this.BtGetConfigROI.Text = "Get Config ROI";
            this.BtGetConfigROI.UseVisualStyleBackColor = true;
            this.BtGetConfigROI.Click += new System.EventHandler(this.BtGetConfigROI_Click);
            // 
            // BtSetConfigROI
            // 
            this.BtSetConfigROI.Location = new System.Drawing.Point(8, 22);
            this.BtSetConfigROI.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BtSetConfigROI.Name = "BtSetConfigROI";
            this.BtSetConfigROI.Size = new System.Drawing.Size(141, 27);
            this.BtSetConfigROI.TabIndex = 0;
            this.BtSetConfigROI.Text = "Set Config ROI";
            this.BtSetConfigROI.UseVisualStyleBackColor = true;
            this.BtSetConfigROI.Click += new System.EventHandler(this.BtSetConfigROI_Click);
            // 
            // ocrParamBox
            // 
            this.ocrParamBox.Controls.Add(this.label11);
            this.ocrParamBox.Controls.Add(this.TxtCharPosY);
            this.ocrParamBox.Controls.Add(this.TxtCharPosX);
            this.ocrParamBox.Controls.Add(this.label9);
            this.ocrParamBox.Controls.Add(this.TxtRotation);
            this.ocrParamBox.Controls.Add(this.TxtCharSizeY);
            this.ocrParamBox.Controls.Add(this.TxtCharSizeX);
            this.ocrParamBox.Controls.Add(this.label8);
            this.ocrParamBox.Controls.Add(this.chkFineScan);
            this.ocrParamBox.Controls.Add(this.TxtSpacing);
            this.ocrParamBox.Controls.Add(this.label7);
            this.ocrParamBox.Controls.Add(this.ChkAdjustSize);
            this.ocrParamBox.Controls.Add(this.TxtAccSimilarity);
            this.ocrParamBox.Controls.Add(this.label6);
            this.ocrParamBox.Controls.Add(this.ChkAdjustSpace);
            this.ocrParamBox.Controls.Add(this.TxtMinSimilarity);
            this.ocrParamBox.Controls.Add(this.label5);
            this.ocrParamBox.Controls.Add(this.TxtFormat);
            this.ocrParamBox.Controls.Add(this.TxtFilter);
            this.ocrParamBox.Controls.Add(this.label4);
            this.ocrParamBox.Controls.Add(this.TxtFielding);
            this.ocrParamBox.Controls.Add(this.cbFontName);
            this.ocrParamBox.Controls.Add(this.label3);
            this.ocrParamBox.Location = new System.Drawing.Point(449, 323);
            this.ocrParamBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ocrParamBox.Name = "ocrParamBox";
            this.ocrParamBox.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ocrParamBox.Size = new System.Drawing.Size(379, 268);
            this.ocrParamBox.TabIndex = 20;
            this.ocrParamBox.TabStop = false;
            this.ocrParamBox.Text = "OCR Parameter";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(15, 232);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 15);
            this.label11.TabIndex = 22;
            this.label11.Text = "Angle";
            // 
            // TxtCharPosY
            // 
            this.TxtCharPosY.Location = new System.Drawing.Point(188, 198);
            this.TxtCharPosY.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TxtCharPosY.Name = "TxtCharPosY";
            this.TxtCharPosY.Size = new System.Drawing.Size(67, 25);
            this.TxtCharPosY.TabIndex = 21;
            // 
            // TxtCharPosX
            // 
            this.TxtCharPosX.Location = new System.Drawing.Point(112, 198);
            this.TxtCharPosX.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TxtCharPosX.Name = "TxtCharPosX";
            this.TxtCharPosX.Size = new System.Drawing.Size(67, 25);
            this.TxtCharPosX.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 202);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(94, 15);
            this.label9.TabIndex = 19;
            this.label9.Text = "Char Pos. (pix)";
            // 
            // TxtRotation
            // 
            this.TxtRotation.Location = new System.Drawing.Point(112, 228);
            this.TxtRotation.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TxtRotation.Name = "TxtRotation";
            this.TxtRotation.Size = new System.Drawing.Size(67, 25);
            this.TxtRotation.TabIndex = 18;
            // 
            // TxtCharSizeY
            // 
            this.TxtCharSizeY.Location = new System.Drawing.Point(188, 168);
            this.TxtCharSizeY.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TxtCharSizeY.Name = "TxtCharSizeY";
            this.TxtCharSizeY.Size = new System.Drawing.Size(67, 25);
            this.TxtCharSizeY.TabIndex = 17;
            // 
            // TxtCharSizeX
            // 
            this.TxtCharSizeX.Location = new System.Drawing.Point(112, 168);
            this.TxtCharSizeX.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TxtCharSizeX.Name = "TxtCharSizeX";
            this.TxtCharSizeX.Size = new System.Drawing.Size(67, 25);
            this.TxtCharSizeX.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 172);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 15);
            this.label8.TabIndex = 15;
            this.label8.Text = "Char Size (pix)";
            // 
            // chkFineScan
            // 
            this.chkFineScan.AutoSize = true;
            this.chkFineScan.Location = new System.Drawing.Point(209, 138);
            this.chkFineScan.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.chkFineScan.Name = "chkFineScan";
            this.chkFineScan.Size = new System.Drawing.Size(85, 19);
            this.chkFineScan.TabIndex = 14;
            this.chkFineScan.Text = "Fine Scan";
            this.chkFineScan.UseVisualStyleBackColor = true;
            // 
            // TxtSpacing
            // 
            this.TxtSpacing.Location = new System.Drawing.Point(112, 135);
            this.TxtSpacing.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TxtSpacing.Name = "TxtSpacing";
            this.TxtSpacing.Size = new System.Drawing.Size(88, 25);
            this.TxtSpacing.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 138);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 15);
            this.label7.TabIndex = 12;
            this.label7.Text = "Spacing";
            // 
            // ChkAdjustSize
            // 
            this.ChkAdjustSize.AutoSize = true;
            this.ChkAdjustSize.Location = new System.Drawing.Point(209, 111);
            this.ChkAdjustSize.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ChkAdjustSize.Name = "ChkAdjustSize";
            this.ChkAdjustSize.Size = new System.Drawing.Size(94, 19);
            this.ChkAdjustSize.TabIndex = 11;
            this.ChkAdjustSize.Text = "Adjust Size";
            this.ChkAdjustSize.UseVisualStyleBackColor = true;
            // 
            // TxtAccSimilarity
            // 
            this.TxtAccSimilarity.Location = new System.Drawing.Point(112, 107);
            this.TxtAccSimilarity.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TxtAccSimilarity.Name = "TxtAccSimilarity";
            this.TxtAccSimilarity.Size = new System.Drawing.Size(88, 25);
            this.TxtAccSimilarity.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 111);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 15);
            this.label6.TabIndex = 9;
            this.label6.Text = "acc. Similarity";
            // 
            // ChkAdjustSpace
            // 
            this.ChkAdjustSpace.AutoSize = true;
            this.ChkAdjustSpace.Location = new System.Drawing.Point(209, 83);
            this.ChkAdjustSpace.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ChkAdjustSpace.Name = "ChkAdjustSpace";
            this.ChkAdjustSpace.Size = new System.Drawing.Size(103, 19);
            this.ChkAdjustSpace.TabIndex = 8;
            this.ChkAdjustSpace.Text = "Adjust Space";
            this.ChkAdjustSpace.UseVisualStyleBackColor = true;
            // 
            // TxtMinSimilarity
            // 
            this.TxtMinSimilarity.Location = new System.Drawing.Point(112, 80);
            this.TxtMinSimilarity.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TxtMinSimilarity.Name = "TxtMinSimilarity";
            this.TxtMinSimilarity.Size = new System.Drawing.Size(88, 25);
            this.TxtMinSimilarity.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 83);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "min Similarity";
            // 
            // TxtFormat
            // 
            this.TxtFormat.Location = new System.Drawing.Point(209, 52);
            this.TxtFormat.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TxtFormat.Name = "TxtFormat";
            this.TxtFormat.Size = new System.Drawing.Size(136, 25);
            this.TxtFormat.TabIndex = 5;
            // 
            // TxtFilter
            // 
            this.TxtFilter.Location = new System.Drawing.Point(112, 52);
            this.TxtFilter.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TxtFilter.Name = "TxtFilter";
            this.TxtFilter.Size = new System.Drawing.Size(88, 25);
            this.TxtFilter.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 55);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Filter / Output";
            // 
            // TxtFielding
            // 
            this.TxtFielding.Location = new System.Drawing.Point(209, 24);
            this.TxtFielding.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TxtFielding.Name = "TxtFielding";
            this.TxtFielding.Size = new System.Drawing.Size(136, 25);
            this.TxtFielding.TabIndex = 2;
            // 
            // cbFontName
            // 
            this.cbFontName.FormattingEnabled = true;
            this.cbFontName.Location = new System.Drawing.Point(112, 23);
            this.cbFontName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbFontName.Name = "cbFontName";
            this.cbFontName.Size = new System.Drawing.Size(88, 23);
            this.cbFontName.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 27);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Font / Text";
            // 
            // teachingBox
            // 
            this.teachingBox.Controls.Add(this.LbDmrLearn);
            this.teachingBox.Controls.Add(this.LbBcrLearn);
            this.teachingBox.Controls.Add(this.LbDmrTeach);
            this.teachingBox.Controls.Add(this.LbBcrTeach);
            this.teachingBox.Controls.Add(this.BtResetCycle);
            this.teachingBox.Controls.Add(this.BtDeleteConfig);
            this.teachingBox.Controls.Add(this.LbOcrLearn);
            this.teachingBox.Controls.Add(this.BtConfigureDMR);
            this.teachingBox.Controls.Add(this.BtConfigureOCR);
            this.teachingBox.Controls.Add(this.BtConfigureBCR);
            this.teachingBox.Controls.Add(this.BtConfigPreset);
            this.teachingBox.Controls.Add(this.LbOcrTeach);
            this.teachingBox.Controls.Add(this.txtConfigName);
            this.teachingBox.Controls.Add(this.BtTeachDMR);
            this.teachingBox.Controls.Add(this.BtTeachOCR);
            this.teachingBox.Controls.Add(this.BtTeachBCR);
            this.teachingBox.Location = new System.Drawing.Point(449, 14);
            this.teachingBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.teachingBox.Name = "teachingBox";
            this.teachingBox.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.teachingBox.Size = new System.Drawing.Size(737, 167);
            this.teachingBox.TabIndex = 21;
            this.teachingBox.TabStop = false;
            this.teachingBox.Text = "Teaching";
            // 
            // LbDmrLearn
            // 
            this.LbDmrLearn.AutoSize = true;
            this.LbDmrLearn.Location = new System.Drawing.Point(465, 77);
            this.LbDmrLearn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LbDmrLearn.Name = "LbDmrLearn";
            this.LbDmrLearn.Size = new System.Drawing.Size(19, 15);
            this.LbDmrLearn.TabIndex = 15;
            this.LbDmrLearn.Text = "...";
            // 
            // LbBcrLearn
            // 
            this.LbBcrLearn.AutoSize = true;
            this.LbBcrLearn.Location = new System.Drawing.Point(465, 24);
            this.LbBcrLearn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LbBcrLearn.Name = "LbBcrLearn";
            this.LbBcrLearn.Size = new System.Drawing.Size(19, 15);
            this.LbBcrLearn.TabIndex = 14;
            this.LbBcrLearn.Text = "...";
            // 
            // LbDmrTeach
            // 
            this.LbDmrTeach.AutoSize = true;
            this.LbDmrTeach.Location = new System.Drawing.Point(117, 77);
            this.LbDmrTeach.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LbDmrTeach.Name = "LbDmrTeach";
            this.LbDmrTeach.Size = new System.Drawing.Size(19, 15);
            this.LbDmrTeach.TabIndex = 13;
            this.LbDmrTeach.Text = "...";
            // 
            // LbBcrTeach
            // 
            this.LbBcrTeach.AutoSize = true;
            this.LbBcrTeach.Location = new System.Drawing.Point(117, 24);
            this.LbBcrTeach.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LbBcrTeach.Name = "LbBcrTeach";
            this.LbBcrTeach.Size = new System.Drawing.Size(19, 15);
            this.LbBcrTeach.TabIndex = 12;
            this.LbBcrTeach.Text = "...";
            // 
            // BtResetCycle
            // 
            this.BtResetCycle.Location = new System.Drawing.Point(460, 100);
            this.BtResetCycle.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BtResetCycle.Name = "BtResetCycle";
            this.BtResetCycle.Size = new System.Drawing.Size(97, 27);
            this.BtResetCycle.TabIndex = 11;
            this.BtResetCycle.Text = "Reset Cycle";
            this.BtResetCycle.UseVisualStyleBackColor = true;
            this.BtResetCycle.Click += new System.EventHandler(this.BtResetCycle_Click);
            // 
            // BtDeleteConfig
            // 
            this.BtDeleteConfig.Location = new System.Drawing.Point(340, 100);
            this.BtDeleteConfig.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BtDeleteConfig.Name = "BtDeleteConfig";
            this.BtDeleteConfig.Size = new System.Drawing.Size(117, 27);
            this.BtDeleteConfig.TabIndex = 10;
            this.BtDeleteConfig.Text = "Delete Config";
            this.BtDeleteConfig.UseVisualStyleBackColor = true;
            this.BtDeleteConfig.Click += new System.EventHandler(this.BtDeleteConfig_Click);
            // 
            // LbOcrLearn
            // 
            this.LbOcrLearn.AutoSize = true;
            this.LbOcrLearn.Location = new System.Drawing.Point(465, 47);
            this.LbOcrLearn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LbOcrLearn.Name = "LbOcrLearn";
            this.LbOcrLearn.Size = new System.Drawing.Size(19, 15);
            this.LbOcrLearn.TabIndex = 9;
            this.LbOcrLearn.Text = "...";
            // 
            // BtConfigureDMR
            // 
            this.BtConfigureDMR.Location = new System.Drawing.Point(340, 72);
            this.BtConfigureDMR.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BtConfigureDMR.Name = "BtConfigureDMR";
            this.BtConfigureDMR.Size = new System.Drawing.Size(117, 27);
            this.BtConfigureDMR.TabIndex = 8;
            this.BtConfigureDMR.Text = "Configure DMR";
            this.BtConfigureDMR.UseVisualStyleBackColor = true;
            this.BtConfigureDMR.Click += new System.EventHandler(this.BtConfigureDMR_Click);
            // 
            // BtConfigureOCR
            // 
            this.BtConfigureOCR.Location = new System.Drawing.Point(340, 42);
            this.BtConfigureOCR.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BtConfigureOCR.Name = "BtConfigureOCR";
            this.BtConfigureOCR.Size = new System.Drawing.Size(117, 27);
            this.BtConfigureOCR.TabIndex = 7;
            this.BtConfigureOCR.Text = "Configure OCR";
            this.BtConfigureOCR.UseVisualStyleBackColor = true;
            this.BtConfigureOCR.Click += new System.EventHandler(this.BtConfigureOCR_Click);
            // 
            // BtConfigureBCR
            // 
            this.BtConfigureBCR.Location = new System.Drawing.Point(340, 18);
            this.BtConfigureBCR.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BtConfigureBCR.Name = "BtConfigureBCR";
            this.BtConfigureBCR.Size = new System.Drawing.Size(117, 27);
            this.BtConfigureBCR.TabIndex = 6;
            this.BtConfigureBCR.Text = "Configure BCR";
            this.BtConfigureBCR.UseVisualStyleBackColor = true;
            this.BtConfigureBCR.Click += new System.EventHandler(this.BtConfigureBCR_Click);
            // 
            // BtConfigPreset
            // 
            this.BtConfigPreset.Location = new System.Drawing.Point(11, 133);
            this.BtConfigPreset.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BtConfigPreset.Name = "BtConfigPreset";
            this.BtConfigPreset.Size = new System.Drawing.Size(263, 27);
            this.BtConfigPreset.TabIndex = 5;
            this.BtConfigPreset.Text = "Create Config using Setted Values";
            this.BtConfigPreset.UseVisualStyleBackColor = true;
            this.BtConfigPreset.Click += new System.EventHandler(this.BtConfigPreset_Click);
            // 
            // LbOcrTeach
            // 
            this.LbOcrTeach.AutoSize = true;
            this.LbOcrTeach.Location = new System.Drawing.Point(117, 51);
            this.LbOcrTeach.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LbOcrTeach.Name = "LbOcrTeach";
            this.LbOcrTeach.Size = new System.Drawing.Size(19, 15);
            this.LbOcrTeach.TabIndex = 4;
            this.LbOcrTeach.Text = "...";
            // 
            // txtConfigName
            // 
            this.txtConfigName.Location = new System.Drawing.Point(11, 103);
            this.txtConfigName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtConfigName.Name = "txtConfigName";
            this.txtConfigName.Size = new System.Drawing.Size(137, 25);
            this.txtConfigName.TabIndex = 3;
            // 
            // BtTeachDMR
            // 
            this.BtTeachDMR.Location = new System.Drawing.Point(11, 72);
            this.BtTeachDMR.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BtTeachDMR.Name = "BtTeachDMR";
            this.BtTeachDMR.Size = new System.Drawing.Size(99, 27);
            this.BtTeachDMR.TabIndex = 2;
            this.BtTeachDMR.Text = "Teach DMR";
            this.BtTeachDMR.UseVisualStyleBackColor = true;
            this.BtTeachDMR.Click += new System.EventHandler(this.BtTeachDMR_Click);
            // 
            // BtTeachOCR
            // 
            this.BtTeachOCR.Location = new System.Drawing.Point(11, 45);
            this.BtTeachOCR.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BtTeachOCR.Name = "BtTeachOCR";
            this.BtTeachOCR.Size = new System.Drawing.Size(99, 27);
            this.BtTeachOCR.TabIndex = 1;
            this.BtTeachOCR.Text = "Teach OCR";
            this.BtTeachOCR.UseVisualStyleBackColor = true;
            this.BtTeachOCR.Click += new System.EventHandler(this.BtTeachOCR_Click);
            // 
            // BtTeachBCR
            // 
            this.BtTeachBCR.Location = new System.Drawing.Point(11, 18);
            this.BtTeachBCR.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BtTeachBCR.Name = "BtTeachBCR";
            this.BtTeachBCR.Size = new System.Drawing.Size(99, 27);
            this.BtTeachBCR.TabIndex = 0;
            this.BtTeachBCR.Text = "Teach BCR";
            this.BtTeachBCR.UseVisualStyleBackColor = true;
            this.BtTeachBCR.Click += new System.EventHandler(this.BtTeachBCR_Click);
            // 
            // saveDialog
            // 
            this.saveDialog.Filter = "JOB Files (*.job)|*.job|CFG Files (*.cfg)|*.cfg";
            this.saveDialog.Title = "Save Job Files";
            // 
            // imgaeBox
            // 
            this.imgaeBox.Controls.Add(this.TxtImageSizeY);
            this.imgaeBox.Controls.Add(this.TxtImageSizeX);
            this.imgaeBox.Controls.Add(this.label10);
            this.imgaeBox.Location = new System.Drawing.Point(449, 599);
            this.imgaeBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.imgaeBox.Name = "imgaeBox";
            this.imgaeBox.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.imgaeBox.Size = new System.Drawing.Size(379, 62);
            this.imgaeBox.TabIndex = 22;
            this.imgaeBox.TabStop = false;
            this.imgaeBox.Text = "Image";
            // 
            // TxtImageSizeY
            // 
            this.TxtImageSizeY.Location = new System.Drawing.Point(188, 24);
            this.TxtImageSizeY.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TxtImageSizeY.Name = "TxtImageSizeY";
            this.TxtImageSizeY.ReadOnly = true;
            this.TxtImageSizeY.Size = new System.Drawing.Size(83, 25);
            this.TxtImageSizeY.TabIndex = 2;
            // 
            // TxtImageSizeX
            // 
            this.TxtImageSizeX.Location = new System.Drawing.Point(96, 24);
            this.TxtImageSizeX.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TxtImageSizeX.Name = "TxtImageSizeX";
            this.TxtImageSizeX.ReadOnly = true;
            this.TxtImageSizeX.Size = new System.Drawing.Size(83, 25);
            this.TxtImageSizeX.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(15, 28);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 15);
            this.label10.TabIndex = 0;
            this.label10.Text = "Size X / Y";
            // 
            // bcrParamBox
            // 
            this.bcrParamBox.Controls.Add(this.TxtBCRFormat);
            this.bcrParamBox.Controls.Add(this.label13);
            this.bcrParamBox.Controls.Add(this.TxtBCRTable);
            this.bcrParamBox.Controls.Add(this.label12);
            this.bcrParamBox.Controls.Add(this.ChkBcrAltis);
            this.bcrParamBox.Controls.Add(this.ChkBcrLowContrast);
            this.bcrParamBox.Controls.Add(this.ChkBcrChecksum);
            this.bcrParamBox.Controls.Add(this.CbBcrResolution);
            this.bcrParamBox.Controls.Add(this.CbBcrSeparator);
            this.bcrParamBox.Controls.Add(this.CbBcrDigits);
            this.bcrParamBox.Controls.Add(this.CbBcrChars);
            this.bcrParamBox.Controls.Add(this.CbBcrTiConv);
            this.bcrParamBox.Controls.Add(this.ChkBcrSemi);
            this.bcrParamBox.Controls.Add(this.CbBcrIbmConv);
            this.bcrParamBox.Controls.Add(this.ChkBcrLTOR);
            this.bcrParamBox.Controls.Add(this.ChkBcrRTOL);
            this.bcrParamBox.Location = new System.Drawing.Point(836, 195);
            this.bcrParamBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bcrParamBox.Name = "bcrParamBox";
            this.bcrParamBox.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bcrParamBox.Size = new System.Drawing.Size(351, 298);
            this.bcrParamBox.TabIndex = 23;
            this.bcrParamBox.TabStop = false;
            this.bcrParamBox.Text = "BCR-Parameter";
            // 
            // TxtBCRFormat
            // 
            this.TxtBCRFormat.Location = new System.Drawing.Point(71, 264);
            this.TxtBCRFormat.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TxtBCRFormat.Name = "TxtBCRFormat";
            this.TxtBCRFormat.Size = new System.Drawing.Size(264, 25);
            this.TxtBCRFormat.TabIndex = 15;
            this.TxtBCRFormat.Text = "++++++++++";
            this.TxtBCRFormat.Leave += new System.EventHandler(this.EditBCRTextBox_Leave);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(17, 268);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(48, 15);
            this.label13.TabIndex = 14;
            this.label13.Text = "Format";
            // 
            // TxtBCRTable
            // 
            this.TxtBCRTable.Location = new System.Drawing.Point(71, 235);
            this.TxtBCRTable.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TxtBCRTable.Name = "TxtBCRTable";
            this.TxtBCRTable.Size = new System.Drawing.Size(264, 25);
            this.TxtBCRTable.TabIndex = 13;
            this.TxtBCRTable.Text = "BCR-Table";
            this.TxtBCRTable.Leave += new System.EventHandler(this.EditBCRTextBox_Leave);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(17, 239);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(39, 15);
            this.label12.TabIndex = 12;
            this.label12.Text = "Table";
            // 
            // ChkBcrAltis
            // 
            this.ChkBcrAltis.AutoSize = true;
            this.ChkBcrAltis.Location = new System.Drawing.Point(175, 213);
            this.ChkBcrAltis.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ChkBcrAltis.Name = "ChkBcrAltis";
            this.ChkBcrAltis.Size = new System.Drawing.Size(99, 19);
            this.ChkBcrAltis.TabIndex = 11;
            this.ChkBcrAltis.Text = "Enable Altis";
            this.ChkBcrAltis.UseVisualStyleBackColor = true;
            // 
            // ChkBcrLowContrast
            // 
            this.ChkBcrLowContrast.AutoSize = true;
            this.ChkBcrLowContrast.Location = new System.Drawing.Point(175, 187);
            this.ChkBcrLowContrast.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ChkBcrLowContrast.Name = "ChkBcrLowContrast";
            this.ChkBcrLowContrast.Size = new System.Drawing.Size(106, 19);
            this.ChkBcrLowContrast.TabIndex = 10;
            this.ChkBcrLowContrast.Text = "Low Contrast";
            this.ChkBcrLowContrast.UseVisualStyleBackColor = true;
            // 
            // ChkBcrChecksum
            // 
            this.ChkBcrChecksum.AutoSize = true;
            this.ChkBcrChecksum.Location = new System.Drawing.Point(21, 187);
            this.ChkBcrChecksum.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ChkBcrChecksum.Name = "ChkBcrChecksum";
            this.ChkBcrChecksum.Size = new System.Drawing.Size(131, 19);
            this.ChkBcrChecksum.TabIndex = 9;
            this.ChkBcrChecksum.Text = "Show Check Char";
            this.ChkBcrChecksum.UseVisualStyleBackColor = true;
            // 
            // CbBcrResolution
            // 
            this.CbBcrResolution.FormattingEnabled = true;
            this.CbBcrResolution.Items.AddRange(new object[] {
            "Semi Standard",
            "High Resolution",
            "Semi & High"});
            this.CbBcrResolution.Location = new System.Drawing.Point(175, 149);
            this.CbBcrResolution.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.CbBcrResolution.Name = "CbBcrResolution";
            this.CbBcrResolution.Size = new System.Drawing.Size(160, 23);
            this.CbBcrResolution.TabIndex = 8;
            // 
            // CbBcrSeparator
            // 
            this.CbBcrSeparator.FormattingEnabled = true;
            this.CbBcrSeparator.Items.AddRange(new object[] {
            "none",
            "<dash>",
            "<dot>",
            "<blank>"});
            this.CbBcrSeparator.Location = new System.Drawing.Point(21, 149);
            this.CbBcrSeparator.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.CbBcrSeparator.Name = "CbBcrSeparator";
            this.CbBcrSeparator.Size = new System.Drawing.Size(144, 23);
            this.CbBcrSeparator.TabIndex = 7;
            // 
            // CbBcrDigits
            // 
            this.CbBcrDigits.FormattingEnabled = true;
            this.CbBcrDigits.Items.AddRange(new object[] {
            "2 digits",
            "suppress leading zero",
            "3 digits"});
            this.CbBcrDigits.Location = new System.Drawing.Point(175, 118);
            this.CbBcrDigits.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.CbBcrDigits.Name = "CbBcrDigits";
            this.CbBcrDigits.Size = new System.Drawing.Size(160, 23);
            this.CbBcrDigits.TabIndex = 6;
            // 
            // CbBcrChars
            // 
            this.CbBcrChars.FormattingEnabled = true;
            this.CbBcrChars.Items.AddRange(new object[] {
            "Auto",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18"});
            this.CbBcrChars.Location = new System.Drawing.Point(21, 118);
            this.CbBcrChars.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.CbBcrChars.Name = "CbBcrChars";
            this.CbBcrChars.Size = new System.Drawing.Size(144, 23);
            this.CbBcrChars.TabIndex = 5;
            // 
            // CbBcrTiConv
            // 
            this.CbBcrTiConv.FormattingEnabled = true;
            this.CbBcrTiConv.Items.AddRange(new object[] {
            "none",
            "Base35",
            "Custom",
            "Custom Checksum"});
            this.CbBcrTiConv.Location = new System.Drawing.Point(175, 82);
            this.CbBcrTiConv.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.CbBcrTiConv.Name = "CbBcrTiConv";
            this.CbBcrTiConv.Size = new System.Drawing.Size(160, 23);
            this.CbBcrTiConv.TabIndex = 4;
            // 
            // ChkBcrSemi
            // 
            this.ChkBcrSemi.AutoSize = true;
            this.ChkBcrSemi.Location = new System.Drawing.Point(21, 84);
            this.ChkBcrSemi.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ChkBcrSemi.Name = "ChkBcrSemi";
            this.ChkBcrSemi.Size = new System.Drawing.Size(58, 19);
            this.ChkBcrSemi.TabIndex = 3;
            this.ChkBcrSemi.Text = "Semi";
            this.ChkBcrSemi.UseVisualStyleBackColor = true;
            // 
            // CbBcrIbmConv
            // 
            this.CbBcrIbmConv.FormattingEnabled = true;
            this.CbBcrIbmConv.Items.AddRange(new object[] {
            "none",
            "Base35",
            "programmable"});
            this.CbBcrIbmConv.Location = new System.Drawing.Point(175, 38);
            this.CbBcrIbmConv.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.CbBcrIbmConv.Name = "CbBcrIbmConv";
            this.CbBcrIbmConv.Size = new System.Drawing.Size(160, 23);
            this.CbBcrIbmConv.TabIndex = 2;
            // 
            // ChkBcrLTOR
            // 
            this.ChkBcrLTOR.AutoSize = true;
            this.ChkBcrLTOR.Location = new System.Drawing.Point(21, 54);
            this.ChkBcrLTOR.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ChkBcrLTOR.Name = "ChkBcrLTOR";
            this.ChkBcrLTOR.Size = new System.Drawing.Size(139, 19);
            this.ChkBcrLTOR.TabIndex = 1;
            this.ChkBcrLTOR.Text = "IBM Left To Right";
            this.ChkBcrLTOR.UseVisualStyleBackColor = true;
            // 
            // ChkBcrRTOL
            // 
            this.ChkBcrRTOL.AutoSize = true;
            this.ChkBcrRTOL.Location = new System.Drawing.Point(21, 31);
            this.ChkBcrRTOL.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ChkBcrRTOL.Name = "ChkBcrRTOL";
            this.ChkBcrRTOL.Size = new System.Drawing.Size(139, 19);
            this.ChkBcrRTOL.TabIndex = 0;
            this.ChkBcrRTOL.Text = "IBM Right To Left";
            this.ChkBcrRTOL.UseVisualStyleBackColor = true;
            // 
            // dmrParamBox
            // 
            this.dmrParamBox.Controls.Add(this.TxtDMRFormat);
            this.dmrParamBox.Controls.Add(this.label14);
            this.dmrParamBox.Controls.Add(this.ChkDmrLinInv);
            this.dmrParamBox.Controls.Add(this.ChkDmrLinNrm);
            this.dmrParamBox.Controls.Add(this.ChkDmrDotInv);
            this.dmrParamBox.Controls.Add(this.ChkDmrDotNrm);
            this.dmrParamBox.Controls.Add(this.CbDmrCodeSize);
            this.dmrParamBox.Controls.Add(this.CbDmrMirror);
            this.dmrParamBox.Controls.Add(this.CbDmrSymbol);
            this.dmrParamBox.Location = new System.Drawing.Point(836, 500);
            this.dmrParamBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dmrParamBox.Name = "dmrParamBox";
            this.dmrParamBox.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dmrParamBox.Size = new System.Drawing.Size(351, 162);
            this.dmrParamBox.TabIndex = 24;
            this.dmrParamBox.TabStop = false;
            this.dmrParamBox.Text = "DMR Parameter";
            // 
            // TxtDMRFormat
            // 
            this.TxtDMRFormat.Location = new System.Drawing.Point(71, 130);
            this.TxtDMRFormat.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TxtDMRFormat.Name = "TxtDMRFormat";
            this.TxtDMRFormat.Size = new System.Drawing.Size(264, 25);
            this.TxtDMRFormat.TabIndex = 17;
            this.TxtDMRFormat.Text = "++++++++++";
            this.TxtDMRFormat.Leave += new System.EventHandler(this.TxtDMRFormat_Leave);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(17, 134);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(48, 15);
            this.label14.TabIndex = 16;
            this.label14.Text = "Format";
            // 
            // ChkDmrLinInv
            // 
            this.ChkDmrLinInv.AutoSize = true;
            this.ChkDmrLinInv.Location = new System.Drawing.Point(185, 104);
            this.ChkDmrLinInv.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ChkDmrLinInv.Name = "ChkDmrLinInv";
            this.ChkDmrLinInv.Size = new System.Drawing.Size(87, 19);
            this.ChkDmrLinInv.TabIndex = 6;
            this.ChkDmrLinInv.Text = "Lin White";
            this.ChkDmrLinInv.UseVisualStyleBackColor = true;
            // 
            // ChkDmrLinNrm
            // 
            this.ChkDmrLinNrm.AutoSize = true;
            this.ChkDmrLinNrm.Checked = true;
            this.ChkDmrLinNrm.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ChkDmrLinNrm.Location = new System.Drawing.Point(185, 76);
            this.ChkDmrLinNrm.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ChkDmrLinNrm.Name = "ChkDmrLinNrm";
            this.ChkDmrLinNrm.Size = new System.Drawing.Size(85, 19);
            this.ChkDmrLinNrm.TabIndex = 5;
            this.ChkDmrLinNrm.Text = "Lin Black";
            this.ChkDmrLinNrm.UseVisualStyleBackColor = true;
            // 
            // ChkDmrDotInv
            // 
            this.ChkDmrDotInv.AutoSize = true;
            this.ChkDmrDotInv.Location = new System.Drawing.Point(185, 46);
            this.ChkDmrDotInv.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ChkDmrDotInv.Name = "ChkDmrDotInv";
            this.ChkDmrDotInv.Size = new System.Drawing.Size(88, 19);
            this.ChkDmrDotInv.TabIndex = 4;
            this.ChkDmrDotInv.Text = "Dot White";
            this.ChkDmrDotInv.UseVisualStyleBackColor = true;
            // 
            // ChkDmrDotNrm
            // 
            this.ChkDmrDotNrm.AutoSize = true;
            this.ChkDmrDotNrm.Checked = true;
            this.ChkDmrDotNrm.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ChkDmrDotNrm.Location = new System.Drawing.Point(185, 20);
            this.ChkDmrDotNrm.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ChkDmrDotNrm.Name = "ChkDmrDotNrm";
            this.ChkDmrDotNrm.Size = new System.Drawing.Size(86, 19);
            this.ChkDmrDotNrm.TabIndex = 3;
            this.ChkDmrDotNrm.Text = "Dot Black";
            this.ChkDmrDotNrm.UseVisualStyleBackColor = true;
            // 
            // CbDmrCodeSize
            // 
            this.CbDmrCodeSize.FormattingEnabled = true;
            this.CbDmrCodeSize.Items.AddRange(new object[] {
            "large",
            "semi",
            "small",
            "tiny"});
            this.CbDmrCodeSize.Location = new System.Drawing.Point(11, 99);
            this.CbDmrCodeSize.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.CbDmrCodeSize.Name = "CbDmrCodeSize";
            this.CbDmrCodeSize.Size = new System.Drawing.Size(160, 23);
            this.CbDmrCodeSize.TabIndex = 2;
            // 
            // CbDmrMirror
            // 
            this.CbDmrMirror.FormattingEnabled = true;
            this.CbDmrMirror.Items.AddRange(new object[] {
            "normal",
            "mirrored"});
            this.CbDmrMirror.Location = new System.Drawing.Point(11, 59);
            this.CbDmrMirror.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.CbDmrMirror.Name = "CbDmrMirror";
            this.CbDmrMirror.Size = new System.Drawing.Size(160, 23);
            this.CbDmrMirror.TabIndex = 1;
            // 
            // CbDmrSymbol
            // 
            this.CbDmrSymbol.FormattingEnabled = true;
            this.CbDmrSymbol.Items.AddRange(new object[] {
            "DataMatrix",
            "QR-Code"});
            this.CbDmrSymbol.Location = new System.Drawing.Point(11, 20);
            this.CbDmrSymbol.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.CbDmrSymbol.Name = "CbDmrSymbol";
            this.CbDmrSymbol.Size = new System.Drawing.Size(160, 23);
            this.CbDmrSymbol.TabIndex = 0;
            // 
            // AppCsDevel
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1213, 961);
            this.ControlBox = false;
            this.Controls.Add(this.dmrParamBox);
            this.Controls.Add(this.bcrParamBox);
            this.Controls.Add(this.imgaeBox);
            this.Controls.Add(this.teachingBox);
            this.Controls.Add(this.ocrParamBox);
            this.Controls.Add(this.roiBox);
            this.Controls.Add(this.jobPanel);
            this.Controls.Add(this.logMessage);
            this.Controls.Add(this.evalBox);
            this.Controls.Add(this.confBox);
            this.Controls.Add(this.procBox);
            this.Controls.Add(this.liveBox);
            this.Controls.Add(this.connBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "AppCsDevel";
            this.Text = "WID Reader C# Example";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AppCsDevel_FormClosing);
            this.connBox.ResumeLayout(false);
            this.connBox.PerformLayout();
            this.confBox.ResumeLayout(false);
            this.confBox.PerformLayout();
            this.liveBox.ResumeLayout(false);
            this.liveBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.intensityUpDown)).EndInit();
            this.procBox.ResumeLayout(false);
            this.evalBox.ResumeLayout(false);
            this.evalBox.PerformLayout();
            this.jobPanel.ResumeLayout(false);
            this.jobPanel.PerformLayout();
            this.roiBox.ResumeLayout(false);
            this.roiBox.PerformLayout();
            this.ocrParamBox.ResumeLayout(false);
            this.ocrParamBox.PerformLayout();
            this.teachingBox.ResumeLayout(false);
            this.teachingBox.PerformLayout();
            this.imgaeBox.ResumeLayout(false);
            this.imgaeBox.PerformLayout();
            this.bcrParamBox.ResumeLayout(false);
            this.bcrParamBox.PerformLayout();
            this.dmrParamBox.ResumeLayout(false);
            this.dmrParamBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        // ====================================================================
        /// <summary>
        /// Private member variables.
        /// </summary>
        // ====================================================================

        private System.Windows.Forms.Button configButton;
        private System.Windows.Forms.Button decodeButton;
        private System.Windows.Forms.Button snapButton;
        private System.Windows.Forms.Button showButton;
        private System.Windows.Forms.Button showBestButton;
        private System.Windows.Forms.Button processButton;
        private System.Windows.Forms.Button codeButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button connectButton;

        private System.Windows.Forms.TextBox slotTextBox;
        private System.Windows.Forms.TextBox qualityTextBox;
        private System.Windows.Forms.TextBox resultTextBox;
        private System.Windows.Forms.TextBox ipTextBox;
        private System.Windows.Forms.TextBox infoTextBox;
        private System.Windows.Forms.TextBox logMessage;

        private System.Windows.Forms.ComboBox channelBox;
        private System.Windows.Forms.ComboBox colorBox;
        private System.Windows.Forms.ComboBox codeBox;

        private System.Windows.Forms.Label confLabel;
        private System.Windows.Forms.Label intensLabel;
        private System.Windows.Forms.Label chanLabel;
        private System.Windows.Forms.Label colorLabel;
        private System.Windows.Forms.Label codeLabel;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.Label ipLabel;

        private System.Windows.Forms.NumericUpDown intensityUpDown;

        private System.Windows.Forms.GroupBox connBox;
        private System.Windows.Forms.GroupBox confBox;
        private System.Windows.Forms.GroupBox liveBox;
        private System.Windows.Forms.GroupBox procBox;
        private System.Windows.Forms.GroupBox evalBox;

        private System.Windows.Forms.OpenFileDialog openDialog;
        private System.Windows.Forms.Button checkConnection;
        private System.Windows.Forms.CheckBox ChkFlipped;
        private System.Windows.Forms.CheckBox ChkRotated;
        private System.Windows.Forms.Button BtSave;
        private System.Windows.Forms.Button BtSaveJob;
        private System.Windows.Forms.Button BtLoadJob;
        private System.Windows.Forms.TextBox TxtProcessTime;
        private System.Windows.Forms.Button BtShowProcessTime;
        private System.Windows.Forms.Panel jobPanel;
        private System.Windows.Forms.GroupBox roiBox;
        private System.Windows.Forms.TextBox TxtYLength;
        private System.Windows.Forms.TextBox TxtYStart;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtXLength;
        private System.Windows.Forms.TextBox TxtXStart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtGetConfigROI;
        private System.Windows.Forms.Button BtSetConfigROI;
        private System.Windows.Forms.GroupBox ocrParamBox;
        private System.Windows.Forms.TextBox TxtFielding;
        private System.Windows.Forms.ComboBox cbFontName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtCharPosY;
        private System.Windows.Forms.TextBox TxtCharPosX;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TxtRotation;
        private System.Windows.Forms.TextBox TxtCharSizeY;
        private System.Windows.Forms.TextBox TxtCharSizeX;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox chkFineScan;
        private System.Windows.Forms.TextBox TxtSpacing;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox ChkAdjustSize;
        private System.Windows.Forms.TextBox TxtAccSimilarity;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox ChkAdjustSpace;
        private System.Windows.Forms.TextBox TxtMinSimilarity;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtFormat;
        private System.Windows.Forms.TextBox TxtFilter;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox teachingBox;
        private System.Windows.Forms.Button BtResetCycle;
        private System.Windows.Forms.Button BtDeleteConfig;
        private System.Windows.Forms.Label LbOcrLearn;
        private System.Windows.Forms.Button BtConfigureDMR;
        private System.Windows.Forms.Button BtConfigureOCR;
        private System.Windows.Forms.Button BtConfigureBCR;
        private System.Windows.Forms.Button BtConfigPreset;
        private System.Windows.Forms.Label LbOcrTeach;
        private System.Windows.Forms.TextBox txtConfigName;
        private System.Windows.Forms.Button BtTeachDMR;
        private System.Windows.Forms.Button BtTeachOCR;
        private System.Windows.Forms.Button BtTeachBCR;
        private System.Windows.Forms.Button BtCaptureSet;
        private System.Windows.Forms.Button BtCaptureGet;
        private System.Windows.Forms.SaveFileDialog saveDialog;
        private System.Windows.Forms.GroupBox imgaeBox;
        private System.Windows.Forms.TextBox TxtImageSizeY;
        private System.Windows.Forms.TextBox TxtImageSizeX;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox bcrParamBox;
        private System.Windows.Forms.ComboBox CbBcrIbmConv;
        private System.Windows.Forms.CheckBox ChkBcrLTOR;
        private System.Windows.Forms.CheckBox ChkBcrRTOL;
        private System.Windows.Forms.CheckBox ChkBcrSemi;
        private System.Windows.Forms.TextBox TxtBCRTable;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.CheckBox ChkBcrAltis;
        private System.Windows.Forms.CheckBox ChkBcrLowContrast;
        private System.Windows.Forms.CheckBox ChkBcrChecksum;
        private System.Windows.Forms.ComboBox CbBcrResolution;
        private System.Windows.Forms.ComboBox CbBcrSeparator;
        private System.Windows.Forms.ComboBox CbBcrDigits;
        private System.Windows.Forms.ComboBox CbBcrChars;
        private System.Windows.Forms.ComboBox CbBcrTiConv;
        private System.Windows.Forms.GroupBox dmrParamBox;
        private System.Windows.Forms.CheckBox ChkDmrLinInv;
        private System.Windows.Forms.CheckBox ChkDmrLinNrm;
        private System.Windows.Forms.CheckBox ChkDmrDotInv;
        private System.Windows.Forms.CheckBox ChkDmrDotNrm;
        private System.Windows.Forms.ComboBox CbDmrCodeSize;
        private System.Windows.Forms.ComboBox CbDmrMirror;
        private System.Windows.Forms.ComboBox CbDmrSymbol;
        private System.Windows.Forms.Label LbDmrLearn;
        private System.Windows.Forms.Label LbBcrLearn;
        private System.Windows.Forms.Label LbDmrTeach;
        private System.Windows.Forms.Label LbBcrTeach;
        private System.Windows.Forms.TextBox TxtBCRFormat;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox TxtDMRFormat;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button ActivateConfig;
    }
}

