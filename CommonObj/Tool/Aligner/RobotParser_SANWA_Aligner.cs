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
using RobotControl;
using System.IO.Ports;

namespace SANWA_Aligner
{
    public class RobotParser_SANWA_Aligner : RobotParser
    {
        private SynchronizationContext SyncContext = null;
        private StringBuilder sbRcv = new StringBuilder();
        private StringBuilder sbSnd = new StringBuilder();
        private MyTimer EexTimer = null;
        private String MutexName;
        private Thread Thread_Aligner;
        private Unit m_Unit;

        private SANWA_AlignerStatus m_ResStatus = new SANWA_AlignerStatus();
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

        public AlignerCommand m_SendCmd = new AlignerCommand();
        public AlignerCommand SendCmd
        {
            get { return m_SendCmd; }
            set { m_SendCmd = value; }
        }

        public AlignerCommand m_RevCmd = new AlignerCommand();
        public AlignerCommand RevCmd
        {
            get { return m_RevCmd; }
            set { m_RevCmd = value; }
        }

        private ResCommand m_ResCmd;
        public ResCommand ResCmd
        {
            get { return m_ResCmd; }
            set { m_ResCmd = value; }
        }

        public RobotParser_SANWA_Aligner(string Name, eConnectedMode Mode, Unit unit = Unit.Aligner1)
        {
            m_Unit = Unit.Robot1;
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
            Thread_Aligner = new Thread(AlignerProcess);
            Thread_Aligner.IsBackground = true;
            Thread_Aligner.Start();

            Boolean bCreatedNew;
            //Create a new mutex using specific mutex name
            Mutex m = new Mutex(false, MutexName, out bCreatedNew);
            if (!bCreatedNew)
            {
                String strMsg = String.Format("Client has been run with Name: {0}!!", MutexName);
                MessageBox.Show(strMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            #endregion
        }

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

        public override void ClientSerial_OnRead(object sender, SerialDataReceivedEventArgs MsgArgs)
        {
            if ((sender as SerialPort).BytesToRead > 0)
            {
                int n = serialPort.BytesToRead;                         //先記錄下來，避免某種原因，人為的原因，操作幾次之間時間長，快取不一致  
                byte[] buf = new byte[n];                               //宣告一個臨時陣列儲存當前來的串列埠資料  
                serialPort.Read(buf, 0, n);                             //讀取緩衝資料  
                sbRcv.Append(Encoding.ASCII.GetString(buf));
                String strRcv = sbRcv.ToString();

                RevBuffer = strRcv;//暫存指令
                TCPRevQueue.Enqueue(strRcv);

                SaveMsg(" <- " + strRcv);

                sbRcv.Clear();
            }
        }

        public override string[] GetCommandList()
        {
            List<string> listName = new List<string>();
            listName.AddRange(Enum.GetNames(typeof(CommDef)));
            listName.Remove(CommDef.GET_PARAM.ToString());
            listName.Remove(CommDef.GET_PARSY.ToString());
            listName.Remove(CommDef.GET_POS.ToString());
            listName.Remove(CommDef.GET_RIO.ToString());
            listName.Remove(CommDef.GET_VER.ToString());
            //listName.Remove(CommDef.SET_LOGSV.ToString());
            listName.Remove(CommDef.SET_RIO.ToString());
            listName.Remove(CommDef.SET_SAVE.ToString());
            listName.Remove(CommDef.SET_STOP.ToString());
            //listName.Remove(CommDef.SET_TIME.ToString());
            listName.Remove(CommDef.CMD_MOVED.ToString());
            listName.Remove(CommDef.ACK.ToString());
            //listName.Remove(CommDef.GET_WFTYP.ToString());
            //listName.Remove(CommDef.SET_WFTYP.ToString());
            listName.Remove(CommDef.GET_RCP.ToString());
            listName.Remove(CommDef.SET_RCP.ToString());
            listName.Remove(CommDef.SET_PARAM.ToString());
            listName.Remove(CommDef.GET_ACPOS.ToString());
            listName.Remove(CommDef.SET_ACPOS.ToString());
            //listName.Remove(CommDef.SET_WTYPE.ToString());

            string[] enumNames = listName.ToArray();
            return enumNames;
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

        public override string[] GetStationList()
        {
            List<string> listName = new List<string>();
            listName.AddRange(Enum.GetNames(typeof(DefStation)));
            listName.Remove(DefStation.None.ToString());

            string[] enumNames = listName.ToArray();
            return enumNames;
        }

        public override CommandParameter[] GetCmdParameterSetting(string Cmd)
        {
            CommandParameter[] CmdParas = new CommandParameter[5];
            for (int i = 0; i < CmdParas.Length; i++)
            {
                CmdParas[i] = new CommandParameter();
            }
            CommDef eCmd;
            if (Enum.TryParse(Cmd, out eCmd))
            {
                switch (eCmd)
                {
                    case CommDef.GET_ERR:
                        CmdParas[0].SetParameter("錯誤序號", 0, 64, true);
                        break;
                    //GET
                    case CommDef.GET_SP:
                    case CommDef.GET_STS:
                    //SET
                    case CommDef.SET_RESET:
                    //CMD
                    case CommDef.CMD_HOME:
                    case CommDef.CMD_ORG:
                    case CommDef.SET_TIME:
                    case CommDef.GET_WTYPE:
                    case CommDef.GET_WFTYP:
                        break;
                    case CommDef.SET_SERVO:
                        CmdParas[0].SetParameter("sv", 0, 1, true);
                        break;
                    case CommDef.SET_SP:
                        CmdParas[0].SetParameter("v1", 0, 99, true);
                        break;
                    case CommDef.SET_STOP:
                        CmdParas[0].SetParameter("m1", 0, 1, true);
                        break;
                    case CommDef.GET_ALIGN:
                        CmdParas[0].SetParameter("v1", 1, 2, true);
                        break;
                    case CommDef.CMD_ALIGN:
                        CmdParas[0].SetParameter("angle", 0, 359999, true);
                        CmdParas[1].SetParameter("type", 0, 2, true);
                        CmdParas[2].SetParameter("zaxis", 0, 0, true);
                        CmdParas[3].SetParameter("mode", 0, 1, true);
                        break;
                    case CommDef.SET_WTYPE:
                        CmdParas[0].SetParameter("Size", 2, 12, true);
                        CmdParas[1].SetParameter("type", 0, 6, true);
                        break;
                    case CommDef.SET_WFTYP:
                        CmdParas[0].SetParameter("Size", 25, 750, true);
                        CmdParas[1].SetParameter("type", 0, 6, true);
                        break;
                    case CommDef.CMD_WHLD:
                    case CommDef.CMD_WRLS:
                        CmdParas[0].SetParameter("NA", 1, 1, true);
                        break;
                    default:
                        break;
                }
            }
            return CmdParas;
        }

        public override bool GetCmdParameterIsNeedStationList(string Cmd)
        {
            CommDef eCmd;
            if (Enum.TryParse(Cmd, out eCmd))
            {
                switch (eCmd)
                {
                    default:
                        break;
                }
            }
            return false;
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
                            byte sEnd = 0x0D;

                            Array.Resize(ref data, data.Length + 1);

                            data[data.Length - 1] = sEnd;

                            ContinueSocket.SocketConnection.Send(data);
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

        public override bool SetCommand(object AlignerCmd)
        {
            m_SendCmd = AlignerCmd as AlignerCommand;
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
                        m_SendCmd.Parameter_1 = parameters[0];
                        m_SendCmd.Parameter_2 = parameters[1];
                        m_SendCmd.Parameter_3 = parameters[2];
                        m_SendCmd.Parameter_4 = parameters[3];
                        m_SendCmd.Parameter_5 = parameters[4];
                    }
                    else
                    {
                        m_SendCmd.Parameter_1 = ((int)eStation).ToString();
                        m_SendCmd.Parameter_2 = parameters[0];
                        m_SendCmd.Parameter_3 = parameters[1];
                        m_SendCmd.Parameter_4 = parameters[2];
                        m_SendCmd.Parameter_5 = parameters[3];
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

        public override string sGetCommnad(string Cmd, string Station, params string[] parameters)
        {
            CommDef eCmd;
            DefStation eStation;
            return "";//TODO
        }


        private void AlignerProcess(object Sender)
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
                        //ResetAlignerStatus();//清除之前接收Aligner狀態資訊
                        EexTimer.Restart();
                        CommandStep = Step.WaitResponseMessage;
                    }
                    break;
                case Step.WaitResponseMessage:
                    if (TCPRevQueue.Count > 0)
                    {
                        RevBuffer = TCPRevQueue.Dequeue();
                        ResponseMessage(RevBuffer);
                        switch (ResCmd)
                        {
                            case ResCommand.ACKN_MSG:
                                {
                                    if (m_SendCmd.GetCommandType == "CMD")
                                    {
                                        EexTimer.Restart();
                                        CommandStep = Step.WaitControlEndOfExe;
                                    }
                                    else
                                    {
                                        EexTimer.Restart();
                                        CommandStep = Step.CommunicationCompleted;
                                    }
                                }
                                break;
                            case ResCommand.EVNT_MSG:
                                break;
                            case ResCommand.FORMAT_ERR:
                                m_ResStatus.ErrorCode = "FORMAT ERR";
                                CommandStep = Step.Error;
                                break;
                            //case ResCommand.FIN_MSG:
                            //    break;
                            case ResCommand.NAK_MSG:
                                m_ResStatus.ErrorCode = m_RevCmd.RSLT;
                                CommandStep = Step.Error;
                                break;
                            default:
                                m_ResStatus.ErrorCode = "ResCmd ERR";
                                CommandStep = Step.Error;
                                break;
                        }
                    }
                    else if (EexTimer.On(60000))//等待30秒逾時處理
                    {
                        m_ResStatus.ErrorCode = "TIMEOUT";
                        CommandStep = Step.Error;
                    }
                    break;
                case Step.WaitControlEndOfExe:
                    if (TCPRevQueue.Count > 0)
                    {
                        RevBuffer = TCPRevQueue.Dequeue();
                        ResponseMessage(RevBuffer);
                        switch (ResCmd)
                        {
                            //case ResCommand.ACKN_MSG:
                            //    break;
                            case ResCommand.EVNT_MSG:
                                break;
                            case ResCommand.FORMAT_ERR:
                                m_ResStatus.ErrorCode = "FORMAT_ERR";
                                CommandStep = Step.Error;
                                break;
                            case ResCommand.FIN_MSG:
                                m_ResStatus.ErrorCode = m_RevCmd.RSLT;
                                if (bSendACKAfterAction)
                                {
                                    CommandStep = Step.HostSendEndOfExe;
                                }
                                else
                                {
                                    if (m_RevCmd.RSLT != "00000000")
                                    {
                                        CommandStep = Step.Error;
                                        return;
                                    }
                                    CommandStep = Step.CommunicationCompleted;
                                }
                                break;
                            case ResCommand.NAK_MSG:
                                m_ResStatus.ErrorCode = m_RevCmd.RSLT;
                                CommandStep = Step.Error;
                                break;
                            default:
                                m_ResStatus.ErrorCode = "ResCmd ERR";
                                CommandStep = Step.Error;
                                break;
                        }
                    }
                    else if (EexTimer.On(30000))//等待30秒逾時處理
                    {
                        m_ResStatus.ErrorCode = "TIMEOUT";
                        CommandStep = Step.Error;
                    }
                    break;

                case Step.HostSendEndOfExe:
                    {
                        string Text = string.Empty;
                        string command = string.Empty;
                        command = UnitNo + "ACK" + ":" + m_RevCmd.RevCMD;
                        Text = "$" + command + CheckSum(command);
                        SendCommandToRobot(Text);
                        if (m_RevCmd.RSLT != "00000000")
                        {
                            CommandStep = Step.Error;
                        }
                        else
                        {
                            CommandStep = Step.CommunicationCompleted;
                        }
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

        public bool CommnadTransferOperation(AlignerCommand Cmd)
        {
            if (ContinueSocket.IsConnected == false)//未連線
            {
                return false;
            }
            string Text = string.Empty;
            string command = string.Empty;

            switch (Cmd.Command)
            {
                case CommDef.GET_SP:
                case CommDef.GET_STS:
                case CommDef.SET_RESET:
                case CommDef.CMD_HOME:
                case CommDef.CMD_ORG:
                case CommDef.SET_LOGSV:
                case CommDef.GET_WFTYP:
                case CommDef.GET_WTYPE:
                case CommDef.ACK:
                    {
                        command = UnitNo + Cmd.GetCommandType + ":" + Cmd.GetCommandName;
                        Text = "$" + command + CheckSum(command);
                    }
                    break;

                case CommDef.GET_ERR:
                case CommDef.SET_SP:
                case CommDef.SET_SERVO:
                case CommDef.SET_STOP:
                case CommDef.CMD_WHLD:
                case CommDef.CMD_WRLS:
                case CommDef.GET_ALIGN:
                    {
                        command = UnitNo + Cmd.GetCommandType + ":" + Cmd.GetCommandName + ":" + Cmd.Parameter_1;
                        Text = "$" + command + CheckSum(command);
                    }
                    break;
                case CommDef.SET_WFTYP:
                case CommDef.SET_WTYPE:
                    {
                        command = UnitNo + Cmd.GetCommandType + ":" + Cmd.GetCommandName + ":" + Cmd.Parameter_1 + "," + Cmd.Parameter_2;
                        Text = "$" + command + CheckSum(command);
                    }
                    break;
                case CommDef.CMD_ALIGN:
                    {
                        command = UnitNo + Cmd.GetCommandType + ":" + Cmd.GetCommandName + ":" + Cmd.Parameter_1 + "," + Cmd.Parameter_2 + "," + Cmd.Parameter_3 + "," + Cmd.Parameter_4;
                        Text = "$" + command + CheckSum(command);
                    }
                    break;
                case CommDef.SET_TIME:
                    {
                        DateTime currentTime = DateTime.Now;
                        string formattedTime = currentTime.ToString("yyyy:MM:dd:HH:mm:ss");
                        command = UnitNo + Cmd.GetCommandType + ":" + Cmd.GetCommandName + ":" + formattedTime;
                        Text = "$" + command + CheckSum(command);
                    }
                    break;
            }
            SendCommandToRobot(Text);

            return true;
        }

        public bool ResponseMessage(string ResMsg)
        {
            int LastCRChar = ResMsg.IndexOf('\r');
            if (LastCRChar == -1)
                return false;
            string RevData = ResMsg.Substring(0, LastCRChar);
            string[] datalist = RevData.Split(new char[] { ':' }, StringSplitOptions.RemoveEmptyEntries);
            ResCmd = DispatchMessage(datalist);
            switch (ResCmd)
            {
                case ResCommand.ACKN_MSG:
                    break;
                case ResCommand.EVNT_MSG:
                    break;
                case ResCommand.FORMAT_ERR:
                    break;
                case ResCommand.FIN_MSG:
                    break;
                case ResCommand.NAK_MSG:
                    break;
                default:
                    break;
            }
            return true;
        }

        public ResCommand DispatchMessage(string[] Msg)
        {
            string sRes = Msg[0].Substring(2, 3);
            try
            {
                switch (sRes)
                {
                    case "ACK":
                        m_RevCmd.RevADR = Msg[0].Substring(1, 1);
                        m_RevCmd.RevFLG = sRes;
                        m_RevCmd.RevCMD = Msg[1];
                        if (Msg.Length > 2)
                        {
                            if (bUseCheckSum)
                            {
                                m_RevCmd.RevDAT = Msg[2].Substring(0, Msg[2].Length - 2);
                                m_RevCmd.RevCheckSum = Msg[2].Substring(Msg[2].Length - 2, 2);
                            }
                            else
                            {
                                m_RevCmd.RevDAT = Msg[2];
                                m_RevCmd.RevCheckSum = "";
                            }

                            switch (m_RevCmd.RevCMD)
                            {
                                case "STS__":
                                    {
                                        if (CheckResSts(m_RevCmd.RevDAT) == false)
                                            return ResCommand.FORMAT_ERR;
                                    }
                                    break;
                                default:
                                    break;
                            }
                        }
                        else
                        {
                            if (bUseCheckSum)
                            {
                                m_RevCmd.RevDAT = "";
                                m_RevCmd.RevCheckSum = Msg[1].Substring(Msg[1].Length - 2, 2);
                            }
                            else
                            {
                                m_RevCmd.RevDAT = "";
                                m_RevCmd.RevCheckSum = "";
                            }
                        }
                        return ResCommand.ACKN_MSG;

                    case "FIN":
                        m_RevCmd.RevADR = Msg[0].Substring(1, 1);
                        m_RevCmd.RevFLG = sRes;
                        m_RevCmd.RevCMD = Msg[1];
                        if (bUseCheckSum)
                        {
                            m_RevCmd.RSLT = Msg[2].Substring(0, Msg[2].Length - 2);
                            m_RevCmd.RevCheckSum = Msg[2].Substring(Msg[2].Length - 2, 2);
                        }
                        else
                        {
                            m_RevCmd.RSLT = Msg[2];
                            m_RevCmd.RevCheckSum = "";
                        }
                        return ResCommand.FIN_MSG;

                    case "NAK":
                        m_RevCmd.RevADR = Msg[0].Substring(1, 1);
                        m_RevCmd.RevFLG = sRes;
                        m_RevCmd.RevCMD = Msg[1];
                        if (bUseCheckSum)
                        {
                            m_RevCmd.RSLT = Msg[2].Substring(0, Msg[2].Length - 2);
                            m_RevCmd.RevCheckSum = Msg[2].Substring(Msg[2].Length - 2, 2);
                        }
                        else
                        {
                            m_RevCmd.RSLT = Msg[2];
                            m_RevCmd.RevCheckSum = "";
                        }
                        return ResCommand.NAK_MSG;

                    case "EVT":
                        m_RevCmd.RevADR = Msg[0].Substring(1, 1);
                        m_RevCmd.RevFLG = sRes;
                        m_RevCmd.RevCMD = Msg[1];
                        string[] result = Msg[2].Split(',');
                        m_RevCmd.RSLT = result[0];
                        if (result.Length >= 2)
                        {
                            if (bUseCheckSum)
                            {
                                m_RevCmd.Error_msg = result[1].Substring(0, result[1].Length - 2);
                                m_RevCmd.RevCheckSum = result[1].Substring(result[1].Length - 2, 2);
                            }
                            else
                            {
                                m_RevCmd.Error_msg = result[1];
                                m_RevCmd.RevCheckSum = "";
                            }
                        }
                        else
                        {
                            if (bUseCheckSum)
                            {
                                m_RevCmd.RevCheckSum = result[0].Substring(result[0].Length - 2, 2);
                            }
                            else
                            {
                                m_RevCmd.RevCheckSum = "";
                            }
                        }
                        return ResCommand.EVNT_MSG;
                }
                return ResCommand.FORMAT_ERR;
            }
            catch
            {
                return ResCommand.FORMAT_ERR;
            }
        }
        private bool CheckResSts(string status)
        {
            if (status != string.Empty)
            {
                List<int> integers = new List<int>();

                for (int i = 0; i < status.Length; i++)
                {
                    int num = 0;
                    string str = status[i].ToString();
                    if (int.TryParse(str, out num))
                    {
                        integers.Add(num);
                    }
                    else
                    {
                        return false;
                    }
                }

                if (integers.Count() == 32)
                {
                    m_ResStatus.iStarting = integers[0];
                    m_ResStatus.iControlMode = integers[1];
                    m_ResStatus.iReserve_1 = integers[2];
                    m_ResStatus.iReserve_2 = integers[3];
                    m_ResStatus.iAction = integers[4];
                    m_ResStatus.iPause = integers[5];
                    m_ResStatus.iIsError = integers[6];
                    m_ResStatus.iStepAction = integers[7];
                    m_ResStatus.iManunal = integers[8];
                    m_ResStatus.iServoOn = integers[9];
                    m_ResStatus.iFanError = integers[10];
                    m_ResStatus.iReserve_3 = integers[11];
                    m_ResStatus.iReserve_4 = integers[12];
                    m_ResStatus.iSolenoidAction = integers[13];
                    m_ResStatus.iORG_Search = integers[14];
                    m_ResStatus.iReserve_5 = integers[15];
                    m_ResStatus.iAxis_X_Home = integers[16];
                    m_ResStatus.iAxis_X_HasProduct = integers[17];
                    m_ResStatus.iAxis_X_Vaccum = integers[18];
                    m_ResStatus.iWafer_Size_TensDigit = integers[19];
                    m_ResStatus.iWafer_Size_UnitsDigit = integers[20];
                    m_ResStatus.iReserve_6 = integers[21];
                    m_ResStatus.iReserve_7 = integers[22];
                    m_ResStatus.iReserve_8 = integers[23];
                    m_ResStatus.iAxis_Y_Home = integers[24];
                    m_ResStatus.iReserve_9 = integers[25];
                    m_ResStatus.iReserve_10 = integers[26];
                    m_ResStatus.iReserve_11 = integers[27];
                    m_ResStatus.iReserve_12 = integers[28];
                    m_ResStatus.iReserve_13 = integers[29];
                    m_ResStatus.iReserve_14 = integers[30];
                    m_ResStatus.iReserve_15 = integers[31];

                    return true;
                }
            }
            return false;
        }

        public override string CheckSum(string message)
        {
            string checksum = string.Empty;
            if (bUseCheckSum)
            {
                char[] chars = message.ToCharArray();
                int sum = 0;
                for (int i = 0; i < chars.Length; i++)
                {
                    sum += (int)chars[i];
                }
                //checksum = (~checksum & 0xFF) + 0x01 ;
                checksum = String.Format("{0:X}", sum);
                checksum.PadLeft(2, '0');
                checksum = checksum.Substring(checksum.Length - 2, 2);
            }
            else
            {
                checksum = "";
            }
            return checksum;// Convert.ToString(checksum, 16).ToUpper();
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
    }
}
