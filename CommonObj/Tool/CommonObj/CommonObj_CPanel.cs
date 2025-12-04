using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProVLib;
using System.ComponentModel;

namespace CommonObj
{
    public class CPanel : ICloneable
    {
        [Description("生產日期")]
        public string Date { set; get; }
        [Description("流水號")]
        public int WorkSequence { set; get; }
        [Description("批號")]
        public string LotID { set; get; }
        [Description("OP編號")]
        public string OPID { set; get; }
        [Description("所在層數")]
        public int CassetteSlot { set; get; }
        [Description("PanelID")]
        public string PanelID { set; get; }
        [Description("CarrirID")]
        public string CarrirID { set; get; }
        [Description("客戶名稱")]
        public string Customer { set; get; }
        [Description("手動輸入PanelID")]
        public string ManualInputPanelID { set; get; }
        [Description("手動輸入CarrirID")]
        public string ManualInputCarrirID { set; get; }
        [Description("產品總類")]
        public string ProductType { get; set; }
        [Description("入料時間")]
        public string sTime_ConveyorIn { get; set; }
        [Description("出料時間")]
        public string sTime_ConveyorOut { get; set; }
        [Description("烤箱破腔時間")]
        public string sTime_OVDOut { get; set; }
        [Description("氮氣櫃破腔時間")]
        public string sTime_N2BOut { get; set; }
        [Description("Carrir破腔時間")]
        public string sTime_PVDOut { get; set; }


        public TrayData pTrayData { get; set; }                 //TrayData

        public object Clone()
        {
            return this.MemberwiseClone();
        }

        public void SetBin(byte bin)
        {
            pTrayData.CellClear(bin);
        }

    }
}
