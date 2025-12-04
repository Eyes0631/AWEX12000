using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using PaeLibGeneral;
using PaeLibProVSDKEx;
using ProVLib;

namespace PD2_SDK
{
    public class BaseModule
    {
        public BaseModule(DelShowAlarm ShowAlarm)
        {
            delShowAlarm = ShowAlarm;
            this.bIsSimulation = false;
            this.bDryRun = false;
        }

        [Description("模擬")]
        public bool bIsSimulation = false;
        [Description("空跑")]
        public bool bDryRun = false;
        [Description("發警報用")]
        public DelShowAlarm delShowAlarm;

        public void ShowAlarm(string AlarmLevel, int ErrorCode, params object[] args)
        {
            if (delShowAlarm != null)
            {
                delShowAlarm(AlarmLevel, ErrorCode + iAlarmCodeShift, args);
            }
        }

        public JActionTask AutoTask = new JActionTask();
        public MyTimer RunTM = new MyTimer();

        [Description("模組名稱")]
        public string MyModuleName = "NoName";
        [Description("Alarm代號位移位置")]
        public int iAlarmCodeShift = 0;

        [Description("Cylinder Delay Time")]
        public int iCylinder_DelayTime = 0;
        [Description("Cylinder Timeout")]
        public int iCylinder_Timeout = 0;

        [Description("Sensor Delay Time")]
        public int iSensor_DelayTime = 0;
        [Description("Sensor Timeout")]
        public int iSensor_Timeout = 0;

    }
}
