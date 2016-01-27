namespace SMS
{
    partial class EditClass
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
            this.lblSelectShift = new System.Windows.Forms.Label();
            this.selectShiftCombo = new System.Windows.Forms.ComboBox();
            this.topBarBox = new System.Windows.Forms.GroupBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.btnForward = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.lblAdminHome = new System.Windows.Forms.Label();
            this.clsList = new System.Windows.Forms.ListBox();
            this.clsGrpBox = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClassEditCancel = new System.Windows.Forms.Button();
            this.btnClassEditSave = new System.Windows.Forms.Button();
            this.careTxt = new System.Windows.Forms.RichTextBox();
            this.btnChangeCRSave = new System.Windows.Forms.Button();
            this.btnChangeCR = new System.Windows.Forms.Button();
            this.btnChangeTeachSave = new System.Windows.Forms.Button();
            this.lblChangeTeach = new System.Windows.Forms.Button();
            this.lblCRTxt = new System.Windows.Forms.Label();
            this.lblCurrentTeachTxt = new System.Windows.Forms.Label();
            this.selectCrCombo = new System.Windows.Forms.ComboBox();
            this.selectTeacherCombo = new System.Windows.Forms.ComboBox();
            this.studentTxt = new System.Windows.Forms.TextBox();
            this.lblClsInfoStdNo = new System.Windows.Forms.Label();
            this.lblClsInfoTeacher = new System.Windows.Forms.Label();
            this.lblClsInfoShift = new System.Windows.Forms.Label();
            this.lblClsInfoSection = new System.Windows.Forms.Label();
            this.topBarBox.SuspendLayout();
            this.clsGrpBox.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSelectShift
            // 
            this.lblSelectShift.AutoSize = true;
            this.lblSelectShift.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectShift.Location = new System.Drawing.Point(21, 30);
            this.lblSelectShift.Name = "lblSelectShift";
            this.lblSelectShift.Size = new System.Drawing.Size(40, 15);
            this.lblSelectShift.TabIndex = 7;
            this.lblSelectShift.Text = "Shift:";
            // 
            // selectShiftCombo
            // 
            this.selectShiftCombo.FormattingEnabled = true;
            this.selectShiftCombo.Location = new System.Drawing.Point(77, 28);
            this.selectShiftCombo.Name = "selectShiftCombo";
            this.selectShiftCombo.Size = new System.Drawing.Size(200, 21);
            this.selectShiftCombo.TabIndex = 6;
            this.selectShiftCombo.SelectedIndexChanged += new System.EventHandler(this.selectShiftCombo_SelectedIndexChanged);
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
            this.topBarBox.TabIndex = 19;
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
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
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
            this.lblAdminHome.Location = new System.Drawing.Point(329, 638);
            this.lblAdminHome.Name = "lblAdminHome";
            this.lblAdminHome.Size = new System.Drawing.Size(156, 18);
            this.lblAdminHome.TabIndex = 18;
            this.lblAdminHome.Text = "ADMIN : USER AREA";
            // 
            // clsList
            // 
            this.clsList.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clsList.FormattingEnabled = true;
            this.clsList.ItemHeight = 17;
            this.clsList.Location = new System.Drawing.Point(17, 68);
            this.clsList.Name = "clsList";
            this.clsList.Size = new System.Drawing.Size(282, 429);
            this.clsList.TabIndex = 0;
            this.clsList.SelectedIndexChanged += new System.EventHandler(this.clsList_SelectedIndexChanged);
            // 
            // clsGrpBox
            // 
            this.clsGrpBox.Controls.Add(this.panel1);
            this.clsGrpBox.Controls.Add(this.lblSelectShift);
            this.clsGrpBox.Controls.Add(this.selectShiftCombo);
            this.clsGrpBox.Controls.Add(this.clsList);
            this.clsGrpBox.Location = new System.Drawing.Point(18, 105);
            this.clsGrpBox.Name = "clsGrpBox";
            this.clsGrpBox.Size = new System.Drawing.Size(787, 521);
            this.clsGrpBox.TabIndex = 17;
            this.clsGrpBox.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnClassEditCancel);
            this.panel1.Controls.Add(this.btnClassEditSave);
            this.panel1.Controls.Add(this.careTxt);
            this.panel1.Controls.Add(this.btnChangeCRSave);
            this.panel1.Controls.Add(this.btnChangeCR);
            this.panel1.Controls.Add(this.btnChangeTeachSave);
            this.panel1.Controls.Add(this.lblChangeTeach);
            this.panel1.Controls.Add(this.lblCRTxt);
            this.panel1.Controls.Add(this.lblCurrentTeachTxt);
            this.panel1.Controls.Add(this.selectCrCombo);
            this.panel1.Controls.Add(this.selectTeacherCombo);
            this.panel1.Controls.Add(this.studentTxt);
            this.panel1.Controls.Add(this.lblClsInfoStdNo);
            this.panel1.Controls.Add(this.lblClsInfoTeacher);
            this.panel1.Controls.Add(this.lblClsInfoShift);
            this.panel1.Controls.Add(this.lblClsInfoSection);
            this.panel1.Location = new System.Drawing.Point(314, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(461, 469);
            this.panel1.TabIndex = 10;
            // 
            // btnClassEditCancel
            // 
            this.btnClassEditCancel.BackColor = System.Drawing.Color.Gainsboro;
            this.btnClassEditCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnClassEditCancel.FlatAppearance.BorderSize = 2;
            this.btnClassEditCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClassEditCancel.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClassEditCancel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnClassEditCancel.Location = new System.Drawing.Point(237, 393);
            this.btnClassEditCancel.Name = "btnClassEditCancel";
            this.btnClassEditCancel.Size = new System.Drawing.Size(92, 39);
            this.btnClassEditCancel.TabIndex = 32;
            this.btnClassEditCancel.Text = "Cancel";
            this.btnClassEditCancel.UseVisualStyleBackColor = false;
            this.btnClassEditCancel.Click += new System.EventHandler(this.btnClassEditCancel_Click);
            // 
            // btnClassEditSave
            // 
            this.btnClassEditSave.BackColor = System.Drawing.Color.Gainsboro;
            this.btnClassEditSave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnClassEditSave.FlatAppearance.BorderSize = 2;
            this.btnClassEditSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClassEditSave.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClassEditSave.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnClassEditSave.Location = new System.Drawing.Point(118, 393);
            this.btnClassEditSave.Name = "btnClassEditSave";
            this.btnClassEditSave.Size = new System.Drawing.Size(92, 39);
            this.btnClassEditSave.TabIndex = 33;
            this.btnClassEditSave.Text = "Save";
            this.btnClassEditSave.UseVisualStyleBackColor = false;
            this.btnClassEditSave.Click += new System.EventHandler(this.btnClassEditSave_Click);
            // 
            // careTxt
            // 
            this.careTxt.Location = new System.Drawing.Point(167, 255);
            this.careTxt.Name = "careTxt";
            this.careTxt.Size = new System.Drawing.Size(236, 107);
            this.careTxt.TabIndex = 31;
            this.careTxt.Text = "";
            // 
            // btnChangeCRSave
            // 
            this.btnChangeCRSave.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangeCRSave.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnChangeCRSave.Location = new System.Drawing.Point(165, 210);
            this.btnChangeCRSave.Name = "btnChangeCRSave";
            this.btnChangeCRSave.Size = new System.Drawing.Size(75, 23);
            this.btnChangeCRSave.TabIndex = 30;
            this.btnChangeCRSave.Text = "Save";
            this.btnChangeCRSave.UseVisualStyleBackColor = true;
            this.btnChangeCRSave.Click += new System.EventHandler(this.btnChangeCRSave_Click);
            // 
            // btnChangeCR
            // 
            this.btnChangeCR.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangeCR.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnChangeCR.Location = new System.Drawing.Point(165, 210);
            this.btnChangeCR.Name = "btnChangeCR";
            this.btnChangeCR.Size = new System.Drawing.Size(75, 23);
            this.btnChangeCR.TabIndex = 29;
            this.btnChangeCR.Text = "Change";
            this.btnChangeCR.UseVisualStyleBackColor = true;
            this.btnChangeCR.Click += new System.EventHandler(this.btnChangeCR_Click);
            // 
            // btnChangeTeachSave
            // 
            this.btnChangeTeachSave.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangeTeachSave.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnChangeTeachSave.Location = new System.Drawing.Point(165, 131);
            this.btnChangeTeachSave.Name = "btnChangeTeachSave";
            this.btnChangeTeachSave.Size = new System.Drawing.Size(75, 23);
            this.btnChangeTeachSave.TabIndex = 28;
            this.btnChangeTeachSave.Text = "Save";
            this.btnChangeTeachSave.UseVisualStyleBackColor = true;
            this.btnChangeTeachSave.Click += new System.EventHandler(this.btnChangeTeachSave_Click);
            // 
            // lblChangeTeach
            // 
            this.lblChangeTeach.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChangeTeach.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblChangeTeach.Location = new System.Drawing.Point(164, 131);
            this.lblChangeTeach.Name = "lblChangeTeach";
            this.lblChangeTeach.Size = new System.Drawing.Size(75, 23);
            this.lblChangeTeach.TabIndex = 27;
            this.lblChangeTeach.Text = "Change";
            this.lblChangeTeach.UseVisualStyleBackColor = true;
            this.lblChangeTeach.Click += new System.EventHandler(this.lblChangeTeach_Click);
            // 
            // lblCRTxt
            // 
            this.lblCRTxt.AutoSize = true;
            this.lblCRTxt.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCRTxt.Location = new System.Drawing.Point(164, 180);
            this.lblCRTxt.Name = "lblCRTxt";
            this.lblCRTxt.Size = new System.Drawing.Size(12, 18);
            this.lblCRTxt.TabIndex = 25;
            this.lblCRTxt.Text = "-";
            // 
            // lblCurrentTeachTxt
            // 
            this.lblCurrentTeachTxt.AutoSize = true;
            this.lblCurrentTeachTxt.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentTeachTxt.Location = new System.Drawing.Point(164, 100);
            this.lblCurrentTeachTxt.Name = "lblCurrentTeachTxt";
            this.lblCurrentTeachTxt.Size = new System.Drawing.Size(12, 18);
            this.lblCurrentTeachTxt.TabIndex = 26;
            this.lblCurrentTeachTxt.Text = "-";
            // 
            // selectCrCombo
            // 
            this.selectCrCombo.FormattingEnabled = true;
            this.selectCrCombo.Location = new System.Drawing.Point(246, 212);
            this.selectCrCombo.Name = "selectCrCombo";
            this.selectCrCombo.Size = new System.Drawing.Size(157, 21);
            this.selectCrCombo.TabIndex = 23;
            // 
            // selectTeacherCombo
            // 
            this.selectTeacherCombo.FormattingEnabled = true;
            this.selectTeacherCombo.Location = new System.Drawing.Point(246, 133);
            this.selectTeacherCombo.Name = "selectTeacherCombo";
            this.selectTeacherCombo.Size = new System.Drawing.Size(157, 21);
            this.selectTeacherCombo.TabIndex = 24;
            // 
            // studentTxt
            // 
            this.studentTxt.Location = new System.Drawing.Point(164, 43);
            this.studentTxt.Name = "studentTxt";
            this.studentTxt.Size = new System.Drawing.Size(239, 20);
            this.studentTxt.TabIndex = 22;
            // 
            // lblClsInfoStdNo
            // 
            this.lblClsInfoStdNo.AutoSize = true;
            this.lblClsInfoStdNo.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClsInfoStdNo.Location = new System.Drawing.Point(57, 48);
            this.lblClsInfoStdNo.Name = "lblClsInfoStdNo";
            this.lblClsInfoStdNo.Size = new System.Drawing.Size(85, 15);
            this.lblClsInfoStdNo.TabIndex = 18;
            this.lblClsInfoStdNo.Text = "No of Student:";
            // 
            // lblClsInfoTeacher
            // 
            this.lblClsInfoTeacher.AutoSize = true;
            this.lblClsInfoTeacher.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClsInfoTeacher.Location = new System.Drawing.Point(57, 103);
            this.lblClsInfoTeacher.Name = "lblClsInfoTeacher";
            this.lblClsInfoTeacher.Size = new System.Drawing.Size(84, 15);
            this.lblClsInfoTeacher.TabIndex = 19;
            this.lblClsInfoTeacher.Text = "Class Teacher:";
            // 
            // lblClsInfoShift
            // 
            this.lblClsInfoShift.AutoSize = true;
            this.lblClsInfoShift.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClsInfoShift.Location = new System.Drawing.Point(57, 255);
            this.lblClsInfoShift.Name = "lblClsInfoShift";
            this.lblClsInfoShift.Size = new System.Drawing.Size(75, 15);
            this.lblClsInfoShift.TabIndex = 20;
            this.lblClsInfoShift.Text = "Special Care:";
            // 
            // lblClsInfoSection
            // 
            this.lblClsInfoSection.AutoSize = true;
            this.lblClsInfoSection.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClsInfoSection.Location = new System.Drawing.Point(57, 183);
            this.lblClsInfoSection.Name = "lblClsInfoSection";
            this.lblClsInfoSection.Size = new System.Drawing.Size(83, 15);
            this.lblClsInfoSection.TabIndex = 21;
            this.lblClsInfoSection.Text = "Class Captain:";
            // 
            // EditClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImage = global::SMS.Properties.Resources.back_edit;
            this.Controls.Add(this.topBarBox);
            this.Controls.Add(this.lblAdminHome);
            this.Controls.Add(this.clsGrpBox);
            this.Name = "EditClass";
            this.Size = new System.Drawing.Size(823, 671);
            this.topBarBox.ResumeLayout(false);
            this.clsGrpBox.ResumeLayout(false);
            this.clsGrpBox.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSelectShift;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Button btnForward;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.ComboBox selectShiftCombo;
        private System.Windows.Forms.GroupBox topBarBox;
        private System.Windows.Forms.Label lblAdminHome;
        private System.Windows.Forms.ListBox clsList;
        private System.Windows.Forms.GroupBox clsGrpBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnClassEditCancel;
        private System.Windows.Forms.Button btnClassEditSave;
        private System.Windows.Forms.RichTextBox careTxt;
        private System.Windows.Forms.Button btnChangeCRSave;
        private System.Windows.Forms.Button btnChangeCR;
        private System.Windows.Forms.Button btnChangeTeachSave;
        private System.Windows.Forms.Button lblChangeTeach;
        private System.Windows.Forms.Label lblCRTxt;
        private System.Windows.Forms.Label lblCurrentTeachTxt;
        private System.Windows.Forms.ComboBox selectCrCombo;
        private System.Windows.Forms.ComboBox selectTeacherCombo;
        private System.Windows.Forms.TextBox studentTxt;
        private System.Windows.Forms.Label lblClsInfoStdNo;
        private System.Windows.Forms.Label lblClsInfoTeacher;
        private System.Windows.Forms.Label lblClsInfoShift;
        private System.Windows.Forms.Label lblClsInfoSection;
    }
}
