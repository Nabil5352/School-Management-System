namespace SMS
{
    partial class Progress
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.topBarBox = new System.Windows.Forms.GroupBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.btnForward = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.lblAdminHome = new System.Windows.Forms.Label();
            this.PersonGrpBox = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SelectShiftCombo = new System.Windows.Forms.ComboBox();
            this.ProgressControl = new System.Windows.Forms.TabControl();
            this.tabClassProgress = new System.Windows.Forms.TabPage();
            this.TermChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabTotalProgress = new System.Windows.Forms.TabPage();
            this.topBarBox.SuspendLayout();
            this.PersonGrpBox.SuspendLayout();
            this.ProgressControl.SuspendLayout();
            this.tabClassProgress.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TermChart)).BeginInit();
            this.SuspendLayout();
            // 
            // topBarBox
            // 
            this.topBarBox.Controls.Add(this.btnRefresh);
            this.topBarBox.Controls.Add(this.btnQuit);
            this.topBarBox.Controls.Add(this.btnForward);
            this.topBarBox.Controls.Add(this.btnBack);
            this.topBarBox.Controls.Add(this.btnHome);
            this.topBarBox.Location = new System.Drawing.Point(236, 15);
            this.topBarBox.Name = "topBarBox";
            this.topBarBox.Size = new System.Drawing.Size(349, 83);
            this.topBarBox.TabIndex = 16;
            this.topBarBox.TabStop = false;
            // 
            // btnRefresh
            // 
            this.btnRefresh.AccessibleDescription = "";
            this.btnRefresh.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRefresh.Image = global::SMS.Properties.Resources.refresh;
            this.btnRefresh.Location = new System.Drawing.Point(85, 14);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(52, 63);
            this.btnRefresh.TabIndex = 14;
            this.btnRefresh.UseVisualStyleBackColor = true;
            // 
            // btnQuit
            // 
            this.btnQuit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnQuit.Image = global::SMS.Properties.Resources.end;
            this.btnQuit.Location = new System.Drawing.Point(279, 14);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(50, 63);
            this.btnQuit.TabIndex = 2;
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // btnForward
            // 
            this.btnForward.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnForward.Image = global::SMS.Properties.Resources.agt_forward_256;
            this.btnForward.Location = new System.Drawing.Point(214, 14);
            this.btnForward.Name = "btnForward";
            this.btnForward.Size = new System.Drawing.Size(52, 63);
            this.btnForward.TabIndex = 1;
            this.btnForward.UseVisualStyleBackColor = true;
            // 
            // btnBack
            // 
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBack.Image = global::SMS.Properties.Resources.agt_back_256;
            this.btnBack.Location = new System.Drawing.Point(150, 14);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(50, 63);
            this.btnBack.TabIndex = 0;
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnHome
            // 
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnHome.Image = global::SMS.Properties.Resources.Home1;
            this.btnHome.Location = new System.Drawing.Point(22, 14);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(50, 63);
            this.btnHome.TabIndex = 0;
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // lblAdminHome
            // 
            this.lblAdminHome.AutoSize = true;
            this.lblAdminHome.Font = new System.Drawing.Font("Algerian", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdminHome.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblAdminHome.Location = new System.Drawing.Point(350, 638);
            this.lblAdminHome.Name = "lblAdminHome";
            this.lblAdminHome.Size = new System.Drawing.Size(105, 18);
            this.lblAdminHome.TabIndex = 15;
            this.lblAdminHome.Text = "ADMIN AREA";
            // 
            // PersonGrpBox
            // 
            this.PersonGrpBox.Controls.Add(this.label1);
            this.PersonGrpBox.Controls.Add(this.SelectShiftCombo);
            this.PersonGrpBox.Controls.Add(this.ProgressControl);
            this.PersonGrpBox.Location = new System.Drawing.Point(18, 105);
            this.PersonGrpBox.Name = "PersonGrpBox";
            this.PersonGrpBox.Size = new System.Drawing.Size(787, 521);
            this.PersonGrpBox.TabIndex = 14;
            this.PersonGrpBox.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(289, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "Shift:";
            // 
            // SelectShiftCombo
            // 
            this.SelectShiftCombo.FormattingEnabled = true;
            this.SelectShiftCombo.Location = new System.Drawing.Point(335, 34);
            this.SelectShiftCombo.Name = "SelectShiftCombo";
            this.SelectShiftCombo.Size = new System.Drawing.Size(151, 21);
            this.SelectShiftCombo.TabIndex = 3;
            this.SelectShiftCombo.SelectedIndexChanged += new System.EventHandler(this.SelectShiftCombo_SelectedIndexChanged);
            // 
            // ProgressControl
            // 
            this.ProgressControl.Controls.Add(this.tabClassProgress);
            this.ProgressControl.Controls.Add(this.tabTotalProgress);
            this.ProgressControl.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProgressControl.Location = new System.Drawing.Point(6, 79);
            this.ProgressControl.Name = "ProgressControl";
            this.ProgressControl.SelectedIndex = 0;
            this.ProgressControl.Size = new System.Drawing.Size(775, 436);
            this.ProgressControl.TabIndex = 2;
            // 
            // tabClassProgress
            // 
            this.tabClassProgress.Controls.Add(this.TermChart);
            this.tabClassProgress.Location = new System.Drawing.Point(4, 24);
            this.tabClassProgress.Name = "tabClassProgress";
            this.tabClassProgress.Padding = new System.Windows.Forms.Padding(3);
            this.tabClassProgress.Size = new System.Drawing.Size(767, 408);
            this.tabClassProgress.TabIndex = 0;
            this.tabClassProgress.Text = "Class progress";
            this.tabClassProgress.UseVisualStyleBackColor = true;
            // 
            // TermChart
            // 
            chartArea1.Area3DStyle.WallWidth = 4;
            chartArea1.AxisX.ArrowStyle = System.Windows.Forms.DataVisualization.Charting.AxisArrowStyle.Triangle;
            chartArea1.AxisX.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea1.AxisX.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea1.AxisX.IsLabelAutoFit = false;
            chartArea1.AxisX.LabelStyle.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea1.AxisX.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea1.AxisX.MajorTickMark.TickMarkStyle = System.Windows.Forms.DataVisualization.Charting.TickMarkStyle.None;
            chartArea1.AxisX2.MajorGrid.LineWidth = 0;
            chartArea1.AxisY.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea1.AxisY.IsLabelAutoFit = false;
            chartArea1.AxisY.LabelStyle.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea1.AxisY.LabelStyle.Format = "{0;0}%";
            chartArea1.AxisY.MajorGrid.LineWidth = 0;
            chartArea1.AxisY2.MajorGrid.LineWidth = 0;
            chartArea1.Name = "ChartArea1";
            this.TermChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.TermChart.Legends.Add(legend1);
            this.TermChart.Location = new System.Drawing.Point(6, 22);
            this.TermChart.Name = "TermChart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "1st Term";
            series1.YValuesPerPoint = 2;
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "2nd Term";
            series2.YValuesPerPoint = 2;
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Final Term";
            series3.YValuesPerPoint = 2;
            this.TermChart.Series.Add(series1);
            this.TermChart.Series.Add(series2);
            this.TermChart.Series.Add(series3);
            this.TermChart.Size = new System.Drawing.Size(755, 380);
            this.TermChart.TabIndex = 3;
            this.TermChart.Text = "chart1";
            // 
            // tabTotalProgress
            // 
            this.tabTotalProgress.Location = new System.Drawing.Point(4, 24);
            this.tabTotalProgress.Name = "tabTotalProgress";
            this.tabTotalProgress.Padding = new System.Windows.Forms.Padding(3);
            this.tabTotalProgress.Size = new System.Drawing.Size(767, 408);
            this.tabTotalProgress.TabIndex = 1;
            this.tabTotalProgress.Text = "Total progress";
            this.tabTotalProgress.UseVisualStyleBackColor = true;
            // 
            // Progress
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImage = global::SMS.Properties.Resources.back_progress;
            this.Controls.Add(this.topBarBox);
            this.Controls.Add(this.lblAdminHome);
            this.Controls.Add(this.PersonGrpBox);
            this.Name = "Progress";
            this.Size = new System.Drawing.Size(823, 671);
            this.topBarBox.ResumeLayout(false);
            this.PersonGrpBox.ResumeLayout(false);
            this.PersonGrpBox.PerformLayout();
            this.ProgressControl.ResumeLayout(false);
            this.tabClassProgress.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TermChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.GroupBox topBarBox;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Button btnForward;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblAdminHome;
        private System.Windows.Forms.GroupBox PersonGrpBox;
        private System.Windows.Forms.TabControl ProgressControl;
        private System.Windows.Forms.TabPage tabClassProgress;
        private System.Windows.Forms.TabPage tabTotalProgress;
        private System.Windows.Forms.DataVisualization.Charting.Chart TermChart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox SelectShiftCombo;
    }
}
