using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using ProVLib;
using KCSDK;
using PaeLibProVSDKEx;
using PaeLibGeneral;
using CommonObj;
using System.IO;
using System.ComponentModel;



namespace CommonObj
{
    public enum WaferState
    {
        None,
        NoWafer,                        // 無晶圓
        WaferDtected,                   // 有晶圓
        ThicknessOverLimit,             // 晶圓超出限制
        WaferPosError,          // 偵測到晶圓位置異常
        Error,
        NeedToDo,
        Done,
    }

    public class SlotState
    {
        public int WaferReferenceCenterPos { get; set; }        // 該層晶圓中心位置
        public int ReferenceCenterPosGap { get; set; }          // 與理論位置差距
        public int WaferThickness { get; set; }                 // Wafer厚度
        public int WaferReferenceThickness { get; set; }        // Wafer理論厚度
        public int WaferThicknessGap { get; set; }              // 與實際Wafer厚度差距
        public int WaferCenterPos { get; set; }                 // 實際晶圓中心位置
        public WaferState _WaferState { get; set; }             // 晶圓掃描狀態
    }

    public class Mapping
    {
        public int iTotalLevel = 0;                         //產品層數
        public int iScanPitch = 0;                          //間距
        public int iWaferThick = 0;                         //產品預設厚度
        public int iWaferThickOffset = 0;                   //產品厚度誤差
        public int iWaferStationOffset = 0;                 //產品位置誤差
        public int iScanWaferFirstTheoreticalPos = 0;        //Wafer理論第一點點位
        public SlotState[] SlotStates;

        private int[] WaferTheoreticalPos;
        private WaferState[] WaferStates;
        private void CalTheoreticalPos()
        {
            WaferTheoreticalPos = new int[iTotalLevel];
            WaferStates = new WaferState[iTotalLevel];
            SlotStates = new SlotState[iTotalLevel];

            for (int i = 0; i < iTotalLevel; i++)
            {
                int pos = iScanWaferFirstTheoreticalPos - (iScanPitch * i);
                WaferTheoreticalPos[i] = pos;
                SlotStates[i] = new SlotState();
                SlotStates[i].WaferReferenceCenterPos = pos;
                SlotStates[i]._WaferState = WaferState.NoWafer;
                WaferStates[i] = WaferState.NoWafer;
            }
        }

        public int[] CalCloseLevelandDis(int ScanMid)
        {
            int[] iResult = new int[2];
            int iMin = int.MaxValue;
            int iLevel = 0;
            for (int index = 0; index < iTotalLevel; index++)    //計算掃描位置最近層數
            {
                int iDis = Math.Abs(ScanMid - WaferTheoreticalPos[index]);
                if (iDis < iMin)
                {
                    iMin = iDis;
                    iLevel = index;
                }
            }
            iResult[0] = iMin;
            iResult[1] = iLevel;
            return iResult;
        }

        public WaferState[] CalScanResult(List<int> SensorOff, List<int> SensorOn)
        {
            CalTheoreticalPos();

            for (int i = 0; i < SensorOn.Count; i++)
            {
                int ScanThick = SensorOff[i] - SensorOn[i];
                int ScanMid = (SensorOff[i] + SensorOn[i]) / 2;
                int ThickGap = Math.Abs(ScanThick - iWaferThick);
                int[] iResult = CalCloseLevelandDis(ScanMid);

                if (iResult[0] > iWaferStationOffset)
                {
                    WaferStates[iResult[1]] = WaferState.WaferPosError;
                }
                else if (ThickGap <= iWaferThickOffset)
                {
                    WaferStates[iResult[1]] = WaferState.WaferDtected;
                }
                else if (ThickGap > iWaferThickOffset)
                {
                    WaferStates[iResult[1]] = WaferState.ThicknessOverLimit;
                }
                else
                {
                    WaferStates[iResult[1]] = WaferState.NoWafer;
                }

                SlotStates[iResult[1]].WaferThickness = ScanThick;
                SlotStates[iResult[1]].WaferCenterPos = ScanMid;
                SlotStates[iResult[1]].ReferenceCenterPosGap = iResult[0];
                SlotStates[iResult[1]].WaferThicknessGap = ThickGap;
                SlotStates[iResult[1]]._WaferState = WaferStates[iResult[1]];
                SlotStates[iResult[1]].WaferReferenceThickness = iWaferThick;
            }
            return WaferStates;
        }
    }
}
