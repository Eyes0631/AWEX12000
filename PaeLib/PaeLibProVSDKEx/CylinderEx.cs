using PaeLibGeneral;
using ProVLib;
using System;

namespace PaeLibProVSDKEx
{
    /// <summary>
    /// 氣缸元件類別 Cylinder Component (必須搭配 ProVLib 的 InBit, OutBit 物件使用)
    /// </summary>
    public class CylinderEx : IDisposable
    {
        #region 私有變數

        private bool m_Simulation = false;
        private DigitalInput DI_On1 = null;     //氣缸 On Sensor
        private DigitalInput DI_On2 = null;     //氣缸 On Sensor
        private DigitalInput DI_On3 = null;     //氣缸 On Sensor
        private DigitalInput DI_On4 = null;     //氣缸 On Sensor
        private DigitalInput DI_Off1 = null;    //氣缸 Off Sensor
        private DigitalInput DI_Off2 = null;    //氣缸 Off Sensor
        private DigitalInput DI_Off3 = null;    //氣缸 Off Sensor
        private DigitalInput DI_Off4 = null;    //氣缸 Off Sensor
        private OutBit OB_On = null;          //氣缸控制 ON DO
        private OutBit OB_Off = null;          //氣缸控制 OFF DO

        #endregion 私有變數

        #region JCylinder 建構子

        /// <summary>
        /// Initializes a new instance of the <see cref="Cylinder"/> class.
        /// </summary>
        /// <param name="obOn">The ob on.</param>
        /// <param name="obOff">The ob off.</param>
        /// <param name="ibOn">The ib on.</param>
        /// <param name="ibOff">The ib off.</param>
        public CylinderEx(OutBit obOn, OutBit obOff, InBit ibOn1, InBit ibOn2, InBit ibOff1, InBit ibOff2)
        {
            m_Simulation = false;
            OB_On = obOn;
            OB_Off = obOff;
            DI_On1 = new DigitalInput(ibOn1);
            DI_On2 = new DigitalInput(ibOn2);
            DI_Off1 = new DigitalInput(ibOff1);
            DI_Off2 = new DigitalInput(ibOff2);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Cylinder"/> class.
        /// </summary>
        /// <param name="obOn">The ob on.</param>
        /// <param name="ibOn">The ib on.</param>
        /// <param name="ibOff">The ib off.</param>
        public CylinderEx(OutBit obOn, InBit ibOn1, InBit ibOn2, InBit ibOn3, InBit ibOn4, InBit ibOff1, InBit ibOff2, InBit ibOff3, InBit ibOff4)
        {
            OB_On = obOn;
            OB_Off = null;
            DI_On1 = new DigitalInput(ibOn1);
            DI_On2 = new DigitalInput(ibOn2);
            DI_On3 = new DigitalInput(ibOn3);
            DI_On4 = new DigitalInput(ibOn4);
            DI_Off1 = new DigitalInput(ibOff1);
            DI_Off2 = new DigitalInput(ibOff2);
            DI_Off3 = new DigitalInput(ibOff3);
            DI_Off4 = new DigitalInput(ibOff4);
        }

        #endregion JCylinder 建構子

        ~CylinderEx()
        {
            this.Dispose();
        }

        public void Dispose()
        {
            if (DI_On1 != null) DI_On1.Dispose();
            if (DI_On2 != null) DI_On2.Dispose();
            if (DI_On3 != null) DI_On3.Dispose();
            if (DI_On4 != null) DI_On4.Dispose();
            if (DI_Off1 != null) DI_Off1.Dispose();
            if (DI_Off2 != null) DI_Off2.Dispose();
            if (DI_Off3 != null) DI_Off3.Dispose();
            if (DI_Off4 != null) DI_Off4.Dispose();
        }

        #region 公用屬性

        /// <summary>
        /// 是否開啟模擬功能
        /// </summary>
        /// <value>
        ///   <c>true</c> if simulation; otherwise, <c>false</c>.
        /// </value>
        public bool Simulation
        {
            get { return m_Simulation; }
            set
            {
                m_Simulation = value;
                if (DI_On1 != null) DI_On1.Simulation = value;
                if (DI_On2 != null) DI_On2.Simulation = value;
                if (DI_On3 != null) DI_On3.Simulation = value;
                if (DI_On4 != null) DI_On4.Simulation = value;
                if (DI_Off1 != null) DI_Off1.Simulation = value;
                if (DI_Off2 != null) DI_Off2.Simulation = value;
                if (DI_Off3 != null) DI_Off3.Simulation = value;
                if (DI_Off4 != null) DI_Off4.Simulation = value;
            }
        }

        /// <summary>
        /// 取得氣缸 On Sensor 的 ON 訊號 (Read-Only)
        /// </summary>
        /// <value>
        ///   <c>true</c> if ON; otherwise, <c>false</c>.
        /// </value>
        public bool OnSensorValue
        {
            get
            {
                bool bRet = true;
                if (DI_On1 != null)
                    bRet &= DI_On1.ValueOn;
                if (DI_On2 != null)
                    bRet &= DI_On2.ValueOn;
                if (DI_On3 != null)
                    bRet &= DI_On3.ValueOn;
                if (DI_On4 != null)
                    bRet &= DI_On4.ValueOn;
                return bRet;
            }
        }

        /// <summary>
        /// 取得氣缸 Off Sensor 的 ON 訊號 (Read-Only)
        /// </summary>
        /// <value>
        ///   <c>true</c> if ON; otherwise, <c>false</c>.
        /// </value>
        public bool OffSensorValue
        {
            get
            {
                bool bRet = true;
                if (DI_On1 != null)
                    bRet &= DI_Off1.ValueOn;
                if (DI_On2 != null)
                    bRet &= DI_Off2.ValueOn;
                if (DI_On3 != null)
                    bRet &= DI_Off3.ValueOn;
                if (DI_On4 != null)
                    bRet &= DI_Off4.ValueOn;
                return bRet;
            }
        }

        /// <summary>
        /// 取得與設定控制氣缸 ON 的 DO 的 ON/OFF 訊號
        /// </summary>
        /// <value>
        ///   <c>true</c> if ON; otherwise, <c>false</c>.
        /// </value>
        public bool OnCtrlValue
        {
            get
            {
                if (!m_Simulation && (OB_On != null))
                {
                    return OB_On.Value;
                }
                return false;
            }
            set
            {
                if (!m_Simulation && (OB_On != null))
                {
                    OB_On.Value = value;
                }
                if (!m_Simulation && (OB_Off != null))
                {
                    OB_Off.Value = !value;
                }
            }
        }

        /// <summary>
        /// 取得與設定控制氣缸 OFF 的 DO 的 ON/OFF 訊號
        /// </summary>
        /// <value>
        ///   <c>true</c> if OFF; otherwise, <c>false</c>.
        /// </value>
        public bool OffCtrlValue
        {
            get
            {
                if (!m_Simulation && (OB_Off != null))
                {
                    return OB_Off.Value;
                }
                return false;
            }
            set
            {
                if (!m_Simulation && (OB_Off != null))
                {
                    OB_Off.Value = value;
                }
                if (!m_Simulation && (OB_On != null))
                {
                    OB_On.Value = !value;
                }
            }
        }

        #endregion 公用屬性

        #region 公用函式

        /// <summary>
        /// 設定氣缸控制的 DO 訊號為 ON
        /// </summary>
        /// <param name="on_ms">On delay time.</param>
        /// <param name="timeout_ms">等待 ON 的 timeout 時間.</param>
        /// <returns>
        /// ThreeValued.TRUE : 氣缸 On Sensor On，且持續 on_ms 時間
        /// ThreeValued.FALSE : 氣缸 On Sensor Off，且持續超過 timeout_ms 時間
        /// ThreeValued.UNKNOW : 氣缸 On Sensor On，但持續時間未達 on_ms，或氣缸 On Sensor Off，但持續時間未超過 timeout_ms
        /// </returns>
        public ThreeValued On(int on_ms = 0, int timeout_ms = 0)
        {
            this.OnCtrlValue = true;     //氣缸 ON

            ThreeValued tvRet1, tvRet2, tvRet3, tvRet4;

            tvRet1 = tvRet2 = tvRet3 = tvRet4 = ThreeValued.UNKNOWN;
            //if (DI_On1 != null)
            //    tvRet1 = DI_On1.On(on_ms, timeout_ms);
            //if (DI_On2 != null)
            //    tvRet2 = DI_On2.On(on_ms, timeout_ms);
            //if (DI_On3 != null)
            //    tvRet3 = DI_On3.On(on_ms, timeout_ms);
            //if (DI_On4 != null)
            //    tvRet4 = DI_On4.On(on_ms, timeout_ms);

            // modify by Terrell, 預防DI空物件會回傳ThreeValued.UNKNOWN
            tvRet1 = DI_On1 == null ? ThreeValued.TRUE : DI_On1.On(on_ms, timeout_ms);
            tvRet2 = DI_On2 == null ? ThreeValued.TRUE : DI_On2.On(on_ms, timeout_ms);
            tvRet3 = DI_On3 == null ? ThreeValued.TRUE : DI_On3.On(on_ms, timeout_ms);
            tvRet4 = DI_On4 == null ? ThreeValued.TRUE : DI_On4.On(on_ms, timeout_ms);

            ThreeValued tRet = RetResult(tvRet1, tvRet2, tvRet3, tvRet4);
            return tRet;
        }

        /// <summary>
        /// 設定氣缸控制的 DO 訊號為 OFF
        /// </summary>
        /// <param name="off_ms">Off delay time.</param>
        /// <param name="timeout_ms">等待 OFF 的 timeout 時間.</param>
        /// <returns>
        /// ThreeValued.TRUE : 氣缸 Off Sensor On，且持續 off_ms 時間
        /// ThreeValued.FALSE : 氣缸 Off Sensor Off，且持續超過 timeout_ms 時間
        /// ThreeValued.UNKNOW : 氣缸 Off Sensor On，但持續時間未達 off_ms，或氣缸 Off Sensor Off，但持續時間未超過 timeout_ms
        /// </returns>
        public ThreeValued Off(int off_ms = 0, int timeout_ms = 0)
        {
            this.OffCtrlValue = true;   //氣缸 ON

            ThreeValued tvRet1, tvRet2, tvRet3, tvRet4;

            tvRet1 = tvRet2 = tvRet3 = tvRet4 = ThreeValued.UNKNOWN;
            //if (DI_On1 != null)
            //    tvRet1 = DI_On1.Off(off_ms, timeout_ms);
            //if (DI_On2 != null)
            //    tvRet2 = DI_On2.Off(off_ms, timeout_ms);
            //if (DI_On3 != null)
            //    tvRet3 = DI_On3.Off(off_ms, timeout_ms);
            //if (DI_On4 != null)
            //    tvRet4 = DI_On4.Off(off_ms, timeout_ms);

            // modify by Terrell, 預防DI空物件會回傳ThreeValued.UNKNOWN
            tvRet1 = DI_Off1 == null ? ThreeValued.TRUE : DI_Off1.On(off_ms, timeout_ms);
            tvRet2 = DI_Off2 == null ? ThreeValued.TRUE : DI_Off2.On(off_ms, timeout_ms);
            tvRet3 = DI_Off3 == null ? ThreeValued.TRUE : DI_Off3.On(off_ms, timeout_ms);
            tvRet4 = DI_Off4 == null ? ThreeValued.TRUE : DI_Off4.On(off_ms, timeout_ms);

            ThreeValued tRet = RetResult(tvRet1, tvRet2, tvRet3, tvRet4);
            return tRet;
        }

        /// <summary>
        /// 關閉氣缸 ON 與 OFF DO
        /// </summary>
        public void Free()
        {
            if (!m_Simulation)
            {
                if (OB_On != null)
                {
                    OB_On.Value = false;
                }
                if (OB_Off != null)
                {
                    OB_Off.Value = false;
                }
            }
        }

        public ThreeValued RetResult(ThreeValued Value1, ThreeValued Value2, ThreeValued Value3, ThreeValued Value4)
        {
            ThreeValued tvRet = ThreeValued.UNKNOWN;
            if (Value1.Equals(ThreeValued.FALSE) ||
                Value2.Equals(ThreeValued.FALSE) ||
                Value3.Equals(ThreeValued.FALSE) ||
                Value4.Equals(ThreeValued.FALSE))
            {
                tvRet = ThreeValued.FALSE;
            }
            else if (Value1.Equals(ThreeValued.TRUE) &&
                     Value2.Equals(ThreeValued.TRUE) &&
                     Value3.Equals(ThreeValued.TRUE) &&
                     Value4.Equals(ThreeValued.TRUE))
            {
                tvRet = ThreeValued.TRUE;
            }
            return tvRet;
        }
        #endregion 公用函式
    }
}