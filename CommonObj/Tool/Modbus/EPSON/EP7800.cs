using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommonObj.ModbusTCP;
using System.ComponentModel;

namespace CommonObj.Tool.Modbus.EPSON
{
    public class EP7800 : ClientMBX
    {
        public float fPressureValue = 0.0f;
        private FunctionCode NowCommand;

        public EP7800(string Port, string Baudrate, string DataBits, string strStopBits, string strParity)
            : base(eConnectedMode.RS232)
        {
            SetComPort(Port, Baudrate, DataBits, strStopBits, strParity);
            delShowRecMsg += Decode;
        }

        private void Decode(byte[] data)
        {
            switch (NowCommand)
            {
                case FunctionCode.AddressSetting:
                    break;
                case FunctionCode.PressureCategoryMapping:
                    break;
                case FunctionCode.CurrentPressureValue:
                    {
                        //if (data.Length == 7)
                        //{
                        //    fPressureValue = WordsToFloat(data[4], data[3]);
                        //}
                    }
                    break;
                case FunctionCode.Unit:
                    break;
                case FunctionCode.DecimalPointDigits:
                    break;
                case FunctionCode.SwitchPointMode:
                    break;
                case FunctionCode.SwitchPointActionType:
                    break;
                case FunctionCode.ActionPointSettingH1orA1:
                    break;
                case FunctionCode.ActionPointSettingh1orb1:
                    break;
                case FunctionCode.OutputReactionMode:
                    break;
                case FunctionCode.OutputReactionTime:
                    break;
                case FunctionCode.PowerOutputSetting:
                    break;
                case FunctionCode.TransmissionSpeedSetting:
                    break;
                case FunctionCode.TransmissionDataSetting:
                    break;
                case FunctionCode.TransmissionCommMode:
                    break;
                case FunctionCode.IndividualChannelOffsetSetting:
                    break;
                case FunctionCode.DisplayFunctionSetting:
                    break;
                case FunctionCode.InputCategory1Setting:
                    break;
                case FunctionCode.DisplayUpdateTime:
                    break;
                case FunctionCode.DetectionMethodSetting:
                    break;
                case FunctionCode.OutputDigitSetting:
                    break;
                case FunctionCode.MaxValueStorage:
                    break;
                case FunctionCode.MinValueStorage:
                    break;
                case FunctionCode.MaxMinValueStorageSetting:
                    break;
                case FunctionCode.OutputDelayTimeSetting:
                    break;
                case FunctionCode.OutputDelayTimeReleaseCondition:
                    break;
                case FunctionCode.CurrentFlowValue:
                    {
                        if (data.Length == 7)
                        {
                            fPressureValue = WordsToInt(data[4], data[3]);
                        }
                    }
                    break;
                default:
                    break;
            }
        }

        public void ReadValue(FunctionCode Func, ushort datalength)
        {
            NowCommand = Func;
            ReadHoldingRegisters(0x00, 0x00, (ushort)Func, datalength);
        }

        public void WritteValue(FunctionCode Func, ushort datalength)
        {
            NowCommand = Func;
            WriteSingleRegister(0x00, 0x00, (ushort)Func, datalength);
        }
    }

    public enum FunctionCode : ushort
    {
        [Description("位址設定，範圍: 0 ~ 255，讀/寫")]
        AddressSetting = 0x00,

        [Description("壓力類別對應，0: 7811; 1: 7812; 2: 7815; 3: 7810，讀/寫")]
        PressureCategoryMapping = 0x01,

        [Description("目前壓力值，讀")]
        CurrentPressureValue = 0x02,

        [Description("單位，0: kPa; 1: mmAq，讀/寫")]
        Unit = 0x03,

        [Description("小數點位數，範圍: 0 ~ 3 位數，讀/寫")]
        DecimalPointDigits = 0x04,

        [Description("開關點作模式，0: HYS; 1: CnP; 2: OFF，讀")]
        SwitchPointMode = 0x05,

        [Description("開關點動作型式，0: NO; 1: NC，讀/寫")]
        SwitchPointActionType = 0x06,

        [Description("動作點設定 H-1 或 A-1（輸出: 校氣後壓力顯示），讀/寫")]
        ActionPointSettingH1orA1 = 0x07,

        [Description("動作點設定 h-1 或 b-1（輸出: 校氣後壓力顯示），讀/寫")]
        ActionPointSettingh1orb1 = 0x08,

        [Description("輸出反應模式，0: OFF; 1: ON，讀")]
        OutputReactionMode = 0x09,

        [Description("輸出反應時間，0: 2.0ms; 1: 32ms; 2: 64ms; 3: 1024ms，讀/寫")]
        OutputReactionTime = 0x0A,

        [Description("當電輸出設定，0: OFF; 1: ON，讀/寫")]
        PowerOutputSetting = 0x0B,

        [Description("傳輸速度設定，0: 9600; 1: 19200; 2: 38400; 3: 115200，讀/寫")]
        TransmissionSpeedSetting = 0x0C,

        [Description("傳輸資料設定，0: N.8.1; 1: E.8.1; 2: O.8.1，讀/寫")]
        TransmissionDataSetting = 0x0D,

        [Description("傳輸通訊模式，0: RTU，讀/寫")]
        TransmissionCommMode = 0x0E,

        [Description("個別通道偏移設定，輸入壓縮: 0 或 1 皆可，讀/寫")]
        IndividualChannelOffsetSetting = 0x0F,

        [Description("顯示功能設定，0: OFF; 1: ON，讀/寫")]
        DisplayFunctionSetting = 0x10,

        [Description("輸入類別1類別設定，0: NPN; 1: PNP，讀/寫")]
        InputCategory1Setting = 0x11,

        [Description("顯示更新時間，範圍: 0.1 ~ 3.0 秒（0.1秒調取到最小值，3.0秒調取即保持值約30），讀/寫")]
        DisplayUpdateTime = 0x12,

        [Description("偵測方式設定，若自動零點值超過 ±3%F.S 則顯示錯誤代碼03H，讀")]
        DetectionMethodSetting = 0x13,

        [Description("輸出位數設定，0: A 單向; 1: B 單向; 2: AB 單向，讀/寫")]
        OutputDigitSetting = 0x14,

        [Description("最大值儲取，顯示 PE 值，讀")]
        MaxValueStorage = 0x15,

        [Description("最小值儲取，顯示 bo 值，讀")]
        MinValueStorage = 0x16,

        [Description("最大值/最小值儲存設定，0: OFF; 1: ON，讀")]
        MaxMinValueStorageSetting = 0x17,

        [Description("輸出延遲時間設定，範圍: 2 ~ 99 秒，讀/寫")]
        OutputDelayTimeSetting = 0x18,

        [Description("輸出延遲時間解除條件，100 秒以上為永久 Eur，讀/寫")]
        OutputDelayTimeReleaseCondition = 0x19,

        [Description("目前流量值，讀")]
        CurrentFlowValue = 0x1A,
    }

}
