using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProVTool;
using System.Timers;

namespace CommonObj.ModbusTCP
{
    public class ICPDAS_t_P_ET_DA2 : ClientMBX
    {
        public enum Register
        {
            CurrentMode_Status_0 = 290,           //讀取電流模式的斷線狀態，0: 正常、1: 斷線，10290
            CurrentMode_Status_1 = 291,           //讀取電流模式的斷線狀態，0: 正常、1: 斷線，10291
            AO_Output_0 = 0,                      //輸出0設定 0~10V、0~20mA，40000
            AO_Output_1 = 1,                      //輸出1設定 0~10V、0~20mA，40001
            AO_DataRange_0 = 459,                 //設定AO的資料範圍 0x30: 0~20mA, 0x31: 4~20mA, 0x32: 0~10V
            AO_DataRange_1 = 460,                 //設定AO的資料範圍 0x30: 0~20mA, 0x31: 4~20mA, 0x32: 0~10V
        }

        public enum MPort
        {
            AO_0,
            AO_1,
        }

        public enum Mode
        {
            Current1 = 48,   // 0~20mA
            Current2 = 49,   // 4~20mA,
            Volt = 50,       // 0~10V
        }

        private Mode AO_0_Mode;
        private Mode AO_1_Mode;

        Timer Timer_Status = new Timer();

        public ICPDAS_t_P_ET_DA2(string sIP, string sPort)
        {
            delShowRecMsg += Decode;
            IP = sIP;
            Port = sPort;
            Timer_Status.Interval = 1000;
            Timer_Status.Elapsed += Timer_Status_Elapsed;
            Timer_Status.Enabled = true;
        }

        void Timer_Status_Elapsed(object sender, ElapsedEventArgs e)
        {
            Timer_Status.Enabled = false;
            if (Connected)
            {
                //ReadHoldingRegisters(0, (int)Register.AO_Output_0, 1);
                //ReadHoldingRegisters(0, (int)Register.AO_Output_1, 1);
            }
            //throw new NotImplementedException();
            Timer_Status.Enabled = true;
        }

        private void Decode(byte[] data)
        {
            if (data[7] == 0x03)
            {
                String str = "";
                if (data[8] == 2)
                {
                    byte[] dataText = new byte[2];//定義文字數組 
                    Array.Copy(data, 9, dataText, 0, 2);
                    //str = Encoding.Default.GetString(dataText).Trim();
                    str = BitConverter.ToString(data, 6, 5);
                    Decode(dataText);
                }
                else
                {
                    byte[] dataText = new byte[data.Length - 9];//定義文字數組 
                    Array.Copy(data, 9, dataText, 0, dataText.Length);

                    str = BitConverter.ToString(data);
                }
            }
        }

        public void SetOutput(MPort port, float vlaue)
        {
            float max = 20;
            float min = 0;
            ushort u = 0;

            switch (port)
            {
                case MPort.AO_0:
                    if (AO_0_Mode == Mode.Current2)
                    {
                        min = 4;
                    }
                    break;
                case MPort.AO_1:
                    if (AO_1_Mode == Mode.Current2)
                    {
                        min = 4;
                    }
                    break;
                default:
                    return;
            }

            u = (ushort)(((vlaue - min) / (max - min)) * 65535);

            switch (port)
            {
                case MPort.AO_0:
                    {
                        WriteSingleRegister(0, 0, (int)Register.AO_Output_0, u);
                    }
                    break;
                case MPort.AO_1:
                    {
                        WriteSingleRegister(0, 0, (int)Register.AO_Output_1, u);
                    }
                    break;
                default:
                    break;
            }
        }

        public void SetMode(MPort port, Mode mode)
        {
            switch (port)
            {
                case MPort.AO_0:
                    WriteSingleRegister(0, 0, (int)Register.AO_DataRange_0, (ushort)mode);
                    AO_0_Mode = mode;
                    break;
                case MPort.AO_1:
                    WriteSingleRegister(0, 0, (int)Register.AO_DataRange_1, (ushort)mode);
                    AO_1_Mode = mode;
                    break;
                default:
                    break;
            }
        }
    }
}
