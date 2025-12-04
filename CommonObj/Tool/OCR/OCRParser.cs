using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Net;
using System.Net.Sockets;
using ProVSocketLib;
using PaeLibGeneral;
using System.ComponentModel;
using System.IO.Ports;
using System.Drawing;

namespace OCRControl
{
    public abstract class OCRParser
    {
        public delegate void DelSaveMsg(string msg);
        public DelSaveMsg delSaveMsg;

        public delegate void DelOnConnect();
        public DelOnConnect delOnConnect;

        public delegate void DelOnDisconnect();
        public DelOnDisconnect delOnDisconnect;

        public delegate void DelShowReadImage(Image image);
        public DelShowReadImage delShowReadImage;

        public delegate void DelShowErrorCode(string Msg);
        public DelShowErrorCode delShowErrorCode;

        protected ProVClientSocketEx ContinueSocket = null;
        public SerialPort serialPort = null;
        protected NetWorkSetting NSetting;

        public bool _bIsSimulation;
        public string _SattionName = "OCR";

        protected int iTask = 0;
        protected int iRecvTask = 0;

        public bool bUseCheckSum;
        public bool bSendACKAfterAction;

        public eConnectedMode ConnectedMode;
        public string SaveImagePath = @"D:\OCR\IMAGE\";
        public string OCR_Read_Result;
        public bool bSaveImage = false;

        private STATE m_State = STATE.IDLE;	//目前的狀態
        public STATE CurSTATE
        {
            get { return m_State; }
            set { m_State = value; }
        }

        private Step m_Command;
        public Step CommandStep
        {
            get { return m_Command; }
            set { m_Command = value; }
        }

        public bool IsConnect()
        {
            if (ContinueSocket == null)
            {
                return false;
            }
            return ContinueSocket.IsConnected;
        }

        public bool SetIPnPort(string IP, ushort PORT)
        {
            string ip = IP.Trim();//刪除前後空白字元

            IPAddress ADDRESS;

            if (IPAddress.TryParse(ip, out ADDRESS))
            {
                NSetting.sIP = ip;
                NSetting.usPort = PORT;
                NSetting.SetFinish = true;
                return true;
            }
            NSetting.SetFinish = false;
            return false;
        }

        public bool SetComPort(string Port, string Baudrate, string DataBits, string strStopBits, string strParity)
        {
            if (serialPort != null)
            {
                try
                {
                    int iBaudRate = Convert.ToInt32(Baudrate);
                    int iDataBit = Convert.ToInt32(DataBits);
                    serialPort.PortName = Port;
                    serialPort.BaudRate = iBaudRate;
                    serialPort.DataBits = iDataBit;

                    switch (strStopBits)
                    {
                        case "1":
                            serialPort.StopBits = StopBits.One;
                            break;

                        case "1.5":
                            serialPort.StopBits = StopBits.OnePointFive;
                            break;

                        case "2":
                            serialPort.StopBits = StopBits.Two;
                            break;

                        default:
                            SaveMsg("Error：停止位參數不正確!");
                            return false;
                    }

                    switch (strParity)
                    {
                        case "None": //None
                            serialPort.Parity = Parity.None;
                            break;
                        case "Odd"://Odd
                            serialPort.Parity = Parity.Odd;
                            break;
                        case "Even"://Even
                            serialPort.Parity = Parity.Even;
                            break;
                        default:
                            SaveMsg("Error：校驗位參數不正確!");
                            return false;
                    }
                    serialPort.NewLine = "\r";
                    serialPort.RtsEnable = true;
                    return true;
                }
                catch (Exception ex)
                {
                    SaveMsg("Error:" + ex.Message);
                    return false;
                }
            }

            SaveMsg("尚未初始化");
            return false;
        }

        public bool Connect()
        {
            try
            {
                if (_bIsSimulation == true)
                {
                    return true;
                }

                switch (ConnectedMode)
                {
                    case eConnectedMode.Ethernet:
                        {
                            IPAddress ADDRESS;

                            if (NSetting.SetFinish == true || IPAddress.TryParse(NSetting.sIP, out ADDRESS))
                            {
                                ContinueSocket.IP = NSetting.sIP;
                                ContinueSocket.Port = NSetting.usPort;// 1900;
                                int ActionConnect = ContinueSocket.Connect();

                                return ContinueSocket.IsConnected;
                            }
                            else
                            {
                                SaveMsg(string.Format("IP Error"));
                                return false;
                            }
                        }
                    //break;

                    case eConnectedMode.RS232:
                        {
                            try
                            {
                                serialPort.Open();
                                if (delOnConnect != null)
                                {
                                    delOnConnect();
                                }
                                return true;
                            }
                            catch (Exception e)
                            {
                                SaveMsg(string.Format(e.Message));
                            }
                        }
                        break;
                }
                return false;
            }
            catch (SocketException e)
            {
                SaveMsg(string.Format("{0},{1},{2}", _SattionName, e.Message, e.Source, e.StackTrace));
                return false;
                //throw;
            }
        }

        public bool DisConnect()
        {
            switch (ConnectedMode)
            {
                case eConnectedMode.Ethernet:
                    {
                        if (ContinueSocket.IsConnected == false)
                        {
                            string _logmsg = "Disconnect Success!";

                            SaveMsg(_logmsg);

                            return false;
                        }

                        ContinueSocket.Disconnect();
                        //ContinueSocket.OnRead -= ClientScoket_OnRead;
                        return true;
                    }
                //break;

                case eConnectedMode.RS232:
                    {
                        string _logmsg = "Disconnect Success!";
                        SaveMsg(_logmsg);
                        serialPort.Close();
                        return true;
                    }
                //break;
            }
            return false;
        }

        public void SaveMsg(string msg)
        {
            if (delSaveMsg != null)
            {
                delSaveMsg(msg);
            }
        }

        public void ShowErrorCode(string code)
        {
            if (delShowErrorCode != null)
            {
                delShowErrorCode(code);
            }
        }

        public void ShowReadImage()
        {
            if (delShowReadImage != null)
            {
                delShowReadImage(GetImage());
            }
        }
        public string GetEnumDescription(Enum value)
        {
            var field = value.GetType().GetField(value.ToString());

            if (field != null)
            {
                var attribue = (DescriptionAttribute)Attribute.GetCustomAttribute(field, typeof(DescriptionAttribute));

                if (attribue != null)
                {
                    return attribue.Description;
                }
            }
            return value.ToString();
        }

        //動作IDLE中
        public bool isIDLE()
        {
            return (CurSTATE == STATE.IDLE);
        }
        //動作發生錯誤中
        public bool ErrorHappen()
        {
            return (CurSTATE == STATE.ERRHAPPEN);
        }
        //重置執行狀態
        public void ResetCommand()
        {
            CurSTATE = STATE.IDLE;
            CommandStep = Step.IDLE;
        }

        public abstract void ClientScoket_OnConnect(ConnectionEventArgs sender);
        public abstract void ClientScoket_OnDisconnect(ConnectionEventArgs sender);
        public abstract void ClientScoket_OnError(ExceptionEventArgs sender);
        public abstract void SendCommandToRobot(string Msg);

        public abstract void ClientScoket_OnRead(ProVSocketLib.MessageEventArgs MsgArgs);
        public abstract void ClientSerial_OnRead(object sender, SerialDataReceivedEventArgs MsgArgs);
        public abstract bool SetCommnad(string Cmd, string Station, params string[] praameters);
        public abstract bool SetCommand(object RobotCmd);
        public abstract string[] GetCommandList();
        public abstract string GetCommandDescribe(string Cmd);
        public abstract CommandParameter[] GetCmdParameterSetting(string Cmd);
        public abstract string CheckSum(string message);
        public abstract string GetErrorCode();
        public abstract object GetStatus();
        public abstract object GetReceiveData();
        public abstract Image GetImage();
    }

    public class CommandParameter
    {
        public string sParameter_Name = "";
        public long MaxValue = 0;
        public long MinValue = 0;
        public string sTextBoxValue = "";

        public string[] Parameter;
        public CommandParameterType PType = CommandParameterType.NumericUpDown;


        public CommandParameter(string Name, long Min, long Max)
        {
            sParameter_Name = Name;
            MinValue = Min;
            MaxValue = Max;
            PType = CommandParameterType.NumericUpDown;
        }

        public CommandParameter(string Name, string[] Data)
        {
            sParameter_Name = Name;
            Parameter = Data;
            PType = CommandParameterType.ComboBox;
        }

        public CommandParameter(string Name, string textBoxValue = "")
        {
            sParameter_Name = Name;
            sTextBoxValue = textBoxValue;
            PType = CommandParameterType.TextBox;
        }
    }

    public enum RobotType
    {
        None = 0,
        Tazmo,
        Yaskawa_SR100,
        Dyhen,
    }

    public struct NetWorkSetting
    {
        public double DTareValue;
        public int iAverageCount;
        public bool SetFinish;
        public string sIP;
        public ushort usPort;
        public ushort usPortContinue;
    }

    //定義機台物件之狀態
    public enum STATE : int
    {
        INIT,			//初始中
        IDLE,			//動作完成，閒置中
        CHANGESTATE,    //狀態轉換
        ACTION,			//m_Step		動作中
        ERRHAPPEN,		//錯誤引發中
    }

    public enum Step : int
    {
        Init = 0,
        Connect,
        SendMessage,
        WaitResponseMessage,
        WaitControlEndOfExe,
        HostSendEndOfExe,
        CommunicationCompleted,
        Error,
        IDLE,
    }

    public enum Unit : int
    {
        Robot1 = 1,
        Aligner1 = 2,
        OCR,
    }

    public enum eConnectedMode
    {
        Ethernet,
        RS232,
    }

    public enum CommandParameterType
    {
        None,
        NumericUpDown,
        ComboBox,
        TextBox,
    }
}
