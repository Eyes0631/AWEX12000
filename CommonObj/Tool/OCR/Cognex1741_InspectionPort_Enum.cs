using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Cognex1741_InspectionPort
{
    public enum DefStation
    {
        None,
    }

    public enum CommDef
    {
        [Description("使用特定Config辨識")]
        READ_CONFIG,
        [Description("辨識")]
        READ,
        [Description("學習")]
        TUNE,
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
}
