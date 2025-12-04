using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using ProVIFM;
using ProVLib;
using KCSDK;
using CommonObj;
using PaeLibGeneral;
using PaeLibProVSDKEx;
using System.Net;
using System.Diagnostics;

using Wid110LibUser;
using System.IO;
using Wid110LibConstUser;
using System.Runtime.InteropServices;

namespace WOI_AB
{
    /// <summary>
    /// 資料讀取的方式: 
    /// 1. PReadValue => 產品相關資料的讀取
    /// 2. OReadValue => 通用設定資料的讀取
    /// 3. SReadValue => 模組設定資料的讀取
    /// 
    /// Log輸出的方式:
    /// 1. public void LogSay(EnLoggerType mType, params string[] msg);
    ///    LogMode=0 msg固定取用陣列第一項目值
    ///    LogMode=1 msg依類型不同取用項目值
    ///    Type="OP" 取用陣列第一項目值
    ///    Type="Alarm" [0]:模組名稱 [1]:錯誤代碼 [2]:錯誤內容 [3]:持續時間 (*由ShowAlarm函式處理)
    ///    Type="Comm" [0]:模組名稱 [1]:記錄內容
    ///    Type="SPC" [0~N]:欄位值
    /// 
    /// Alarm輸出的方式: 
    /// 1. public void ShowAlarm(string AlarmLevel, int ErrorCode);
    /// 2. public void ShowAlarm(string AlarmLevel, int ErrorCode, params object[] args);
    /// AlarmLevel: "E/e","W/w","I/i"
    /// 
    /// 常用判斷:
    /// 1. IsSimulation() => 是否為模擬狀態 0:實機 1:亂數模擬 2:純模擬
    /// 2. mCanHome => 是否可歸零
    /// 3. mHomeOk => 歸零完畢時，需設定此變數為 true
    /// 4. mLotend => 是否可結批
    /// 5. mLotendOk => 結批完畢時，需設定此變數為 true
    /// 
    /// 常用函式:
    /// 1. SetCanLotEnd: 通知模組可以進行結批
    /// 2. GetLotEndOk: 取得模組是否結批完成
    /// 3. GetLotend: 取得模組是否正在進行結批
    /// 4. SetLotEndOk: 設定模組結批完成
    /// 5. IsSimulation: 取得模組是否在模擬狀態
    /// 6. SetCanHome: 通知模組可以進行歸零
    /// 7. GetHomeOk: 取得模組歸零結果
    /// 8. SReadValue: 取得模組內部指定欄位資料
    /// 9. SSetValue: 設定模組內部指定欄位資料
    /// 10. SaveFile: 通知模組進行資料存檔
    /// 11. PReadValue: 取得產品設定指定表格/欄位資料
    /// 12. OReadValue: 取得通用設定指定欄位資料
    /// 13. GetUseModule: 取得模組開關設定
    /// 14. GetModuleID: 取得模組編號設定
    /// 
    /// 常用資料變數:
    /// 1. PackageName: 目前模組正在使用的產品名稱
    /// 2. IsAutoMode: 模組是否處理Auto模式
    /// 3. RunTM: MyTimer型別，可用於Auto流程
    /// 4. HomeTM: MyTimer型別，可用於Home流程
    /// </summary>
    /// 
    
    public enum eCylinder
    {
        OcrCY,
    }

    public partial class WOI_AB : BaseModuleInterface
    {
        [DllImport("user32.dll")]
        static extern bool SetWindowPos(IntPtr hWnd, IntPtr hWndInsertAfter, int X, int Y, int cx, int cy, uint uFlags);

        static readonly IntPtr HWND_TOPMOST = new IntPtr(-1);
        const uint SWP_NOSIZE = 0x0001;
        const uint SWP_NOMOVE = 0x0002;

        #region IO
        private Cylinder Cylinder_OCR;
        #endregion

        #region 模組變數
        private Wid110Lib WidLib;
        private bool connected;
        private JActionFlag Flag_WOI_Action;
        private JActionFlag Flag_OcrRead_Action;
        private WOI_ActionMode _WOI_ActionMode;
        private string _OCR_Read_Result;
        private string OCR_Read_Result
        {
            get { return _OCR_Read_Result; }
            set
            {
                _OCR_Read_Result = value;
                CommonObj.DataLayer.Aligner_OCR_ReadID = _OCR_Read_Result;
                SetLabelWaferID(_OCR_Read_Result);
            }
        }
        private bool _bOcrResultIsOK; //Gary v1.0.0.8 OCR結果是OK或NG
        private bool bOcrResultIsOK
        {
            get { return _bOcrResultIsOK; }
            set
            {
                _bOcrResultIsOK = value;
                DataLayer.bOcrAlignerResultOK = _bOcrResultIsOK;
            }
        }

        private bool bTimeReset;
        //Gary 20231028
        private Thread DialogFormThread = null;                 // 其他表單處理專用執行緒
        private bool StopDialogFormThread = true;               // 其他表單處理專用執行緒運行旗標

        private bool bShowOCR_ReadIDFailForm = false;
        private Failure_Action OCR_ReadIDFailReturn = Failure_Action.None;

        private bool bShowWaferIDManualInputForm = false;
        private DialogResult WaferIDManualInputFormReturn = DialogResult.None;

        private bool bShowOCRTeachingSoftwareForm = false;
        private string TempImagePath;

        ImageConverter imageConverter = new ImageConverter();

        public delegate void DelShowImage(Image _Image);

        private Thread OcrReadThread = null;                 // OCR 讀取專用執行緒 Gary v1.0.0.8
        private bool StopOcrReadThread = true;               // OCR 讀取專用執行緒運行旗標 Gary v1.0.0.8
        private bool bOcrReadErr = false;//Gary v1.0.0.8

        private bool bTeachAngleCountArrive;
        #endregion

        #region 設定參數
        private struct BasicValue
        {
            public bool UseLogFlowChartRunTime;
            public bool bIsSimulation;
            public bool UseTeachingSoftware;
            public bool UseOCRInSimulation;

            public string OCRSocket_IpAddress;
            public string B_sTeachingSoftwarePath;

            public int CylinderActionDelayTime;
            public int CylinderActionTimeout;

            public bool SaveOCRImage;
            public string SaveImageFolderPath;

            public bool CheckChecksum;
        }
        private BasicValue BValue;

        private struct PackageValue
        {
            public int _WaferSize;
            public bool Aligner_CheckSum;
        }
        private PackageValue PValue;

        private struct OptionValue
        {
            public bool DryRun;
        }
        private OptionValue OValue;
        #endregion

        public WOI_AB()
        {
            InitializeComponent();

            CreateComponentList();
            DialogFormThread = new Thread(PPFAProcess);
            DialogFormThread.Start();
            StopDialogFormThread = false;

            IntPtr hwnd = this.Handle;
            this.Location = new Point(0, 0);
            this.Dock = DockStyle.Fill;
            this.Refresh();

            WidLib = new Wid110Lib();
            TempImagePath = Path.GetFullPath(WidLib.getTmpImage());

            OcrReadThread = new Thread(OCRProcess);
            OcrReadThread.Start();
            StopOcrReadThread = false;
        }

        #region 繼承函數

        //模組解構使用
        public override void DisposeTH()
        {
            OCR_Disconnect();
            StopDialogFormThread = true;
            DialogFormThread.Join();

            StopOcrReadThread = true;
            OcrReadThread.Join();
            base.DisposeTH();
        }

        //程式初始化
        public override void Initial()
        {
            DataReset();
            Cylinder_OCR = new Cylinder(ob_Ocr_Out, ib_Ocr_Out, ib_Ocr_Back);
            Cylinder_OCR.Simulation = BValue.bIsSimulation;

            Flag_WOI_Action = new JActionFlag();
            Flag_OcrRead_Action = new JActionFlag();
        }

        //持續偵測函數
        public override void AlwaysRun()  //持續掃描
        {
            //if (PackageName != "" && PackageName != null)
            //{
            //    if (PReadValue("_WaferSize").ToInt() == 0)
            //    {
            //        if (Cylinder_OCR.OnSensorValue == false)
            //        {
            //            Cylinder_OCR.On();
            //        }
            //    }
            //    else
            //    {
            //        if (Cylinder_OCR.OffSensorValue == false)
            //        {
            //            Cylinder_OCR.Off();
            //        }
            //    }
            //}
        }
        public override int ScanIO() { return 0; } //掃描硬體按鈕IO

        //歸零相關函數
        public override void HomeReset()  //歸零前的重置
        {
            mHomeOk = false;
            DataReset();
            Flag_WOI_Action.Reset();
            _WOI_ActionMode = WOI_ActionMode.None;

            FC_HOME_START.TaskReset();
            FC_AUTO_OCRCONNECT_START.TaskReset();
            FC_AUTO_INCH_SWITCH_START.TaskReset();
            FC_AUTO_TRIGGER_START.TaskReset();
            FC_Auto_TeachAngleMode_START.TaskReset();
        }
        public override bool Home() //歸零
        {
            if (bTimeReset)
            {
                HomeTM.Restart();
                bTimeReset = false;
            }

            FC_HOME_START.MainRun();
            FC_AUTO_OCRCONNECT_START.MainRun();
            FC_AUTO_INCH_SWITCH_START.MainRun();
            return mHomeOk;
        } 

        //運轉相關函數
        public override void ServoOn() { } //Motor Servo On
        public override void ServoOff() { } //Motor Servo Off
        public override void RunReset()  //運轉前初始化
        {
            if (PReadValue("_WaferSize").ToInt() == 0)
            {
                //if (Cylinder_OCR.OnSensorValue == false)
                //{
                    Cylinder_OCR.On();
                //}
            }
            else
            {
                //if (Cylinder_OCR.OffSensorValue == false)
                //{
                    Cylinder_OCR.Off();
                //}
            }
        }
        public override void Run()  //運轉
        {
            if (bTimeReset)
            {
                RunTM.Restart();
                bTimeReset = false;
            }
            //if (IsSimulation() == 0)
            //{
            //    if (PReadValue("_WaferSize").ToInt() == 0)
            //    {
            //        if (Cylinder_OCR.OnSensorValue == false)
            //            ShowAlarm("E", 5);
            //    }
            //    else
            //    {
            //        if (Cylinder_OCR.OffSensorValue == false)
            //            ShowAlarm("E", 5);
            //    }
            //}

            FC_AUTO_INCH_SWITCH_START.MainRun();
            FC_AUTO_OCRCONNECT_START.MainRun();
            FC_AUTO_TRIGGER_START.MainRun();
            FC_Auto_TeachAngleMode_START.MainRun();
        }
        public override void SetSpeed(bool bHome = false) { } //速度設定

        //手動相關函數
        public override void ManualReset() { } //手動運行前置設定
        public override void ManualRun() { } //手動模式運行

        //停止所有馬達
        public override void StopMotor()
        {
            bTimeReset = true;
            base.StopMotor();
        }

        public override void AfterSaveParam()
        {
            LoadBasicData();
            //base.AfterSaveParam();
        }
        #endregion

        #region 私有函數
        private void OCRProcess(object obj)
        {
            while (!StopOcrReadThread)
            {
                if (Flag_OcrRead_Action != null)
                {
                    while (Flag_OcrRead_Action.IsDoIt())
                    {
                        Flag_OcrRead_Action.Doing();
                        if (OCR_Trigger())
                        {
                            bOcrReadErr = false;
                        }
                        else
                        {
                            bOcrReadErr = true;
                        }
                        Flag_OcrRead_Action.Done();
                    }
                }

                Thread.Sleep(10);
            }
        }
        /// <summary>
        /// 處理表單視窗
        /// </summary>
        /// <param name="obj"></param>
        private void PPFAProcess(object obj)
        {
            while (!StopDialogFormThread)
            {
                while (bShowOCR_ReadIDFailForm)
                {
                    OCR_ReadIDFailReturn = Failure_Action.None;
                    string Title = "OCR Read ID Fail";
                    string[] btnName = { "Retry", "Manual Input", "Correction", "Reject" };
                    Failure_Action[] btnActions = { Failure_Action.Retry, Failure_Action.ManualInput, Failure_Action.Correction, Failure_Action.Reject };
                    Failure_Action_Form OCR_ReadIDFailForm = new Failure_Action_Form(Title, btnName, btnActions);
                    OCR_ReadIDFailForm.Text = "Aligner Fail Action Form"; //v1.0.0.13 Munin
                    OCR_ReadIDFailForm.ShowForm();
                    OCR_ReadIDFailReturn = OCR_ReadIDFailForm.GetResult();
                    if (OCR_ReadIDFailReturn == Failure_Action.Correction)
                    {
                        OCR_Disconnect();
                        bShowOCRTeachingSoftwareForm = true;
                    }
                    else if (OCR_ReadIDFailReturn == Failure_Action.ManualInput)
                    {
                        WaferIDManualInputFormReturn = System.Windows.Forms.DialogResult.None;
                        bShowWaferIDManualInputForm = true;
                    }
                    bShowOCR_ReadIDFailForm = false;
                    OCR_ReadIDFailForm.Close();
                }

                while (bShowWaferIDManualInputForm)
                {
                    WaferIDManualInputFormReturn = System.Windows.Forms.DialogResult.None;
                    InputCassetteIDForm InputWaferIDForm = new InputCassetteIDForm("Wafer Data");
                    InputWaferIDForm.Text = "Aligner Input Cassette ID Form"; //v1.0.0.13 Munin
                    InputWaferIDForm.ShowForm();
                    OCR_Read_Result = InputWaferIDForm.GetCstID;
                    WaferIDManualInputFormReturn = InputWaferIDForm.GetActionResult;
                    bShowWaferIDManualInputForm = false;
                    InputWaferIDForm.Close();
                }

                while (bShowOCRTeachingSoftwareForm)
                {
                    OpenTeachingSoftware();
                    bShowOCRTeachingSoftwareForm = false;
                }

                Thread.Sleep(50);
            }
        }
        /// <summary>
        /// 汽缸手動開關
        /// </summary>
        /// <param name="CY"></param>
        private void CY_Switch(Cylinder CY)
        {
            bool b1 = CY.OnSensorValue;
            bool b2 = CY.OffSensorValue;

            ThreeValued rt = (b1 == true && b2 == false) ? CY.Off() : CY.On();
        }
        /// <summary>
        /// 控制汽缸
        /// </summary>
        /// <param name="eCy"></param>
        /// <param name="bOn"></param>
        /// <returns></returns>
        private bool Cylinder_Ctrl(eCylinder eCy, ECylinderAction eAction)
        {
            Cylinder Cy = null;
            switch (eCy)
            {
                case eCylinder.OcrCY:
                    Cy = Cylinder_OCR;
                    break;
                default:
                    Cy = null;
                    break;
            }

            int DelayTime = 0;
            int Timeout = 0;

            DelayTime = BValue.CylinderActionDelayTime;
            Timeout = BValue.CylinderActionTimeout;

            ThreeValued rt = ThreeValued.UNKNOWN;
            switch (eAction)
            {
                case ECylinderAction.Close:
                    rt = Cy.Off(DelayTime, Timeout);
                    break;
                case ECylinderAction.Open:
                    rt = Cy.On(DelayTime, Timeout);
                    break;
                default:
                    break;
            }

            if (rt ==  ThreeValued.TRUE)
            {
                return true;
            }
            else if (rt == ThreeValued.FALSE)
            {
                string sSwitch = ECylinderAction.Open.ToString();
                switch (eCy)
                {
                    case eCylinder.OcrCY:
                        ShowAlarm("E", 1, sSwitch);
                        break;
                    default:
                        break;
                }
            }
            return false;

        }
        /// <summary>
        /// 儲存流程花費時間
        /// </summary>
        /// <param name="FlowChart_MainRun">MainRun的流程</param>
        /// <param name="Msg">其他訊息</param>
        private void LogFlowChartRunTime(FlowChart FlowChart_MainRun, string Msg = "")
        {
            if (BValue.UseLogFlowChartRunTime)
            {
                string sLog = string.Format("({0}){1},{2},{3}", FlowChart_MainRun.Text, FlowChart_MainRun.NowTask.Text, FlowChart_MainRun.NowTask.RunTime, Msg);
                JLogger.LogTrace("FlowChartRunTime_WOI", sLog);
            }
        }

        private delegate void SetBtnEnable(bool b);
        private void SetBtnOcrConnectEnable(bool b)
        {
            if (this.InvokeRequired)
            {
                SetBtnEnable DelSetBtnEnable = new SetBtnEnable(SetBtnOcrConnectEnable);
                this.Invoke(DelSetBtnEnable, b);
            }
            else
            {
                btn_ORC_Connect.Enabled = b;
            }
        }
        private bool OCR_Connect()
        {
            IPAddress ipAddr;
            if (!IPAddress.TryParse(BValue.OCRSocket_IpAddress, out ipAddr))
            {
                return false;
            }

            if (WidLib.FInit(BValue.OCRSocket_IpAddress))
            {
                SetBtnOcrConnectEnable(false);
                connected = true;
                return true;
            }
            return false;
        }

        private bool OCR_Trigger()
        {
            if (WidLib.FProcessRead())
            {
                // get read result
                string[] WaferID = WidLib.FGetWaferId().Split(':');
                OCR_Read_Result = WaferID[1].Replace(" ","");
                return true;
            }
            return false;
        }

        private bool OCR_Disconnect()
        {
            if (WidLib.FExit())
            {
                connected = false;
                return true;
            }
            SetBtnOcrConnectEnable(true);
            return false;
        }

        public delegate void ShowMsg(string msg);
        private void SetLabelWaferID(string ID)
        {
            if (this.InvokeRequired)
            {
                ShowMsg delShowMsg = new ShowMsg(SetLabelWaferID);
                this.Invoke(delShowMsg, ID);
            }
            else
            {
                lb_WaferID.Text = ID;
            }
        }

        private void OpenTeachingSoftware()
        {
            try
            {
                // 要啟動的應用程式的路徑
                string appPath = @BValue.B_sTeachingSoftwarePath;

                // 如果您需要傳遞命令列引數，可以在第二個參數中指定它們
                //string arguments = "arg1 arg2 arg3";

                // 創建 ProcessStartInfo 對象以設定應用程式的相關信息
                ProcessStartInfo startInfo = new ProcessStartInfo
                {
                    FileName = appPath,        // 應用程式路徑
                    //Arguments = arguments,     // 命令列引數（可選）
                    UseShellExecute = false    // 使用系統外部殼程式執行（預設為 true）
                };

                // 創建 Process 對象並啟動應用程式
                Process process = new Process
                {
                    StartInfo = startInfo
                };
                process.Start();

                // 等待應用程式結束
                process.WaitForExit();
            }
            catch (Exception ex)
            {
                MessageBox.Show("啟動應用程式時出現錯誤：" + ex.Message);
            }
        }

        private void GetProcessImage(int bestOrAll)
        {
            if (!WidLib.FIsInitialized())
            {
                //HandleWidLibError();
                return;
            }

            int counter = 0;
            while (true)
            {
                if (!WidLib.FProcessGetImage(TempImagePath, bestOrAll))
                {
                    if (WidLib.getErrno() == Wid110LibConst.ecNoMoreImg)
                    {
                        //logMsg(counter.ToString() + " images retrieved after last process trigger.");
                        return;
                    }
                    //HandleWidLibError();
                }

                //ImageDialog.Show();
                //ImageDialog.pictureBox.Load(TempImagePath);
                Image Ocr_Image = (Image)imageConverter.ConvertFrom(File.ReadAllBytes(TempImagePath));
                ShowOcrImage(Ocr_Image);
                //pbx_OCR_Read.Load(TempImagePath);
                if (BValue.SaveOCRImage)//v1.0.0.13
                {
                    Bitmap bitmap = new Bitmap(Ocr_Image);
                    SaveImage(bitmap);
                }
                counter++;
            }
        }

        private void SaveImage(Bitmap bitmap)//v1.0.0.13
        {
            string sDate = DateTime.Now.ToString("yyyyMMdd");
            string sTime = DateTime.Now.ToString("HHmmss");
            string directoryPath = @BValue.SaveImageFolderPath + @"\" + sDate + @"\";
            string originalFileName = "Image_" + sTime + ".bmp";
            string bOcrReadErrForSave = bOcrReadErr ? "Fail" : "Pass";
            // 指定硬碟的根目錄，例如 "C:\"
            string driveLetter = "E:\\";

            // 獲取硬碟信息
            DriveInfo driveInfo = new DriveInfo(driveLetter);

            // 檢查硬碟是否已滿 (閾值為 10MB)
            long threshold = 10 * 1024 * 1024; // 10MB
            if (driveInfo.AvailableFreeSpace <= threshold)
            {
                MessageBox.Show("Hard drive is full, please check.");
                return;
            }

            // 檢查目錄是否存在，若不存在則創建
            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }

            // 確定要保存的完整文件路徑
            string filePath = Path.Combine(directoryPath, bOcrReadErrForSave + originalFileName);

            // 若文件已存在，則添加序號到文件名後面，直到找到一個可用的文件名
            //int counter = 1;
            //while (File.Exists(filePath))
            //{
            //    filePath = Path.Combine(directoryPath, Path.GetFileNameWithoutExtension(originalFileName) + "_" + counter + Path.GetExtension(originalFileName));
            //    counter++;
            //}

            // 將位圖保存到文件中
            bitmap.Save(filePath, System.Drawing.Imaging.ImageFormat.Bmp);
        }

        private void ShowOcrImage(Image _Image)
        {
            if (this.InvokeRequired)
            {
                DelShowImage delShowImage = new DelShowImage(ShowOcrImage);
                this.Invoke(delShowImage, _Image);
            }
            else
            {
                if (bOcrResultIsOK)
                {
                    lb_OcrResult.Text = "OK";
                    lb_OcrResult.ForeColor = Color.Lime;
                }
                else
                {
                    lb_OcrResult.Text = "NG";
                    lb_OcrResult.ForeColor = Color.Red;
                }
                pbx_OCR_Read.Image = _Image;
                CommonObj.DataLayer.Ocr_Aligner_Image = _Image;
            }
        }
        #endregion

        #region 公用函數
        /// <summary>
        /// 更新參數
        /// </summary>
        public void DataReset()
        {
            LoadBasicData();
            LoadPackageData();
            LoadOptionData();
        }
        /// <summary>
        /// 讀取模組資料
        /// </summary>
        public void LoadBasicData()
        {
            BValue.UseLogFlowChartRunTime = SReadValue("UseLogFlowChartRunTime").ToBoolean();
            BValue.bIsSimulation = IsSimulation() != 0;
            BValue.OCRSocket_IpAddress = SReadValue("OCRSocket_IpAddress").ToString();
            BValue.CylinderActionDelayTime = SReadValue("CylinderActionDelayTime").ToInt();
            BValue.CylinderActionTimeout = SReadValue("CylinderActionTimeout").ToInt();
            BValue.UseTeachingSoftware = SReadValue("UseTeachingSoftware").ToBoolean();
            BValue.UseOCRInSimulation = SReadValue("UseOCRInSimulation").ToBoolean();
            BValue.B_sTeachingSoftwarePath = SReadValue("B_sTeachingSoftwarePath").ToString();

            BValue.SaveOCRImage = SReadValue("SaveOCRImage").ToBoolean();
            BValue.SaveImageFolderPath = SReadValue("SaveImageFolderPath").ToString();
            BValue.CheckChecksum = SReadValue("CheckChecksum").ToBoolean();
        }
        /// <summary>
        /// 讀取產品資料
        /// </summary>
        public void LoadPackageData()
        {
            PValue._WaferSize = SReadValue("_WaferSize").ToInt();
            PValue.Aligner_CheckSum = PReadValue("Aligner_CheckSum").ToBoolean();
            
        }
        /// <summary>
        /// 讀取系統設定資料
        /// </summary>
        public void LoadOptionData()
        {
            OValue.DryRun = OReadValue("DryRun").ToBoolean();
        }

        /// <summary>
        /// 取得動作結果
        /// </summary>
        /// <returns></returns>
        public bool GetActionResult()
        {
            if (this.GetUseModule().Equals(false))
            {
                return false;
            }

            if (Flag_WOI_Action.IsDone())
            {
                return true;
            }
            return false;
        }
        /// <summary>
        /// 設定動作
        /// </summary>
        /// <param name="mode"></param>
        /// <returns></returns>
        public bool SetCommand(WOI_ActionMode mode)
        {
            if (this.GetUseModule().Equals(false))
            {
                return true;
            }

            if (!Flag_WOI_Action.IsDoing())
            {
                _WOI_ActionMode = mode;
                Flag_WOI_Action.DoIt();
                return true;
            }
            return false;
        }

        public void SetTeachAngleCountArrive(bool b)
        {
            bTeachAngleCountArrive = b;
        }

        public void FlowChartRecord()
        {
            List<FlowChart> FCs = new List<FlowChart>();
            FCs.Add(FC_HOME_START);
            FCs.Add(FC_AUTO_OCRCONNECT_START);
            FCs.Add(FC_AUTO_INCH_SWITCH_START);
            FCs.Add(FC_AUTO_TRIGGER_START);
            FCs.Add(FC_Auto_TeachAngleMode_START);

            LogRecord.FlowChartRecord("WOIA", FCs);
        }
        #endregion

        
        #region Button
        /// <summary>
        /// 汽缸手動開關
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Cylider_Switch_Click(object sender, EventArgs e)
        {
            CY_Switch(Cylinder_OCR);
        }

        private void btn_ORC_Connect_Click(object sender, EventArgs e)
        {
            OCR_Connect();
        }

        private void btn_ORC_Read_Click(object sender, EventArgs e)
        {
            Stopwatch watch = new Stopwatch();
            watch.Restart();
            OCR_Trigger();
            bOcrResultIsOK = OCR_Read_Result == "fail" ? false : true;
            GetProcessImage(0);
            watch.Stop();
            lb_ReadTime.Text = watch.ElapsedMilliseconds.ToString();
            watch = null;
        }

        private void btn_ORC_Disconnect_Click(object sender, EventArgs e)
        {
            OCR_Disconnect();
            btn_ORC_Connect.Enabled = true;
        }

        private void btn_OpenTeachingSoftware_Click(object sender, EventArgs e)
        {
            OCR_Disconnect();
            bShowOCRTeachingSoftwareForm = true;
        }

        public void OpenTeachingSoftware_UseMain() 
        {
            OCR_Disconnect();
            bShowOCRTeachingSoftwareForm = true;
        }
        #endregion

        #region 流程
        private FlowChart.FCRESULT FC_NEXT_Run()
        {
            //共用
            return FlowChart.FCRESULT.NEXT;
        }

        #region =================================================== HOME ===================================================
        private FlowChart.FCRESULT FC_HOME_START_Run()
        {
            return FlowChart.FCRESULT.NEXT;
        }

        private FlowChart.FCRESULT FC_Home_WaitCmd_Run()
        {
            if (mCanHome)
            {
                LogFlowChartRunTime(FC_HOME_START);
                HomeTM.Restart();
                return FlowChart.FCRESULT.NEXT;
            }
            return FlowChart.FCRESULT.IDLE;
        }

        private FlowChart.FCRESULT FC_Home_OcrCyOff_Run()
        {
            return FlowChart.FCRESULT.NEXT;
            if (Cylinder_Ctrl(eCylinder.OcrCY, ECylinderAction.Close))//Close:12 Inch
            {
                LogFlowChartRunTime(FC_HOME_START);
                HomeTM.Restart();
                return FlowChart.FCRESULT.NEXT;
            }
            return FlowChart.FCRESULT.IDLE;
        }

        private FlowChart.FCRESULT FC_Home_DoOcrConnect_Run()
        {
            bool b1 = SetCommand(WOI_ActionMode.Connect);
            if (b1 == true)
            {
                LogFlowChartRunTime(FC_HOME_START);
                HomeTM.Restart();
                return FlowChart.FCRESULT.NEXT;
            }
            return FlowChart.FCRESULT.IDLE;
        }

        private FlowChart.FCRESULT FC_Home_OcrConnectDone_Run()
        {
            bool b1 = GetActionResult();
            if (b1 == true)
            {
                LogFlowChartRunTime(FC_HOME_START);
                HomeTM.Restart();
                return FlowChart.FCRESULT.NEXT;
            }
            return FlowChart.FCRESULT.IDLE;
        }

        private FlowChart.FCRESULT FC_Home_DoInchSwitch_Run()
        {
            return FlowChart.FCRESULT.NEXT;
            if (PackageName == null && PackageName == "")
            {
                HomeTM.Restart();
                return FlowChart.FCRESULT.NEXT;
            }

            bool b1 = false;
            switch (PValue._WaferSize)
            {
                case 0:
                    b1 = SetCommand(WOI_ActionMode.SetInch8);
                    break;
                case 1:
                    b1 = SetCommand(WOI_ActionMode.SetInch12);
                    break;
            }

            if (b1 == true)
            {
                LogFlowChartRunTime(FC_HOME_START);
                HomeTM.Restart();
                return FlowChart.FCRESULT.NEXT;
            }
            return FlowChart.FCRESULT.IDLE;
        }

        private FlowChart.FCRESULT FC_Home_InchSwitchDone_Run()
        {
            return FlowChart.FCRESULT.NEXT;
            if (PackageName == null && PackageName == "")
            {
                HomeTM.Restart();
                return FlowChart.FCRESULT.NEXT;
            }

            bool b1 = GetActionResult();
            if (b1 == true)
            {
                LogFlowChartRunTime(FC_HOME_START);
                HomeTM.Restart();
                return FlowChart.FCRESULT.NEXT;
            }
            return FlowChart.FCRESULT.IDLE;
        }

        private FlowChart.FCRESULT FC_Home_Done_Run()
        {
            mHomeOk = true;
            return FlowChart.FCRESULT.IDLE;
        }

        #endregion =================================================== HOME ===================================================

        #region =================================================== Trigger ===================================================
        private FlowChart.FCRESULT FC_AUTO_TRIGGER_START_RUN()
        {
            return FlowChart.FCRESULT.NEXT;
        }

        private FlowChart.FCRESULT FC_Auto_Trigger_WaitCmd_Run()
        {
            if (Flag_WOI_Action.IsDoIt())
            {
                if (_WOI_ActionMode == WOI_ActionMode.Inspection)
                {
                    Flag_WOI_Action.Doing();
                    bOcrReadErr = false;
                    Flag_OcrRead_Action.DoIt();//Gary v1.0.0.8
                    LogFlowChartRunTime(FC_AUTO_TRIGGER_START);
                    RunTM.Restart();
                    return FlowChart.FCRESULT.NEXT;
                }
            }
            return FlowChart.FCRESULT.IDLE;
        }

        private FlowChart.FCRESULT FC_Auto_Trigger_Trigger_Run()
        {
            //_REJECT
            //if (OValue.DryRun)
            //{
            //    RunTM.Restart();
            //    return FlowChart.FCRESULT.NEXT;
            //}

            if (BValue.bIsSimulation && !BValue.UseOCRInSimulation)
            {
                OCR_Read_Result = "SIMULATION";
                RunTM.Restart();
                return FlowChart.FCRESULT.NEXT;
            }

            //if (OCR_Trigger())
            if(Flag_OcrRead_Action.IsDone())
            {
                if (bOcrReadErr)
                {
                    ShowAlarm("E", 3);//OCR辨識失敗，請檢查是否連線
                    return FlowChart.FCRESULT.CASE2;
                }
                else
                {
                    if (OCR_Read_Result == "fail")// && BValue.UseTeachingSoftware)
                    {
                        bOcrResultIsOK = false;
                        GetProcessImage(0);
                        WaferIDManualInputFormReturn = System.Windows.Forms.DialogResult.None;
                        OCR_ReadIDFailReturn = Failure_Action.None;
                        bShowOCR_ReadIDFailForm = true;
                        ShowAlarm("E", 4);
                        return FlowChart.FCRESULT.CASE1;
                    }

                    if (BValue.CheckChecksum || PValue.Aligner_CheckSum)    //v1.0.0.5新增Aligner_CheckSum  Munin
                    {
                        if (_CommonObj.WaferChecksumIsOK(OCR_Read_Result) == false)
                        {
                            bOcrResultIsOK = false;
                            GetProcessImage(0);
                            WaferIDManualInputFormReturn = System.Windows.Forms.DialogResult.None;
                            OCR_ReadIDFailReturn = Failure_Action.None;
                            bShowOCR_ReadIDFailForm = true;
                            ShowAlarm("E", 6);
                            return FlowChart.FCRESULT.CASE1;
                        }
                    }
                    bOcrResultIsOK = true;
                    GetProcessImage(0);
                    LogFlowChartRunTime(FC_AUTO_TRIGGER_START);
                    RunTM.Restart();
                    return FlowChart.FCRESULT.NEXT;
                }
            }
            return FlowChart.FCRESULT.IDLE;
        }

        private FlowChart.FCRESULT FC_Auto_Trigger_ReadIDFailResult_Run()
        {
            switch (OCR_ReadIDFailReturn)
            {
                case Failure_Action.Retry:
                    bOcrReadErr = false;
                    Flag_OcrRead_Action.DoIt();//Gary v1.0.0.8
                    return FlowChart.FCRESULT.CASE1;

                case Failure_Action.ManualInput:
                    return FlowChart.FCRESULT.CASE2;

                case Failure_Action.Reject:
                    OCR_Read_Result = "_REJECT";
                    return FlowChart.FCRESULT.CASE3;

                case Failure_Action.Correction:
                    return FlowChart.FCRESULT.NEXT;

                default:
                    break;
            }
            return FlowChart.FCRESULT.IDLE;
        }

        private FlowChart.FCRESULT FC_Auto_Trigger_ManualInputIDResult_Run()
        {
            switch (WaferIDManualInputFormReturn)
            {
                case System.Windows.Forms.DialogResult.OK:
                    return FlowChart.FCRESULT.NEXT;
                case System.Windows.Forms.DialogResult.Cancel: //v1.0.0.5新增Cancel選項
                    return FlowChart.FCRESULT.CASE1;
                    
                default:
                    break;
            }
            return FlowChart.FCRESULT.IDLE;
        }

        private FlowChart.FCRESULT FC_Auto_Trigger_Connect_Run()
        {
            if (BValue.bIsSimulation && !BValue.UseOCRInSimulation)
            {
                RunTM.Restart();
                return FlowChart.FCRESULT.NEXT;
            }

            if (bShowOCRTeachingSoftwareForm == false)
            {
                if (OCR_Connect())
                {
                    bOcrReadErr = false;
                    Flag_OcrRead_Action.DoIt();//Gary v1.0.0.8
                    LogFlowChartRunTime(FC_AUTO_TRIGGER_START);
                    RunTM.Restart();
                    return FlowChart.FCRESULT.NEXT;
                }
                else
                {
                    ShowAlarm("E", 2);
                }
            }
            return FlowChart.FCRESULT.IDLE;
        }

        private FlowChart.FCRESULT FC_Auto_Trigger_Done_Run()
        {
            _WOI_ActionMode = WOI_ActionMode.None;
            Flag_WOI_Action.Done();
            RunTM.Restart();
            LogFlowChartRunTime(FC_AUTO_TRIGGER_START);
            return FlowChart.FCRESULT.NEXT;
        }
        #endregion =================================================== Trigger ===================================================

        #region =================================================== Connect ===================================================
        private FlowChart.FCRESULT FC_AUTO_OCRCONNECT_START_Run()
        {
            return FlowChart.FCRESULT.NEXT;
        }

        private FlowChart.FCRESULT FC_Auto_OcrConnect_WaitCmd_Run()
        {
            if (Flag_WOI_Action.IsDoIt())
            {
                if (_WOI_ActionMode == WOI_ActionMode.Connect)
                {
                    Flag_WOI_Action.Doing();
                    LogFlowChartRunTime(FC_AUTO_OCRCONNECT_START);
                    RunTM.Restart();
                    return FlowChart.FCRESULT.NEXT;
                }
            }
            return FlowChart.FCRESULT.IDLE;
        }

        private FlowChart.FCRESULT FC_Auto_OcrConnect_Connect_Run()
        {
            if (BValue.bIsSimulation && !BValue.UseOCRInSimulation)
            {
                RunTM.Restart();
                return FlowChart.FCRESULT.NEXT;
            }

            if (OCR_Connect())
            {
                LogFlowChartRunTime(FC_AUTO_OCRCONNECT_START);
                HomeTM.Restart();
                return FlowChart.FCRESULT.NEXT;
            }

            if (RunTM.On(10000))
            {
                ShowAlarm("E", 2);
                RunTM.Restart();
            }
            return FlowChart.FCRESULT.IDLE;
        }

        private FlowChart.FCRESULT FC_Auto_OcrConnect_Done_Run()
        {
            _WOI_ActionMode = WOI_ActionMode.None;
            Flag_WOI_Action.Done();
            RunTM.Restart();
            LogFlowChartRunTime(FC_AUTO_OCRCONNECT_START);
            return FlowChart.FCRESULT.NEXT;
        }
        #endregion =================================================== Connect ===================================================

        #region =================================================== Inch Switch ===================================================
        private FlowChart.FCRESULT FC_AUTO_INCH_SWITCH_START_Run()
        {
            return FlowChart.FCRESULT.NEXT;
        }

        private FlowChart.FCRESULT FC_AUTO_InchSwitch_WaitCmd_Run()
        {
            if (Flag_WOI_Action.IsDoIt())
            {
                if (_WOI_ActionMode == WOI_ActionMode.SetInch8 || _WOI_ActionMode == WOI_ActionMode.SetInch12)
                {
                    Flag_WOI_Action.Doing();
                    LogFlowChartRunTime(FC_AUTO_INCH_SWITCH_START);
                    RunTM.Restart();
                    return FlowChart.FCRESULT.NEXT;
                }
            }
            return FlowChart.FCRESULT.IDLE;
        }

        private FlowChart.FCRESULT FC_AUTO_InchSwitch_CyliderAction_Run()
        {
            bool b1 = false;
            switch (_WOI_ActionMode)
            {
                case WOI_ActionMode.SetInch8:
                    b1 = Cylinder_Ctrl(eCylinder.OcrCY, ECylinderAction.Open);
                    break;
                case WOI_ActionMode.SetInch12:
                    b1 = Cylinder_Ctrl(eCylinder.OcrCY, ECylinderAction.Close);
                    break;
            }

            if (b1)
            {
                LogFlowChartRunTime(FC_AUTO_INCH_SWITCH_START);
                RunTM.Restart();
                return FlowChart.FCRESULT.NEXT;
            }
            return FlowChart.FCRESULT.IDLE;
        }

        private FlowChart.FCRESULT FC_AUTO_InchSwitch_Done_Run()
        {
            _WOI_ActionMode = WOI_ActionMode.None;
            Flag_WOI_Action.Done();
            RunTM.Restart();
            LogFlowChartRunTime(FC_AUTO_INCH_SWITCH_START);
            return FlowChart.FCRESULT.NEXT;
        }
        #endregion =================================================== Inch Switch ===================================================

        #region =================================================== Teach Angle Mode ===================================================
        private FlowChart.FCRESULT FC_Auto_TeachAngleMode_START_Run()
        {
            return FlowChart.FCRESULT.NEXT;
        }

        private FlowChart.FCRESULT FC_Auto_TeachAngleMode_WaitCommand_Run()
        {
            if (Flag_WOI_Action.IsDoIt())
            {
                if (_WOI_ActionMode == WOI_ActionMode.TeachAngle)
                {
                    Flag_WOI_Action.Doing();
                    bOcrReadErr = false;
                    Flag_OcrRead_Action.DoIt();//Gary v1.0.0.8
                    LogFlowChartRunTime(FC_Auto_TeachAngleMode_START);
                    RunTM.Restart();
                    return FlowChart.FCRESULT.NEXT;
                }
            }
            return FlowChart.FCRESULT.IDLE;
        }

        private FlowChart.FCRESULT FC_Auto_TeachAngleMode_Trigger_Run()
        {
            if (BValue.bIsSimulation && !BValue.UseOCRInSimulation)
            {
                RunTM.Restart();
                return FlowChart.FCRESULT.NEXT;
            }

            //if (bTeachAngleCountArrive)
            //{
            //    WaferIDManualInputFormReturn = System.Windows.Forms.DialogResult.None;
            //    OCR_ReadIDFailReturn = Failure_Action.None;
            //    bShowOCR_ReadIDFailForm = true;
            //    return FlowChart.FCRESULT.CASE1;
            //}

            //if (OCR_Trigger())
            if (Flag_OcrRead_Action.IsDone())
            {
                if (bOcrReadErr)
                {
                    ShowAlarm("E", 3);//OCR辨識失敗，請檢查是否連線
                    return FlowChart.FCRESULT.CASE2;
                }
                else
                {
                    if (OCR_Read_Result == "fail")// && BValue.UseTeachingSoftware)
                    {
                        bOcrResultIsOK = false;
                        GetProcessImage(0);
                    }
                    else
                    {
                        bOcrResultIsOK = true;
                        GetProcessImage(0);
                    }
                    LogFlowChartRunTime(FC_Auto_TeachAngleMode_START);
                    RunTM.Restart();
                    return FlowChart.FCRESULT.NEXT;
                }
            }
            return FlowChart.FCRESULT.IDLE;
        }

        private FlowChart.FCRESULT FC_Auto_TeachAngleMode_ReadIDFailResult_Run()
        {
            switch (OCR_ReadIDFailReturn)
            {
                case Failure_Action.Retry:
                    OCR_Read_Result = "_RETRY";
                    return FlowChart.FCRESULT.CASE3;

                case Failure_Action.ManualInput:
                    return FlowChart.FCRESULT.CASE2;

                case Failure_Action.Reject:
                    OCR_Read_Result = "_REJECT";
                    return FlowChart.FCRESULT.CASE3;

                case Failure_Action.Correction:
                    return FlowChart.FCRESULT.NEXT;

                default:
                    break;
            }
            return FlowChart.FCRESULT.IDLE;
        }

        private FlowChart.FCRESULT FC_Auto_TeachAngleMode_ManualInputIDResult_Run()
        {
            switch (WaferIDManualInputFormReturn)
            {
                case System.Windows.Forms.DialogResult.OK:
                    return FlowChart.FCRESULT.NEXT;
                case System.Windows.Forms.DialogResult.Cancel: //v1.0.0.5新增Cancel選項
                    return FlowChart.FCRESULT.CASE1;
                    
                default:
                    break;
            }
            return FlowChart.FCRESULT.IDLE;
        }

        private FlowChart.FCRESULT FC_Auto_TeachAngleMode_Connect_Run()
        {
            if (BValue.bIsSimulation && !BValue.UseOCRInSimulation)
            {
                RunTM.Restart();
                return FlowChart.FCRESULT.NEXT;
            }

            if (bShowOCRTeachingSoftwareForm == false)
            {
                if (OCR_Connect())
                {
                    bOcrReadErr = false;
                    Flag_OcrRead_Action.DoIt();//Gary v1.0.0.8
                    LogFlowChartRunTime(FC_Auto_TeachAngleMode_START);
                    RunTM.Restart();
                    return FlowChart.FCRESULT.NEXT;
                }
                else
                {
                    ShowAlarm("E", 2);
                }
            }
            return FlowChart.FCRESULT.IDLE;
        }

        private FlowChart.FCRESULT FC_Auto_TeachAngleMode_Done_Run()
        {
            _WOI_ActionMode = WOI_ActionMode.None;
            Flag_WOI_Action.Done();
            RunTM.Restart();
            LogFlowChartRunTime(FC_Auto_TeachAngleMode_START);
            return FlowChart.FCRESULT.NEXT;
        }
        #endregion =================================================== Teach Angle Mode ===================================================


        #endregion 流程

    }
}

