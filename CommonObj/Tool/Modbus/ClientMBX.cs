using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProVTool;
using PaeLibGeneral;
using System.Net.Sockets;
using System.Windows.Forms;
using System.IO.Ports;

namespace CommonObj.ModbusTCP
{
    public class ClientMBX
    {
        public ProVClientSocket newclient = null;
        public SerialPort newSerialPort = null;
        public eConnectedMode _ConnectMode;
        byte[] byLastSent = null; //SeriaPort用
        private List<byte> receiveBuffer = new List<byte>();
        //private TAsyncMsgFlusher log;
        /// <summary>
        /// 委派顯示訊息
        /// </summary>
        public delegate void DelShowMsg(string Msg);
        public DelShowMsg delShowMsg;
        /// <summary>
        /// 委派傳出接收的訊息
        /// </summary>
        public delegate void DelShowRecMsg(byte[] data);
        public DelShowRecMsg delShowRecMsg;
        /// <summary>
        /// Log儲存路徑，預設 D:\Log\
        /// </summary>
        public string LogPath = @"D:\Log\";
        /// <summary>
        /// Log名稱，預設 ModbusTCP
        /// </summary>
        public string LogName = "ModbusTCP";
        /// <summary>
        /// 是否要記錄Log，預設 TRUE
        /// </summary>
        public bool SaveLog = true;
        /// <summary>
        /// 是否連線，預設 FALSE
        /// </summary>
        private bool _Connected = false;
        public bool Connected
        {
            get
            {
                switch (_ConnectMode)
                {
                    case eConnectedMode.Ethernet:
                        return _Connected;
                        //break;
                    case eConnectedMode.RS232:
                        return newSerialPort.IsOpen;
                        //break;
                    default:
                        break;
                }
                return false;
            }

            set { _Connected = value; }
        }

        private string IP;
        private string Port;

        private object SendLock = new object();

        private bool[] RequestArray = new bool[255];

        private bool _OnReadFinish = true;
        public bool OnReadFinish
        {
            get { return _OnReadFinish; }
            set { _OnReadFinish = value; }
        }
        public ClientMBX(eConnectedMode mode)
        {
            _ConnectMode = mode;

            switch (_ConnectMode)
            {
                case eConnectedMode.RS232:
                    {
                        newSerialPort = new System.IO.Ports.SerialPort();
                        newSerialPort.DataReceived += ClientSerial_OnRead;
                    }
                    break;
                case eConnectedMode.Ethernet:
                    {
                        newclient = new ProVClientSocket();
                        newclient.OnConnect += ClientScoket_OnConnect;
                        newclient.OnRead += ClientScoket_OnRead;
                        newclient.OnDisconnect += ClientScoket_OnDisconnect;
                        newclient.OnError += ClientScoket_OnError;
                    }
                    break;
                default:
                    break;
            }
        }

        #region 私有函數
        /// <summary>
        /// 透過委派顯示訊息
        /// </summary>
        /// <param name="Msg"></param>
        private void ShowMsg(string Msg)
        {
            if (delShowMsg != null)
            {
                delShowMsg(Msg + Environment.NewLine);
            }
        }
        /// <summary>
        /// Log紀錄
        /// </summary>
        /// <param name="Title">標題</param>
        /// <param name="Msg">訊息</param>
        private void LogTrace(string Title, string Msg)
        {
            if (SaveLog)
            {
                try
                {
                    JLogger.LogTrace(Title, Msg, true, LogName + ".txt", LogPath);
                }
                catch (Exception ex)
                {
                    ShowMsg(ex.Message);
                }
            }
        }
        /// <summary>
        /// 錯誤事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="errorCode"></param>
        /// <param name="ErrMsg"></param>
        private void ClientScoket_OnError(object sender, int errorCode, string ErrMsg)
        {
            ShowMsg(ErrMsg);
            LogTrace("Error", ErrMsg);
        }
        /// <summary>
        /// 離線事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="socket"></param>
        private void ClientScoket_OnDisconnect(object sender, Socket socket)
        {
            Connected = false;
            string Msg = "Connect is break";
            ShowMsg(Msg);
            LogTrace("System", Msg);
        }
        /// <summary>
        /// 連線事件
        /// </summary>
        /// <param name="sender"></param>
        private void ClientScoket_OnConnect(object sender)
        {
            Connected = true;
            string Msg = "Connect success";
            ShowMsg(Msg);
            LogTrace("System", Msg);
        }
        /// <summary>
        /// 監聽事件
        /// </summary>
        /// <param name="sender"></param>
        private void ClientScoket_OnRead(SocketClient sender)
        {
            try
            {
                byte[] data = sender.ReadBuf();
                if(delShowRecMsg!=null)
                {
                    delShowRecMsg(data);
                }
                //RequestArray[(int)data[1]] = true;

                _OnReadFinish = true;

                string str = BitConverter.ToString(data);
                string direction = "<-";
                ShowMsg(direction + str);
                LogTrace("System", direction + str);
            }
            catch (Exception ex)
            {
                ShowMsg( ex.Message);
                LogTrace("OnRead Error", ex.Message);
            }

        }
        /// <summary>
        /// RS232 OnRead
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="MsgArgs"></param>
        private void ClientSerial_OnRead(object sender, SerialDataReceivedEventArgs MsgArgs)
        {
            try
            {
                if ((sender as SerialPort).BytesToRead > 0)
                {
                    int n = newSerialPort.BytesToRead;                         //先記錄下來，避免某種原因，人為的原因，操作幾次之間時間長，快取不一致  
                    byte[] data = new byte[n];                               //宣告一個臨時陣列儲存當前來的串列埠資料  
                    newSerialPort.Read(data, 0, n);                             //讀取緩衝資料  

                    receiveBuffer.AddRange(data);
                    int i = 0;
                    while (i <= receiveBuffer.Count - 5) // 最少 3 byte 資料 + 2 byte CRC
                    {
                        // 嘗試計算 CRC
                        for (int length = 3; i + length + 2 <= receiveBuffer.Count; length++)
                        {
                            byte[] candidate = receiveBuffer.GetRange(i, length).ToArray();
                            byte[] crc = CRC16(candidate, candidate.Length);

                            // 檢查 CRC 是否匹配
                            if (crc[0] == receiveBuffer[i + length] && crc[1] == receiveBuffer[i + length + 1])
                            {
                                candidate = receiveBuffer.GetRange(i, length + 2).ToArray();
                                // 找到一筆完整 frame
                                if (delShowRecMsg != null)
                                {
                                    delShowRecMsg(candidate);
                                }
                                //RequestArray[(int)data[1]] = true;

                                _OnReadFinish = true;

                                string str = BitConverter.ToString(candidate.ToArray());
                                string direction = "<-";
                                ShowMsg(direction + str);
                                LogTrace("System", direction + str);

                                // 移除已處理的資料（含 CRC）
                                receiveBuffer.RemoveRange(i, length + 2);

                                // 從頭重新檢查 buffer
                                i = -1;
                                break;
                            }
                        }
                        i++;
                    }

                    if (receiveBuffer.Count > 256)
                    {
                        receiveBuffer.Clear();
                    }
                }
            }
            catch (Exception ex)
            {
                ShowMsg(ex.Message);
                LogTrace("ClientSerial_OnRead Error", ex.Message);
            }
        }
        /// <summary>
        /// 建立 Modbus 讀取請求封包
        /// </summary>
        private byte[] CreateRequest(byte TransactionID, byte unitId, byte functionCode, ushort startAddress, ushort count)
        {
            byte[] request = null;
            switch (_ConnectMode)
            {
                case eConnectedMode.Ethernet:
                    {
                        request = new byte[]
                        {
                            0x00, TransactionID, // Transaction ID
                            0x00, 0x00, // Protocol ID (Modbus TCP)
                            0x00, 0x06, // Message Length
                            unitId,     // Unit ID
                            functionCode, // Modbus 功能碼
                            (byte)(startAddress >> 8), (byte)startAddress, // 起始位址
                            (byte)(count >> 8), (byte)count  // 讀取長度
                        };
                    }
                    break;
                case eConnectedMode.RS232:
                    {
                        request = new byte[8];

                        request[0] = unitId;     // Unit ID
                        request[1] = functionCode; // Modbus 功能碼
                        request[2] = (byte)(startAddress >> 8);
                        request[3] = (byte)startAddress; // 起始位址
                        request[4] = (byte)(count >> 8);
                        request[5] = (byte)count;  // 讀取長度

                        byte[] crc = CRC16(request, 6);
                        request[6] = crc[0];
                        request[7] = crc[1]; 
                    }
                    break;
                default:
                    break;
            }
            return request;
        }
        /// <summary>
        /// 建立 多個暫存器 Modbus 讀取請求封包
        /// </summary>
        private byte[] CreateWriteMultipleRequest(byte TransactionID, byte unitId, ushort startAddress, ushort[] values)
        {
            byte[] request = new byte[13 + values.Length * 2];
            request[0] = 0x00; // Transaction ID
            request[1] = TransactionID; // Transaction ID
            request[2] = 0x00; // Protocol ID
            request[3] = 0x00; // Protocol ID
            request[4] = (byte)((values.Length * 2 + 7) >> 8); // Length high byte
            request[5] = (byte)((values.Length * 2 + 7) & 0xFF); // Length low byte
            request[6] = unitId; // Unit ID
            request[7] = 0x10; // Function code for Write Multiple Registers
            request[8] = (byte)(startAddress >> 8); // Start address high byte
            request[9] = (byte)(startAddress & 0xFF); // Start address low byte
            request[10] = (byte)(values.Length >> 8); // Number of registers high byte
            request[11] = (byte)(values.Length & 0xFF); // Number of registers low byte
            request[12] = (byte)(values.Length * 2); // Byte count (number of bytes to follow)

            // 填充暫存器值
            int byteIndex = 12;
            foreach (var value in values)
            {
                byteIndex++;
                request[byteIndex] = (byte)(value >> 8); // 高位元
                byteIndex++;
                request[byteIndex] = (byte)(value & 0xFF); // 低位元
            }

            return request;
        }
        /// <summary>
        /// 發送 Modbus 請求並接收回應
        /// </summary>
        private void SendRequest(byte[] request)
        {
            if (!Connected)
            {
                Connect(); // 確保連線有效
            }

            lock (SendLock)
            {
                _OnReadFinish = false;

                //RequestArray[(int)request[1]] = false;
                switch (_ConnectMode)
                {
                    case eConnectedMode.Ethernet:
                        {
                            newclient.Socket.SendBuf(request); // 發送請求
                        }
                        break;
                    case eConnectedMode.RS232:
                        {
                            receiveBuffer.Clear();
                            newSerialPort.Write(request, 0, request.Length);
                            byLastSent = request;
                        }
                        break;
                    default:
                        break;
                }

                string str = BitConverter.ToString(request);
                string direction = "->";
                ShowMsg(direction + str);
                LogTrace("System", direction + str);
            }
        }
        // CRC16 Modbus 計算
        private byte[] CRC16(byte[] data, int length)
        {
            ushort crc = 0xFFFF;
            for (int i = 0; i < length; i++)
            {
                crc ^= data[i];
                for (int j = 0; j < 8; j++)
                {
                    if ((crc & 0x0001) != 0)
                    {
                        crc >>= 1;
                        crc ^= 0xA001;
                    }
                    else
                    {
                        crc >>= 1;
                    }
                }
            }
            return new byte[] { (byte)(crc & 0xFF), (byte)((crc >> 8) & 0xFF) };
        }

        private bool VerifyModbusCRC(byte[] data)
        {
            if (data == null || data.Length < 3)
                return false; // 至少要有地址 + 功能碼 + CRC

            // 計算CRC（不含最後兩個位元組）
            byte[] calculated = CRC16(data, data.Length - 2);

            // 取出接收到的CRC（最後兩個位元組）
            byte receivedLow = data[data.Length - 2];
            byte receivedHigh = data[data.Length - 1];

            return (calculated[0] == receivedLow && calculated[1] == receivedHigh);
        }

        private int GetExpectedLength(byte[] buffer)
{
    // 判斷封包長度
    if (buffer.Length < 3) return 0;

    byte functionCode = buffer[1];
    if (functionCode == 0x03 || functionCode == 0x04) // 讀取保持/輸入暫存器
    {
        if (buffer.Length >= 3)
        {
            int byteCount = buffer[2];
            return 3 + byteCount + 2; // 地址+功能碼+Byte數+資料+CRC
        }
    }
    // 其他功能碼可自行擴充
    return 0;
}
        #endregion 私有函數

        #region 公用函數
        public bool SetIPnPort(string sIP, ushort uPORT)
        {
            string ip = sIP.Trim();//刪除前後空白字元
            IP = ip;
            Port = uPORT.ToString();
            return true;
        }

        public bool SetComPort(string Port, string Baudrate, string DataBits, string strStopBits, string strParity)
        {
            if (newSerialPort != null)
            {
                try
                {
                    int iBaudRate = Convert.ToInt32(Baudrate);
                    int iDataBit = Convert.ToInt32(DataBits);
                    newSerialPort.PortName = Port;
                    newSerialPort.BaudRate = iBaudRate;
                    newSerialPort.DataBits = iDataBit;

                    switch (strStopBits)
                    {
                        case "1":
                            newSerialPort.StopBits = StopBits.One;
                            break;

                        case "1.5":
                            newSerialPort.StopBits = StopBits.OnePointFive;
                            break;

                        case "2":
                            newSerialPort.StopBits = StopBits.Two;
                            break;

                        default:
                            ShowMsg("Error：停止位參數不正確!");
                            return false;
                    }

                    switch (strParity)
                    {
                        case "None": //None
                            newSerialPort.Parity = Parity.None;
                            break;
                        case "Odd"://Odd
                            newSerialPort.Parity = Parity.Odd;
                            break;
                        case "Even"://Even
                            newSerialPort.Parity = Parity.Even;
                            break;
                        default:
                            ShowMsg("Error：校驗位參數不正確!");
                            return false;
                    }
                    newSerialPort.NewLine = "\r";
                    newSerialPort.RtsEnable = true;
                    return true;
                }
                catch (Exception ex)
                {
                    ShowMsg("Error:" + ex.Message);
                    return false;
                }
            }

            ShowMsg("尚未初始化");
            return false;
        }
        /// <summary>
        /// 連線
        /// </summary>
        /// <returns></returns>
        public int Connect()
        {
            try
            {
                switch (_ConnectMode)
                {
                    case eConnectedMode.Ethernet:
                        {
                            IP = "192.168.0.110";
                            string ipadd = IP.Trim();//將服務器IP地址存放在字符串 ipadd中  
                            int port = Convert.ToInt32(Port.Trim());//將端口號強制爲32位整型，存放在port中  

                            //創建一個套接字   
                            //IPEndPoint ie = new IPEndPoint(IPAddress.Parse(ipadd), port);
                            //newclient = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                            newclient.IP = ipadd;
                            newclient.Port = port;

                            //將套接字與遠程服務器地址相連  
                            //newclient.Connect(ie);
                            return newclient.Connect();
                        }
                        //break;
                    case eConnectedMode.RS232:
                        {
                            if (Connected == false)
                                newSerialPort.Open();
                        }
                        break;
                    default:
                        break;
                }
                return 0;
            }
            catch (Exception ex)
            {
                ShowMsg(ex.Message);
                LogTrace("System", ex.Message);
                return -999;
            }
        }
        /// <summary>
        /// 斷線
        /// </summary>
        public void DisConnect()
        {
            switch (_ConnectMode)
            {
                case eConnectedMode.Ethernet:
                    {
                        newclient.Disconnect();
                    }
                    break;
                case eConnectedMode.RS232:
                    {
                        newSerialPort.Close();
                    }
                    break;
                default:
                    break;
            }
        }
        /// <summary>
        /// 讀取 Holding Registers (0x03)
        /// </summary>
        public void ReadHoldingRegisters(byte TransactionID, byte unitId, ushort startAddress, ushort numRegisters)
        {
            byte[] request = CreateRequest(TransactionID, unitId, 0x03, startAddress, numRegisters);
            SendRequest(request);
        }
        /// <summary>
        /// 寫入 單個暫存器 (0x06)
        /// </summary>
        public bool WriteSingleRegister(byte TransactionID, byte unitId, ushort address, ushort value)
        {
            byte[] request = CreateRequest(TransactionID, unitId, 0x06, address, value);
            SendRequest(request);
            return true;
        }
        /// <summary>
        /// 寫入 多個暫存器 (0x10)
        /// </summary>
        public bool WriteMultipleRegisters(byte TransactionID, byte unitId, ushort startAddress, ushort[] values)
        {
            byte[] request = CreateWriteMultipleRequest(TransactionID, unitId, startAddress, values);
            SendRequest(request);
            return true;
        }
        /// <summary>
        /// 取得指定Request
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public bool GetRequest(int index)
        {
            return RequestArray[index];
        }
        /// <summary>
        /// 將word轉成char陣列
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static char[] BytesToBinaryCharArray(ushort word)
        {
            // 轉換為 16 位元的 char 陣列
            char[] result = new char[16];
            for (int i = 0; i < 16; i++)
            {
                result[15 - i] = (word & (1 << i)) != 0 ? '1' : '0'; // 逐位檢查
            }
            return result;
        }
        /// <summary>
        /// 將word轉成bool陣列
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static bool[] BytesToBinaryBoolArray(ushort word)
        {
            // 轉換為 16 位元的 bool 陣列
            bool[] result = new bool[16];
            for (int i = 0; i < 16; i++)
            {
                result[i] = (word & (1 << i)) != 0; // 逐位檢查
            }
            return result;
        }
        /// <summary>
        /// 將word轉成int
        /// </summary>
        /// <param name="high"></param>
        /// <param name="low"></param>
        /// <returns></returns>
        public static int BytesToInt32(ushort word)
        {
            //將高位 byte 左移 8 位，低位 byte 直接 OR 運算
            return (int)word;
        }

        public static int BytesToInt16(ushort word)
        {
            byte[] bytes = BitConverter.GetBytes(word);
            return BitConverter.ToInt16(bytes, 0);
        }
        /// <summary>
        /// 將兩個word轉成float
        /// </summary>
        /// <param name="word1"></param>
        /// <param name="word2"></param>
        /// <returns></returns>
        public static float WordsToFloat(ushort word1, ushort word2)
        {
            // 先將兩個 16-bit word 組合成 4 個 byte（低位在前，高位在後）
            byte[] bytes = new byte[4];
            bytes[0] = (byte)(word1 & 0xFF);      // 低 8 位
            bytes[1] = (byte)(word1 >> 8);        // 高 8 位
            bytes[2] = (byte)(word2 & 0xFF);      // 低 8 位
            bytes[3] = (byte)(word2 >> 8);        // 高 8 位

            // 轉換為 float
            return BitConverter.ToSingle(bytes, 0);
        }
        /// <summary>
        /// 將兩個word轉成int
        /// </summary>
        /// <param name="word1"></param>
        /// <param name="word2"></param>
        /// <returns></returns>
        public static int WordsToInt(byte lowByte, byte highByte, bool signedResult = true)
        {
            byte[] bytes = new byte[2] { lowByte, highByte };

            if (!BitConverter.IsLittleEndian)
                Array.Reverse(bytes);

            if (signedResult)
                return BitConverter.ToInt16(bytes, 0);
            else
                return BitConverter.ToUInt16(bytes, 0);
        }
        /// <summary>
        /// 16 個 bool 值合併為 1 個 word
        /// </summary>
        /// <param name="bits"></param>
        /// <returns></returns>
        public static ushort BoolArrayToWord(bool[] bits)
        {
            if (bits.Length != 16)
                throw new ArgumentException("輸入的布林陣列長度必須為 16");

            ushort word = 0;
            for (int i = 0; i < 16; i++)
            {
                if (bits[i])
                {
                    word |= (ushort)(1 << (i)); // 設置對應的位元
                }
            }
            return word;
        }
        #endregion 公用函數
    }
}
