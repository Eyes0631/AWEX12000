using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PaeLibProVSDKEx;
using ProVLib;

namespace CommonObj
{
    public static class TrayDataSetting
    {
        public static TrayData tdFoup1 = new TrayData();
        public static TrayDataEx tdex_Foup1 = new TrayDataEx(tdFoup1);
        public static TrayData tdFoup2 = new TrayData();
        public static TrayDataEx tdex_Foup2 = new TrayDataEx(tdFoup2);
        public static TrayData tdFoup3 = new TrayData();
        public static TrayDataEx tdex_Foup3 = new TrayDataEx(tdFoup3);
        public static TrayData tdFoup4 = new TrayData();
        public static TrayDataEx tdex_Foup4 = new TrayDataEx(tdFoup4);

        public static TrayData td_DTS_CV1 = new TrayData();
        public static TrayDataEx tdex_DTS_CV1 = new TrayDataEx(td_DTS_CV1);
        public static TrayData td_DTS_CV2 = new TrayData();
        public static TrayDataEx tdex_DTS_CV2 = new TrayDataEx(td_DTS_CV2);

        public static TrayData tdCarrierPnP = new TrayData();
        public static TrayDataEx tdex_CarrierPnP = new TrayDataEx(tdCarrierPnP);

        public static TrayData tdLeftUpperArm = new TrayData();
        public static TrayDataEx tdex_LeftUpperArm = new TrayDataEx(tdLeftUpperArm);
        public static TrayData tdLeftLowerArm = new TrayData();
        public static TrayDataEx tdex_LeftLowerArm = new TrayDataEx(tdLeftLowerArm);
        public static TrayData tdRightUpperArm = new TrayData();
        public static TrayDataEx tdex_RightUpperArm = new TrayDataEx(tdRightUpperArm);
        public static TrayData tdRightLowerArm = new TrayData();
        public static TrayDataEx tdex_RightLowerArm = new TrayDataEx(tdRightLowerArm);

        public static TrayData td_Aligner1 = new TrayData();
        public static TrayDataEx tdex_Aligner1 = new TrayDataEx(td_Aligner1);
        public static TrayData td_Aligner2 = new TrayData();
        public static TrayDataEx tdex_Aligner2 = new TrayDataEx(td_Aligner2);

        public static TrayData tdElevator = new TrayData();
        public static TrayDataEx tdex_Elevator = new TrayDataEx(tdElevator);
        public static TrayData tdUVAT = new TrayData();
        public static TrayDataEx tdex_UVAT = new TrayDataEx(tdUVAT);
        public static TrayData tdCarrier = new TrayData();
        public static TrayDataEx tdex_Carrier = new TrayDataEx(tdCarrier);

        public static void TrayDataReset()
        {
            tdFoup1.XN = 1;
            tdFoup1.YN = 25;
            tdFoup1.CellClear((byte)_BinDefine.None);

            tdFoup2.XN = 1;
            tdFoup2.YN = 25;
            tdFoup2.CellClear((byte)_BinDefine.None);

            tdFoup3.XN = 1;
            tdFoup3.YN = 25;
            tdFoup3.CellClear((byte)_BinDefine.None);

            tdFoup4.XN = 1;
            tdFoup4.YN = 25;
            tdFoup4.CellClear((byte)_BinDefine.None);

            tdLeftUpperArm.XN = 1;
            tdLeftUpperArm.YN = 1;
            tdLeftUpperArm.CellClear((byte)_BinDefine.None);

            tdLeftLowerArm.XN = 1;
            tdLeftLowerArm.YN = 1;
            tdLeftLowerArm.CellClear((byte)_BinDefine.None);

            tdRightUpperArm.XN = 1;
            tdRightUpperArm.YN = 1;
            tdRightUpperArm.CellClear((byte)_BinDefine.None);

            tdRightLowerArm.XN = 1;
            tdRightLowerArm.YN = 1;
            tdRightLowerArm.CellClear((byte)_BinDefine.None);

            td_DTS_CV1.XN = 1;
            td_DTS_CV1.YN = 1;
            td_DTS_CV1.CellClear((byte)_BinDefine.None);

            td_DTS_CV2.XN = 1;
            td_DTS_CV2.YN = 1;
            td_DTS_CV2.CellClear((byte)_BinDefine.None);

            tdUVAT.XN = 1;
            tdUVAT.YN = 1;
            tdUVAT.CellClear((byte)_BinDefine.NoWafer);

            tdElevator.XN = 1;
            tdElevator.YN = 2;
            tdElevator.CellClear((byte)_BinDefine.None);

            tdCarrierPnP.XN = 2;
            tdCarrierPnP.YN = 2;
            tdCarrierPnP.CellClear((byte)_BinDefine.None);

            td_Aligner1.XN = 1;
            td_Aligner1.YN = 1;
            td_Aligner1.CellClear((byte)_BinDefine.NoWafer);

            td_Aligner2.XN = 1;
            td_Aligner2.YN = 1;
            td_Aligner2.CellClear((byte)_BinDefine.NoWafer);
        }

        public static void DataChange(ref TrayDataEx tdex_1, ref TrayDataEx tdex_2, int FoupLevel = 0, bool IsChanging = false)
        {
            int YN1 = tdex_1.Rows;
            int YN2 = tdex_2.Rows;
            
            if (YN1 > 1 && YN2 == 1)
            {
                if (IsChanging)
                {
                    tdex_1.SetState(0, 0, 0, FoupLevel, 1);
                    tdex_2.SetState(0, 0, 0, 0, 1);
                }
                else
                {
                    byte bin1 = tdex_1.GetBin(0, 0, 0, FoupLevel);
                    byte bin2 = tdex_2.GetBin(0, 0, 0, 0);

                    tdex_1.SetState(0, 0, 0, FoupLevel, 0);
                    tdex_1.SetBin(0, 0, 0, FoupLevel, bin2);

                    tdex_2.SetState(0, 0, 0, 0, 0);
                    tdex_2.SetBin(0, 0, 0, 0, bin1);
                }
            }
            else if (YN1 == 1 && YN2 > 1)
            {
                if (IsChanging)
                {
                    tdex_2.SetState(0, 0, 0, FoupLevel, 1);
                    tdex_1.SetState(0, 0, 0, 0, 1);
                }
                else
                {
                    byte bin1 = tdex_2.GetBin(0, 0, 0, FoupLevel);
                    byte bin2 = tdex_1.GetBin(0, 0, 0, 0);

                    tdex_2.SetState(0, 0, 0, FoupLevel, 0);
                    tdex_2.SetBin(0, 0, 0, FoupLevel, bin2);

                    tdex_1.SetState(0, 0, 0, 0, 0);
                    tdex_1.SetBin(0, 0, 0, 0, bin1);
                }
            }
            else if (YN1 == 1 && YN2 == 1)
            {
                if (IsChanging)
                {
                    tdex_1.SetState(0, 0, 0, 0, 1);
                    tdex_2.SetState(0, 0, 0, 0, 1);
                }
                else
                {
                    byte bin1 = tdex_1.GetBin(0, 0, 0, 0);
                    byte bin2 = tdex_2.GetBin(0, 0, 0, 0);

                    tdex_1.SetState(0, 0, 0, 0, 0);
                    tdex_1.SetBin(0, 0, 0, 0, bin2);

                    tdex_2.SetState(0, 0, 0, 0, 0);
                    tdex_2.SetBin(0, 0, 0, 0, bin1);
                }
            }
        }
    }

    public static class GlobalBinDefine
    {
        public static byte[] NoWaferBin = new byte[] { (byte)_BinDefine.NoWafer };
        public static byte[] HasWaferBin = new byte[] { (byte)_BinDefine.HasWafer };
        public static byte[] ExChange = new byte[] { (byte)_BinDefine.Exchange };
        public static byte[] DoAlign = new byte[] { (byte)_BinDefine.DoAlign };
        public static byte[] PickWaferBin = new byte[] { (byte)_BinDefine.PickWafer, (byte)_BinDefine.PickDummy };
        public static byte[] BookingBin = new byte[] { (byte)_BinDefine.Booking_A, (byte)_BinDefine.Booking_B };
        public static byte[] NeedAligner_A = new byte[] { (byte)_BinDefine.Booking_A, (byte)_BinDefine.DoAlign, (byte)_BinDefine.HasWafer };
        public static byte[] NeedAligner_B = new byte[] { (byte)_BinDefine.Booking_B, (byte)_BinDefine.DoAlign, (byte)_BinDefine.HasWafer };
    }
}
