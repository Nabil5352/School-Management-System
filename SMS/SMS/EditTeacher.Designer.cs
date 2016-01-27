namespace SMS
{
    partial class EditTeacher
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
            this.teacherGrpBox = new System.Windows.Forms.GroupBox();
            this.lblDesignation = new System.Windows.Forms.Label();
            this.LnameTxt = new System.Windows.Forms.TextBox();
            this.FnameTxt = new System.Windows.Forms.TextBox();
            this.ContactTxt = new System.Windows.Forms.TextBox();
            this.EmailTxt = new System.Windows.Forms.TextBox();
            this.EducationTxt = new System.Windows.Forms.TextBox();
            this.DesignationTxt = new System.Windows.Forms.TextBox();
            this.TeacherAddressBox = new System.Windows.Forms.GroupBox();
            this.DistrictTxt = new System.Windows.Forms.ComboBox();
            this.lblZip = new System.Windows.Forms.Label();
            this.lblDistrict = new System.Windows.Forms.Label();
            this.ZipTxt = new System.Windows.Forms.TextBox();
            this.CityTxt = new System.Windows.Forms.TextBox();
            this.StreetTxt = new System.Windows.Forms.TextBox();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblStreet = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblContact = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblEducation = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.teacherRichTxtBox = new System.Windows.Forms.RichTextBox();
            this.TeachList = new System.Windows.Forms.ListBox();
            this.btnEditCancel = new System.Windows.Forms.Button();
            this.btnEditSave = new System.Windows.Forms.Button();
            this.topBarBox.SuspendLayout();
            this.teacherGrpBox.SuspendLayout();
            this.TeacherAddressBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblAdminHome
            // 
            this.lblAdminHome.AutoSize = true;
            this.lblAdminHome.Font = new System.Drawing.Font("Algerian", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdminHome.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblAdminHome.Location = new System.Drawing.Point(329, 637);
            this.lblAdminHome.Name = "lblAdminHome";
            this.lblAdminHome.Size = new System.Drawing.Size(156, 18);
            this.lblAdminHome.TabIndex = 21;
            this.lblAdminHome.Text = "ADMIN : USER AREA";
            // 
            // topBarBox
            // 
            this.topBarBox.Controls.Add(this.btnRefresh);
            this.topBarBox.Controls.Add(this.btnQuit);
            this.topBarBox.Controls.Add(this.btnForward);
            this.topBarBox.Controls.Add(this.btnBack);
            this.topBarBox.Controls.Add(this.btnHome);
            this.topBarBox.Location = new System.Drawing.Point(236, 14);
            this.topBarBox.Name = "topBarBox";
            this.topBarBox.Size = new System.Drawing.Size(349, 83);
            this.topBarBox.TabIndex = 22;
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
            this.btnRefresh.TabIndex = 23;
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
            // teacherGrpBox
            // 
            this.teacherGrpBox.Controls.Add(this.btnEditCancel);
            this.teacherGrpBox.Controls.Add(this.btnEditSave);
            this.teacherGrpBox.Controls.Add(this.lblDesignation);
            this.teacherGrpBox.Controls.Add(this.LnameTxt);
            this.teacherGrpBox.Controls.Add(this.FnameTxt);
            this.teacherGrpBox.Controls.Add(this.ContactTxt);
            this.teacherGrpBox.Controls.Add(this.EmailTxt);
            this.teacherGrpBox.Controls.Add(this.EducationTxt);
            this.teacherGrpBox.Controls.Add(this.DesignationTxt);
            this.teacherGrpBox.Controls.Add(this.TeacherAddressBox);
            this.teacherGrpBox.Controls.Add(this.lblAddress);
            this.teacherGrpBox.Controls.Add(this.lblContact);
            this.teacherGrpBox.Controls.Add(this.lblEmail);
            this.teacherGrpBox.Controls.Add(this.lblEducation);
            this.teacherGrpBox.Controls.Add(this.lblName);
            this.teacherGrpBox.Controls.Add(this.teacherRichTxtBox);
            this.teacherGrpBox.Controls.Add(this.TeachList);
            this.teacherGrpBox.Location = new System.Drawing.Point(18, 104);
            this.teacherGrpBox.Name = "teacherGrpBox";
            this.teacherGrpBox.Size = new System.Drawing.Size(787, 521);
            this.teacherGrpBox.TabIndex = 20;
            this.teacherGrpBox.TabStop = false;
            // 
            // lblDesignation
            // 
            this.lblDesignation.AutoSize = true;
            this.lblDesignation.BackColor = System.Drawing.Color.White;
            this.lblDesignation.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesignation.Location = new System.Drawing.Point(356, 102);
            this.lblDesignation.Name = "lblDesignation";
            this.lblDesignation.Size = new System.Drawing.Size(75, 15);
            this.lblDesignation.TabIndex = 9;
            this.lblDesignation.Text = "Designation:";
            // 
            // LnameTxt
            // 
            this.LnameTxt.Location = new System.Drawing.Point(593, 45);
            this.LnameTxt.Name = "LnameTxt";
            this.LnameTxt.Size = new System.Drawing.Size(92, 20);
            this.LnameTxt.TabIndex = 7;
            // 
            // FnameTxt
            // 
            this.FnameTxt.Location = new System.Drawing.Point(491, 45);
            this.FnameTxt.Name = "FnameTxt";
            this.FnameTxt.Size = new System.Drawing.Size(92, 20);
            this.FnameTxt.TabIndex = 7;
            // 
            // ContactTxt
            // 
            this.ContactTxt.Location = new System.Drawing.Point(491, 257);
            this.ContactTxt.Name = "ContactTxt";
            this.ContactTxt.Size = new System.Drawing.Size(194, 20);
            this.ContactTxt.TabIndex = 7;
            // 
            // EmailTxt
            // 
            this.EmailTxt.Location = new System.Drawing.Point(491, 200);
            this.EmailTxt.Name = "EmailTxt";
            this.EmailTxt.Size = new System.Drawing.Size(194, 20);
            this.EmailTxt.TabIndex = 7;
            // 
            // EducationTxt
            // 
            this.EducationTxt.Location = new System.Drawing.Point(491, 147);
            this.EducationTxt.Name = "EducationTxt";
            this.EducationTxt.Size = new System.Drawing.Size(194, 20);
            this.EducationTxt.TabIndex = 7;
            // 
            // DesignationTxt
            // 
            this.DesignationTxt.Location = new System.Drawing.Point(491, 97);
            this.DesignationTxt.Name = "DesignationTxt";
            this.DesignationTxt.Size = new System.Drawing.Size(194, 20);
            this.DesignationTxt.TabIndex = 7;
            // 
            // TeacherAddressBox
            // 
            this.TeacherAddressBox.BackColor = System.Drawing.Color.White;
            this.TeacherAddressBox.Controls.Add(this.DistrictTxt);
            this.TeacherAddressBox.Controls.Add(this.lblZip);
            this.TeacherAddressBox.Controls.Add(this.lblDistrict);
            this.TeacherAddressBox.Controls.Add(this.ZipTxt);
            this.TeacherAddressBox.Controls.Add(this.CityTxt);
            this.TeacherAddressBox.Controls.Add(this.StreetTxt);
            this.TeacherAddressBox.Controls.Add(this.lblCity);
            this.TeacherAddressBox.Controls.Add(this.lblStreet);
            this.TeacherAddressBox.Location = new System.Drawing.Point(491, 309);
            this.TeacherAddressBox.Name = "TeacherAddressBox";
            this.TeacherAddressBox.Size = new System.Drawing.Size(257, 151);
            this.TeacherAddressBox.TabIndex = 5;
            this.TeacherAddressBox.TabStop = false;
            // 
            // DistrictTxt
            // 
            this.DistrictTxt.FormattingEnabled = true;
            this.DistrictTxt.Location = new System.Drawing.Point(90, 78);
            this.DistrictTxt.Name = "DistrictTxt";
            this.DistrictTxt.Size = new System.Drawing.Size(134, 21);
            this.DistrictTxt.TabIndex = 10;
            // 
            // lblZip
            // 
            this.lblZip.AutoSize = true;
            this.lblZip.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblZip.Location = new System.Drawing.Point(28, 119);
            this.lblZip.Name = "lblZip";
            this.lblZip.Size = new System.Drawing.Size(27, 15);
            this.lblZip.TabIndex = 5;
            this.lblZip.Text = "Zip:";
            // 
            // lblDistrict
            // 
            this.lblDistrict.AutoSize = true;
            this.lblDistrict.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDistrict.Location = new System.Drawing.Point(28, 84);
            this.lblDistrict.Name = "lblDistrict";
            this.lblDistrict.Size = new System.Drawing.Size(47, 15);
            this.lblDistrict.TabIndex = 5;
            this.lblDistrict.Text = "District:";
            // 
            // ZipTxt
            // 
            this.ZipTxt.Location = new System.Drawing.Point(90, 114);
            this.ZipTxt.Name = "ZipTxt";
            this.ZipTxt.Size = new System.Drawing.Size(134, 20);
            this.ZipTxt.TabIndex = 7;
            // 
            // CityTxt
            // 
            this.CityTxt.Location = new System.Drawing.Point(90, 45);
            this.CityTxt.Name = "CityTxt";
            this.CityTxt.Size = new System.Drawing.Size(134, 20);
            this.CityTxt.TabIndex = 7;
            // 
            // StreetTxt
            // 
            this.StreetTxt.Location = new System.Drawing.Point(90, 13);
            this.StreetTxt.Name = "StreetTxt";
            this.StreetTxt.Size = new System.Drawing.Size(134, 20);
            this.StreetTxt.TabIndex = 7;
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCity.Location = new System.Drawing.Point(28, 50);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(31, 15);
            this.lblCity.TabIndex = 5;
            this.lblCity.Text = "City:";
            // 
            // lblStreet
            // 
            this.lblStreet.AutoSize = true;
            this.lblStreet.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStreet.Location = new System.Drawing.Point(28, 18);
            this.lblStreet.Name = "lblStreet";
            this.lblStreet.Size = new System.Drawing.Size(42, 15);
            this.lblStreet.TabIndex = 5;
            this.lblStreet.Text = "Street:";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.BackColor = System.Drawing.Color.White;
            this.lblAddress.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.Location = new System.Drawing.Point(356, 321);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(56, 15);
            this.lblAddress.TabIndex = 3;
            this.lblAddress.Text = "Address:";
            // 
            // lblContact
            // 
            this.lblContact.AutoSize = true;
            this.lblContact.BackColor = System.Drawing.Color.White;
            this.lblContact.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContact.Location = new System.Drawing.Point(356, 262);
            this.lblContact.Name = "lblContact";
            this.lblContact.Size = new System.Drawing.Size(52, 15);
            this.lblContact.TabIndex = 3;
            this.lblContact.Text = "Contact:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.BackColor = System.Drawing.Color.White;
            this.lblEmail.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(356, 205);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(38, 15);
            this.lblEmail.TabIndex = 3;
            this.lblEmail.Text = "Email:";
            // 
            // lblEducation
            // 
            this.lblEducation.AutoSize = true;
            this.lblEducation.BackColor = System.Drawing.Color.White;
            this.lblEducation.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEducation.Location = new System.Drawing.Point(356, 152);
            this.lblEducation.Name = "lblEducation";
            this.lblEducation.Size = new System.Drawing.Size(115, 15);
            this.lblEducation.TabIndex = 3;
            this.lblEducation.Text = "Educational Quality:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.White;
            this.lblName.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(356, 50);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(40, 15);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "Name:";
            // 
            // teacherRichTxtBox
            // 
            this.teacherRichTxtBox.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teacherRichTxtBox.Location = new System.Drawing.Point(273, 17);
            this.teacherRichTxtBox.Name = "teacherRichTxtBox";
            this.teacherRichTxtBox.Size = new System.Drawing.Size(508, 497);
            this.teacherRichTxtBox.TabIndex = 2;
            this.teacherRichTxtBox.Text = "";
            // 
            // TeachList
            // 
            this.TeachList.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TeachList.FormattingEnabled = true;
            this.TeachList.ItemHeight = 17;
            this.TeachList.Location = new System.Drawing.Point(7, 17);
            this.TeachList.Name = "TeachList";
            this.TeachList.Size = new System.Drawing.Size(249, 497);
            this.TeachList.TabIndex = 0;
            this.TeachList.SelectedIndexChanged += new System.EventHandler(this.TeachList_SelectedIndexChanged);
            // 
            // btnEditCancel
            // 
            this.btnEditCancel.BackColor = System.Drawing.Color.DarkGray;
            this.btnEditCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnEditCancel.FlatAppearance.BorderSize = 2;
            this.btnEditCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditCancel.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditCancel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnEditCancel.Location = new System.Drawing.Point(535, 477);
            this.btnEditCancel.Name = "btnEditCancel";
            this.btnEditCancel.Size = new System.Drawing.Size(83, 28);
            this.btnEditCancel.TabIndex = 10;
            this.btnEditCancel.Text = "Cancel";
            this.btnEditCancel.UseVisualStyleBackColor = false;
            this.btnEditCancel.Click += new System.EventHandler(this.btnEditCancel_Click);
            // 
            // btnEditSave
            // 
            this.btnEditSave.BackColor = System.Drawing.Color.DarkGray;
            this.btnEditSave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnEditSave.FlatAppearance.BorderSize = 2;
            this.btnEditSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditSave.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditSave.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnEditSave.Location = new System.Drawing.Point(416, 477);
            this.btnEditSave.Name = "btnEditSave";
            this.btnEditSave.Size = new System.Drawing.Size(83, 28);
            this.btnEditSave.TabIndex = 11;
            this.btnEditSave.Text = "Save";
            this.btnEditSave.UseVisualStyleBackColor = false;
            this.btnEditSave.Click += new System.EventHandler(this.btnEditSave_Click);
            // 
            // EditTeacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImage = global::SMS.Properties.Resources.back_edit;
            this.Controls.Add(this.lblAdminHome);
            this.Controls.Add(this.topBarBox);
            this.Controls.Add(this.teacherGrpBox);
            this.Name = "EditTeacher";
            this.Size = new System.Drawing.Size(823, 671);
            this.topBarBox.ResumeLayout(false);
            this.teacherGrpBox.ResumeLayout(false);
            this.teacherGrpBox.PerformLayout();
            this.TeacherAddressBox.ResumeLayout(false);
            this.TeacherAddressBox.PerformLayout();
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
        private System.Windows.Forms.GroupBox teacherGrpBox;
        private System.Windows.Forms.Label lblDesignation;
        private System.Windows.Forms.TextBox LnameTxt;
        private System.Windows.Forms.TextBox FnameTxt;
        private System.Windows.Forms.TextBox EmailTxt;
        private System.Windows.Forms.TextBox EducationTxt;
        private System.Windows.Forms.TextBox DesignationTxt;
        private System.Windows.Forms.GroupBox TeacherAddressBox;
        private System.Windows.Forms.ComboBox DistrictTxt;
        private System.Windows.Forms.Label lblZip;
        private System.Windows.Forms.Label lblDistrict;
        private System.Windows.Forms.TextBox ZipTxt;
        private System.Windows.Forms.TextBox CityTxt;
        private System.Windows.Forms.TextBox StreetTxt;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblStreet;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblEducation;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.RichTextBox teacherRichTxtBox;
        private System.Windows.Forms.ListBox TeachList;
        private System.Windows.Forms.Label lblContact;
        private System.Windows.Forms.TextBox ContactTxt;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnEditCancel;
        private System.Windows.Forms.Button btnEditSave;
    }
}
