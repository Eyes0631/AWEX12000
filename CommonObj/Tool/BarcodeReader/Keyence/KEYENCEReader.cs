using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PaeLibGeneral;
using ProVTool;

namespace CommonObj
{
    
    public enum ReaderState
    {
        Unknow,
        Success,
        Fail,
        Error,
        Wait,
    }

    public enum ReaderCMD
    {
        NONE,
        SETJOB,
        TUNE,
        FOCUS,
        READ,
        QUIT,
    }

    public class KEYENCEReader
    {
        private const String FinalChar = "\r";
        private ProVClientSocket Socket = new ProVClientSocket();
        private string IP;
        private int Port;
        private int ScanTime;
        private JTimer T1 = new JTimer();
        
        private JActionTask iWorkTask = new JActionTask();
        private ReaderState State = ReaderState.Unknow;
        private ReaderCMD CMD = ReaderCMD.NONE;
        private string ReturnValue;

        public KEYENCEReader()
        {
            this.Socket.OnConnect += new ProVTool.ProVClientSocket.SocketNotifyHandler(this.Sockett_OnConnect);
            this.Socket.OnDisconnect += new ProVTool.ProVClientSocket.SocketDisconnectNotifyHandler(this.Sockett_OnDisconnect);
            this.Socket.OnRead += new ProVTool.ProVClientSocket.SocketReadNotifyHandler(this.Socket_OnRead);
            this.Socket.OnError += new ProVTool.ProVClientSocket.ErrorNotifyHandler(this.Socket_OnError);
        }

        private void Sockett_OnConnect(object sender)
        {
            JLogger.LogDebug("KEYENCEReader", "Socket | Connect");
        }

        private void Sockett_OnDisconnect(object sender, System.Net.Sockets.Socket socket)
        {
            JLogger.LogDebug("KEYENCEReader", "Socket | Disconnect");
        }

        private void Socket_OnError(object sender, int errorCode, string ErrMsg)
        {
            String msg = String.Format("Socket連線錯誤：Error Code:{0}, ErrMsg{1}", errorCode, ErrMsg);
            JLogger.LogDebug("KEYENCEReader", "Socket | " + msg);
        }

        private void Socket_OnRead(ProVTool.SocketClient sender)
        {
            string msg = sender.ReadText();
            JLogger.LogDebug("KEYENCEReader", "Socket Read | " + msg);
            try
            {
                ReturnValue += msg;
            }
            catch (Exception ex)
            {
                JLogger.LogDebug("KEYENCEReader", "Socket Read Error | " + ex.Message);
            }
        }
        public bool SetSocketPara(string _IP, int _Port, int DelayTM = 500)
        {
            bool bRet = false;
            
            try
            {
                IP = _IP;
                Port = _Port;
                ScanTime = DelayTM;
                bRet = true;
                
            }
            catch (Exception e)
            {
                string msg = string.Format("KEYENCEReader SetSocketPara:{0};\n\r堆棧追蹤:{1}", e.Message, e.StackTrace);
                JLogger.LogDebug("KEYENCEReader", "Socket Setting Error | " + msg);
            }

            return bRet;
        }

        public bool CheckConnect()
        {
            return Socket.Socket.Connected;
        }

        public bool Connect()
        {
            bool bRet = false;

            try
            {
                Socket.IP = IP;
                Socket.Port = Port;
                if (Socket.Socket != null)
                {
                    //if (Socket.Socket.Connected == false)
                        Socket.Connect();
                }
                else
                {
                    Socket.Connect();
                }
                bRet = true;
            }
            catch (Exception e)
            {
                string msg = string.Format("KEYENCEReader Connect:{0};\n\r堆棧追蹤:{1}", e.Message, e.StackTrace);
                JLogger.LogDebug("KEYENCEReader", "Socket | " + msg);
            }

            return bRet;
        }

        public bool Disconnet()
        {
            bool bRet = false;

            try
            {
                Socket.Disconnect();

                bRet = true;
            }
            catch (Exception e)
            {
                string msg = string.Format("KEYENCEReader Disconnet:{0};\n\r堆棧追蹤:{1}", e.Message, e.StackTrace);
                JLogger.LogDebug("KEYENCEReader", "Socket | " + msg);
            }

            return bRet;
        }

        public bool Reset()
        {
            bool bRet = false;

            try
            {
                State = ReaderState.Unknow;
                CMD = ReaderCMD.NONE;
                ReturnValue = "";
                iWorkTask.Reset();
                bRet = true;
            }
            catch (Exception e)
            {
                string msg = string.Format("KEYENCEReader Reset:{0};\n\r堆棧追蹤:{1}", e.Message, e.StackTrace);
                JLogger.LogDebug("KEYENCEReader", "Socket | " + msg);
            }

            return bRet;
        }

        private ReaderState SetJob(String JobName)
        {
            ReaderState state = ReaderState.Wait;

            if (Socket.Socket.Connected.Equals(false)) Connect();

            switch (iWorkTask.Value)
            {
                case 0:     //Socket 是否建立
                    {
                        if (Socket.Socket.Equals(null))
                        {
                            state = ReaderState.Error;
                        }
                        else
                        {
                            iWorkTask.Next();
                        }
                    }
                    break;
                case 1: //連線確認
                    {
                        if (Socket.Socket.Connected.Equals(false))
                        {
                            state = ReaderState.Error;
                        }
                        else
                        {
                            iWorkTask.Next();
                        }
                    }
                    break;
                case 2: //QUIT CMD
                    {
                        string msg = "PRON";
                        msg += FinalChar;
                        Socket.Socket.SendText(msg);
                        T1.Start();
                        iWorkTask.Next();
                    }
                    break;
                case 3: //等待結果
                    {
                        if (string.IsNullOrEmpty(ReturnValue).Equals(false))
                        {
                            if (ReturnValue.IndexOf("SUCCEEDED") >= 0)
                            {
                                iWorkTask.Next();
                            }
                            else if (ReturnValue.IndexOf("ER") >= 0)
                            {
                                state = ReaderState.Fail;
                            }
                        }
                    }
                    break;
                case 4: //Done
                    {
                        state = ReaderState.Success;
                    }
                    break;

            }

            return state;
        }

        private ReaderState SetFocus()
        {
            ReaderState state = ReaderState.Wait;

            if (Socket.Socket.Connected.Equals(false)) Connect();

            switch (iWorkTask.Value)
            {
                case 0:     //Socket 是否建立
                    {
                        if (Socket.Socket.Equals(null))
                        {
                            state = ReaderState.Error;
                        }
                        else
                        {
                            iWorkTask.Next();
                        }
                    }
                    break;
                case 1: //連線確認
                    {
                        if (Socket.Socket.Connected.Equals(false))
                        {
                            state = ReaderState.Error;
                        }
                        else
                        {
                            iWorkTask.Next();
                        }
                    }
                    break;
                case 2: //QUIT CMD
                    {
                        string msg = "FTUNE";
                        msg += FinalChar;
                        Socket.Socket.SendText(msg);
                        T1.Start();
                        iWorkTask.Next();
                    }
                    break;
                case 3: //等待結果
                    {
                        if (string.IsNullOrEmpty(ReturnValue).Equals(false))
                        {
                            if (ReturnValue.IndexOf("SUCCEEDED") >= 0)
                            {
                                iWorkTask.Next();
                            }
                            else if (ReturnValue.IndexOf("FAILED") >= 0)
                            {
                                state = ReaderState.Fail;
                            }
                        }
                    }
                    break;
                case 4: //Done
                    {
                        state = ReaderState.Success;
                    }
                    break;

            }

            return state;
        }

        private ReaderState SetTune(String JobName)
        {
            ReaderState state = ReaderState.Wait;

            if (Socket.Socket.Connected.Equals(false)) Connect();

            switch (iWorkTask.Value)
            {
                case 0:     //Socket 是否建立
                    {
                        if (Socket.Socket.Equals(null))
                        {
                            state = ReaderState.Error;
                        }
                        else
                        {
                            iWorkTask.Next();
                        }
                    }
                    break;
                case 1: //連線確認
                    {
                        if (Socket.Socket.Connected.Equals(false))
                        {
                            state = ReaderState.Error;
                        }
                        else
                        {
                            iWorkTask.Next();
                        }
                    }
                    break;
                case 2: //QUIT CMD
                    {
                        string msg = "TUNE";
                        msg += FinalChar;
                        Socket.Socket.SendText(msg);
                        T1.Start();
                        iWorkTask.Next();
                    }
                    break;
                case 3: //等待結果
                    {
                        if (string.IsNullOrEmpty(ReturnValue).Equals(false))
                        {
                            if (ReturnValue.IndexOf("SUCCEEDED") >= 0)
                            {
                                iWorkTask.Next();
                            }
                            else if (ReturnValue.IndexOf("FAILED") >= 0)
                            {
                                state = ReaderState.Fail;
                            }
                        }
                    }
                    break;
                case 4: //Done
                    {
                        state = ReaderState.Success;
                    }
                    break;

            }

            return state;
        }

        private ReaderState SetQuit()
        {
            ReaderState state = ReaderState.Wait;

            if (Socket.Socket.Connected.Equals(false)) Connect();

            switch (iWorkTask.Value)
            {
                case 0:     //Socket 是否建立
                    {
                        if (Socket.Socket.Equals(null))
                        {
                            state = ReaderState.Error;
                        }
                        else
                        {
                            iWorkTask.Next();
                        }
                    }
                    break;
                case 1: //連線確認
                    {
                        if (Socket.Socket.Connected.Equals(false))
                        {
                            state = ReaderState.Error;
                        }
                        else
                        {
                            iWorkTask.Next();
                        }
                    }
                    break;
                case 2: //QUIT CMD
                    {
                        string msg = "TQUIT";
                        msg += FinalChar;
                        Socket.Socket.SendText(msg);
                        T1.Start();
                        iWorkTask.Next();
                    }
                    break;
                case 3: //等待結果
                    {
                        if (string.IsNullOrEmpty(ReturnValue).Equals(false))
                        {
                            if (ReturnValue.IndexOf("OK") >= 0)
                            {
                                iWorkTask.Next();
                            }
                        }
                    }
                    break;
                case 4: //Done
                    {
                        state = ReaderState.Success;
                    }
                    break;

            }

            return state;
        }

        private ReaderState SetScan(String JobName)
        {
            ReaderState state = ReaderState.Wait;

            if (Socket.Socket.Connected.Equals(false)) Connect();

            switch (iWorkTask.Value)
            {
                case 0:     //Socket 是否建立
                    {
                        if (Socket.Socket.Equals(null))
                        {
                            state = ReaderState.Error;
                        }
                        else
                        {
                            iWorkTask.Next();
                        }
                    }
                    break;
                case 1: //連線確認
                    {
                        if (Socket.Socket.Connected.Equals(false))
                        {
                            state = ReaderState.Error;
                        }
                        else
                        {
                            iWorkTask.Next();
                        }
                    }
                    break;
                case 2: //開始讀取
                    {
                        string msg = "LON";
                        if (string.IsNullOrWhiteSpace(JobName).Equals(false))
                            msg += "," + JobName;
                        msg += FinalChar;
                        Socket.Socket.SendText(msg);
                        T1.Start();
                        iWorkTask.Next();
                    }
                    break;
                case 3: //等待結果
                    {
                        if (T1.Count(ScanTime))
                        {
                            string msg = "LOFF";
                            msg += FinalChar;
                            Socket.Socket.SendText(msg);
                            iWorkTask.Next();
                        }
                    }
                    break;
                case 4: //Done
                    {
                        state = ReaderState.Success;
                        if (string.IsNullOrEmpty(ReturnValue))
                            state = ReaderState.Fail;
                    }
                    break;
                   
            }

            return state;
        }

        public string GetValue()
        {
            return ReturnValue;
        }

        public ReaderState SendCMD(ReaderCMD _CMD, String JobName = "")
        {
            CMD = _CMD;
            switch (CMD)
            {
                case ReaderCMD.SETJOB:
                    {
                        State = SetJob(JobName);
                    }
                    break;
                case ReaderCMD.FOCUS:
                    {
                        State = SetFocus();
                    }
                    break;
                case ReaderCMD.TUNE:
                    {
                        State = SetTune(JobName);
                    }
                    break;
                case ReaderCMD.QUIT:
                    {
                        State = SetQuit();
                    }
                    break;
                case ReaderCMD.READ:
                    {
                        State = SetScan(JobName);
                    }
                    break;
            }
            return State;
        }
    }
}
