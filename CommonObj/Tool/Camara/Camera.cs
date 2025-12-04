using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProVLib;
using System.Net;
using System.Net.Sockets;
using ProVSocketLib;

namespace CommonObj
{
    public partial class Camera : UserControl
    {

        public class InspectResult
        {
            public string X { get; set; }
            public string Y { get; set; }
            public string Angle { get; set; }
        }

        #region Attributes

        [Browsable(true), Category("#參數設定"), Description("連線IP")]
        public string IP
        {
            get
            {
                return NSetting.sIP;
            }
            set
            {
                NSetting.sIP = value;
            }
        }

        [Browsable(true), Category("#參數設定"), Description("連線port:5000:5002:5004:...:5014")]
        public ushort PORT
        {
            get
            {
                return NSetting.usPort;
            }
            set
            {
                NSetting.usPort = value;
            }
        }

        [Browsable(true), Category("#參數設定"), Description("是否為模擬模式")]
        public bool IsSimulation
        {
            get
            {
                return _bIsSimulation;
            }
            set
            {
                _bIsSimulation = value;
            }
        }
        private bool _bIsSimulation = false;

        [Browsable(true), Category("#參數設定"), Description("是否存Log")]
        public bool IsSaveLog
        {
            get
            {
                return _bIsSaveLog;
            }
            set
            {
                _bIsSaveLog = value;
            }
        }
        private bool _bIsSaveLog = true;

        [Browsable(true), Category("#參數設定"), Description("連線方式")]
        public eProVConnectedMode ProVConnectedMode
        {
            get
            {
                return _ProVConnectedMode;
            }
            set
            {
                _ProVConnectedMode = value;
                Ccd_ClientSocket.Visible = _ProVConnectedMode == eProVConnectedMode.SocketEx;
                Ccd_SECSEgnine.Visible = _ProVConnectedMode == eProVConnectedMode.SECSEgnine;
            }
        }
        private eProVConnectedMode _ProVConnectedMode = eProVConnectedMode.SECSEgnine;
        #endregion Attributes

        #region Struct
        struct NetWorkSetting
        {
            //public bool SetFinish;
            public string sIP;
            public ushort usPort;
        }
        private NetWorkSetting NSetting;
        #endregion struct

        #region Enum
        public enum sCCD
        {
            AddNewJobCmd,              //Add New Job                      //開放
            ChangeJobCmd,              //Change Job                       //開放
            StartToInspectCmd,              //Mask
            StartToInspectTray1Cmd,         //左Tray
            StartToInspectTray2Cmd,         //右Tray
            StartToInspectOnflyReadyCmd,    //預備動態拍攝
            GetToInspectOnflyResultCmd,     //動態檢測完成
            NozzleInspectCmd,           //吸嘴定位拍照檢查X軸位置


            GrabSuccessCmd,            //GrabSuccess                      //不能傳
            GetInspectResultCmd,       //GetInspectResult                 //不開放
            DeleteJobCmd,              //Delete Job                       //不開放
            ExportJobCmd,              //Export Job                       //不開放
            ImportJobCmd,              //Import Job                       //不開放
            StartBatchCmd,             //Start Batch                      //不開放
            StopBatchCmd,              //Stop Batch                       //不開放
            LotEndCmd,                 //Lot End                          //不開放
            LotResetCmd,               //Reset Cmd                        //不開放
            LotSaveCmd,                //Lot Save                         //不開放
            RescanCmd,                 //Rescan                           //不開放
            OverwriteCmd,              //Over Write                       //不開放
        }

        public enum eProVConnectedMode
        {
            SECSEgnine,
            SocketEx,
        }
        #endregion Enum

        #region private Parameter
        private string sReturnStatus = "";
        private ProVSocketLib.TAsyncMsgFlusher log;

        private const int iCmdName = 0;
        private const int iCmdState = 1;
        private const int iCmdRet = 2;

        private const int iSubResult1 = 3;
        private const int iSubResult2 = 4;
        private const int iSubResult3 = 5;
        //GetInspectResultCmd,0,Index,Result=value; 這個命令欄為順序不同，須跟視覺確認
        #endregion private Parameter

        public Camera()
        {
            InitializeComponent();

            log = new ProVSocketLib.TAsyncMsgFlusher(500, @"\Log\", PORT.ToString(), null, 0, "log", "");
            Disposed += OnDispose;
        }

        private void OnDispose(object sender, EventArgs e)
        {
            if (Ccd_SECSEgnine != null)
            {
                Ccd_SECSEgnine.Disconnect();
                Ccd_SECSEgnine.Dispose();
            }

            if (Ccd_ClientSocket != null)
            {
                Ccd_ClientSocket.Disconnect();
                Ccd_ClientSocket.Dispose();
            }
        }

        #region Private Function

        private void Send(string[] SendCmd)
        {
            switch (ProVConnectedMode)
            {
                case eProVConnectedMode.SECSEgnine:
                    {
                        if (Ccd_SECSEgnine.IsConnected == true)
                        {
                            string SendComm = String.Join(",", SendCmd);
                            SaveSendMsg(SendComm);
                            sReturnStatus = string.Empty;
                            Ccd_SECSEgnine.SendData(SendComm);
                        }
                    }
                    break;
                case eProVConnectedMode.SocketEx:
                    {
                        if (Ccd_ClientSocket.IsConnected == true)
                        {
                            string SendComm = String.Join(",", SendCmd);
                            SaveSendMsg(SendComm);
                            sReturnStatus = string.Empty;
                            Ccd_ClientSocket.SocketConnection.Send(SendComm);
                        }
                    }
                    break;
                default:
                    break;
            }
          
        }

        #region 讀取
        private void ClientScoket_OnRead(MessageEventArgs MsgArgs)
        {
            ReciveMsg(MsgArgs.Text);
            String strRcv = MsgArgs.Text;
            string[] resultarray = strRcv.Split(new char[] { ',', ';', '\r' });

            Decode(resultarray);
        }

        private void CcdSocket_OnReadEvent(string[] dataArray)
        {
            ReciveMsg(dataArray);
            string result = "";
            for (int i = 0; i < dataArray.Count(); i++)
            {
                result += dataArray[i].TrimEnd('\r').TrimEnd('\n').TrimEnd(' ');
            }
            string[] resultarray = result.Split(new char[] { ',', ';', '\r' });

            Decode(resultarray);
        }

        private void Decode(string[] Msg)
        {
            sCCD RevComm;

            if (Enum.TryParse(Msg[0], out RevComm) == true)
            {
                switch (RevComm)
                {
                    case sCCD.AddNewJobCmd:
                    case sCCD.ChangeJobCmd:
                        {
                            bool bSW = false;
                            string sRet = "";
                            if (Msg[iCmdState] == "0")//0->Success, 1->Fail
                            {
                                sRet = "0";
                                bSW = true;
                            }
                            else
                            {
                                sRet = Msg[iCmdRet];   //1->Fail,讀取錯誤原因//Msg[iCmdRet]
                            }

                            //FeedBack
                            if (GetCCDEventHandler != null)
                            {
                                CCDEventArgs arg = new CCDEventArgs();
                                arg.CmdName = RevComm;
                                arg.ActionRet = true;
                                arg.CmdRet = bSW;
                                arg.ReadValue = sRet;
                                GetCCDEventHandler(null, arg);
                            }
                        }
                        break;

                    case sCCD.StartToInspectCmd: //兩點定位
                        {
                            bool bSW = false;
                            string sRet = "";
                            string sMeasure = "";
                            string sX = "", sY = "", sAngle = "";
                            if (Msg[iCmdState] == "0")//0->Success, 1->Fail
                            {

                                string[] result1 = Msg[iCmdRet].Split('=');
                                if (result1.Length == 2)
                                {
                                    sRet = "0"; // 代表成功
                                    sMeasure = result1[1]; // 例：X1&Y1&A1
                                    bSW = true;

                                    string[] parts = sMeasure.Split('&');
                                    if (parts.Length == 3)
                                    {
                                        sX = parts[0];
                                        sY = parts[1];
                                        sAngle = parts[2];
                                    }
                                }
                                else
                                {
                                    sRet = "格式錯誤"; // 格式錯誤
                                    bSW = false;
                                }
                            }
                            else // 失敗
                            {
                                bSW = false;
                                sRet = Msg[iCmdRet]; // 錯誤訊息
                            }

                            // 回傳事件通知
                            if (GetCCDEventHandler != null)
                            {
                                CCDEventArgs arg = new CCDEventArgs();
                                arg.CmdName = RevComm;
                                arg.ActionRet = true;
                                arg.CmdRet = bSW;
                                arg.GrabRet = true;
                                arg.ReadValue = sRet;
                                arg.MeasureValue = sMeasure;

                                // 新增個別欄位：X、Y、Angle（選擇性）
                                arg.X = sX;
                                arg.Y = sY;
                                arg.Angle = sAngle;

                                GetCCDEventHandler(null, arg);
                            }
                        } break;
                    case sCCD.StartToInspectTray1Cmd://左Tray//兩點定位
                        {
                            bool bSW = false;
                            string sRet = "";
                            string sMeasure = "";
                            string sX = "", sY = "", sAngle = "";
                            if (Msg[iCmdState] == "0")//0->Success, 1->Fail
                            {

                                string[] result1 = Msg[iCmdRet].Split('=');
                                if (result1.Length == 2)
                                {
                                    sRet = "0"; // 代表成功
                                    sMeasure = result1[1]; // 例：X1&Y1&A1
                                    bSW = true;

                                    string[] parts = sMeasure.Split('&');
                                    if (parts.Length == 3)
                                    {
                                        sX = parts[0];
                                        sY = parts[1];
                                        sAngle = parts[2];
                                    }
                                }
                                else
                                {
                                    sRet = "格式錯誤"; // 格式錯誤
                                    bSW = false;
                                }
                            }
                            else // 失敗
                            {
                                bSW = false;
                                sRet = Msg[iCmdRet]; // 錯誤訊息
                            }

                            // 回傳事件通知
                            if (GetCCDEventHandler != null)
                            {
                                CCDEventArgs arg = new CCDEventArgs();
                                arg.CmdName = RevComm;
                                arg.ActionRet = true;
                                arg.CmdRet = bSW;
                                arg.GrabRet = true;
                                arg.ReadValue = sRet;
                                arg.MeasureValue = sMeasure;

                                // 新增個別欄位：X、Y、Angle（選擇性）
                                arg.X = sX;
                                arg.Y = sY;
                                arg.Angle = sAngle;

                                GetCCDEventHandler(null, arg);
                            }
                        } break;
                    case sCCD.StartToInspectTray2Cmd://右Tray//兩點定位
                        {
                            bool bSW = false;
                            string sRet = "";
                            string sMeasure = "";
                            string sX = "", sY = "", sAngle = "";
                            if (Msg[iCmdState] == "0")//0->Success, 1->Fail
                            {

                                string[] result1 = Msg[iCmdRet].Split('=');
                                if (result1.Length == 2)
                                {
                                    sRet = "0"; // 代表成功
                                    sMeasure = result1[1]; // 例：X1&Y1&A1
                                    bSW = true;

                                    string[] parts = sMeasure.Split('&');
                                    if (parts.Length == 3)
                                    {
                                        sX = parts[0];
                                        sY = parts[1];
                                        sAngle = parts[2];
                                    }
                                }
                                else
                                {
                                    sRet = "格式錯誤"; // 格式錯誤
                                    bSW = false;
                                }
                            }
                            else // 失敗
                            {
                                bSW = false;
                                sRet = Msg[iCmdRet]; // 錯誤訊息
                            }

                            // 回傳事件通知
                            if (GetCCDEventHandler != null)
                            {
                                CCDEventArgs arg = new CCDEventArgs();
                                arg.CmdName = RevComm;
                                arg.ActionRet = true;
                                arg.CmdRet = bSW;
                                arg.GrabRet = true;
                                arg.ReadValue = sRet;
                                arg.MeasureValue = sMeasure;

                                // 新增個別欄位：X、Y、Angle（選擇性）
                                arg.X = sX;
                                arg.Y = sY;
                                arg.Angle = sAngle;
                                GetCCDEventHandler(null, arg);
                            }
                        } break;


                    case sCCD.StartToInspectOnflyReadyCmd: // OnFly預備
                        {
                            bool bSW = false;
                            string sRet = "";
                            if (Msg[iCmdState] == "0")//0->Success, 1->Fail
                            {
                                bSW = true;
                                sRet = "0";
                                //sRet = Msg[iCmdRet];//這個命令欄為順序不同，須跟視覺確認
                                //沒有回傳Index
                            }
                            else
                            {
                                sRet = Msg[iCmdRet];
                            }

                            //FeedBack
                            if (GetCCDEventHandler != null)
                            {
                                CCDEventArgs arg = new CCDEventArgs();
                                arg.CmdName = RevComm;
                                arg.ActionRet = true;
                                arg.CmdRet = bSW;
                                arg.GrabRet = bSW;//無意義
                                arg.ReadValue = sRet;
                                GetCCDEventHandler(null, arg);
                            }
                        }
                        break;

                    case sCCD.GetToInspectOnflyResultCmd://
                        {
                            bool bSW = false;
                            string sRet = "";
                            string sX = "", sY = "", sAngle = "";

                            if (Msg.Length > 2)
                            {
                                if (Msg[iCmdState] == "0")  // 0 -> 成功
                                {
                                    string xValue = Msg[iCmdRet].Replace("Result", "").Replace("=", "").Trim();
                                    string yValue = Msg[iCmdRet + 1].Trim();
                                    string angleValue = Msg[iCmdRet + 2].Trim();
                                    if (!string.IsNullOrEmpty(xValue) && !string.IsNullOrEmpty(yValue) && !string.IsNullOrEmpty(angleValue))
                                    {
                                        sX = xValue;
                                        sY = yValue;
                                        sAngle = angleValue;
                                        sRet = "0";
                                        bSW = true;
                                    }

                                    else
                                    {
                                        sRet = "結果格式錯誤";
                                        bSW = false;
                                    }
                                }
                                else
                                {
                                    bSW = false;
                                    sRet = Msg[iCmdRet]; // 失敗訊息
                                }
                            }
                            else
                            {
                                sRet = "資料長度不足";
                                bSW = false;
                            }

                            if (GetCCDEventHandler != null)
                            {
                                CCDEventArgs arg = new CCDEventArgs();
                                arg.CmdName = RevComm;
                                arg.ActionRet = true;
                                arg.CmdRet = bSW;
                                arg.GrabRet = true;
                                arg.ReadValue = sRet;
                                arg.X = sX;
                                arg.Y = sY;
                                arg.Angle = sAngle;
                                GetCCDEventHandler(null, arg);
                            }
                        }
                        break;
                    case sCCD.GetInspectResultCmd:
                        {
                            bool bSW = false;
                            string sRet = "";
                            if (Msg[iCmdState] == "0")//0->Success, 1->Fail
                            {
                                bSW = true;
                                sRet = Msg[iCmdRet];//這個命令欄為順序不同，須跟視覺確認
                                //沒有回傳Index
                            }
                            else
                            {
                                sRet = Msg[iCmdRet];
                            }

                            //FeedBack
                            if (GetCCDEventHandler != null)
                            {
                                CCDEventArgs arg = new CCDEventArgs();
                                arg.CmdName = RevComm;
                                arg.ActionRet = true;
                                arg.CmdRet = bSW;
                                arg.GrabRet = bSW;//無意義
                                arg.ReadValue = sRet;
                                GetCCDEventHandler(null, arg);
                            }
                        }
                        break;                       
                        case sCCD.NozzleInspectCmd: //兩點定位
                        {
                            bool bSW = false;
                            string sRet = "";
                            string sMeasure = "";
                            string sX = "", sY = "", sAngle = "";
                            if (Msg[iCmdState] == "0")//0->Success, 1->Fail
                            {

                                string[] result1 = Msg[iCmdRet].Split('=');
                                if (result1.Length == 2)
                                {
                                    sRet = "0"; // 代表成功
                                    sMeasure = result1[1]; // 例：X1&Y1&A1
                                    bSW = true;

                                    string[] parts = sMeasure.Split('&');
                                    if (parts.Length == 3)
                                    {
                                        sX = parts[0];
                                        sY = parts[1];
                                        sAngle = parts[2];
                                    }
                                }
                                else
                                {
                                    sRet = "格式錯誤"; // 格式錯誤
                                    bSW = false;
                                }
                            }
                            else // 失敗
                            {
                                bSW = false;
                                sRet = Msg[iCmdRet]; // 錯誤訊息
                            }

                            // 回傳事件通知
                            if (GetCCDEventHandler != null)
                            {
                                CCDEventArgs arg = new CCDEventArgs();
                                arg.CmdName = RevComm;
                                arg.ActionRet = true;
                                arg.CmdRet = bSW;
                                arg.GrabRet = true;
                                arg.ReadValue = sRet;
                                arg.MeasureValue = sMeasure;

                                // 新增個別欄位：X、Y、Angle（選擇性）
                                arg.X = sX;
                                arg.Y = sY;
                                arg.Angle = sAngle;

                                GetCCDEventHandler(null, arg);
                            }
                        } 
                        break;
                    default:
                        break;
                }
            }
        }
        #endregion

        public void ReciveMsg(string[] msg)
        {
            if (_bIsSaveLog == true)
            {
                for (int i = 0; i < msg.Length; i++)
                {
                    log.AddMsg(string.Format("<-【{0}】{1}", NSetting.usPort, msg[i]));
                }
            }
        }

        public void ReciveMsg(string msg)
        {
            if (_bIsSaveLog == true)
            {
                log.AddMsg(string.Format("<-【{0}】{1}", NSetting.usPort, msg));
            }
        }

        private void SaveSendMsg(string msg)
        {
            if (_bIsSaveLog == true)
            {
                log.AddMsg(string.Format("->【{0}】{1}", NSetting.usPort, msg));
            }
        }

        #endregion Private Function

        #region Public Function 傳送命令

        //預留命令修改
        public bool SendVisionCmd(sCCD cmd, params string[] args)
        {
            if (_bIsSimulation == true)
            {
                //FeedBack
                if (GetCCDEventHandler != null)
                {
                    CCDEventArgs arg = new CCDEventArgs();
                    arg.CmdName = cmd;
                    arg.ActionRet = true;
                    arg.CmdRet = true;
                    arg.GrabRet = true;
                    arg.ReadValue = "";
                    GetCCDEventHandler(null, arg);
                }
                return true;
            }

            //if (CcdSocket.IsConnected == true ||false)
            //{
            switch (cmd)
            {
                case sCCD.AddNewJobCmd:
                    {
                        //由第一站操作
                        Send(new string[] { cmd.ToString(), args[0], args[1], args[2], args[3], args[4], args[5], args[6], args[7], args[8] });//Job Name
                    }
                    break;

                case sCCD.ChangeJobCmd:
                    {
                        //由第一站操作
                        Send(new string[] { cmd.ToString(), args[0], args[1], args[2], args[3], args[4] });//Job Name
                    }
                    break;

                case sCCD.StartToInspectCmd: //Mask
                    //case sCCD.GetInspectResultCmd:
                    {
                        int index = 0;
                        if (Int32.TryParse(args[0], out index) == true)
                        {

                            List<string> cmdList = new List<string>();
                            cmdList.Add(cmd.ToString());   // 加入指令名稱
                            cmdList.AddRange(args);        // 加入所有參數：如 ["11", "Mask=1"]
                            Send(cmdList.ToArray());       // 傳送完整命令                          
                        }
                        else
                        {
                            return false;
                        }
                    }
                    break;
                case sCCD.StartToInspectTray1Cmd://左Tray
                    {
                        int index = 0;
                        if (Int32.TryParse(args[0], out index) == true)
                        {

                            List<string> cmdList = new List<string>();
                            cmdList.Add(cmd.ToString());   // 加入指令名稱
                            cmdList.AddRange(args);        // 加入所有參數：如 ["11", "Mask=1"]
                            Send(cmdList.ToArray());       // 傳送完整命令                          
                        }
                        else
                        {
                            return false;
                        }
                    }
                    break;
                case sCCD.StartToInspectTray2Cmd://右Tray
                    {
                        int index = 0;
                        if (Int32.TryParse(args[0], out index) == true)
                        {

                            List<string> cmdList = new List<string>();
                            cmdList.Add(cmd.ToString());   // 加入指令名稱
                            cmdList.AddRange(args);        // 加入所有參數：如 ["11", "Mask=1"]
                            Send(cmdList.ToArray());       // 傳送完整命令                          
                        }
                        else
                        {
                            return false;
                        }
                    }
                    break;
                case sCCD.StartToInspectOnflyReadyCmd:
                    {

                        Send(new string[] { cmd.ToString(), args[0], args[1], args[2], args[3] });
                      
                    }
                    break;
                case sCCD.GetToInspectOnflyResultCmd:
                    {
                        Send(new string[] { cmd.ToString() });  

                    }
                    break;
                case sCCD.NozzleInspectCmd:
                    {
                        int index = 0;
                        if (Int32.TryParse(args[0], out index) == true)
                        {

                            List<string> cmdList = new List<string>();
                            cmdList.Add(cmd.ToString());   // 加入指令名稱
                            cmdList.AddRange(args);        // 加入所有參數：如 ["11", "Mask=1"]
                            Send(cmdList.ToArray());       // 傳送完整命令                          
                        }
                        else
                        {
                            return false;
                        }
                    }
                    break;
     
                default:
                    return false;
            }
            return true;
        }
        //else
        //{
        //    //CcdSocket = new ProVTool.ProVSECSEngine();
        //   // CcdSocket.Initialize("");
        //    CcdSocket.Connect();
        //       return false;

        //}
        public bool IsConnect()
        {
            switch (ProVConnectedMode)
            {
                case eProVConnectedMode.SECSEgnine:
                    {
                        return Ccd_SECSEgnine.IsConnected;
                    }
                    break;
                case eProVConnectedMode.SocketEx:
                    {
                        return Ccd_ClientSocket.IsConnected;
                    }
                    break;
            }
            return false;
        }

        public bool DisConnect()
        {
            switch (ProVConnectedMode)
            {
                case eProVConnectedMode.SECSEgnine:
                    {
                        Ccd_SECSEgnine.Disconnect();
                    }
                    break;
                case eProVConnectedMode.SocketEx:
                    {
                        Ccd_ClientSocket.Disconnect();
                    }
                    break;
            }
            return true;
        }
        public bool Connect()
        {
            try
            {
                IPAddress ADDRESS;

                if (IPAddress.TryParse(NSetting.sIP, out ADDRESS))
                {
                    switch (ProVConnectedMode)
                    {
                        case eProVConnectedMode.SECSEgnine:
                            {
                                Ccd_SECSEgnine.IP = NSetting.sIP;
                                Ccd_SECSEgnine.Port = NSetting.usPort;

                                if (Ccd_SECSEgnine.IsConnected == false)//檢查是否己連線
                                {
                                    Ccd_SECSEgnine.Initialize("");
                                    Ccd_SECSEgnine.Connect();
                                }
                            }
                            break;
                        case eProVConnectedMode.SocketEx:
                            {
                                Ccd_ClientSocket.IP = NSetting.sIP;
                                Ccd_ClientSocket.Port = NSetting.usPort;
                                int ActionConnect = Ccd_ClientSocket.Connect();

                                //return ContinueSocket.IsConnected;
                            }
                            break;
                        default:
                            return false;
                    }
                }
                else
                {
                    //MessageBox.Show("請設定正確的IP與Port!!!");
                    return false;
                }
            }
            catch (SocketException e)
            {
                //MessageBox.Show(e.Message);
                //throw;
            }
            return true;
        }
        #endregion Public Function
        #region Class
        //在建構式"訂閱事件"
        //CCD.GetCCDEventHandler += CtrlCCDEvent;

        //處理訂閱資料
        //bool XXX;
        //string SSS;
        //void CtrlCCDEvent(object sender, CCDEventArgs e)
        //{
        //    XXX = e.ActionRet; //用全域變數接收量測結果，量測前請重置
        //    SSS = e.ReadValue;  //用全域變數接收量測數值，量測前請重置
        //}

        public event EventHandler<CCDEventArgs> GetCCDEventHandler;

        public class CCDEventArgs : EventArgs
        {
            public CCDEventArgs()
            {
            }

            public sCCD CmdName//CCD回傳結果與送出指令應相同
            {
                get;
                set;
            }

            public bool GrabRet//回傳取像成功
            {
                get;
                set;
            }

            public bool ActionRet//回傳辨識狀態(是否己得到視覺軟體辨識結果)
            {
                get;
                set;
            }

            public bool CmdRet//回傳辨識結果(true : OK , false : NG)
            {
                get;
                set;
            }

            public string ReadValue//回傳辨識結果(string)
            {
                get;
                set;
            }

            public string X
            {
                get;
                set;
            }
            public string Y
            {
                get;
                set;
            }
            public string Angle
            {
                get;
                set;
            }
            private string _MeasureValue;
            public string MeasureValue
            {
                get { return _MeasureValue == null ? ":" : _MeasureValue; }
                set { _MeasureValue = value; }
            }

            private string _SettingValue;
            public string SettingValue//門檻值 Gary 0523
            {
                get { return _SettingValue == null ? ":" : _SettingValue; }
                set { _SettingValue = value; }
            }

            private string _ImagePath;
            public string ImagePath //Gary 0523
            {
                get { return _ImagePath == null ? "" : _ImagePath; }
                set { _ImagePath = value; }
            }
        }
        #endregion Class
        //End
    }
}
