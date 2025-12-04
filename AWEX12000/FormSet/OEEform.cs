using OEEsystem;
using PaeLibGeneral;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using NPOI.HSSF.UserModel;

namespace ProVSimpleProject
{
    public partial class OEEform : Form
    {
        OEECalculation OEEcalc = null;
        JWorkerThread wt = null;
        string[] LogFileNames = null;
        ProductionPeriod ProdPeriodType = ProductionPeriod.Weekly;   //預設為 weekly
        AlarmGroupBy AlarmGroupType = AlarmGroupBy.Message;    //預設為 Message
        OEEtype MachineType = OEEtype.SSVP10000;    //預設為 SSVP10000
        bool IsExtractFile = true;
        JActionFlag OEECalcFlag = null;
        int OEECalcRet = 0;
        object typeDataBase = null;

        public OEEform()
        {
            InitializeComponent();
            OEECalcFlag = new JActionFlag();
            wt = new JWorkerThread(OEECalculate);
        }

        public OEEform(object dataList)
        {
            InitializeComponent();

            OEEcalc = new OEECalculation(GetParser(SYSPara.OEERPType));
            OEECalcFlag = new JActionFlag();
            wt = new JWorkerThread(OEECalculate);
            wt.Start();

            typeDataBase = dataList;
            GetPeriod(dataList);

            ////// 從內參設定直接讀取 //////////////
            if (SYSPara.OEERPFrom == 1)
            {
                IEnumerable<string> filesO = GetLogFiles(((List<List<object>>[])dataList)[0][0][0].ToString());
                LogFileNames = filesO.ToArray();
                typeDataBase = null;
            }
            
            if (!OEECalcFlag.IsDoing())
            {
                IsExtractFile = true;
                OEECalcFlag.DoIt();
                tmUpdateData.Enabled = true;    //啟動資訊更新Timer
            }
            ///////////////////////
        }
        
        private void GetPeriod(object data)
        {
            ProductionPeriod periodOee = ProductionPeriod.Overall;
            switch (((List<List<object>>[])data)[0][0][1].ToString())
            {
                case "日":
                    periodOee = ProductionPeriod.Daily;
                    break;
                case "周":
                    periodOee = ProductionPeriod.Weekly;
                    break;
                case "月":
                    periodOee = ProductionPeriod.Monthly;
                    break;
                case "年":
                    periodOee = ProductionPeriod.Yearly;
                    break;
            }


            foreach (ToolStripMenuItem item in calculationTypeToolStripMenuItem.DropDownItems)
            {
                if (item.Text == periodOee.ToString())
                {
                    ProdPeriodType = periodOee;
                    UncheckOtherToolStripMenuItems(item);
                }
            }
        }

        private void OEEform_Load(object sender, EventArgs e)
        {
            tmUpdateStatus.Enabled = true;

            tcOEE.TabIndex = 0;
            tbOEE.Clear();
            tbAlarmDailyCount.Clear();

            string appExeFileName = Assembly.GetExecutingAssembly().Location;
            tsslVersion.Text = FileVersionInfo.GetVersionInfo(appExeFileName).FileVersion.ToString();
            tsslLastEditDate.Text = File.GetLastWriteTime(appExeFileName).ToString("yyyy/MM/dd");
            tsslAuthor.Text = "Jay Tsao";
            tsslStatus.Text = "";

            overallToolStripMenuItem.Tag = ProductionPeriod.Overall;
            dailyToolStripMenuItem.Tag = ProductionPeriod.Daily;
            weeklyToolStripMenuItem.Tag = ProductionPeriod.Weekly;
            monthlyToolStripMenuItem.Tag = ProductionPeriod.Monthly;
            yearlyToolStripMenuItem.Tag = ProductionPeriod.Yearly;

            moduleToolStripMenuItem.Tag = AlarmGroupBy.Module;
            errorCodeToolStripMenuItem.Tag = AlarmGroupBy.Code;
            messageToolStripMenuItem.Tag = AlarmGroupBy.Message;
        }

        private void OEEform_FormClosing(object sender, FormClosingEventArgs e)
        {
            wt.Stop();
            tmUpdateData.Stop();
        }

        private void InitializeOpenFileDialog(OEEtype type)
        {
            // Set the file dialog to filter for graphics files.
            switch (type)
            {
                case OEEtype.SSVP10000:
                    {
                        this.openLogFileDialog.Filter =
                            "CSV files (*.csv)|*.csv|" +
                            "LOG files (*.log)|*.log|" +
                            "TXT files (*.txt)|*.txt|" +
                            "All files (*.*)|*.*";
                    }
                    break;
                case OEEtype.TBPP14300:
                case OEEtype.TBPP15005:
                    {
                        this.openLogFileDialog.Filter =
                            "Excel2003 files (*.xls)|*.xls|" +
                            "Excel2007 (*.xlsx)|*.xlsx|" +
                            "All files (*.*)|*.*";
                    }
                    break;
                default:
                    {
                        this.openLogFileDialog.Filter = "All files (*.*)|*.*";
                    }
                    break;
            }

            // Allow the user to select multiple files.
            this.openLogFileDialog.Multiselect = true;
            this.openLogFileDialog.Title = string.Format("{0} Files Browser", type);
            
        }

        private void UncheckOtherToolStripMenuItems(ToolStripMenuItem selectedMenuItem)
        {
            selectedMenuItem.Checked = true;

            // Select the other MenuItens from the ParentMenu(OwnerItens) and unchecked this,
            // The current Linq Expression verify if the item is a real ToolStripMenuItem
            // and if the item is a another ToolStripMenuItem to uncheck this.
            foreach (var ltoolStripMenuItem in (from object
                                                    item in selectedMenuItem.Owner.Items
                                                let ltoolStripMenuItem = item as ToolStripMenuItem
                                                where ltoolStripMenuItem != null
                                                where !item.Equals(selectedMenuItem)
                                                select ltoolStripMenuItem))
                (ltoolStripMenuItem).Checked = false;

            // This line is optional, for show the mainMenu after click
            //selectedMenuItem.Owner.Show();
        }

        private void overallToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProdPeriodType = (ProductionPeriod)((ToolStripMenuItem)sender).Tag;
            UncheckOtherToolStripMenuItems((ToolStripMenuItem)sender);
        }

        private void messageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //AlarmGroupType = (AlarmGroupBy)((ToolStripMenuItem)sender).Tag;
            //UncheckOtherToolStripMenuItems((ToolStripMenuItem)sender);
            //((ToolStripMenuItem)sender).Checked = !(((ToolStripMenuItem)sender).Checked);
            if (((ToolStripMenuItem)sender).Checked)
            {
                AlarmGroupType |= (AlarmGroupBy)((ToolStripMenuItem)sender).Tag;
            }
            else
            {
                AlarmGroupType ^= (AlarmGroupBy)((ToolStripMenuItem)sender).Tag;
            }
        }


        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Exit
            FormSet.tCtrlReport.SelectedTab = FormSet.tabLog;
            this.Close();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Open
            GetProductNo();
        }

        private string GetProductNo()
        {
            string ModulePath = Directory.GetCurrentDirectory() + @"\Localdata\OEEReportLib\";

            DirectoryInfo di = new DirectoryInfo(ModulePath);
            bool isProductExist = false;
            foreach (var file in di.GetFiles())
            {
                if (file.Extension == ".dll")
                {
                    foreach (ToolStripMenuItem item in openToolStripMenuItem.DropDownItems)
                    {
                        if (!item.Text.Contains(file.Name.TrimEnd(file.Extension.ToCharArray())))                         
                            continue;
                        else
                            isProductExist = true;
                    }
                    if (!isProductExist)
                    {
                        nameProduct = file.Name.TrimEnd(file.Extension.ToCharArray());
                        openToolStripMenuItem.DropDownItems.Add(nameProduct);
                        openToolStripMenuItem.DropDownItems[openToolStripMenuItem.DropDownItems.Count - 1].Click += DllProductToolStripMenuItemClick;
                    }
                }
            }            

            return string.Empty;
        }

        private LogParser GetParser(string dllName)
        {
            string ModulePath = string.Format("{0}{1}.dll", Directory.GetCurrentDirectory() + @"\Localdata\OEEReportLib\", dllName);
            Byte[] asmdata = System.IO.File.ReadAllBytes(ModulePath);
            Assembly assembly = Assembly.Load(asmdata);

            string AssemName = assembly.GetName().Name;
            string ClassName = AssemName + "." + AssemName;

            Type type = assembly.GetType(ClassName);

            object obj = assembly.CreateInstance(type.FullName);

            LogParser lp = obj as LogParser;
            lp.typeDataBase = typeDataBase;

            return lp;
        }

        

        private void DllInitializeOpenFileDialog(string type)
        {
            switch (type)
            {
                case "SSVP10000":
                    {
                        this.openLogFileDialog.Filter =
                            "CSV files (*.csv)|*.csv|" +
                            "LOG files (*.log)|*.log|" +
                            "TXT files (*.txt)|*.txt|" +
                            "All files (*.*)|*.*";
                    }
                    break;
                case "TBPP14300":
                case "TBPP15005":
                    {
                        this.openLogFileDialog.Filter =
                            "Excel2003 files (*.xls)|*.xls|" +
                            "Excel2007 (*.xlsx)|*.xlsx|" +
                            "All files (*.*)|*.*";
                    }
                    break;
                case "StdOEE":
                    this.openLogFileDialog.Filter = "Log files (*.csv|*.csv";
                    break;
                default:
                    {
                        this.openLogFileDialog.Filter = "All files (*.*)|*.*";
                    }
                    break;
            }

            
            // Allow the user to select multiple files.
            this.openLogFileDialog.Multiselect = true;
            this.openLogFileDialog.Title = string.Format("{0} Files Browser", type);

        }


        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Save
        }

        private void importToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Import
        }

        private void exportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Export
        }

        private void reAnalyseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Re-Analyse
            if (!OEECalcFlag.IsDoing())
            {
                IsExtractFile = false;
                OEECalcFlag.DoIt();
                tmUpdateData.Enabled = true;    //啟動資訊更新Timer
            }
        }

        private void dgvAlarmsGropubyMsg_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //string message = dgvAlarmsGropubyMsg.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
            string message = dgvAlarms.Rows[e.RowIndex].Cells[3].Value.ToString();
            if (OEEcalc != null)
            {
                Dictionary<string, int> alarmCount = OEEcalc.DailyAlarmCount(message);
                string sInfo = string.Empty;
                foreach (KeyValuePair<string, int> item in alarmCount)
                {
                    sInfo += string.Format("{0:yyyy/MM/dd} : {1}\r\n",item.Key, item.Value);
                }
                sInfo += string.Format("{0}\r\n", "--------------------");
                sInfo += string.Format("Total count = {0}", alarmCount.Sum(x => x.Value));
                MessageBox.Show(sInfo, message, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dgvAlarmsGropubyMsg_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                //string message = dgvAlarmsGropubyMsg.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                string message = dgvAlarms.Rows[e.RowIndex].Cells[3].Value.ToString();
                if (OEEcalc != null)
                {
                    Dictionary<string, int> alarmCount = OEEcalc.DailyAlarmCount(message);
                    string sInfo = string.Format("【{0}】\r\n{1}\r\n", message,"-----------------");
                    foreach (KeyValuePair<string, int> item in alarmCount)
                    {
                        sInfo += string.Format("{0:yyyy/MM/dd} : {1}\r\n", item.Key, item.Value);
                    }
                    sInfo += string.Format("{0}\r\nTotal count = {1}", "-----------------", alarmCount.Sum(x => x.Value));
                    tbAlarmDailyCount.Text = sInfo;
                }
            }
        }

        private void tmUpdateData_Tick(object sender, EventArgs e)
        {
            if (OEECalcFlag.IsDone())
            {
                //Overview
                tbOEE.Clear();
                if (OEEcalc.ProductionSum.Count > 0)
                {
                    tbOEE.Text = string.Format(
                        "Overview 【{0:yyyy/MM/dd} ~ {1:yyyy/MM/dd}】\r\n" +
                        "Total Qty. = {2} pcs\t|\t" +
                        "Alarm Count = {3} times\t|\t" +
                        "Yield = {4,6:0.0000}",
                        OEEcalc.ProductionSum.Min(x => x.Period.Start), OEEcalc.ProductionSum.Max(x => x.Period.End),
                        OEEcalc.ProductionSum.Sum(x => x.Quantity),
                        OEEcalc.ProductionSum.Sum(x => x.AlarmCount),
                        (1.0f - (OEEcalc.ProductionSum.Sum(x => x.AlarmCount) / (float)OEEcalc.ProductionSum.Sum(x => x.Quantity))));
                }

                //Production
                dgvProduction.Rows.Clear();
                dgvProduction.Columns.Clear();
                dgvProduction.Columns.Add("items", "");
                List<string> TotalQty = new List<string>();
                TotalQty.Add("Total Qty.");
                List<string> AlarmCount = new List<string>();
                AlarmCount.Add("Alarm Count");
                List<string> Yeild = new List<string>();
                Yeild.Add("Yeild");
                List<string> MUBA = new List<string>();
                MUBA.Add("MUBA");
                List<string> OperatingTime = new List<string>();
                OperatingTime.Add("Operating Time");
                List<string> Availability = new List<string>();
                Availability.Add("Availability");
                List<string> UPH = new List<string>();
                UPH.Add("UPH");
                for (int i = 0; i < OEEcalc.ProductionSum.Count; ++i)
                {
                    //Add new Column
                    string columnName = string.Format("col{0}", i);
                    dgvProduction.Columns.Add(columnName, OEEcalc.ProductionSum[i].Title);

                    //Add row data (for this column)
                    TotalQty.Add(OEEcalc.ProductionSum[i].Quantity.ToString());
                    AlarmCount.Add(OEEcalc.ProductionSum[i].AlarmCount.ToString());
                    Yeild.Add(string.Format("{0,6:0.0000}", OEEcalc.ProductionSum[i].Yield));
                    MUBA.Add(string.Format("{0}", OEEcalc.ProductionSum[i].MUBA));
                    OperatingTime.Add(string.Format("{0:D2}:{1:D2}:{2:D2}",
                        OEEcalc.ProductionSum[i].OperatingTime.Hours, OEEcalc.ProductionSum[i].OperatingTime.Minutes, OEEcalc.ProductionSum[i].OperatingTime.Seconds));
                    Availability.Add(string.Format("{0,6:0.0000}", OEEcalc.ProductionSum[i].Availability));
                    UPH.Add(string.Format("{0}", OEEcalc.ProductionSum[i].UPH));
                }
                dgvProduction.Rows.Add(TotalQty.ToArray());
                dgvProduction.Rows.Add(AlarmCount.ToArray());
                dgvProduction.Rows.Add(Yeild.ToArray());
                dgvProduction.Rows.Add(MUBA.ToArray());
                dgvProduction.Rows.Add(OperatingTime.ToArray());
                dgvProduction.Rows.Add(Availability.ToArray());
                dgvProduction.Rows.Add(UPH.ToArray());
                for (int i = 0; i < dgvProduction.Columns.Count; ++i)
                {
                    //關閉所有欄位排序功能
                    dgvProduction.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
                }
                dgvProduction.Columns[0].Frozen = true; //固定第一行

                int chartWidth = ((OEEcalc.ProductionSum.Count * 50) + 200);
                chartQty.Width = chartWidth;
                chartUPH.Width = chartWidth;
                chartYield.Width = chartWidth;
                chartMUBA.Width = chartWidth;
                chartAvailability.Width = chartWidth;
                chartOperationTime.Width = chartWidth;

                DisplayProductionData(chartQty, OEEcalc.ProductionSum.Select(x => x.Title).ToList(), OEEcalc.ProductionSum.Select(x => x.Quantity).ToList(),
                    "Quantity", SeriesChartType.Column, Color.Gold, "{0:D}");
                DisplayProductionData(chartUPH, OEEcalc.ProductionSum.Select(x => x.Title).ToList(), OEEcalc.ProductionSum.Select(x => x.UPH).ToList(),
                    "UPH", SeriesChartType.Column, Color.Blue, "{0:D}");
                DisplayProductionData(chartYield, OEEcalc.ProductionSum.Select(x => x.Title).ToList(), OEEcalc.ProductionSum.Select(x => x.Yield).ToList(),
                    "Yield", SeriesChartType.Column, Color.IndianRed, "{0:P}");
                DisplayProductionData(chartMUBA, OEEcalc.ProductionSum.Select(x => x.Title).ToList(), OEEcalc.ProductionSum.Select(x => x.MUBA).ToList(),
                    "MUBA", SeriesChartType.Column, Color.OrangeRed, "{0:0}");
                DisplayProductionData(chartAvailability, OEEcalc.ProductionSum.Select(x => x.Title).ToList(), OEEcalc.ProductionSum.Select(x => x.Availability).ToList(),
                    "Availability", SeriesChartType.Column, Color.YellowGreen, "{0:P}");
                DisplayProductionData(chartOperationTime, OEEcalc.ProductionSum.Select(x => x.Title).ToList(), OEEcalc.ProductionSum.Select(x => x.OperatingTime.TotalSeconds).ToList(),
                    "Operating Time", SeriesChartType.Column, Color.DarkSeaGreen, "{0:D}");

                //Alarm List
                string[] title = new string[] { "No", "Module", "Recipe", "ErrorCode", "Alarm Message", "Count", "Percentage", "CumuLative Percentage" };
                int[] lengthTT = new int[] { 100, 100, 100, 100, 500, 80, 100, 100 };
                dgvAlarms.Columns.Clear();
                for (int i = 0; i < title.Length; i++)
                {
                    dgvAlarms.Columns.Add(title[i].Trim(' '), title[i]);
                    //dgvAlarms.Columns[i].HeaderText = title[i];
                    dgvAlarms.Columns[i].Width = lengthTT[i]; // 設定為 100 像素
                    dgvAlarms.Columns[i].Frozen = true; // 讓第一欄固定不動
                    dgvAlarms.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter; // 文字置中
                    dgvAlarms.Columns[i].DefaultCellStyle.BackColor = Color.LightGray; // 設定背景顏色
                    dgvAlarms.Columns[i].ReadOnly = true;
                }

                dgvAlarms.Rows.Clear();
                tbAlarmDailyCount.Clear();
                for (int i = 0; i < OEEcalc.AlarmSum.Count; ++i)
                {
                    dgvAlarms.Rows.Add(new string[] { 
                                string.Format("Top{0}", (i + 1)), 
                                OEEcalc.AlarmSum[i].Alarm.Module,
                                OEEcalc.AlarmSum[i].Alarm.Recipe,
                                OEEcalc.AlarmSum[i].Alarm.Code, 
                                OEEcalc.AlarmSum[i].Alarm.Message, 
                                OEEcalc.AlarmSum[i].Count.ToString(), 
                                string.Format("{0,6:0.0000}", OEEcalc.AlarmSum[i].Percentage), 
                                string.Format("{0,6:0.0000}", OEEcalc.AlarmSum[i].CumulativePercentage) });
                }
                tmUpdateData.Enabled = false;
            }
        }

        private void tmUpdateStatus_Tick(object sender, EventArgs e)
        {
            switch (OEECalcRet)
            {
                case 0:
                    {
                        tspbOEEprogress.Value = 0;
                        UpdateStatus("OEEperformance Initialized.");
                    }
                    break;
                case 1:
                    {
                        tspbOEEprogress.Value = tspbOEEprogress.Maximum;
                        UpdateStatus("Data Analysis Completed.");
                    }
                    break;
                case 2:
                    {
                        if (tspbOEEprogress.Value.Equals(tspbOEEprogress.Maximum))
                        {
                            tspbOEEprogress.Value = 0;
                        }
                        tspbOEEprogress.PerformStep();
                        UpdateStatus("Data Analyzing...");
                    }
                    break;
                case -1:
                    {
                        UpdateStatus("System Error!");
                    }
                    break;
                case -2:
                    {
                        UpdateStatus("OEE Calculation Error!");
                    }
                    break;
            }

            fileToolStripMenuItem.Enabled = (OEECalcRet != 2);
            toolToolStripMenuItem.Enabled = (OEECalcRet != 2);
        }

        private void DisplayProductionData(Chart chart, IEnumerable xValue, IEnumerable yValuePrimary,
            string title, SeriesChartType type, Color color, string labelFormat = "{0:F2}")
        {
            //Reset Data
            chart.Titles.Clear();
            chart.ChartAreas.Clear();
            chart.Series.Clear();

            Color _backColor = Color.DimGray;
            Color _foreColor = Color.WhiteSmoke;
            Color _lineColor = Color.DarkGray;
            Font _titleFont = new Font("Consolas", 12F, FontStyle.Bold);
            Font _labelFont = new Font("Consolas", 8F, FontStyle.Bold);

            chart.BackColor = _backColor;
            chart.ForeColor = _foreColor;

            chart.Titles.Add(new Title(title, Docking.Top, _titleFont, color));

            chart.ChartAreas.Add(title);
            chart.ChartAreas[title].BackColor = _backColor;

            chart.ChartAreas[title].AxisX.LineColor = _lineColor;
            chart.ChartAreas[title].AxisX.LabelStyle.Font = _labelFont;
            chart.ChartAreas[title].AxisX.LabelStyle.ForeColor = _foreColor;
            chart.ChartAreas[title].AxisX.MajorTickMark.LineColor = _lineColor;
            chart.ChartAreas[title].AxisX.MajorGrid.Enabled = false;
            chart.ChartAreas[title].AxisX.MajorGrid.LineColor = _lineColor;

            //chart.ChartAreas[title].AxisY.Title = title;
            //chart.ChartAreas[title].AxisY.TitleFont = _titleFont;
            //chart.ChartAreas[title].AxisY.TitleForeColor = color;
            chart.ChartAreas[title].AxisY.LineColor = _lineColor;
            chart.ChartAreas[title].AxisY.LabelStyle.Font = _labelFont;
            chart.ChartAreas[title].AxisY.LabelStyle.ForeColor = _foreColor;
            chart.ChartAreas[title].AxisY.MajorTickMark.LineColor = _lineColor;
            chart.ChartAreas[title].AxisY.MajorGrid.Enabled = false;
            chart.ChartAreas[title].AxisY.MajorGrid.LineColor = _lineColor;

            if (yValuePrimary != null)
            {
                Series _serial = new Series();
                _serial.ChartType = type;
                //_serial.YAxisType = AxisType.Primary;
                _serial.Color = color;
                _serial.IsValueShownAsLabel = true;
                _serial.LabelForeColor = _foreColor;
                //_serial.LabelBackColor = _backColor;
                _serial.LabelFormat = labelFormat;
                _serial.Points.DataBindXY(xValue, yValuePrimary);
                _serial.Font = _labelFont;
                chart.Series.Add(_serial);
            }
        }

        /// <summary>
        /// 統計生產資料
        /// </summary>
        /// <returns></returns>
        private void OEECalculate()
        {
            if (OEECalcFlag.IsDoIt())
            {
                OEECalcRet = 2; //Busy
                OEECalcFlag.Doing();
                if (OEEcalc != null)
                {
                    if (OEEcalc.Summary(LogFileNames, ProdPeriodType, AlarmGroupType, IsExtractFile))
                    {
                        OEECalcRet = 1;     //Done
                        OEECalcFlag.Done();
                    }
                    else
                    {
                        OEECalcRet = -2;  //OEE Calculation Error!
                        OEECalcFlag.Done();
                    }
                }
                else
                {
                    OEECalcRet = -1;  //System Error!
                    OEECalcFlag.Done();
                }
            }
        }

        private void UpdateStatus(string s)
        {
            tsslStatus.Text = s;
        }

        private string nameProduct = string.Empty;
        private void DllProductToolStripMenuItemClick(object sender, EventArgs e)
        {
            nameProduct = (sender as ToolStripMenuItem).Text;
            
            if (typeDataBase != null)
            {
                OEEcalc = new OEECalculation(GetParser(nameProduct));
                IsExtractFile = true;
                OEECalcFlag.DoIt();
                tmUpdateData.Enabled = true;    //啟動資訊更新Timer
            }
            else
            {
                OEEcalc = new OEECalculation(GetParser(nameProduct));
                DllInitializeOpenFileDialog(nameProduct);
                if (!OEECalcFlag.IsDoing())
                {
                    if (this.openLogFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        LogFileNames = this.openLogFileDialog.FileNames;
                        IsExtractFile = true;
                        OEECalcFlag.DoIt();
                        tmUpdateData.Enabled = true;    //啟動資訊更新Timer
                    }
                }
            }
        }

        private void GetMachineType()
        { 
        
        }
        private void ProductToolStripMenuItemClick(object sender,EventArgs e)
        {
            MachineType = (OEEtype)((ToolStripMenuItem)sender).Tag;
            InitializeOpenFileDialog(MachineType);
            if (!OEECalcFlag.IsDoing())
            {
                if (this.openLogFileDialog.ShowDialog() == DialogResult.OK)
                {
                    LogFileNames = this.openLogFileDialog.FileNames;
                    IsExtractFile = true;
                    OEECalcFlag.DoIt();
                    tmUpdateData.Enabled = true;    //啟動資訊更新Timer
                }
            }
        }
        
        private void exportToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var workbook = new HSSFWorkbook();
            var sheetReportResult = workbook.CreateSheet("Alarm List");

            int row_idx = 0;
            sheetReportResult.CreateRow(row_idx);
            for (int i = 0; i < dgvAlarms.ColumnCount; i++)
            {
                sheetReportResult.GetRow(row_idx).CreateCell(i).SetCellValue(dgvAlarms.Columns[i].HeaderText);
            }

            row_idx = 1;
            sheetReportResult.CreateRow(row_idx);
            for (int r = 0; r < dgvAlarms.Rows.Count; r++)
            {
                sheetReportResult.CreateRow(row_idx + r);
                for (int i = 0; i < dgvAlarms.ColumnCount; i++)
                {
                    sheetReportResult.GetRow(row_idx + r).CreateCell(i).SetCellValue(dgvAlarms.Rows[r].Cells[i].Value.ToString());
                    sheetReportResult.AutoSizeColumn(i);
                }
            }
            var file = new FileStream("D:\\Alarm_List.xls", FileMode.Create);
            workbook.Write(file);
            file.Close();           

            MessageBox.Show("Export to D:\\Alarm_List.xls");
        }


        private IEnumerable<string> GetLogFiles(string period)
        {
            DateTime dtStart = DateTime.Parse(period.Split('~')[0]);
            DateTime dtEnd = DateTime.Parse(period.Split('~')[1]);


            var files = Directory.EnumerateFiles(@"D:\Log\")
                                .Where(file => new FileInfo(file).LastWriteTime < dtEnd)
                                .Where(file => new FileInfo(file).LastWriteTime > dtStart)
                                .Where(file => new FileInfo(file).Extension == ".csv" );


            return (IEnumerable<string>)files;
        }
    }

}
