using PaeLibGeneral;
using PaeLibProVSDKEx;
using ProVLib;
using System;

namespace PaeLibBibExchangerModule
{
    /// <summary>
    /// 推車類別
    /// </summary>
    public class BemCarrier : JModuleBase, IDisposable
    {
        #region I/O & Motion 元件

        /// <summary>
        /// 推車板定位偵測(偵測推車內的板是否超出安全位置)
        /// </summary>
        private DigitalInput DI_CarrierBIBPositionDetector;
        /// <summary>
        /// 閘門板定位偵測(偵測推車內的板是否超出安全位置，與閘門作動干涉)
        /// </summary>
        private DigitalInput DI_GateBIBPositionDetector;
        /// <summary>
        /// 光閘 Sensor Z
        /// </summary>
        private DigitalInput DI_Grating_Z;
        /// <summary>
        /// 光閘 Sensor Y
        /// </summary>
        private DigitalInput DI_Grating_Y;
        /// <summary>
        /// 推車樣式偵測A
        /// </summary>
        private DigitalInput DI_CarrierTypeDetectorA;
        /// <summary>
        /// 推車樣式偵測B
        /// </summary>
        private DigitalInput DI_CarrierTypeDetectorB;
        /// <summary>
        /// 推車夾持氣缸按鈕偵測
        /// </summary>
        private DigitalInput DI_ClasperButton;
        /// <summary>
        /// 閘門氣缸按鈕偵測
        /// </summary>
        private DigitalInput DI_GateButton;
        /// <summary>
        /// RACK到位SENSOR
        /// </summary>
        private DigitalInput DI_RackInPos;
        /// <summary>
        /// RACK有無SENSOR
        /// </summary>
        private DigitalInput DI_RackDetector;
        /// <summary>
        /// 閘門偵測
        /// </summary>
        private DigitalInput DI_GateDetector;
        /// <summary>
        /// 推車狀態警示燈
        /// </summary>
        private OutBit OB_CarrierLight;
        /// <summary>
        /// 推車夾持氣缸組 (常態為釋放)
        /// </summary>
        private Cylinder[] CY_Clasper;
        /// <summary>
        /// 閘門氣缸
        /// </summary>
        private Cylinder CY_Gate;

        #endregion I/O & Motion 元件

        #region 私有變數

        //卡匣物件 - 推車
        private JCassette CarrierInfo = new JCassette();

        private int LightBlinkingTick = 0;

        //Tasks
        private JActionTask HomeTask = new JActionTask();
        private JActionTask AutoTask = new JActionTask();
        private JActionTask ClasperButtonActionTask = new JActionTask();
        private JActionTask GateButtonActionTask = new JActionTask();

        /// <summary>
        /// 是否啟用 Rack Mode
        /// </summary>
        private readonly bool bEnableRackMode = false;

        #endregion 私有變數

        protected override void SimulationSetting(bool simulation)
        {
            //設定各 I/O 元件 Simulation
            if (DI_CarrierBIBPositionDetector != null) DI_CarrierBIBPositionDetector.Simulation = simulation;
            if (DI_GateBIBPositionDetector != null) DI_GateBIBPositionDetector.Simulation = simulation;
            if (DI_Grating_Z != null) DI_Grating_Z.Simulation = simulation;
            if (DI_Grating_Y != null) DI_Grating_Y.Simulation = simulation;
            if (DI_CarrierTypeDetectorA != null) DI_CarrierTypeDetectorA.Simulation = simulation;
            if (DI_CarrierTypeDetectorB != null) DI_CarrierTypeDetectorB.Simulation = simulation;
            if (DI_ClasperButton != null) DI_ClasperButton.Simulation = simulation;
            if (DI_GateButton != null) DI_GateButton.Simulation = simulation;
            if (DI_RackInPos != null) DI_RackInPos.Simulation = simulation;
            if (DI_RackDetector != null) DI_RackDetector.Simulation = simulation;
            if (DI_GateDetector != null) DI_GateDetector.Simulation = simulation;
            if (CY_Clasper != null)
            {
                foreach (var cy in CY_Clasper)
                {
                    if (cy != null) cy.Simulation = simulation;
                }
            }
            if (CY_Gate != null) CY_Gate.Simulation = simulation;
        }

        #region 屬性

        /// <summary>
        /// 手推台車樣式
        ///----------------
        /// A\B | Off | On
        ///----------------
        /// Off |  0  |  2
        ///----------------
        /// On  |  1  |  3
        ///----------------
        /// </summary>
        public int CarrierType { get; set; }

        /// <summary>
        /// 是否更換手推台車
        /// </summary>
        public bool IsCarrierExchange { get; set; }

        /// <summary>
        /// 手推台車是否 Ready
        /// </summary>
        private bool m_IsCarrierReady = false;

        public bool IsCarrierReady
        {
            get
            {
                if (this.Simulation || this.DryRun)
                {
                    return true;
                }
                return m_IsCarrierReady;
            }
            set
            {
                m_IsCarrierReady = value;
            }
        }

        #endregion 屬性

        #region 常數

        /// <summary>
        /// 氣缸流程動作逾時 (毫秒)
        /// </summary>
        private const int iTMCYDelay = 6000;

        /// <summary>
        /// 台車夾持氣缸動作時間 (毫秒)
        /// </summary>
        private const int iTMCYTimer = 800;

        /// <summary>
        /// 燈號狀態閃爍時間 (毫秒)
        /// </summary>
        private const int iLightBlinkTimer = 300;

        #endregion 常數

        #region 建構與解構

        /// <summary>
        /// 建構子，初始化元件
        /// </summary>
        /// <param name="alarm"></param>
        /// <param name="ib_CarrierBIBPositionDetector"></param>
        /// <param name="ib_GateBIBPositionDetector"></param>
        /// <param name="ib_CarrierTypeDetectorA"></param>
        /// <param name="ib_CarrierTypeDetectorB"></param>
        /// <param name="ib_ClasperButton"></param>
        /// <param name="ib_GateButton"></param>
        /// <param name="ob_CarrierLight"></param>
        public BemCarrier(
            AlarmCallback alarm,
            InBit ib_CarrierBIBPositionDetector, InBit ib_GateBIBPositionDetector, InBit ib_GratingZ, InBit ib_GratingY,
            InBit ib_CarrierTypeDetectorA, InBit ib_CarrierTypeDetectorB,
            InBit ib_ClasperButton, InBit ib_GateButton,
            OutBit ob_CarrierLight, int iClasperCY_Num)
            : base(alarm)
        {
            //BemCarrierAlarm = new JModuleBase(alarm);
            DI_CarrierBIBPositionDetector = new DigitalInput(ib_CarrierBIBPositionDetector);
            DI_GateBIBPositionDetector = new DigitalInput(ib_GateBIBPositionDetector);
            DI_Grating_Z = new DigitalInput(ib_GratingZ);
            DI_Grating_Y = new DigitalInput(ib_GratingY);
            DI_CarrierTypeDetectorA = new DigitalInput(ib_CarrierTypeDetectorA);
            DI_CarrierTypeDetectorB = new DigitalInput(ib_CarrierTypeDetectorB);
            DI_ClasperButton = new DigitalInput(ib_ClasperButton);
            DI_GateButton = new DigitalInput(ib_GateButton);
            OB_CarrierLight = ob_CarrierLight;
            CY_Clasper = new Cylinder[iClasperCY_Num];

            Simulation = false;
            DryRun = false;
            CarrierType = 0;
            IsCarrierExchange = false;
            IsCarrierReady = false;
        }

        /// <summary>
        /// 建構子，初始化元件
        /// <para>For RACK Mode</para>
        /// </summary>
        /// <param name="alarm"></param>
        /// <param name="ib_CarrierBIBPositionDetector"></param>
        /// <param name="ib_GateBIBPositionDetector"></param>
        /// <param name="ib_GratingZ"></param>
        /// <param name="ib_GratingY"></param>
        /// <param name="ib_RackInPos"></param>
        /// <param name="ib_RackDetector"></param>
        /// <param name="ib_GateDetector"></param>
        /// <param name="iClasperCY_Num"></param>
        public BemCarrier(
            AlarmCallback alarm,
            InBit ib_CarrierBIBPositionDetector, InBit ib_GateBIBPositionDetector,
            InBit ib_GratingZ, InBit ib_GratingY,
            InBit ib_RackInPos, InBit ib_RackDetector,
            InBit ib_GateDetector,
            int iClasperCY_Num)
            : base(alarm)
        {
            //BemCarrierAlarm = new JModuleBase(alarm);
            DI_CarrierBIBPositionDetector = new DigitalInput(ib_CarrierBIBPositionDetector);
            DI_GateBIBPositionDetector = new DigitalInput(ib_GateBIBPositionDetector);
            DI_Grating_Z = new DigitalInput(ib_GratingZ);
            DI_Grating_Y = new DigitalInput(ib_GratingY);
            DI_RackInPos = new DigitalInput(ib_RackInPos);
            DI_RackDetector = new DigitalInput(ib_RackDetector);
            DI_GateDetector = new DigitalInput(ib_GateDetector);
            CY_Clasper = new Cylinder[iClasperCY_Num];

            Simulation = false;
            DryRun = false;
            CarrierType = 0;
            IsCarrierExchange = false;
            IsCarrierReady = false;

            bEnableRackMode = true; // 啟用 RACK 模式
        }

        ~BemCarrier()
        {
            this.Dispose();
        }

        public void Dispose()
        {
            if (DI_CarrierBIBPositionDetector != null) DI_CarrierBIBPositionDetector.Dispose();
            if (DI_GateBIBPositionDetector != null) DI_GateBIBPositionDetector.Dispose();
            if (DI_CarrierTypeDetectorA != null) DI_CarrierTypeDetectorA.Dispose();
            if (DI_CarrierTypeDetectorB != null) DI_CarrierTypeDetectorB.Dispose();
            if (DI_ClasperButton != null) DI_ClasperButton.Dispose();
            if (DI_GateButton != null) DI_GateButton.Dispose();
            if (DI_Grating_Z != null) DI_Grating_Z.Dispose();
            if (DI_Grating_Y != null) DI_Grating_Y.Dispose();
            if (DI_RackInPos != null) DI_RackInPos.Dispose();
            if (DI_RackDetector != null) DI_RackDetector.Dispose();
            if (DI_GateDetector != null) DI_GateDetector.Dispose();
            if (OB_CarrierLight != null) OB_CarrierLight.Dispose();
            if (CY_Clasper != null)
            {
                foreach (var cy in CY_Clasper)
                {
                    if (cy != null) cy.Dispose();
                }
            }
            if (CY_Gate != null) CY_Gate.Dispose();
        }

        #endregion 建構與解構

        #region 私有函式

        /// <summary>
        /// 顯示 Alarm 的函式委派
        /// </summary>
        /// <param name="ret"></param>
        private void ShowModuleAlarm(int ret)//模組Alarm
        {
            this.ShowAlarm(ret);
        }

        /// <summary>
        /// 清除 Alarm 的函式委派
        /// </summary>
        /// <param name="ret"></param>
        private void ClearModuleAlarm(int ret)
        {
            this.ClearAlarm(ret);
        }

        /// <summary>
        /// 手推台車夾持氣缸控制
        /// </summary>
        /// <param name="clasp">true : 夾持，false : 釋放</param>
        /// <param name="on_ms">sensor on delay time</param>
        /// <param name="timeout_ms">timeout delay time</param>
        /// <returns>true : 動作完成，false : 動作未完成</returns>
        private bool CY_ClasperCtrl(bool clasp, int on_ms = 800, int timeout_ms = 6000)
        {
            bool bRet = false;
            if (CY_Clasper != null)
            {
                ThreeValued tRet_Left = ThreeValued.TRUE;
                ThreeValued tRet_Right = ThreeValued.TRUE;

                //氣缸動作控制
                if (!clasp)
                {
                    //夾持 (因為常態為夾持，所以氣缸 Off 為釋放)
                    foreach (var cy in CY_Clasper)
                    {
                        if (cy != null)
                        {
                            var tRet = cy.Off(on_ms, timeout_ms);
                            if (tRet == ThreeValued.FALSE)
                                tRet_Left = ThreeValued.FALSE;
                            else if (tRet == ThreeValued.UNKNOWN && tRet_Left != ThreeValued.FALSE)
                                tRet_Left = ThreeValued.UNKNOWN;
                        }
                    }
                }
                else
                {
                    //釋放 (因為常態為夾持，所以氣缸 On 為夾持)
                    foreach (var cy in CY_Clasper)
                    {
                        if (cy != null)
                        {
                            var tRet = cy.On(on_ms, timeout_ms);
                            if (tRet == ThreeValued.FALSE)
                                tRet_Left = ThreeValued.FALSE;
                            else if (tRet == ThreeValued.UNKNOWN && tRet_Left != ThreeValued.FALSE)
                                tRet_Left = ThreeValued.UNKNOWN;
                        }
                    }
                }

                //氣缸動作結果判斷
                if (tRet_Left.Equals(ThreeValued.TRUE) &&
                    tRet_Right.Equals(ThreeValued.TRUE))
                {
                    bRet = true;
                }
                else if (tRet_Left.Equals(ThreeValued.FALSE) || tRet_Right.Equals(ThreeValued.FALSE))
                {
                    if (clasp)
                    {
                        //如果是夾持台車失敗，則將台車釋放(氣缸 Off)
                        if (CY_Clasper != null)
                        {
                            foreach (var cy in CY_Clasper)
                            {
                                if (cy != null)
                                    cy.OffCtrlValue = true;
                            }
                        }
                        //Alarm : 夾持台車動作逾時
                        ShowModuleAlarm((int)BEMAlarmCode.ArmBemCarrierClaspTimeout);
                    }
                    else
                    {
                        //Alarm : 釋放台車動作逾時
                        ShowModuleAlarm((int)BEMAlarmCode.ArmBemCarrierReleaseTimeout);
                    }
                }
            }
            else
            {
                //Alarm : 推車夾持氣缸元件未初始化
                ShowModuleAlarm((int)BEMAlarmCode.ArmBemCarrierClasperNull);
            }
            return bRet;
        }

        /// <summary>
        /// 偵測手推台車板子是否在安全位置
        /// </summary>
        /// <returns>true : 是，false : 否</returns>
        private bool CheckCarrierBIBPosition()
        {
            bool bRet = false;
            if (DI_CarrierBIBPositionDetector != null)
            {
                ThreeValued tRet = DI_CarrierBIBPositionDetector.On(50, 1000); //B接點
                if (tRet.Equals(ThreeValued.TRUE))
                {
                    bRet = true;
                }
                else if (tRet.Equals(ThreeValued.FALSE))
                {
                    //Alarm : 推車板定位不良
                    ShowModuleAlarm((int)BEMAlarmCode.ArmBemCarrierBIBPositionError);
                }
            }
            else
            {
                bRet = true;
            }
            return bRet;
        }

        /// <summary>
        /// 偵測閘門處板子是否在安全位置
        /// </summary>
        /// <returns>true : 是，false : 否</returns>
        private bool CheckGateBIBPosition()
        {
            bool bRet = false;
            if (DI_GateBIBPositionDetector != null)
            {
                ThreeValued tRet = DI_GateBIBPositionDetector.On(50, 1000); //B接點
                if (tRet.Equals(ThreeValued.TRUE))
                {
                    bRet = true;
                }
                else if (tRet.Equals(ThreeValued.FALSE))
                {
                    //Alarm : 閘門板定位不良
                    ShowModuleAlarm((int)BEMAlarmCode.ArmBemCarrierGateBIBPositionError);
                }
            }
            else
            {
                bRet = true;
            }
            return bRet;
        }

        /// <summary>
        /// 夾持推車氣缸按鈕動作 - 於 AlwaysRun 中呼叫
        /// </summary>
        /// <returns></returns>
        private void ClasperButtonAction()
        {
            JActionTask Task = ClasperButtonActionTask;
            switch (Task.Value)
            {
                case 0:
                    {
                        bool B1 = (IsCarrierExchange && !IsCarrierReady);   //要求更換推車且推車未Ready
                        bool B4 = DI_ClasperButton.ValueOn || this.Simulation;     //夾持推車氣缸按鈕
                        if ((B1 && B4))
                        {
                            if (this.Simulation)
                            {
                                Task.Next();
                            }
                            else
                            {
                                bool B2 = CheckCarrierInPosition();     //推車是否到位(推到底) - 含推車樣式判斷
                                bool B3 = CheckCarrierBIBPosition();    //偵測手推台車板子是否在安全位置
                                if (B2 && B3)
                                {
                                    Task.Next();
                                }
                            }
                        }
                    }
                    break;

                case 1:     //夾持推車
                    {
                        if (CY_ClasperCtrl(true))
                        {
                            Task.Next();
                        }
                    }
                    break;

                case 2:     //夾持推車完成
                    {
                        IsCarrierExchange = false;
                        Task.Next(99);
                    }
                    break;

                case 99:
                    break;
            }
        }

        /// <summary>
        /// 開啟閘門氣缸按鈕動作 - 於 AlwaysRun 中呼叫
        /// </summary>
        private void GateButtonAction()
        {
            JActionTask Task = GateButtonActionTask;
            switch (Task.Value)
            {
                case 0:
                    {
                        bool B1 = (!IsCarrierExchange && !IsCarrierReady);   //推車已更換但推車未Ready
                        bool B2 = DI_GateButton.ValueOn || this.Simulation; //開啟閘門氣缸按鈕
                        if ((B1 && B2))
                        {
                            Task.Next();
                        }
                    }
                    break;

                case 1: //開啟閘門
                    {
                        if (OpenGate())
                        {
                            Task.Next();
                        }
                    }
                    break;

                case 2: //開啟閘門完成
                    {
                        IsCarrierReady = true;
                        Task.Next(99);
                    }
                    break;

                case 99:
                    break;
            }
        }

        /// <summary>
        /// 更新推車指示燈狀態 - 於 AlwaysRun 中呼叫
        /// </summary>
        private void RefreshLightStatus()
        {
            if (OB_CarrierLight != null)
            {
                if (IsCarrierExchange)
                {
                    //通知更換推車(更換推車中) - 推車在定位燈恆亮，推車不在定位燈閃爍
                    if (CarrierInPosition())
                    {
                        //推車在定位 - 燈恆亮
                        OB_CarrierLight.On();
                    }
                    else
                    {
                        //推車不在定位 - 燈閃爍
                        OB_CarrierLight.Value = (LightBlinkingTick <= iLightBlinkTimer);
                        LightBlinkingTick++;
                        LightBlinkingTick = (LightBlinkingTick % (iLightBlinkTimer * 2));
                    }
                }
                else
                {
                    //推車更換完成(沒有要更換推車) - 推車在定位燈亮，推車不在定位燈滅
                    OB_CarrierLight.Value = CarrierInPosition();
                }
            }
        }

        #endregion 私有函式

        #region 公有函式

        /// <summary>
        /// 設定推車資訊(for 雙層)
        /// </summary>
        /// <param name="n1">第一層層數(下層區塊)</param>
        /// <param name="n2">第二層層數(上層區塊)</param>
        /// <param name="pitch">層與層之間距</param>
        /// <param name="gap">上/下層區塊之間距(不包含層間距)</param>
        public bool SetCarrierInfo(int n1, int n2, int pitch, int gap)
        {
            bool bRet = false;
            if (CarrierInfo != null)
            {
                CarrierInfo.Reset();
                CarrierInfo.AddSlotInfo(n1, pitch, 0);
                CarrierInfo.AddSlotInfo(n2, pitch, gap);
                bRet = true;
            }
            return bRet;
        }

        /// <summary>
        /// 設定推車資訊(for 單層)
        /// </summary>
        /// <param name="n1">第一層層數(下層區塊)</param>
        /// <param name="pitch">層與層之間距</param>
        public bool SetCarrierInfo(int n1, int pitch)
        {
            bool bRet = false;
            if (CarrierInfo != null)
            {
                CarrierInfo.Reset();
                CarrierInfo.AddSlotInfo(n1, pitch, 0);
                bRet = true;
            }
            return bRet;
        }

        /// <summary>
        /// 重置所有樓層狀態為指定的狀態
        /// </summary>
        /// <param name="status">指定重置的狀態</param>
        public void ResetSlotStatus(SlotStatus status)
        {
            CarrierInfo.ResetStatus(status);
        }

        /// <summary>
        /// 設定指定樓層狀態為指定的狀態
        /// </summary>
        /// <param name="n">指定樓層(由下而上，第一層為 1，第二層為 2，...以此類推)</param>
        /// <param name="status">指定狀態</param>
        /// <returns>true : 設定成功，false : 設定失敗</returns>
        public bool SetSlotStatus(int n, SlotStatus status)
        {
            bool bSet = CarrierInfo.SetStatus(n, status);
            return bSet;
        }

        /// <summary>
        /// 取得指定樓層的狀態
        /// </summary>
        /// <param name="n">指定樓層(由下而上，第一層為 1，第二層為 2，...以此類推)</param>
        /// <returns>回傳指定樓層的狀態</returns>
        public SlotStatus GetSlotStatus(int n)
        {
            return CarrierInfo.GetStatus(n);
        }

        /// <summary>
        /// 取得符合指定狀態的樓層
        /// </summary>
        /// <param name="status">指定尋找的狀態</param>
        /// <param name="increasing">設定搜尋順序，true:由下往上，false:由上往下</param>
        /// <param name="StartFloor">指定開始尋找的樓層</param>  
        /// <returns>回傳找到的樓層(由下而上，第一層為 1，第二層為 2，...以此類推)，若沒找到則回傳-1</returns>
        public int GetSlotNo(SlotStatus status, bool increasing = true, int StartFloor = 1)
        {
            if (CarrierInfo != null)
            {
                //取得總層數
                int iSlotCount = CarrierInfo.GetTotalSlots();
                //由下往上找
                if (increasing)
                {
                    for (int i = StartFloor; i <= iSlotCount; ++i)
                    {
                        if (CarrierInfo.GetStatus(i) == status)
                        {
                            return i;
                        }
                    }
                }
                //由上往下找
                else
                {
                    for (int i = iSlotCount; i >= StartFloor; --i)
                    {
                        if (CarrierInfo.GetStatus(i) == status)
                        {
                            return i;
                        }
                    }
                }
            }
            return -1;	//找不到
        }

        /// <summary>
        /// 取得指定樓層的高度
        /// </summary>
        /// <param name="slot">指定樓層(由下而上，第一層為 1，第二層為 2，...以此類推)</param>
        /// <returns>回傳指定樓層高度</returns>
        public int GetSlotHeight(int n)
        {
            return CarrierInfo.GetSlotHeight(n);
        }

        /// <summary>
        /// 取得推車樣式
        ///----------------
        /// A\B | Off | On
        ///----------------
        /// Off |  0  |  2
        ///----------------
        /// On  |  1  |  3
        ///----------------
        /// </summary>
        /// <returns>0:無推車, 1~3 支援三種樣式</returns>
        public int GetCarrierType()
        {
            int iRet = 0;
            if (DI_CarrierTypeDetectorA != null)
            {
                if (DI_CarrierTypeDetectorA.ValueOn)
                {
                    if (DI_CarrierTypeDetectorB != null)
                    {
                        if (DI_CarrierTypeDetectorB.ValueOn)
                        {
                            iRet = 3;
                        }
                        else
                        {
                            iRet = 1;
                        }
                    }
                    else
                    {
                        iRet = 1;
                    }
                }
                else
                {
                    if (DI_CarrierTypeDetectorB != null)
                    {
                        if (DI_CarrierTypeDetectorB.ValueOn)
                        {
                            iRet = 2;
                        }
                        else
                        {
                            iRet = 0;
                        }
                    }
                    else
                    {
                        iRet = 0;
                    }
                }
            }
            return iRet;
        }

        /// <summary>
        /// 判斷推車是否到位(推到底)
        /// </summary>
        /// <returns></returns>
        public bool CarrierInPosition()
        {
            if (DryRun)
            {
                return true;
            }

            bool bRet = (GetCarrierType() > 0);
            return bRet;
        }

        /// <summary>
        /// 判斷推車是否到位(推到底) - 含推車樣式判斷
        /// </summary>
        /// <returns></returns>
        public bool CheckCarrierInPosition()
        {
            if (DryRun)
            {
                return true;
            }

            bool bRet = (GetCarrierType() == CarrierType);
            if (bRet == false)
            {
                //Alarm : 手推台車樣式錯誤！
                ShowModuleAlarm((int)BEMAlarmCode.ArmBemCarrierTypeError);
            }
            return bRet;
        }

        /// <summary>
        /// 初始化推車夾持氣缸
        /// </summary>
        /// <param name="index">推車夾持氣缸 index</param>
        /// <param name="ob_Clasper"></param>
        /// <param name="ib_ClasperOn"></param>
        /// <param name="ib_ClasperOff"></param>
        public void InitialClasperCY(int index, OutBit ob_Clasper, InBit ib_ClasperOn, InBit ib_ClasperOff)
        {
            if (index > CY_Clasper.Length) return;
            CY_Clasper[index] = new Cylinder(ob_Clasper, ib_ClasperOn, ib_ClasperOff);
        }

        /// <summary>
        /// 初始化閘門氣缸
        /// </summary>
        /// <param name="ob_Gate"></param>
        /// <param name="ib_GateOn"></param>
        /// <param name="ib_GateOff"></param>
        public void InitialGateCY(OutBit ob_Gate, InBit ib_GateOn, InBit ib_GateOff)
        {
            CY_Gate = new Cylinder(ob_Gate, ib_GateOn, ib_GateOff);
        }

        public void InitialGateCY(OutBit ob_GateOn, OutBit ob_GateOff, InBit ib_GateOn, InBit ib_GateOff)
        {
            CY_Gate = new Cylinder(ob_GateOn, ob_GateOff, ib_GateOn, ib_GateOff);
        }

        /// <summary>
        /// 判斷RACK是否到位(推到底)
        /// <para>為了因應空跑功能，所以必須在屬性註明是判斷是否到位，因為DryRun時一律回傳true</para>
        /// </summary>
        /// <param name="bState"><c>true</c> : 到位，<c>false</c> : 未到位</param>
        /// <returns></returns>
        public bool RackInPosition(bool bState)
        {
            if (DryRun || DI_RackInPos == null)
            {
                return true;
            }

            if (bState)
            {
                return DI_RackInPos.ValueOn;
            }
            else
            {
                return DI_RackInPos.ValueOff;
            }
        }

        /// <summary>
        /// 判斷有無RACK
        /// <para>為了因應空跑功能，所以必須在屬性註明是判斷有無RACK，因為DryRun時一律回傳true</para>
        /// </summary>
        /// <param name="bState"><c>true</c> : 有 RACK，<c>false</c> : 無 RACK</param>
        /// <returns></returns>
        public bool HasRackDetector(bool bState)
        {
            if (DryRun || DI_RackDetector == null)
            {
                return true;
            }

            if (bState)
            {
                return DI_RackDetector.ValueOn;
            }
            else
            {
                return DI_RackDetector.ValueOff;
            }
        }

        #endregion 公有函式

        #region 動作流程

        /// <summary>
        /// 資料重置
        /// </summary>
        public void DataReset()
        {
            LightBlinkingTick = 0;
            IsCarrierReady = false;
            IsCarrierExchange = false;
            ClasperButtonActionTask.Reset();    //Reset to zero.
            GateButtonActionTask.Reset();       //Reset to zero.
            TaskReset();
            HomeReset();
        }

        /// <summary>
        /// 不間斷執行
        /// </summary>
        public void AlwaysRun()
        {
            ClasperButtonAction();
            GateButtonAction();
            RefreshLightStatus();
        }

        /// <summary>
        /// 判斷狀態是否安全可讓 Z 軸移動
        /// 由 BIBExchanger 模組呼叫並將結果傳給 Elevator.SafetyProtection(bool)
        /// </summary>
        /// <returns>true : 安全，false : 不安全</returns>
        public bool IsSafeForAxisZMoving()
        {
            bool bRet = true;
            if (!this.Simulation)
            {
                if (DI_CarrierBIBPositionDetector.ValueOff)
                {
                    //Alarm : 推車板定位不良
                    ShowModuleAlarm((int)BEMAlarmCode.ArmBemCarrierBIBPositionError);
                    bRet = false;
                }
                else if (DI_GateBIBPositionDetector.ValueOff)
                {
                    //Alarm : 閘門板定位不良
                    ShowModuleAlarm((int)BEMAlarmCode.ArmBemCarrierGateBIBPositionError);
                    bRet = false;
                }
                else if ((DI_Grating_Z != null && DI_Grating_Z.ValueOff) ||
                         (DI_Grating_Y != null && DI_Grating_Y.ValueOff))
                {
                    //Alarm : 觸發光閘安全防護
                    ShowModuleAlarm((int)BEMAlarmCode.ArmBemElevatorGratingBIBPositionError);
                    bRet = false;
                }
            }
            return bRet;
        }

        /// <summary>
        /// 動作流程重置
        /// </summary>
        public void TaskReset()// 重置 Task
        {
            AutoTask.Reset();   //Reset to zero.
        }

        /// <summary>
        /// 夾持推車 (呼叫此函式前，記得先呼叫 TaskReset() 函式)
        /// </summary>
        /// <returns>true : 動作完成，false : 動作中</returns>
        public bool ClaspCarrier()
        {
            bool bRet = false;
            JActionTask Task = AutoTask;
            switch (Task.Value)
            {
                case 0:
                    {	//偵測手推台車板子是否在安全位置
                        if (CheckCarrierBIBPosition())
                        {
                            if (!bEnableRackMode) //是否為RACK模式
                            {
                                Task.Next();
                            }
                            else
                            {
                                Task.Next(10); //偵測RACK有無推到定位
                            }
                        }
                    }
                    break;

                case 1: //偵測手推台車有無推到定位
                    {
                        if (CarrierInPosition())
                        {
                            Task.Next();
                        }
                        else
                        {
                            //Alarm : 推車未推至定位
                            ShowModuleAlarm((int)BEMAlarmCode.ArmBemCarrierPositionError);
                        }
                    }
                    break;

                case 2:	//推車夾持氣缸夾持動作
                    {
                        if (CY_ClasperCtrl(true))
                        {
                            Task.Next();
                        }
                    }
                    break;

                case 3:
                    {
                        bRet = true;
                    }
                    break;

                case 10: //偵測RACK有無推到定位
                    {
                        if (RackInPosition(true))
                        {
                            Task.Next(2); //推車夾持氣缸夾持動作
                        }
                        else
                        {
                            //Alarm : 推車未推至定位
                            ShowModuleAlarm((int)BEMAlarmCode.ArmBemCarrierPositionError);
                        }
                    }
                    break;
            }
            return bRet;
        }

        /// <summary>
        /// 釋放推車 (呼叫此函式前，記得先呼叫 TaskReset() 函式)
        /// </summary>
        /// <returns>true : 動作完成，false : 動作中</returns>
        public bool ReleaseCarrier(bool IsRack = false) //釋放推車 (呼叫此函式前，記得先呼叫 TaskReset() 函式)
        {
            bool bRet = false;
            JActionTask Task = AutoTask;
            switch (Task.Value)
            {
                case 0:
                    {	//偵測手推台車板子是否在安全位置
                        if (CheckCarrierBIBPosition())
                        {
                            Task.Next();
                        }
                    }
                    break;

                case 1:	//釋放推車
                    {
                        if (IsRack)
                        {
                            Task.Next();
                        }
                        else
                        {
                            if (CY_ClasperCtrl(false))
                            {
                                Task.Next();
                            }
                        }
                    }
                    break;

                case 2:
                    {
                        bRet = true;	//動作完成
                    }
                    break;
            }
            return bRet;
        }

        /// <summary>
        /// 關閉閘門
        /// </summary>
        /// <returns></returns>
        public bool CloseGate()
        {
            bool bRet = false;
            JActionTask Task = AutoTask;
            switch (Task.Value)
            {
                case 0: //判斷閘門板定位偵測是否觸發(B接)
                    {
                        if (CheckGateBIBPosition())
                        {
                            Task.Next();
                        }
                    }
                    break;

                case 1: //關閉閘門
                    {
                        ThreeValued tRet = CY_Gate.Off(100, 5000);
                        if (tRet.Equals(ThreeValued.TRUE))
                        {
                            Task.Next();
                        }
                        else
                        {
                            if (tRet.Equals(ThreeValued.FALSE))
                            {
                                //Alarm : 關閉閘門動作逾時
                                ShowModuleAlarm((int)BEMAlarmCode.ArmBemCarrierCloseGateTimeout);
                            }
                        }
                    }
                    break;

                case 2: //閘門偵測
                    {
                        if (DI_GateDetector == null)
                        {
                            Task.Next();
                        }

                        ThreeValued tRet = DI_GateDetector.On(100);
                        if (tRet.Equals(ThreeValued.TRUE))
                        {
                            Task.Next();
                        }
                        else
                        {
                            if (tRet.Equals(ThreeValued.FALSE))
                            {
                                //Alarm : 關閉閘門動作逾時
                                ShowModuleAlarm((int)BEMAlarmCode.ArmBemCarrierCloseGateTimeout);
                            }
                        }
                    }
                    break;

                case 3:
                    {
                        bRet = true;
                    }
                    break;
            }
            return bRet;
        }

        /// <summary>
        /// 開啟閘門
        /// </summary>
        /// <returns></returns>
        public bool OpenGate()
        {
            bool bRet = false;
            JActionTask Task = AutoTask;
            switch (Task.Value)
            {
                case 0: //開啟閘門
                    {
                        ThreeValued tRet = CY_Gate.On(100, 5000);
                        if (tRet.Equals(ThreeValued.TRUE))
                        {
                            Task.Next();
                        }
                        else
                        {
                            if (tRet.Equals(ThreeValued.FALSE))
                            {
                                //Alarm : 開啟閘門動作逾時
                                ShowModuleAlarm((int)BEMAlarmCode.ArmBemCarrierOpenGateTimeout);
                            }
                        }
                    }
                    break;

                case 1: //判斷閘門板定位偵測是否觸發(B接)
                    {
                        if (CheckGateBIBPosition())
                        {
                            Task.Next();
                        }
                    }
                    break;

                case 2:
                    {
                        bRet = true;
                    }
                    break;
            }
            return bRet;
        }

        /// <summary>
        /// 要求更換推車
        /// </summary>
        public void RequireExchangeCarrier()
        {
            IsCarrierReady = false;
            IsCarrierExchange = true;
            ClasperButtonActionTask.Reset();    //Reset to zero.
            GateButtonActionTask.Reset();       //Reset to zero.
        }

        #endregion 動作流程

        #region 歸零流程

        /// <summary>
        /// 重置 HomeTask
        /// </summary>
        public void HomeReset()
        {
            HomeTask.Reset();   //Reset to zero.
        }

        /// <summary>
        /// 歸零 (呼叫此函式前，記得先呼叫 HomeReset() 函式)
        /// </summary>
        /// <returns>true : 歸零完成，false : 歸零中...</returns>
        public bool Home()
        {
            bool bRet = false;
            JActionTask Task = HomeTask;
            switch (Task.Value)
            {
                case 0:
                    {
                        TaskReset();
                        Task.Next();
                    }
                    break;

                case 1:	//關閉閘門
                    {
                        if (ClaspCarrier())
                        {
                            Task.Next();
                        }
                    }
                    break;

                case 2:
                    {
                        TaskReset();
                        Task.Next();
                    }
                    break;

                case 3:	//釋放推車
                    {
                        bool IsRack = true;
                        if (ReleaseCarrier(IsRack))
                        {
                            Task.Next();
                        }
                    }
                    break;
                case 4:
                    {
                        bRet = true;	//動作完成
                    }
                    break;
            }
            return bRet;
        }

        #endregion 歸零流程
    }
}