// ============================================================================
// Copyright (c) 2010  IOSS GmbH
// All Rights Reserved.
// ============================================================================


// ============================================================================
//
//      AppCsForm  -  C# Library GUI
//
// ============================================================================
//
//      File:     appCsForm.cs           Type:         Implementation
//
//      Date:     04.02.2010                 Last Change:  25.03.2010
//
//      Author:   Thomas M. Schlageter
//                Silvio Robel
//
//      Methods:  AppCsDevel           -  constructor
//
//                chan2Idx              -  convert channel name into index
//                chanIndexChanged      -  channel box index handler
//                closeButtonClick      -  close button handler
//                col2Idx               -  convert color name into index
//                colorIndexChanged     -  color box index handler
//                confButtonClick       -  configuration button handler
//                connButtonClick       -  connect button handler
//                decodeButtonClick     -  snap/decode button handler
//                initialize            -  Initialize GUI
//                intensityChanged      -  intensity field handler
//                isValidIntensity      -  check intensity
//                isValidIP             -  check IP address
//                isValidIPPart         -  check partial IP address
//                isValidSlot           -  check slot
//                logButtonClick        -  log button handler
//                logMsg                -  send message to logger
//                pictureClick          -  picture click handler
//                processButtonClick    -  process button handler
//                showBestButtonClick   -  show best button handler
//                showCloseButtonClick  -  close button handler
//                showCodeButtonClick   -  code button handler
//                showProcButtonClick   -  show process button handler
//                snapButtonClick       -  snap button handler
//                textIPChanged         -  IP text field handler
//                textSlotChanged       -  slot text field handler
//                typeIndexChanged      -  type box index handler
//                updUI                 -  update GUI elements
//
// ============================================================================


using System;
using System.IO;
using System.Net;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Wid110LibConstUser;
using AppCsConstDevel;
using AppCsLogger;
using Wid110LibUser;


namespace AppCs
{
    public partial class AppCsDevel : Form
    {
        // ====================================================================
        /// <summary>
        /// Member variables.
        /// </summary>
        // ====================================================================

        private Wid110Lib WidLib;
        private Logger logger;
        private AppCsImageDlg ImageDialog;

        private string lastIP { get; set; }
        private string lastSlot { get; set; }
        private string lastIntensity { get; set; }
        private string lastQuality { get; set; }
        private string lastColor { get; set; }
        private string lastChannel { get; set; }
        private string lastType { get; set; }

        private string libVers = "";
        private string parVers = "";
        private string widVers = "";
        private string widType = "";

        private bool connected = false;

        public const int MAX_SLOT = 32;
        public const int MAX_INTENSITY = 100;

        public const int STR_VERSION = 2000; //!< Version number server-software
        public const int STR_REVISION = 2005; //!< revision number 
        public const int STR_VC_TYPE = 2001; //!< System Board ID, defined by Hardware
        public const int STR_HW_VERSION = 2002; //!< System Hardware version
        public const int STR_FW_VERSION = 2020; //!< System Firmware version
        public const int STR_READER_COMMENT = 2059; //!< reader location string and custom comments     
        public const int STR_READER_HOSTNAME = 2060; //!< hostname for DHCP ident; empty for getting DHCP ident with MAC-Address, if name is given it's added to #IP file on reader


        private string TempImagePath;

        WID_BCR bcrSetting;
        WID_OCR ocrSetting;
        WID_DMR dmrSetting;
        WID_CAPTURE widCapture;

        private bool SuppressEvent = false;

        // ====================================================================
        /// <summary>
        /// Constructor: Initialize graphical components.
        /// </summary>
        // ====================================================================

        public AppCsDevel()
        {
            InitializeComponent();          // handled by IDE


            try
            {
                logger = new Logger(logMessage, true);  // enable logging
                WidLib = new Wid110Lib();
                TempImagePath = Path.GetFullPath(WidLib.getTmpImage());
                ImageDialog = new AppCsImageDlg();
            }

            catch (Exception e)
            {
                logMessage.Text = "AppCsDevel()\r\n"
                                + "ERROR: Unable to create AppCsDevel instance\r\n"
                                + e.ToString();

                return;
            }


            logMsg("AppCsDevel()");

            initialize();                   // not handled by IDE

            updUI();					// update UI elements
        }


        // ====================================================================
        /// <summary>
        /// Initialize components; not handled by IDE.
        /// </summary>
        // ====================================================================

        private void initialize()
        {
            logMsg("initialize()");


            libVers = WidLib.FGetVersion();
            parVers = WidLib.FGetVersionParam();
            widVers = WidLib.FGetReaderInfo(STR_VERSION);
            widType = WidLib.FGetReaderInfo(STR_HW_VERSION);

            infoTextBox.Text = widType + widVers + "\r\n"
                             + "C# Library Version " + libVers + "\r\n"
                             + "compiled for Parameter " + parVers;


            openDialog.CheckFileExists = true;
            openDialog.CheckPathExists = true;
            openDialog.InitialDirectory = ".";

            connectButton.Enabled = true;
            closeButton.Enabled = true;


            colorBox.Items.AddRange(new object[]
            {
            AppCsConstDev.colRED,
            AppCsConstDev.colGREEN,
            AppCsConstDev.colBLUE
            });

            colorBox.SelectedIndex = 0;


            channelBox.Items.AddRange(new object[]
            {
            AppCsConstDev.chanBRIGHT,
            AppCsConstDev.chanFOCUS,
            AppCsConstDev.chanINNER,
            AppCsConstDev.chanOUTER,
            AppCsConstDev.chanALL
            });

            channelBox.SelectedIndex = 0;


            codeBox.Items.AddRange(new object[]
            {
            AppCsConstDev.codeDMR,
            AppCsConstDev.codeOCR,
            AppCsConstDev.codeBCR,
            AppCsConstDev.codeLAST
            });

            codeBox.SelectedIndex = 0;


            connectButton.Text = (connected)
                               ? AppCsConstDev.cbtnDisc
                               : AppCsConstDev.cbtnConn;


            lastColor = colorBox.SelectedText;
            lastChannel = channelBox.SelectedText;
            lastType = codeBox.SelectedText;
            lastIP = ipTextBox.Text;
            lastSlot = slotTextBox.Text;
            lastIntensity = Convert.ToString(intensityUpDown.Value);

            CbDmrSymbol.SelectedIndex = 0;
            CbDmrMirror.SelectedIndex = 0;
            CbDmrCodeSize.SelectedIndex = 1;

            CbBcrChars.SelectedIndex = 0;
            CbBcrDigits.SelectedIndex = 0;
            CbBcrResolution.SelectedIndex = 0;
            CbBcrSeparator.SelectedIndex = 1;
            CbBcrIbmConv.SelectedIndex = 0;
            CbBcrTiConv.SelectedIndex = 0;

            resultTextBox.Text = Wid110LibConst.rsltBLANK;
            lastQuality = "0";
        }


        // ====================================================================
        /// <summary>
        /// Send message to logger instance.
        /// </summary>
        /// <param name="msg"> message to send.</param>
        // ====================================================================

        private void logMsg(string msg)
        {
            if (logger != null && logger.isLogging())
                logger.logMessage("AppCsForm." + msg);
        }

        private void HandleWidLibError()
        {
            string errMsg;
            if (WidLib.CheckError(out errMsg))
            {
                logMsg("ERROR: " + errMsg + "\r\n");
            }
        }


        // ====================================================================
        /// <summary>
        /// Event handler: Process trigger button click.
        /// </summary>
        /// <param name="sender"> event sender.</param>
        /// <param name="e">      event arguments.</param>
        // ====================================================================

        private void processButtonClick(object sender, EventArgs e)
        {
            logMsg("processButtonClick()");

            // perform process read
            if (WidLib.FProcessRead())
            {
                // get read result
                resultTextBox.Text = WidLib.FGetWaferId();
            }
            HandleWidLibError();

            // update GUI elements depending on state
            updUI();
        }


        // ====================================================================
        /// <summary>
        /// Event handler: Configuration button click.
        /// </summary>
        /// <param name="sender"> event sender.</param>
        /// <param name="e">      event arguments.</param>
        // ====================================================================

        private void confButtonClick(object sender, EventArgs e)
        {
            logMsg("confButtonClick()");

            // activate file dialog
            if (openDialog.ShowDialog() == DialogResult.OK)
            {
                // read file and send to reader
                WidLib.FLoadRecipesToSlot(openDialog.FileName, Convert.ToInt16(slotTextBox.Text));
                HandleWidLibError();
            }
        }

        private void BtLoadJob_Click(object sender, EventArgs e)
        {
            logMsg("BtLoadJobClick()");
            if (openDialog.ShowDialog() == DialogResult.OK)
            {
                // read file and send to reader
                WidLib.FLoadRecipes(openDialog.FileName);
                HandleWidLibError();
            }
        }

        private void BtSaveJob_Click(object sender, EventArgs e)
        {
            logMsg("BtSaveJobClick()");
            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                bool job,cfg;

                job = saveDialog.FileName.Contains(".job");
                cfg = saveDialog.FileName.Contains(".cfg");
                
                //Save job to local machine
                if(job)
                {    
                    WidLib.FSaveJob(saveDialog.FileName);
                    HandleWidLibError();
                    return;
                }
                if(cfg)
                {
                    string configName = txtConfigName.Text;
                    WidLib.FSaveConfig(saveDialog.FileName,configName);
                    HandleWidLibError();
                    return;
                }
                logMsg("BtSaveJobClick() wrong file name" + saveDialog.FileName);
            }

        }

        public bool Connect(string IP)
        {
            if (!connected)
            {
                // read IP address
                lastIP = ipTextBox.Text;

                IPAddress ipAddr;
                if (!IPAddress.TryParse(lastIP, out ipAddr))
                {
                    logMsg("invalid IP address given: " + lastIP);
                    return false;
                }

                if (WidLib.FInit(lastIP))
                {
                    return true;
                }
                return false;
            }
            else
            {
                return true;
            }

        }

        public bool Trigger()
        {
            if (WidLib.FProcessRead())
            {
                return true;
            }
            return false;
        }

        public string GetResult()
        {
            return WidLib.FGetWaferId();
        }
        // ====================================================================
        /// <summary>
        /// Event handler: Connect button click.
        /// </summary>
        /// <param name="sender"> event sender.</param>
        /// <param name="e">      event arguments.</param>
        // ====================================================================

        private void connButtonClick(object sender, EventArgs e)
        {
            logMsg("connButtonClick()");


            // library not initialized: connect  --------------------------------
            if (!connected)
            {
                // read IP address
                lastIP = ipTextBox.Text;

                IPAddress ipAddr;
                if (!IPAddress.TryParse(lastIP, out ipAddr))
                {
                    logMsg("invalid IP address given: " + lastIP);
                    return;
                }


                // button description connecting
                connectButton.Text = AppCsConstDev.cbtnCong;
                Application.DoEvents();

                // disable connect button before connecting; made visible by updUI()
                connectButton.Enabled = false;

                // disable ip textfield
                ipTextBox.Enabled = false;


                // connect to IP address
                if (WidLib.FInit(lastIP))
                {
                    //Connection Attempt Success
                    logMsg("connButtonClick(): connected");
                    connectButton.Text = AppCsConstDev.cbtnDisc;
                    connected = true;

                    UploadOCR();
                    UploadDmr();
                    UploadBcr();

                    //Get Font Name
                    cbFontName.Items.Clear();
                    for (int x = 0; x < 7; x++)
                    {
                        string fontName = WidLib.FGetFontName(x);
                        HandleWidLibError();

                        if (string.IsNullOrEmpty(fontName)) continue;
                        cbFontName.Items.Add(fontName);
                    }
                    if (cbFontName.Items.Count > 0)
                    {
                        //ToDo: Check - Font Name returned as null?
                        if (string.IsNullOrEmpty(ocrSetting.widFontName))
                            cbFontName.SelectedIndex = 0;
                        else
                            cbFontName.SelectedIndex = cbFontName.Items.IndexOf(ocrSetting.widFontName);
                    }

                    chkFineScan.Checked = WidLib.FGetFineScan();
                    HandleWidLibError();

                    //Get Last Configuration Name
                    string lastConfig = string.Empty;
                    int configID = 0; //Index zero is empty
                    do
                    {
                        configID++;
                        lastConfig = WidLib.FGetConfigurationName(configID);
                    } while (lastConfig.Length > 0);

                    lastConfig = WidLib.FGetConfigurationName(--configID);
                    if (string.IsNullOrEmpty(lastConfig)) lastConfig = "config";
                    txtConfigName.Text = lastConfig + "+";

                    //Image Size
                    TxtImageSizeX.Text = WidLib.FGetImageXSize().ToString();
                    HandleWidLibError();

                    TxtImageSizeY.Text = WidLib.FGetImageYSize().ToString();
                    HandleWidLibError();
                }
                else HandleWidLibError();
            }


            // library initialized: disconnect  ---------------------------------
            else
            {
                // disconnect from sensor
                if (WidLib.FExit())
                {
                    logMsg("connButtonClick(): disconnected");

                    connectButton.Text = AppCsConstDev.cbtnConn;
                    connected = false;
                }

                else HandleWidLibError();
            }
            connectButton.Enabled = true;


            // update GUI elements depending on state
            updUI();
        }

        // ====================================================================
        /// <summary>
        /// Event handler: Snap button click (take image using temporary
        /// settings).
        /// </summary>
        /// <param name="sender"> event sender.</param>
        /// <param name="e">      event arguments.</param>
        // ====================================================================

        ImageConverter imageConverter = new ImageConverter();
        private void snapButtonClick(object sender, EventArgs e)
        {
            logMsg("snapButtonClick()");

            resultTextBox.Clear();

            WID_CAPTURE capture = GetCaptureSettings();

            //take image with given parameters
            if (WidLib.FLiveGetImage(TempImagePath,
                              capture.widChannel,
                              capture.widIntensity,
                              capture.widColor))
            {


                // activate picture box
                ImageDialog.Show();

                // display file in picture box
                //ImageDialog.pictureBox.Load(TempImagePath); //Not working as .NET Framework 4 onwards, file is locked until Bitmap is disposed
                //https://docs.microsoft.com/en-us/dotnet/api/system.drawing.bitmap.-ctor?redirectedfrom=MSDN&view=dotnet-plat-ext-3.1#System_Drawing_Bitmap__ctor_System_String_

                ImageDialog.pictureBox.Image = (Image)imageConverter.ConvertFrom(File.ReadAllBytes(TempImagePath));

                // dummy read result
                resultTextBox.Text = Wid110LibConst.rsltBLANK;
            }
            else HandleWidLibError();

            // update GUI elements depending on state
            updUI();
        }


        // ====================================================================
        /// <summary>
        /// Event handler: Decode button click (take image and decode).
        /// </summary>
        /// <param name="sender"> event sender.</param>
        /// <param name="e">      event arguments.</param>
        // ====================================================================

        private void decodeButtonClick(object sender, EventArgs e)
        {
            logMsg("decodeButtonClick()");
            throw new NotImplementedException();

            // take image with given parameters and decode
            //lib.liveRead(lib.getTmpImage(),
            //                      chan2Idx(lastChannel),
            //                      Convert.ToInt32(lastIntensity),
            //                      col2Idx(lastColor));

            // activate picture box
            ImageDialog.Show();

            // display file in picture box
            //ImageDialog.pictureBox.Load(lib.getTmpImage());

            // get read result
            //lastResult = lib.getWaferId();

            // update GUI elements depending on state
            updUI();
        }


        // ====================================================================
        /// <summary>
        /// Event handler: Show process image button click.
        /// </summary>
        /// <param name="sender"> event sender.</param>
        /// <param name="e">      event arguments.</param>
        // ====================================================================

        private void showProcButtonClick(object sender, EventArgs e)
        {
            logMsg("showProcButtonClick()");
            GetProcessImage(AppCsConstDev.imgALL);
        }


        // ====================================================================
        /// <summary>
        /// Event handler: Show best process image button click.
        /// </summary>
        /// <param name="sender"> event sender.</param>
        /// <param name="e">      event arguments.</param>
        // ====================================================================

        private void showBestButtonClick(object sender, EventArgs e)
        {
            logMsg("showBestButtonClick()");
            GetProcessImage(AppCsConstDev.imgBEST);
        }


        private void GetProcessImage(int bestOrAll)
        {
            if (!WidLib.FIsInitialized())
            {
                HandleWidLibError();
                return;
            }

            int counter = 0;
            while (true)
            {
                if (!WidLib.FProcessGetImage(TempImagePath, bestOrAll))
                {
                    if (WidLib.getErrno() == Wid110LibConst.ecNoMoreImg)
                    {
                        logMsg(counter.ToString() + " images retrieved after last process trigger.");
                        return;
                    }
                    HandleWidLibError();
                }

                ImageDialog.Show();
                ImageDialog.pictureBox.Load(TempImagePath);
                counter++;
            }
        }


        // ====================================================================
        /// <summary>
        /// Event handler: Close button click.
        /// </summary>
        /// <param name="sender"> event sender.</param>
        /// <param name="e">      event arguments.</param>
        // ====================================================================

        private void closeButtonClick(object sender, EventArgs e)
        {
            logMsg("closeButtonClick()");
            Application.Exit();
        }


        // ====================================================================
        /// <summary>
        /// Event handler: Show code quality button click.
        /// </summary>
        /// <param name="sender"> event sender.</param>
        /// <param name="e">      event arguments.</param>
        // ====================================================================

        private void showCodeButtonClick(object sender, EventArgs e)
        {
            logMsg("showCodeButtonClick()");

            int result = Wid110LibConst.rsltNoCodeQuality;
            switch (codeBox.SelectedIndex)
            {
                case 0: result = WidLib.FGetCodeQualityDMR(); break;
                case 1: result = WidLib.FGetCodeQualityOCR(); break;
                case 2: result = WidLib.FGetCodeQualityBCR(); break;
                case 3: result = WidLib.FGetCodeQualityLast(); break;
            }
            qualityTextBox.Text = result.ToString();
        }


        // ====================================================================
        /// <summary>
        /// Event handler: IP address changed.
        /// </summary>
        /// <param name="sender"> event sender.</param>
        /// <param name="e">      event arguments.</param>
        // ====================================================================

        private void textIPChanged(object sender, EventArgs e)
        {
            string ip = ipTextBox.Text;
            IPAddress ipAddr;

            if (IPAddress.TryParse(ip, out ipAddr))
                lastIP = ip;
            else                                            // no autocorrection here because user cannot enter a new ip then
                return;

            logMsg("textIPChanged(): " + ip);
        }


        // ====================================================================
        /// <summary>
        /// Event handler: Configuration slot changed.
        /// </summary>
        /// <param name="sender"> event sender.</param>
        /// <param name="e">      event arguments.</param>
        // ====================================================================

        private void textSlotChanged(object sender, EventArgs e)
        {
            string slot = slotTextBox.Text;

            if (isValidSlot(slot))
                lastSlot = slot;
            else
                slotTextBox.Text = lastSlot;

            logMsg("textSlotChanged(): " + slot);
        }


        // ====================================================================
        /// <summary>
        /// Event handler: Intensity changed.
        /// </summary>
        /// <param name="sender"> event sender.</param>
        /// <param name="e">      event arguments.</param>
        // ====================================================================

        private void intensityChanged(object sender, EventArgs e)
        {
            //// manually update the 'Text' member, which otherwise would
            //// be 1 count behind the 'Value' member otherwise
            ////						- ALL PRAISE MICRO$OFT!
            //intensityUpDown.Text = Convert.ToString(intensityUpDown.Value);


            //if (isValidIntensity(intensityUpDown.Value))
            //    lastIntensity = intensityUpDown.Text;
            //else
            //    intensityUpDown.Text = lastIntensity;

            //logMsg("intensityChanged(): " + lastIntensity);
        }


        // ====================================================================
        /// <summary>
        /// Event handler: Color selected.
        /// </summary>
        /// <param name="sender"> event sender.</param>
        /// <param name="e">      event arguments.</param>
        // ====================================================================

        private void colorIndexChanged(object sender, EventArgs e)
        {
            lastColor = colorBox.SelectedItem.ToString();

            logMsg("colorIndexChanged(): " + lastColor);
        }


        // ====================================================================
        /// <summary>
        /// Event handler: Channel selected.
        /// </summary>
        /// <param name="sender"> event sender.</param>
        /// <param name="e">      event arguments.</param>
        // ====================================================================

        private void chanIndexChanged(object sender, EventArgs e)
        {
            lastChannel = channelBox.SelectedItem.ToString();

            logMsg("chanIndexChanged(): " + lastChannel);
        }


        // ====================================================================
        /// <summary>
        /// Event handler: Code type selected.
        /// </summary>
        /// <param name="sender"> event sender.</param>
        /// <param name="e">      event arguments.</param>
        // ====================================================================

        private void typeIndexChanged(object sender, EventArgs e)
        {
            lastType = codeBox.SelectedItem.ToString();

            logMsg("typeIndexChanged(): " + lastType);
        }


        // ====================================================================
        /// <summary>
        /// Check slot to be a valid slot.
        /// </summary>
        /// <param name="slot"> slot to check.</param>
        /// <return>            true if valid.</return>
        // ====================================================================

        private bool isValidSlot(string slot)
        {
            try
            {
                int s = Convert.ToInt32(slot);

                return (s >= 0 && s <= MAX_SLOT);
            }


            catch (Exception e)
            {
                logMsg("isValidSlot( " + slot + " )\r\n"
                      + "ERROR: Invalid slot\r\n"
                      + e.ToString());
            }

            return false;
        }


        // ====================================================================
        /// <summary>
        /// Check intensity to be a valid slot.
        /// </summary>
        /// <param name="ints"> intensity to check.</param>
        /// <return>            true if valid.</return>
        // ====================================================================

        private bool isValidIntensity(decimal i)
        {
            if (i >= 0 && i < MAX_INTENSITY)
                return true;

            else
                logMsg("isValidIntensity( " + i + " )\r\n"
                      + "ERROR: Invalid intensity");

            return false;
        }


        // ====================================================================
        /// <summary>
        /// Update UI elements depending on current state.
        /// </summary>
        // ====================================================================

        private void updUI()
        {
            logMsg("updUI()");

            // read library state and versions
            connected = WidLib.FIsInitialized();

//            if (libVers.Length == 0 || parVers.Length == 0 || widVers.Length == 0)
            {
                libVers = WidLib.FGetVersion();
                parVers = WidLib.FGetVersionParam();
                widVers = WidLib.FGetReaderInfo(STR_VERSION);
                widType = WidLib.FGetReaderInfo(STR_HW_VERSION);

                infoTextBox.Text = widType + widVers + "\r\n"
                                 + "C# Library Version " + libVers + "\r\n"
                                 + "compiled for Paramter " + parVers;
            }


            // update connection related GUI components
            if (connected)
            {
                // show 'disconnect' button
                connectButton.Text = AppCsConstDev.cbtnDisc;

                liveBox.Enabled = confBox.Enabled =
                    procBox.Enabled = evalBox.Enabled =
                    jobPanel.Enabled = teachingBox.Enabled =
                    bcrParamBox.Enabled = dmrParamBox.Enabled =
                    roiBox.Enabled = ocrParamBox.Enabled = true;

            }


            else
            {
                // show 'connect' button
                connectButton.Text = AppCsConstDev.cbtnConn;

                liveBox.Enabled = confBox.Enabled =
                    procBox.Enabled = evalBox.Enabled =
                    jobPanel.Enabled = teachingBox.Enabled =
                    bcrParamBox.Enabled = dmrParamBox.Enabled =
                    roiBox.Enabled = ocrParamBox.Enabled = false;
            }


        }

        private void BtCaptureSet_Click(object sender, EventArgs e)
        {
            WID_CAPTURE capture = GetCaptureSettings();
            if (!WidLib.FSetImageCapture(capture)) HandleWidLibError();
        }

        private void BtCaptureGet_Click(object sender, EventArgs e)
        {
            WID_CAPTURE capture = WidLib.FGetImageCapture();
            HandleWidLibError();
            DisplayCaptureSettings(capture);
        }

        private void DisplayCaptureSettings(WID_CAPTURE capture)
        {
            SuppressEvent = true;
            try
            {
                ChkRotated.Checked = Convert.ToBoolean(capture.widRotated);
                ChkFlipped.Checked = Convert.ToBoolean(capture.widFlipped);
                channelBox.SelectedIndex = capture.widChannel;
                colorBox.SelectedIndex = capture.widColor;
                intensityUpDown.Value = capture.widIntensity;
            }
            finally { SuppressEvent = false; }
        }

        private WID_CAPTURE GetCaptureSettings()
        {
            WID_CAPTURE capture = new WID_CAPTURE();
            capture.widChannel = channelBox.SelectedIndex;
            capture.widColor = colorBox.SelectedIndex;
            capture.widIntensity = (int)intensityUpDown.Value;
            capture.widFlipped = Convert.ToInt32(ChkFlipped.Checked);
            capture.widRotated = Convert.ToInt32(ChkRotated.Checked);
            return capture;
        }


        private void CheckConnection_Click(object sender, EventArgs e)
        {
            logMsg("CheckConnection_Clik()");
            if (WidLib.FCheckConnection(ipTextBox.Text, 3))
            {
                logMsg("Reader connected!");
            }
            else
                logMsg("Reader disconnected!");
            HandleWidLibError();
        }

        private void AppCsDevel_FormClosing(object sender, FormClosingEventArgs e)
        {
            WidLib.Dispose();
        }

        private void BtSave_Click(object sender, EventArgs e)
        {
            logMsg("SaveClick()");
            BtSave.Text = "Saving...";
            Application.DoEvents();

            WidLib.FSaveJobToReader();
            HandleWidLibError();
            BtSave.Text = "Save";
        }

        private void BtShowProcessTime_Click(object sender, EventArgs e)
        {
            TxtProcessTime.Text = WidLib.FGetCodeTime().ToString();
            HandleWidLibError();
        }

        private void BtSetConfigROI_Click(object sender, EventArgs e)
        {
            logMsg("SetConfigROI_Click()");
            WID_ROI roi;
            WID_CAPTURE capture;
            string config = txtConfigName.Text;

            if (!WidLib.FGetROI(config, out roi, out capture))
            {
                logMsg("Failed to read ROI from configuration " + config);
                HandleWidLibError();
                return;
            }

            roi = GetROISettings();

            if (!WidLib.FSetROI(config, roi, capture))
            {
                logMsg("Can't set ROI to configuration " + config);
                HandleWidLibError();
            }
        }

        private void BtGetConfigROI_Click(object sender, EventArgs e)
        {
            logMsg("GetConfigROI_Click()");
            WID_ROI widRoi;
            WID_CAPTURE widConfig, widCapture;
            string config = txtConfigName.Text;

            if (!WidLib.FGetROI(config, out widRoi, out widConfig))
            {
                logMsg("Failed to read ROI from configuration " + config);
                HandleWidLibError();
                return;
            }

            DisplayROISettings(widRoi);

            widCapture = WidLib.FGetImageCapture();
            widCapture.widFlipped = widConfig.widFlipped;
            widCapture.widRotated = widConfig.widRotated;

            WidLib.FSetImageCapture(widCapture);
            ChkFlipped.Checked = Convert.ToBoolean(widCapture.widFlipped);
            ChkRotated.Checked = Convert.ToBoolean(widCapture.widRotated);
        }

        private void DisplayROISettings(WID_ROI roi)
        {
            TxtXStart.Text = roi.roiXS.ToString();
            TxtYStart.Text = roi.roiYS.ToString();
            TxtXLength.Text = roi.roiXL.ToString();
            TxtYLength.Text = roi.roiYL.ToString();
        }

        private WID_ROI GetROISettings()
        {
            WID_ROI roi = new WID_ROI();
            roi.roiXS = Convert.ToInt32(TxtXStart.Text);
            roi.roiYS = Convert.ToInt32(TxtYStart.Text);
            roi.roiXL = Convert.ToInt32(TxtXLength.Text);
            roi.roiYL = Convert.ToInt32(TxtYLength.Text);
            return roi;
        }

        private void ResetLabelText()
        {
            LbOcrTeach.Text = LbOcrLearn.Text = "...";
            LbDmrTeach.Text = LbDmrLearn.Text = "...";
            LbBcrTeach.Text = LbBcrLearn.Text = "...";
        }

        private void BtTeachBCR_Click(object sender, EventArgs e)
        {
            logMsg("TeachBCR_Click()");
            if (!WidLib.FIsInitialized())
            {
                logMsg("Reader not initialized!");
                return;
            }

            ResetLabelText();
            LbBcrTeach.Text = "Proessing";
            Application.DoEvents();

            UpdateBcr();
            if (!WidLib.FTeachingBCR())
            {
                LbBcrTeach.Text = "Failed";
                HandleWidLibError();
                return;
            }

            LbBcrTeach.Text = "OK";

            //Get Image Raw Data - Return as Image
            Image image;
            if (!WidLib.FGetImageRawData(out image))
            {
                LbBcrTeach.Text = "Failed";
                HandleWidLibError();
                return;
            }
            ImageDialog.Show();
            ImageDialog.pictureBox.Image = image;

            resultTextBox.Text = WidLib.FGetWaferId();
        }

        private void BtConfigureBCR_Click(object sender, EventArgs e)
        {
            if (!WidLib.FIsInitialized())
            {
                logMsg("Reader not initialized!");
                return;
            }

            LbBcrLearn.Text = "Processing";
            int scanStepPreScan = WidLib.FGetFineScan() ? 180 : 90;
            int scanStepConfig = 90;

            Image image;
            ImageDialog.Show();

            //Coarse Search
            for (int x = 0; x < scanStepPreScan; x++)
            {
                LbBcrLearn.Text = "Pre Scaning:" + x.ToString() + " of " + scanStepPreScan.ToString();
                WidLib.FConfigureBCR();
                WidLib.FGetImageRawData(out image);
                ImageDialog.pictureBox.Image = image;
                Application.DoEvents();
            }

            //Find Search
            for (int x = 0; x < scanStepConfig; x++)
            {
                LbBcrLearn.Text = "Fine Scanning:" + x.ToString() + " of " + scanStepConfig.ToString();
                WidLib.FConfigureBCR();
                WidLib.FGetImageRawData(out image);
                ImageDialog.pictureBox.Image = image;
                Application.DoEvents();
            }

            //Configure new configuration
            string configName = txtConfigName.Text;
            bool valid = WidLib.FConfigureBCR(configName);
            WidLib.FGetImageRawData(out image);
            ImageDialog.pictureBox.Image = image;

            ResetLabelText();

            resultTextBox.Text = WidLib.FGetWaferId();

            if (valid) LbBcrLearn.Text = WidLib.FGetCodeQualityBCR() + " reads";
            else LbBcrLearn.Text = "Failed";
        }

        private void BtTeachDMR_Click(object sender, EventArgs e)
        {
            logMsg("TeachDMR_Click()");
            if (!WidLib.FIsInitialized())
            {
                logMsg("Reader not initialized!");
                return;
            }

            ResetLabelText();
            LbDmrTeach.Text = "Processing";
            Application.DoEvents();

            UpdateDmr();
            if (!WidLib.FTeachingDMR())
            {
                LbDmrTeach.Text = "Failed";
                HandleWidLibError();
                return;
            }
            LbDmrTeach.Text = "OK";

            //Get Image Raw Data - Return as Image
            Image image;
            if (!WidLib.FGetImageRawData(out image))
            {
                LbDmrTeach.Text = "Failed";
                HandleWidLibError();
                return;
            }
            ImageDialog.Show();
            ImageDialog.pictureBox.Image = image;

            resultTextBox.Text = WidLib.FGetWaferId();

        }

        private void BtConfigureDMR_Click(object sender, EventArgs e)
        {
            if (!WidLib.FIsInitialized())
            {
                logMsg("Reader not initialized!");
                return;
            }

            LbDmrLearn.Text = "Processing";
            int scanStepPreScan = WidLib.FGetFineScan() ? 180 : 90;
            int scanStepConfig = 90;

            Image image;
            ImageDialog.Show();

            //Coarse Search
            for (int x = 0; x < scanStepPreScan; x++)
            {
                LbDmrLearn.Text = "Pre Scaning:" + x.ToString() + " of " + scanStepPreScan.ToString();
                WidLib.FConfigureDMR();
                WidLib.FGetImageRawData(out image);
                ImageDialog.pictureBox.Image = image;
                Application.DoEvents();
            }

            //Find Search
            for (int x = 0; x < scanStepConfig; x++)
            {
                LbDmrLearn.Text = "Fine Scanning:" + x.ToString() + " of " + scanStepConfig.ToString();
                WidLib.FConfigureDMR();
                WidLib.FGetImageRawData(out image);
                ImageDialog.pictureBox.Image = image;
                Application.DoEvents();
            }

            //Configure new configuration
            string configName = txtConfigName.Text;
            bool valid = WidLib.FConfigureDMR(configName);
            WidLib.FGetImageRawData(out image);
            ImageDialog.pictureBox.Image = image;

            ResetLabelText();

            resultTextBox.Text = WidLib.FGetWaferId();

            if (valid) LbDmrLearn.Text = WidLib.FGetCodeQualityDMR() + " reads";
            else LbDmrLearn.Text = "Failed";
        }

        private void BtTeachOCR_Click(object sender, EventArgs e)
        {
            if (!WidLib.FIsInitialized())
            {
                logMsg("Reader not initialized!");
                return;
            }

            LbOcrTeach.Text = "Processing";
            Application.DoEvents();

            logMsg("TeachOCR_Click()");
            int imageSize = WidLib.FGetImageXSize() * WidLib.FGetImageYSize();
            logMsg(" Image Size = " + imageSize.ToString());

            UpdateOCR();
            if (!WidLib.FTeachingOCR())
            {
                LbOcrTeach.Text = "Failed";
                HandleWidLibError();
                return;
            }
            LbOcrTeach.Text = "OK";

            //Get Image Raw Data - Return as Image
            Image image;
            if (!WidLib.FGetImageRawData(out image))
            {
                LbOcrTeach.Text = "Failed";
                HandleWidLibError();
                return;
            }
            ImageDialog.Show();
            ImageDialog.pictureBox.Image = image;

            ResetLabelText();
            resultTextBox.Text = WidLib.FGetWaferId();
        }

        private void BtConfigureOCR_Click(object sender, EventArgs e)
        {
            if (!WidLib.FIsInitialized())
            {
                logMsg("Reader not initialized!");
                return;
            }

            LbOcrLearn.Text = "Processing";
            int scanStepPreScan = WidLib.FGetFineScan() ? 180 : 90;
            int scanStepConfig = 90;

            Image image;
            ImageDialog.Show();

            //Coarse Search
            for (int x = 0; x < scanStepPreScan; x++)
            {
                LbOcrLearn.Text = "Pre Scaning:" + x.ToString() + " of " + scanStepPreScan.ToString();
                WidLib.FConfigureOCR();
                WidLib.FGetImageRawData(out image);
                ImageDialog.pictureBox.Image = image;
                Application.DoEvents();
            }

            //Find Search
            for (int x = 0; x < scanStepConfig; x++)
            {
                LbOcrLearn.Text = "Fine Scanning:" + x.ToString() + " of " + scanStepConfig.ToString();
                WidLib.FConfigureOCR();
                WidLib.FGetImageRawData(out image);
                ImageDialog.pictureBox.Image = image;
                Application.DoEvents();
            }

            //Configure new configuration
            string configName = txtConfigName.Text;
            bool valid = WidLib.FConfigureOCR(configName);
            WidLib.FGetImageRawData(out image);
            ImageDialog.pictureBox.Image = image;

            ResetText();

            resultTextBox.Text = WidLib.FGetWaferId();
            if (valid) LbOcrLearn.Text = WidLib.FGetCodeQualityOCR() + " reads";
            else LbOcrLearn.Text = "Failed";
        }

        private void BtDeleteConfig_Click(object sender, EventArgs e)
        {
            WidLib.FConfigureDelete(txtConfigName.Text);
            HandleWidLibError();
        }

        private void BtResetCycle_Click(object sender, EventArgs e)
        {
            if (WidLib.FIsInitialized())
            {
                WidLib.FConfigurePreset();
                HandleWidLibError();
            }
        }

        private void BtConfigPreset_Click(object sender, EventArgs e)
        {
            UpdateOCR();
            if (WidLib.FIsInitialized())
            {
                WidLib.FConfigurePreset(txtConfigName.Text);
                HandleWidLibError();
            }
        }

        private void UploadOCR()
        {
            if (!WidLib.FIsInitialized())
            {
                logMsg("Reader not initialized!");
                return;
            }

            if (WidLib.FGetParamOCR(out ocrSetting, out widCapture))
            {
                DisplayCaptureSettings(widCapture);
                DisplayROISettings(ocrSetting.widRoi);

                TxtAccSimilarity.Text = ocrSetting.widAccSimilarity.ToString();
                TxtMinSimilarity.Text = ocrSetting.widMinSimilarity.ToString();
                TxtSpacing.Text = ocrSetting.widSpacing.ToString();
                TxtCharPosX.Text = ocrSetting.widCharPosX.ToString();
                TxtCharPosY.Text = ocrSetting.widCharPosY.ToString();
                TxtCharSizeX.Text = ocrSetting.widCharSizeX.ToString();
                TxtCharSizeY.Text = ocrSetting.widCharSizeY.ToString();
                TxtFilter.Text = ocrSetting.widFilter.ToString();
                TxtRotation.Text = ocrSetting.widRotation.ToString();
                ChkAdjustSize.Checked = Convert.ToBoolean(ocrSetting.widAdjustSize);
                ChkAdjustSpace.Checked = Convert.ToBoolean(ocrSetting.widAdjustSpace);
                TxtFielding.Text = ocrSetting.widFielding;
                TxtFormat.Text = ocrSetting.widFormat;

            }
            else HandleWidLibError();
        }

        private void UpdateOCR()
        {
            if (!WidLib.FIsInitialized())
            {
                logMsg("Reader not initialized!");
                return;
            }

            ocrSetting = new WID_OCR()
            {
                widAccSimilarity = Convert.ToInt32(TxtAccSimilarity.Text),
                widMinSimilarity = Convert.ToInt32(TxtMinSimilarity.Text),
                widSpacing = Convert.ToInt32(TxtSpacing.Text),
                widFontName = cbFontName.Text,
                widAdjustSize = Convert.ToInt32(ChkAdjustSize.Checked),
                widAdjustSpace = Convert.ToInt32(ChkAdjustSpace.Checked),
                widFielding = TxtFielding.Text,
                widFormat = TxtFormat.Text,
                widFilter = Convert.ToInt32(TxtFilter.Text),

                widRotation = Convert.ToInt32(TxtRotation.Text),
                widCharSizeX = Convert.ToInt32(TxtCharSizeX.Text),
                widCharSizeY = Convert.ToInt32(TxtCharSizeY.Text),

                widCharPosX = Convert.ToInt32(TxtCharPosX.Text),
                widCharPosY = Convert.ToInt32(TxtCharPosY.Text)
            };
            ocrSetting.widRoi = GetROISettings();
            widCapture = GetCaptureSettings();

            if (!WidLib.FSetParamOCR(ocrSetting, widCapture))
            {
                HandleWidLibError();
                return;
            }
        }

        private void UploadBcr()
        {
            if (!WidLib.FIsInitialized())
            {
                logMsg("Reader not initialized!");
                return;
            }

            if (!WidLib.FGetParamBCR(out bcrSetting, out widCapture))
            {
                HandleWidLibError();
                return;
            }

            ChkBcrLTOR.Checked = Convert.ToBoolean(bcrSetting.widIBM_LtoR);
            ChkBcrRTOL.Checked = Convert.ToBoolean(bcrSetting.widIBM_RtoL);
            ChkBcrSemi.Checked = Convert.ToBoolean(bcrSetting.widSemi);
            ChkBcrLowContrast.Checked = Convert.ToBoolean(bcrSetting.widLowContrast);
            ChkBcrChecksum.Checked = Convert.ToBoolean(bcrSetting.widCheckSum);
            ChkBcrAltis.Checked = Convert.ToBoolean(bcrSetting.widEnableAltis);

            CbBcrIbmConv.SelectedIndex = bcrSetting.widIBMConversion;
            CbBcrTiConv.SelectedIndex = bcrSetting.widTIConversion;
            CbBcrDigits.SelectedIndex = bcrSetting.widDigits;
            CbBcrResolution.SelectedIndex = bcrSetting.widResolution;
            TxtBCRTable.Text = bcrSetting.widConversion;
            TxtBCRFormat.Text = bcrSetting.widFormat;

            switch (bcrSetting.widSeparator)
            {
                case 0: CbBcrSeparator.SelectedIndex = 0; break;
                case '-': CbBcrSeparator.SelectedIndex = 1; break;
                case '.': CbBcrSeparator.SelectedIndex = 2; break;
                case ' ': CbBcrSeparator.SelectedIndex = 3; break;
                case '#': CbBcrSeparator.SelectedIndex = 4; break;
            }

            CbBcrSeparator.SelectedIndex = bcrSetting.widBarCodeLength == 0 ? 0 : bcrSetting.widBarCodeLength - 6;

            DisplayROISettings(bcrSetting.widRoi);
            DisplayCaptureSettings(widCapture);
        }

        private void UpdateBcr()
        {
            if (!WidLib.FIsInitialized())
            {
                logMsg("Reader not initialized!");
                return;
            }

            bcrSetting.widIBM_LtoR = Convert.ToInt32(ChkBcrLTOR.Checked);
            bcrSetting.widIBM_RtoL = Convert.ToInt32(ChkBcrRTOL.Checked);
            bcrSetting.widSemi = Convert.ToInt32(ChkBcrSemi.Checked);
            bcrSetting.widLowContrast = Convert.ToInt32(ChkBcrLowContrast.Checked);
            bcrSetting.widCheckSum = Convert.ToInt32(ChkBcrChecksum.Checked);
            bcrSetting.widEnableAltis = Convert.ToInt32(ChkBcrAltis.Checked);

            bcrSetting.widIBMConversion = CbBcrIbmConv.SelectedIndex;
            bcrSetting.widTIConversion = CbBcrTiConv.SelectedIndex;
            bcrSetting.widDigits = CbBcrDigits.SelectedIndex;
            bcrSetting.widResolution = CbBcrResolution.SelectedIndex;
            bcrSetting.widConversion = TxtBCRTable.Text;
            bcrSetting.widFormat = TxtBCRFormat.Text;

            switch (CbBcrSeparator.SelectedIndex)
            {
                case 0: bcrSetting.widSeparator = 0; break;
                case 1: bcrSetting.widSeparator = '-'; break;
                case 2: bcrSetting.widSeparator = '.'; break;
                case 3: bcrSetting.widSeparator = ' '; break;
                case 4: bcrSetting.widSeparator = '#'; break;
            }

            bcrSetting.widBarCodeLength = CbBcrChars.SelectedIndex == 0 ? 0 : CbBcrChars.SelectedIndex + 6;

            bcrSetting.widRoi = GetROISettings();
            widCapture = GetCaptureSettings();

            if (!WidLib.FSetParamBCR(bcrSetting, widCapture))
            {
                HandleWidLibError();
                return;
            }
        }

        private void UploadDmr()
        {

            if (!WidLib.FIsInitialized())
            {
                logMsg("Reader not initialized!");
                return;
            }
            if (!WidLib.FGetParamDMR(out dmrSetting, out widCapture))
            {
                HandleWidLibError();
                return;
            }

            CbDmrSymbol.SelectedIndex = dmrSetting.widSymbol;
            CbDmrCodeSize.SelectedIndex = dmrSetting.widCodeSize;
            CbDmrMirror.SelectedIndex = dmrSetting.widCodeType;

            ChkDmrDotInv.Checked = Convert.ToBoolean(dmrSetting.widDotInv);
            ChkDmrDotNrm.Checked = Convert.ToBoolean(dmrSetting.widDotNrm);
            ChkDmrLinInv.Checked = Convert.ToBoolean(dmrSetting.widLinInv);
            ChkDmrLinNrm.Checked = Convert.ToBoolean(dmrSetting.widLinNrm);
            TxtDMRFormat.Text = dmrSetting.widFormat;

            DisplayROISettings(dmrSetting.widRoi);
            DisplayCaptureSettings(widCapture);
        }

        private void UpdateDmr()
        {
            if (!WidLib.FIsInitialized())
            {
                logMsg("Reader not initialized!");
                return;
            }

            dmrSetting.widSymbol = CbDmrSymbol.SelectedIndex;
            dmrSetting.widCodeSize = CbDmrCodeSize.SelectedIndex;
            dmrSetting.widCodeType = CbDmrMirror.SelectedIndex;

            dmrSetting.widDotInv = Convert.ToInt32(ChkDmrDotInv.Checked);
            dmrSetting.widDotNrm = Convert.ToInt32(ChkDmrDotNrm.Checked);
            dmrSetting.widLinInv = Convert.ToInt32(ChkDmrLinInv.Checked);
            dmrSetting.widLinNrm = Convert.ToInt32(ChkDmrLinNrm.Checked);
            dmrSetting.widFormat = TxtDMRFormat.Text;

            dmrSetting.widRoi = GetROISettings();
            widCapture = GetCaptureSettings();

            if (!WidLib.FSetParamDMR(dmrSetting, widCapture))
            {
                HandleWidLibError();
                return;
            }

        }

        private void ChkRotated_CheckedChanged(object sender, EventArgs e)
        {
            if (SuppressEvent) return;
            WID_CAPTURE capture = GetCaptureSettings();
            if (WidLib.FIsInitialized())
            {
                WidLib.FSetImageCapture(capture);
                UpdateOCR();
                UpdateDmr();
                UpdateBcr();
            }
        }

        private void ChkFlipped_CheckedChanged(object sender, EventArgs e)
        {
            if (SuppressEvent) return;
            WID_CAPTURE capture = GetCaptureSettings();
            if (WidLib.FIsInitialized())
            {
                WidLib.FSetImageCapture(capture);
                UpdateOCR();
                UpdateDmr();
                UpdateBcr();
            }
        }

        private void TxtDMRFormat_Leave(object sender, EventArgs e)
        {
            UpdateDmr();
        }

        private void EditBCRTextBox_Leave(object sender, EventArgs e)
        {
            UpdateBcr();
        }

        private void openDialog_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void ActivateConfig_Click(object sender, EventArgs e)
        {
            if (WidLib.FIsInitialized())
            {
                if (txtConfigName.Text.Length > 0)
                {
                    bool ret = WidLib.FConfigureActivate(txtConfigName.Text);
                    if (ret)
                    {
                        if (WidLib.FProcessReadConfig(txtConfigName.Text))
                        {
                            // get read result
                            resultTextBox.Text = WidLib.FGetWaferId();
                        }
                        HandleWidLibError();
                    }
                }
                else
                {
                    if (WidLib.FProcessRead())
                    {
                        // get read result
                        resultTextBox.Text = WidLib.FGetWaferId();
                    }
                    HandleWidLibError();
                }
            }
        }
    }
}
