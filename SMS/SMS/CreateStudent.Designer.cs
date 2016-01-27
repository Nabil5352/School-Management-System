namespace SMS
{
    partial class CreateStudent
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
            this.lblAdminHome = new System.Windows.Forms.Label();
            this.topBarBox = new System.Windows.Forms.GroupBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.btnForward = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.StdGContactTxt = new System.Windows.Forms.TextBox();
            this.StdlblID = new System.Windows.Forms.Label();
            this.btnCancelTeach = new System.Windows.Forms.Button();
            this.btnAddStd = new System.Windows.Forms.Button();
            this.StdSelectCmbox = new System.Windows.Forms.ComboBox();
            this.lblStdGContact = new System.Windows.Forms.Label();
            this.lblExOrCurrent = new System.Windows.Forms.Label();
            this.lblStdID = new System.Windows.Forms.Label();
            this.lblStdSelect = new System.Windows.Forms.Label();
            this.CreateStdBox = new System.Windows.Forms.GroupBox();
            this.StdSelectLeaveYearCombox = new System.Windows.Forms.ComboBox();
            this.lblStdLeaveYear = new System.Windows.Forms.Label();
            this.StdSelectYearCombox = new System.Windows.Forms.ComboBox();
            this.StdMetaTxt = new System.Windows.Forms.RichTextBox();
            this.lblStdMeta = new System.Windows.Forms.Label();
            this.lblStdAdYear = new System.Windows.Forms.Label();
            this.StdRollTxt = new System.Windows.Forms.TextBox();
            this.lblStdRoll = new System.Windows.Forms.Label();
            this.StdSelectClassCombox = new System.Windows.Forms.ComboBox();
            this.lblStdSelectClass = new System.Windows.Forms.Label();
            this.selectShift = new System.Windows.Forms.ComboBox();
            this.StdSelectExOrCurrentCmbox = new System.Windows.Forms.ComboBox();
            this.lblSelectShift = new System.Windows.Forms.Label();
            this.topBarBox.SuspendLayout();
            this.CreateStdBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblAdminHome
            // 
            this.lblAdminHome.AutoSize = true;
            this.lblAdminHome.Font = new System.Drawing.Font("Algerian", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdminHome.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblAdminHome.Location = new System.Drawing.Point(337, 637);
            this.lblAdminHome.Name = "lblAdminHome";
            this.lblAdminHome.Size = new System.Drawing.Size(161, 18);
            this.lblAdminHome.TabIndex = 18;
            this.lblAdminHome.Text = "ADMIN + USER AREA";
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
            this.btnRefresh.TabIndex = 16;
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
            // StdGContactTxt
            // 
            this.StdGContactTxt.Location = new System.Drawing.Point(190, 313);
            this.StdGContactTxt.Name = "StdGContactTxt";
            this.StdGContactTxt.Size = new System.Drawing.Size(236, 22);
            this.StdGContactTxt.TabIndex = 11;
            // 
            // StdlblID
            // 
            this.StdlblID.AutoSize = true;
            this.StdlblID.Location = new System.Drawing.Point(187, 93);
            this.StdlblID.Name = "StdlblID";
            this.StdlblID.Size = new System.Drawing.Size(30, 15);
            this.StdlblID.TabIndex = 9;
            this.StdlblID.Text = "S ID";
            // 
            // btnCancelTeach
            // 
            this.btnCancelTeach.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnCancelTeach.FlatAppearance.BorderSize = 2;
            this.btnCancelTeach.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelTeach.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelTeach.Location = new System.Drawing.Point(244, 459);
            this.btnCancelTeach.Name = "btnCancelTeach";
            this.btnCancelTeach.Size = new System.Drawing.Size(89, 39);
            this.btnCancelTeach.TabIndex = 4;
            this.btnCancelTeach.Text = "Cancel";
            this.btnCancelTeach.UseVisualStyleBackColor = true;
            this.btnCancelTeach.Click += new System.EventHandler(this.btnCancelTeach_Click);
            // 
            // btnAddStd
            // 
            this.btnAddStd.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnAddStd.FlatAppearance.BorderSize = 2;
            this.btnAddStd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddStd.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddStd.Location = new System.Drawing.Point(117, 459);
            this.btnAddStd.Name = "btnAddStd";
            this.btnAddStd.Size = new System.Drawing.Size(89, 39);
            this.btnAddStd.TabIndex = 4;
            this.btnAddStd.Text = "Create";
            this.btnAddStd.UseVisualStyleBackColor = true;
            this.btnAddStd.Click += new System.EventHandler(this.btnAddStd_Click);
            // 
            // StdSelectCmbox
            // 
            this.StdSelectCmbox.FormattingEnabled = true;
            this.StdSelectCmbox.Location = new System.Drawing.Point(190, 121);
            this.StdSelectCmbox.Name = "StdSelectCmbox";
            this.StdSelectCmbox.Size = new System.Drawing.Size(236, 23);
            this.StdSelectCmbox.TabIndex = 1;
            // 
            // lblStdGContact
            // 
            this.lblStdGContact.AutoSize = true;
            this.lblStdGContact.Location = new System.Drawing.Point(46, 320);
            this.lblStdGContact.Name = "lblStdGContact";
            this.lblStdGContact.Size = new System.Drawing.Size(103, 15);
            this.lblStdGContact.TabIndex = 0;
            this.lblStdGContact.Text = "Guardian Contact:";
            // 
            // lblExOrCurrent
            // 
            this.lblExOrCurrent.AutoSize = true;
            this.lblExOrCurrent.Location = new System.Drawing.Point(46, 28);
            this.lblExOrCurrent.Name = "lblExOrCurrent";
            this.lblExOrCurrent.Size = new System.Drawing.Size(72, 15);
            this.lblExOrCurrent.TabIndex = 0;
            this.lblExOrCurrent.Text = "Ex / Current:";
            // 
            // lblStdID
            // 
            this.lblStdID.AutoSize = true;
            this.lblStdID.Location = new System.Drawing.Point(46, 93);
            this.lblStdID.Name = "lblStdID";
            this.lblStdID.Size = new System.Drawing.Size(68, 15);
            this.lblStdID.TabIndex = 0;
            this.lblStdID.Text = "Student ID:";
            // 
            // lblStdSelect
            // 
            this.lblStdSelect.AutoSize = true;
            this.lblStdSelect.Location = new System.Drawing.Point(46, 129);
            this.lblStdSelect.Name = "lblStdSelect";
            this.lblStdSelect.Size = new System.Drawing.Size(42, 15);
            this.lblStdSelect.TabIndex = 0;
            this.lblStdSelect.Text = "Select:";
            // 
            // CreateStdBox
            // 
            this.CreateStdBox.BackColor = System.Drawing.Color.Transparent;
            this.CreateStdBox.Controls.Add(this.StdSelectLeaveYearCombox);
            this.CreateStdBox.Controls.Add(this.lblStdLeaveYear);
            this.CreateStdBox.Controls.Add(this.StdSelectYearCombox);
            this.CreateStdBox.Controls.Add(this.StdMetaTxt);
            this.CreateStdBox.Controls.Add(this.lblStdMeta);
            this.CreateStdBox.Controls.Add(this.lblStdAdYear);
            this.CreateStdBox.Controls.Add(this.StdRollTxt);
            this.CreateStdBox.Controls.Add(this.lblStdRoll);
            this.CreateStdBox.Controls.Add(this.StdSelectClassCombox);
            this.CreateStdBox.Controls.Add(this.lblStdSelectClass);
            this.CreateStdBox.Controls.Add(this.StdGContactTxt);
            this.CreateStdBox.Controls.Add(this.StdlblID);
            this.CreateStdBox.Controls.Add(this.btnCancelTeach);
            this.CreateStdBox.Controls.Add(this.btnAddStd);
            this.CreateStdBox.Controls.Add(this.selectShift);
            this.CreateStdBox.Controls.Add(this.StdSelectExOrCurrentCmbox);
            this.CreateStdBox.Controls.Add(this.StdSelectCmbox);
            this.CreateStdBox.Controls.Add(this.lblStdGContact);
            this.CreateStdBox.Controls.Add(this.lblSelectShift);
            this.CreateStdBox.Controls.Add(this.lblExOrCurrent);
            this.CreateStdBox.Controls.Add(this.lblStdID);
            this.CreateStdBox.Controls.Add(this.lblStdSelect);
            this.CreateStdBox.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateStdBox.Location = new System.Drawing.Point(321, 113);
            this.CreateStdBox.Name = "CreateStdBox";
            this.CreateStdBox.Size = new System.Drawing.Size(484, 521);
            this.CreateStdBox.TabIndex = 17;
            this.CreateStdBox.TabStop = false;
            // 
            // StdSelectLeaveYearCombox
            // 
            this.StdSelectLeaveYearCombox.FormattingEnabled = true;
            this.StdSelectLeaveYearCombox.Location = new System.Drawing.Point(190, 269);
            this.StdSelectLeaveYearCombox.Name = "StdSelectLeaveYearCombox";
            this.StdSelectLeaveYearCombox.Size = new System.Drawing.Size(236, 23);
            this.StdSelectLeaveYearCombox.TabIndex = 21;
            // 
            // lblStdLeaveYear
            // 
            this.lblStdLeaveYear.AutoSize = true;
            this.lblStdLeaveYear.Location = new System.Drawing.Point(46, 277);
            this.lblStdLeaveYear.Name = "lblStdLeaveYear";
            this.lblStdLeaveYear.Size = new System.Drawing.Size(79, 15);
            this.lblStdLeaveYear.TabIndex = 20;
            this.lblStdLeaveYear.Text = "Leaving Year:";
            // 
            // StdSelectYearCombox
            // 
            this.StdSelectYearCombox.FormattingEnabled = true;
            this.StdSelectYearCombox.Location = new System.Drawing.Point(190, 231);
            this.StdSelectYearCombox.Name = "StdSelectYearCombox";
            this.StdSelectYearCombox.Size = new System.Drawing.Size(236, 23);
            this.StdSelectYearCombox.TabIndex = 19;
            // 
            // StdMetaTxt
            // 
            this.StdMetaTxt.Location = new System.Drawing.Point(190, 371);
            this.StdMetaTxt.Name = "StdMetaTxt";
            this.StdMetaTxt.Size = new System.Drawing.Size(236, 59);
            this.StdMetaTxt.TabIndex = 18;
            this.StdMetaTxt.Text = "";
            // 
            // lblStdMeta
            // 
            this.lblStdMeta.AutoSize = true;
            this.lblStdMeta.Location = new System.Drawing.Point(46, 371);
            this.lblStdMeta.Name = "lblStdMeta";
            this.lblStdMeta.Size = new System.Drawing.Size(38, 15);
            this.lblStdMeta.TabIndex = 17;
            this.lblStdMeta.Text = "Meta:";
            // 
            // lblStdAdYear
            // 
            this.lblStdAdYear.AutoSize = true;
            this.lblStdAdYear.Location = new System.Drawing.Point(46, 239);
            this.lblStdAdYear.Name = "lblStdAdYear";
            this.lblStdAdYear.Size = new System.Drawing.Size(94, 15);
            this.lblStdAdYear.TabIndex = 16;
            this.lblStdAdYear.Text = "Admission Year:";
            // 
            // StdRollTxt
            // 
            this.StdRollTxt.Location = new System.Drawing.Point(190, 194);
            this.StdRollTxt.Name = "StdRollTxt";
            this.StdRollTxt.Size = new System.Drawing.Size(236, 22);
            this.StdRollTxt.TabIndex = 15;
            // 
            // lblStdRoll
            // 
            this.lblStdRoll.AutoSize = true;
            this.lblStdRoll.Location = new System.Drawing.Point(46, 201);
            this.lblStdRoll.Name = "lblStdRoll";
            this.lblStdRoll.Size = new System.Drawing.Size(31, 15);
            this.lblStdRoll.TabIndex = 14;
            this.lblStdRoll.Text = "Roll:";
            // 
            // StdSelectClassCombox
            // 
            this.StdSelectClassCombox.FormattingEnabled = true;
            this.StdSelectClassCombox.Location = new System.Drawing.Point(190, 158);
            this.StdSelectClassCombox.Name = "StdSelectClassCombox";
            this.StdSelectClassCombox.Size = new System.Drawing.Size(236, 23);
            this.StdSelectClassCombox.TabIndex = 13;
            // 
            // lblStdSelectClass
            // 
            this.lblStdSelectClass.AutoSize = true;
            this.lblStdSelectClass.Location = new System.Drawing.Point(46, 166);
            this.lblStdSelectClass.Name = "lblStdSelectClass";
            this.lblStdSelectClass.Size = new System.Drawing.Size(39, 15);
            this.lblStdSelectClass.TabIndex = 12;
            this.lblStdSelectClass.Text = "Class:";
            // 
            // selectShift
            // 
            this.selectShift.FormattingEnabled = true;
            this.selectShift.Location = new System.Drawing.Point(190, 53);
            this.selectShift.Name = "selectShift";
            this.selectShift.Size = new System.Drawing.Size(236, 23);
            this.selectShift.TabIndex = 1;
            this.selectShift.SelectedIndexChanged += new System.EventHandler(this.selectShift_SelectedIndexChanged);
            // 
            // StdSelectExOrCurrentCmbox
            // 
            this.StdSelectExOrCurrentCmbox.FormattingEnabled = true;
            this.StdSelectExOrCurrentCmbox.Location = new System.Drawing.Point(190, 20);
            this.StdSelectExOrCurrentCmbox.Name = "StdSelectExOrCurrentCmbox";
            this.StdSelectExOrCurrentCmbox.Size = new System.Drawing.Size(236, 23);
            this.StdSelectExOrCurrentCmbox.TabIndex = 1;
            this.StdSelectExOrCurrentCmbox.SelectedIndexChanged += new System.EventHandler(this.StdSelectExOrCurrentCmbox_SelectedIndexChanged);
            // 
            // lblSelectShift
            // 
            this.lblSelectShift.AutoSize = true;
            this.lblSelectShift.Location = new System.Drawing.Point(46, 61);
            this.lblSelectShift.Name = "lblSelectShift";
            this.lblSelectShift.Size = new System.Drawing.Size(35, 15);
            this.lblSelectShift.TabIndex = 0;
            this.lblSelectShift.Text = "Shift:";
            // 
            // CreateStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImage = global::SMS.Properties.Resources.back_createPerson;
            this.Controls.Add(this.lblAdminHome);
            this.Controls.Add(this.topBarBox);
            this.Controls.Add(this.CreateStdBox);
            this.Name = "CreateStudent";
            this.Size = new System.Drawing.Size(823, 671);
            this.topBarBox.ResumeLayout(false);
            this.CreateStdBox.ResumeLayout(false);
            this.CreateStdBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAdminHome;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Button btnForward;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.GroupBox topBarBox;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.TextBox StdGContactTxt;
        private System.Windows.Forms.Label StdlblID;
        private System.Windows.Forms.Button btnCancelTeach;
        private System.Windows.Forms.Button btnAddStd;
        private System.Windows.Forms.ComboBox StdSelectCmbox;
        private System.Windows.Forms.Label lblStdGContact;
        private System.Windows.Forms.Label lblExOrCurrent;
        private System.Windows.Forms.Label lblStdID;
        private System.Windows.Forms.Label lblStdSelect;
        private System.Windows.Forms.GroupBox CreateStdBox;
        private System.Windows.Forms.ComboBox StdSelectExOrCurrentCmbox;
        private System.Windows.Forms.Label lblStdSelectClass;
        private System.Windows.Forms.ComboBox StdSelectClassCombox;
        private System.Windows.Forms.Label lblStdRoll;
        private System.Windows.Forms.Label lblStdMeta;
        private System.Windows.Forms.Label lblStdAdYear;
        private System.Windows.Forms.TextBox StdRollTxt;
        private System.Windows.Forms.RichTextBox StdMetaTxt;
        private System.Windows.Forms.ComboBox StdSelectYearCombox;
        private System.Windows.Forms.Label lblStdLeaveYear;
        private System.Windows.Forms.ComboBox StdSelectLeaveYearCombox;
        private System.Windows.Forms.Label lblSelectShift;
        private System.Windows.Forms.ComboBox selectShift;
        private System.Windows.Forms.Button btnRefresh;
    }
}
