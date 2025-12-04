using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PaeLibGeneral;
using System.Drawing;

namespace CommonObj
{
    public delegate void DelShowOcrImage(Image _Image);
    public delegate void EventHandler_DataChange(DataIndex Index, object sender, EventArgs e);

    public enum DataIndex
    {
        FoupID,
        BoxID,
        Aligner_OCR_ReadID,
        Laser_OCR_ReadID,
        LotID,
        OPID,
        OutputSum,
        BU2_Lot,
        ASC_Lot,
        Custome,
        W_Lot,
        Device,
        W_Code,
        ExpectedWorkSum,
        WPB_WorkSum,
        EngineeringProducts, //v1.0.0.21
        WaferSize,//v1.0.0.21
        ProductType//v1.0.0.21
    }

    public static class DataLayer
    {
        public static event EventHandler_DataChange Data_Change;
        private static readonly object AlignerOCR_Lock = new object();
        private static readonly object LaserOCR_Lock = new object();
        private static readonly object PreLaserOCR_Lock = new object();


        private static int _WaferSize = 0;//v1.0.0.21
        public static int WaferSize//v1.0.0.21
        {
            get { return _WaferSize; }
            set
            {
                _WaferSize = value;
                if (Data_Change != null)
                {
                    Data_Change(DataIndex.WaferSize, _WaferSize.ToString(), EventArgs.Empty);
                }
            }
        }
        
        private static string _ProductType; //v1.0.0.21
        public static string ProductType    //v1.0.0.21
        {
            get { return _ProductType; }
            set
            {
                _ProductType = value;
                if (Data_Change != null)
                {
                    Data_Change(DataIndex.ProductType, _ProductType, EventArgs.Empty);
                }
            }
        }

        private static int iEngineeringProducts = 0;//v1.0.0.21
        public static int EngineeringProducts//v1.0.0.21
        {
            get { return iEngineeringProducts; }
            set
            {
                iEngineeringProducts = value;
                if (Data_Change != null)
                {
                    Data_Change(DataIndex.EngineeringProducts, iEngineeringProducts, EventArgs.Empty);
                }
            }
        }         

        private static string _FoupID;
        public static string FoupID
        {
            get { return _FoupID; }
            set
            {
                _FoupID = value;
                if (Data_Change != null)
                {
                    Data_Change(DataIndex.FoupID, _FoupID, EventArgs.Empty);
                }
            }
        }

        private static string _BoxID;
        public static string BoxID
        {
            get { return _BoxID; }
            set
            {
                _BoxID = value;
                if (Data_Change != null)
                {
                    Data_Change(DataIndex.BoxID, _BoxID, EventArgs.Empty);
                }
            }
        }

        public static bool bOcrAlignerResultOK = false;
        private static string _Aligner_OCR_ReadID;
        public static string Aligner_OCR_ReadID
        {
            get { return _Aligner_OCR_ReadID; }
            set
            {
                _Aligner_OCR_ReadID = value;
                if (Data_Change != null)
                {
                    Data_Change(DataIndex.Aligner_OCR_ReadID, _Aligner_OCR_ReadID, EventArgs.Empty);
                }
            }
        }

        public static bool bOcrLaserResultOK = false;
        private static string _Laser_OCR_ReadID;
        public static string Laser_OCR_ReadID
        {
            get { return _Laser_OCR_ReadID; }
            set
            {
                _Laser_OCR_ReadID = value;
                if (Data_Change != null)
                {
                    Data_Change(DataIndex.Laser_OCR_ReadID, _Laser_OCR_ReadID, EventArgs.Empty);
                }
            }
        }

        public static CWafer UpperArmWaferData;
        public static CWafer LowerArmWaferData;
        public static CWafer AlignerWaferData;
        public static CWafer LaserWaferData;
        public static CWafer BufferStageWaferData;
        public static CWafer WaferPickerArmWaferData;
        public static CWafer WRHPickerArmWaferData;//v1.0.0.4
        public static CWafer[] FoupWaferData;

        public static void ChangeWaferData(ref CWafer Sourece, ref CWafer Target)
        {
            Target = (CWafer)Sourece.Clone();
            Sourece = null;
        }

        public static DelShowOcrImage delShowOcrAlingerImage;
        private static Image _Ocr_Aligner_Image;
        public static Image Ocr_Aligner_Image
        {
            get 
            {
                lock (AlignerOCR_Lock)
                {
                    return _Ocr_Aligner_Image.Clone() as Image;
                }
            }
            set
            {
                lock (AlignerOCR_Lock)
                {
                    _Ocr_Aligner_Image = value;
                    if (delShowOcrAlingerImage != null)
                    {
                        Image image = _Ocr_Aligner_Image.Clone() as Image;
                        delShowOcrAlingerImage(image);
                    }
                }
            }
        }

        public static DelShowOcrImage delShowOcrLaserImage;
        private static Image _Ocr_Laser_Image;
        public static Image Ocr_Laser_Image
        {
            get 
            {
                lock (LaserOCR_Lock)
                {
                    return _Ocr_Laser_Image.Clone() as Image;
                }
            }
            set
            {
                lock (LaserOCR_Lock)
                {
                    _Ocr_Laser_Image = value;
                    if (delShowOcrLaserImage != null)
                    {
                        Image image = _Ocr_Laser_Image.Clone() as Image;
                        delShowOcrLaserImage(image);
                    }
                }
            }
        }

        public static DelShowOcrImage delShowOcrPreLaserImage;
        private static Image _Ocr_PreLaser_Image;
        public static Image Ocr_PreLaser_Image
        {
            get
            {
                lock (PreLaserOCR_Lock)
                {
                    return _Ocr_PreLaser_Image.Clone() as Image;
                }
            }
            set
            {
                lock (PreLaserOCR_Lock)
                {
                    _Ocr_PreLaser_Image = value;
                    if (delShowOcrPreLaserImage != null && _Ocr_PreLaser_Image != null)
                    {
                        Image image = _Ocr_PreLaser_Image.Clone() as Image;
                        delShowOcrPreLaserImage(image);
                    }
                }
            }
        }

        private static int _iExpectedWorkSum = 0;
        public static int iExpectedWorkSum
        {
            get { return _iExpectedWorkSum; }
            set
            {
                _iExpectedWorkSum = value;
                if (Data_Change != null)
                {
                    Data_Change(DataIndex.ExpectedWorkSum, _iExpectedWorkSum.ToString(), EventArgs.Empty);
                }
            }
        }

        private static int _iWPB_WorkSum = 0;
        public static int iWPB_WorkSum
        {
            get { return _iWPB_WorkSum; }
            set
            {
                _iWPB_WorkSum = value;
                if (Data_Change != null)
                {
                    Data_Change(DataIndex.WPB_WorkSum, _iWPB_WorkSum.ToString(), EventArgs.Empty);
                }
            }
        }

        public static long IndexTime = 0;
        public static int WPH = 0;

        private static string _LotID;
        public static string LotID
        {
            get { return _LotID; }
            set
            {
                _LotID = value;
                if (Data_Change != null)
                {
                    Data_Change(DataIndex.LotID, _LotID, EventArgs.Empty);
                }
            }
        }

        private static string _OPID;
        public static string OPID
        {
            get { return _OPID; }
            set
            {
                _OPID = value;
                if (Data_Change != null)
                {
                    Data_Change(DataIndex.OPID, _OPID, EventArgs.Empty);
                }
            }
        }

        private static int iOutputSum = 0;
        public static int OutputSum
        {
            get { return iOutputSum; }
            set
            {
                iOutputSum = value;
                if (Data_Change != null)
                {
                    Data_Change(DataIndex.OutputSum, iOutputSum, EventArgs.Empty);
                }
            }
        }

        private static string _BU2_Lot;//BU2內部批號
        public static string BU2_Lot
        {
            get { return _BU2_Lot; }
            set
            {
                _BU2_Lot = value;
                if (Data_Change != null)
                {
                    Data_Change(DataIndex.BU2_Lot, _BU2_Lot, EventArgs.Empty);
                }
            }
        }

        private static string _ASC_Lot;//ASC內部批號
        public static string ASC_Lot
        {
            get { return _ASC_Lot; }
            set
            {
                _ASC_Lot = value;
                if (Data_Change != null)
                {
                    Data_Change(DataIndex.ASC_Lot, _ASC_Lot, EventArgs.Empty);
                }
            }
        }

        private static string _Custome;//客戶名稱
        public static string Custome
        {
            get { return _Custome; }
            set
            {
                _Custome = value;
                if (Data_Change != null)
                {
                    Data_Change(DataIndex.Custome, _Custome, EventArgs.Empty);
                }
            }
        }

        private static string _W_Lot;//客戶產品批號(Customer lot#)
        public static string W_Lot
        {
            get { return _W_Lot; }
            set
            {
                _W_Lot = value;
                if (Data_Change != null)
                {
                    Data_Change(DataIndex.W_Lot, _W_Lot, EventArgs.Empty);
                }
            }
        }

        private static string _Device;//客戶產品型號(Customer Device)
        public static string Device
        {
            get { return _Device; }
            set
            {
                _Device = value;
                if (Data_Change != null)
                {
                    Data_Change(DataIndex.Device, _Device, EventArgs.Empty);
                }
            }
        }

        private static string _W_Code;//晶圓光罩
        public static string W_Code
        {
            get { return _W_Code; }
            set
            {
                _W_Code = value;
                if (Data_Change != null)
                {
                    Data_Change(DataIndex.W_Code, _W_Code, EventArgs.Empty);
                }
            }
        }

        private static string WaferQty;//進貨片數
        private static string DiesQty;//進貨顆數

        public static MES_ID_Data[] MES_ID;

        public static EngravingMode Engraving_Mode;
        public static bool EngravingModeCheckDone = false;

        public static KYEC_SECS_DATA SECS_DATA = new KYEC_SECS_DATA();

        public static Dictionary<string, RecipeInfo> dtyW_CodeRecipes = new Dictionary<string, RecipeInfo>();
    }


    public class KYEC_SECS_DATA
    {
        public KYEC_WaferData WaferData = new KYEC_WaferData();
        public string MappingResult;
    }

    public class RecipeInfo
    {
        public EngravingMode eEngravingMode;
        public float fMarkingAngle;
        //public string sOcrJobName;
    }

    public enum RecipeState
    {
        None = 0,
        Create,
        Changed,
        Delete,
    }

}
