using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Net;
using System.Net.Sockets;
using ProVSocketLib;
using System.ComponentModel;
using ProVLib;
using PaeLibGeneral;
using System.Windows.Forms;
using CommonObj;
using OCRControl;
using System.Drawing;
using System.IO;


namespace Cognex1741_InspectionPort
{
    public class OCRParser_Cognex1741_InspectionPort : OCRParser
    {
        private SynchronizationContext SyncContext = null;
        private StringBuilder sbRcv = new StringBuilder();
        private StringBuilder sbSnd = new StringBuilder();
        private MyTimer EexTimer = null;
        private String MutexName;
        private Thread Thread_Robot;
        private Unit m_Unit;

        private OCR_Status m_ResStatus = new OCR_Status();
        //儲存TCP/IP資訊
        private Queue<string> TCPRevQueue = new Queue<string>();

        private string UnitNo
        {
            get { return ((int)m_Unit).ToString(); }
        }

        private string m_RevBuffer = string.Empty;
        public string RevBuffer
        {
            get { return m_RevBuffer; }
            set { m_RevBuffer = value; }
        }

        public OCR_Command m_SendCmd = new OCR_Command();
        public OCR_Command SendCmd
        {
            get { return m_SendCmd; }
            set { m_SendCmd = value; }
        }

        public OCR_Command m_RevCmd = new OCR_Command();
        public OCR_Command RevCmd
        {
            get { return m_RevCmd; }
            set { m_RevCmd = value; }
        }

        public OCRParser_Cognex1741_InspectionPort(string Name, eConnectedMode Mode, Unit unit = Unit.OCR)
        {
            m_Unit = unit;
            #region 避免程式重覆執行
            MutexName = Name;
            SyncContext = SynchronizationContext.Current;

            switch (Mode)
            {
                case eConnectedMode.Ethernet:
                    {
                        ContinueSocket = new ProVClientSocketEx();
                        ContinueSocket.OnConnect += ClientScoket_OnConnect;
                        ContinueSocket.OnDisconnect += ClientScoket_OnDisconnect;
                        ContinueSocket.OnError += ClientScoket_OnError;
                        ContinueSocket.OnRead += ClientScoket_OnRead;
                    }
                    break;

                case eConnectedMode.RS232:
                    {
                        serialPort = new System.IO.Ports.SerialPort();
                        serialPort.DataReceived += ClientSerial_OnRead;
                    }
                    break;
            }

            EexTimer = new MyTimer();
            //執行序建立
            Thread_Robot = new Thread(RobotProcess);
            Thread_Robot.IsBackground = true;
            Thread_Robot.Start();

            Boolean bCreatedNew;
            //Create a new mutex using specific mutex name
            Mutex m = new Mutex(false, MutexName, out bCreatedNew);
            if (!bCreatedNew)
            {
                String strMsg = String.Format("Client has been run with Name: {0}!!", MutexName);
                MessageBox.Show(strMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
            #endregion

        public override void ClientScoket_OnConnect(ConnectionEventArgs sender)
        {
            if (delOnConnect != null)
            {
                delOnConnect();
            }
        }

        public override void ClientScoket_OnDisconnect(ConnectionEventArgs sender)
        {
            if (delOnDisconnect != null)
            {
                delOnDisconnect();
            }
            //throw new NotImplementedException();
        }

        public override void ClientScoket_OnError(ExceptionEventArgs sender)
        {
            //throw new NotImplementedException();
        }

        public override void ClientScoket_OnRead(MessageEventArgs MsgArgs)
        {
            sbRcv.Append(MsgArgs.Text);
            String strRcv = sbRcv.ToString();
            if ((strRcv != String.Empty) && (strRcv.IndexOf('\r') > 0))
            {
                RevBuffer = strRcv;//暫存指令
                TCPRevQueue.Enqueue(strRcv);

                SaveMsg(" <- " + strRcv);

                sbRcv.Clear();
            }
        }

        public override void ClientSerial_OnRead(object sender, System.IO.Ports.SerialDataReceivedEventArgs MsgArgs)
        {

        }

        private void RobotProcess(object Sender)
        {
            //m_Sender = Sender;
            while (true)
            {
                Cycle();
                Thread.Sleep(10);
            }
        }
        private void Cycle()
        {
            switch (CommandStep)
            {
                case Step.Init:
                    CommandStep = Step.Connect;
                    break;
                case Step.Connect:
                    CurSTATE = STATE.IDLE;
                    CommandStep = Step.IDLE;
                    break;
                case Step.SendMessage:
                    if (CommnadTransferOperation(SendCmd))
                    {
                        //ResetRobotStatus();//清除之前接收Robot狀態資訊
                        EexTimer.Restart();
                        CommandStep = Step.WaitResponseMessage;
                    }
                    break;
                case Step.WaitResponseMessage:
                    if (TCPRevQueue.Count > 0)
                    {
                        RevBuffer = TCPRevQueue.Dequeue();
                        ResponseMessage(RevBuffer);
                        EexTimer.Restart();
                        CommandStep = Step.CommunicationCompleted;
                    }
                    else if (EexTimer.On(30000))//等待30秒逾時處理
                    {
                        m_ResStatus.ErrorCode = "TIMEOUT";
                        CommandStep = Step.Error;
                    }
                    break;

                case Step.CommunicationCompleted:
                    TCPRevQueue.Clear();
                    CurSTATE = STATE.IDLE;
                    CommandStep = Step.IDLE;
                    break;
                case Step.Error:
                    CurSTATE = STATE.ERRHAPPEN;
                    CommandStep = Step.IDLE;
                    break;
                case Step.IDLE:
                    break;
                default:
                    break;
            }
        }

        public bool CommnadTransferOperation(OCR_Command Cmd)
        {
            if (ContinueSocket.IsConnected == false)//未連線
            {
                return false;
            }
            string Text = string.Empty;
            string command = string.Empty;

            switch (Cmd.Command)
            {
                case CommDef.READ_CONFIG:
                    command = "READ(" + Cmd.Parameters[0] + ")";
                    Text = command + "\r\n";
                    break;
                case CommDef.READ:
                    command = "READ";
                    Text = command + "\r\n"; ;
                    break;
                case CommDef.TUNE:
                    command = "TUNE(" + Cmd.Parameters[0] + ")";
                    Text = command + "\r\n"; ;
                    break;
                default:
                    break;
            }

            SendCommandToRobot(Text);

            return true;
        }

        public bool ResponseMessage(string ResMsg)
        {
            string temp = ResMsg.Trim('\n', '\r');
            string[] sCommand = temp.Split(',');
            int DataLength = sCommand.Length;
            string sOCR_Result = "";

            String sReadOcrResult = sCommand[0];

            if (m_SendCmd.Command == CommDef.READ || m_SendCmd.Command == CommDef.READ_CONFIG)
            {
                if (sReadOcrResult.Contains("*") || sReadOcrResult.Contains("?"))
                {
                    sOCR_Result = "N";
                }
                else
                {
                    if (DataLength == 1)
                    {
                        if (PValue.OCR_UseChecksum == true)//v1.0.0.18
                        {
                            if (CommonFunction.WaferChecksumIsOK(sReadOcrResult))
                            {
                                sOCR_Result = "Y";
                            }
                            else
                            {
                                sOCR_Result = "N";
                            }
                        }
                        else //v1.0.0.18
                        {
                            sOCR_Result = "Y";
                        }
                    }
                    else
                    {
                        String sCheckSumResult = sCommand[1];
                        String sPassOrNg = sCommand[2];

                        if (Convert.ToDouble(sPassOrNg) >= 1)
                        {
                            sOCR_Result = "Y";
                        }
                        else
                        {
                            sOCR_Result = "N";

                        }
                    }

                }

                m_RevCmd.RevDAT = sOCR_Result + "," + sReadOcrResult;
                OCR_Read_Result = m_RevCmd.RevDAT;
                ShowReadImage();
            }
            //string[] datalist = RevData.Split(new char[] { ':' }, StringSplitOptions.RemoveEmptyEntries);
            //DispatchMessage(datalist);
            return true;
        }

        public override string CheckSum(string message)
        {
            return message;
        }

        public override CommandParameter[] GetCmdParameterSetting(string Cmd)
        {
            List<CommandParameter> listCmdParas = new List<CommandParameter>();
            string[] para;
            CommDef eCmd;
            if (Enum.TryParse(Cmd, out eCmd))
            {
                switch (eCmd)
                {
                    case CommDef.READ_CONFIG:
                        listCmdParas.Add(new CommandParameter("Config", -1, 50));
                        break;
                    case CommDef.READ:
                        break;
                    case CommDef.TUNE:
                        listCmdParas.Add(new CommandParameter("Config", 1, 50));
                        break;
                    default:
                        break;
                }
            }
            return listCmdParas.ToArray();
        }

        public override string GetCommandDescribe(string Cmd)
        {
            CommDef eCmd;
            string msg = "";
            if (Enum.TryParse(Cmd, out eCmd))
            {
                msg = GetEnumDescription(eCmd);
            }
            return msg;
        }

        public override string GetErrorCode()
        {
            return m_ResStatus.ErrorCode;
        }

        public override object GetStatus()
        {
            return m_ResStatus;
        }

        public override object GetReceiveData()
        {
            return RevCmd;
        }

        public override void SendCommandToRobot(string Msg)
        {
            if (_bIsSimulation)
            {
                return;
            }

            SaveMsg(" -> " + Msg);

            switch (ConnectedMode)
            {
                case eConnectedMode.Ethernet:
                    {
                        byte[] data = Encoding.ASCII.GetBytes(Msg);

                        //Send
                        if (ContinueSocket.SocketConnection != null && ContinueSocket.IsConnected == true)
                        {
                            //byte sEnd = 0x0D;

                            //Array.Resize(ref data, data.Length + 1);

                            //data[data.Length - 1] = sEnd;

                            ContinueSocket.SocketConnection.Send(Msg);
                        }
                    }
                    break;

                case eConnectedMode.RS232:
                    {
                        serialPort.WriteLine(Msg);
                    }
                    break;
            }
        }

        public override bool SetCommand(object RobotCmd)
        {
            if (_bIsSimulation)
            {
                return true;
            }

            m_SendCmd = RobotCmd as OCR_Command;
            if (m_SendCmd != null)
            {
                if (isIDLE())
                {
                    //WaitSocketRecive = false;//清除已接收旗標
                    TCPRevQueue.Clear();//清除接收柱列
                    CommandStep = Step.SendMessage;//動作狀態ID
                    CurSTATE = STATE.ACTION;
                    return true;
                }
            }
            return false;
        }

        public override bool SetCommnad(string Cmd, string Station, params string[] parameters)
        {
            CommDef eCmd;
            DefStation eStation;
            if (Enum.TryParse(Cmd, out eCmd) && Enum.TryParse(Station, out eStation))
            {
                try
                {
                    m_SendCmd.Command = eCmd;
                    if (eStation == DefStation.None)
                    {
                        m_SendCmd.Parameters = new string[parameters.Length];
                        m_SendCmd.Parameters = parameters;
                    }
                    else
                    {
                        m_SendCmd.Parameters = new string[parameters.Length + 1];
                        m_SendCmd.Parameters[0] = ((int)eStation).ToString();
                        for (int i = 1; i < parameters.Length; i++)
                        {
                            m_SendCmd.Parameters[i] = parameters[i - 1];
                        }
                    }
                }
                catch
                {
                    return false;
                }

                if (isIDLE())
                {
                    //WaitSocketRecive = false;//清除已接收旗標
                    TCPRevQueue.Clear();//清除接收柱列
                    CommandStep = Step.SendMessage;//動作狀態ID
                    CurSTATE = STATE.ACTION;
                    return true;
                }
            }
            return false;
        }

        public override string[] GetCommandList()
        {
            List<string> listName = new List<string>();
            listName.AddRange(Enum.GetNames(typeof(CommDef)));
            string[] enumNames = listName.ToArray();
            return enumNames;
        }

        public override Image GetImage()
        {
            Image image = null;
            Image image_ret = null;
            string Date = DateTime.Now.ToString("yyyyMMdd");
            string Time = DateTime.Now.ToString("yyyyMMdd_HHmmss");
            FtpData FD = new FtpData();
            FD.ftpUrl = "ftp://172.16.0.1/image.bmp";
            FD.localPath = SaveImagePath + @Date + @"\";
            FD.localFileName = Time + ".bmp";
            FD.ftpUsername = "admin";
            FD.ftpPassword = "";

            string FilePath = FD.localPath + FD.localFileName;

            try
            {
                FTP OCRData = new FTP(FD);
                bool b1 = OCRData.GetData();
                if (b1)
                {
                    image = Image.FromFile(FilePath).Clone() as Image;
                    image_ret = image.Clone() as Image;
                    image = null;
                    image.Dispose();
                }
            }
            catch
            {
            }

            //try
            //{

            //    if(File.Exists(FilePath))
            //    {

            //    }
            //}
            return image_ret;
        }
    }
}
