using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Cognex1741_CommandPort
{
    public enum DefStation
    {
        None,
    }

    public enum CommDef
    {
        [Description("登入")]
        Login,
        [Description("載入指定Job")]
        LoadFile,
        //[Description("讀取BMP檔")]
        //ReadBMP,
        [Description("設定Online(1)/Offline(0)")]
        SetOnline,
        [Description("取得現在狀態Online(1)/Offline(0)")]
        GetOnline,
    }

    public class OCR_Command
    {
        public CommDef Command { get; set; }
        public string Config { get; set; }
        public string RevDAT { get; set; }
        public string Error_msg { get; set; }
        public string[] Parameters { get; set; }
    }

    public class OCR_Status
    {
        public string ErrorCode;
    }

    public enum TResult 
    { 
        EV_NONE = -1 /*無狀態*/,
        EV_NG = 0 /*失敗*/, 
        EV_OK = 1 /*成功 */, 
        EV_BUSY = 2
    }
}
