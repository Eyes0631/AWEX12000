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
    public partial class CylinderEx : UserControl
    {
        public event EventHandler Toggled;

        private const int FormSizeX = 170;
        private const int FormSizeY = 115;
        private const int FormSizeY_Open = 180;

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
        private bool bOnAction = false;
        private bool bOffAction = false;
        private bool bManual = false; //是否在手動操作，防止不必要UI更新
        private bool bInitial = false;//是否有Initial完成
        private string sActionTime = "";//紀錄ActionTime

        private ToolTip HintF;

        private int InitialCount = 0;

        private Cylinder _MyCylinder = null;
        public Cylinder MyCylinder
        {
            get
            {
                if (_MyCylinder == null)
                {
                    _MyCylinder = new Cylinder(null, null, null);
                }
                return _MyCylinder;
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
                    this.SuspendLayout();

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

                    if (Toggled != null)
                    {
                        Toggled(this, EventArgs.Empty);
                    }

                    this.ResumeLayout(true);
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

        private InBit _OnSensor;
        [Category("自訂")]
        [Description("OnSensor"), DisplayName("1.OnSensor")]
        [Browsable(true)] // 確保屬性在屬性視窗中可見
        public InBit OnSensor
        {
            get { return _OnSensor; }
            set
            {
                _OnSensor = value;
                CheckIfInitialized();
            }
        }

        private InBit _OffSensor;
        [Category("自訂")]
        [Description("OffSensor"), DisplayName("2.OffSensor")]
        [Browsable(true)] // 確保屬性在屬性視窗中可見
        public InBit OffSensor
        {
            get { return _OffSensor; }
            set
            {
                _OffSensor = value;
                CheckIfInitialized();
            }
        }

        private OutBit _OnCtrl;
        [Category("自訂")]
        [Description("OnCtrl"), DisplayName("3.OnCtrl")]
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
        [Description("OffCtrl"), DisplayName("4.OffCtrl")]
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
        public string Text_Off
        {
            get { return ledLabel_Off.Caption; }
            set { ledLabel_Off.Caption = value; }
        }

        [Category("自訂")]
        [Description("OffCtrl")]
        [Browsable(true)] // 確保屬性在屬性視窗中可見
        public string Text_On
        {
            get { return ledLabel_On.Caption; }
            set { ledLabel_On.Caption = value; }
        }

        public CylinderEx()
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
                if (_OnSensor != null)
                {
                    sHint = "[OnSensor]:" + _OnSensor.IOPort + "\r\n";
                }
                if (_OffSensor != null)
                {
                    sHint += "[OffSensor]:" + _OffSensor.IOPort + "\r\n";
                }
                sHint += "[OffCtrl]:" + _OffCtrl.IOPort + "\r\n";

                _MyCylinder = new Cylinder(_OffCtrl, _OnSensor, _OffSensor);
            }
            else if (_OnCtrl != null && _OffCtrl == null)
            {
                if (_OnSensor != null)
                {
                    sHint = "[OnSensor]:" + _OnSensor.IOPort + "\r\n";
                }
                if (_OffSensor != null)
                {
                    sHint += "[OffSensor]:" + _OffSensor.IOPort + "\r\n";
                }
                sHint += "[OnCtrl]:" + _OnCtrl.IOPort + "\r\n";

                _MyCylinder = new Cylinder(_OnCtrl, _OnSensor, _OffSensor);
            }
            else
            {
                if (_OnSensor != null)
                {
                    sHint = "[OnSensor]:" + _OnSensor.IOPort + "\r\n";
                }
                if (_OffSensor != null)
                {
                    sHint += "[OffSensor]:" + _OffSensor.IOPort + "\r\n";
                }
                sHint += "[OnCtrl]:" + _OnCtrl.IOPort + "\r\n";
                sHint += "[OffCtrl]:" + _OffCtrl.IOPort + "\r\n";

                _MyCylinder = new Cylinder(_OnCtrl, _OffCtrl, _OnSensor, _OffSensor);
            }

            HintF.SetToolTip(lb_CyName, sHint);
            bInitial = true;
        }

        [Browsable(false)]
        public bool OffCtrlValue
        {
            get
            {
                return MyCylinder.OffCtrlValue;
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
                MyCylinder.OffCtrlValue = value;
            }
        }

        [Browsable(false)]
        public bool OffSensorValue
        {
            get
            {
                return MyCylinder.OffSensorValue;
            }
        }

        [Browsable(false)]
        public bool OnCtrlValue
        {
            get
            {
                return MyCylinder.OnCtrlValue;
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
                MyCylinder.OnCtrlValue = value;
            }
        }

        [Browsable(false)]
        public bool OnSensorValue
        {
            get
            {
                return MyCylinder.OnSensorValue;
            }
        }

        [Browsable(false)]
        public bool Simulation
        {
            get
            {
                return MyCylinder.Simulation;
            }
            set
            {
                MyCylinder.Simulation = value;
            }
        }

        public void DisposeTH()
        {
            MyCylinder.Dispose();
        }

        public void Free()
        {
            MyCylinder.Free();
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
            return MyCylinder.Off(off_ms, timeout_ms);
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
            return MyCylinder.On(on_ms, timeout_ms);
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
            if (MyCylinder != null)
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

            if (MyCylinder != null)
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
                    if (MyCylinder.OffSensorValue)
                    {
                        bOffAction = false;
                        watch_ActionTime.Stop();
                        sActionTime = watch_ActionTime.ElapsedMilliseconds.ToString();
                    }
                }
                else if (bOnAction)
                {
                    if (MyCylinder.OnSensorValue)
                    {
                        bOnAction = false;
                        watch_ActionTime.Stop();
                        sActionTime = watch_ActionTime.ElapsedMilliseconds.ToString();
                    }
                }
                else
                {
                    watch_ActionTime.Stop();
                }

                if (bManual)
                {
                    lb_ActionTime.Text = sActionTime;
                    ledLabel_On.Value = MyCylinder.OnSensorValue;
                    ledLabel_Off.Value = MyCylinder.OffSensorValue;
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

        private void CylinderEx_Paint(object sender, PaintEventArgs e)
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

        private void CylinderEx_Load(object sender, EventArgs e)
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
            bOpenSetting = !bOpenSetting;
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
                    //bOpenSetting = false;
                }
            }
        }
    }

    public class HideEventsTypeDescriptionProvider : TypeDescriptionProvider
    {
        private TypeDescriptionProvider baseProvider;

        public HideEventsTypeDescriptionProvider(Type type)
            : base(TypeDescriptor.GetProvider(type))
        {
            baseProvider = TypeDescriptor.GetProvider(type);
        }

        public override ICustomTypeDescriptor GetTypeDescriptor(Type objectType, object instance)
        {
            ICustomTypeDescriptor baseDescriptor = baseProvider.GetTypeDescriptor(objectType, instance);
            return new HideEventsTypeDescriptor(baseDescriptor);
        }
    }

    public class HideEventsTypeDescriptor : CustomTypeDescriptor
    {
        public HideEventsTypeDescriptor(ICustomTypeDescriptor parent) : base(parent) { }

        // 覆寫 GetEvents 方法以返回空的事件集合
        public override EventDescriptorCollection GetEvents()
        {
            return EventDescriptorCollection.Empty;
        }

        public override EventDescriptorCollection GetEvents(Attribute[] attributes)
        {
            return FilterEvents(base.GetEvents(attributes));
        }

        private EventDescriptorCollection FilterEvents(EventDescriptorCollection events)
        {
            // 定義要隱藏的內建事件名稱
            string[] eventsToShow = { "IsSafeTo_On_Action", "IsSafeTo_Off_Action" };

            var filtered = new List<EventDescriptor>();
            foreach (EventDescriptor ev in events)
            {
                // 只排除內建事件，保留自定義事件
                if (Array.Exists(eventsToShow, e => e == ev.Name))
                {
                    filtered.Add(ev);
                }
            }

            return new EventDescriptorCollection(filtered.ToArray());
        }
    }

    public enum CylinderLanguage
    {
        TW,
        EN,
    }
}
