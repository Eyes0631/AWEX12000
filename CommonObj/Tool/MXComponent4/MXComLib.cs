#define UtlType

//#define ACTETHERLib_ActQJ71E71TCP


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ActUtlTypeLib;
using KHST = CommonObj.KvStruct;
using ACTETHERLib;
using System.Runtime;



namespace CommonObj
{
    class MXComLib
    {


#if UtlType
        ActUtlTypeClass plc = new ActUtlTypeClass();

        //CommonObj.KvStruct _KvStruct = new CommonObj.KvStruct();

        //string cpuType;
        //int cpuNum;
        bool bIsOpen = false;

        //在這邊可能會有人有疑問M值共有7680個為何陣列大小為480，手冊[375]頁說明讀取M值時1代表16個bit也就是說如果只讀取1個值這個數值就代表M0~M15，所以陣列大小為 7680/16=480。
        //可能又會有第二個疑問，如何正確得知M1234的狀態為何?這部分只需要一點計算就可以知道M1234在M_List的第幾個索引中的第幾個bit。
        public short[] D_List = new short[8000];
        public short[] M_List = new short[16];

        public MXComLib()
        {

        }

        //解構式
        ~MXComLib()
        {

        }

        #region MXC功能

        //設定邏輯站號與密碼
        //設定NumericUpDown最大值與最小值(已知邏輯站號範圍為[0~1023])
        public void SetLogicalStation(int Number, string STR = "")
        {
#if UtlType
            plc.ActLogicalStationNumber = 1;
            plc.ActPassword = "";
#endif

            //plc.ActHostAddress = STR;
            //plc.ActIONumber = Number;
            //plc.ActTimeOut = 1000;
        }
        /// <summary>
        /// 連線初始化PLC
        /// </summary>
        /// <param name="SW"></param>
        /// <param name="cpuType"></param>
        /// <param name="cpuNum"></param>
        /// <returns></returns>
        public int IsConnection(bool SW, out string cpuType, out int cpuNum)
        {
            SetLogicalStation(5002, "172.16.1.20");

            if (SW)
            {
                //開啟連線並且讀取CPU Type與回傳值
                int code = (int)plc.Open();
                if (code.Equals(0))
                {
                    plc.GetCpuType(out cpuType, out cpuNum);
                    bIsOpen = true;
                    return code;
                }
                else
                {
                    cpuType = "";
                    cpuNum = -1;
                    return -1;
                }
            }
            else
            {
                bIsOpen = false;//v1.0.0.11 ted
                int code = (int)plc.Close();
                cpuType = "";
                cpuNum = -1;
                return code;
            }
        }

        public int ReadDeviceBlock2_M_Value(string ValueType, int iNum, ref short[] M_List)
        {
            string szDevice = ValueType + Convert.ToString(iNum, 16).ToUpper();

            int Ret = plc.ReadDeviceBlock2(szDevice, M_List.Length, out M_List[0]);

            return Ret;
        }

        private bool GetPLC_bit_Statue(short[] list, int address)
        {
            bool[] bit = new bool[16];
            ////1.計算M_List索引
            int i_value = (int)(address / 16);
            ////2.計算第幾個bit
            int bit_index = address % 16;

            Word_To_bit16(list[i_value], ref bit);

            return bit[bit_index];
        }

        private void Word_To_bit16(short sh, ref bool[] bo)
        {
            //再來就是DWord，假設D3~4為一個DWord數值
            //int dword = (int)((D_List[3] & 0xFFFF) | ((D_List[4] & 0xFFFF) << 16));

            //sh = 355;

            byte[] by = BitConverter.GetBytes(sh);

            int Data = (int)by[0];

            string STR = string.Format("{0,8}", Convert.ToString(Data, 2));

            STR = STR.Replace(" ", "0");

            Data = (int)by[1];

            string STR_2 = string.Format("{0,8}", Convert.ToString(Data, 2));

            STR_2 = STR_2.Replace(" ", "0");

            STR_2 += STR;

            bool[] boo = new bool[16];

            for (int i = 0; i < boo.Length; i++)
            {
                if (STR_2.Substring(i, 1) == "1")
                {
                    boo[i] = true;
                }
                else
                {
                    boo[i] = false;
                }
            }

            //"0110001100000001"

            Array.Reverse(boo);

            bo = boo;
        }

        public string GetClockData()
        {
            short lpvarYear;
            short lpvarMonth;
            short lpvarDay;
            short lpvarDayOfWeek;
            short lpvarHour;
            short lpvarMinute;
            short lpvarSecond;

            plc.GetClockData(out lpvarYear, out lpvarMonth, out lpvarDay, out lpvarDayOfWeek, out lpvarHour, out lpvarMinute, out lpvarSecond);
            return string.Format("{0}_{1}_{2}_{3}_{4}_{5}", lpvarYear, lpvarMonth, lpvarDay, lpvarHour, lpvarMinute, lpvarSecond);
        }

        public int GetDevice(string ValueType, int iNum, out short oShort, out int oint)
        {
            string szDevice = ValueType + Convert.ToString(iNum, 16).ToUpper();

            //string szDevice = ValueType + inum.ToString();

            int Ret = plc.GetDevice2(szDevice, out oShort);

            Ret = plc.GetDevice(szDevice, out oint);

            return Ret;
        }

        public int SetDevice(string ValueType, int iNum, int Value)
        {
            string szDevice = ValueType + Convert.ToString(iNum, 16).ToUpper();

            return plc.SetDevice(szDevice, Value);
        }
        //寫入一個區間資料
        public int WriteDeviceBlock2(string ValueType, int iNum, int iTextSize, string sText)
        {
            string szDevice = ValueType + Convert.ToString(iNum, 10).ToUpper();

            if (sText.Length == 1)
            {
                sText += " ";
            }

            byte[] bSRC = Encoding.ASCII.GetBytes(sText);

            short[] sSRC = new short[iTextSize];

            KHST.ByteToShort(ref sSRC, bSRC);

            sSRC = Array.ConvertAll(bSRC, (b) => (short)b);

            return plc.WriteDeviceBlock2(szDevice, iTextSize, ref sSRC[0]);
        }

        public int WriteDeviceBlock3(string ValueType, int iNum, string[] sText)
        {
            string szDevice = ValueType + Convert.ToString(iNum, 10).ToUpper();

            int iWordLength = 20;

            //一個字的長度20，有幾個字串就寫多少個20
            int iProfile = iWordLength * sText.Length;

            byte[] bSRC = new byte[0];

            short[] sSRC_tmp = new short[0];

            short[] sSRC = new short[0];

            //處理第n個字串元素
            for (int i = 0; i < sText.Length; i++)
            {
                //先轉換成byte
                bSRC = Encoding.ASCII.GetBytes(sText[i]);
                //轉換成short
                sSRC_tmp = Array.ConvertAll(bSRC, (b) => (short)b);
                //short補到長度20
                short[] result = Enumerable.Repeat((short)0, iWordLength).ToArray();
                Array.Copy(sSRC_tmp, result, Math.Min(sSRC_tmp.Length, iWordLength));
                //合併
                sSRC = sSRC.Concat(result).ToArray();
            }
            //區塊寫入
            return plc.WriteDeviceBlock2(szDevice, iProfile, ref sSRC[0]);
        }
        //讀入一個區間資料(Bug)
        public int ReadDeviceBlock2_S(string ValueType, int iNum, int iTextSize, ref short[] short_ay_Value)
        {
            try
            {
                string szDevice = ValueType + Convert.ToString(iNum, 16).ToUpper();

                int RET = plc.ReadDeviceBlock2(szDevice, iTextSize, out short_ay_Value[0]);

                return RET;
            }
            catch (Exception)
            {
                return -999;
            }
        }

        /// <summary>
        /// 讀一個連續字串長度為20的Array
        /// </summary>
        /// <param name="ValueType"></param>
        /// <param name="iNum"></param>
        /// <param name="iTextSize"></param>
        /// <param name="string_ay_Value"></param>
        /// <returns></returns>
        public int ReadDeviceBlock2_S_ay(string ValueType, int iNum, int iTextSize, ref string[] string_ay_Value)
        {
            try
            {
                int iWordLenght = 20;

                short[] short_ay_Value = new short[string_ay_Value.Length * iWordLenght];

                string szDevice = ValueType + Convert.ToString(iNum, 10).ToUpper();

                int RET = plc.ReadDeviceBlock2(szDevice, short_ay_Value.Length, out short_ay_Value[0]);


                for (int i = 0; i < string_ay_Value.Length; i++)
                {
                    short[] short_ay_Value_Tmp = new short[iWordLenght];

                    Array.ConstrainedCopy(short_ay_Value, i * iWordLenght, short_ay_Value_Tmp, 0, iWordLenght);

                    string sTmp = string.Empty;

                    var bytes = short_ay_Value_Tmp.SelectMany(x => BitConverter.GetBytes(x)).ToArray();

                    string_ay_Value[i] = System.Text.Encoding.Unicode.GetString(bytes).Replace("\0", "");
                }

                return RET;
            }
            catch (Exception)
            {
                return -999;
            }
        }


        //讀入一個區間資料
        public int ReadDeviceBlock2(string ValueType, int iNum, int iTextSize, ref  string sText)//v1.0.0.7
        {
            string szDevice;

            short[] sSRC = new short[iTextSize];

            int RET = 0;

            switch (ValueType)
            {
                case "M":
                case "B":
                    {
                        szDevice = ValueType + Convert.ToString(iNum, 16).ToUpper();//PLC讀布林為16進制             

                        RET = plc.ReadDeviceBlock2(szDevice, iTextSize, out sSRC[0]);

                        if (RET != 0)
                        {
                            sText = "ERROR";

                            return RET;
                        }

                        StringBuilder Builder = new StringBuilder();

                        for (int i = 0; i < iTextSize; i++)
                        {
                            string sRET_2 = string.Format("{0,16}", Convert.ToString(sSRC[i], 2));

                            sRET_2 = sRET_2.Replace(" ", "0");

                            Builder.Append(new string(sRET_2.Reverse().ToArray()));
                        }

                        sText = Builder.ToString();
                    }
                    break;
                case "D":
                case "ZR":
                    {
                        szDevice = ValueType + Convert.ToString(iNum, 10).ToUpper();//PLC讀字串為10進制

                        RET = plc.ReadDeviceBlock2(szDevice, iTextSize, out sSRC[0]);

                        var bytes = sSRC.SelectMany(x => BitConverter.GetBytes(x)).ToArray();

                        sText = System.Text.Encoding.Unicode.GetString(bytes);

                        sText.Replace("\0", "");
                    }
                    break;
                default:
                    break;
            }

            return RET;

        }

        //讀取不連續多區塊資料
        public int WriteDeviceRandom2(string ValueType, int iTextSize, short[] sh_arr) //v1.0.0.10 ted
        {
            short[] _sh_arr = new short[iTextSize];

            int RET = plc.WriteDeviceRandom2(ValueType, iTextSize, ref sh_arr[0]);

            return RET;
        }
        //寫入不連續多區塊資料
        public int ReadDeviceRandom2(string ValueType, int iTextSize, out short[] sh_arr) //v1.0.0.10 ted
        {
            if (bIsOpen == false) //v1.0.0.11 ted
            {
                sh_arr = new short[0];//v1.0.0.17 ted
                return -5;
            }

            short[] _sh_arr = new short[iTextSize];

            int RET = -1;

            try
            {
                RET = plc.ReadDeviceRandom2(ValueType, iTextSize, out _sh_arr[0]);
            }
            catch (Exception)
            {
                sh_arr = new short[0];//v1.0.0.17 ted
                return -6;
            }

            string sText;
            //monitor
            var bytes = _sh_arr.SelectMany(x => BitConverter.GetBytes(x)).ToArray();
            //monitor
            sText = System.Text.Encoding.Unicode.GetString(bytes);

            sh_arr = _sh_arr;

            return RET;
        }

        #endregion MXC功能

#endif


#if ACTETHERLib_ActQJ71E71TCP


        ACTETHERLib.ActQJ71E71TCP plc = new ACTETHERLib.ActQJ71E71TCP();

        //CommonObj.KvStruct _KvStruct = new CommonObj.KvStruct();

        //string cpuType;
        //int cpuNum;
        bool bIsOpen = false;

        //在這邊可能會有人有疑問M值共有7680個為何陣列大小為480，手冊[375]頁說明讀取M值時1代表16個bit也就是說如果只讀取1個值這個數值就代表M0~M15，所以陣列大小為 7680/16=480。
        //可能又會有第二個疑問，如何正確得知M1234的狀態為何?這部分只需要一點計算就可以知道M1234在M_List的第幾個索引中的第幾個bit。
        public short[] D_List = new short[8000];
        public short[] M_List = new short[16];

        public MXComLib()
        {

        }

        #region MXC功能

        //設定邏輯站號與密碼
        //設定NumericUpDown最大值與最小值(已知邏輯站號範圍為[0~1023])
        public void SetLogicalStation(int Number, string STR = "")
        {
            plc.ActHostAddress = STR;
            plc.ActIONumber = Number;
            plc.ActTimeOut = 2000;


            //plc.ActSourceStationNumber = 2;//這個參數好像沒有關係
            //plc.ActStationNumber = 1;

            plc.ActSourceStationNumber = 1;//這個參數好像沒有關係
            plc.ActStationNumber = 2;
        }
        /// <summary>
        /// 連線初始化PLC
        /// </summary>
        /// <param name="SW"></param>
        /// <param name="cpuType"></param>
        /// <param name="cpuNum"></param>
        /// <returns></returns>
        public int IsConnection(bool SW, out string cpuType, out int cpuNum)
        {
            SetLogicalStation(1023, "172.16.1.20");//一定不能跟設定的1025相衝

            if (SW)
            {
                //開啟連線並且讀取CPU Type與回傳值
                int code = (int)plc.Open();
                if (code.Equals(0))
                {
                    int icpuNum = 0;

                    plc.GetCpuType(out cpuType, ref icpuNum);
                    bIsOpen = true;

                    cpuNum = icpuNum;
                    return code;
                }
                else
                {
                    cpuType = "";
                    cpuNum = -1;
                    return -1;
                }
            }
            else
            {
                int code = (int)plc.Close();
                bIsOpen = false;
                cpuType = "";
                cpuNum = -1;
                return code;
            }
        }

        public int ReadDeviceBlock2_M_Value(string ValueType, int iNum, ref short[] M_List)
        {
            string szDevice = ValueType + Convert.ToString(iNum, 16).ToUpper();

            int Ret = plc.ReadDeviceBlock2(szDevice, M_List.Length, out M_List[0]);

            return Ret;
        }

        private bool GetPLC_bit_Statue(short[] list, int address)
        {
            bool[] bit = new bool[16];
            ////1.計算M_List索引
            int i_value = (int)(address / 16);
            ////2.計算第幾個bit
            int bit_index = address % 16;

            Word_To_bit16(list[i_value], ref bit);

            return bit[bit_index];
        }

        private void Word_To_bit16(short sh, ref bool[] bo)
        {
            //再來就是DWord，假設D3~4為一個DWord數值
            //int dword = (int)((D_List[3] & 0xFFFF) | ((D_List[4] & 0xFFFF) << 16));

            //sh = 355;

            byte[] by = BitConverter.GetBytes(sh);

            int Data = (int)by[0];

            string STR = string.Format("{0,8}", Convert.ToString(Data, 2));

            STR = STR.Replace(" ", "0");

            Data = (int)by[1];

            string STR_2 = string.Format("{0,8}", Convert.ToString(Data, 2));

            STR_2 = STR_2.Replace(" ", "0");

            STR_2 += STR;

            bool[] boo = new bool[16];

            for (int i = 0; i < boo.Length; i++)
            {
                if (STR_2.Substring(i, 1) == "1")
                {
                    boo[i] = true;
                }
                else
                {
                    boo[i] = false;
                }
            }

            //"0110001100000001"

            Array.Reverse(boo);

            bo = boo;
        }

        public string GetClockData()
        {
            short lpvarYear;
            short lpvarMonth;
            short lpvarDay;
            short lpvarDayOfWeek;
            short lpvarHour;
            short lpvarMinute;
            short lpvarSecond;

            plc.GetClockData(out lpvarYear, out lpvarMonth, out lpvarDay, out lpvarDayOfWeek, out lpvarHour, out lpvarMinute, out lpvarSecond);
            return string.Format("{0}_{1}_{2}_{3}_{4}_{5}", lpvarYear, lpvarMonth, lpvarDay, lpvarHour, lpvarMinute, lpvarSecond);
        }

        //讀取單一位置
        public int GetDevice(string ValueType, int iNum, out short oShort, out int oint)
        {
            string szDevice = ValueType + Convert.ToString(iNum, 16).ToUpper();

            //string szDevice = ValueType + inum.ToString();

            int Ret = plc.GetDevice2(szDevice, out oShort);

            Ret = plc.GetDevice(szDevice, out oint);

            return Ret;
        }
        //寫入單一位置
        public int SetDevice(string ValueType, int iNum, int Value)
        {
            string szDevice = ValueType + Convert.ToString(iNum, 16).ToUpper();

            return plc.SetDevice(szDevice, Value);
        }

        //寫入一個區間資料
        public int WriteDeviceBlock2(string ValueType, int iNum, int iTextSize, string sText)
        {
            string szDevice = ValueType + Convert.ToString(iNum, 10).ToUpper();

            if (sText.Length == 1)
            {
                sText += " ";
            }

            byte[] bSRC = Encoding.ASCII.GetBytes(sText);

            short[] sSRC = new short[iTextSize];

            KHST.ByteToShort(ref sSRC, bSRC);

            sSRC = Array.ConvertAll(bSRC, (b) => (short)b);

            return plc.WriteDeviceBlock2(szDevice, iTextSize, ref sSRC[0]);
        }

        public int WriteDeviceBlock3(string ValueType, int iNum, string[] sText)
        {
            string szDevice = ValueType + Convert.ToString(iNum, 10).ToUpper();

            int iWordLength = 20;

            int iProfile = iWordLength * sText.Length;

            byte[] bSRC = new byte[0];

            short[] sSRC_tmp = new short[0];

            short[] sSRC = new short[0];

            for (int i = 0; i < sText.Length; i++)
            {
                bSRC = Encoding.ASCII.GetBytes(sText[i]);

                sSRC_tmp = Array.ConvertAll(bSRC, (b) => (short)b);
                //補到長度20
                short[] result = Enumerable.Repeat((short)0, iWordLength).ToArray();
                Array.Copy(sSRC_tmp, result, Math.Min(sSRC_tmp.Length, iWordLength));
                //合併
                sSRC = sSRC.Concat(result).ToArray();
            }

            return plc.WriteDeviceBlock2(szDevice, iProfile, ref sSRC[0]);
        }
        //讀入一個區間資料(Bug)
        public int ReadDeviceBlock2_S(string ValueType, int iNum, int iTextSize, ref short[] short_ay_Value)
        {
            try
            {
                string szDevice = ValueType + Convert.ToString(iNum, 16).ToUpper();

                int RET = plc.ReadDeviceBlock2(szDevice, iTextSize, out short_ay_Value[0]);

                return RET;
            }
            catch (Exception)
            {
                return -999;
            }
        }

        public int ReadDeviceBlock2_S_ay(string ValueType, int iNum, int iTextSize, ref string[] string_ay_Value)
        {
            try
            {
                int iWordLenght = 20;

                short[] short_ay_Value = new short[string_ay_Value.Length * iWordLenght];

                string szDevice = ValueType + Convert.ToString(iNum, 10).ToUpper();

                int RET = plc.ReadDeviceBlock2(szDevice, short_ay_Value.Length, out short_ay_Value[0]);


                for (int i = 0; i < string_ay_Value.Length; i++)
                {
                    short[] short_ay_Value_Tmp = new short[iWordLenght];

                    Array.ConstrainedCopy(short_ay_Value, i * iWordLenght, short_ay_Value_Tmp, 0, iWordLenght);

                    string sTmp = string.Empty;

                    var bytes = short_ay_Value_Tmp.SelectMany(x => BitConverter.GetBytes(x)).ToArray();

                    string_ay_Value[i] = System.Text.Encoding.Unicode.GetString(bytes).Replace("\0", "");
                }

                return RET;
            }
            catch (Exception)
            {
                return -999;
            }
        }


        //讀入一個區間資料
        public int ReadDeviceBlock2(string ValueType, int iNum, int iTextSize, ref  string sText)//v1.0.0.7
        {
            string szDevice;

            short[] sSRC = new short[iTextSize];

            int RET = 0;

            switch (ValueType)
            {
                case "M":
                case "B":
                    {
                        szDevice = ValueType + Convert.ToString(iNum, 16).ToUpper();//PLC讀布林為16進制             

                        RET = plc.ReadDeviceBlock2(szDevice, iTextSize, out sSRC[0]);

                        StringBuilder Builder = new StringBuilder();

                        for (int i = 0; i < iTextSize; i++)
                        {
                            string sRET_2 = string.Format("{0,16}", Convert.ToString(sSRC[i], 2));

                            sRET_2 = sRET_2.Replace(" ", "0");

                            Builder.Append(new string(sRET_2.Reverse().ToArray()));
                        }

                        sText = Builder.ToString();
                    }
                    break;
                case "D":
                case "ZR":
                    {
                        szDevice = ValueType + Convert.ToString(iNum, 10).ToUpper();//PLC讀字串為10進制

                        RET = plc.ReadDeviceBlock2(szDevice, iTextSize, out sSRC[0]);

                        var bytes = sSRC.SelectMany(x => BitConverter.GetBytes(x)).ToArray();

                        sText = System.Text.Encoding.Unicode.GetString(bytes);

                        sText.Replace("\0", "");
                    }
                    break;
                default:
                    break;
            }

            return RET;

        }

        //讀取不連續多區塊資料
        public int WriteDeviceRandom2(string ValueType, int iNum, int iTextSize, short[] sh_arr)
        {
            short[] _sh_arr = new short[iTextSize];

            int RET = plc.WriteDeviceRandom2(ValueType, iTextSize, ref sh_arr[0]);

            return RET;
        }
        //寫入不連續多區塊資料
        public int ReadDeviceRandom2(string ValueType, int iNum, int iTextSize, out short[] sh_arr)
        {
            short[] _sh_arr = new short[iTextSize];

            int RET = plc.ReadDeviceRandom2(ValueType, iTextSize, out _sh_arr[0]);

            sh_arr = _sh_arr;

            return RET;
        }

        ////讀取一個區間資料
        //public int WriteDeviceBlock2(string ValueType, int iNum, int iTextSize, string sText)
        //{
        //    string szDevice = ValueType + Convert.ToString(iNum, 16).ToUpper();

        //    if (sText.Length == 1)
        //    {
        //        sText += " ";
        //    }

        //    byte[] bSRC = Encoding.ASCII.GetBytes(sText);

        //    short[] sSRC = new short[iTextSize];

        //    KHST.ByteToShort(ref sSRC, bSRC);

        //    sSRC = Array.ConvertAll(bSRC, (b) => (short)b);

        //    return plc.WriteDeviceBlock2(szDevice, iTextSize, ref sSRC[0]);

        //    //return plc.WriteDeviceBlock2(szDevice, sSRC.Length, ref sSRC[0]);
        //}
        ////讀入一個區間資料(Bug)
        //public int ReadDeviceBlock2(string ValueType, int iNum, int iTextSize, ref string sText)
        //{
        //    string szDevice = ValueType + Convert.ToString(iNum, 16).ToUpper();

        //    short[] sSRC = new short[iTextSize];

        //    int RET = plc.ReadDeviceBlock2(szDevice, iTextSize, out sSRC[0]);


        //    switch (ValueType)
        //    {
        //        case "M":
        //        case "B":
        //            {
        //                StringBuilder Builder = new StringBuilder();

        //                for (int i = 0; i < iTextSize; i++)
        //                {
        //                    string sRET_2 = string.Format("{0,16}", Convert.ToString(sSRC[i], 2));

        //                    sRET_2 = sRET_2.Replace(" ", "0");

        //                    Builder.Append(new string(sRET_2.Reverse().ToArray()));
        //                }

        //                sText = Builder.ToString();
        //            }
        //            break;
        //        case "D":
        //            {
        //                var bytes = sSRC.SelectMany(x => BitConverter.GetBytes(x)).ToArray();

        //                sText = System.Text.Encoding.Unicode.GetString(bytes);

        //                sText.Replace("\0", "");
        //            }
        //            break;
        //        default:
        //            break;
        //    }

        //    return RET;

        //}

        //////
        //public int ReadDeviceBlock2_S(string ValueType, int iNum, int iTextSize, ref short[] short_ay_Value)
        //{
        //    string szDevice = ValueType + Convert.ToString(iNum, 16).ToUpper();
            
        //    int RET = plc.ReadDeviceBlock2(szDevice, iTextSize, out short_ay_Value[0]);

        //    return RET;
        //}

        //public int WriteDeviceBlock3(string ValueType, int iNum, string[] sText)
        //{
        //    string szDevice = ValueType + Convert.ToString(iNum, 10).ToUpper();

        //    int iWordLength = 20;

        //    int iProfile = iWordLength * sText.Length;

        //    byte[] bSRC = new byte[0];

        //    short[] sSRC_tmp = new short[0];

        //    short[] sSRC = new short[0];

        //    for (int i = 0; i < sText.Length; i++)
        //    {
        //        bSRC = Encoding.ASCII.GetBytes(sText[i]);

        //        sSRC_tmp = Array.ConvertAll(bSRC, (b) => (short)b);
        //        //補到長度20
        //        short[] result = Enumerable.Repeat((short)0, iWordLength).ToArray();
        //        Array.Copy(sSRC_tmp, result, Math.Min(sSRC_tmp.Length, iWordLength));
        //        //合併
        //        sSRC = sSRC.Concat(result).ToArray();
        //    }

        //    return plc.WriteDeviceBlock2(szDevice, iProfile, ref sSRC[0]);
        //}

        ////讀取不連續多區塊資料
        //public int WriteDeviceRandom2(string ValueType, int iNum, int iTextSize, short[] sh_arr)
        //{
        //    short[] _sh_arr = new short[iTextSize];

        //    int RET = plc.WriteDeviceRandom2(ValueType, iTextSize, ref sh_arr[0]);

        //    return RET;
        //}
        ////寫入不連續多區塊資料
        //public int ReadDeviceRandom2(string ValueType, int iNum, int iTextSize, out short[] sh_arr)
        //{
        //    short[] _sh_arr = new short[iTextSize];

        //    int RET = plc.ReadDeviceRandom2(ValueType, iTextSize, out _sh_arr[0]);

        //    sh_arr = _sh_arr;

        //    return RET;
        //}


        #endregion MXC功能

#endif

    }
}
