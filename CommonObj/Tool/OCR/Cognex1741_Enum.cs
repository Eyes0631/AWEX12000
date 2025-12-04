using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Cognex
{
    public enum DefStation
    {
        None,
    }

    public enum CommDef
    {
        [Description("是用特定Config辨識")]
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
        public string Parameter_1 { get; set; }
        public string Parameter_2 { get; set; }
        public string Parameter_3 { get; set; }
        public string Parameter_4 { get; set; }
        public string Parameter_5 { get; set; }
    }

    public class OCR_Status
    {
        public string ErrorCode;
    }
}
