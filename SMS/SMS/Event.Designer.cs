namespace SMS
{
    partial class Event
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Event));
            this.topBarBox = new System.Windows.Forms.GroupBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.btnForward = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.Container = new System.Windows.Forms.GroupBox();
            this.YearSummaryTabs = new System.Windows.Forms.TabControl();
            this.tabHolidays = new System.Windows.Forms.TabPage();
            this.tabAppoint = new System.Windows.Forms.TabPage();
            this.weekEventBox = new System.Windows.Forms.GroupBox();
            this.thisWeekPanel = new System.Windows.Forms.Panel();
            this.TodayEventBox = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.eventCalender = new System.Windows.Forms.MonthCalendar();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ArabicDate = new System.Windows.Forms.Label();
            this.BanglaDate = new System.Windows.Forms.Label();
            this.nxt7EventBox = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblAdminHome = new System.Windows.Forms.Label();
            this.topBarBox.SuspendLayout();
            this.Container.SuspendLayout();
            this.YearSummaryTabs.SuspendLayout();
            this.weekEventBox.SuspendLayout();
            this.TodayEventBox.SuspendLayout();
            this.panel1.SuspendLayout();
            this.nxt7EventBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // topBarBox
            // 
            this.topBarBox.BackColor = System.Drawing.Color.Transparent;
            this.topBarBox.Controls.Add(this.btnRefresh);
            this.topBarBox.Controls.Add(this.btnQuit);
            this.topBarBox.Controls.Add(this.btnForward);
            this.topBarBox.Controls.Add(this.btnBack);
            this.topBarBox.Controls.Add(this.btnHome);
            this.topBarBox.Location = new System.Drawing.Point(236, 14);
            this.topBarBox.Name = "topBarBox";
            this.topBarBox.Size = new System.Drawing.Size(349, 83);
            this.topBarBox.TabIndex = 8;
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
            this.btnRefresh.TabIndex = 15;
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
            // Container
            // 
            this.Container.BackColor = System.Drawing.Color.Transparent;
            this.Container.Controls.Add(this.YearSummaryTabs);
            this.Container.Controls.Add(this.weekEventBox);
            this.Container.Controls.Add(this.TodayEventBox);
            this.Container.Controls.Add(this.nxt7EventBox);
            this.Container.Location = new System.Drawing.Point(17, 108);
            this.Container.Name = "Container";
            this.Container.Size = new System.Drawing.Size(788, 516);
            this.Container.TabIndex = 9;
            this.Container.TabStop = false;
            // 
            // YearSummaryTabs
            // 
            this.YearSummaryTabs.Controls.Add(this.tabHolidays);
            this.YearSummaryTabs.Controls.Add(this.tabAppoint);
            this.YearSummaryTabs.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YearSummaryTabs.Location = new System.Drawing.Point(433, 37);
            this.YearSummaryTabs.Name = "YearSummaryTabs";
            this.YearSummaryTabs.SelectedIndex = 0;
            this.YearSummaryTabs.Size = new System.Drawing.Size(336, 439);
            this.YearSummaryTabs.TabIndex = 0;
            // 
            // tabHolidays
            // 
            this.tabHolidays.AutoScroll = true;
            this.tabHolidays.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabHolidays.Location = new System.Drawing.Point(4, 24);
            this.tabHolidays.Name = "tabHolidays";
            this.tabHolidays.Padding = new System.Windows.Forms.Padding(3);
            this.tabHolidays.Size = new System.Drawing.Size(328, 411);
            this.tabHolidays.TabIndex = 0;
            this.tabHolidays.Text = "Holidays";
            this.tabHolidays.UseVisualStyleBackColor = true;
            // 
            // tabAppoint
            // 
            this.tabAppoint.AutoScroll = true;
            this.tabAppoint.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabAppoint.Location = new System.Drawing.Point(4, 24);
            this.tabAppoint.Name = "tabAppoint";
            this.tabAppoint.Padding = new System.Windows.Forms.Padding(3);
            this.tabAppoint.Size = new System.Drawing.Size(328, 411);
            this.tabAppoint.TabIndex = 1;
            this.tabAppoint.Text = "Appointment";
            this.tabAppoint.UseVisualStyleBackColor = true;
            // 
            // weekEventBox
            // 
            this.weekEventBox.Controls.Add(this.thisWeekPanel);
            this.weekEventBox.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weekEventBox.Location = new System.Drawing.Point(12, 301);
            this.weekEventBox.Name = "weekEventBox";
            this.weekEventBox.Size = new System.Drawing.Size(407, 200);
            this.weekEventBox.TabIndex = 3;
            this.weekEventBox.TabStop = false;
            this.weekEventBox.Text = "Next Event:";
            // 
            // thisWeekPanel
            // 
            this.thisWeekPanel.AutoScroll = true;
            this.thisWeekPanel.BackColor = System.Drawing.Color.White;
            this.thisWeekPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.thisWeekPanel.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thisWeekPanel.Location = new System.Drawing.Point(0, 27);
            this.thisWeekPanel.Name = "thisWeekPanel";
            this.thisWeekPanel.Size = new System.Drawing.Size(407, 173);
            this.thisWeekPanel.TabIndex = 0;
            // 
            // TodayEventBox
            // 
            this.TodayEventBox.BackColor = System.Drawing.Color.Transparent;
            this.TodayEventBox.Controls.Add(this.panel1);
            this.TodayEventBox.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TodayEventBox.Location = new System.Drawing.Point(12, 10);
            this.TodayEventBox.Name = "TodayEventBox";
            this.TodayEventBox.Size = new System.Drawing.Size(407, 285);
            this.TodayEventBox.TabIndex = 2;
            this.TodayEventBox.TabStop = false;
            this.TodayEventBox.Text = "Today";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.eventCalender);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.ArabicDate);
            this.panel1.Controls.Add(this.BanglaDate);
            this.panel1.Location = new System.Drawing.Point(0, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(407, 258);
            this.panel1.TabIndex = 0;
            // 
            // eventCalender
            // 
            this.eventCalender.Location = new System.Drawing.Point(79, 83);
            this.eventCalender.Name = "eventCalender";
            this.eventCalender.ShowWeekNumbers = true;
            this.eventCalender.TabIndex = 5;
            this.eventCalender.TitleBackColor = System.Drawing.SystemColors.Highlight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Constantia", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkGreen;
            this.label2.Location = new System.Drawing.Point(92, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 18);
            this.label2.TabIndex = 9;
            this.label2.Text = "Arabic:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkGreen;
            this.label1.Location = new System.Drawing.Point(98, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 23);
            this.label1.TabIndex = 8;
            this.label1.Text = "বাংলা:";
            // 
            // ArabicDate
            // 
            this.ArabicDate.AutoSize = true;
            this.ArabicDate.Font = new System.Drawing.Font("Constantia", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ArabicDate.ForeColor = System.Drawing.Color.DarkGreen;
            this.ArabicDate.Location = new System.Drawing.Point(158, 50);
            this.ArabicDate.Name = "ArabicDate";
            this.ArabicDate.Size = new System.Drawing.Size(49, 18);
            this.ArabicDate.TabIndex = 7;
            this.ArabicDate.Text = "arabic";
            // 
            // BanglaDate
            // 
            this.BanglaDate.AutoSize = true;
            this.BanglaDate.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BanglaDate.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.BanglaDate.Location = new System.Drawing.Point(157, 13);
            this.BanglaDate.Name = "BanglaDate";
            this.BanglaDate.Size = new System.Drawing.Size(66, 23);
            this.BanglaDate.TabIndex = 6;
            this.BanglaDate.Text = "bangla";
            // 
            // nxt7EventBox
            // 
            this.nxt7EventBox.BackColor = System.Drawing.Color.Transparent;
            this.nxt7EventBox.Controls.Add(this.label3);
            this.nxt7EventBox.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nxt7EventBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.nxt7EventBox.Location = new System.Drawing.Point(433, 10);
            this.nxt7EventBox.Name = "nxt7EventBox";
            this.nxt7EventBox.Size = new System.Drawing.Size(336, 491);
            this.nxt7EventBox.TabIndex = 1;
            this.nxt7EventBox.TabStop = false;
            this.nxt7EventBox.Text = "Year Summary";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Constantia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkGreen;
            this.label3.Location = new System.Drawing.Point(51, 469);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(212, 14);
            this.label3.TabIndex = 0;
            this.label3.Text = "** May depend on sighting of the Moon";
            // 
            // lblAdminHome
            // 
            this.lblAdminHome.AutoSize = true;
            this.lblAdminHome.Font = new System.Drawing.Font("Algerian", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdminHome.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblAdminHome.Location = new System.Drawing.Point(347, 636);
            this.lblAdminHome.Name = "lblAdminHome";
            this.lblAdminHome.Size = new System.Drawing.Size(105, 18);
            this.lblAdminHome.TabIndex = 10;
            this.lblAdminHome.Text = "ADMIN AREA";
            // 
            // Event
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.Controls.Add(this.lblAdminHome);
            this.Controls.Add(this.Container);
            this.Controls.Add(this.topBarBox);
            this.Name = "Event";
            this.Size = new System.Drawing.Size(823, 671);
            this.topBarBox.ResumeLayout(false);
            this.Container.ResumeLayout(false);
            this.YearSummaryTabs.ResumeLayout(false);
            this.weekEventBox.ResumeLayout(false);
            this.TodayEventBox.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.nxt7EventBox.ResumeLayout(false);
            this.nxt7EventBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox topBarBox;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Button btnForward;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.GroupBox Container;
        private System.Windows.Forms.Label lblAdminHome;
        private System.Windows.Forms.GroupBox nxt7EventBox;
        private System.Windows.Forms.GroupBox TodayEventBox;
        private System.Windows.Forms.GroupBox weekEventBox;
        private System.Windows.Forms.TabControl YearSummaryTabs;
        private System.Windows.Forms.TabPage tabHolidays;
        private System.Windows.Forms.TabPage tabAppoint;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel thisWeekPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MonthCalendar eventCalender;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ArabicDate;
        private System.Windows.Forms.Label BanglaDate;
    }
}
