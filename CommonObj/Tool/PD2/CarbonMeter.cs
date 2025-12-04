using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CarbonEmissionMeter;

namespace CommonObj
{
    public partial class CarbonMeter : UserControl
    {
        public CarbonMeter()
        {
            InitializeComponent();

            meter = new CarbonEmissionMeter.CarbonEmissionMeter();
        }

        private string _IP = "IP";
        [Category("自訂")]
        [Description("連線IP")]
        [Browsable(true)] // 確保屬性在屬性視窗中可見
        public string sIP
        {
            get { return _IP; }
            set
            {
                _IP = value;
            }
        }
        #region public

        //連線元件
        public CarbonEmissionMeter.CarbonEmissionMeter meter;

        /// <summary>
        /// 回傳是否資料讀取中，如果是的話，就不用再重新連線
        /// </summary>
        /// <returns></returns>
        public bool IsReading()
        {
            return meter.IsReading;        
        }
        //連線(true  : 連線 false : 斷線)
        public bool Connect(CommTypes commType, bool bIsConnect = true, int port = 502)
        {
            if (bIsConnect == true)
            {
                meter.Connect(commType, _IP);

                meter.Start();
            }
            else
            {
                meter.Stop();
            }
            return true;//TODO:需要有回傳結果，需要有斷線功能  ---> 沒有要提供回傳結果，沒有提供斷線功能，下"STOP"就能關軟體
        }
        //取得瞬時壓力
        public double GetAirPressure()
        {
            return meter.AirPressure;
        }
        //取得順時流速
        public double GetAirFlowRate()
        {
            return meter.AirFlowRate;
        }
        //取順時功率
        public double GetPower()
        {
            return meter.Power;
        }
        //開關氣門
        public bool CtrlValve(bool bSW)
        {
            if (bSW)
            {
                meter.OpenAirValve();
                return true;
            }
            else
            {
                meter.CloseAirValve();
                return true;
            }
        }


        #endregion public















        //設定通訊方式與IP
        private void btnConnect_Click(object sender, EventArgs e)
        {
            meter.Connect(CommTypes.MP_FEN1, _IP);
        }

        //開始量測
        private void btnRead_Click(object sender, EventArgs e)
        {
            meter.Start();
        }

        //是否正在擷取感測器的值
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (meter.IsReading)
            {
                cb_IsReading.BackColor = Color.LightGreen;
                cb_IsReading.Text = "CONNECT";
            }
            else
            {
                cb_IsReading.BackColor = Color.Red;
                cb_IsReading.Text = "DISCONNECT";
            }
        }

        //停止量測
        private void btnStop_Click(object sender, EventArgs e)
        {
            meter.Stop();
        }

        //打開氣壓閥門，開關頻率建議大於10分鐘
        private void btnOpenValve_Click(object sender, EventArgs e)
        {
            meter.OpenAirValve();
        }

        //關閉氣壓閥門
        private void btnCloseValve_Click(object sender, EventArgs e)
        {
            meter.CloseAirValve();
        }
        
        //讀取即時氣壓
        private void btnReadAirPressure_Click(object sender, EventArgs e)
        {
            bt_ReadAirPressure.Text = meter.AirPressure.ToString();
        }

        //讀取即時氣流量
        private void bt_ReadAirFlowRate_Click(object sender, EventArgs e)
        {
            bt_ReadAirFlowRate.Text = meter.AirFlowRate.ToString();
        }

        //讀取即時電力
        private void btnReadPower_Click(object sender, EventArgs e)
        {
            bt_ReadPower.Text = meter.Power.ToString();
        }

        //讀取最近24小時或最近7天的歷史資料
        //private void btnLoadData_Click(object sender, EventArgs e)
        //{
        //    var dataSource1 = meter.ReadHoursData();
        //    chart1.Series["Series1"].Points.DataBind(dataSource1, "TimeStamp", "CarbonEmission", "");
        //    chart2.Series["Series1"].Points.DataBind(dataSource1, "TimeStamp", "Power", "");
        //    chart3.Series["Series1"].Points.DataBind(dataSource1, "TimeStamp", "AirFlowRate", "");
        //    var dataSource2 = meter.ReadDaysData();
        //    chart4.Series["Series1"].Points.DataBind(dataSource2, "TimeStamp", "CarbonEmission", "");
        //    chart5.Series["Series1"].Points.DataBind(dataSource2, "TimeStamp", "Power", "");
        //    chart6.Series["Series1"].Points.DataBind(dataSource2, "TimeStamp", "AirFlowRate", "");
        //}

        private void bt_Summary_Click(object sender, EventArgs e)
        {
            var dataSource1 = meter.ReadHoursData();
            chart1.Series["Series1"].Points.DataBind(dataSource1, "TimeStamp", "CarbonEmission", "");
            chart2.Series["Series1"].Points.DataBind(dataSource1, "TimeStamp", "Power", "");
            chart3.Series["Series1"].Points.DataBind(dataSource1, "TimeStamp", "AirFlowRate", "");
            var dataSource2 = meter.ReadDaysData();
            chart4.Series["Series1"].Points.DataBind(dataSource2, "TimeStamp", "CarbonEmission", "");
            chart5.Series["Series1"].Points.DataBind(dataSource2, "TimeStamp", "Power", "");
            chart6.Series["Series1"].Points.DataBind(dataSource2, "TimeStamp", "AirFlowRate", "");
        }

        //END
    }
}
