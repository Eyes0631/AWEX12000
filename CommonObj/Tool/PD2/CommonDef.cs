using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PD2_SDK
{
    public enum TransferMode
    {
        None,
        Output,
        Input,
    }

    public enum EDirection
    {
        Forward,
        Backward,
        Left,
        Right,
    }

    //public enum ECylinderAction
    //{
    //    Open,
    //    Close,
    //}
    public delegate void DelShowAlarm(string AlarmLevel, int ErrorCode, params object[] args);
}
