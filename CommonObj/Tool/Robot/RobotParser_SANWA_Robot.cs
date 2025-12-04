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

namespace SANWA_Robot
{
    public class RobotParser_SANWA_Robot : RobotParser
    {
        private SynchronizationContext SyncContext = null;
        private StringBuilder sbRcv = new StringBuilder();
        private StringBuilder sbSnd = new StringBuilder();
        private MyTimer EexTimer = null;
        private String MutexName;
        private Thread Thread_Robot;
        private Unit m_Unit;

        private SANWA_RobotStatus m_ResStatus = new SANWA_RobotStatus();
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

        public RobotCommand m_SendCmd = new RobotCommand();
        public RobotCommand SendCmd
        {
            get { return m_SendCmd; }
            set { m_SendCmd = value; }
        }

        public RobotCommand m_RevCmd = new RobotCommand();
        public RobotCommand RevCmd
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

        public RobotParser_SANWA_Robot(string Name, eConnectedMode Mode, Unit unit = Unit.Robot1)
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

        public override void ClientSerial_OnRead(object sender, System.IO.Ports.SerialDataReceivedEventArgs MsgArgs)
        {

        }

        public override string[] GetCommandList()
        {
            List<string> listName = new List<string>();
            listName.AddRange(Enum.GetNames(typeof(CommDef)));
            listName.Remove(CommDef.GET_BRDIO.ToString());
            listName.Remove(CommDef.GET_E84.ToString());
            listName.Remove(CommDef.GET_MAPRD.ToString());
            listName.Remove(CommDef.GET_MITFR.ToString());
            listName.Remove(CommDef.GET_NMEIO.ToString());
            listName.Remove(CommDef.GET_PARAM.ToString());
            listName.Remove(CommDef.GET_PARSY.ToString());
            listName.Remove(CommDef.GET_PDATA.ToString());
            listName.Remove(CommDef.GET_PNSTS.ToString());
            listName.Remove(CommDef.GET_POS.ToString());
            listName.Remove(CommDef.GET_RBPOS.ToString());
            listName.Remove(CommDef.GET_RIO.ToString());
            listName.Remove(CommDef.GET_RIOMC.ToString());
            listName.Remove(CommDef.GET_TAGDT.ToString());
            listName.Remove(CommDef.GET_TAGID.ToString());
            listName.Remove(CommDef.GET_TEACH.ToString());
            listName.Remove(CommDef.GET_VER.ToString());
            listName.Remove(CommDef.GET_TIME.ToString());
            listName.Remove(CommDef.SET_BATCL.ToString());
            listName.Remove(CommDef.SET_BRDIO.ToString());
            listName.Remove(CommDef.SET_STOP.ToString());
            //listName.Remove(CommDef.SET_CONT.ToString());
            listName.Remove(CommDef.SET_ENCCL.ToString());
            listName.Remove(CommDef.SET_ENCOF.ToString());
            listName.Remove(CommDef.SET_LOADP.ToString());
            //listName.Remove(CommDef.SET_LOGSV.ToString());
            listName.Remove(CommDef.SET_MITFR.ToString());
            listName.Remove(CommDef.SET_NMEIO.ToString());
            listName.Remove(CommDef.SET_PARAM.ToString());
            //listName.Remove(CommDef.SET_PAUSE.ToString());
            listName.Remove(CommDef.SET_PDATA.ToString());
            listName.Remove(CommDef.SET_RIO.ToString());
            listName.Remove(CommDef.SET_SAVE.ToString());
            listName.Remove(CommDef.SET_SAVEP.ToString());
            listName.Remove(CommDef.SET_STPDO.ToString());
            listName.Remove(CommDef.SET_TAGDT.ToString());
            listName.Remove(CommDef.SET_TAGID.ToString());
            listName.Remove(CommDef.SET_TEACH.ToString());
            listName.Remove(CommDef.SET_TGEVT.ToString());
            //listName.Remove(CommDef.SET_TIME.ToString());
            listName.Remove(CommDef.CMD_ALX.ToString());
            listName.Remove(CommDef.CMD_CARRY.ToString());
            listName.Remove(CommDef.CMD_FOKCB.ToString());
            listName.Remove(CommDef.CMD_PUSH.ToString());
            listName.Remove(CommDef.CMD_FORK.ToString());
            listName.Remove(CommDef.CMD_MOVED.ToString());
            listName.Remove(CommDef.CMD_MOVEM.ToString());
            listName.Remove(CommDef.CMD_MOVEP.ToString());
            listName.Remove(CommDef.CMD_MULSE.ToString());
            //listName.Remove(CommDef.CMD_PUTST.ToString());
            listName.Remove(CommDef.CMD_RHOME.ToString());
            listName.Remove(CommDef.CMD_EORG.ToString());
            //listName.Remove(CommDef.CMD_RET.ToString());
            listName.Remove(CommDef.CMD_SHOME.ToString());
            listName.Remove(CommDef.CMD_FLIP.ToString());
            listName.Remove(CommDef.ACK.ToString());

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

            #region MyRegion
            //if (Enum.TryParse(Cmd, out eCmd))
            //{
            //    switch (eCmd)
            //    {
            //        case CommDef.GET_ERR:
            //            CmdParas[0].SetParameter("no", 0, 64, true);
            //            break;
            //        case CommDef.GET_MAP:
            //        case CommDef.GET_MAPT:
            //            CmdParas[0].SetParameter("no", 1, 3, true);
            //            break;
            //        //GET
            //        case CommDef.GET_MODE:
            //        case CommDef.GET_SP:
            //        case CommDef.GET_STS:
            //        //SET
            //        case CommDef.SET_RESET:
            //        case CommDef.SET_CONT:
            //        case CommDef.SET_PAUSE:
            //        case CommDef.SET_TIME:
            //        //CMD
            //        case CommDef.CMD_HOME:
            //        case CommDef.CMD_ORG:
            //        case CommDef.CMD_RHOME:
            //        case CommDef.CMD_RET:
            //            break;
            //        case CommDef.GET_SV:
            //            CmdParas[0].SetParameter("no", 1, 10, true);
            //            break;
            //        case CommDef.SET_MODE:
            //            CmdParas[0].SetParameter("v1", 0, 3, true);
            //            break;
            //        case CommDef.SET_SERVO:
            //            CmdParas[0].SetParameter("sv(0:OFF 1: ON)", 0, 1, true);
            //            break;
            //        case CommDef.SET_SP:
            //            CmdParas[0].SetParameter("v1", 0, 99, true);
            //            break;
            //        case CommDef.SET_SV:
            //            CmdParas[0].SetParameter("no", 1, 10, true);
            //            CmdParas[1].SetParameter("v1", 0, 1, true);
            //            break;
            //        case CommDef.SET_STOP:
            //            CmdParas[0].SetParameter("m1", 0, 1, true);
            //            break;
            //        case CommDef.CMD_EORG:
            //            CmdParas[0].SetParameter("axis", 1, 16, true);
            //            break;
            //        case CommDef.CMD_GET:
            //            CmdParas[0].SetParameter("slot", 1, 25, true);
            //            CmdParas[1].SetParameter("arm", 1, 3, true);
            //            CmdParas[2].SetParameter("al", 0, 1, true);
            //            CmdParas[3].SetParameter("opt", 0, 4, true);
            //            break;
            //        case CommDef.CMD_PUT:
            //            CmdParas[0].SetParameter("slot", 1, 25, true);
            //            CmdParas[1].SetParameter("arm", 1, 3, true);
            //            CmdParas[2].SetParameter("opt", 0, 4, true);
            //            break;
            //        case CommDef.CMD_GETST:
            //        case CommDef.CMD_PUTST:
            //            CmdParas[0].SetParameter("slot", 1, 25, true);
            //            CmdParas[1].SetParameter("arm", 1, 2, true);
            //            CmdParas[2].SetParameter("step(1~6)", 0, 6, true);
            //            break;
            //        case CommDef.CMD_GETW:
            //        case CommDef.CMD_PUTW:
            //            CmdParas[0].SetParameter("slot", 1, 25, true);
            //            CmdParas[1].SetParameter("arm", 1, 2, true);
            //            break;
            //        case CommDef.CMD_MAP:
            //            CmdParas[0].SetParameter("col", 1, 25, true);
            //            CmdParas[1].SetParameter("slot", 0, 25, true);
            //            break;
            //        case CommDef.CMD_MOVDP:
            //            CmdParas[0].SetParameter("no", 1, 1111111111111111, true);
            //            CmdParas[1].SetParameter("speed", 0, 99, true);
            //            break;
            //        case CommDef.CMD_WHLD:
            //        case CommDef.CMD_WRLS:
            //            CmdParas[0].SetParameter("arm", 1, 2, true);
            //            break;
            //        default:
            //            break;
            //    }
            //}
            #endregion
            if (Enum.TryParse(Cmd, out eCmd))
            {
                switch (eCmd)
                {
                    case CommDef.GET_ERR:
                        CmdParas[0].SetParameter("履歷號碼", 0, 64, true);
                        break;
                    case CommDef.GET_MAP:
                    case CommDef.GET_MAPT:
                        CmdParas[0].SetParameter("結果排序(下往上/上往下/整合)", 1, 3, true);
                        break;
                    //GET
                    case CommDef.GET_MODE:
                    case CommDef.GET_SP:
                    case CommDef.GET_STS:
                    //SET
                    case CommDef.SET_RESET:
                    case CommDef.SET_CONT:
                    case CommDef.SET_PAUSE:
                    case CommDef.SET_TIME:
                    //CMD
                    case CommDef.CMD_HOME:
                    case CommDef.CMD_ORG:
                    case CommDef.CMD_RHOME:
                    case CommDef.CMD_RET:
                        break;
                    case CommDef.GET_SV:
                        CmdParas[0].SetParameter("電磁閥號碼", 1, 10, true);
                        break;
                    case CommDef.SET_MODE:
                        CmdParas[0].SetParameter("模式(正常/空跑/測試/單動)", 0, 3, true);
                        break;
                    case CommDef.SET_SERVO:
                        CmdParas[0].SetParameter("激磁(OFF/ON)", 0, 1, true);
                        break;
                    case CommDef.SET_SP:
                        CmdParas[0].SetParameter("速度(%)", 0, 99, true);
                        break;
                    case CommDef.SET_SV:
                        CmdParas[0].SetParameter("電磁閥號碼", 1, 10, true);
                        CmdParas[1].SetParameter("狀態(OFF/ON)", 0, 1, true);
                        break;
                    case CommDef.SET_STOP:
                        CmdParas[0].SetParameter("(減速停止/加速停止)", 0, 1, true);
                        break;
                    case CommDef.CMD_EORG:
                        CmdParas[0].SetParameter("軸編號", 1, 16, true);
                        break;
                    case CommDef.CMD_GET:
                        CmdParas[0].SetParameter("層數", 1, 25, true);
                        CmdParas[1].SetParameter("R手臂/L手臂/R+L手臂", 1, 3, true);
                        CmdParas[2].SetParameter("Align(無/有)", 0, 1, true);
                        CmdParas[3].SetParameter("停止點(1/2/續做)", 0, 3, true);//Clamp型不支援第四種
                        break;
                    case CommDef.CMD_PUT:
                        CmdParas[0].SetParameter("層數", 1, 25, true);
                        CmdParas[1].SetParameter("R手臂/L手臂/R+L手臂", 1, 3, true);
                        CmdParas[2].SetParameter("停止點(1/2/續動)", 0, 3, true);//Clamp型不支援第四種
                        break;
                    case CommDef.CMD_GETST:
                    case CommDef.CMD_PUTST:
                        CmdParas[0].SetParameter("層數", 1, 25, true);
                        CmdParas[1].SetParameter("R手臂/L手臂/R+L手臂", 1, 2, true);
                        CmdParas[2].SetParameter("單動點(1~6)", 0, 6, true);
                        break;
                    case CommDef.CMD_GETW:
                    case CommDef.CMD_PUTW:
                        CmdParas[0].SetParameter("層數", 1, 25, true);
                        CmdParas[1].SetParameter("R手臂/L手臂", 1, 2, true);
                        break;
                    case CommDef.CMD_MAP:
                        CmdParas[0].SetParameter("固定1(無意義)", 1, 1, true);//用不到
                        CmdParas[1].SetParameter("開始掃描層數(0~25)", 0, 25, true);
                        break;
                    case CommDef.CMD_MOVDP:
                        CmdParas[0].SetParameter("啟用軸(R3/X2/Z2/T2/L2/R2/X1/Z1/T1/L1/R1/X/Z/T/L/R)", 1, 1111111111111111, true);
                        CmdParas[1].SetParameter("速度(%)", 0, 99, true);
                        break;
                    case CommDef.CMD_WHLD:
                    case CommDef.CMD_WRLS:
                        CmdParas[0].SetParameter("R手臂/L手臂", 1, 2, true);
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
                    case CommDef.CMD_GET:
                    case CommDef.CMD_PUT:
                    case CommDef.CMD_GETW:
                    case CommDef.CMD_PUTW:
                    case CommDef.CMD_GETST:
                    case CommDef.CMD_PUTST:
                    case CommDef.CMD_MAP:
                    case CommDef.CMD_MOVDP:
                        {
                            return true;
                        }
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

        public override bool SetCommand(object RobotCmd)
        {
            m_SendCmd = RobotCmd as RobotCommand;
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


        public override string sGetCommnad(string Cmd, string Station, params string[] parameters)
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
                    return "";
                }                
            }
            return sCombinCommand(m_SendCmd);
        }


        private string sCombinCommand(RobotCommand Cmd)
        {
            string Text = string.Empty;
            string command = string.Empty;

            switch (Cmd.Command)
            {
                case CommDef.GET_MODE:
                case CommDef.GET_SP:
                case CommDef.GET_STS:
                case CommDef.SET_RESET:
                case CommDef.CMD_HOME:
                case CommDef.CMD_ORG:
                case CommDef.CMD_RHOME:
                case CommDef.ACK:
                case CommDef.SET_PAUSE:
                case CommDef.SET_CONT:
                case CommDef.CMD_RET:
                case CommDef.SET_LOGSV:
                    {
                        command = UnitNo + Cmd.GetCommandType + ":" + Cmd.GetCommandName;
                        Text = "$" + command + CheckSum(command);
                    }
                    break;

                case CommDef.GET_ERR:
                case CommDef.GET_MAP:
                case CommDef.GET_MAPT:
                case CommDef.GET_SV:
                case CommDef.SET_MODE:
                case CommDef.SET_SP:
                case CommDef.SET_SERVO:
                case CommDef.SET_STOP:
                case CommDef.CMD_EORG:
                case CommDef.CMD_WHLD:
                case CommDef.CMD_WRLS:
                    {
                        command = UnitNo + Cmd.GetCommandType + ":" + Cmd.GetCommandName + ":" + Cmd.Parameter_1;
                        Text = "$" + command + CheckSum(command);
                    }
                    break;

                case CommDef.SET_SV:
                    {
                        command = UnitNo + Cmd.GetCommandType + ":" + Cmd.GetCommandName + ":" + Cmd.Parameter_1 + "," + Cmd.Parameter_2;
                        Text = "$" + command + CheckSum(command);
                    }
                    break;

                case CommDef.CMD_GETW:
                case CommDef.CMD_PUTW:
                case CommDef.CMD_MAP:
                case CommDef.CMD_MOVDP:
                    {
                        command = UnitNo + Cmd.GetCommandType + ":" + Cmd.GetCommandName + ":" + Cmd.Parameter_1 + "," + Cmd.Parameter_2 + "," + Cmd.Parameter_3;
                        Text = "$" + command + CheckSum(command);
                    }
                    break;

                case CommDef.CMD_GETST:
                case CommDef.CMD_PUTST:
                case CommDef.CMD_PUT:
                    {
                        command = UnitNo + Cmd.GetCommandType + ":" + Cmd.GetCommandName + ":" + Cmd.Parameter_1 + "," + Cmd.Parameter_2 + "," + Cmd.Parameter_3 + "," + Cmd.Parameter_4;
                        Text = "$" + command + CheckSum(command);
                    }
                    break;

                case CommDef.CMD_GET:
                    {
                        command = UnitNo + Cmd.GetCommandType + ":" + Cmd.GetCommandName + ":" + Cmd.Parameter_1 + "," + Cmd.Parameter_2 + "," + Cmd.Parameter_3 + "," + Cmd.Parameter_4 + "," + Cmd.Parameter_5;
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
            return Text;
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

        public bool CommnadTransferOperation(RobotCommand Cmd)
        {
            if (ContinueSocket.IsConnected == false)//未連線
            {
                return false;
            }
            string Text = string.Empty;
            string command = string.Empty;
            
            switch (Cmd.Command)
            {
                case CommDef.GET_MODE:
                case CommDef.GET_SP:
                case CommDef.GET_STS:
                case CommDef.SET_RESET:
                case CommDef.CMD_HOME:
                case CommDef.CMD_ORG:
                case CommDef.CMD_RHOME:
                case CommDef.ACK:
                case CommDef.SET_PAUSE:
                case CommDef.SET_CONT:
                case CommDef.CMD_RET:
                case CommDef.SET_LOGSV:
                    {
                        command = UnitNo + Cmd.GetCommandType + ":" + Cmd.GetCommandName;
                        Text = "$" + command + CheckSum(command);
                    }
                    break;

                case CommDef.GET_ERR:
                case CommDef.GET_MAP:
                case CommDef.GET_MAPT:
                case CommDef.GET_SV:
                case CommDef.SET_MODE:
                case CommDef.SET_SP:
                case CommDef.SET_SERVO:
                case CommDef.SET_STOP:
                case CommDef.CMD_EORG:
                case CommDef.CMD_WHLD:
                case CommDef.CMD_WRLS:
                    {
                        command = UnitNo + Cmd.GetCommandType + ":" + Cmd.GetCommandName + ":" + Cmd.Parameter_1;
                        Text = "$" + command + CheckSum(command);
                    }
                    break;
                    
                case CommDef.SET_SV:
                    {
                        command = UnitNo + Cmd.GetCommandType + ":" + Cmd.GetCommandName + ":" + Cmd.Parameter_1 + "," + Cmd.Parameter_2;
                        Text = "$" + command + CheckSum(command);
                    }
                    break;

                case CommDef.CMD_GETW:
                case CommDef.CMD_PUTW:
                case CommDef.CMD_MAP:
                case CommDef.CMD_MOVDP:
                    {
                        command = UnitNo + Cmd.GetCommandType + ":" + Cmd.GetCommandName + ":" + Cmd.Parameter_1 + "," + Cmd.Parameter_2 + "," + Cmd.Parameter_3;
                        Text = "$" + command + CheckSum(command);
                    }
                    break;

                case CommDef.CMD_GETST:
                case CommDef.CMD_PUTST:
                case CommDef.CMD_PUT:
                    {
                        command = UnitNo + Cmd.GetCommandType + ":" + Cmd.GetCommandName + ":" + Cmd.Parameter_1 + "," + Cmd.Parameter_2 + "," + Cmd.Parameter_3 + "," + Cmd.Parameter_4;
                        Text = "$" + command + CheckSum(command);
                    }
                    break;

                case CommDef.CMD_GET:
                    {
                        command = UnitNo + Cmd.GetCommandType + ":" + Cmd.GetCommandName + ":" + Cmd.Parameter_1 + "," + Cmd.Parameter_2 + "," + Cmd.Parameter_3 + "," + Cmd.Parameter_4 + "," + Cmd.Parameter_5;
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
                //case CommDef.CMD_MAP:
                //    {

                //    }
                //    break;

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
                                case "MAP__":
                                    {
                                        m_RevCmd.mp = m_RevCmd.RevDAT;
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
                    m_ResStatus.iIsError = integers[2];
                    m_ResStatus.iReserve_1 = integers[3];
                    m_ResStatus.iAction = integers[4];
                    m_ResStatus.iPause = integers[5];
                    m_ResStatus.iResetRequest = integers[6];
                    m_ResStatus.iStepAction = integers[7];
                    m_ResStatus.iManunal = integers[8];
                    m_ResStatus.iServoOn = integers[9];
                    m_ResStatus.iFanError = integers[10];
                    m_ResStatus.iEncoderPower = integers[11];
                    m_ResStatus.iArmInterferenceArea = integers[12];
                    m_ResStatus.iSolenoidAction = integers[13];
                    m_ResStatus.iORG_Search = integers[14];
                    m_ResStatus.iReserve_2 = integers[15];
                    m_ResStatus.iBlade_R_ORG = integers[16];
                    m_ResStatus.iBlade_R_HasProduct = integers[17];
                    m_ResStatus.iBlade_R_Vaccum = integers[18];
                    m_ResStatus.iBlade_R_END_EF_1 = integers[19];
                    m_ResStatus.iBlade_R_END_EF_2 = integers[20];
                    m_ResStatus.iBlade_R_END_EF_3 = integers[21];
                    m_ResStatus.iBlade_R_END_EF_4 = integers[22];
                    m_ResStatus.iBlade_R_SHOCK = integers[23];
                    m_ResStatus.iBlade_L_ORG = integers[24];
                    m_ResStatus.iBlade_L_HasProduct = integers[25];
                    m_ResStatus.iBlade_L_Vaccum = integers[26];
                    m_ResStatus.iBlade_L_END_EF_1 = integers[27];
                    m_ResStatus.iBlade_L_END_EF_2 = integers[28];
                    m_ResStatus.iBlade_L_END_EF_3 = integers[29];
                    m_ResStatus.iBlade_L_END_EF_4 = integers[30];
                    m_ResStatus.iBlade_L_SHOCK = integers[31];

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
