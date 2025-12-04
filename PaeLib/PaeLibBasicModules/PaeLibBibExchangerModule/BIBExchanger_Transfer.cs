using PaeLibGeneral;
using PaeLibProVSDKEx;
using ProVLib;
using System;

namespace PaeLibBibExchangerModule
{
    public class BemTransfer : JModuleBase, IDisposable
    {
        #region enum

        /// <summary>
        /// 條碼槍樣式
        /// </summary>
        public enum BARCODE_READER_TYPE
        {
            NONE = 0,
            CIPHER_LAB = 1,
            OPTICON_NLV = 2
        }

        #endregion enum

        #region I/O & Motion 元件

        /// <summary>
        /// 前軌道板偵測(B接點，靠近推車端)
        /// </summary>
        private DigitalInput DI_FrontTrackBIBDetector = null;

        /// <summary>
        /// 後軌道板偵測(B接點，靠近主機端)
        /// </summary>
        private DigitalInput DI_BackTrackBIBDetector = null;

        /// <summary>
        /// 前勾爪處有無板偵測
        /// </summary>
        private DigitalInput DI_FrontHookBIBDetector = null;

        /// <summary>
        /// 後勾爪處有無板偵測
        /// </summary>
        private DigitalInput DI_BackHookBIBDetector = null;

        /// <summary>
        /// 前推車掃板偵測
        /// </summary>
        private DigitalInput DI_FrontCarrierBIBDetector = null;

        /// <summary>
        /// 後推車掃板偵測
        /// </summary>
        private DigitalInput DI_BackCarrierBIBDetector = null;

        /// <summary>
        /// 軌道上開蓋偵測
        /// </summary>
        private DigitalInput DI_TrackOpenLidDetector = null;

        /// <summary>
        /// 左側RACK拉盤中開蓋偵測
        /// </summary>
        private DigitalInput DI_LeftRackOpenLidDetector = null;

        /// <summary>
        /// 右側RACK拉盤中開蓋偵測
        /// </summary>
        private DigitalInput DI_RightRackOpenLidDetector = null;

        /// <summary>
        /// 重置東方馬達的Alarm
        /// </summary>
        private OutBit OB_AphaStepMotorAlarmReset = null;

        /// <summary>
        /// 前勾爪氣缸(靠近推車端)
        /// <para>常態縮回</para>
        /// </summary>
        private Cylinder CY_FrontHook = null;

        /// <summary>
        /// 後勾爪氣缸(靠近主機端)
        /// <para>常態縮回</para>
        /// </summary>
        private Cylinder CY_BackHook = null;

        /// <summary>
        /// 部分供板機含有板固定氣缸
        /// <para>常態縮回</para>
        /// </summary>
        private Cylinder CY_Pressure = null;
        private Cylinder CY_Pressure2 = null;

        /// <summary>
        /// 部分供板機含有板固定氣缸
        /// <para>常態縮回</para>
        /// <para>4個檢知</para>
        /// </summary>
        //private CylinderEx CY_PressureEx = null;

        /// <summary>
        /// 閘門氣缸
        /// <para>常態伸出</para>
        /// </summary>
        private Cylinder CY_CarrierGate = null;

        /// <summary>
        /// Y 軸馬達
        /// </summary>
        private Motor MO_AxisY = null;

        #endregion I/O & Motion 元件

        #region 私有變數

        /// <summary>
        /// 條碼槍
        /// </summary>
        private JBarcodeReader BarcodeReader = new JBarcodeReader();

        /// <summary>
        /// 自動任務
        /// </summary>
        private JActionTask AutoTask = new JActionTask();

        /// <summary>
        /// 歸零任務
        /// </summary>
        private JActionTask HomeTask = new JActionTask();
        /// <summary>
        /// 讀取板號任務
        /// </summary>
        private JActionTask ReadBIDTask = new JActionTask();

        /// <summary>
        /// 勾板氣缸上升 Delay Time
        /// </summary>
        private int iHookUpDelayTime = 300;

        /// <summary>
        /// 勾板氣缸下降 Delay Time
        /// </summary>
        private int iHookDownDelayTime = 300;

        /// <summary>
        /// 板固定氣缸上升 Delay Time
        /// </summary>
        private int iPressureUpDelayTime = 300;

        /// <summary>
        /// 板固定氣缸下降 Delay Time
        /// </summary>
        private int iPressureDownDelayTime = 300;

        /// <summary>
        /// Y 軸點位補償值
        /// </summary>
        private int iYPosOffset = 0;

        #endregion 私有變數

        /// <summary>
        /// 設定各 I/O 元件 Simulation
        /// </summary>
        /// <param name="simulation"></param>
        protected override void SimulationSetting(bool simulation)
        {
            if (DI_FrontTrackBIBDetector != null) DI_FrontTrackBIBDetector.Simulation = simulation;
            if (DI_BackTrackBIBDetector != null) DI_BackTrackBIBDetector.Simulation = simulation;
            if (DI_FrontHookBIBDetector != null) DI_FrontHookBIBDetector.Simulation = simulation;
            if (DI_BackHookBIBDetector != null) DI_BackHookBIBDetector.Simulation = simulation;
            if (DI_FrontCarrierBIBDetector != null) DI_FrontCarrierBIBDetector.Simulation = simulation;
            if (DI_BackCarrierBIBDetector != null) DI_BackCarrierBIBDetector.Simulation = simulation;
            if (DI_TrackOpenLidDetector != null) DI_TrackOpenLidDetector.Simulation = simulation;
            if (DI_LeftRackOpenLidDetector != null) DI_LeftRackOpenLidDetector.Simulation = simulation;
            if (DI_RightRackOpenLidDetector != null) DI_RightRackOpenLidDetector.Simulation = simulation;
            if (CY_FrontHook != null) CY_FrontHook.Simulation = simulation;
            if (CY_BackHook != null) CY_BackHook.Simulation = simulation;
            if (CY_Pressure != null) CY_Pressure.Simulation = simulation;
            if (CY_Pressure2 != null) CY_Pressure2.Simulation = simulation;
            if (CY_CarrierGate != null) CY_CarrierGate.Simulation = simulation;
        }

        #region 屬性

        /// <summary>
        /// 前後勾爪距離
        /// </summary>
        public int DistanceOfHook { get; set; }

        /// <summary>
        /// 主機端送板點
        /// </summary>
        public int SendBIBPosition { get; set; }

        /// <summary>
        /// 主機端收板點
        /// </summary>
        public int ReceiveBIBPosition { get; set; }

        /// <summary>
        /// 安全等待點
        /// </summary>
        public int WaitingPosition { get; set; }

        /// <summary>
        /// 讀板號位置
        /// </summary>
        public int ReadBarCodePosition { get; set; }

        /// <summary>
        /// 推車有無板偵測點
        /// </summary>
        public int DetectCarrierBIBPosition { get; set; }

        /// <summary>
        /// 主機有無板偵測點
        /// </summary>
        public int DetectBoardStageBIBPosition { get; set; }

        /// <summary>
        /// 推車進板點(從推車拉板進來)
        /// </summary>
        public int PullInBIBPosition { get; set; }

        /// <summary>
        /// 推車退板點(退板回推車)
        /// </summary>
        public int PushOutBIBPosition { get; set; }

        /// <summary>
        /// Y 軸速度 - 高速(無勾板時)
        /// </summary>
        public int AxisYSpeedHigh { get; set; }

        /// <summary>
        /// Y 軸速度 - 低速(有勾板時)
        /// </summary>
        public int AxisYSpeedLow { get; set; }

        /// <summary>
        /// Barcode Reader ComPort
        /// </summary>
        public byte BarcodeReaderComPort { get; set; }

        /// <summary>
        /// Barcode Reader Type
        /// </summary>
        public byte BarcodeReaderType { get; set; }

        /// <summary>
        /// 設定是否讀取板號
        /// </summary>
        public bool ReadBID { get; set; }

        /// <summary>
        /// 板號
        /// </summary>
        public string BID { get; private set; }

        /// <summary>
        /// 讀取板號模式 
        /// 0:拉板時讀取
        /// 1:推車讀取
        /// 2:供板機固定高度讀取
        /// </summary>
        public int ReadBIDMode { get; set; }

        /// <summary>
        /// 記錄板子來源樓層
        /// </summary>
        public int PullSlotNo { get; set; }

        #endregion 屬性

        #region 建構與解構

        /// <param name="ib_FrontTrackBIBDetector">前軌道板偵測(B接點，靠近推車端)</param>
        /// <param name="ib_BackTrackBIBDetector">後軌道板偵測(B接點，靠近主機端)</param>
        /// <param name="ib_FrontHookBIBDetector">前勾爪處有無板偵測</param>
        /// <param name="ib_BackHookBIBDetector">後勾爪處有無板偵測</param>
        /// <param name="ib_FrontCarrierBIBDetector">前推車掃板偵測</param>
        /// <param name="ib_BackCarrierBIBDetector">後推車掃板偵測</param>
        /// <param name="ib_TrackOpenLidDetector">軌道上開蓋偵測</param>
        /// <param name="ib_LeftRackOpenLidDetector">左側RACK拉盤中開蓋偵測</param>
        /// <param name="ib_RightRackOpenLidDetector">右側RACK拉盤中開蓋偵測</param>
        /// <param name="ob_AphaStepMotorAlarmReset">重置東方馬達的Alarm</param>
        /// <param name="ob_FrontHook">前勾爪氣缸(靠近推車端)</param>
        /// <param name="ib_FrontHookOn">前勾爪氣缸 ON 位置</param>
        /// <param name="ib_FrontHookOff">前勾爪氣缸 OFF 位置</param>
        /// <param name="ob_BackHook">後勾爪氣缸(靠近主機端)</param>
        /// <param name="ib_BackHookOn">後勾爪氣缸 ON 位置</param>
        /// <param name="ib_BackHookOff">後勾爪氣缸 OFF 位置</param>
        /// <param name="ob_Presure">板固定氣缸</param>
        /// <param name="ib_FrontPresureOn">板固定氣缸 ON 位置</param>
        /// <param name="ib_FrontPresureOff">板固定氣缸 OFF 位置</param>
        /// <param name="ob_CarrierGate">閘門氣缸</param>
        /// <param name="ib_CarrierGateUp">閘門氣缸 UP 位置</param>
        /// <param name="ib_CarrierGateDown">閘門氣缸 DOWN 位置</param>
        /// <param name="mo_AxisY">Y 軸馬達</param>
        /// <param name="barcodeReaderType">Barcode Reader Type</param>
        /// <param name="barcodeReaderComPort">Barcode Reader ComPort</param>
        public BemTransfer(
            AlarmCallback alarm,
            InBit ib_FrontTrackBIBDetector, InBit ib_BackTrackBIBDetector,
            InBit ib_FrontHookBIBDetector, InBit ib_BackHookBIBDetector,
            InBit ib_FrontCarrierBIBDetector, InBit ib_BackCarrierBIBDetector,
            InBit ib_TrackOpenLidDetector, InBit ib_LeftRackOpenLidDetector, InBit ib_RightRackOpenLidDetector,
            OutBit ob_AphaStepMotorAlarmReset,
            OutBit ob_FrontHook, InBit ib_FrontHookOn, InBit ib_FrontHookOff,
            OutBit ob_BackHook, InBit ib_BackHookOn, InBit ib_BackHookOff,
            OutBit ob_Presure, InBit ib_FrontPresureOn, InBit ib_FrontPresureOff, InBit ib_BackPresureOn, InBit ib_BackPresureOff,
            OutBit ob_CarrierGate, InBit ib_CarrierGateUp, InBit ib_CarrierGateDown,
            Motor mo_AxisY,
            BARCODE_READER_TYPE barcodeReaderType, byte barcodeReaderComPort)
            : base(alarm)
        {
            DI_FrontTrackBIBDetector = new DigitalInput(ib_FrontTrackBIBDetector);
            DI_BackTrackBIBDetector = new DigitalInput(ib_BackTrackBIBDetector);
            DI_FrontHookBIBDetector = new DigitalInput(ib_FrontHookBIBDetector);
            DI_BackHookBIBDetector = new DigitalInput(ib_BackHookBIBDetector);
            DI_FrontCarrierBIBDetector = new DigitalInput(ib_FrontCarrierBIBDetector);
            DI_BackCarrierBIBDetector = new DigitalInput(ib_BackCarrierBIBDetector);
            DI_TrackOpenLidDetector = new DigitalInput(ib_TrackOpenLidDetector);
            DI_LeftRackOpenLidDetector = new DigitalInput(ib_LeftRackOpenLidDetector);
            DI_RightRackOpenLidDetector = new DigitalInput(ib_RightRackOpenLidDetector);
            OB_AphaStepMotorAlarmReset = ob_AphaStepMotorAlarmReset;
            CY_FrontHook = new Cylinder(ob_FrontHook, ib_FrontHookOn, ib_FrontHookOff);
            CY_BackHook = new Cylinder(ob_BackHook, ib_BackHookOn, ib_BackHookOff);
            if (ib_BackPresureOn == null && ib_BackPresureOff == null)
            {
                CY_Pressure = new Cylinder(ob_Presure, ib_FrontPresureOn, ib_FrontPresureOff);
            }
            else
            {
                CY_Pressure = new Cylinder(ob_Presure, ib_FrontPresureOn, ib_FrontPresureOff);
                CY_Pressure2 = new Cylinder(ob_Presure, ib_BackPresureOn, ib_BackPresureOff);
                //  CY_PressureEx = new CylinderEx(ob_Presure, null, ib_FrontPresureOn, ib_BackPresureOn, ib_FrontPresureOff, ib_BackPresureOff);
            }
            CY_CarrierGate = new Cylinder(ob_CarrierGate, ib_CarrierGateDown, ib_CarrierGateUp);
            MO_AxisY = mo_AxisY;

            BarcodeReaderType = (byte)barcodeReaderType;
            BarcodeReaderComPort = barcodeReaderComPort;
        }

        ~BemTransfer()
        {
            this.Dispose();
        }

        public void Dispose()
        {
            if (DI_FrontTrackBIBDetector != null) DI_FrontTrackBIBDetector.Dispose();
            if (DI_BackTrackBIBDetector != null) DI_BackTrackBIBDetector.Dispose();
            if (DI_FrontHookBIBDetector != null) DI_FrontHookBIBDetector.Dispose();
            if (DI_BackHookBIBDetector != null) DI_BackHookBIBDetector.Dispose();
            if (DI_FrontCarrierBIBDetector != null) DI_FrontCarrierBIBDetector.Dispose();
            if (DI_BackCarrierBIBDetector != null) DI_BackCarrierBIBDetector.Dispose();
            if (DI_TrackOpenLidDetector != null) DI_TrackOpenLidDetector.Dispose();
            if (DI_LeftRackOpenLidDetector != null) DI_LeftRackOpenLidDetector.Dispose();
            if (DI_RightRackOpenLidDetector != null) DI_RightRackOpenLidDetector.Dispose();
            if (OB_AphaStepMotorAlarmReset != null) OB_AphaStepMotorAlarmReset.Dispose();
            if (CY_BackHook != null) CY_BackHook.Dispose();
            if (CY_FrontHook != null) CY_FrontHook.Dispose();
            if (CY_Pressure != null) CY_Pressure.Dispose();
            if (CY_Pressure2 != null) CY_Pressure2.Dispose();
            if (CY_CarrierGate != null) CY_CarrierGate.Dispose();
            if (MO_AxisY != null) MO_AxisY.Dispose();
        }

        #endregion 建構與解構

        #region 私有函式

        private void ShowModuleAlarm(int ret)//模組Alarm
        {
            this.ShowAlarm(ret);
        }

        private void ClearModuleAlarm(int ret)
        {
            this.ClearAlarm(ret);
        }

        /// <summary>
        /// 前勾板氣缸上升
        /// </summary>
        /// <returns></returns>
        private bool FrontHookUp()
        {
            bool bRet = false;
            if (CY_FrontHook != null)
            {
                ThreeValued tRet = CY_FrontHook.On(iHookUpDelayTime, 6000);
                if (tRet.Equals(ThreeValued.TRUE) || Simulation)
                {
                    //設為低速
                    MO_AxisY.SetSpeed(Math.Min(AxisYSpeedHigh, AxisYSpeedLow));
                    bRet = true;
                }
                else if (tRet.Equals(ThreeValued.FALSE))
                {
                    //Alarm : 前勾板氣缸上升動作逾時
                    ShowModuleAlarm((int)BEMAlarmCode.ArmBemTransferFrontHookUpTimeout);
                }
            }
            else
            {
                //Alarm : 前勾板氣缸元件未初始化
                ShowModuleAlarm((int)BEMAlarmCode.ArmBemTransferFrontHookNull);
            }
            return bRet;
        }

        /// <summary>
        /// 後勾板氣缸上升
        /// </summary>
        /// <returns></returns>
        private bool BackHookUp()
        {
            bool bRet = false;
            if (CY_BackHook != null)
            {
                ThreeValued tRet = CY_BackHook.On(iHookUpDelayTime, 6000);
                if (tRet.Equals(ThreeValued.TRUE) || Simulation)
                {
                    //設為低速
                    MO_AxisY.SetSpeed(Math.Min(AxisYSpeedHigh, AxisYSpeedLow));
                    bRet = true;
                }
                else if (tRet.Equals(ThreeValued.FALSE))
                {
                    //Alarm : 後勾板氣缸上升動作逾時
                    ShowModuleAlarm((int)BEMAlarmCode.ArmBemTransferBackHookUpTimeout);
                }
            }
            else
            {
                //Alarm : 後勾板氣缸元件未初始化
                ShowModuleAlarm((int)BEMAlarmCode.ArmBemTransferBackHookNull);
            }
            return bRet;
        }

        /// <summary>
        /// 前勾板氣缸下降
        /// </summary>
        /// <returns></returns>
        private bool FrontHookDown()
        {
            bool bRet = false;
            if (CY_FrontHook != null)
            {
                ThreeValued tRet = CY_FrontHook.Off(iHookDownDelayTime, 6000);
                if (tRet.Equals(ThreeValued.TRUE) || this.Simulation)
                {
                    bRet = true;
                }
                else if (tRet.Equals(ThreeValued.FALSE))
                {
                    //Alarm : 前勾板氣缸下降動作逾時
                    ShowModuleAlarm((int)BEMAlarmCode.ArmBemTransferFrontHookDownTimeout);
                }
            }
            else
            {
                //Alarm : 前勾板氣缸元件未初始化
                ShowModuleAlarm((int)BEMAlarmCode.ArmBemTransferFrontHookNull);
            }
            return bRet;
        }

        /// <summary>
        /// 後勾板氣缸下降
        /// </summary>
        /// <returns></returns>
        private bool BackHookDown()
        {
            bool bRet = false;
            if (CY_BackHook != null)
            {
                ThreeValued tRet = CY_BackHook.Off(iHookDownDelayTime, 6000);
                if (tRet.Equals(ThreeValued.TRUE) || this.Simulation)
                {
                    bRet = true;
                }
                else if (tRet.Equals(ThreeValued.FALSE))
                {
                    //Alarm : 後勾板氣缸下降動作逾時
                    ShowModuleAlarm((int)BEMAlarmCode.ArmBemTransferBackHookDownTimeout);
                }
            }
            else
            {
                //Alarm : 後勾板氣缸元件未初始化
                ShowModuleAlarm((int)BEMAlarmCode.ArmBemTransferBackHookNull);
            }
            return bRet;
        }

        /// <summary>
        /// 控制 夾盤氣缸
        /// </summary>
        public bool Control_CyPressure(bool IsUp, int delayT = 200, int alarmT = 6000)
        {
            if (this.Simulation) return true;

            if (CY_Pressure == null)  //部分供板機無Pressure氣缸，直接回傳true
                return true;

            ThreeValued t1, t2 = ThreeValued.UNKNOWN;
            if (IsUp)
            {
                t1 = CY_Pressure.Off(delayT, alarmT);
                t2 = CY_Pressure2 == null ? ThreeValued.TRUE : CY_Pressure2.Off(delayT, alarmT);
            }
            else
            {
                t1 = CY_Pressure.On(delayT, alarmT);
                t2 = CY_Pressure2 == null ? ThreeValued.TRUE : CY_Pressure2.On(delayT, alarmT);
            }

            if (t1.Equals(ThreeValued.TRUE) && t2.Equals(ThreeValued.TRUE))
            {
                return true;
            }
            else if (t1.Equals(ThreeValued.FALSE) || t2.Equals(ThreeValued.FALSE))
            {
                if (IsUp)
                    ShowModuleAlarm((int)BEMAlarmCode.ArmBemTransferPressureUpTimeout);
                else
                    ShowModuleAlarm((int)BEMAlarmCode.ArmBemTransferPressureDownTimeout);
            }
            return false;
        }


        /// <summary>
        /// 板固定氣缸上升(板釋放)
        /// </summary>
        /// <returns></returns>
        private bool PressureUp()
        {
            return Control_CyPressure(true);

            //bool bRet = false;
            //if (CY_Pressure != null)
            //{
            //    ThreeValued tRet = CY_Pressure.Off(iPressureUpDelayTime, 6000);
            //    if (tRet.Equals(ThreeValued.TRUE) || this.Simulation)
            //    {
            //        bRet = true;
            //    }
            //    else if (tRet.Equals(ThreeValued.FALSE))
            //    {
            //        //Alarm : 前勾板氣缸下降動作逾時
            //        ShowModuleAlarm((int)BEMAlarmCode.ArmBemTransferPressureUpTimeout);
            //    }
            //}
            //else
            //{
            //    //部分供板機無Pressure氣缸，直接回傳true
            //    bRet = true;
            //}
            //return bRet;
        }

        /// <summary>
        /// 板下壓氣缸下降(板固定)
        /// </summary>
        /// <returns></returns>
        private bool PressureDown()
        {
            return Control_CyPressure(false);

            //bool bRet = false;
            //if (CY_Pressure.Simulation.Equals(true))
            //{
            //    return true;
            //}
            //if (CY_Pressure != null)
            //{
            //    ThreeValued tRet = CY_Pressure.On(iPressureDownDelayTime, 6000);
            //    if (tRet.Equals(ThreeValued.TRUE) || this.Simulation)
            //    {
            //        bRet = true;
            //    }
            //    else if (tRet.Equals(ThreeValued.FALSE))
            //    {
            //        //Alarm : 後勾板氣缸下降動作逾時
            //        ShowModuleAlarm((int)BEMAlarmCode.ArmBemTransferPressureDownTimeout);
            //    }
            //}
            //else
            //{
            //    //部分供板機無Pressure氣缸，直接回傳true
            //    bRet = true;
            //}
            //return bRet;
        }

        /// <summary>
        /// 台車閘門氣缸控制
        /// </summary>
        /// <param name="val"><c>true</c> : 台車閘門下降，<c>false</c> : 台車閘門上升</param>
        /// <returns>控制結果</returns>
        private bool CarrierGateCtrl(bool val)
        {
            if (CY_CarrierGate.Equals(null))
            {
                return true;
            }

            ThreeValued crRet = ThreeValued.UNKNOWN;
            if (val)
            {
                crRet = CY_CarrierGate.On(80, 6000);
            }
            else
            {
                crRet = CY_CarrierGate.Off(80, 6000);
            }

            if (crRet.Equals(ThreeValued.TRUE) || DryRun || Simulation)
            {
                return true;
            }
            else if (crRet.Equals(ThreeValued.FALSE))
            {
                //Alarm : 台車閘門氣缸動作逾時
                if (val)
                {
                    ShowModuleAlarm((int)BEMAlarmCode.ArmBemCarrierOpenGateTimeout);
                }
                else
                {
                    ShowModuleAlarm((int)BEMAlarmCode.ArmBemCarrierCloseGateTimeout);
                }
            }
            return false;
        }

        /// <summary>
        /// 前後勾板氣缸下降
        /// </summary>
        /// <returns></returns>
        private bool AllHookDown()
        {
            bool bRet1 = FrontHookDown();
            bool bRet2 = BackHookDown();
            if (bRet1 && bRet2)
            {
                //設為高速
                MO_AxisY.SetSpeed(Math.Max(AxisYSpeedHigh, AxisYSpeedLow));
                return true;
            }
            return false;
        }

        /// <summary>
        /// Y軸馬達移動到目標位置
        /// </summary>
        /// <param name="position">移動的目標位置</param>
        /// <returns><c>true</c>: 成功移動到目標位置</returns>
        private bool AxisYGoto(int position)
        {
            bool bRet = false;
            if (MO_AxisY != null)
            {
                if (MO_AxisY.G00(position))
                {
                    bRet = true;
                }
            }
            else
            {
                //Alarm : Y 軸馬達元件未初始化
                ShowModuleAlarm((int)BEMAlarmCode.ArmBemTransferAxisYNull);
            }
            return bRet;
        }

        /// <summary>
        /// 勾板前檢查勾爪上方有板或無板 (Sensor A接點)
        /// <para>從推車進板流程</para>
        /// </summary>
        /// <param name="bState">true : 判斷有板，false : 判斷無板</param>
        /// <returns></returns>
        private bool CheckCarrierBoardExists(bool bState)
        {
            if (DryRun || DI_FrontHookBIBDetector == null)
            {
                return true;
            }
            bool B1 = false;
            if (bState)
            {
                B1 = DI_FrontHookBIBDetector.ValueOn;
            }
            else
            {
                B1 = DI_FrontHookBIBDetector.ValueOff;
            }
            return B1;
        }

        /// <summary>
        /// 勾板前檢查勾爪上方有板或無板 (Sensor A接點)
        /// <para>從主機收板流程</para>
        /// </summary>
        /// <param name="bState">true : 判斷有板，false : 判斷無板</param>
        /// <returns></returns>
        private bool CheckBoardStageBoardExists(bool bState)
        {
            if (DryRun || DI_BackHookBIBDetector == null)
            {
                return true;
            }
            bool B1 = false;
            if (bState)
            {
                B1 = DI_BackHookBIBDetector.ValueOn;
            }
            else
            {
                B1 = DI_BackHookBIBDetector.ValueOff;
            }
            return B1;
        }

        #endregion 私有函式

        #region 公有函式

        /// <summary>
        /// 判斷平台內有板或無板 (Sensor B接點)
        /// <para>為了因應空跑功能，所以必須在屬性註明是判斷有板或無板，因為DryRun時一律回傳true</para>
        /// </summary>
        /// <param name="bState">true : 判斷有板，false : 判斷無板</param>
        /// <returns></returns>
        public bool StageBoardExists(bool bState)
        {
            if (DryRun)
            {
                return true;
            }
            bool B1 = false;
            bool B2 = false;
            if (bState)
            {
                //判斷是否有板，若有板則兩顆Sensor都被遮斷
                B1 = DI_FrontTrackBIBDetector.ValueOff;
                B2 = DI_BackTrackBIBDetector.ValueOff;
            }
            else
            {
                //判斷是否無板，若無板則兩顆Sensor都無被遮斷
                B1 = DI_FrontTrackBIBDetector.ValueOn;
                B2 = DI_BackTrackBIBDetector.ValueOn;
            }
            return (B1 && B2);
        }

        /// <summary>
        /// 推車內有板或無板 (Sensor A接點)
        /// <para>為了因應空跑功能，所以必須在屬性註明是判斷有板或無板，因為DryRun時一律回傳true</para>
        /// </summary>
        /// <param name="bState">true : 判斷有板，false : 判斷無板</param>
        /// <returns></returns>
        public bool CarrierBoardExists(bool bState)
        {
            if (DryRun || Simulation)
            {
                return true;
            }
            bool B1 = false;
            if (bState)
            {
                B1 = DI_FrontCarrierBIBDetector.ValueOn;
            }
            else
            {
                B1 = DI_FrontCarrierBIBDetector.ValueOff;
            }
            return B1;
        }

        /// <summary>
        /// 主機內有板或無板 (Sensor A接點)
        /// <para>為了因應空跑功能，所以必須在屬性註明是判斷有板或無板，因為DryRun時一律回傳true</para>
        /// </summary>
        /// <param name="bState">true : 判斷有板，false : 判斷無板</param>
        /// <returns></returns>
        public bool BoardStageBoardExists(bool bState)
        {
            if (DryRun || Simulation)
            {
                return true;
            }
            bool B1 = false;
            if (bState)
            {
                B1 = DI_BackCarrierBIBDetector.ValueOn;
            }
            else
            {
                B1 = DI_BackCarrierBIBDetector.ValueOff;
            }
            return B1;
        }

        /// <summary>
        /// 軌道上開蓋偵測 (Sensor B接點)
        /// <para>為了因應空跑功能，所以必須在屬性註明是判斷有無開蓋，因為DryRun時一律回傳true</para>
        /// </summary>
        /// <param name="bState">true : 判斷有開蓋，false : 判斷無開蓋</param>
        /// <returns></returns>
        public bool TrackOpenLidDetector(bool bState)
        {
            if (DryRun || DI_TrackOpenLidDetector == null)
            {
                return true;
            }
            bool bRet = false;
            if (bState)
            {
                //判斷是否有開蓋，若有開蓋則Sensor被遮斷
                bRet = DI_TrackOpenLidDetector.ValueOff;
            }
            else
            {
                //判斷是否無開蓋，若無板則Sensor都無被遮斷
                bRet = DI_TrackOpenLidDetector.ValueOn;
            }
            return bRet;
        }

        /// <summary>
        /// RACK拉盤中開蓋偵測 (Sensor B接點)
        /// <para>為了因應空跑功能，所以必須在屬性註明是判斷有無開蓋，因為DryRun時一律回傳true</para>
        /// </summary>
        /// <param name="bState">true : 判斷有開蓋，false : 判斷無開蓋</param>
        /// <returns></returns>
        public bool RackOpenLidDetector(bool bState)
        {
            if (DryRun)
            {
                return true;
            }
            bool bLeftRet = false;
            bool bRightRet = false;
            if (bState)
            {
                //判斷是否有開蓋，若有開蓋則Sensor被遮斷
                bLeftRet = DI_LeftRackOpenLidDetector == null ? true : DI_LeftRackOpenLidDetector.ValueOff;
                bRightRet = DI_RightRackOpenLidDetector == null ? true : DI_RightRackOpenLidDetector.ValueOff;
            }
            else
            {
                //判斷是否無開蓋，若無開蓋則Sensor都無被遮斷
                bLeftRet = DI_LeftRackOpenLidDetector == null ? true : DI_LeftRackOpenLidDetector.ValueOn;
                bRightRet = DI_RightRackOpenLidDetector == null ? true : DI_RightRackOpenLidDetector.ValueOn;
            }
            return bLeftRet && bRightRet;
        }

        #endregion 公有函式

        #region 動作流程

        /// <summary>
        /// 資料重置
        /// </summary>
        public void DataReset()
        {
            //重置變數

            TaskReset();
            HomeReset();
        }

        /// <summary>
        /// 讀取板號流程重置
        /// </summary>
        public void ReadBIDTaskReset()
        {
            BID = "";
            ReadBIDTask.Reset();
            BarcodeReader.ReadBarcodeTaskReset();
        }

        /// <summary>
        /// 讀取板號流程
        /// </summary>
        /// <returns>
        ///     <c>#BUSY#</c> : BUSY
        ///     <c>!ERROR!</c> : ERROR
        ///     <c>!TIMEOUT!</c> : TIMEOUT
        ///     <c>string</c> : barcode
        /// </returns>
        public bool ReadBIDProcess()
        {
            if (!ReadBID || BarcodeReaderType.Equals(0) || BarcodeReaderComPort.Equals(0))
            {
                BID = "";
                return true;
            }

            bool bRet = false;
            JActionTask Task = ReadBIDTask;
            switch (Task.Value)
            {
                case 0: //Open Com Port
                    {
                        if (BarcodeReader.Open(BarcodeReaderType, BarcodeReaderComPort))
                        {
                            BarcodeReader.ReadBarcodeTaskReset();
                            Task.Next();
                        }
                        else
                        {
                            //Alarm : 條碼槍通訊埠開啟失敗 (請確認埠號設定是否正確)
                            ShowModuleAlarm((int)BEMAlarmCode.ArmBemTransferBarcodeReaderComPortError);
                        }
                    }
                    break;

                case 1: //Barcode Reader - ReadBarcode()
                    {
                        string sRet = BarcodeReader.ReadBarcode();
                        if (sRet != "#BUSY#")
                        {
                            BID = sRet;
                            Task.Next();
                        }
                    }
                    break;

                case 2: //Close Com Port
                    {
                        BarcodeReader.Close();
                        Task.Next(99);
                    }
                    break;

                case 99:    //Done
                    {
                        bRet = true;
                    }
                    break;
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
        /// 移動到讀取BarCode點 (呼叫此函式前，記得先呼叫 TaskReset() 函式重置 Task)
        /// </summary>
        /// <returns></returns>
        public bool GotoDetectCarrierDiePakBarCodePosition()
        {
            bool bRet = false;
            JActionTask Task = AutoTask;
            switch (Task.Value)
            {
                case 0:
                    {   //DiePak下壓氣缸下降                            
                        if (PressureDown())
                        {
                            Task.Next();
                        }
                    }
                    break;
                case 1:
                    {	//後勾板氣缸上升
                        if (BackHookUp())
                        {
                            Task.Next();
                        }
                    }
                    break;
                case 2:
                    {   //DiePak下壓氣缸上升                            
                        if (PressureUp())
                        {
                            Task.Next();
                        }
                    }
                    break;
                case 3:
                    {   //Y 軸移至讀取 BarCode點位
                        if (AxisYGoto(this.ReadBarCodePosition))
                        {
                            Task.Next();
                        }
                    }
                    break;
                case 4:
                    {   //DiePak下壓氣缸下降                            
                        if (PressureDown())
                        {
                            Task.Next();
                        }
                    }
                    break;
                case 5: //完成
                    {
                        bRet = true;
                    }
                    break;
            }

            return bRet;
        }

        /// <summary>
        /// 移動到讀取BarCode後回安全點點 (呼叫此函式前，記得先呼叫 TaskReset() 函式重置 Task)
        /// </summary>
        /// <returns></returns>
        public bool GotoDetectCarrierDiePakBarCodePositionSafe()
        {
            bool bRet = false;
            JActionTask Task = AutoTask;
            switch (Task.Value)
            {
                case 0:
                    {   //DiePak下壓氣缸上升                            
                        if (PressureUp())
                        {
                            Task.Next();
                        }
                    }
                    break;
                case 1:
                    {   //Y 軸移至安全等待點
                        if (AxisYGoto(this.WaitingPosition))
                        {
                            Task.Next();
                        }
                    }
                    break;
                case 2:
                    {   //DiePak下壓氣缸下降                            
                        if (PressureDown())
                        {
                            Task.Next();
                        }
                    }
                    break;
                case 3:
                    {	//前後勾板氣缸下降
                        if (AllHookDown())
                        {
                            Task.Next();
                        }
                    }
                    break;
                case 4: //完成
                    {
                        bRet = true;
                    }
                    break;
            }

            return bRet;
        }

        /// <summary>
        /// 移動至推車有無板偵測點 (呼叫此函式前，記得先呼叫 TaskReset() 函式重置 Task)
        /// </summary>
        /// <returns></returns>
        public bool GotoDetectCarrierBoardPosition(bool bState, out bool bResult)
        {
            bResult = false;
            bool bRet = false;
            JActionTask Task = AutoTask;
            switch (Task.Value)
            {
                case 0: //如有板下壓氣缸，先做下壓在做偵測(退板偵測時有板)
                    {
                        if (PressureDown())
                        {
                            Task.Next();
                        }
                    }
                    break;
                case 1: //前/後勾板氣缸下降
                    {
                        if (AllHookDown())
                        {
                            Task.Next();
                        }
                    }
                    break;

                case 2: //Y 軸移至推車有無板偵測點
                    {
                        if (AxisYGoto(this.DetectCarrierBIBPosition))
                        {
                            Task.Next();
                        }
                    }
                    break;

                case 3: //判斷有無板
                    {
                        bResult = CarrierBoardExists(bState);
                        bRet = true;
                    }
                    break;

                    //case 4: //Y 軸移至安全位置
                    //    {
                    //        if (AxisYGoto(this.WaitingPosition))
                    //        {
                    //            Task.Next();
                    //        }
                    //    }
                    //    break;

                    //case 5: //完成
                    //    {

                    //        bRet = true;
                    //    }
                    //    break;
            }
            return bRet;
        }

        /// <summary>
        /// 移動至主機有無板偵測點 (呼叫此函式前，記得先呼叫 TaskReset() 函式重置 Task)
        /// </summary>
        /// <returns></returns>
        public bool GotoDetectBoardStageBoardPosition(bool bState, out bool bResult)
        {
            bResult = false;
            bool bRet = false;
            JActionTask Task = AutoTask;
            switch (Task.Value)
            {
                case 0: //如有板下壓氣缸，先做下壓在做偵測(退板偵測時有板)
                    {
                        if (PressureDown())
                        {
                            Task.Next();
                        }
                    }
                    break;
                case 1: //前/後勾板氣缸下降
                    {
                        if (AllHookDown())
                        {
                            Task.Next();
                        }
                    }
                    break;

                case 2: //Y 軸移至主機有無板偵測點
                    {
                        if (AxisYGoto(this.DetectBoardStageBIBPosition))
                        {
                            Task.Next();
                        }
                    }
                    break;

                case 3: //判斷有無板
                    {
                        bResult = BoardStageBoardExists(bState);
                        bRet = true;
                    }
                    break;

                    //case 4: //Y 軸移至安全位置
                    //    {
                    //        if (AxisYGoto(this.WaitingPosition))
                    //        {
                    //            Task.Next();
                    //        }
                    //    }
                    //    break;

                    //case 5: //完成
                    //    {

                    //        bRet = true;
                    //    }
                    //    break;
            }
            return bRet;
        }

        /// <summary>
        /// 從推車進板流程 (呼叫此函式前，記得先呼叫 TaskReset() 函式重置 Task)
        /// </summary>
        /// <param name="offset">勾爪Y軸補償值</param>
        /// <returns></returns>
        public bool PullInBoardFromCarrier(int offset = 0)
        {
            bool bRet = false;
            JActionTask Task = AutoTask;
            switch (Task.Value)
            {
                case 0: //前後勾板氣缸下降
                    {
                        if (AllHookDown())
                        {
                            iYPosOffset = 0;
                            Task.Next();
                        }
                    }
                    break;
                case 1: //DiePak下壓氣缸上升
                    {
                        if (PressureUp())
                        {
                            iYPosOffset = 0;
                            Task.Next();
                        }
                    }
                    break;
                case 2: //Y 軸移動至推車進板點
                    {
                        int pos = PullInBIBPosition + iYPosOffset + offset;
                        if (AxisYGoto(pos))
                        {
                            Task.Next();
                        }
                    }
                    break;

                case 3: //判斷有無板，無板則回 case 3 (Offset + 1000)
                    {
                        if (CheckCarrierBoardExists(true))
                        {
                            Task.Next();
                        }
                        else
                        {
                            if (iYPosOffset < 3000)
                            {
                                iYPosOffset += 1000;
                                Task.Next(1);
                            }
                            else
                            {
                                //推車無板，勾板失敗
                                Task.Next(14);   //Y 軸移至安全等待點
                            }
                        }
                    }
                    break;

                case 4: //前勾板氣缸上升
                    {
                        if (FrontHookUp())
                        {
                            Task.Next();
                        }
                    }
                    break;

                case 5:    //推車閘門向上開啟
                    {
                        if (CarrierGateCtrl(true))
                        {
                            Task.Next();
                        }
                    }
                    break;
                case 6: //Y 軸移至主機端送板點 (暫時借用此點位，因為此點位最靠近極限)
                    {
                        if (RackOpenLidDetector(false))
                        {
                            if (AxisYGoto(SendBIBPosition))
                            {
                                Task.Next();
                            }
                        }
                        else
                        {
                            //Alarm : 從推車進板流程偵測到RACK開蓋異常，請確認是否開蓋
                            ShowModuleAlarm((int)BEMAlarmCode.ArmBemTransferRackLidDetectErrorCT);
                        }
                    }
                    break;

                case 7: //Diepak 下壓氣缸下壓
                    {
                        if (PressureDown())
                        {
                            Task.Next();
                        }
                    }
                    break;
                case 8: //前後勾板氣缸下降
                    {
                        if (AllHookDown())
                        {
                            Task.Next();
                        }
                    }
                    break;

                case 9: //Y 軸前進一個勾爪距離(即主機端送板點-勾爪距離-1000)
                    {
                        //多退 1000 避免勾爪與板框摩擦
                        int pos = SendBIBPosition - DistanceOfHook - 1000;
                        if (AxisYGoto(pos))
                        {
                            Task.Next();
                        }
                    }
                    break;

                case 10: //後勾板氣缸上升
                    {
                        if (BackHookUp())
                        {
                            Task.Next();
                        }
                    }
                    break;

                case 11: //DiePak 下壓氣上升
                    {
                        if (PressureUp())
                        {
                            Task.Next();
                        }
                    }
                    break;
                case 12: //移動至讀取板號位置
                    {
                        if (ReadBIDMode.Equals(0) && ReadBID)
                        {
                            if (AxisYGoto(ReadBarCodePosition))
                            {
                                ReadBIDTaskReset();
                                Task.Next();
                            }
                        }
                        else
                        {
                            Task.Next(14);
                        }
                        //if (!ReadBID || AxisYGoto(ReadBarCodePosition))
                        //{
                        //    ReadBIDTaskReset();
                        //    Task.Next();
                        //}
                    }
                    break;

                case 13: //讀取板號
                    {
                        if (ReadBIDProcess())
                        {
                            Task.Next();
                        }
                    }
                    break;

                case 14: //Y 軸移至安全等待點
                    {
                        if (AxisYGoto(WaitingPosition))
                        {
                            Task.Next();
                        }
                    }
                    break;

                case 15: //推車閘門向下關閉
                    {
                        if (CarrierGateCtrl(false))
                        {
                            Task.Next();
                        }
                    }
                    break;
                case 16:    //DiePak 下壓氣缸下壓
                    {
                        if (PressureDown())
                        {
                            Task.Next();
                        }
                    }
                    break;
                case 17: //前後勾板氣缸下降
                    {
                        Task.Next();    //後續動作仍需後勾爪上升，此處不做下降
                        //if (AllHookDown())
                        //{
                        //    Task.Next();
                        //}
                    }
                    break;

                case 18: //判斷平台內有無板 (B接點)
                    {
                        if (StageBoardExists(true))
                        {
                            Task.Next(99);
                        }
                        else
                        {
                            //Alarm : 從推車進板流程偵測到平台內板異常，請確認是否卡板
                            ShowModuleAlarm((int)BEMAlarmCode.ArmBemTransferTrackBIBDetectErrorCT);
                        }
                    }
                    break;

                case 99:    //完成
                    {
                        bRet = true;
                    }
                    break;
            }
            return bRet;
        }

        /// <summary>
        /// 退板至推車流程 (呼叫此函式前，記得先呼叫 TaskReset() 函式重置 Task)
        /// </summary>
        /// <returns></returns>
        public bool PushOutBoardToCarrier()
        {
            bool bRet = false;
            JActionTask Task = AutoTask;
            switch (Task.Value)
            {
                case 0: //DiePak 下壓氣缸下壓
                    {
                        if (PressureDown())
                        {
                            Task.Next();
                        }
                    }
                    break;
                case 1: //前後勾板氣缸下降
                    {
                        if (AllHookDown())
                        {
                            Task.Next();
                        }
                    }
                    break;

                case 2: //Y 軸移至安全等待點
                    {
                        int pos = (WaitingPosition - 1000);
                        if (AxisYGoto(pos))
                        {
                            Task.Next();
                        }
                    }
                    break;

                case 3: //後勾板氣缸上升
                    {
                        if (BackHookUp())
                        {
                            Task.Next();
                        }
                    }
                    break;

                case 4: //DiePak 下壓氣缸下壓
                    {
                        if (PressureUp())
                        {
                            Task.Next();
                        }
                    }
                    break;

                case 5: //推車閘門氣缸向上開啟
                    {
                        if (CarrierGateCtrl(true))
                        {
                            Task.Next();
                        }
                    }
                    break;
                case 6: //Y 軸移動至推車退板點
                    {
                        if (RackOpenLidDetector(false))
                        {
                            if (AxisYGoto(PushOutBIBPosition))
                            {
                                Task.Next();
                            }
                        }
                        else
                        {
                            Task.Next(101); //後勾爪動作中偵測到開蓋異常，退回等待位置，並發生異常
                        }
                    }
                    break;

                case 7: //DiePak下壓氣缸下壓
                    {
                        if (PressureDown())
                        {
                            Task.Next();
                        }
                    }
                    break;

                case 8: //前後勾板氣缸下降
                    {
                        if (AllHookDown())
                        {
                            Task.Next();
                        }
                    }
                    break;

                case 9: //Y 軸移動至推車退板點 + DistanceOfHook
                    {
                        int pos = (PushOutBIBPosition + DistanceOfHook - 1000);
                        if (AxisYGoto(pos))
                        {
                            Task.Next();
                        }
                    }
                    break;

                case 10: //前勾板氣缸上升
                    {
                        if (FrontHookUp())
                        {
                            Task.Next();
                        }
                    }
                    break;

                case 11: //DiePak下壓氣缸上升
                    {
                        if (PressureUp())
                        {
                            Task.Next();
                        }
                    }
                    break;

                case 12: //Y 軸移動至推車退板點
                    {
                        if (RackOpenLidDetector(false))
                        {
                            if (AxisYGoto(PushOutBIBPosition))
                            {
                                Task.Next();
                            }
                        }
                        else
                        {
                            Task.Next(111); //前勾爪動作中偵測到開蓋異常，Y 軸移動至推車退板點 + DistanceOfHook，並發生異常
                        }
                    }
                    break;

                case 13: //推車閘門向下關閉
                    {
                        if (CarrierGateCtrl(false))
                        {
                            Task.Next();
                        }
                    }
                    break;

                case 14: //前後勾板氣缸下降
                    {
                        if (AllHookDown())
                        {
                            Task.Next();
                        }
                    }
                    break;

                case 15: //Y 軸移至安全等待點
                    {
                        if (AxisYGoto(WaitingPosition))
                        {
                            Task.Next();
                        }
                    }
                    break;

                case 16:    //判斷平台內有無板
                    {
                        if (StageBoardExists(false))
                        {
                            //bBoardExists = false;
                            Task.Next(99);
                        }
                        else
                        {
                            //Alarm : 退板至推車流程偵測到平台內板異常，請確認是否卡板
                            ShowModuleAlarm((int)BEMAlarmCode.ArmBemTransferTrackBIBDetectErrorTC);
                        }
                    }
                    break;

                case 99:    //完成
                    {
                        bRet = true;
                    }
                    break;

                case 101: //後勾爪動作中偵測到開蓋異常，Y 軸移至安全等待點，並發生異常
                    {
                        int pos = (WaitingPosition - 1000);
                        if (AxisYGoto(pos))
                        {
                            //Alarm : 退板至推車流程偵測到RACK開蓋異常，請確認是否開蓋
                            ShowModuleAlarm((int)BEMAlarmCode.ArmBemTransferRackLidDetectErrorTC);
                            Task.Next(6); //Y 軸移動至推車退板點
                        }
                    }
                    break;

                case 111: //前勾爪動作中偵測到開蓋異常，Y 軸移動至推車退板點 + DistanceOfHook，並發生異常
                    {
                        int pos = (PushOutBIBPosition + DistanceOfHook - 1000);
                        if (AxisYGoto(pos))
                        {
                            //Alarm : 退板至推車流程偵測到RACK開蓋異常，請確認是否開蓋
                            ShowModuleAlarm((int)BEMAlarmCode.ArmBemTransferRackLidDetectErrorTC);
                            Task.Next(12); //Y 軸移動至推車退板點
                        }
                    }
                    break;
            }
            return bRet;
        }

        /// <summary>
        /// 送板至主機流程 (呼叫此函式前，記得先呼叫 TaskReset() 函式重置 Task)
        /// </summary>
        /// <returns></returns>
        public bool SendBoardToBoardStage()
        {
            bool bRet = false;
            JActionTask Task = AutoTask;
            switch (Task.Value)
            {
                case 0: //DiePak下壓氣缸下降
                    {
                        if (PressureDown())
                        {
                            Task.Next();
                        }
                    }
                    break;
                case 1: //前後勾板氣缸下降
                    {
                        if (AllHookDown())
                        {
                            Task.Next();
                        }
                    }
                    break;

                case 2: //Y 軸移至安全等待點
                    {
                        if (AxisYGoto(WaitingPosition))
                        {
                            Task.Next();
                        }
                    }
                    break;

                case 3: //後勾板氣缸上升
                    {
                        if (BackHookUp())
                        {
                            Task.Next();
                        }
                    }
                    break;

                case 4: //板下壓氣缸上升
                    {
                        if (PressureUp())
                        {
                            Task.Next();
                        }
                    }
                    break;

                case 5: //Y 軸移至主機端送板點
                    {
                        if (TrackOpenLidDetector(false))
                        {
                            if (AxisYGoto(SendBIBPosition))
                            {
                                Task.Next();
                            }
                        }
                        else
                        {
                            Task.Next(101); //偵測到開蓋異常，Y 軸移至安全等待點，並發出警報
                        }
                    }
                    break;

                case 6: //DiePak下壓氣缸下降
                    {
                        if (PressureDown())
                        {
                            Task.Next();
                        }
                    }
                    break;

                case 7: //前後勾板氣缸下降
                    {
                        if (AllHookDown())
                        {
                            Task.Next();
                        }
                    }
                    break;

                case 8: //Y 軸移至安全等待點
                    {
                        if (AxisYGoto(WaitingPosition))
                        {
                            Task.Next();
                        }
                    }
                    break;

                case 9:
                    {		//判斷平台內有無板
                        bool B1 = DI_FrontTrackBIBDetector.ValueOn;	    //無遮斷 靠近手推台車
                        bool B2 = DI_BackTrackBIBDetector.ValueOff;		//遮斷 靠近主機
                        if (DryRun || (B1 && B2))
                        {
                            //bBoardExists = false;
                            Task.Next(99);
                        }
                        else
                        {
                            //Alarm : 送板至主機流程偵測到平台內板異常，請確認是否卡板
                            ShowModuleAlarm((int)BEMAlarmCode.ArmBemTransferTrackBIBDetectErrorTS);
                        }
                    }
                    break;

                case 99:    //完成
                    {
                        bRet = true;
                    }
                    break;

                case 101: //偵測到開蓋異常，Y 軸移至安全等待點，並發出警報
                    {
                        if (AxisYGoto(WaitingPosition))
                        {
                            //Alarm : 送板至主機流程偵測到平台內開蓋異常，請確認是否卡板
                            ShowModuleAlarm((int)BEMAlarmCode.ArmBemTransferTrackLidDetectErrorTS);
                            Task.Next(5); //Y 軸移至主機端送板點
                        }
                    }
                    break;
            }
            return bRet;
        }

        /// <summary>
        /// 送板至主機流程完成後，進行DiePak下壓氣缸上升 (呼叫此函式前，記得先呼叫 TaskReset() 函式重置 Task)
        /// </summary>
        /// <returns><c>true</c>: 動作完成，<c>false</c>: 動作中</returns>
        public bool AfterSendBoardToBoardStage()
        {
            bool bRet = false;
            JActionTask Task = AutoTask;
            switch (Task.Value)
            {
                case 0: //DiePak下壓氣缸上升
                    {
                        if (PressureUp())
                        {
                            Task.Next();
                        }
                    }
                    break;
                case 1:
                    {
                        bRet = true;
                    }
                    break;
            }
            return bRet;
        }

        /// <summary>
        /// 從主機收板流程前，進行DiePak下壓氣缸下降 (呼叫此函式前，記得先呼叫 TaskReset() 函式重置 Task)
        /// </summary>
        /// <returns><c>true</c>: 動作完成，<c>false</c>: 動作中</returns>
        public bool BeforeReceiveBoardFromBoardStage()
        {
            bool bRet = false;
            JActionTask Task = AutoTask;
            switch (Task.Value)
            {
                case 0: //前後勾板氣缸下降
                    {
                        if (AllHookDown())
                        {
                            Task.Next();
                        }
                    }
                    break;

                case 1: //Y軸移至安全等待點
                    {
                        if (AxisYGoto(WaitingPosition))
                        {
                            Task.Next();
                        }
                    }
                    break;

                case 2: //DiePak下壓氣缸下降
                    {
                        if (PressureDown())
                        {
                            Task.Next(99);
                        }
                    }
                    break;
                case 99:
                    {
                        bRet = true;
                    }
                    break;
            }
            return bRet;
        }

        /// <summary>
        /// 從主機收板流程 (呼叫此函式前，記得先呼叫 TaskReset() 函式重置 Task)
        /// </summary>
        /// <returns></returns>
        public bool ReceiveBoardFromBoardStage()
        {
            bool bRet = false;
            JActionTask Task = AutoTask;
            switch (Task.Value)
            {
                case 0: //前後勾板氣缸下降
                    {
                        if (AllHookDown())
                        {
                            Task.Next();
                        }
                    }
                    break;

                case 1: //Y 軸移至主機端收板點
                    {
                        if (AxisYGoto(ReceiveBIBPosition))
                        {
                            Task.Next();
                        }
                    }
                    break;

                case 2: //判斷有無板
                    {
                        if (CheckBoardStageBoardExists(true))
                        {
                            Task.Next();
                        }
                        else
                        {
                            //Alarm : 從主機收板流程偵測到勾板前無板，請確認是否卡板
                            ShowModuleAlarm((int)BEMAlarmCode.ArmBemTransferTrackBIBDetectErrorST);
                        }
                    }
                    break;

                case 3: //後勾板氣缸上升
                    {
                        if (BackHookUp())
                        {
                            Task.Next();
                        }
                    }
                    break;

                case 4: //DiePak 下壓氣缸上升
                    {
                        if (PressureUp())
                        {
                            Task.Next();
                        }
                    }
                    break;

                case 5: //Y 軸移至安全等待點
                    {
                        if (TrackOpenLidDetector(false))
                        {
                            if (AxisYGoto(WaitingPosition))
                            {
                                Task.Next();
                            }
                        }
                        else
                        {
                            Task.Next(101); //偵測到開蓋異常，Y 軸移至主機端收板點，並發出警報
                        }
                    }
                    break;

                case 6: //DiePak下壓氣缸下降
                    {
                        if (PressureDown())
                        {
                            Task.Next();
                        }
                    }
                    break;

                case 7:
                    {	//前後勾板氣缸下降
                        if (AllHookDown())
                        {
                            Task.Next();
                        }
                    }
                    break;

                case 8: //判斷平台內有無板
                    {
                        if (StageBoardExists(true))
                        {
                            //bBoardExists = true;    //2016/07/11 Jay Tsao
                            Task.Next(99);
                        }
                        else
                        {
                            //Alarm : 從主機收板流程偵測到平台內板異常，請確認是否卡板
                            ShowModuleAlarm((int)BEMAlarmCode.ArmBemTransferTrackBIBDetectErrorST);
                        }
                    }
                    break;

                case 99: //完成
                    {
                        bRet = true;
                    }
                    break;

                case 101: //偵測到開蓋異常，Y 軸移至主機端收板點，並發出警報
                    {
                        if (AxisYGoto(ReceiveBIBPosition))
                        {
                            //Alarm : 從主機收板流程偵測到平台內開蓋異常，請確認是否卡板
                            ShowModuleAlarm((int)BEMAlarmCode.ArmBemTransferTrackLidDetectErrorST);
                            Task.Next(5); //Y 軸移至安全等待點
                        }
                    }
                    break;
            }
            return bRet;
        }

        #endregion 動作流程

        #region 歸零流程

        /// <summary>
        /// 重置 HomeTask
        /// </summary>
        public void HomeReset()
        {
            HomeTask.Reset();   //Reset to zero.
            MO_AxisY.HomeReset();
        }

        /// <summary>
        /// 歸零 (呼叫此函式前，記得先呼叫 HomeReset() 函式)
        /// </summary>
        /// <returns></returns>
        public bool Home()
        {
            bool bRet = false;
            if (MO_AxisY != null)
            {
                JActionTask Task = HomeTask;
                switch (Task.Value)
                {
                    case 0:
                        {
                            Task.Next();
                        }
                        break;

                    case 1: //前後勾板氣缸下降
                        {
                            bool b1 = AllHookDown();
                            bool b2 = PressureDown();
                            bool b3 = CarrierGateCtrl(false);
                            //if (AllHookDown())
                            if (b1 && b2 && b3)
                            {
                                MO_AxisY.HomeReset();
                                Task.Next();
                            }
                        }
                        break;

                    case 2: //Y 軸歸零
                        {
                            if (MO_AxisY.Home())
                            {
                                Task.Next();
                            }
                        }
                        break;

                    case 3: //Y 軸移至安全等待點
                        {
                            if (AxisYGoto(WaitingPosition))
                            {
                                Task.Next();
                            }
                        }
                        break;

                    case 4:
                        {   //要確認下當有無板子此2個SENSOR偵測狀態    B偵測
                            if (StageBoardExists(false))
                            {
                                //bBoardExists = false;   //2016/07/11 Jay Tsao
                                Task.Next(99);
                            }
                            else
                            {
                                //Alarm : 歸零流程偵測到平台內有板，請手動將板移除
                                ShowModuleAlarm((int)BEMAlarmCode.ArmBemTransferBIBRemainInHoming);
                            }
                        }
                        break;

                    case 99: //完成
                        {
                            bRet = true;
                        }
                        break;
                }
            }
            else
            {
                //Alarm : Y 軸馬達元件未初始化
                ShowModuleAlarm((int)BEMAlarmCode.ArmBemTransferAxisYNull);
            }
            return bRet;
        }

        #endregion 歸零流程
    }
}