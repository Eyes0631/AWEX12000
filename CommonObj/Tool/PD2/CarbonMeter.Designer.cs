namespace CommonObj
{
    partial class CarbonMeter
    {
        /// <summary> 
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 元件設計工具產生的程式碼

        /// <summary> 
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
        /// 修改這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CarbonMeter));
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title3 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title4 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title5 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title6 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart3 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart4 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart5 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart6 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.bt_ReadPower = new System.Windows.Forms.Button();
            this.bt_ReadAirFlowRate = new System.Windows.Forms.Button();
            this.bt_ReadAirPressure = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.bt_Connect = new System.Windows.Forms.Button();
            this.bt_ead_Start = new System.Windows.Forms.Button();
            this.bt_Read_Stop = new System.Windows.Forms.Button();
            this.bt_OpenAir = new System.Windows.Forms.Button();
            this.bt_CloseAir = new System.Windows.Forms.Button();
            this.bt_Disconnect = new System.Windows.Forms.Button();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.cb_IsReading = new System.Windows.Forms.CheckBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.bt_Summary = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart6)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Enabled = false;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            resources.ApplyResources(this.chart1, "chart1");
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            series1.ToolTip = "#VALY";
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Time;
            this.chart1.Series.Add(series1);
            title1.Name = "Title1";
            title1.Text = "CO2 kg(24 hr)";
            this.chart1.Titles.Add(title1);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.chart1);
            this.flowLayoutPanel2.Controls.Add(this.chart2);
            this.flowLayoutPanel2.Controls.Add(this.chart3);
            this.flowLayoutPanel2.Controls.Add(this.chart4);
            this.flowLayoutPanel2.Controls.Add(this.chart5);
            this.flowLayoutPanel2.Controls.Add(this.chart6);
            this.flowLayoutPanel2.Controls.Add(this.bt_Summary);
            resources.ApplyResources(this.flowLayoutPanel2, "flowLayoutPanel2");
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            // 
            // chart2
            // 
            chartArea2.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea2);
            legend2.Enabled = false;
            legend2.Name = "kg";
            this.chart2.Legends.Add(legend2);
            resources.ApplyResources(this.chart2, "chart2");
            this.chart2.Name = "chart2";
            series2.ChartArea = "ChartArea1";
            series2.IsVisibleInLegend = false;
            series2.Legend = "kg";
            series2.Name = "Series1";
            series2.ToolTip = "#VALY";
            series2.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Date;
            this.chart2.Series.Add(series2);
            title2.Name = "Title1";
            title2.Text = "CO2 kg(7 Day)";
            this.chart2.Titles.Add(title2);
            // 
            // chart3
            // 
            chartArea3.Name = "ChartArea1";
            this.chart3.ChartAreas.Add(chartArea3);
            legend3.Enabled = false;
            legend3.Name = "Legend1";
            this.chart3.Legends.Add(legend3);
            resources.ApplyResources(this.chart3, "chart3");
            this.chart3.Name = "chart3";
            series3.ChartArea = "ChartArea1";
            series3.IsVisibleInLegend = false;
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            series3.ToolTip = "#VALY";
            series3.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Time;
            this.chart3.Series.Add(series3);
            title3.Name = "Title1";
            title3.Text = "kWh(24 hr)";
            this.chart3.Titles.Add(title3);
            // 
            // chart4
            // 
            chartArea4.Name = "ChartArea1";
            this.chart4.ChartAreas.Add(chartArea4);
            legend4.Enabled = false;
            legend4.Name = "Legend1";
            this.chart4.Legends.Add(legend4);
            resources.ApplyResources(this.chart4, "chart4");
            this.chart4.Name = "chart4";
            series4.ChartArea = "ChartArea1";
            series4.IsVisibleInLegend = false;
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            series4.ToolTip = "#VALY";
            series4.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Date;
            this.chart4.Series.Add(series4);
            title4.Name = "Title1";
            title4.Text = "kWh(7 Day)";
            this.chart4.Titles.Add(title4);
            // 
            // chart5
            // 
            chartArea5.Name = "ChartArea1";
            this.chart5.ChartAreas.Add(chartArea5);
            legend5.Enabled = false;
            legend5.Name = "Legend1";
            this.chart5.Legends.Add(legend5);
            resources.ApplyResources(this.chart5, "chart5");
            this.chart5.Name = "chart5";
            series5.ChartArea = "ChartArea1";
            series5.IsVisibleInLegend = false;
            series5.Legend = "Legend1";
            series5.Name = "Series1";
            series5.ToolTip = "#VALY";
            series5.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Time;
            this.chart5.Series.Add(series5);
            title5.Name = "Title1";
            title5.Text = "Air Flow L(24 hr)";
            this.chart5.Titles.Add(title5);
            // 
            // chart6
            // 
            chartArea6.Name = "ChartArea1";
            this.chart6.ChartAreas.Add(chartArea6);
            legend6.Enabled = false;
            legend6.Name = "Legend1";
            this.chart6.Legends.Add(legend6);
            resources.ApplyResources(this.chart6, "chart6");
            this.chart6.Name = "chart6";
            series6.ChartArea = "ChartArea1";
            series6.IsVisibleInLegend = false;
            series6.Legend = "Legend1";
            series6.Name = "Series1";
            series6.ToolTip = "#VALY";
            series6.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Date;
            this.chart6.Series.Add(series6);
            title6.Name = "Title1";
            title6.Text = "Air Flow L(7 Day)";
            this.chart6.Titles.Add(title6);
            // 
            // bt_ReadPower
            // 
            this.bt_ReadPower.BackColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.bt_ReadPower, "bt_ReadPower");
            this.bt_ReadPower.ForeColor = System.Drawing.Color.White;
            this.bt_ReadPower.Name = "bt_ReadPower";
            this.bt_ReadPower.UseVisualStyleBackColor = false;
            this.bt_ReadPower.Click += new System.EventHandler(this.btnReadPower_Click);
            // 
            // bt_ReadAirFlowRate
            // 
            this.bt_ReadAirFlowRate.BackColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.bt_ReadAirFlowRate, "bt_ReadAirFlowRate");
            this.bt_ReadAirFlowRate.ForeColor = System.Drawing.Color.White;
            this.bt_ReadAirFlowRate.Name = "bt_ReadAirFlowRate";
            this.bt_ReadAirFlowRate.UseVisualStyleBackColor = false;
            this.bt_ReadAirFlowRate.Click += new System.EventHandler(this.bt_ReadAirFlowRate_Click);
            // 
            // bt_ReadAirPressure
            // 
            this.bt_ReadAirPressure.BackColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.bt_ReadAirPressure, "bt_ReadAirPressure");
            this.bt_ReadAirPressure.ForeColor = System.Drawing.Color.White;
            this.bt_ReadAirPressure.Name = "bt_ReadAirPressure";
            this.bt_ReadAirPressure.UseVisualStyleBackColor = false;
            this.bt_ReadAirPressure.Click += new System.EventHandler(this.btnReadAirPressure_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.bt_ReadAirPressure);
            this.flowLayoutPanel1.Controls.Add(this.bt_ReadAirFlowRate);
            this.flowLayoutPanel1.Controls.Add(this.bt_ReadPower);
            resources.ApplyResources(this.flowLayoutPanel1, "flowLayoutPanel1");
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            // 
            // bt_Connect
            // 
            this.bt_Connect.BackColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.bt_Connect, "bt_Connect");
            this.bt_Connect.ForeColor = System.Drawing.Color.White;
            this.bt_Connect.Name = "bt_Connect";
            this.bt_Connect.UseVisualStyleBackColor = false;
            this.bt_Connect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // bt_ead_Start
            // 
            this.bt_ead_Start.BackColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.bt_ead_Start, "bt_ead_Start");
            this.bt_ead_Start.ForeColor = System.Drawing.Color.White;
            this.bt_ead_Start.Name = "bt_ead_Start";
            this.bt_ead_Start.UseVisualStyleBackColor = false;
            this.bt_ead_Start.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // bt_Read_Stop
            // 
            this.bt_Read_Stop.BackColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.bt_Read_Stop, "bt_Read_Stop");
            this.bt_Read_Stop.ForeColor = System.Drawing.Color.White;
            this.bt_Read_Stop.Name = "bt_Read_Stop";
            this.bt_Read_Stop.UseVisualStyleBackColor = false;
            this.bt_Read_Stop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // bt_OpenAir
            // 
            this.bt_OpenAir.BackColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.bt_OpenAir, "bt_OpenAir");
            this.bt_OpenAir.ForeColor = System.Drawing.Color.White;
            this.bt_OpenAir.Name = "bt_OpenAir";
            this.bt_OpenAir.UseVisualStyleBackColor = false;
            this.bt_OpenAir.Click += new System.EventHandler(this.btnOpenValve_Click);
            // 
            // bt_CloseAir
            // 
            this.bt_CloseAir.BackColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.bt_CloseAir, "bt_CloseAir");
            this.bt_CloseAir.ForeColor = System.Drawing.Color.White;
            this.bt_CloseAir.Name = "bt_CloseAir";
            this.bt_CloseAir.UseVisualStyleBackColor = false;
            this.bt_CloseAir.Click += new System.EventHandler(this.btnCloseValve_Click);
            // 
            // bt_Disconnect
            // 
            this.bt_Disconnect.BackColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.bt_Disconnect, "bt_Disconnect");
            this.bt_Disconnect.ForeColor = System.Drawing.Color.White;
            this.bt_Disconnect.Name = "bt_Disconnect";
            this.bt_Disconnect.UseVisualStyleBackColor = false;
            this.bt_Disconnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.bt_CloseAir);
            this.flowLayoutPanel3.Controls.Add(this.bt_OpenAir);
            this.flowLayoutPanel3.Controls.Add(this.bt_Read_Stop);
            this.flowLayoutPanel3.Controls.Add(this.bt_ead_Start);
            this.flowLayoutPanel3.Controls.Add(this.bt_Disconnect);
            this.flowLayoutPanel3.Controls.Add(this.bt_Connect);
            this.flowLayoutPanel3.Controls.Add(this.cb_IsReading);
            resources.ApplyResources(this.flowLayoutPanel3, "flowLayoutPanel3");
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            // 
            // cb_IsReading
            // 
            resources.ApplyResources(this.cb_IsReading, "cb_IsReading");
            this.cb_IsReading.BackColor = System.Drawing.Color.Red;
            this.cb_IsReading.Name = "cb_IsReading";
            this.cb_IsReading.UseVisualStyleBackColor = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // bt_Summary
            // 
            this.bt_Summary.BackColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.bt_Summary, "bt_Summary");
            this.bt_Summary.ForeColor = System.Drawing.Color.White;
            this.bt_Summary.Name = "bt_Summary";
            this.bt_Summary.UseVisualStyleBackColor = false;
            this.bt_Summary.Click += new System.EventHandler(this.bt_Summary_Click);
            // 
            // CarbonMeter
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.flowLayoutPanel3);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "CarbonMeter";
            resources.ApplyResources(this, "$this");
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.flowLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart6)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart4;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart5;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart6;
        private System.Windows.Forms.Button bt_ReadPower;
        private System.Windows.Forms.Button bt_ReadAirFlowRate;
        private System.Windows.Forms.Button bt_ReadAirPressure;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button bt_Connect;
        private System.Windows.Forms.Button bt_ead_Start;
        private System.Windows.Forms.Button bt_Read_Stop;
        private System.Windows.Forms.Button bt_OpenAir;
        private System.Windows.Forms.Button bt_CloseAir;
        private System.Windows.Forms.Button bt_Disconnect;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.CheckBox cb_IsReading;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.Button bt_Summary;

    }
}
