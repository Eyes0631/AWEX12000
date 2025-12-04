using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using ProVSocketLib;
using PaeLibGeneral;
using CommonObj;

namespace RobotControl
{
    [ToolboxItem(true)]
    public partial class RobotControl : UserControl
    {
        public RobotControl()
        {
            InitializeComponent();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            Para_Ctrl = new Parameter_Control[5]
            {
                new Parameter_Control{ tbx_ParameterName=tbx_parameter_1, nu_ParameterName=nu_parameter_1},
                new Parameter_Control{ tbx_ParameterName=tbx_parameter_2, nu_ParameterName=nu_parameter_2},
                new Parameter_Control{ tbx_ParameterName=tbx_parameter_3, nu_ParameterName=nu_parameter_3},
                new Parameter_Control{ tbx_ParameterName=tbx_parameter_4, nu_ParameterName=nu_parameter_4},
                new Parameter_Control{ tbx_ParameterName=tbx_parameter_5, nu_ParameterName=nu_parameter_5},
            };
        }

        public delegate void DelShowMsg(string Msg);
        public delegate void DelSetConnectedMode(eConnectedMode mode);
        public delegate bool DelIsSafeToAction();
        public DelIsSafeToAction delIsSafeToAction;

        private ProVSocketLib.TAsyncMsgFlusher log;
        private RobotParser robotParser = null;
        private Parameter_Control[] Para_Ctrl;
        public delegate bool SafeToAction();
        private bool m_IsConnect = false;
        // 使用 TypeConverter 屬性來指定選單選擇器
        private eConnectedMode _ConnectedMode = eConnectedMode.Ethernet;
        [TypeConverter(typeof(EnumDropDownConverter))]
        public eConnectedMode ConnectedMode
        {
            get { return _ConnectedMode; }
            set
            {
                _ConnectedMode = value;
                SetConnentedMode(_ConnectedMode);
            }
        }


        private bool _UseCheckSum = false;
        public bool UseCheckSum
        {
            get { return _UseCheckSum; }
            set { _UseCheckSum = value; }
        }

        private bool _SendACKAfterAction = false;
        public bool SendACKAfterAction
        {
            get { return _SendACKAfterAction; }
            set { _SendACKAfterAction = value; }
        }

        private string _StationName = "RobotController";
        public string StationName
        {
            get { return _StationName; }
            set
            {
                _StationName = value;
                ShowStationName(_StationName);
            }
        }

        private bool _bIsSimulation = false;
        [Browsable(false)]
        public bool IsSimulation
        {
            get { return _bIsSimulation; }
            set
            {
                _bIsSimulation = value;
                if (robotParser != null)
                {
                    robotParser._bIsSimulation = _bIsSimulation;
                }
            }
        }

        private bool _bIsSaveLog = true;
        [Browsable(false)]
        public bool IsSaveLog
        {
            get { return _bIsSaveLog; }
            set { _bIsSaveLog = value; }
        }

        private bool _bSafeToAction = true;


        private bool _bManualTest = false;
        [Browsable(false)]
        public bool IsManualTest
        {
            get { return _bManualTest; }
            set { _bManualTest = value; }
        }

        [Category("安全保護")]
        [Description("安全保護")]
        [Browsable(true)] // 確保屬性在屬性視窗中可見
        public delegate bool IsSafeToActionEventHandler(string station);
        public event IsSafeToActionEventHandler IsSafeToAction;

        protected bool OnIsSafeToAction(string station)
        {
            if (IsSafeToAction != null)
            {
                return IsSafeToAction(station);
            }
            return false; // 預設返回值
        }

        //public bool IsSafeToAction(string station)
        //{
        //    if (delIsSafeToAction != null)
        //    {
        //        return delIsSafeToAction();
        //    }
        //    return _bSafeToAction;
        //}

        public void Initial(RobotParser RP)
        {
            if (RP == null)
                return;

            robotParser = RP;
            robotParser._SattionName = _StationName;
            robotParser.ConnectedMode = _ConnectedMode;
            log = new TAsyncMsgFlusher(500, @"D:\Log\", _StationName, listBox1, 0, "log", "");
            robotParser.delSaveMsg += SaveMsg;
            robotParser.delOnConnect += ClientScoket_OnConnect;
            robotParser.delOnDisconnect += ClientScoket_OnDisconnect;
            robotParser.delShowErrorCode += ShowErrorCode;
            robotParser.bUseCheckSum = UseCheckSum;
            robotParser.bSendACKAfterAction = SendACKAfterAction;
            robotParser.delUpdateStatusLED += delUpdateStatusLED;


            lst_Command.Items.Clear();
            lst_Command.Items.AddRange(robotParser.GetCommandList());
            lst_Station.Items.Clear();
            lst_Station.Items.AddRange(robotParser.GetStationList());
        }

        public bool SetIPnPort(string IP, ushort PORT)
        {
            if (robotParser == null)
            {
                return false;
            }

            bool b1 = robotParser.SetIPnPort(IP, PORT);
            if (b1 == true)
            {
                HostSetting(IP, PORT.ToString());
            }
            return b1;
        }

        public bool SetComPort(string Port, string Baudrate, string DataBits, string StopBits, string Parity)
        {
            if (robotParser == null)
            {
                return false;
            }

            bool b1 = robotParser.SetComPort(Port, Baudrate, DataBits, StopBits, Parity);
            if (b1 == true)
            {
                HostSetting(Port, Baudrate, DataBits, StopBits, Parity);
            }
            return b1;
        }

        public bool SetCommand(object RobotCmd)
        {
            if (robotParser == null)
            {
                return false;
            }

            if (_bSafeToAction == false)
            {
                return false;
            }

            return robotParser.SetCommand(RobotCmd);
        }

        public bool IsConnect()
        {
            if (robotParser == null)
            {
                return false;
            }
            return m_IsConnect;
            //return robotParser.IsConnect();
        }

        public void SetReSize()
        {
            float newx = this.Width / X;
            float newy = this.Height / Y;
            SetControls(newx, newy, this);
        }
        //請在模組解構時 Diconnet
        public bool DisConnect()
        {
            if (robotParser == null)
            {
                return false;
            }

            return robotParser.DisConnect();
        }

        public bool Connect()
        {
            if (robotParser == null)
            {
                return false;
            }

            bool b1 = robotParser.Connect();
            if (b1 == false)
            {
                //robotParser.SaveMsg("Connect Fail");
            }
            return b1;
        }

        public bool IsIDLE()
        {
            return robotParser.isIDLE();
        }

        public bool ErrorHappened()
        {
            return robotParser.ErrorHappened();
        }

        public string GetErrorCode()
        {
            return robotParser.GetErrorCode();
        }

        public object GetStatus()
        {
            return robotParser.GetStatus();
        }

        public void AlarmReset()
        {
            if (robotParser != null)
            {
                robotParser.ResetCommand();
                this.Invoke((MethodInvoker)delegate //PD2
                {
                    tbx_ErrorCode.Text = "";
                });
            }
        }
        #region private

        private void ClientScoket_OnConnect()
        {
            m_IsConnect = true;

            string logmsg = "-> " + "Connect Success!";

            ledGreen.Value = KCSDK.ThreeColorLight.ColorLightType.GreenLight;

            SaveMsg(logmsg);
        }

        private void ClientScoket_OnDisconnect()
        {
            m_IsConnect = false;

            string logmsg = "-> " + "Disconnect Success!";

            ledGreen.Value = KCSDK.ThreeColorLight.ColorLightType.GrayLight;

            SaveMsg(logmsg);
        }

        private void ShowErrorCode(string Msg)
        {
            tbx_ErrorCode.Text = Msg;
        }

        private void ClientScoket_OnError(ExceptionEventArgs sender)
        {

        }

        private void SendByteToRobot(string Msg)
        {
            if (robotParser == null)
            {
                return;
            }

            robotParser.SendCommandToRobot(Msg);
        }

        private void SaveMsg(string msg)
        {
            if (_bIsSaveLog == true)
            {
                log.AddMsg(string.Format("【{0}】{1}", _StationName, msg));
            }
        }

        public delegate void DelHostUpdate(string IP, string Port);
        private void HostSetting(string IP, string Port)
        {
            if (this.InvokeRequired)
            {
                DelHostUpdate delHostUpdate = new DelHostUpdate(HostSetting);
                this.Invoke(delHostUpdate, IP, Port);
            }
            else
            {
                tbx_IP.Text = IP;
                tbx_Port.Text = Port;
            }
        }

        public delegate void DelHostUpdate_SerialPort(string Port, string Baudrate, string DataBits, string Parity, string StopBits);
        private void HostSetting(string Port, string Baudrate, string DataBits, string StopBits, string Parity)
        {
            if (this.InvokeRequired)
            {
                DelHostUpdate delHostUpdate = new DelHostUpdate(HostSetting);
                this.Invoke(delHostUpdate, Port, Baudrate, DataBits, StopBits, Parity);
            }
            else
            {
                tbx_IP.Text = Port;
                tbx_Port.Text = Baudrate;
                tbx_DataBit.Text = DataBits;
                tbx_Parity.Text = Parity;
                tbx_StopBit.Text = StopBits;
            }
        }

        private void ShowStationName(string Name)
        {
            if (this.InvokeRequired)
            {
                DelShowMsg MyDel = new DelShowMsg(ShowStationName);
                this.Invoke(MyDel, Name);
            }
            else
            {
                tbx_StationName.Text = Name;
            }
        }

        private void SetConnentedMode(eConnectedMode mode)
        {
            if (this.InvokeRequired)
            {
                DelSetConnectedMode MyDel = new DelSetConnectedMode(SetConnentedMode);
                this.Invoke(MyDel, mode);
            }
            else
            {
                switch (mode)
                {
                    case eConnectedMode.Ethernet:
                        {
                            textBox5.Text = "IP";
                            textBox7.Text = "Port";
                            textBox8.Visible = false;
                            tbx_DataBit.Visible = false;
                            textBox10.Visible = false;
                            tbx_StopBit.Visible = false;
                            textBox12.Visible = false;
                            tbx_Parity.Visible = false;
                        }
                        break;
                    case eConnectedMode.RS232:
                        {
                            textBox5.Text = "COM";
                            textBox7.Text = "BPS";
                            textBox8.Visible = true;
                            tbx_DataBit.Visible = true;
                            textBox10.Visible = true;
                            tbx_StopBit.Visible = true;
                            textBox12.Visible = true;
                            tbx_Parity.Visible = true;
                        }
                        break;
                    default:
                        break;
                }
            }
        }
        private bool ProcessReceivedData(List<byte> byteArray)
        {
            return false;
        }

        private void delUpdateStatusLED(KCSDK.ThreeColorLight.ColorLightType Type)
        {
            if (this.InvokeRequired == true)
            {
                RobotParser.DelUpdateStatusLED del = new RobotParser.DelUpdateStatusLED(delUpdateStatusLED);

                this.BeginInvoke(del, Type);
            }
            else
            {
                if (led_Status != null)
                {
                    led_Status.Value = Type;
                }
            }
        }


        #endregion private

        private void bt_connect_Click(object sender, EventArgs e)
        {
            Connect();
        }

        private void bt_disconnect_Click(object sender, EventArgs e)
        {
            DisConnect();
        }

        private void bt_Command_Click(object sender, EventArgs e)
        {
            if (robotParser == null)
            {
                MessageBox.Show("Not Initial");
                return;
            }

            //if (IsConnect() == false)
            //{
            //    MessageBox.Show("Not Connect");
            //    return;
            //}

            int iCmdIndex = lst_Command.SelectedIndex;

            if (iCmdIndex == -1)
            {
                MessageBox.Show("No Select Command");
                return;
            }

            string cmd = lst_Command.SelectedItem.ToString();
            string station = "None";

            if (robotParser.GetCmdParameterIsNeedStationList(cmd))
            {
                int iStationIndex = lst_Station.SelectedIndex;
                if (iStationIndex == -1)
                {
                    MessageBox.Show("No Select Station");
                    return;
                }
                else
                {
                    station = lst_Station.SelectedItem.ToString();

                    if (IsSafeToAction(station) == false)//IsSafeToAction != null &&
                    {
                        if (IsSafeToAction == null)
                        {
                            MessageBox.Show("Robot Not Safe");
                        }
                        return;
                    }
                }
            }

            string parameter_1 = nu_parameter_1.Value.ToString();
            string parameter_2 = nu_parameter_2.Value.ToString();
            string parameter_3 = nu_parameter_3.Value.ToString();
            string parameter_4 = nu_parameter_4.Value.ToString();
            string parameter_5 = nu_parameter_5.Value.ToString();
            
            if (IsConnect() == false)
            {
                string sComm = robotParser.sGetCommnad(cmd, station, parameter_1, parameter_2, parameter_3, parameter_4, parameter_5);

                log.AddMsg(string.Format("【{0}】{1}", _StationName, sComm));

                MessageBox.Show("Not Connect");
                return;
            }

            bool b1 = robotParser.SetCommnad(cmd, station, parameter_1, parameter_2, parameter_3, parameter_4, parameter_5);
            if (b1 == false)
            {
                MessageBox.Show("Set Command Fail");
            }
        }

        private float X;
        private float Y;
        private bool bSetTag = false;
        private void setTag(Control cons)
        {
            foreach (Control con in cons.Controls)
            {
                con.Tag = con.Width + ":" + con.Height + ":" + con.Left + ":" + con.Top + ":" + con.Font.Size;
                if (con.Controls.Count > 0)
                {
                    setTag(con);
                }
            }
            bSetTag = true;
        }

        private void SetControls(float newx, float newy, Control cons)
        {
            if (bSetTag == false)
            {
                return;
            }

            foreach (Control con in cons.Controls)
            {
                string[] mytag = con.Tag.ToString().Split(new char[] { ':' });
                float a = Convert.ToSingle(mytag[0]) * newx;
                con.Width = (int)a;
                a = Convert.ToSingle(mytag[1]) * newy;
                con.Height = (int)a;
                a = Convert.ToSingle(mytag[2]) * newx;
                con.Left = (int)a;
                a = Convert.ToSingle(mytag[3]) * newy;
                con.Top = (int)a;
                Single currentSize = Convert.ToSingle(mytag[4]) * Math.Min(newx, newy);
                con.Font = new Font(con.Font.Name, currentSize, con.Font.Style, con.Font.Unit);
                if (con.Controls.Count > 0)
                {
                    SetControls(newx, newy, con);
                }
            }
        }

        private void RobotControl_Resize(object sender, EventArgs e)
        {
            //float newx = this.Width / X;
            //float newy = this.Height / Y;
            //SetControls(newx, newy, this);
        }

        private void RobotControl_Load(object sender, EventArgs e)
        {
            X = this.Width;
            Y = this.Height;
            setTag(this);
        }

        private void lst_Command_SelectedIndexChanged(object sender, EventArgs e)
        {
            int iCmdIndex = lst_Command.SelectedIndex;

            if (iCmdIndex == -1)
            {
                return;
            }

            string cmd = lst_Command.SelectedItem.ToString();

            if (robotParser != null)
            {
                log.AddMsg(string.Format("【{0}】使用者選擇命令說明:{1}", _StationName, robotParser.GetCommandDescribe(cmd)));

                CommandParameter[] CmdParas = robotParser.GetCmdParameterSetting(cmd);
                for (int i = 0; i < Para_Ctrl.Length; i++)
                {
                    Para_Ctrl[i].tbx_ParameterName.Text = CmdParas[i].sParameter_Name;
                    Para_Ctrl[i].tbx_ParameterName.Visible = CmdParas[i].IsVisible;

                    Para_Ctrl[i].nu_ParameterName.Maximum = CmdParas[i].MaxValue;
                    Para_Ctrl[i].nu_ParameterName.Minimum = CmdParas[i].MinValue;
                    Para_Ctrl[i].nu_ParameterName.Visible = CmdParas[i].IsVisible;
                    Para_Ctrl[i].nu_ParameterName.Value = CmdParas[i].MinValue;
                }
                bool b1 = robotParser.GetCmdParameterIsNeedStationList(cmd);
                textBox1.Visible = b1;
                lst_Station.Visible = b1;
            }
        }

        private void btn_AlarmReset_Click(object sender, EventArgs e)
        {
            AlarmReset();
        }

        public object GetReceiveData()
        {
            return robotParser.GetReceiveData();
        }

        public class Parameter_Control
        {
            public TextBox tbx_ParameterName;
            public NumericUpDown nu_ParameterName;
        }

    }

    // 自定義的選單選擇器
    public class EnumDropDownConverter : EnumConverter
    {
        public EnumDropDownConverter(Type type)
            : base(type)
        {
        }

        // 指定選單選擇器為下拉式清單
        public override StandardValuesCollection GetStandardValues(ITypeDescriptorContext context)
        {
            return new StandardValuesCollection(Enum.GetValues(base.EnumType));
        }

        // 指定使用下拉式清單
        public override bool GetStandardValuesSupported(ITypeDescriptorContext context)
        {
            return true;
        }

        // 指定為實際值，而不是索引
        public override bool GetStandardValuesExclusive(ITypeDescriptorContext context)
        {
            return true;
        }
    }
}
