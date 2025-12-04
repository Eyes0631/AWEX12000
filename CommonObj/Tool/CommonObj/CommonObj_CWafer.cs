using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonObj
{
    public class CWafer : ICloneable
    {
        public string Date { set; get; }                       // 生產時的日期 //20221202

        public string Time { set; get; }                        // 生產時的時間 //20221202

        public int WorkSequence { set; get; }                   // 流水號

        public string LotID { set; get; }                       // 生產時的批號

        public string Source_CarrierID { set; get; }            // 取出的Carrier ID

        //public string Destination_CarrierID { set; get; }       // 目標的Carrier ID

        public string OPID { set; get; }                        // OP ID

        public string FoupID { set; get; }                        // FOUP ID

        public int FoupSlot { set; get; }                         //Foup層數

        public int CassetteSlot { set; get; }                     //Cassette層數

        public int InnerStorageSlot { set; get; }                 //內蓋層數

        public int ExternalStorageSlot { set; get; }              //外蓋層數

        public ECassette ECassetteLocation { set; get; }          //Cassette位置

        public string Wafer_OCR_ReadID { set; get; }                   // Wafer OCR

        //public string Laser_OCR { set; get; }

        public int CarrierSlot_Initial { set; get; }            // 從Carrier的第n層取出 

        //public int CarrierSlot_Terminal { set; get; }           // 放Carrier的第n層

        //public Stage Location_Initial { set; get; }             // Foup位置

        //public Stage Location_Terminal { set; get; }            // Foup位置

        //public string BU2_Lot { set; get; }                     //內部批號

        //public string ASC_Lot { set; get; }

        public string Customer { set; get; }                     //客戶名稱

        public string W_Lot { set; get; }                       //客戶產品批號

        public string Device { set; get; }                      //客戶產品型號

        public string W_Code { set; get; }                      //晶圓光罩

        public string MES_Wafer_ID { get; set; }                //MES ID

        public bool NotMatchWithMES { set; get; }               //是否與MES ID比對不符

        public bool ManualInputID { set; get; }                 //是否手動輸入ID

        public WaferSize WaferSize { get; set; }                //晶圓尺寸

        public CassetteSize CassetteSize { get; set; }                //晶圓尺寸

        //public string WaferThickness { get; set; }              //晶圓厚度

        public string ProductType { get; set; }                 //產品類別

        public string EngineeringProducts { get; set; }         //工程品

        //public KYEC_WaferData KYEC_Data = new KYEC_WaferData();

        public string WaferRingID { get; set; }

        //-----Gary 20241101-----
        public string WaferTransferID { get; set; }
        //-----Gary 20241101-----

        public string OCR_NotchFace { get; set; }//v1.0.0.5

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }

    public class CWaferDataShow
    {
        public int Seq
        {
            set;
            get;
        }                 // 流水號

        public string Date
        {
            set;
            get;
        }

        public string Time
        {
            set;
            get;
        }

        public string Align_OCR
        {
            set;
            get;
        }

        public string Laser_OCR
        {
            set;
            get;
        }

        public int Slot
        {
            set;
            get;
        }                     //Carrier的第n層放
    }

    public enum WaferSize
    {
        Inch12 = 12,
        Inch8 = 8,
        Inch6 = 6,
        Inch5 = 5,
    }

    public enum CassetteSize
    {
        Inch12 = 12,
        Inch8 = 8,
    }


    public enum Nozzle_Chose
    {
        Use_WRH = 0,
        Dont_Use_WRH = 1,
    }

    public class KYEC_WaferData
    {
        public string CustomerNo { get; set; }
        public string IncomingNo { get; set; }
        public string CustomerLotNo { get; set; }
        public string IncomeCustomerLotNo { get; set; }
        public string ShipLotNo { get; set; }
        public string ProductNo { get; set; }
        public string WaferList { get; set; }
        public string CustomerName { get; set; }
        public string CustomerCode { get; set; }
        public string WaferModel { get; set; }
        public string WaferMask { get; set; }
        public string ChipSize { get; set; }
        public string ChipThickness { get; set; }
        public string ProgramName { get; set; }
        public string DieQty { get; set; }
        public string LotDieQty { get; set; }
        public string RcvUnit { get; set; }
        public string OrgRcvUnit { get; set; }
        public string RunCardNo { get; set; }
        public string WaferLotNo { get; set; }
        public string LabelLotNo { get; set; }
        public string EquipmentNo { get; set; }
        public string LotType { get; set; }
        public string IncomingSlices { get; set; }
        public string IncomingQty { get; set; }
        public string CustomerShortName { get; set; }
        public string ProductCategory { get; set; }
        public string WoWaferId { get; set; }
        public string GrindThickness { get; set; }
        public string GrindThicknessUnit { get; set; }

    }
}
