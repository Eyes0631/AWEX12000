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

namespace OCRControl
{
    [ToolboxItem(true)]
    public partial class OCRControl : UserControl
    {
        public OCRControl()
        {
            InitializeComponent();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
        }

        public delegate void DelShowMsg(string Msg);
        public delegate void DelShowImage(Image image);
        public delegate void DelSetConnectedMode(eConnectedMode mode);
        public delegate bool DelIsSafeToAction();

        private ProVSocketLib.TAsyncMsgFlusher log;
        private OCRParser OcrParser = null;
        public delegate bool SafeToAction();
        private bool m_IsConnect = false;
        private string[] Parameters;
        private ParaControl Para_Ctrl;
        public DelShowImage delShowImage;
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
                if (OcrParser != null)
                {
                    OcrParser._bIsSimulation = _bIsSimulation;
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

        public void Initial(OCRParser RP)
        {
            if (RP == null)
                return;

            OcrParser = RP;
            OcrParser._SattionName = _StationName;
            OcrParser.ConnectedMode = _ConnectedMode;
            log = new TAsyncMsgFlusher(500, @"D:\Log\", _StationName, listBox1, 0, "log", "");
            OcrParser.delSaveMsg += SaveMsg;
            OcrParser.delOnConnect += ClientScoket_OnConnect;
            OcrParser.delOnDisconnect += ClientScoket_OnDisconnect;
            OcrParser.delShowErrorCode += ShowErrorCode;
            OcrParser.delShowReadImage += ShowReadImage;
            OcrParser.bUseCheckSum = UseCheckSum;
            OcrParser.bSendACKAfterAction = SendACKAfterAction;

            lst_Command.Items.Clear();
            lst_Command.Items.AddRange(OcrParser.GetCommandList());
        }

        public bool SetIPnPort(string IP, ushort PORT)
        {
            if (OcrParser == null)
            {
                return false;
            }

            bool b1 = OcrParser.SetIPnPort(IP, PORT);
            if (b1 == true)
            {
                HostSetting(IP, PORT.ToString());
            }
            return b1;
        }

        public bool SetComPort(string Port, string Baudrate, string DataBits, string StopBits, string Parity)
        {
            if (OcrParser == null)
            {
                return false;
            }

            bool b1 = OcrParser.SetComPort(Port, Baudrate, DataBits, StopBits, Parity);
            if (b1 == true)
            {
                HostSetting(Port, Baudrate, DataBits, StopBits, Parity);
            }
            return b1;
        }

        public bool SetCommand(object RobotCmd)
        {
            if (OcrParser == null)
            {
                return false;
            }

            if (_bSafeToAction == false)
            {
                return false;
            }

            return OcrParser.SetCommand(RobotCmd);
        }

        public bool IsConnect() //Munin
        {
            if (OcrParser == null)
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
            if (OcrParser == null)
            {
                return false;
            }

            return OcrParser.DisConnect();
        }

        public bool Connect()
        {
            if (OcrParser == null)
            {
                return false;
            }

            bool b1 = OcrParser.Connect();
            if (b1 == false)
            {
                //robotParser.SaveMsg("Connect Fail");
            }
            return b1;
        }

        public bool IsIDLE()
        {
            return OcrParser.isIDLE();
        }

        public bool ErrorHappen()
        {
            return OcrParser.ErrorHappen();
        }

        public string GetErrorCode()
        {
            return OcrParser.GetErrorCode();
        }

        public object GetStatus()
        {
            return OcrParser.GetStatus();
        }

        public void AlarmReset()
        {
            if (OcrParser != null)
            {
                OcrParser.ResetCommand();
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
            if (OcrParser == null)
            {
                return;
            }

            OcrParser.SendCommandToRobot(Msg);
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
            if (OcrParser == null)
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

            bool b1 = OcrParser.SetCommnad(cmd, station, Para_Ctrl.GetParas());
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

            if (OcrParser != null)
            {

                lb_CommandDescribe.Text = OcrParser.GetCommandDescribe(cmd);

                flowLayoutPanel6.Controls.Clear();
                Para_Ctrl = new ParaControl();

                CommandParameter[] CmdParas = OcrParser.GetCmdParameterSetting(cmd);
                Para_Ctrl.Parameter_Ctrl = new Control[CmdParas.Length];
                for (int i = 0; i < CmdParas.Length; i++)
                {
                    Para_Ctrl.Parameter_Ctrl[i] = new Control();
                    //Para_Ctrl[i].tbx_ParameterName.Text = CmdParas[i].sParameter_Name;
                    //Para_Ctrl[i].tbx_ParameterName.Visible = CmdParas[i].IsVisible;

                    //Para_Ctrl[i].nu_ParameterName.Maximum = CmdParas[i].MaxValue;
                    //Para_Ctrl[i].nu_ParameterName.Minimum = CmdParas[i].MinValue;
                    //Para_Ctrl[i].nu_ParameterName.Visible = CmdParas[i].IsVisible;
                    //Para_Ctrl[i].nu_ParameterName.Value = CmdParas[i].MinValue;

                    TextBox tbx_Caption = new TextBox();
                    tbx_Caption.BackColor = System.Drawing.SystemColors.InfoText;
                    tbx_Caption.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    tbx_Caption.ForeColor = System.Drawing.Color.Lime;
                    tbx_Caption.Name = "Caption_parameter_" + i.ToString();
                    tbx_Caption.ReadOnly = true;
                    tbx_Caption.Size = new System.Drawing.Size(126, 26);
                    tbx_Caption.Text = CmdParas[i].sParameter_Name;
                    tbx_Caption.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;

                    flowLayoutPanel6.Controls.Add(tbx_Caption);

                    switch (CmdParas[i].PType)
                    {
                        case CommandParameterType.NumericUpDown:
                            {
                                NumericUpDown nu = new NumericUpDown();
                                nu.Name = "nu_parameter_" + i.ToString();
                                nu.Size = new System.Drawing.Size(123, 22);
                                nu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;

                                nu.Maximum = CmdParas[i].MaxValue;
                                nu.Minimum = CmdParas[i].MinValue;
                                nu.Value = nu.Minimum;

                                flowLayoutPanel6.Controls.Add(nu);
                                Para_Ctrl.Parameter_Ctrl[i] = nu;
                            }
                            break;
                        case CommandParameterType.ComboBox:
                            {
                                ComboBox cbx = new ComboBox();
                                cbx.Name = "cbx_parameter_" + i.ToString();
                                cbx.Size = new System.Drawing.Size(123, 22);
                                cbx.DropDownStyle = ComboBoxStyle.DropDownList;
                                cbx.Items.AddRange(CmdParas[i].Parameter);
                                cbx.SelectedIndex = 0;

                                flowLayoutPanel6.Controls.Add(cbx);
                                Para_Ctrl.Parameter_Ctrl[i] = cbx;
                            }
                            break;
                        case CommandParameterType.TextBox:
                            {
                                TextBox tbx = new TextBox();
                                tbx.Name = "tbx_parameter_" + i.ToString();
                                tbx.Size = new System.Drawing.Size(125, 22);
                                tbx.Text = CmdParas[i].sTextBoxValue;

                                flowLayoutPanel6.Controls.Add(tbx);
                                Para_Ctrl.Parameter_Ctrl[i] = tbx;
                            }
                            break;
                        default:
                            break;
                    }

                }
            }
        }

        private void btn_AlarmReset_Click(object sender, EventArgs e)
        {
            AlarmReset();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = false;

            if (OcrParser != null)
            {
                if (OcrParser.isIDLE() == false)
                {
                    if (OcrParser.ErrorHappen())
                    {
                        tbx_ErrorCode.Text = OcrParser.GetErrorCode();
                        led_Status.Value = KCSDK.ThreeColorLight.ColorLightType.RedLight;
                    }
                    else
                    {
                        led_Status.Value = KCSDK.ThreeColorLight.ColorLightType.YellowLight;
                    }
                }
                else
                {
                    if (OcrParser.ErrorHappen())
                    {
                        tbx_ErrorCode.Text = OcrParser.GetErrorCode();
                        led_Status.Value = KCSDK.ThreeColorLight.ColorLightType.RedLight;
                    }
                    else
                    {
                        led_Status.Value = KCSDK.ThreeColorLight.ColorLightType.GrayLight;
                    }
                }
            }
            timer1.Enabled = true;
        }

        public object GetReceiveData()
        {
            return OcrParser.GetReceiveData();
        }

        public class Parameter_Control
        {
            public TextBox tbx_ParameterName;
            public NumericUpDown nu_ParameterName;
        }

        private void ShowReadImage(Image image)
        {
            if (image == null)
                return;

            this.Invoke((MethodInvoker)delegate
            {
                pictureBox1.Image = image;
                tbx_OCR_Result.Text = OcrParser.OCR_Read_Result;
            });

            if (delShowImage != null)
            {
                delShowImage((Image)image.Clone());
            }
        }

        public class ParaControl
        {
            public Control[] Parameter_Ctrl;

            public string[] GetParas()
            {
                string[] Paras = new string[Parameter_Ctrl.Length];

                for (int i = 0; i < Parameter_Ctrl.Length; i++)
                {
                    if (Parameter_Ctrl[i] is NumericUpDown)
                    {
                        NumericUpDown con = Parameter_Ctrl[i] as NumericUpDown;
                        Paras[i] = con.Value.ToString();
                    }
                    else if (Parameter_Ctrl[i] is ComboBox)
                    {
                        ComboBox con = Parameter_Ctrl[i] as ComboBox;
                        Paras[i] = con.SelectedItem.ToString();
                    }
                    else if (Parameter_Ctrl[i] is TextBox)
                    {
                        TextBox con = Parameter_Ctrl[i] as TextBox;
                        Paras[i] = con.Text;
                    }
                }

                return Paras;
            }
        }

        public string GetSavePath()
        {
            return OcrParser.SaveImagePath;
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
