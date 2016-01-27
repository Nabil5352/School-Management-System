namespace SMS
{
    partial class Classes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Classes));
            this.clsGrpBox = new System.Windows.Forms.GroupBox();
            this.lblSelectShift = new System.Windows.Forms.Label();
            this.selectShiftCombo = new System.Windows.Forms.ComboBox();
            this.stdOptionBox = new System.Windows.Forms.GroupBox();
            this.clsList = new System.Windows.Forms.ListBox();
            this.topBarBox = new System.Windows.Forms.GroupBox();
            this.lblAdminHome = new System.Windows.Forms.Label();
            this.btnClsProgress = new System.Windows.Forms.Button();
            this.btnClsEdit = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.btnForward = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblClsInfoSpecialTxt = new System.Windows.Forms.Label();
            this.lblClsInfoCCaptainTxt = new System.Windows.Forms.Label();
            this.lblClsInfoCTeacherTxt = new System.Windows.Forms.Label();
            this.lblClsInfoStdNoTxt = new System.Windows.Forms.Label();
            this.lblClsInfoClassTxt = new System.Windows.Forms.Label();
            this.lblClsInfoStdNo = new System.Windows.Forms.Label();
            this.lblClsInfoTeacher = new System.Windows.Forms.Label();
            this.lblClsInfoShift = new System.Windows.Forms.Label();
            this.lblClsInfoSection = new System.Windows.Forms.Label();
            this.lblClsInfoCls = new System.Windows.Forms.Label();
            this.clsGrpBox.SuspendLayout();
            this.stdOptionBox.SuspendLayout();
            this.topBarBox.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // clsGrpBox
            // 
            this.clsGrpBox.Controls.Add(this.panel1);
            this.clsGrpBox.Controls.Add(this.lblSelectShift);
            this.clsGrpBox.Controls.Add(this.selectShiftCombo);
            this.clsGrpBox.Controls.Add(this.stdOptionBox);
            this.clsGrpBox.Controls.Add(this.clsList);
            this.clsGrpBox.Location = new System.Drawing.Point(18, 104);
            this.clsGrpBox.Name = "clsGrpBox";
            this.clsGrpBox.Size = new System.Drawing.Size(787, 521);
            this.clsGrpBox.TabIndex = 14;
            this.clsGrpBox.TabStop = false;
            // 
            // lblSelectShift
            // 
            this.lblSelectShift.AutoSize = true;
            this.lblSelectShift.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectShift.Location = new System.Drawing.Point(46, 31);
            this.lblSelectShift.Name = "lblSelectShift";
            this.lblSelectShift.Size = new System.Drawing.Size(40, 15);
            this.lblSelectShift.TabIndex = 7;
            this.lblSelectShift.Text = "Shift:";
            // 
            // selectShiftCombo
            // 
            this.selectShiftCombo.FormattingEnabled = true;
            this.selectShiftCombo.Location = new System.Drawing.Point(92, 29);
            this.selectShiftCombo.Name = "selectShiftCombo";
            this.selectShiftCombo.Size = new System.Drawing.Size(200, 21);
            this.selectShiftCombo.TabIndex = 6;
            this.selectShiftCombo.SelectedIndexChanged += new System.EventHandler(this.selectShiftCombo_SelectedIndexChanged);
            // 
            // stdOptionBox
            // 
            this.stdOptionBox.Controls.Add(this.btnClsProgress);
            this.stdOptionBox.Controls.Add(this.btnClsEdit);
            this.stdOptionBox.Location = new System.Drawing.Point(427, 355);
            this.stdOptionBox.Name = "stdOptionBox";
            this.stdOptionBox.Size = new System.Drawing.Size(290, 148);
            this.stdOptionBox.TabIndex = 1;
            this.stdOptionBox.TabStop = false;
            // 
            // clsList
            // 
            this.clsList.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clsList.FormattingEnabled = true;
            this.clsList.ItemHeight = 17;
            this.clsList.Location = new System.Drawing.Point(7, 68);
            this.clsList.Name = "clsList";
            this.clsList.Size = new System.Drawing.Size(346, 429);
            this.clsList.TabIndex = 0;
            this.clsList.SelectedIndexChanged += new System.EventHandler(this.clsList_SelectedIndexChanged);
            // 
            // topBarBox
            // 
            this.topBarBox.Controls.Add(this.btnRefresh);
            this.topBarBox.Controls.Add(this.btnQuit);
            this.topBarBox.Controls.Add(this.btnForward);
            this.topBarBox.Controls.Add(this.btnBack);
            this.topBarBox.Controls.Add(this.btnHome);
            this.topBarBox.Location = new System.Drawing.Point(235, 14);
            this.topBarBox.Name = "topBarBox";
            this.topBarBox.Size = new System.Drawing.Size(345, 83);
            this.topBarBox.TabIndex = 16;
            this.topBarBox.TabStop = false;
            // 
            // lblAdminHome
            // 
            this.lblAdminHome.AutoSize = true;
            this.lblAdminHome.Font = new System.Drawing.Font("Algerian", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdminHome.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblAdminHome.Location = new System.Drawing.Point(329, 637);
            this.lblAdminHome.Name = "lblAdminHome";
            this.lblAdminHome.Size = new System.Drawing.Size(156, 18);
            this.lblAdminHome.TabIndex = 15;
            this.lblAdminHome.Text = "ADMIN : USER AREA";
            // 
            // btnClsProgress
            // 
            this.btnClsProgress.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClsProgress.Image = global::SMS.Properties.Resources.schoolEdit;
            this.btnClsProgress.Location = new System.Drawing.Point(156, 19);
            this.btnClsProgress.Name = "btnClsProgress";
            this.btnClsProgress.Size = new System.Drawing.Size(102, 109);
            this.btnClsProgress.TabIndex = 0;
            this.btnClsProgress.Text = "Class Progress";
            this.btnClsProgress.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnClsProgress.UseVisualStyleBackColor = true;
            this.btnClsProgress.Click += new System.EventHandler(this.btnClsProgress_Click);
            // 
            // btnClsEdit
            // 
            this.btnClsEdit.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClsEdit.Image = global::SMS.Properties.Resources.EditSchoolInfol;
            this.btnClsEdit.Location = new System.Drawing.Point(31, 19);
            this.btnClsEdit.Name = "btnClsEdit";
            this.btnClsEdit.Size = new System.Drawing.Size(102, 109);
            this.btnClsEdit.TabIndex = 0;
            this.btnClsEdit.Text = "Edit Info";
            this.btnClsEdit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnClsEdit.UseVisualStyleBackColor = true;
            this.btnClsEdit.Click += new System.EventHandler(this.btnClsEdit_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.AccessibleDescription = "";
            this.btnRefresh.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRefresh.Image = global::SMS.Properties.Resources.refresh;
            this.btnRefresh.Location = new System.Drawing.Point(84, 14);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(52, 63);
            this.btnRefresh.TabIndex = 15;
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnQuit.Image = global::SMS.Properties.Resources.end;
            this.btnQuit.Location = new System.Drawing.Point(276, 14);
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
            this.btnForward.Location = new System.Drawing.Point(211, 14);
            this.btnForward.Name = "btnForward";
            this.btnForward.Size = new System.Drawing.Size(52, 63);
            this.btnForward.TabIndex = 1;
            this.btnForward.UseVisualStyleBackColor = true;
            // 
            // btnBack
            // 
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBack.Image = global::SMS.Properties.Resources.agt_back_256;
            this.btnBack.Location = new System.Drawing.Point(147, 14);
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblClsInfoSpecialTxt);
            this.panel1.Controls.Add(this.lblClsInfoCCaptainTxt);
            this.panel1.Controls.Add(this.lblClsInfoCTeacherTxt);
            this.panel1.Controls.Add(this.lblClsInfoStdNoTxt);
            this.panel1.Controls.Add(this.lblClsInfoClassTxt);
            this.panel1.Controls.Add(this.lblClsInfoStdNo);
            this.panel1.Controls.Add(this.lblClsInfoTeacher);
            this.panel1.Controls.Add(this.lblClsInfoShift);
            this.panel1.Controls.Add(this.lblClsInfoSection);
            this.panel1.Controls.Add(this.lblClsInfoCls);
            this.panel1.Location = new System.Drawing.Point(379, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(387, 318);
            this.panel1.TabIndex = 8;
            // 
            // lblClsInfoSpecialTxt
            // 
            this.lblClsInfoSpecialTxt.AutoSize = true;
            this.lblClsInfoSpecialTxt.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClsInfoSpecialTxt.Location = new System.Drawing.Point(189, 248);
            this.lblClsInfoSpecialTxt.Name = "lblClsInfoSpecialTxt";
            this.lblClsInfoSpecialTxt.Size = new System.Drawing.Size(12, 18);
            this.lblClsInfoSpecialTxt.TabIndex = 20;
            this.lblClsInfoSpecialTxt.Text = "-";
            // 
            // lblClsInfoCCaptainTxt
            // 
            this.lblClsInfoCCaptainTxt.AutoSize = true;
            this.lblClsInfoCCaptainTxt.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClsInfoCCaptainTxt.Location = new System.Drawing.Point(189, 193);
            this.lblClsInfoCCaptainTxt.Name = "lblClsInfoCCaptainTxt";
            this.lblClsInfoCCaptainTxt.Size = new System.Drawing.Size(12, 18);
            this.lblClsInfoCCaptainTxt.TabIndex = 21;
            this.lblClsInfoCCaptainTxt.Text = "-";
            // 
            // lblClsInfoCTeacherTxt
            // 
            this.lblClsInfoCTeacherTxt.AutoSize = true;
            this.lblClsInfoCTeacherTxt.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClsInfoCTeacherTxt.Location = new System.Drawing.Point(189, 139);
            this.lblClsInfoCTeacherTxt.Name = "lblClsInfoCTeacherTxt";
            this.lblClsInfoCTeacherTxt.Size = new System.Drawing.Size(12, 18);
            this.lblClsInfoCTeacherTxt.TabIndex = 22;
            this.lblClsInfoCTeacherTxt.Text = "-";
            // 
            // lblClsInfoStdNoTxt
            // 
            this.lblClsInfoStdNoTxt.AutoSize = true;
            this.lblClsInfoStdNoTxt.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClsInfoStdNoTxt.Location = new System.Drawing.Point(189, 90);
            this.lblClsInfoStdNoTxt.Name = "lblClsInfoStdNoTxt";
            this.lblClsInfoStdNoTxt.Size = new System.Drawing.Size(12, 18);
            this.lblClsInfoStdNoTxt.TabIndex = 23;
            this.lblClsInfoStdNoTxt.Text = "-";
            // 
            // lblClsInfoClassTxt
            // 
            this.lblClsInfoClassTxt.AutoSize = true;
            this.lblClsInfoClassTxt.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClsInfoClassTxt.Location = new System.Drawing.Point(189, 40);
            this.lblClsInfoClassTxt.Name = "lblClsInfoClassTxt";
            this.lblClsInfoClassTxt.Size = new System.Drawing.Size(12, 18);
            this.lblClsInfoClassTxt.TabIndex = 24;
            this.lblClsInfoClassTxt.Text = "-";
            // 
            // lblClsInfoStdNo
            // 
            this.lblClsInfoStdNo.AutoSize = true;
            this.lblClsInfoStdNo.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClsInfoStdNo.Location = new System.Drawing.Point(89, 93);
            this.lblClsInfoStdNo.Name = "lblClsInfoStdNo";
            this.lblClsInfoStdNo.Size = new System.Drawing.Size(85, 15);
            this.lblClsInfoStdNo.TabIndex = 15;
            this.lblClsInfoStdNo.Text = "No of Student:";
            // 
            // lblClsInfoTeacher
            // 
            this.lblClsInfoTeacher.AutoSize = true;
            this.lblClsInfoTeacher.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClsInfoTeacher.Location = new System.Drawing.Point(89, 142);
            this.lblClsInfoTeacher.Name = "lblClsInfoTeacher";
            this.lblClsInfoTeacher.Size = new System.Drawing.Size(84, 15);
            this.lblClsInfoTeacher.TabIndex = 16;
            this.lblClsInfoTeacher.Text = "Class Teacher:";
            // 
            // lblClsInfoShift
            // 
            this.lblClsInfoShift.AutoSize = true;
            this.lblClsInfoShift.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClsInfoShift.Location = new System.Drawing.Point(89, 251);
            this.lblClsInfoShift.Name = "lblClsInfoShift";
            this.lblClsInfoShift.Size = new System.Drawing.Size(75, 15);
            this.lblClsInfoShift.TabIndex = 17;
            this.lblClsInfoShift.Text = "Special Care:";
            // 
            // lblClsInfoSection
            // 
            this.lblClsInfoSection.AutoSize = true;
            this.lblClsInfoSection.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClsInfoSection.Location = new System.Drawing.Point(89, 196);
            this.lblClsInfoSection.Name = "lblClsInfoSection";
            this.lblClsInfoSection.Size = new System.Drawing.Size(83, 15);
            this.lblClsInfoSection.TabIndex = 18;
            this.lblClsInfoSection.Text = "Class Captain:";
            // 
            // lblClsInfoCls
            // 
            this.lblClsInfoCls.AutoSize = true;
            this.lblClsInfoCls.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClsInfoCls.Location = new System.Drawing.Point(89, 43);
            this.lblClsInfoCls.Name = "lblClsInfoCls";
            this.lblClsInfoCls.Size = new System.Drawing.Size(39, 15);
            this.lblClsInfoCls.TabIndex = 19;
            this.lblClsInfoCls.Text = "Class:";
            // 
            // Classes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.Controls.Add(this.clsGrpBox);
            this.Controls.Add(this.topBarBox);
            this.Controls.Add(this.lblAdminHome);
            this.Name = "Classes";
            this.Size = new System.Drawing.Size(823, 671);
            this.clsGrpBox.ResumeLayout(false);
            this.clsGrpBox.PerformLayout();
            this.stdOptionBox.ResumeLayout(false);
            this.topBarBox.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox clsGrpBox;
        private System.Windows.Forms.GroupBox stdOptionBox;
        private System.Windows.Forms.Button btnClsProgress;
        private System.Windows.Forms.Button btnClsEdit;
        private System.Windows.Forms.ListBox clsList;
        private System.Windows.Forms.GroupBox topBarBox;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Button btnForward;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Label lblAdminHome;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label lblSelectShift;
        private System.Windows.Forms.ComboBox selectShiftCombo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblClsInfoSpecialTxt;
        private System.Windows.Forms.Label lblClsInfoCCaptainTxt;
        private System.Windows.Forms.Label lblClsInfoCTeacherTxt;
        private System.Windows.Forms.Label lblClsInfoStdNoTxt;
        private System.Windows.Forms.Label lblClsInfoClassTxt;
        private System.Windows.Forms.Label lblClsInfoStdNo;
        private System.Windows.Forms.Label lblClsInfoTeacher;
        private System.Windows.Forms.Label lblClsInfoShift;
        private System.Windows.Forms.Label lblClsInfoSection;
        private System.Windows.Forms.Label lblClsInfoCls;
    }
}
