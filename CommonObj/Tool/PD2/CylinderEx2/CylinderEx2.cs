using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PaeLibGeneral;
using PaeLibProVSDKEx;
using ProVLib;
using System.Diagnostics;
using System.Reflection;

namespace CommonObj
{
    [ToolboxItem(true)]
    public partial class CylinderEx2 : UserControl
    {
        private const int FormSizeX = 170;
        private const int FormSizeY = 220;
        private const int FormSizeY_Open = 285;

        #region 私有屬性
        private bool _bSwitchOn = false;
        private bool bSwitchOn
        {
            get { return _bSwitchOn; }
            set
            {
                _bSwitchOn = value;
                this.Invoke((MethodInvoker)delegate
                {
                    if (_bSwitchOn)
                    {
                        btnSW.BackgroundImage = Properties.Resources.toggle_on;
                    }
                    else
                    {
                        btnSW.BackgroundImage = Properties.Resources.toggle_off;
                    }
                });
            }
        }

        private bool _bCycle = false;
        private bool bCycle
        {
            get { return _bCycle; }
            set
            {
                _bCycle = value;
                this.Invoke((MethodInvoker)delegate
                {
                    if (_bCycle)
                    {
                        btn_Cycle.BackColor = Color.Green;
                        btn_Cycle.FlatAppearance.MouseOverBackColor = btn_Cycle.BackColor;
                        btn_Cycle.FlatAppearance.MouseDownBackColor = btn_Cycle.BackColor;
                    }
                    else
                    {
                        btn_Cycle.BackColor = Color.Transparent;
                        btn_Cycle.FlatAppearance.MouseOverBackColor = btn_Cycle.BackColor;
                        btn_Cycle.FlatAppearance.MouseDownBackColor = btn_Cycle.BackColor;
                    }
                });
            }
        }

        private int _iActionTime = 0;
        private int iActionTime
        {
            get { return _iActionTime; }
            set
            {
                _iActionTime = value;
                this.Invoke((MethodInvoker)delegate
                {
                    lb_ActionTime.Text = _iActionTime.ToString();
                });
            }
        }

        private MyTimer Timer_Cycle = new MyTimer();
        private Stopwatch watch_ActionTime = new Stopwatch();
        private bool _bOnAction = false;
        private bool bOnAction
        {
            get { return _bOnAction; }
            set
            {
                _bOnAction = value;
                if (_bOnAction)
                {
                    bCy1_ActionDone = false;
                    bCy2_ActionDone = false;
                }
            }
        }
        private bool _bOffAction = false;
        private bool bOffAction
        {
            get { return _bOffAction; }
            set
            {
                _bOffAction = value;
                if (_bOffAction)
                {
                    bCy1_ActionDone = false;
                    bCy2_ActionDone = false;
                }
            }
        }

        private bool bCy1_ActionDone = false;//計算時間用
        private bool bCy2_ActionDone = false;//計算時間用
        private bool bManual = false; //是否在手動操作，防止不必要UI更新
        private bool bInitial = false;//是否有Initial完成
        private string sActionTime = "";//紀錄ActionTime
        private string sActionTime2 = "";//紀錄ActionTime

        private ToolTip HintF;

        private int InitialCount = 0;

        private Cylinder _MyCylinder_1 = null;
        public Cylinder MyCylinder_1
        {
            get
            {
                if (_MyCylinder_1 == null)
                {
                    _MyCylinder_1 = new Cylinder(null, null, null);
                }
                return _MyCylinder_1;
            }
        }

        private Cylinder _MyCylinder_2 = null;
        public Cylinder MyCylinder_2
        {
            get
            {
                if (_MyCylinder_2 == null)
                {
                    _MyCylinder_2 = new Cylinder(null, null, null);
                }
                return _MyCylinder_2;
            }
        }

        private CylinderLanguage _eLanguage = CylinderLanguage.TW;
        public CylinderLanguage CyLanguage
        {
            get { return _eLanguage; }
            set
            {
                _eLanguage = value;
                ShowCyName();
            }
        }

        private bool _bOpenSetting = false;
        private bool bOpenSetting
        {
            get { return _bOpenSetting; }
            set
            {
                _bOpenSetting = value;
                this.Invoke((MethodInvoker)delegate
               {
                   if (_bOpenSetting)
                   {
                       // 設置固定大小
                       this.BringToFront();
                       this.MaximumSize = new Size(FormSizeX, FormSizeY_Open);
                       this.MinimumSize = new Size(FormSizeX, FormSizeY_Open);
                       this.Size = new Size(FormSizeX, FormSizeY_Open);
                   }
                   else
                   {

                       // 設置固定大小
                       this.SendToBack();
                       this.MaximumSize = new Size(FormSizeX, FormSizeY);
                       this.MinimumSize = new Size(FormSizeX, FormSizeY);
                       this.Size = new Size(FormSizeX, FormSizeY);
                   }
               });
            }
        }
        #endregion 私有屬性

        private string _CyName_TW = "Cylinder";
        [Category("自訂")]
        [Description("氣缸中文名稱")]
        [Browsable(true)] // 確保屬性在屬性視窗中可見
        public string CyName_TW
        {
            get { return _CyName_TW; }
            set
            {
                _CyName_TW = value;
                ShowCyName();
            }
        }

        private string _CyName_EN = "Cylinder";
        [Category("自訂")]
        [Description("氣缸英文名稱")]
        [Browsable(true)] // 確保屬性在屬性視窗中可見
        public string CyName_EN
        {
            get { return _CyName_EN; }
            set
            {
                _CyName_EN = value;
                //ShowCyName(_CyName_EN);
            }
        }

        private InBit _OnSensor_1;
        [Category("自訂")]
        [Description("OnSensor"), DisplayName("1.OnSensor")]
        [Browsable(true)] // 確保屬性在屬性視窗中可見
        public InBit OnSensor_1
        {
            get { return _OnSensor_1; }
            set
            {
                _OnSensor_1 = value;
                CheckIfInitialized();
            }
        }

        private InBit _OffSensor_1;
        [Category("自訂")]
        [Description("OffSensor"), DisplayName("2.OffSensor")]
        [Browsable(true)] // 確保屬性在屬性視窗中可見
        public InBit OffSensor_1
        {
            get { return _OffSensor_1; }
            set
            {
                _OffSensor_1 = value;
                CheckIfInitialized();
            }
        }

        private InBit _OnSensor_2;
        [Category("自訂")]
        [Description("OnSensor"), DisplayName("3.OnSensor")]
        [Browsable(true)] // 確保屬性在屬性視窗中可見
        public InBit OnSensor_2
        {
            get { return _OnSensor_2; }
            set
            {
                _OnSensor_2 = value;
                CheckIfInitialized();
            }
        }

        private InBit _OffSensor_2;
        [Category("自訂")]
        [Description("OffSensor"), DisplayName("4.OffSensor")]
        [Browsable(true)] // 確保屬性在屬性視窗中可見
        public InBit OffSensor_2
        {
            get { return _OffSensor_2; }
            set
            {
                _OffSensor_2 = value;
                CheckIfInitialized();
            }
        }

        private OutBit _OnCtrl;
        [Category("自訂")]
        [Description("OnCtrl"), DisplayName("5.OnCtrl")]
        [Browsable(true)] // 確保屬性在屬性視窗中可見
        public OutBit OnCtrl
        {
            get { return _OnCtrl; }
            set
            {
                _OnCtrl = value;
                CheckIfInitialized();
            }
        }

        private OutBit _OffCtrl;
        [Category("自訂")]
        [Description("OffCtrl"), DisplayName("6.OffCtrl")]
        [Browsable(true)] // 確保屬性在屬性視窗中可見
        public OutBit OffCtrl
        {
            get { return _OffCtrl; }
            set
            {
                _OffCtrl = value;
                CheckIfInitialized();
            }
        }

        [Category("自訂")]
        [Description("OffCtrl")]
        [Browsable(true)] // 確保屬性在屬性視窗中可見
        public string Text_Off_1
        {
            get { return ledLabel_Off_1.Caption; }
            set { ledLabel_Off_1.Caption = value; }
        }

        [Category("自訂")]
        [Description("OffCtrl")]
        [Browsable(true)] // 確保屬性在屬性視窗中可見
        public string Text_On_1
        {
            get { return ledLabel_On_1.Caption; }
            set { ledLabel_On_1.Caption = value; }
        }

        [Category("自訂")]
        [Description("OffCtrl")]
        [Browsable(true)] // 確保屬性在屬性視窗中可見
        public string Text_Off_2
        {
            get { return ledLabel_Off_2.Caption; }
            set { ledLabel_Off_2.Caption = value; }
        }

        [Category("自訂")]
        [Description("OffCtrl")]
        [Browsable(true)] // 確保屬性在屬性視窗中可見
        public string Text_On_2
        {
            get { return ledLabel_On_2.Caption; }
            set { ledLabel_On_2.Caption = value; }
        }

        public CylinderEx2()
        {
            TypeDescriptor.AddProvider(new HideEventsTypeDescriptionProvider(this.GetType()), this);
            InitializeComponent();

            btnSW.FlatAppearance.BorderSize = 0;
            btnSW.FlatAppearance.MouseOverBackColor = btnSW.BackColor;
            btnSW.FlatAppearance.MouseDownBackColor = btnSW.BackColor;

            btn_Cycle.FlatAppearance.BorderSize = 0;
            btn_Cycle.FlatAppearance.MouseOverBackColor = btn_Cycle.BackColor;
            btn_Cycle.FlatAppearance.MouseDownBackColor = btn_Cycle.BackColor;

            btn_Setting.FlatAppearance.BorderSize = 0;
            btn_Setting.FlatAppearance.MouseOverBackColor = btn_Setting.BackColor;
            btn_Setting.FlatAppearance.MouseDownBackColor = btn_Setting.BackColor;

            this.BackColor = Color.Gainsboro;

            // 設置固定大小
            this.Size = new Size(FormSizeX, FormSizeY);
            this.MaximumSize = new Size(FormSizeX, FormSizeY);
            this.MinimumSize = new Size(FormSizeX, FormSizeY);

            // 初始化 ToolTip
            HintF = new ToolTip();

            // 設定 ToolTip 的屬性
            HintF.ToolTipTitle = "IO Port";
            HintF.AutoPopDelay = 5000; // 5 秒後自動消失
            HintF.InitialDelay = 500; // 延遲 0.5 秒出現
            HintF.ReshowDelay = 200;  // 再次顯示的延遲
            HintF.IsBalloon = false;   // 氣泡樣式

            //bOpenSetting = false;
            SubscribeToMouseEvents(this);  // 訂閱滑鼠事件
        }

        #region 公開函數

        private void Initial()
        {
            if (this.DesignMode)
            {
                return; // 在設計時期不執行任何操作
            }

            if (_OnCtrl == null && _OffCtrl == null)
            {
                string msg = CyName_TW + ":Initial失敗";
                //this.Invoke((MethodInvoker)delegate
                //{
                //    panel1.BackColor = Color.Red;
                //});
                MessageBox.Show(msg);
                return;
            }

            string sHint = "";
            if (_OnCtrl == null && _OffCtrl != null)
            {
                if (_OnSensor_1 != null)
                {
                    sHint = "[OnSensor_1]:" + _OnSensor_1.IOPort + "\r\n";
                }

                if (_OnSensor_2 != null)
                {
                    sHint = "[OnSensor_2]:" + _OnSensor_2.IOPort + "\r\n";
                }

                if (_OffSensor_1 != null)
                {
                    sHint += "[OffSensor_1]:" + _OffSensor_1.IOPort + "\r\n";
                }

                if (_OffSensor_2 != null)
                {
                    sHint += "[OffSensor_2]:" + _OffSensor_2.IOPort + "\r\n";
                }
                sHint += "[OffCtrl]:" + _OffCtrl.IOPort + "\r\n";

                _MyCylinder_1 = new Cylinder(_OffCtrl, _OnSensor_1, _OffSensor_1);
                _MyCylinder_2 = new Cylinder(_OffCtrl, _OnSensor_2, _OffSensor_2);
            }
            else if (_OnCtrl != null && _OffCtrl == null)
            {
                if (_OnSensor_1 != null)
                {
                    sHint = "[OnSensor]:" + _OnSensor_1.IOPort + "\r\n";
                }
                if (_OffSensor_1 != null)
                {
                    sHint += "[OffSensor]:" + _OffSensor_1.IOPort + "\r\n";
                }
                sHint += "[OnCtrl]:" + _OnCtrl.IOPort + "\r\n";

                _MyCylinder_1 = new Cylinder(_OnCtrl, _OnSensor_1, _OffSensor_1);
                _MyCylinder_2 = new Cylinder(_OnCtrl, _OnSensor_2, _OffSensor_2);
            }
            else
            {
                if (_OnSensor_1 != null)
                {
                    sHint = "[OnSensor]:" + _OnSensor_1.IOPort + "\r\n";
                }
                if (_OffSensor_1 != null)
                {
                    sHint += "[OffSensor]:" + _OffSensor_1.IOPort + "\r\n";
                }
                sHint += "[OnCtrl]:" + _OnCtrl.IOPort + "\r\n";
                sHint += "[OffCtrl]:" + _OffCtrl.IOPort + "\r\n";

                _MyCylinder_1 = new Cylinder(_OnCtrl, _OffCtrl, _OnSensor_1, _OffSensor_1);
                _MyCylinder_2 = new Cylinder(_OnCtrl, _OffCtrl, _OnSensor_2, _OffSensor_2);
            }

            HintF.SetToolTip(lb_CyName, sHint);
            bInitial = true;
        }

        [Browsable(false)]
        public bool OffCtrlValue
        {
            get
            {
                return MyCylinder_1.OffCtrlValue;
            }
            set
            {
                if (IsSafeTo_On_Action != null)
                {
                    if (IsSafeTo_On_Action() == false)
                    {
                        return;
                    }
                }
                MyCylinder_1.OffCtrlValue = value;
            }
        }

        [Browsable(false)]
        public bool OffSensorValue_1
        {
            get
            {
                return MyCylinder_1.OffSensorValue;
            }
        }

        [Browsable(false)]
        public bool OffSensorValue_2
        {
            get
            {
                return MyCylinder_2.OffSensorValue;
            }
        }

        [Browsable(false)]
        public bool OnCtrlValue
        {
            get
            {
                return MyCylinder_1.OnCtrlValue;
            }
            set
            {
                if (IsSafeTo_Off_Action != null)
                {
                    if (IsSafeTo_Off_Action() == false)
                    {
                        return;
                    }
                }
                MyCylinder_1.OnCtrlValue = value;
            }
        }

        [Browsable(false)]
        public bool OnSensorValue_1
        {
            get
            {
                return MyCylinder_1.OnSensorValue;
            }
        }

        [Browsable(false)]
        public bool OnSensorValue_2
        {
            get
            {
                return MyCylinder_2.OnSensorValue;
            }
        }

        [Browsable(false)]
        public bool Simulation
        {
            get
            {
                return MyCylinder_1.Simulation;
            }
            set
            {
                MyCylinder_1.Simulation = value;
            }
        }

        public void DisposeTH()
        {
            MyCylinder_1.Dispose();
            MyCylinder_2.Dispose();
        }

        public void Free()
        {
            MyCylinder_1.Free();
            MyCylinder_2.Free();
        }

        public ThreeValued Off(int off_ms = 0, int timeout_ms = 0)
        {
            if (bInitial == false)
            {
                string msg = this.CyName_TW + ":未初始化";
                MessageBox.Show(msg);
                return ThreeValued.UNKNOWN;
            }

            if (IsSafeTo_Off_Action != null)
            {
                if (IsSafeTo_Off_Action() == false)
                {
                    return ThreeValued.UNKNOWN;
                }
            }

            if (bOffAction == false)
            {
                bOnAction = false;
                bOffAction = true;
                watch_ActionTime.Restart();
            }

            _bSwitchOn = false; //不用bSwitchOn防止更新圖示

            ThreeValued[] TV = new ThreeValued[2];
            TV[0] = MyCylinder_1.Off(off_ms, timeout_ms);
            TV[1] = MyCylinder_2.Off(off_ms, timeout_ms);

            if (TV.All(x => x == ThreeValued.TRUE))
            {
                return ThreeValued.TRUE;
            }
            else if (TV.Any(x => x == ThreeValued.FALSE))
            {
                return ThreeValued.FALSE;
            }
            return ThreeValued.UNKNOWN;
        }

        public ThreeValued On(int on_ms = 0, int timeout_ms = 0)
        {
            if (bInitial == false)
            {
                string msg = this.CyName_TW + ":未初始化";
                MessageBox.Show(msg);
                return ThreeValued.UNKNOWN;
            }

            if (IsSafeTo_On_Action != null)
            {
                if (IsSafeTo_On_Action() == false)
                {
                    return ThreeValued.UNKNOWN;
                }
            }

            if (bOnAction == false)
            {
                bOffAction = false;
                bOnAction = true;
                watch_ActionTime.Restart();
            }

            _bSwitchOn = true;  //不用bSwitchOn防止更新圖示

            ThreeValued[] TV = new ThreeValued[2];
            TV[0] = MyCylinder_1.On(on_ms, timeout_ms);
            TV[1] = MyCylinder_2.On(on_ms, timeout_ms);

            if (TV.All(x => x == ThreeValued.TRUE))
            {
                return ThreeValued.TRUE;
            }
            else if (TV.Any(x => x == ThreeValued.FALSE))
            {
                return ThreeValued.FALSE;
            }
            return ThreeValued.UNKNOWN;
        }

        // 自定義事件
        public delegate bool IsSafeToActionEventHandler();
        [Category("安全保護")]
        [Description("氣缸On安全保護")]
        [Browsable(true)] // 確保屬性在屬性視窗中可見
        public event IsSafeToActionEventHandler IsSafeTo_On_Action;
        [Category("安全保護")]
        [Description("氣缸Off安全保護")]
        [Browsable(true)] // 確保屬性在屬性視窗中可見
        public event IsSafeToActionEventHandler IsSafeTo_Off_Action;

        public void EnterManual()
        {
            bManual = true;
            bSwitchOn = _bSwitchOn;
        }

        public void LeftManual()
        {
            bManual = false;
            bCycle = false;
        }
        #endregion 公開函數

        #region 私有函數

        private void Swtich()
        {
            if (MyCylinder_1 != null)
            {
                if (bSwitchOn)
                {
                    if (IsSafeTo_Off_Action != null)
                    {
                        if (IsSafeTo_Off_Action() == true)
                        {
                            bSwitchOn = false;
                            Off();
                        }
                    }
                    else
                    {
                        bSwitchOn = false;
                        Off();
                    }
                }
                else
                {
                    if (IsSafeTo_On_Action != null)
                    {
                        if (IsSafeTo_On_Action() == true)
                        {
                            bSwitchOn = true;
                            On();
                        }
                    }
                    else
                    {
                        bSwitchOn = true;
                        On();
                    }
                }
            }
        }

        public delegate void DelShowMsg();
        private void ShowCyName()
        {
            if (this.InvokeRequired)
            {
                DelShowMsg MyDel = new DelShowMsg(ShowCyName);
                this.Invoke(MyDel, Name);
            }
            else
            {
                switch (CyLanguage)
                {
                    case CylinderLanguage.TW:
                        lb_CyName.Text = _CyName_TW;
                        break;
                    case CylinderLanguage.EN:
                        lb_CyName.Text = _CyName_EN;
                        break;
                    default:
                        break;
                }
            }
        }

        private void CheckIfInitialized()
        {
            InitialCount++;
            if (InitialCount == 4)
            {
                Initial();
            }
        }
        #endregion 私有函數

        #region 事件

        private void btnSW_Click(object sender, EventArgs e)
        {
            if (bInitial == false)
            {
                string msg = this.CyName_TW + ":未初始化";
                MessageBox.Show(msg);
                return;
            }

            Swtich();
        }

        private void btn_Cycle_Click(object sender, EventArgs e)
        {
            if (bInitial == false)
            {
                string msg = this.CyName_TW + ":未初始化";
                MessageBox.Show(msg);
                return;
            }

            if (bCycle)
            {
                bCycle = false;
            }
            else
            {
                Timer_Cycle.Restart();
                bCycle = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = false;

            if (MyCylinder_1 != null && MyCylinder_2 != null)
            {
                if (bCycle)
                {
                    string sTime = tbx_CycleTime.Text;
                    int iTime = 0;
                    if (int.TryParse(sTime, out iTime))
                    {
                        if (Timer_Cycle.On(iTime))
                        {
                            Timer_Cycle.Restart();
                            Swtich();
                        }
                    }
                }

                if (bOffAction)
                {
                    if (MyCylinder_1.OffSensorValue && bCy1_ActionDone == false)
                    {
                        bCy1_ActionDone = true;
                        sActionTime = watch_ActionTime.ElapsedMilliseconds.ToString();
                    }

                    if (MyCylinder_2.OffSensorValue && bCy2_ActionDone == false)
                    {
                        bCy2_ActionDone = true;
                        sActionTime2 = watch_ActionTime.ElapsedMilliseconds.ToString();
                    }

                    if (bCy1_ActionDone && bCy2_ActionDone)
                    {
                        bOffAction = false;
                        watch_ActionTime.Stop();
                    }
                }
                else if (bOnAction)
                {
                    if (MyCylinder_1.OnSensorValue && bCy1_ActionDone == false)
                    {
                        bCy2_ActionDone = true;
                        sActionTime = watch_ActionTime.ElapsedMilliseconds.ToString();
                    }

                    if (MyCylinder_2.OnSensorValue && bCy2_ActionDone == false)
                    {
                        bCy2_ActionDone = true;
                        sActionTime2 = watch_ActionTime.ElapsedMilliseconds.ToString();
                    }

                    if (bCy1_ActionDone && bCy2_ActionDone)
                    {
                        bOnAction = false;
                        watch_ActionTime.Stop();
                    }
                }
                else
                {
                    watch_ActionTime.Stop();
                }

                if (bManual)
                {
                    lb_ActionTime.Text = sActionTime;
                    lb_ActionTime2.Text = sActionTime2;
                    ledLabel_On_1.Value = MyCylinder_1.OnSensorValue;
                    ledLabel_Off_1.Value = MyCylinder_1.OffSensorValue;
                }
            }

            timer1.Enabled = true;
        }

        private void tbx_CycleTime_KeyPress(object sender, KeyPressEventArgs e)
        {
            // 允許數字 (0-9) 和控制鍵（如回車、退格等）
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // 禁止輸入
            }
        }

        private void CylinderEx2_Paint(object sender, PaintEventArgs e)
        {
            // 設置背景顏色
            e.Graphics.Clear(this.BackColor);
        }

        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            // 確保大小保持固定
            if (_bOpenSetting)
            {
                if (this.Size != new Size(FormSizeX, FormSizeY_Open))
                {
                    this.Size = new Size(FormSizeX, FormSizeY_Open);
                }
            }
            else
            {
                if (this.Size != new Size(FormSizeX, FormSizeY))
                {
                    this.Size = new Size(FormSizeX, FormSizeY);
                }
            }
        }

        #endregion 事件

        private void CylinderEx2_Load(object sender, EventArgs e)
        {
            if (this.DesignMode)
            {
                return;
            }

            if (bInitial == false)
            {
                panel1.BackColor = Color.Red;
            }
        }

        private void btn_Setting_Click(object sender, EventArgs e)
        {
            bOpenSetting = true;
        }

        // 遞迴訂閱所有子控制項的 MouseEnter 和 MouseLeave 事件
        private void SubscribeToMouseEvents(Control control)
        {
            foreach (Control childControl in control.Controls)
            {
                childControl.MouseEnter += new EventHandler(Control_MouseEnter);
                childControl.MouseLeave += new EventHandler(Control_MouseLeave);

                // 遞迴訂閱子控制項
                if (childControl.Controls.Count > 0)
                {
                    SubscribeToMouseEvents(childControl);
                }
            }
        }

        // 當滑鼠進入任何子控制項
        private void Control_MouseEnter(object sender, EventArgs e)
        {
            // 你可以在這裡處理滑鼠進入的行為
        }

        // 當滑鼠離開任何子控制項
        private void Control_MouseLeave(object sender, EventArgs e)
        {
            if (bOpenSetting)
            {
                // 檢查是否整個 UserControl 都沒有滑鼠
                if (!this.ClientRectangle.Contains(this.PointToClient(Cursor.Position)))
                {
                    bOpenSetting = false;
                }
            }
        }
    }

}
