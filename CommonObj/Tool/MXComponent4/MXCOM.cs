using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//
using System.Threading;
using ProVLib;
using System.Collections;

//
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace CommonObj
{
    public class MXCOM : IDisposable
    {
        const string sDValue = "D";
        const string sLValue = "L";
        const string sMValue = "M";
        const string sBValue = "B";
        const string sZRValue = "ZR";

        private MXComLib MXCLib;

        private bool IsPass = false;

        private bool IsConnect = false;//v1.0.0.11 ted

        private string sCpuType = "";//v1.0.0.13 ted
        private int iCpuNum = -1; //v1.0.0.13 ted

        public MXCOM()
        {
            MXCLib = new MXComLib();

            _Struct = new MXC4Struct();

            //執行序建立
            Threading = new Thread(MXCProcess);
            Threading.IsBackground = true;
            Threading.Start();
        }

        public void Dispose()
        {
            IsPass = true;

            Threading.Join();
        }

        #region MXCProcess

        #region private

        private Thread Threading;

        private MXC4Struct _Struct;

        private void MXCProcess(object Sender)
        {
            //m_Sender = Sender;
            while (true)
            {
                //if (IsConnect == true) //v1.0.0.17 noke
                //{                   
                //    foreach (var signal in MXC4Struct.HandOverSignals)
                //    {
                //        signal.Read();
                //    }
                //    foreach (var pdf in MXC4Struct.PanelDataFlows)
                //    {
                //        pdf.Read();
                //    }
                //}

                Cycle();
                Thread.Sleep(100);
            }
        }

        /// <summary>
        /// 讀取B值
        /// </summary>
        private void ReadIO_Cycle()
        {
            if (IsConnect == false)//v1.0.0.11 ted
            {
                return;
            }

            int iLenght = ((int)eMXC_IO_Read.eEnd - (int)eMXC_IO_Read.eInline_CNVI_Ready) / 16;

            short[] tmpshort = new short[iLenght];

            int iIO_WordShift = 0;//16 bit

            DataLayer.b_ay_MXC_IO_Read = new bool[iLenght * 16];

            //讀值
            int iRet = MXCLib.ReadDeviceBlock2_S(sBValue, (int)eMXC_IO_Read.eInline_CNVI_Ready, iLenght, ref tmpshort);

            if (iRet == 0)
            {
                for (int i = 0; i < tmpshort.Length; i++)
                {
                    if (tmpshort[i] != 0)
                    {
                        BitArray bitArray = new BitArray(new[] { (int)(tmpshort[i]) });//short強制轉成int所以後面的為無效位元

                        bool[] bits = new bool[32];

                        bitArray.CopyTo(bits, 0);

                        for (int t = 0; t < bits.Length / 2; t++)
                        {
                            if (bits[t] == true)
                            {
                                DataLayer.b_ay_MXC_IO_Read[iIO_WordShift * 16 + t] = true;//
                            }
                        }
                    }
                    else
                    {
                        for (int k = 0; k < 16; k++)
                        {
                            DataLayer.b_ay_MXC_IO_Read[iIO_WordShift * 16 + k] = false;
                        }
                    }

                    iIO_WordShift++;
                }
            }

            ////有Carrier出料
            //if (DataLayer.b_ay_MXC_IO_Read[(int)eMXC_IO_Read.eInline_PVLD_Ready - (int)eMXC_IO_Read.eInline_CNVI_Ready] == true)//v1.0.0.17 ted
            //{
            //    if (DataLayer. bPVDWaitOutput_Carrier == false)
            //    {
            //        DataLayer.bPVDWaitOutput_Carrier = true;
            //    }                   
            //}
            //else
            //{
            //    if (DataLayer.bPVDWaitOutput_Carrier == true)
            //    {
            //        DataLayer.bPVDWaitOutput_Carrier = false;
            //    }    
            //}
            ////PVD要料中
            //if (DataLayer.b_ay_MXC_IO_Read[(int)eMXC_IO_Read.eInline_PVLU_Ready - (int)eMXC_IO_Read.eInline_CNVI_Ready] == true)//v1.0.0.17 ted
            //{
            //    if (DataLayer.bPVDWaitInput_Panel == false)
            //    {
            //        DataLayer.bPVDWaitInput_Panel = true;
            //    }             
            //}
            //else
            //{
            //    if (DataLayer.bPVDWaitInput_Panel == true)
            //    {
            //        DataLayer.bPVDWaitInput_Panel = false;
            //    } 
            //}
        }

        /// <summary>
        /// 依定義位置寫入panel info
        /// </summary>
        private void WritePanelInfo()
        {
            if (IsConnect == false)//v1.0.0.11 ted
            {
                return;
            }

            CPanel tmpCPanel = new CPanel();

            #region Location

            switch (DataLayer.MXCStruct_UpdatePanelInfo.Location)
            {
                case MXCLocation.CoveyorIn:
                    {
                        //tmpCPanel = DataLayer.cpConveryorIn;
                    }
                    break;
                case MXCLocation.PTI:
                    {
                        tmpCPanel = DataLayer.cpPTI;
                    }
                    break;
                case MXCLocation.Buffer_1:
                case MXCLocation.Buffer_2:
                case MXCLocation.Buffer_3:
                case MXCLocation.Buffer_4:
                    {
                        //轉成int
                        string sNum = DataLayer.MXCStruct_UpdatePanelInfo.Location.ToString();
                        sNum = sNum.Replace("Buffer_", "");
                        int iNum = 0;
                        bool b1 = Int32.TryParse(sNum, out iNum);
                        if (b1 == true)
                        {
                            tmpCPanel = DataLayer.cp_ay_UBMs[iNum - 1];//複製PanelInfo
                        }
                        else
                        {
                            return;
                        }
                    }
                    break;
                case MXCLocation.Plasma:
                    {
                        tmpCPanel = DataLayer.cpPlasma;
                    }
                    break;
                case MXCLocation.PPM_Upper:
                    {
                        tmpCPanel = DataLayer.cpPPM_Upper;
                    }
                    break;
                case MXCLocation.PPM_Lower:
                    {
                        tmpCPanel = DataLayer.cpPPM_Lower;
                    }
                    break;
                case MXCLocation.PTO:
                    {
                        tmpCPanel = DataLayer.cpPTO;
                    }
                    break;
                case MXCLocation.CoveyorOut:
                    {
                        //tmpCPanel = DataLayer.cpConveyorOut;
                    }
                    break;
                default:
                    {
                        return;
                    }
                    break;
            }

            #endregion Location

            #region Copy Data

            string[] s_ay_Write = new string[20];

            s_ay_Write[0] = tmpCPanel.Date;
            s_ay_Write[1] = tmpCPanel.WorkSequence.ToString();
            s_ay_Write[2] = tmpCPanel.LotID;
            s_ay_Write[3] = tmpCPanel.OPID;
            s_ay_Write[4] = tmpCPanel.CassetteSlot.ToString();

            s_ay_Write[5] = tmpCPanel.PanelID;
            s_ay_Write[6] = tmpCPanel.CarrirID;
            s_ay_Write[7] = tmpCPanel.Customer;
            s_ay_Write[8] = tmpCPanel.ManualInputPanelID;
            s_ay_Write[9] = tmpCPanel.ManualInputCarrirID;

            s_ay_Write[10] = tmpCPanel.ProductType;
            s_ay_Write[11] = tmpCPanel.sTime_ConveyorIn;
            s_ay_Write[12] = tmpCPanel.sTime_ConveyorOut;
            s_ay_Write[13] = tmpCPanel.sTime_OVDOut;
            s_ay_Write[14] = tmpCPanel.sTime_N2BOut;

            s_ay_Write[15] = tmpCPanel.sTime_PVDOut;
            s_ay_Write[16] = "TBD";
            s_ay_Write[17] = "TBD";
            s_ay_Write[18] = "TBD";
            s_ay_Write[19] = "TBD";

            #endregion Copy Data

            int iRet = WriteDeviceBlock3(sZRValue, (int)DataLayer.MXCStruct_UpdatePanelInfo.Location, s_ay_Write);
        }

        private Dictionary<object, string> oDictionary_RemoteControl = new Dictionary<object, string>();

        private eMXCRemoteControl _PreRemoteControl = eMXCRemoteControl.None;
        private eMXCRemoteControl _CurrRemoteControl = eMXCRemoteControl.None;
        private eMXCRemoteControl _NewRemoteControl = eMXCRemoteControl.None;

        /// <summary>
        /// 輪詢上位控制狀態
        /// </summary>
        /// 
        private void ReadRemoteControl_Cycle()//v1.0.0.11 ted
        {
            if (IsConnect == false)//v1.0.0.11 ted
            {
                return;
            }

            oDictionary_RemoteControl.Clear();

            //目前己定義狀態
            oDictionary_RemoteControl.Add((double)MXCLocation.RemoteControl + (double)eMXCRemoteControl.START / 10, null);
            oDictionary_RemoteControl.Add((double)MXCLocation.RemoteControl + (double)eMXCRemoteControl.PAUSE / 10, null);
            oDictionary_RemoteControl.Add((double)MXCLocation.RemoteControl + (double)eMXCRemoteControl.LOTEND / 10, null);
            oDictionary_RemoteControl.Add((double)MXCLocation.RemoteControl + (double)eMXCRemoteControl.PP_SELECT / 10, null);

            int iret = ReadDeviceRandomOBJ(sZRValue, ref oDictionary_RemoteControl); //v1.0.0.10 ted

            if (iret == 0)
            {
                var st_array = new List<string>(oDictionary_RemoteControl.Count);

                foreach (var kvp in oDictionary_RemoteControl)
                {
                    st_array.Add(kvp.Value);
                }

                int iSta = GetSingleActiveIndexStrict(st_array);

                //-2 : 沒有狀態
                //-1 : 狀態切換中(有多個bit同時存在)
                //0~3 : 工作狀態

                if (iSta >= 0)
                {
                    //轉換成新狀態
                    _NewRemoteControl = (eMXCRemoteControl)iSta;

                    //判斷狀態有沒有變化
                    if (_NewRemoteControl.Equals(_CurrRemoteControl) == false)
                    {
                        //先暫存現在的狀態
                        DataLayer.PreRemoteControl = DataLayer.CurrRemoteControl;
                        //更新新的狀態
                        DataLayer.CurrRemoteControl = _NewRemoteControl;
                        //內部計算也要更新
                        _CurrRemoteControl = _NewRemoteControl;
                    }
                }
            }
        }
        /// <summary>
        /// 嚴格檢查 st_array 是否「剛好只有一個 "1"」，並返回其索引（否則拋出異常）
        /// </summary>
        /// <param name="st_array">要檢查的陣列</param>
        /// <returns>唯一 "1" 的索引</returns>
        /// <exception cref="InvalidOperationException">如果沒有 "1" 或多於一個 "1"</exception>
        public int GetSingleActiveIndexStrict(List<string> st_array)//v1.0.0.11 ted
        {
            // 使用 LINQ 找出所有 "1" 的索引
            var indices = st_array
                .Select((value, index) => new { value, index })
                .Where(x => x.value == "1")
                .Select(x => x.index)
                .ToList();

            // 嚴格檢查：必須剛好一個 "1"
            switch (indices.Count)
            {
                case 0:
                    return -2;
                case 1:
                    return indices[0]; // 正確情況，返回索引
                default:
                    return -1;
            }
        }

        private void Cycle()
        {
            if (IsPass == true)
            {
                if (_Struct.Action != MXCAction.None)
                {
                    MXCEventArgs arg = new MXCEventArgs();
                    arg.ID = "ToDo";
                    arg.IO = true;
                    arg.eStatus = eStatus.OK;
                    Feedback(arg);
                }
            }

            ReadIO_Cycle();

            ReadRemoteControl_Cycle();//v1.0.0.11 ted

            switch (_Struct.Action)
            {
                case MXCAction.None:
                    {

                    }
                    break;
                case MXCAction.WriteID:
                    break;
                case MXCAction.ReadID:
                    {
                        //FeedBack
                        MXCEventArgs arg = new MXCEventArgs();
                        arg.ID = "ToDo";
                        Feedback(arg);
                    }
                    break;
                #region HandOver_Read
                case MXCAction.HandOver_Read:
                    {
                        switch (_Struct.Location)
                        {
                            case MXCLocation.None:
                                break;
                            case MXCLocation.CoveyorIn:
                                break;
                            default:
                                break;
                        }
                    }
                    break;
                #endregion HandOver_Read

                #region HandOver_Write
                case MXCAction.HandOver_Write:
                    {
                        int iRet = 0;

                        switch (_Struct.Location)
                        {
                            case MXCLocation.None:
                                break;
                            case MXCLocation.CoveyorIn:
                                break;
                            case MXCLocation.Plasma:
                                {
                                    //寫值
                                    iRet = MXCLib.SetDevice(sBValue, _Struct.GetPVD_Up_IO(_Struct.NowHandOver), _Struct.IO == true ? 1 : 0);
                                }
                                break;
                            default:
                                break;
                        }

                        //FeedBack
                        MXCEventArgs arg = new MXCEventArgs();

                        arg.MXAction = MXCAction.HandOver_Write;

                        if (iRet == 0)
                        {
                            arg.eStatus = eStatus.OK;
                        }
                        else
                        {
                            arg.eStatus = eStatus.NG;
                        }

                        Feedback(arg);
                    }
                    break;
                #endregion HandOver_Write

                case MXCAction.Reject:
                    break;
                case MXCAction.GetCommand:
                    break;
                case MXCAction.WriteIO:
                    {
                        int iRet = 0;

                        switch (_Struct.Location)
                        {
                            case MXCLocation.Plasma:
                                {
                                    //寫值
                                    iRet = MXCLib.SetDevice(sBValue, (int)eMXC_IO_Read.eInline_PVLU_Ready, _Struct.IO == true ? 1 : 0); //v1.0.0.17 ted
                                }
                                break;
                            //case MXCLocation.PVL_Carrier:
                            //    {
                            //        //寫值
                            //        iRet = MXCLib.SetDevice(sBValue, (int)eMXC_IO_Read.eInline_PVLD_Ready, _Struct.IO == true ? 1 : 0); //v1.0.0.17 ted
                            //    }
                            //    break;
                            default:
                                break;
                        }
                    }
                    break;
                case MXCAction.WriteRandom://v1.0.0.11 ted
                    {
                        WriteDeviceRandomOBJ(sZRValue, _Struct.Dictionary);
                        _Struct.Action = MXCAction.None;
                    }
                    break;
                case MXCAction.WritePanelInfo:
                    {
                        WritePanelInfo();
                        _Struct.Action = MXCAction.None;
                    }
                    break;
                default:
                    break;
            }
        }

        #endregion private

        public event EventHandler<MXCEventArgs> GetMXCEventHandler;

        public class MXCEventArgs : EventArgs
        {
            public MXCEventArgs()
            {

            }

            public MXCAction MXAction
            {
                set;
                get;
            }

            public bool IO
            {
                set;
                get;
            }

            public string ID
            {
                get;
                set;
            }

            public short[] s_ay_Read_IO
            {
                get;
                set;
            }

            public eStatus eStatus//取得狀態
            {
                get;
                set;
            }

            public eMXCRemoteControl eRemoteControl //上位控制模式
            {
                get;
                set;
            }
        }

        private void Feedback(MXCEventArgs arg)
        {
            //FeedBack
            if (GetMXCEventHandler != null)
            {
                GetMXCEventHandler(null, arg);
                _Struct.Action = MXCAction.None;
            }

        }

        public bool SetAction(MXC4Struct Struct)
        {
            if (_Struct.Action != MXCAction.None)
            {
                return false;
            }

            if (Struct != null)
            {
                _Struct = Struct.Copy();
                return true;
            }

            return false;
        }

        public bool MXCIO_Write(string ValueType, bool[] bHadover)
        {
            StringBuilder sWrite = new StringBuilder();

            bool SW = false;

            for (int i = 0; i < bHadover.Length; i++)
            {
                SW = bHadover[i];

                if (SW)
                {
                    sWrite.Append(1);
                }
                else
                {
                    sWrite.Append(0);
                }
            }

            MXCLib.WriteDeviceBlock2(ValueType, 0, bHadover.Length, sWrite.ToString());
            return true;
        }

        public void SetLogicalStation(int Number, string STR = "")
        {
            MXCLib.SetLogicalStation(Number, STR);
        }

        public int IsConnection(bool SW, out string cpuType, out int cpuNum)
        {
            if (IsConnect == true)//v1.0.0.13 ted
            {
                cpuType = sCpuType;
                cpuNum = iCpuNum;
                return 0;
            }

            int iRet = MXCLib.IsConnection(SW, out cpuType, out cpuNum);//v1.0.0.11 ted

            if (iRet == 0)
            {
                sCpuType = cpuType;
                iCpuNum = cpuNum;
                IsConnect = true;
            }
            else
            {
                IsConnect = false;
            }
            return iRet;
        }

        public int GetDevice(string ValueType, int inum, out short oShort, out int oint)
        {
            return MXCLib.GetDevice(ValueType, inum, out  oShort, out  oint);
        }

        public int SetDevice(string ValueType, int iNum, int Value)
        {
            return MXCLib.SetDevice(ValueType, iNum, Value);
        }

        public int ReadDeviceBlock2(string ValueType, int iNum, int iTextSize, ref string sText)
        {
            return MXCLib.ReadDeviceBlock2(ValueType, iNum, iTextSize, ref sText);
        }

        public int WriteDeviceBlock2(string ValueType, int iNum, int iTextSize, string sText)
        {
            return MXCLib.WriteDeviceBlock2(ValueType, iNum, iTextSize, sText);
        }

        public int WriteDeviceBlock3(string ValueType, int iNum, string[] sText)
        {
            return MXCLib.WriteDeviceBlock3(ValueType, iNum, sText);
        }

        public int WriteDeviceRandom2(string ValueType, int iTextSize, short[] stText)//v1.0.0.10 ted
        {
            return MXCLib.WriteDeviceRandom2(ValueType, iTextSize, stText);//v1.0.0.10 ted
        }

        /// <summary>
        /// 目前obj只能用int或是double 
        /// 
        /// int: 寫入字串 (有幾個字串就會遞增幾個ZR暫存器，最大長度不得超過20個字)
        /// 
        /// double: 寫入bit (bit當bool用,有幾個"0""1"就會寫幾個)
        /// 
        /// </summary>
        /// <param name="valueType"></param>
        /// <param name="dictionary"></param>
        /// <returns></returns>
        public int WriteDeviceRandomOBJ(string valueType, Dictionary<object, string> dictionary)
        {
            // 参数验证    
            if (dictionary.Count == 0)
                return -1;

            // 预计算总长度优化内存分配
            int totalLength = 0;
            foreach (var kvp in dictionary)
            {
                if (kvp.Value != null)
                    totalLength += kvp.Value.Length;
            }

            var addresses = new List<string>(totalLength);
            var sh_array = new List<short>(totalLength);

            foreach (var kvp in dictionary)
            {
                if (string.IsNullOrEmpty(kvp.Value))
                    continue;

                // 动态解析键值类型 (.NET 4.5兼容写法)
                double startValue;
                double increment;

                if (kvp.Key is int)
                {
                    startValue = (int)kvp.Key;
                    increment = 1.0;

                    // 生成地址和ASCII数据
                    foreach (char c in kvp.Value)
                    {
                        addresses.Add(string.Concat(valueType, startValue.ToString(CultureInfo.InvariantCulture)));
                        startValue += increment;
                        sh_array.Add((short)c);
                    }
                }
                else if (kvp.Key is double)
                {
                    startValue = (double)kvp.Key;
                    increment = 0.1;

                    // 生成地址和ASCII数据
                    foreach (char c in kvp.Value)
                    {
                        addresses.Add(string.Concat(valueType, startValue.ToString("0.0")));
                        startValue += increment;
                        sh_array.Add((short)c);
                    }
                }
                else
                {
                    return -1;
                }
            }

            string addrString = string.Join("\n", addresses);
            return MXCLib.WriteDeviceRandom2(addrString, sh_array.Count, sh_array.ToArray());
        }


        /// <summary>
        /// 目前obj只能用int或是double 
        /// ////////////////////////////////
        /// 
        /// #int: 讀進低位元字串 " 00000000 11110110 " = "v" 00000000 為高位元 11110110為低位元
        /// 
        /// 如果這是 Little-Endian 系統（如 x86 CPU），低位元組（LSB）會先儲存。最低位元（LSB）：最右邊的 0
        /// 如果是 Big-Endian 系統（如網路傳輸），高位元組（MSB）會先儲存。最高位元（MSB）：最左邊的 0
        /// 
        /// #double: 讀入bit (bit當bool用,有幾個"0""1"就會寫幾個)
        /// 
        /// </summary>
        /// <param name="valueType"></param>
        /// <param name="dictionary"></param>
        /// <returns></returns>

        public int ReadDeviceRandomOBJ(string valueType, ref Dictionary<object, string> dictionary)
        {
            // 参数验证    
            if (dictionary.Count == 0)
                return -1;

            // 预计算总长度优化内存分配
            int totalLength = dictionary.Count;

            var addresses = new List<string>(totalLength);
            var sh_array = new List<short>(totalLength);

            foreach (var kvp in dictionary)
            {
                // 动态解析键值类型 (.NET 4.5兼容写法)
                double startValue;
                if (kvp.Key is int)
                {
                    startValue = (int)kvp.Key;

                    // 生成地址和ASCII数据
                    addresses.Add(string.Concat(valueType, startValue.ToString(CultureInfo.InvariantCulture)));
                }
                else if (kvp.Key is double)
                {
                    startValue = (double)kvp.Key;

                    // 生成地址和ASCII数据
                    addresses.Add(string.Concat(valueType, startValue.ToString("0.0")));
                }
                else
                {
                    return -1;
                }
            }
            short[] stText;
            string addrString = string.Join("\n", addresses);

            int iRet = MXCLib.ReadDeviceRandom2(addrString, dictionary.Count, out stText);//v1.0.0.10 ted

            if (iRet == 0)
            {
                //monitor
                var bytes = stText.SelectMany(x => BitConverter.GetBytes(x)).ToArray();
                string sText = System.Text.Encoding.Unicode.GetString(bytes);

                dictionary.Clear();

                for (int i = 0; i < addresses.Count; i++)
                {
                    dictionary.Add(addresses[i], stText[i].ToString());
                }
            }

            return iRet;
        }

        public int ReadDeviceRandom2(string ValueType, int iTextSize, out  short[] stText)//v1.0.0.10 ted
        {
            return MXCLib.ReadDeviceRandom2(ValueType, iTextSize, out stText);//v1.0.0.10 ted
        }

        public int ReadDeviceBlock2_S(string ValueType, int iNum, int iTextSize, ref string[] s_ay_Text)
        {
            return MXCLib.ReadDeviceBlock2_S_ay(ValueType, iNum, iTextSize, ref s_ay_Text);
        }

        public string GetClockData()
        {
            return MXCLib.GetClockData();
        }

        public void ReadMXCState()
        {
            if (IsConnect == true) //v1.0.0.17 noke
            {
                foreach (var signal in MXC4Struct.HandOverSignals)
                {
                    signal.Read();
                }
                foreach (var pdf in MXC4Struct.PanelDataFlows)
                {
                    pdf.Read();
                }
            }
        }


        #endregion MXCProcess

        #region MyRegion

        /// <summary>
        ///  Dictionary.Add(30020, "1.0.0.1");
        ///  Dictionary.Add(30040, "12:30:15");
        ///  Dictionary.Add(30050, "APLU11200");
        /// </summary>
        /// 
        /// 實際位置字串
        /// "ZR30020\nZR30021\nZR30022\nZR30023\nZR30024\nZR30025\nZR30026\nZR30040\nZR30041\nZR30042\nZR30043\nZR30044\nZR30045\nZR30046\nZR30047\nZR30050\nZR30051\nZR30052\nZR30053\nZR30054\nZR30055\nZR30056\nZR30057\nZR30058"
        /// 
        ///  實際short,但是字串表示
        /// "49,46,48,46,48,46,49,49,50,58,51,48,58,49,53,65,80,76,85,49,49,49,48,49"
        /// 
        /// 
        /// <param name="ValueType"></param>
        /// <param name="Dictionary"></param>
        /// <returns></returns>
        //public int WriteDeviceRandom3(string ValueType, Dictionary<int, string> Dictionary)//v1.0.0.10 ted
        //{
        //    //取得開頭數值
        //    int[] values = Dictionary.Keys.ToArray();
        //    //取得字串列
        //    string[] stringValues = Dictionary.Values.ToArray();

        //    //創建list放置要組合成的位置資訊
        //    List<string> L_addrs = new List<string>();

        //    for (int i = 0; i < stringValues.Length; i++)
        //    {
        //        //取得n個開頭數值
        //        int iStartValue = values[i];

        //        for (int t = 0; t < stringValues[i].Length; t++)
        //        {
        //            //組合PLC記憶體位置
        //            L_addrs.Add(ValueType + iStartValue.ToString());
        //            //遞增下一個
        //            iStartValue++;
        //        }
        //    }
        //    //將list中己經組好的位置，轉換成一整個字串，分隔符號為"\n"
        //    string addrs = string.Join("\n", L_addrs.ToArray());

        //    //最後要送出命令的陣列string[] --> short[]
        //    short[] sh_array = new short[0];

        //    //將string[] 轉換成short[]後再依順序整合起來
        //    for (int i = 0; i < stringValues.Length; i++)
        //    {
        //        // 轉換每個字母為 ASCII 值
        //        short[] result = stringValues[i].Replace("\r", "").Select(c => (short)c).ToArray();

        //        sh_array = sh_array.Concat(result).ToArray();
        //    }

        //    //string TEST = string.Join(",", sh_array.ToArray());

        //    return MXCLib.WriteDeviceRandom2(addrs, sh_array.Length, sh_array);//v1.0.0.10 ted
        //}

        #endregion MyRegion
    }
}
