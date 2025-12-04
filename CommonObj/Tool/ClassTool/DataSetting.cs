using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonObj
{
    public struct PackageData
    {
        public int iLMaskFirstCellOffset_X;
        public int iLMaskFirstCellOffset_Y;

        public int iRMaskFirstCellOffset_X;
        public int iRMaskFirstCellOffset_Y;

        public int iLRMaskOriginalOffset_X;
        public int iLRMaskOriginalOffset_Y;

        public int iMaskOriginalOffset_X;
        public int iMaskOriginalOffset_Y;

        public int iMaskFirstCellOffset_X;
        public int iMaskFirstCellOffset_Y;

        public int iLRMask_XN;
        public int iLRMask_YN;
        public int iLRMask_XPitch;
        public int iLRMask_YPitch;

        public int iMask_XN;
        public int iMask_YN;
        public int iMask_XPitch;
        public int iMask_YPitch;

        public int Edit_LRMaskColums;
        public int Edit_MaskColums;

        public int iLRCST_FloorNum;
        public int iLRCST_Pitch;
        public int iCST_FloorNum;
        public int iCST_Pitch;

        public string Edit_LRLayoutBin;
        public string Edit_LRMaskPitchBin;

        public string Edit_LayoutBin;
        public string Edit_MaskPitchBin;
    }

    public static class CommonObj_PValue
    {
        //private static PackageData _PValue;

        //public static int iLMaskFirstCellOffset_X { get { return _PValue.iLMaskFirstCellOffset_X; } }
        //public static int iLMaskFirstCellOffset_Y { get { return _PValue.iLMaskFirstCellOffset_Y; } }
        //public static int iRMaskFirstCellOffset_X { get { return _PValue.iRMaskFirstCellOffset_X; } }
        //public static int iRMaskFirstCellOffset_Y { get { return _PValue.iRMaskFirstCellOffset_Y; } }
        //public static int iLRMaskOriginalOffset_X { get { return _PValue.iLRMaskOriginalOffset_X; } }
        //public static int iLRMaskOriginalOffset_Y { get { return _PValue.iLRMaskOriginalOffset_Y; } }
        //public static int iLRMask_XN { get { return _PValue.iLRMask_XN; } }
        //public static int iLRMask_YN { get { return _PValue.iLRMask_YN; } }
        //public static int iLRMask_XPitch { get { return _PValue.iLRMask_XPitch; } }
        //public static int iLRMask_YPitch { get { return _PValue.iLRMask_YPitch; } }
        //public static int iMask_XN { get { return _PValue.iMask_XN; } }
        //public static int iMask_YN { get { return _PValue.iMask_YN; } }
        //public static int iMask_XPitch { get { return _PValue.iMask_XPitch; } }
        //public static int iMask_YPitch { get { return _PValue.iMask_YPitch; } }
        //public static int Edit_LRMaskColums { get { return _PValue.Edit_LRMaskColums; } }
        //public static int Edit_MaskColums { get { return _PValue.Edit_MaskColums; } }
        //public static int iMaskOriginalOffset_X { get { return _PValue.iMaskOriginalOffset_X; } }
        //public static int iMaskOriginalOffset_Y { get { return _PValue.iMaskOriginalOffset_Y; } }
        //public static int iMaskFirstCellOffset_X { get { return _PValue.iMaskFirstCellOffset_X; } }
        //public static int iMaskFirstCellOffset_Y { get { return _PValue.iMaskFirstCellOffset_Y; } }
        //public static int iLRCST_FloorNum { get { return _PValue.iLRCST_FloorNum; } }
        //public static int iLRCST_Pitch { get { return _PValue.iLRCST_Pitch; } }
        //public static int iCST_FloorNum { get { return _PValue.iCST_FloorNum; } }
        //public static int iCST_Pitch { get { return _PValue.iCST_Pitch; } }

        //public static string Edit_LRLayoutBin { get { return _PValue.Edit_LRLayoutBin; } }
        //public static string Edit_LRMaskPitchBin { get { return _PValue.Edit_LRMaskPitchBin; } }

        //public static string Edit_LayoutBin { get { return _PValue.Edit_LayoutBin; } }
        //public static string Edit_MaskPitchBin { get { return _PValue.Edit_MaskPitchBin; } }

        //public static void LoadData(PackageData data)
        //{
        //    _PValue = data;
        //}
    }

    public struct OptionData
    {
        public bool bDryRun;
        public bool bNonStopRun;
        public int iManchineSpeedRate;
        public int iCommProtocol;

        public int iDis_Conveyor_X_Transfer;
        public int iDis_Conveyor_X_RunMore;
        public int iDis_Conveyor_X_Adjust;
        public bool bIsSimulation;

    }

    public static class OValue
    {
        private static OptionData _OValue;

        public static bool bDryRun { get { return _OValue.bDryRun; } }
        public static bool bNonStopRun { get { return _OValue.bNonStopRun; } }
        public static bool bIsSimulation { get { return _OValue.bIsSimulation; } }

        public static int iManchineSpeedRate { get { return _OValue.iManchineSpeedRate; } }        
        public static int iDis_Conveyor_X_Transfer { get { return _OValue.iDis_Conveyor_X_Transfer; } }
        public static int iDis_Conveyor_X_RunMore { get { return _OValue.iDis_Conveyor_X_RunMore; } }
        public static int iDis_Conveyor_X_Adjust { get { return _OValue.iDis_Conveyor_X_Adjust; } }


        public static void LoadData(OptionData data)
        {
            _OValue = data;
        }

        public static OptionData GetData()
        {
            return _OValue;
        }
    }

}
