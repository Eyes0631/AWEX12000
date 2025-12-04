using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProVLib;
using System.Threading;
using ProVIFM;
using System.Diagnostics;
using System.Reflection;
using ProVTool;
using KCSDK;
using System.IO;

using System.Runtime.InteropServices;

namespace AWEX12000
{
    public partial class MainF1 : Form
    {
        #region 架構使用 (參數定義)

        private Object mtpMSS = null;
        private Object mtpMainFlow = null;
        private Object mtpGEM = null;

        //2020/02/05
        private Point 異常通知畫面位置;
        private bool mMouseDown = false;

        private MyTimer TAutoLogout = new MyTimer();
        #endregion

        public MainF1()
        {
            InitializeComponent();

            #region 架構使用 (參數初始化)

            //初始變數
            Width = 1440;
            Height = 900;

            //使MessageBox有多國語系的功能
            MessageBoxManager.Register();

            //設定警報系統的顯示 UI
            SYSPara.Alarm.SetLanguage("tw");
            List<object> lightio = (List<object>)SYSPara.CallProc("MAA", "GetLightIO");
            SYSPara.Alarm.SetUI(lvArmGrid.GetType(), lvArmGrid, lightio);

            //MSS 嵌入 tpMSS
            mtpMSS = tpMSS;
            tpMSS.Controls.Add(FormSet.mMSS);
            FormSet.mMSS.Dock = DockStyle.Fill;

            //MainFlow 嵌入 tpMainFlow
            mtpMainFlow = tpMainFlow;
            tpMainFlow.Controls.Add(FormSet.mMainFlow);
            FormSet.mMainFlow.Dock = DockStyle.Fill;

            //+ By Max For SECS
            //ProVGemF 嵌入 tpGEM
            int idx = SYSPara.OReadValue("CommProtocol").ToInt();
            if (idx == 1) //SECS
            {
                mtpGEM = tpCommunication;
                tpCommunication.Controls.Add(FormSet.mGemF);
                FormSet.mGemF.Dock = DockStyle.Fill;
                FormSet.mGemF.OnDataExchangeEvent += OnDataExchangeEvent;
            }
            else
            {
                tabMachineState.TabPages.Remove(tpCommunication);
            }

            //建立 AaferShowAlarm 函數
            SYSPara.Alarm.SetAfterShowAlarDelegate(AfterShowAlarm);

            TB_授權有效性.Value = SYSPara.LicenseDate;
            switch (SYSPara.LicenseMode)
            {
                case 0:
                    TB_授權模式.Value = "試用";
                    break;
                case 1:
                    TB_授權模式.Value = "單機授權";
                    TB_授權有效性.Value = "No Limit";
                    break;
                case 2:
                    TB_授權模式.Value = "天數授權";
                    break;
            }
            #endregion
        }
        
        //+ By Max For SECS
        //向GEM Form註冊DataExchange事件
        //GEM Form如有需要的資料會透過此事件向Handler要
        //或是有事件也會透過此事件通知Handler
        //使用者須在此事件中依對應的TableCode讀取相對應的參數
        /* ExchangeData資料結構
        public class ExchangeData
        {
            public string DataName;                 //資料名稱 PReadValue或OReadValue使用
            public TableCode Code;                  //OPTION、PACKAGE、PRELOADPACKAGE、REAL
            public HOSTCMD HostCMD;                 //START、STOP、PAUSE...
            public ProVLib.ProVMessage ParamMap;    //Parameter Map <參數名稱，參數值>
            public KCSDK.DataTransfer RetData;      //回傳資料可封裝在RetData中
        }
        */
        ExchangeData OnDataExchangeEvent(EventType evtType, ExchangeData exData)
        {
            switch (evtType)
            {
                case EventType.QUERY:
                    {
                        switch (exData.Code)
                        {
                            case TableCode.OPTION: //通用設定資料
                                {
                                    exData.RetData = SYSPara.OReadValue(exData.DataName);
                                }
                                break;
                            case TableCode.PACKAGE: //產品相關資料
                                {
                                    exData.RetData = SYSPara.PReadValue(exData.DataName);
                                }
                                break;
                            case TableCode.PRELOADPACKAGE: //產品管理相關資料
                                {
                                    try
                                    {
                                        //+ By Max, PPBODY Operation
                                        if (exData.DataName.Contains('.'))
                                        {
                                            string[] SubArray = exData.DataName.Split(new char[] { '.' }, StringSplitOptions.RemoveEmptyEntries);
                                            KCSDK.DataManagement.FieldData fd = FormSet.mPackage.PreloadPackageDS.FieldList.Find(x => x.DataName == SubArray[0]);
                                            exData.RetData = fd.SubPackage.ReadValue(SubArray[1]);
                                        }
                                        else
                                        {
                                            KCSDK.DataManagement.FieldData fd = FormSet.mPackage.PreloadPackageDS.FieldList.Find(x => x.DataName == exData.DataName);
                                            if (fd != null)
                                            {
                                                switch (fd.Type)
                                                {
                                                    case "String":
                                                        {
                                                            exData.RetData = FormSet.mPackage.PreloadPackageDS.ReadValue(exData.DataName);
                                                            if (exData.RetData == null)
                                                                exData.RetData = new DataTransfer("");
                                                        }
                                                        break;
                                                    case "Int":
                                                        {
                                                            exData.RetData = FormSet.mPackage.PreloadPackageDS.ReadValue(exData.DataName);
                                                            if (exData.RetData == null)
                                                                exData.RetData = new DataTransfer(0);
                                                        }
                                                        break;
                                                    case "Boolean":
                                                        {
                                                            exData.RetData = FormSet.mPackage.PreloadPackageDS.ReadValue(exData.DataName);
                                                            if (exData.RetData == null)
                                                                exData.RetData = new DataTransfer(false);
                                                        }
                                                        break;
                                                    case "Double":
                                                        {
                                                            exData.RetData = FormSet.mPackage.PreloadPackageDS.ReadValue(exData.DataName);
                                                            if (exData.RetData == null)
                                                                exData.RetData = new DataTransfer(0.0);
                                                        }
                                                        break;
                                                    case "Table":
                                                        {
                                                            String strTbl = "";
                                                            DataTable tblData = FormSet.mPackage.PreloadPackageDS.ReadTable(exData.DataName);
                                                            for (int i = 0; i < tblData.Rows.Count; ++i)
                                                            {
                                                                for (int j = 0; j < tblData.Columns.Count; ++j)
                                                                {
                                                                    strTbl += tblData.Rows[i][j].ToString();
                                                                    if (j > tblData.Columns.Count - 2)
                                                                        strTbl += ";";
                                                                    else
                                                                        strTbl += ",";
                                                                }
                                                            }
                                                            exData.RetData = new DataTransfer(strTbl);
                                                        }
                                                        break;
                                                    case "SubPackage":
                                                        {
                                                            //string[] strArray = exData.DataName.Split(new char[] { '.' }, StringSplitOptions.RemoveEmptyEntries);
                                                            //exData.RetData = fd.SubPackage.ReadValue(strArray[0], strArray[1]);
                                                            exData.RetData = new DataTransfer(fd.Value);
                                                            //if (exData.RetData == null)
                                                            //    exData.RetData = new DataTransfer(0.0);
                                                            //exData.RetData = new DataTransfer("Kinsus.xml");
                                                        }
                                                        break;
                                                }
                                            }
                                            else
                                            {
                                                String strMsg = String.Format("找不到DataName為:[{0}]的欄位資料", exData.DataName);
                                                MessageBox.Show(strMsg, "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                            }

                                        }
                                    }
                                    catch (Exception ex)
                                    {
                                        String str = ex.Message;
                                    }
                                }
                                break;
                            case TableCode.REAL: //其他即時資料
                                {
                                    switch (exData.DataName)
                                    {
                                        case "MDLN":
                                            {
                                                exData.RetData = new DataTransfer(SYSPara.EQID);
                                            }
                                            break;
                                        case "SOFTREV":
                                            {
                                                exData.RetData = new DataTransfer(FileVersionInfo.GetVersionInfo(Assembly.GetExecutingAssembly().Location).FileVersion.ToString());
                                            }
                                            break;
                                        case "PPACTION":
                                            {
                                                if (exData.ParamMap.IsParameterExisted("LISTPPID"))
                                                {
                                                    string[] list = System.IO.Directory.GetFiles(FormSet.mPackage.FolderPath, "*.xml").Select(file => System.IO.Path.GetFileName(file)).ToArray();
                                                    String ppidList = string.Join(",", list);
                                                    exData.RetData = new DataTransfer(ppidList);
                                                    SYSPara.LogSay(EnLoggerType.EnLog_COMM, "收到「取得Package列表」的遠端指令");
                                                }
                                                else if (exData.ParamMap.IsParameterExisted("DELPPID"))
                                                {
                                                    String PPIDName = (String)exData.ParamMap.GetParameter("DELPPID");
                                                    if (PPIDName == "ALL")
                                                    {
                                                        string[] list = System.IO.Directory.GetFiles(FormSet.mPackageSelF.FolderPath, "*.xml").Select(file => System.IO.Path.GetFileName(file)).ToArray();
                                                        for (int i = 0; i < list.Count(); ++i)
                                                        {
                                                            string fname = string.Format(@"{0}\{1}", FormSet.mPackageSelF.FolderPath, list[i]);
                                                            System.IO.File.Delete(fname);
                                                        }

                                                    }
                                                    else
                                                    {
                                                        string fname = string.Format(@"{0}\{1}", FormSet.mPackage.FolderPath, PPIDName);
                                                        System.IO.File.Delete(fname);
                                                    }
                                                    exData.RetData = new DataTransfer(true);
                                                    String strTemp = String.Format("收到「刪除Package : {0}」的遠端指令", PPIDName);
                                                    SYSPara.LogSay(EnLoggerType.EnLog_COMM, strTemp);
                                                }
                                                else if (exData.ParamMap.IsParameterExisted("EXISTPPID"))
                                                {
                                                    //0 = OK
                                                    //1 = Already have
                                                    //2 = No space
                                                    //3 = Invalid PPID
                                                    //4 = Busy, try later
                                                    //5 = Will not accept
                                                    //>5 = Other error
                                                    //6-63 Reserved
                                                    String PPIDName = (String)exData.ParamMap.GetParameter("EXISTPPID");
                                                    string fname = string.Format(@"{0}\{1}", FormSet.mPackage.FolderPath, PPIDName);
                                                    if (System.IO.File.Exists(fname))
                                                    {
                                                        exData.RetData = new DataTransfer(1);//Already Have
                                                    }
                                                    else
                                                    {
                                                        exData.RetData = new DataTransfer(0); //OK
                                                    }
                                                }
                                                else if (exData.ParamMap.IsParameterExisted("SELPPID"))
                                                {

                                                    String PPIDName = (String)exData.ParamMap.GetParameter("SELPPID");
                                                    string fname = string.Format(@"{0}\{1}", FormSet.mPackage.FolderPath, PPIDName);
                                                    if (System.IO.File.Exists(fname))
                                                    {
                                                        FormSet.mPackage.PreloadPackageDS.Initial(fname, PPIDName);
                                                        exData.RetData = new DataTransfer(0); //OK
                                                    }
                                                    else
                                                    {
                                                        exData.RetData = new DataTransfer(1); //NG
                                                    }

                                                }
                                                else if (exData.ParamMap.IsParameterExisted("PPID"))
                                                {
                                                    exData.RetData = new DataTransfer(FormSet.mPackage.FileName);
                                                }
                                            }
                                            break;
                                        case "GrayLevel":
                                            {
                                                exData.RetData = new DataTransfer(128);
                                            }
                                            break;
                                        case "PackageName":
                                            {
                                                exData.RetData = new DataTransfer(SYSPara.PackageName);
                                            }
                                            break;
                                    }
                                }
                                break;
                        }
                    }
                    break;
                case EventType.WRITE:
                    {
                        switch (exData.Code)
                        {
                            case TableCode.OPTION: //通用設定資料
                                {
                                    //...
                                    exData.RetData = new DataTransfer(0); //= 0 表示可設定並完成； != 0 表示不可改變或無法改變
                                }
                                break;
                            case TableCode.PACKAGE: //產品相關資料
                                {
                                    //...
                                    exData.RetData = new DataTransfer(0); //= 0 表示可設定並完成； != 0 表示不可改變或無法改變
                                }
                                break;
                            case TableCode.REAL: //其他即時資料
                                {
                                    switch (exData.DataName)
                                    {
                                        case "EstabTimeDelay":
                                            {
                                                if (exData.ParamMap.IsParameterExisted("P1"))
                                                {
                                                    ushort setVal = (ushort)exData.ParamMap.GetParameter("P1");
                                                    exData.RetData = new DataTransfer(0); //= 0 表示可設定並完成； != 0 表示不可改變或無法改變
                                                }
                                                else
                                                {
                                                    exData.RetData = new DataTransfer(1); //= 0 表示可設定並完成； != 0 表示不可改變或無法改變
                                                }
                                            }
                                            break;
                                        case "MaxTest":
                                            {
                                                if (exData.ParamMap.IsParameterExisted("P1"))
                                                {
                                                    //ushort setVal = (ushort)exData.ParamMap.GetParameter("P1");
                                                    exData.RetData = new DataTransfer(0); //= 0 表示可設定並完成； != 0 表示不可改變或無法改變
                                                }
                                                else
                                                {
                                                    exData.RetData = new DataTransfer(1); //= 0 表示可設定並完成； != 0 表示不可改變或無法改變
                                                }
                                            }
                                            break;
                                        case "PPACTION":
                                            {
                                                if (exData.ParamMap.IsParameterExisted("RCVPPID"))
                                                {
                                                    String PPIDName = (String)exData.ParamMap.GetParameter("RCVPPID");
                                                    string fname = string.Format(@"{0}\{1}", FormSet.mPackage.FolderPath, PPIDName);
                                                    FormSet.mPackage.PreloadPackageDS.Initial(fname, "Package");

                                                    //+ By Max 20190503
                                                    if (exData.ParamMap.IsParameterExisted("PKGItemData"))
                                                    {
                                                        List<PKGItem> PKGItemList = (List<PKGItem>)exData.ParamMap.GetParameter("PKGItemData");
                                                        DataManagement.FieldData fdTemp = null;
                                                        for (int i = 0; i < PKGItemList.Count; ++i)
                                                        {
                                                            PKGItem Item = PKGItemList[i];
                                                            DataManagement.FieldData fd = null;
                                                            if (Item.QueryName.Contains('.')) //判斷是否為子表格
                                                            {
                                                                string[] SubArray = Item.QueryName.Split(new char[] { '.' }, StringSplitOptions.RemoveEmptyEntries);
                                                                fd = FormSet.mPackage.PreloadPackageDS.FieldList.Find(x => x.DataName == SubArray[0]);
                                                                fd = fdTemp; //取剛剛暫存起來的子表格來使用
                                                            }
                                                            else
                                                            {
                                                                fd = FormSet.mPackage.PreloadPackageDS.FieldList.Find(x => x.DataName == Item.QueryName);
                                                                if (fd.SubPackage != null) //先將子表格的FieldData暫存起來
                                                                {
                                                                    //SubPackage 資料不作設定
                                                                    fdTemp = fd;
                                                                    continue;
                                                                }
                                                            }

                                                            if (fd != null)
                                                            {
                                                                switch (Item.Format)
                                                                {
                                                                    case "A":
                                                                        {
                                                                            //SubPackage
                                                                            if (Item.QueryName.Contains('.'))
                                                                            {
                                                                                string[] SubArray = Item.QueryName.Split(new char[] { '.' }, StringSplitOptions.RemoveEmptyEntries);
                                                                                string oldValue = fd.SubPackage.ReadValue(SubArray[1]).ToString();
                                                                                string value = Item.sData;
                                                                                fd.SubPackage.SetData(SubArray[1], "String", (object)value);
                                                                                fd.SubPackage.SaveFile();
                                                                            }
                                                                            else
                                                                            {
                                                                                if (fd.Type == "Table")
                                                                                {
                                                                                    string value = Item.sData;
                                                                                    string[] strRow = value.Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
                                                                                    fd.Table.Rows.Clear();
                                                                                    for (int m = 0; m < strRow.Count(); ++m)
                                                                                    {
                                                                                        DataRow r = fd.Table.NewRow();
                                                                                        string[] strColumn = strRow[m].Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
                                                                                        for (int n = 0; n < strColumn.Count(); ++n)
                                                                                        {
                                                                                            r[n] = (object)strColumn[n];
                                                                                            //fd.Table.Rows[m][n] = (object)strColumn[n];
                                                                                        }
                                                                                        fd.Table.Rows.Add(r);
                                                                                    }
                                                                                }
                                                                                else
                                                                                {
                                                                                    string oldValue = FormSet.mPackage.PreloadPackageDS.ReadValue(Item.QueryName).ToString();
                                                                                    string value = Item.sData;
                                                                                    FormSet.mPackage.PreloadPackageDS.SetData(Item.QueryName, "String", (object)value);
                                                                                    string newValue = FormSet.mPackage.PreloadPackageDS.ReadValue(Item.QueryName).ToString();
                                                                                }
                                                                            }
                                                                        }
                                                                        break;
                                                                    case "BOOL":
                                                                        {
                                                                            //SubPackage
                                                                            if (Item.QueryName.Contains('.'))
                                                                            {
                                                                                string[] SubArray = Item.QueryName.Split(new char[] { '.' }, StringSplitOptions.RemoveEmptyEntries);
                                                                                bool oldValue = fd.SubPackage.ReadValue(SubArray[1]).ToBoolean();
                                                                                bool value = Item.bData;
                                                                                fd.SubPackage.SetData(SubArray[1], "Boolean", (object)value);
                                                                                fd.SubPackage.SaveFile();
                                                                            }
                                                                            else
                                                                            {
                                                                                bool oldValue = FormSet.mPackage.PreloadPackageDS.ReadValue(Item.QueryName).ToBoolean();
                                                                                bool value = Item.bData;
                                                                                FormSet.mPackage.PreloadPackageDS.SetData(Item.QueryName, "Boolean", (object)value);
                                                                                bool newValue = FormSet.mPackage.PreloadPackageDS.ReadValue(Item.QueryName).ToBoolean();
                                                                            }
                                                                        }
                                                                        break;
                                                                    case "F4":
                                                                    case "F8":
                                                                        {
                                                                            //SubPackage
                                                                            if (Item.QueryName.Contains('.'))
                                                                            {
                                                                                string[] SubArray = Item.QueryName.Split(new char[] { '.' }, StringSplitOptions.RemoveEmptyEntries);
                                                                                double oldValue = fd.SubPackage.ReadValue(SubArray[1]).ToDouble();
                                                                                double value = Item.fData;
                                                                                fd.SubPackage.SetData(SubArray[1], "Double", (object)value);
                                                                                fd.SubPackage.SaveFile();
                                                                            }
                                                                            else
                                                                            {
                                                                                double oldValue = FormSet.mPackage.PreloadPackageDS.ReadValue(Item.QueryName).ToDouble();
                                                                                double value = Item.fData;
                                                                                FormSet.mPackage.PreloadPackageDS.SetData(Item.QueryName, "Double", (object)value);
                                                                                double newValue = FormSet.mPackage.PreloadPackageDS.ReadValue(Item.QueryName).ToDouble();
                                                                            }
                                                                        }
                                                                        break;
                                                                    case "I1":
                                                                    case "I2":
                                                                    case "I4":
                                                                    case "I8":
                                                                    case "U1":
                                                                    case "U2":
                                                                    case "U4":
                                                                    case "U8":
                                                                        {
                                                                            //SubPackage
                                                                            if (Item.QueryName.Contains('.'))
                                                                            {
                                                                                string[] SubArray = Item.QueryName.Split(new char[] { '.' }, StringSplitOptions.RemoveEmptyEntries);
                                                                                int oldValue = fd.SubPackage.ReadValue(SubArray[1]).ToInt();
                                                                                int value = Item.iData;
                                                                                fd.SubPackage.SetData(SubArray[1], "Int", (object)value);
                                                                                fd.SubPackage.SaveFile();
                                                                            }
                                                                            else
                                                                            {
                                                                                int oldValue = FormSet.mPackage.PreloadPackageDS.ReadValue(Item.QueryName).ToInt();
                                                                                int value = Item.iData;
                                                                                FormSet.mPackage.PreloadPackageDS.SetData(Item.QueryName, "Double", (object)value);
                                                                                int newValue = FormSet.mPackage.PreloadPackageDS.ReadValue(Item.QueryName).ToInt();
                                                                            }
                                                                        }
                                                                        break;
                                                                }
                                                            }
                                                        }
                                                    }
                                                    FormSet.mPackage.PreloadPackageDS.SaveFile(fname);
                                                    exData.RetData = new DataTransfer(0); //Ack
                                                }
                                            }
                                            break;
                                    }
                                }
                                break;
                        }
                    }
                    break;
                case EventType.COMMAND:
                    {
                        /*
                         *  Command Return Code:
                            0 = Acknowledge, command has been performed
                            1 = Command does not exist
                            2 = Cannot perform now
                            3 = At least one parameter isinvalid
                            4 = Acknowledge, command will be performed with completion signaled later by an event
                            5 = Rejected, Already in Desired Condition
                            6 = No such object exists
                            7-63 Reserved
                        */
                        switch (exData.HostCMD)
                        {
                            case HOSTCMD.INITIAL:
                                {
                                    SYSPara.LogSay(EnLoggerType.EnLog_COMM, "收到「原點復歸開始」的遠端指令");

                                    SYSPara.SysState = StateMode.SM_PACKAGELOAD_OK;

                                    SYSPara.ErrorStop = false;
                                    SYSPara.MusicOn = true;
                                    SYSPara.Alarm.ClearAll();

                                    SYSPara.SysRun = true;
                                    exData.RetData = new DataTransfer(0); //Ack
                                }
                                break;
                            case HOSTCMD.START:
                                {
                                    SYSPara.LogSay(EnLoggerType.EnLog_COMM, "收到「生產開始」的遠端指令");

                                    SYSPara.ErrorStop = false;
                                    SYSPara.MusicOn = true;
                                    SYSPara.Alarm.ClearAll();

                                    SYSPara.SysRun = true;
                                    exData.RetData = new DataTransfer(0); //Ack
                                }
                                break;
                            case HOSTCMD.LOTEND:
                                {
                                    SYSPara.LogSay(EnLoggerType.EnLog_COMM, "收到「結批」的遠端指令");
                                    SYSPara.LotendOk = false;
                                    SYSPara.Lotend = true;
                                    SYSPara.Alarm.Say("I0504"); //結批開始

                                    exData.RetData = new DataTransfer(0); //Ack
                                }
                                break;
                            case HOSTCMD.PPSELECT: //Select Package
                                {
                                    if (exData.ParamMap.IsParameterExisted("PPName"))
                                    {
                                        String strPackageName = (string)exData.ParamMap.GetParameter("PPName");
                                        if (!String.IsNullOrEmpty(strPackageName))
                                        {
                                            //Load Package ...
                                            //if (!String.IsNullOrEmpty(FormSet.mPackageSelF.FileName)) //直接換掉Package
                                            //{
                                            //    FormSet.mPackage.SetFileName(strPackageName);
                                            //    FormSet.mPackageSelF.FileName = strPackageName;
                                            //}
                                            //else //
                                            {
                                                if (InvokeRequired)
                                                {
                                                    Invoke(new SelPackageDelegate(SelPackage), strPackageName);
                                                }
                                                else
                                                {
                                                    FormSet.mPackageSelF.FolderPath = SYSPara.SysDir + @"\LocalData\Package\";
                                                    String[] strArray = strPackageName.Split(new char[] { '\\' });
                                                    FormSet.mPackageSelF.FileName = strArray[1];//strPackageName;
                                                    FormSet.mPackageSelF.FileName = Path.GetFileNameWithoutExtension(FormSet.mPackageSelF.FileName);
                                                    FormSet.mPackage.SetFileName(FormSet.mPackageSelF.FileName, "", true);
                                                    SYSPara.PackageName = FormSet.mPackageSelF.FileName;
                                                }
                                                SYSPara.SysState = StateMode.SM_PACKAGELOAD_RESET;
                                            }

                                            exData.RetData = new DataTransfer(0); //Ack
                                            SYSPara.LogSay(EnLoggerType.EnLog_COMM, "收到「載入料號」的遠端指令");
                                            String strMsg = String.Format("「料號」: {0}", strPackageName);
                                            SYSPara.LogSay(EnLoggerType.EnLog_COMM, strMsg);

                                            SYSPara.SysState = StateMode.SM_PACKAGELOAD_RESET;
                                        }
                                        else
                                        {
                                            exData.RetData = new DataTransfer(2); //Can't Perform Now
                                        }
                                    }
                                    else
                                    {
                                        exData.RetData = new DataTransfer(2); //Can't Perform Now
                                    }
                                }
                                break;
                            case HOSTCMD.STOP:
                                {
                                    exData.RetData = new DataTransfer(0); //Ack
                                }
                                break;
                            case HOSTCMD.PAUSE:
                                {
                                    if (SYSPara.SysState == StateMode.SM_ALARM)
                                    {
                                        SYSPara.ErrorStop = false;
                                        SYSPara.SysState = StateMode.SM_PAUSE;
                                    }

                                    SYSPara.MusicOn = false;
                                    FormSet.mMSS.M_Stop();

                                    SYSPara.SysRun = false;

                                    SYSPara.LogSay(EnLoggerType.EnLog_COMM, "收到「生產暫停」的遠端指令");

                                    exData.RetData = new DataTransfer(0); //Ack
                                }
                                break;
                            case HOSTCMD.RESUME:
                                {
                                    SYSPara.LogSay(EnLoggerType.EnLog_COMM, "收到「生產繼續」的遠端指令");

                                    SYSPara.ErrorStop = false;
                                    SYSPara.MusicOn = true;
                                    SYSPara.Alarm.ClearAll();

                                    SYSPara.SysRun = true;
                                    exData.RetData = new DataTransfer(0); //Ack
                                    exData.RetData = new DataTransfer(0); //Ack
                                }
                                break;
                            case HOSTCMD.ABORT:
                                {
                                    SYSPara.LogSay(EnLoggerType.EnLog_COMM, "收到「生產放棄」的遠端指令");
                                    exData.RetData = new DataTransfer(0); //Ack
                                }
                                break;
                        }
                    }
                    break;
                case EventType.STATECHANGE:
                    {
                        switch (exData.DataName)
                        {
                            case "EQPOFFLINE":
                                {
                                    SYSPara.LogSay(EnLoggerType.EnLog_COMM, "控制模式切至EQPOFFLINE");
                                }
                                break;
                            case "HOSTOFFLINE":
                                {
                                    SYSPara.LogSay(EnLoggerType.EnLog_COMM, "控制模式切至HOSTOFFLINE");
                                }
                                break;
                            case "ONLINELOCAL":
                                {
                                    SYSPara.LogSay(EnLoggerType.EnLog_COMM, "控制模式切至ONLINELOCAL");
                                }
                                break;
                            case "ONLINEREMOTE":
                                {
                                    SYSPara.LogSay(EnLoggerType.EnLog_COMM, "控制模式切至ONLINEREMOTE");
                                }
                                break;
                            case "COMMUNICATING":
                                {
                                    SYSPara.LogSay(EnLoggerType.EnLog_COMM, "連線狀態為COMMUNICATING");
                                }
                                break;
                            case "NOTCOMMUNICATING":
                                {
                                    SYSPara.LogSay(EnLoggerType.EnLog_COMM, "連線狀態為NOTCOMMUNICATING");
                                }
                                break;
                            case "DISABLED":
                                {
                                    SYSPara.LogSay(EnLoggerType.EnLog_COMM, "連線狀態為DISABLED");
                                }
                                break;

                        }
                    }
                    break;
                case EventType.SPOOLING:
                    {
                        switch (exData.DataName)
                        {
                            case "ACTIVE":
                                {
                                    SYSPara.LogSay(EnLoggerType.EnLog_COMM, "Spooling 機制運作中！");
                                }
                                break;
                            case "INACTIVE":
                                {
                                    SYSPara.LogSay(EnLoggerType.EnLog_COMM, "Spooling 機制停止運作！");
                                }
                                break;
                        }
                    }
                    break;
            }

            return exData;
        }

        #region 架構使用 (Public)

        //顯示產品名稱
        public void ShowPackageName(bool show)
        {
            string packagename = "";
            if (show)
            {
                if (string.IsNullOrEmpty(FormSet.mPackage.FolderName_Auto))
                    packagename = string.Format("{0}", FormSet.mPackage.FileName_Auto);
                else
                    packagename = string.Format("{0}_{1}", FormSet.mPackage.FolderName_Auto, FormSet.mPackage.FileName_Auto);
            }
            lbPackageName.Text = packagename;
        }

        //關閉歸零視窗
        public void ExitInitialForm()
        {
            AllFormHide();
            SetControlSW(ControlButtonType.None);
        }

        //切換至歸零視窗
        public void ChangeToInitialForm()
        {
            AllFormHide();
            //把Initial Form 載入到 pnlContainer
            pnlContainer.Controls.Add(FormSet.mInitialF);
            FormSet.mInitialF.WindowState = FormWindowState.Maximized;
            FormSet.mInitialF.Reset();
            FormSet.mInitialF.Show();

            //把 Control Button 設為不可按
            SetControlSW(ControlButtonType.Initial);
        }

        //顯示作業開始時間
        public void ShowAutoStartTM()
        {
            lbOperationStartTM.Value = DateTime.Now.ToString("G");
            lbOperationEndTM.Value = "";
        }

        //顯示作業結束時間
        public void ShowAutoEndTM()
        {
            //顯示作業結束時間
            lbOperationEndTM.Value = DateTime.Now.ToString("G");
        }

        #endregion

        #region 架構使用 (Private)

        //使用者登入
        private void UserLogin()
        {
            bool blogin = false;

            DialogResult result = System.Windows.Forms.DialogResult.None;
            while (!blogin)
            {
                switch (SYSPara.LoginMode)
                {
                    case 0:
                        result = FormSet.mUserLogin.ShowDialog();
                        break;
                    case 1:
                        result = FormSet.mUserLoginEx.ShowDialog();
                        break;
                }

                if (result == DialogResult.OK)
                {
                    if (SYSPara.mSecret.NowUser != null)
                        lbUserType.Text = SYSPara.mSecret.NowUser.Name;
                    else
                        lbUserType.Text = "Not Login";

                    AfterChangeUser();
                    blogin = true;

                    SYSPara.LogSay(EnLoggerType.EnLog_OP, string.Format("{0} 登入", lbUserType.Text));
                }
                else if (result == System.Windows.Forms.DialogResult.Cancel)
                {
                    if (SYSPara.mSecret.NowUser != null)
                    {
                        lbUserType.Text = SYSPara.mSecret.NowUser.Name;
                        blogin = true;

                        SYSPara.LogSay(EnLoggerType.EnLog_OP, string.Format("{0} 登入", lbUserType.Text));
                    }
                    else
                        lbUserType.Text = "Not Login";
                }
            }          
        }

        //更換使用者需要處理的資料
        private void AfterChangeUser()
        {
            SYSPara.mSecret.ChangeUser();
        }

        //將Panel上的所有Form給隱藏
        private void AllFormHide()
        {
            foreach (Control control in pnlContainer.Controls)
                if (control is Form)
                    ((Form)control).Parent = null;
        }

        //切換 UI 畫面
        private void PageChange(object sender, EventArgs e)
        {
            int tag = Convert.ToInt32(((Button)sender).Tag);
            switch (tag)
            {
                case 1: //自動操作
                    if (SYSPara.IsAutoMode)
                        return;

                    if (SYSPara.RunMode == RunModeDT.MAINTENANCE)
                        return;

                    AllFormHide();
                    SYSPara.LogSay(EnLoggerType.EnLog_OP, "使用者按下「自動操作」");

                    SYSPara.SysRun = false;
                    FormSet.mMSS.M_Stop();
                    SYSPara.SysState = StateMode.SM_PACKAGELOAD_RESET;

                    pnlContainer.Controls.Add(FormSet.mPackageSelF);
                    FormSet.mPackageSelF.WindowState = FormWindowState.Maximized;
                    FormSet.mPackageSelF.Show();
                    FormSet.mPackageSelF.Initial();

                    //把 Control Button 設為不可按
                    SetControlSW(ControlButtonType.Initial);
                    break;
                case 2: //手動操作
                    AllFormHide();
                    SYSPara.LogSay(EnLoggerType.EnLog_OP, "使用者按下「手動操作」");

                    SYSPara.SysRun = false;
                    FormSet.mMSS.M_Stop();
                    SYSPara.SysState = StateMode.SM_MANUAL_RESET;

                    pnlContainer.Controls.Add(FormSet.mModuleContainer);
                    FormSet.mModuleContainer.WindowState = FormWindowState.Maximized;
                    FormSet.mModuleContainer.Show();
                    FormSet.mModuleContainer.PerformClick();
                    foreach (BaseModuleInterface module in FormSet.ModuleList)
                    {
                        module.pnlAutoIOCheck.Parent = module.tpCheck;
                        module.pnlAutoIOCheck.Location = new Point(0, 0);
                    }
                    //把 Control Button 設為不可按
                    SetControlSW(ControlButtonType.Initial);
                    break;
                case 3: //產品設定
                    AllFormHide();
                    SYSPara.LogSay(EnLoggerType.EnLog_OP, "使用者按下「產品設定」");

                    SYSPara.SysRun = false;
                    FormSet.mMSS.M_Stop();

                    pnlContainer.Controls.Add(FormSet.mPackage);
                    FormSet.mPackage.WindowState = FormWindowState.Maximized;
                    FormSet.mPackage.Show();
                    FormSet.mPackage.Initial();

                    //把 Control Button 設為不可按
                    SetControlSW(ControlButtonType.Initial);
                    break;
                case 4: //通用設定
                    AllFormHide();
                    SYSPara.LogSay(EnLoggerType.EnLog_OP, "使用者按下「通用設定」");

                    SYSPara.SysRun = false;
                    FormSet.mMSS.M_Stop();

                    pnlContainer.Controls.Add(FormSet.mOption);
                    FormSet.mOption.WindowState = FormWindowState.Maximized;
                    FormSet.mOption.Show();
                    FormSet.mOption.RefreshAllData("MachineSet");
                    FormSet.mOption.InitialSubPackage();
                    break;
                case 5: //切換語系
                    SYSPara.LogSay(EnLoggerType.EnLog_OP, "使用者按下「語系切換」");
                    switch (SYSPara.Lang.GetNowLanguage())
                    {
                        case "tw":
                            SYSPara.Lang.ChangeLanguage("en");
                            foreach (BaseModuleInterface module in FormSet.ModuleList)
                                module.ChangeLanguage("en");
                            SYSPara.Alarm.SetLanguage("en");
                            break;
                        case "en":
                            SYSPara.Lang.ChangeLanguage("third");
                            foreach (BaseModuleInterface module in FormSet.ModuleList)
                                module.ChangeLanguage("third");
                            SYSPara.Alarm.SetLanguage("third");
                            break;
                        case "third":
                            SYSPara.Lang.ChangeLanguage("tw");
                            foreach (BaseModuleInterface module in FormSet.ModuleList)
                                module.ChangeLanguage("tw");
                            SYSPara.Alarm.SetLanguage("tw");
                            break;
                    }
                    break;
                case 6: //History
                    AllFormHide();
                    SYSPara.LogSay(EnLoggerType.EnLog_OP, "使用者按下「歷史記錄」");

                    pnlContainer.Controls.Add(FormSet.mLogF);
                    FormSet.mLogF.InitialLogger();
                    FormSet.mLogF.WindowState = FormWindowState.Maximized;
                    FormSet.mLogF.Show();
                    break;
            }
        }

        //控制按鈕致能
        public void SetControlSW(ControlButtonType type)
        {
            switch (type)
            {
                case ControlButtonType.Initial:
                    foreach (Control control in pnlControl.Controls)
                    {
                        if (control is Button)
                        {
                            if ((control == btnStart) || (control == btnPause) || (control == btnReset))
                                control.Enabled = true;
                            else
                                control.Enabled = false;
                        }
                    }
                    break;
                case ControlButtonType.None:
                    foreach (Control control in pnlControl.Controls)
                    {
                        if (control is Button)
                            control.Enabled = true;
                    }
                    AfterChangeUser();
                    break;
            }
        }

        //設備狀態顯示
        private void DisplaySysState()
        {
            if (SYSPara.RunMode == RunModeDT.MAINTENANCE)
                lbRunState.BackColor = Color.Aqua;
            else
            {
                if (SYSPara.SysRun)
                    lbRunState.BackColor = Color.Lime;
                else
                {
                    if (SYSPara.ErrorStop)
                        lbRunState.BackColor = Color.Red;
                    else
                        lbRunState.BackColor = Color.Yellow;
                }
            }

            lbRunState.Text = SYSPara.RunMode.ToString();
        }

        //2020/02/05
        private void lb異常訊息_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                異常通知畫面位置 = e.Location;
                mMouseDown = true;
            }
        }

        //2020/02/05
        private void lb異常訊息_MouseUp(object sender, MouseEventArgs e)
        {
            mMouseDown = false;
        }

        //2020/02/05
        private void lb異常訊息_MouseMove(object sender, MouseEventArgs e)
        {
            if (mMouseDown)
            {
                pnl異常通知.Left += (e.X - 異常通知畫面位置.X);
                pnl異常通知.Top += (e.Y - 異常通知畫面位置.Y);
            }
        }

        #endregion

        #region 架構使用 (按鈕功能)

        private void btnStart_Click(object sender, EventArgs e)
        {
            SYSPara.LogSay(EnLoggerType.EnLog_OP, "使用者按下「生產開始」");

            SYSPara.ErrorStop = false;
            SYSPara.MusicOn = true;
            SYSPara.Alarm.ClearAll();

            SYSPara.SysRun = true;
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            if (SYSPara.SysState == StateMode.SM_ALARM)
            {
                SYSPara.ErrorStop = false;
                SYSPara.SysState = StateMode.SM_PAUSE;
            }

            SYSPara.MusicOn = false;
            FormSet.mMSS.M_Stop();

            SYSPara.SysRun = false;

            SYSPara.LogSay(EnLoggerType.EnLog_OP, "使用者按下「生產暫停」");
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            if (SYSPara.IsAutoMode)
            {
                LotendSelectForm mlotendsel = new LotendSelectForm();
                DialogResult ret = mlotendsel.ShowDialog();
                switch (ret)
                {
                    case System.Windows.Forms.DialogResult.OK: //結批
                        {
                            SYSPara.LogSay(EnLoggerType.EnLog_OP, "使用者按下「結批」");
                            SYSPara.LotendOk = false;
                            SYSPara.Lotend = true;
                            SYSPara.Alarm.Say("I0504"); //結批開始
                        }
                        break;
                    case System.Windows.Forms.DialogResult.Cancel: //取消
                        SYSPara.LogSay(EnLoggerType.EnLog_OP, "使用者按下「結批歸零取消」");
                        break;
                    case System.Windows.Forms.DialogResult.Abort: //強制歸零
                        {
                            SYSPara.LogSay(EnLoggerType.EnLog_OP, "使用者按下「強制歸零」");

                            SYSPara.SysState = StateMode.SM_INIT_RESET;

                            AllFormHide();
                            //把Initial Form 載入到 pnlContainer
                            pnlContainer.Controls.Add(FormSet.mInitialF);
                            FormSet.mInitialF.WindowState = FormWindowState.Maximized;
                            FormSet.mInitialF.Reset();
                            FormSet.mInitialF.Show();

                            //把 Control Button 設為不可按
                            SetControlSW(ControlButtonType.Initial);
                        }
                        break;
                }
            }
            else
            {
                SYSPara.LogSay(EnLoggerType.EnLog_OP, "使用者按下「強制歸零」");

                SYSPara.SysState = StateMode.SM_INIT_RESET;

                AllFormHide();
                //把Initial Form 載入到 pnlContainer
                pnlContainer.Controls.Add(FormSet.mInitialF);
                FormSet.mInitialF.WindowState = FormWindowState.Maximized;
                FormSet.mInitialF.Reset();
                FormSet.mInitialF.Show();

                //把 Control Button 設為不可按
                SetControlSW(ControlButtonType.Initial);
            }

        }

        private void btnChangeUser_Click(object sender, EventArgs e)
        {
            SYSPara.LogSay(EnLoggerType.EnLog_OP, string.Format("{0} 登出", lbUserType.Text));

            FormSet.mOption.ExitClick();
            FormSet.mPackage.ExitClick();
            FormSet.mModuleContainer.ExitClick();

            //使用者登入
            UserLogin();
        }

        //+ By Max, v4.0.1.17 [修改]ALT+F4關閉不了程式
        public bool bFormClose = false;
        private void btnExit_Click(object sender, EventArgs e)
        {
            SYSPara.LogSay(EnLoggerType.EnLog_OP, "使用者按下「離開程式」");

            if (!SYSPara.SysRun)
            {
                DialogResult result = MessageBox.Show("是否要離開程式?", "注意", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                switch (result)
                {
                    case DialogResult.OK:
                        switch (SYSPara.RunMode)
                        {
                            case RunModeDT.MAINTENANCE:
                            case RunModeDT.MANUAL:
                                SYSPara.SysState = StateMode.SM_CANCEL;
                                break;
                        }

                        SYSPara.Alarm.ClearAll();
                        Thread.Sleep(200);

                        //關閉警報系統
                        SYSPara.Alarm.DisposeTH();
                        Thread.Sleep(300);

                        //+ By Max 20201104 LifeTime
                        TObjForm.ObjFormClose();

                        //關閉HMI前的動作
                        SYSPara.HMIClose = true;
                        while (SYSPara.HMIReady) ;

                        //+ By Max, v4.0.1.17 [修改]ALT+F4關閉不了程式
                        bFormClose = true;
                        Close();
                        break;
                    case DialogResult.Cancel:
                        break;
                }
            }
            else
            {
                SYSPara.Alarm.Say("I0501"); //禁止離開
            }
        }

        //+ By Max, v4.0.1.17 [修改]ALT+F4關閉不了程式
        private void MainF_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!bFormClose && e.CloseReason == CloseReason.UserClosing)
            {
                SYSPara.LogSay(EnLoggerType.EnLog_OP, "使用者按下「離開程式」");

                if (!SYSPara.SysRun)
                {
                    DialogResult result = MessageBox.Show("是否要離開程式?", "注意", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    switch (result)
                    {
                        case DialogResult.OK:
                            switch (SYSPara.RunMode)
                            {
                                case RunModeDT.MAINTENANCE:
                                case RunModeDT.MANUAL:
                                    SYSPara.SysState = StateMode.SM_CANCEL;
                                    break;
                            }

                            SYSPara.Alarm.ClearAll();
                            Thread.Sleep(200);

                            //關閉警報系統
                            SYSPara.Alarm.DisposeTH();
                            Thread.Sleep(300);

                            //+ By Max 20201104 LifeTime
                            TObjForm.ObjFormClose();

                            //關閉HMI前的動作
                            SYSPara.HMIClose = true;
                            while (SYSPara.HMIReady) ;

                            //+ By Max, v4.0.1.17 [修改]ALT+F4關閉不了程式
                            bFormClose = true;
                            Close();
                            break;
                        case DialogResult.Cancel:
                            e.Cancel = true;
                            break;
                    }
                }
                else
                {
                    SYSPara.Alarm.Say("I0501"); //禁止離開
                }
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            SYSPara.LogSay(EnLoggerType.EnLog_OP, "使用者按下「警報重置」");
            SYSPara.MusicOn = false;
            SYSPara.ErrorStop = false;
            SYSPara.Alarm.ClearAll();
            if (SYSPara.SysState == StateMode.SM_ALARM || SYSPara.SysState == StateMode.SM_PAUSE)
                SYSPara.SysState = StateMode.SM_PAUSE;
        }

        private void btnResetIDLE_Click(object sender, EventArgs e)
        {
            SYSPara.LogSay(EnLoggerType.EnLog_OP, "使用者按下「IDLE累計時間」歸零");

            SYSPara.IdleTM = 0;
        }

        private void btnResetHome_Click(object sender, EventArgs e)
        {
            SYSPara.LogSay(EnLoggerType.EnLog_OP, "使用者按下「歸零累計時間」歸零");

            SYSPara.HomeTM = 0;
        }

        private void btnResetManual_Click(object sender, EventArgs e)
        {
            SYSPara.LogSay(EnLoggerType.EnLog_OP, "使用者按下「手動操作累計時間」歸零");

            SYSPara.ManualTM = 0;
        }

        private void btnResetMaintenance_Click(object sender, EventArgs e)
        {
            SYSPara.LogSay(EnLoggerType.EnLog_OP, "使用者按下「維修累計時間」歸零");

            SYSPara.MaintenanceTM = 0;
            //+ By Max, v4.0.1.12, For Measurement Report Test
            //FormSet.mGemF.MeasurementEventReport(18);
        }

        #endregion

        #region 安全門機制改善
        private delegate void delShowMsgLabel(List<string> msglist);
        AlarmMsgFrm mAlarmfrm = null;
        private void ShowMsgLabel(List<string> msglist)
        {
            if (msglist.Count == 0)
            {
                if (mAlarmfrm != null)
                {
                    mAlarmfrm.Close();
                    mAlarmfrm = null;
                }
                return;
            }

            string msg = "";
            foreach (string value in msglist)
            {
                msg += value;
                msg += "\n";
            }
            msg = msg.Substring(0, msg.Length - 1);

            if (mAlarmfrm == null)
                mAlarmfrm = new AlarmMsgFrm();

            mAlarmfrm.SetMsg(msg);
            mAlarmfrm.Left = (Width - mAlarmfrm.Width) / 2;
            mAlarmfrm.Top = (Height - mAlarmfrm.Height) / 2;

            mAlarmfrm.Show();
        }
        private void SaftyActionDelegate(int iActionCode)
        {
            if (!SYSPara.HMIReady)
                return;

            bool 安全門偵測 = (((iActionCode & 0x02) >> 1) == 1); 
            bool 緊停偵測 = (((iActionCode & 0x04) >> 2) == 1); 
            bool 安全門偵測關閉提醒 = ((iActionCode & 0x01) == 1);

            List<string> msglist = new List<string>();
            if (緊停偵測)
            {
                msglist.Add("緊停異常通知");
                msglist.Add("EMG Stop");
            }
            if (安全門偵測)
            {
                msglist.Add("安全門打開");
                msglist.Add("SafeDoor Open");
                if (SYSPara.SetupReadValue("安全門機制設定").ToInt() == 2)
                    SYSPara.安全門開啟 = true;
            }
            if (安全門偵測關閉提醒)
            {
                msglist.Add("安全門偵測功能關閉");
                msglist.Add("SafeDoor Detect Close");
                if (SYSPara.SetupReadValue("安全門機制設定").ToInt() == 2)
                    SYSPara.安全門偵測開關關閉 = true;
            }

            if (緊停偵測 || 安全門偵測 || 安全門偵測關閉提醒)
            {
                if (InvokeRequired)               
                    BeginInvoke(new delShowMsgLabel(ShowMsgLabel), msglist);
            }
            else
            {
                msglist.Clear();
                if (InvokeRequired)
                    BeginInvoke(new delShowMsgLabel(ShowMsgLabel), msglist);
            }
        }
        #endregion

        //警報後置處理
        private void AfterShowAlarm(ArmMtrl armMtrl, bool bSet)
        {
            int idx = SYSPara.OReadValue("CommProtocol").ToInt();
            if (idx == 1) //SECS
            {
                FormSet.mGemF.AlarmReport(armMtrl, bSet);
            }

            //+ By Max For AlarmForm Show
            if (bSet)
            {
                AlarmForm.ShowAlarmForm(armMtrl);
            }
            else
            {
                AlarmForm.CloseAlarmForm();
            }

            //SYSPara.LogSay("SPC", armMtrl.Explain);
        }

        private delegate void SelPackageDelegate(String PackageName);

        private void SelPackage(String PackageName)
        {
            FormSet.mPackageSelF.FolderPath = SYSPara.SysDir + @"\LocalData\Package\";
            String[] strArray = PackageName.Split(new char[] { '\\' });
            FormSet.mPackageSelF.FileName = PackageName;
            FormSet.mPackageSelF.FileName = Path.GetFileNameWithoutExtension(FormSet.mPackageSelF.FileName);
            FormSet.mPackage.SetFileName(FormSet.mPackageSelF.FileName, "", true);
            SYSPara.PackageName = FormSet.mPackageSelF.FileName;
        }

        private void MainF1_Load(object sender, EventArgs e)
        {
            #region 架構使用 (參數初始化)
            //設定視窗使用的語系
            SYSPara.Lang.ChangeLanguage("tw");
            lbVersion.Text = string.Format("{1} Version {0}", FileVersionInfo
                .GetVersionInfo(Assembly.GetExecutingAssembly().Location).FileVersion.ToString(), SYSPara.EQID);
            lbProjectName.Text = this.GetType().Assembly.GetName().Name;

            tmUIRefresh.Enabled = true;

            SYSPara.MaxScanTime = 0;
            SYSPara.MusicOn = true;
            SYSPara.HMIReady = true;
            SYSPara.HMIClose = false;
            SYSPara.InitialOk = false;

            lbUserType.Text = "Not Login";

            #endregion

            #region 使用者修改 (顯示元件前置設定)

            //FormSet.mPackage.Initial();
            //FormSet.mOption.Initial();
            //FormSet.m內參設定.Initial();

            //安全門機制改善
            //傳送發生安全門或緊急停止開關觸發時回呼的委派函式
            //if (SYSPara.SetupReadValue("安全門機制設定").ToInt() == 2)
                SYSPara.CallProc("MAA", "RecordSaftyCheckDelegate", new Action<int>(SaftyActionDelegate));

            switch (SYSPara.SetupReadValue("警報燈號類型").ToInt())
            {
                case 0: //三色燈
                    LightLayoutPanel.ColumnCount = 3;
                    ledBlue.Visible = false;
                    break;
                case 1: //四色燈
                    break;
            }

            #endregion
        }

        private void MainF1_Shown(object sender, EventArgs e)
        {
            //使用者登入
            UserLogin();
        }

        private void tmUIRefresh_Tick(object sender, EventArgs e)
        {
            tmUIRefresh.Enabled = false;

            #region 架構使用 (定時顯示)

            //嫁動率
            double d = SYSPara.logDB.GetUtilizationRate(DateTime.Now, DateTime.Now);
            lb嫁動率.Value = string.Format("{0:0.0}", d);

            //顯示目前時間
            lbNowTime.Text = DateTime.Now.ToString("G");

            lbIdleTM.Value = UserSnippet.ToTimeString(SYSPara.IdleTM);
            lbHomeTM.Value = UserSnippet.ToTimeString(SYSPara.HomeTM);
            lbManualTM.Value = UserSnippet.ToTimeString(SYSPara.ManualTM);
            lbMaintenanceTM.Value = UserSnippet.ToTimeString(SYSPara.MaintenanceTM);

            //顯示運行時相關資料
            if (SYSPara.RunMode == RunModeDT.AUTO)
            {
                lbRunTM.Value = UserSnippet.ToTimeString(SYSPara.RunSecond);
                lbPauseTM.Value = UserSnippet.ToTimeString(SYSPara.StopSecond);
            }

            lbScanTM.Value = string.Format("{0:0.000}", SYSPara.ScanTimeEx);
            lbScanCNT.Value = SYSPara.ScanTime.ToString();

            //設備狀態顯示
            DisplaySysState();

            //顯示三色燈LED
            if ((bool)SYSPara.CallProc("MAA", "ScanRedLight"))
                ledRed.Value = KCSDK.ThreeColorLight.ColorLightType.RedLight;
            else
                ledRed.Value = KCSDK.ThreeColorLight.ColorLightType.GrayLight;
            if ((bool)SYSPara.CallProc("MAA", "ScanYellowLight"))
                ledYellow.Value = KCSDK.ThreeColorLight.ColorLightType.YellowLight;
            else
                ledYellow.Value = KCSDK.ThreeColorLight.ColorLightType.GrayLight;
            if ((bool)SYSPara.CallProc("MAA", "ScanGreenLight"))
                ledGreen.Value = KCSDK.ThreeColorLight.ColorLightType.GreenLight;
            else
                ledGreen.Value = KCSDK.ThreeColorLight.ColorLightType.GrayLight;
            if ((bool)SYSPara.CallProc("MAA", "ScanBlueLight"))
                ledBlue.Value = KCSDK.ThreeColorLight.ColorLightType.BlueLight;
            else
                ledBlue.Value = KCSDK.ThreeColorLight.ColorLightType.GrayLight;

            #endregion

            #region 使用者修改

            #endregion

            tmUIRefresh.Enabled = true;
        }

        private void UserLogOut()
        {
            SYSPara.mSecret.LoginUser("作業員");
            SYSPara.mSecret.ChangeUser();
            lbUserType.Text = "作業員";
        }

        public void ChangeUserToOP()
        {
            SYSPara.LogSay(EnLoggerType.EnLog_OP, string.Format("{0} 自動登出", lbUserType.Text));

            FormSet.mOption.ExitClick();
            FormSet.mPackage.ExitClick();
            FormSet.mModuleContainer.ExitClick();

            //使用者登入
            UserLogOut();
            //SYSPara.mSecret.LoginUser("作業員");
            //UserLogin();
        }

        /// <summary>
        /// 調用windows API獲取鼠標鍵盤空閒時間
        /// </summary>
        /// <param name="plii"></param>
        /// <returns></returns>
        [DllImport("user32.dll")]
        private static extern bool GetLastInputInfo(ref LASTINPUTINFO plii);
        /// <summary>
        /// 獲取鼠標鍵盤空閒時間
        /// </summary>
        /// <returns></returns>
        public static long GetIdleTick()
        {
            LASTINPUTINFO lastInputInfo = new LASTINPUTINFO();
            lastInputInfo.cbSize = Marshal.SizeOf(lastInputInfo);
            if (!GetLastInputInfo(ref　lastInputInfo)) return 0;
            return Environment.TickCount - (long)lastInputInfo.dwTime;
        }
        [StructLayout(LayoutKind.Sequential)]
        private struct LASTINPUTINFO
        {
            [MarshalAs(UnmanagedType.U4)]
            public int cbSize;
            [MarshalAs(UnmanagedType.U4)]
            public uint dwTime;
        }
        private void TM_AutoLogout_Tick(object sender, EventArgs e)
        {
            if (SYSPara.mSecret.NowUser != null && SYSPara.mSecret.NowUser.Level > 1)
            {
                int iAutoLogoutTime_Min = SYSPara.OReadValue("iAutoLogoutTime_Min").ToInt();
                if (iAutoLogoutTime_Min <= 0) iAutoLogoutTime_Min = 1;
                if (GetIdleTick() >= iAutoLogoutTime_Min * 60 * 1000)
                {
                    ChangeUserToOP();
                }
            }
            //TM_AutoLogout.Enabled = true;
        }
    }
}
