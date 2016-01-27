namespace SMS
{
    partial class EditStudent
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
            this.lblAddress = new System.Windows.Forms.Label();
            this.topBarBox = new System.Windows.Forms.GroupBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.btnForward = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.stdAddressBox = new System.Windows.Forms.GroupBox();
            this.districtTxt = new System.Windows.Forms.ComboBox();
            this.lblZip = new System.Windows.Forms.Label();
            this.lblDistrict = new System.Windows.Forms.Label();
            this.zipTxt = new System.Windows.Forms.TextBox();
            this.CityTxt = new System.Windows.Forms.TextBox();
            this.streetTxt = new System.Windows.Forms.TextBox();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblStreet = new System.Windows.Forms.Label();
            this.lblAdminHome = new System.Windows.Forms.Label();
            this.stdGrpBox = new System.Windows.Forms.GroupBox();
            this.btnStdEditCancel = new System.Windows.Forms.Button();
            this.btnStdEditSave = new System.Windows.Forms.Button();
            this.lblCurrent = new System.Windows.Forms.Label();
            this.lblStatusSelect = new System.Windows.Forms.ComboBox();
            this.SelectClassCombo = new System.Windows.Forms.ComboBox();
            this.MetaRichBoxTxt = new System.Windows.Forms.RichTextBox();
            this.lblMeta = new System.Windows.Forms.Label();
            this.SelectLeaveYearCmbox = new System.Windows.Forms.ComboBox();
            this.SelectShiftCombo = new System.Windows.Forms.ComboBox();
            this.selectShift = new System.Windows.Forms.ComboBox();
            this.SelectClassCmbox = new System.Windows.Forms.ComboBox();
            this.lblClass = new System.Windows.Forms.Label();
            this.lblGContact = new System.Windows.Forms.Label();
            this.EmailTxt = new System.Windows.Forms.TextBox();
            this.GContactTxt = new System.Windows.Forms.TextBox();
            this.RollTxt = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblLeaveYear = new System.Windows.Forms.Label();
            this.lblRoll = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblFName = new System.Windows.Forms.Label();
            this.stdRichTxtBox = new System.Windows.Forms.RichTextBox();
            this.stdList = new System.Windows.Forms.ListBox();
            this.topBarBox.SuspendLayout();
            this.stdAddressBox.SuspendLayout();
            this.stdGrpBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.BackColor = System.Drawing.Color.White;
            this.lblAddress.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.Location = new System.Drawing.Point(331, 401);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(56, 15);
            this.lblAddress.TabIndex = 3;
            this.lblAddress.Text = "Address:";
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
            this.btnRefresh.TabIndex = 24;
            this.btnRefresh.UseVisualStyleBackColor = true;
            // 
            // btnQuit
            // 
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
            this.btnForward.Image = global::SMS.Properties.Resources.agt_forward_256;
            this.btnForward.Location = new System.Drawing.Point(214, 14);
            this.btnForward.Name = "btnForward";
            this.btnForward.Size = new System.Drawing.Size(52, 63);
            this.btnForward.TabIndex = 1;
            this.btnForward.UseVisualStyleBackColor = true;
            // 
            // btnBack
            // 
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
            this.btnHome.Image = global::SMS.Properties.Resources.Home1;
            this.btnHome.Location = new System.Drawing.Point(22, 14);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(50, 63);
            this.btnHome.TabIndex = 0;
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // stdAddressBox
            // 
            this.stdAddressBox.BackColor = System.Drawing.Color.White;
            this.stdAddressBox.Controls.Add(this.districtTxt);
            this.stdAddressBox.Controls.Add(this.lblZip);
            this.stdAddressBox.Controls.Add(this.lblDistrict);
            this.stdAddressBox.Controls.Add(this.zipTxt);
            this.stdAddressBox.Controls.Add(this.CityTxt);
            this.stdAddressBox.Controls.Add(this.streetTxt);
            this.stdAddressBox.Controls.Add(this.lblCity);
            this.stdAddressBox.Controls.Add(this.lblStreet);
            this.stdAddressBox.Location = new System.Drawing.Point(445, 388);
            this.stdAddressBox.Name = "stdAddressBox";
            this.stdAddressBox.Size = new System.Drawing.Size(320, 70);
            this.stdAddressBox.TabIndex = 5;
            this.stdAddressBox.TabStop = false;
            // 
            // districtTxt
            // 
            this.districtTxt.FormattingEnabled = true;
            this.districtTxt.Location = new System.Drawing.Point(203, 37);
            this.districtTxt.Name = "districtTxt";
            this.districtTxt.Size = new System.Drawing.Size(111, 21);
            this.districtTxt.TabIndex = 10;
            // 
            // lblZip
            // 
            this.lblZip.AutoSize = true;
            this.lblZip.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblZip.Location = new System.Drawing.Point(150, 18);
            this.lblZip.Name = "lblZip";
            this.lblZip.Size = new System.Drawing.Size(27, 15);
            this.lblZip.TabIndex = 5;
            this.lblZip.Text = "Zip:";
            // 
            // lblDistrict
            // 
            this.lblDistrict.AutoSize = true;
            this.lblDistrict.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDistrict.Location = new System.Drawing.Point(150, 40);
            this.lblDistrict.Name = "lblDistrict";
            this.lblDistrict.Size = new System.Drawing.Size(47, 15);
            this.lblDistrict.TabIndex = 5;
            this.lblDistrict.Text = "District:";
            // 
            // zipTxt
            // 
            this.zipTxt.Location = new System.Drawing.Point(203, 13);
            this.zipTxt.Name = "zipTxt";
            this.zipTxt.Size = new System.Drawing.Size(111, 20);
            this.zipTxt.TabIndex = 7;
            // 
            // CityTxt
            // 
            this.CityTxt.Location = new System.Drawing.Point(53, 40);
            this.CityTxt.Name = "CityTxt";
            this.CityTxt.Size = new System.Drawing.Size(84, 20);
            this.CityTxt.TabIndex = 7;
            // 
            // streetTxt
            // 
            this.streetTxt.Location = new System.Drawing.Point(53, 13);
            this.streetTxt.Name = "streetTxt";
            this.streetTxt.Size = new System.Drawing.Size(84, 20);
            this.streetTxt.TabIndex = 7;
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCity.Location = new System.Drawing.Point(6, 39);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(31, 15);
            this.lblCity.TabIndex = 5;
            this.lblCity.Text = "City:";
            // 
            // lblStreet
            // 
            this.lblStreet.AutoSize = true;
            this.lblStreet.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStreet.Location = new System.Drawing.Point(5, 18);
            this.lblStreet.Name = "lblStreet";
            this.lblStreet.Size = new System.Drawing.Size(42, 15);
            this.lblStreet.TabIndex = 5;
            this.lblStreet.Text = "Street:";
            // 
            // lblAdminHome
            // 
            this.lblAdminHome.AutoSize = true;
            this.lblAdminHome.Font = new System.Drawing.Font("Algerian", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdminHome.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblAdminHome.Location = new System.Drawing.Point(329, 641);
            this.lblAdminHome.Name = "lblAdminHome";
            this.lblAdminHome.Size = new System.Drawing.Size(156, 18);
            this.lblAdminHome.TabIndex = 15;
            this.lblAdminHome.Text = "ADMIN : USER AREA";
            // 
            // stdGrpBox
            // 
            this.stdGrpBox.Controls.Add(this.btnStdEditCancel);
            this.stdGrpBox.Controls.Add(this.btnStdEditSave);
            this.stdGrpBox.Controls.Add(this.lblCurrent);
            this.stdGrpBox.Controls.Add(this.lblStatusSelect);
            this.stdGrpBox.Controls.Add(this.SelectClassCombo);
            this.stdGrpBox.Controls.Add(this.MetaRichBoxTxt);
            this.stdGrpBox.Controls.Add(this.lblMeta);
            this.stdGrpBox.Controls.Add(this.SelectLeaveYearCmbox);
            this.stdGrpBox.Controls.Add(this.SelectShiftCombo);
            this.stdGrpBox.Controls.Add(this.selectShift);
            this.stdGrpBox.Controls.Add(this.SelectClassCmbox);
            this.stdGrpBox.Controls.Add(this.lblClass);
            this.stdGrpBox.Controls.Add(this.lblGContact);
            this.stdGrpBox.Controls.Add(this.EmailTxt);
            this.stdGrpBox.Controls.Add(this.GContactTxt);
            this.stdGrpBox.Controls.Add(this.RollTxt);
            this.stdGrpBox.Controls.Add(this.stdAddressBox);
            this.stdGrpBox.Controls.Add(this.lblAddress);
            this.stdGrpBox.Controls.Add(this.lblEmail);
            this.stdGrpBox.Controls.Add(this.lblLeaveYear);
            this.stdGrpBox.Controls.Add(this.lblRoll);
            this.stdGrpBox.Controls.Add(this.lblStatus);
            this.stdGrpBox.Controls.Add(this.lblFName);
            this.stdGrpBox.Controls.Add(this.stdRichTxtBox);
            this.stdGrpBox.Controls.Add(this.stdList);
            this.stdGrpBox.Location = new System.Drawing.Point(18, 104);
            this.stdGrpBox.Name = "stdGrpBox";
            this.stdGrpBox.Size = new System.Drawing.Size(787, 530);
            this.stdGrpBox.TabIndex = 14;
            this.stdGrpBox.TabStop = false;
            // 
            // btnStdEditCancel
            // 
            this.btnStdEditCancel.BackColor = System.Drawing.Color.White;
            this.btnStdEditCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnStdEditCancel.FlatAppearance.BorderSize = 2;
            this.btnStdEditCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStdEditCancel.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStdEditCancel.Location = new System.Drawing.Point(533, 484);
            this.btnStdEditCancel.Name = "btnStdEditCancel";
            this.btnStdEditCancel.Size = new System.Drawing.Size(92, 29);
            this.btnStdEditCancel.TabIndex = 18;
            this.btnStdEditCancel.Text = "Cancel";
            this.btnStdEditCancel.UseVisualStyleBackColor = false;
            this.btnStdEditCancel.Click += new System.EventHandler(this.btnStdEditCancel_Click);
            // 
            // btnStdEditSave
            // 
            this.btnStdEditSave.BackColor = System.Drawing.Color.White;
            this.btnStdEditSave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnStdEditSave.FlatAppearance.BorderSize = 2;
            this.btnStdEditSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStdEditSave.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStdEditSave.Location = new System.Drawing.Point(409, 484);
            this.btnStdEditSave.Name = "btnStdEditSave";
            this.btnStdEditSave.Size = new System.Drawing.Size(92, 29);
            this.btnStdEditSave.TabIndex = 19;
            this.btnStdEditSave.Text = "Save";
            this.btnStdEditSave.UseVisualStyleBackColor = false;
            this.btnStdEditSave.Click += new System.EventHandler(this.btnStdEditSave_Click);
            // 
            // lblCurrent
            // 
            this.lblCurrent.AutoSize = true;
            this.lblCurrent.BackColor = System.Drawing.Color.White;
            this.lblCurrent.Location = new System.Drawing.Point(595, 38);
            this.lblCurrent.Name = "lblCurrent";
            this.lblCurrent.Size = new System.Drawing.Size(10, 13);
            this.lblCurrent.TabIndex = 17;
            this.lblCurrent.Text = "-";
            // 
            // lblStatusSelect
            // 
            this.lblStatusSelect.FormattingEnabled = true;
            this.lblStatusSelect.Location = new System.Drawing.Point(464, 35);
            this.lblStatusSelect.Name = "lblStatusSelect";
            this.lblStatusSelect.Size = new System.Drawing.Size(121, 21);
            this.lblStatusSelect.TabIndex = 16;
            this.lblStatusSelect.SelectedIndexChanged += new System.EventHandler(this.lblStatusSelect_SelectedIndexChanged);
            // 
            // SelectClassCombo
            // 
            this.SelectClassCombo.FormattingEnabled = true;
            this.SelectClassCombo.Location = new System.Drawing.Point(125, 17);
            this.SelectClassCombo.Name = "SelectClassCombo";
            this.SelectClassCombo.Size = new System.Drawing.Size(121, 21);
            this.SelectClassCombo.TabIndex = 15;
            this.SelectClassCombo.SelectedIndexChanged += new System.EventHandler(this.SelectClassCombo_SelectedIndexChanged);
            // 
            // MetaRichBoxTxt
            // 
            this.MetaRichBoxTxt.Location = new System.Drawing.Point(464, 341);
            this.MetaRichBoxTxt.Name = "MetaRichBoxTxt";
            this.MetaRichBoxTxt.Size = new System.Drawing.Size(178, 41);
            this.MetaRichBoxTxt.TabIndex = 14;
            this.MetaRichBoxTxt.Text = "";
            // 
            // lblMeta
            // 
            this.lblMeta.AutoSize = true;
            this.lblMeta.BackColor = System.Drawing.Color.White;
            this.lblMeta.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMeta.Location = new System.Drawing.Point(331, 357);
            this.lblMeta.Name = "lblMeta";
            this.lblMeta.Size = new System.Drawing.Size(38, 15);
            this.lblMeta.TabIndex = 13;
            this.lblMeta.Text = "Meta:";
            // 
            // SelectLeaveYearCmbox
            // 
            this.SelectLeaveYearCmbox.FormattingEnabled = true;
            this.SelectLeaveYearCmbox.Location = new System.Drawing.Point(464, 205);
            this.SelectLeaveYearCmbox.Name = "SelectLeaveYearCmbox";
            this.SelectLeaveYearCmbox.Size = new System.Drawing.Size(179, 21);
            this.SelectLeaveYearCmbox.TabIndex = 12;
            // 
            // SelectShiftCombo
            // 
            this.SelectShiftCombo.FormattingEnabled = true;
            this.SelectShiftCombo.Location = new System.Drawing.Point(7, 17);
            this.SelectShiftCombo.Name = "SelectShiftCombo";
            this.SelectShiftCombo.Size = new System.Drawing.Size(112, 21);
            this.SelectShiftCombo.TabIndex = 12;
            this.SelectShiftCombo.SelectedIndexChanged += new System.EventHandler(this.SelectShiftCombo_SelectedIndexChanged);
            // 
            // selectShift
            // 
            this.selectShift.FormattingEnabled = true;
            this.selectShift.Location = new System.Drawing.Point(463, 76);
            this.selectShift.Name = "selectShift";
            this.selectShift.Size = new System.Drawing.Size(179, 21);
            this.selectShift.TabIndex = 12;
            this.selectShift.SelectedIndexChanged += new System.EventHandler(this.selectShift_SelectedIndexChanged);
            // 
            // SelectClassCmbox
            // 
            this.SelectClassCmbox.FormattingEnabled = true;
            this.SelectClassCmbox.Location = new System.Drawing.Point(464, 114);
            this.SelectClassCmbox.Name = "SelectClassCmbox";
            this.SelectClassCmbox.Size = new System.Drawing.Size(179, 21);
            this.SelectClassCmbox.TabIndex = 12;
            // 
            // lblClass
            // 
            this.lblClass.AutoSize = true;
            this.lblClass.BackColor = System.Drawing.Color.White;
            this.lblClass.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClass.Location = new System.Drawing.Point(327, 118);
            this.lblClass.Name = "lblClass";
            this.lblClass.Size = new System.Drawing.Size(39, 15);
            this.lblClass.TabIndex = 9;
            this.lblClass.Text = "Class:";
            // 
            // lblGContact
            // 
            this.lblGContact.AutoSize = true;
            this.lblGContact.BackColor = System.Drawing.Color.White;
            this.lblGContact.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGContact.Location = new System.Drawing.Point(327, 256);
            this.lblGContact.Name = "lblGContact";
            this.lblGContact.Size = new System.Drawing.Size(111, 15);
            this.lblGContact.TabIndex = 8;
            this.lblGContact.Text = "Guardian\'s Contact:";
            // 
            // EmailTxt
            // 
            this.EmailTxt.Location = new System.Drawing.Point(464, 297);
            this.EmailTxt.Name = "EmailTxt";
            this.EmailTxt.Size = new System.Drawing.Size(178, 20);
            this.EmailTxt.TabIndex = 7;
            // 
            // GContactTxt
            // 
            this.GContactTxt.Location = new System.Drawing.Point(464, 253);
            this.GContactTxt.Name = "GContactTxt";
            this.GContactTxt.Size = new System.Drawing.Size(178, 20);
            this.GContactTxt.TabIndex = 7;
            // 
            // RollTxt
            // 
            this.RollTxt.Location = new System.Drawing.Point(464, 157);
            this.RollTxt.Name = "RollTxt";
            this.RollTxt.Size = new System.Drawing.Size(178, 20);
            this.RollTxt.TabIndex = 7;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.BackColor = System.Drawing.Color.White;
            this.lblEmail.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(328, 299);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(38, 15);
            this.lblEmail.TabIndex = 3;
            this.lblEmail.Text = "Email:";
            // 
            // lblLeaveYear
            // 
            this.lblLeaveYear.AutoSize = true;
            this.lblLeaveYear.BackColor = System.Drawing.Color.White;
            this.lblLeaveYear.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLeaveYear.Location = new System.Drawing.Point(328, 207);
            this.lblLeaveYear.Name = "lblLeaveYear";
            this.lblLeaveYear.Size = new System.Drawing.Size(79, 15);
            this.lblLeaveYear.TabIndex = 3;
            this.lblLeaveYear.Text = "Leaving year:";
            // 
            // lblRoll
            // 
            this.lblRoll.AutoSize = true;
            this.lblRoll.BackColor = System.Drawing.Color.White;
            this.lblRoll.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoll.Location = new System.Drawing.Point(328, 163);
            this.lblRoll.Name = "lblRoll";
            this.lblRoll.Size = new System.Drawing.Size(31, 15);
            this.lblRoll.TabIndex = 3;
            this.lblRoll.Text = "Roll:";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(328, 35);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(44, 15);
            this.lblStatus.TabIndex = 3;
            this.lblStatus.Text = "Status:";
            // 
            // lblFName
            // 
            this.lblFName.AutoSize = true;
            this.lblFName.BackColor = System.Drawing.Color.White;
            this.lblFName.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFName.Location = new System.Drawing.Point(328, 78);
            this.lblFName.Name = "lblFName";
            this.lblFName.Size = new System.Drawing.Size(35, 15);
            this.lblFName.TabIndex = 3;
            this.lblFName.Text = "Shift:";
            // 
            // stdRichTxtBox
            // 
            this.stdRichTxtBox.BackColor = System.Drawing.Color.White;
            this.stdRichTxtBox.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stdRichTxtBox.Location = new System.Drawing.Point(263, 17);
            this.stdRichTxtBox.Name = "stdRichTxtBox";
            this.stdRichTxtBox.Size = new System.Drawing.Size(511, 507);
            this.stdRichTxtBox.TabIndex = 2;
            this.stdRichTxtBox.Text = "";
            // 
            // stdList
            // 
            this.stdList.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stdList.FormattingEnabled = true;
            this.stdList.ItemHeight = 16;
            this.stdList.Location = new System.Drawing.Point(7, 49);
            this.stdList.Name = "stdList";
            this.stdList.Size = new System.Drawing.Size(249, 468);
            this.stdList.TabIndex = 0;
            this.stdList.SelectedIndexChanged += new System.EventHandler(this.stdList_SelectedIndexChanged);
            // 
            // EditStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImage = global::SMS.Properties.Resources.back_edit;
            this.Controls.Add(this.topBarBox);
            this.Controls.Add(this.lblAdminHome);
            this.Controls.Add(this.stdGrpBox);
            this.Name = "EditStudent";
            this.Size = new System.Drawing.Size(823, 671);
            this.topBarBox.ResumeLayout(false);
            this.stdAddressBox.ResumeLayout(false);
            this.stdAddressBox.PerformLayout();
            this.stdGrpBox.ResumeLayout(false);
            this.stdGrpBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.GroupBox topBarBox;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Button btnForward;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.GroupBox stdAddressBox;
        private System.Windows.Forms.Label lblZip;
        private System.Windows.Forms.Label lblDistrict;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblStreet;
        private System.Windows.Forms.Label lblAdminHome;
        private System.Windows.Forms.GroupBox stdGrpBox;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblLeaveYear;
        private System.Windows.Forms.Label lblFName;
        private System.Windows.Forms.RichTextBox stdRichTxtBox;
        private System.Windows.Forms.ListBox stdList;
        private System.Windows.Forms.Label lblGContact;
        private System.Windows.Forms.ComboBox districtTxt;
        private System.Windows.Forms.TextBox zipTxt;
        private System.Windows.Forms.TextBox CityTxt;
        private System.Windows.Forms.TextBox streetTxt;
        private System.Windows.Forms.TextBox EmailTxt;
        private System.Windows.Forms.TextBox GContactTxt;
        private System.Windows.Forms.TextBox RollTxt;
        private System.Windows.Forms.Label lblRoll;
        private System.Windows.Forms.Label lblClass;
        private System.Windows.Forms.ComboBox SelectClassCmbox;
        private System.Windows.Forms.ComboBox SelectLeaveYearCmbox;
        private System.Windows.Forms.Label lblMeta;
        private System.Windows.Forms.RichTextBox MetaRichBoxTxt;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.ComboBox selectShift;
        private System.Windows.Forms.ComboBox SelectShiftCombo;
        private System.Windows.Forms.ComboBox SelectClassCombo;
        private System.Windows.Forms.ComboBox lblStatusSelect;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblCurrent;
        private System.Windows.Forms.Button btnStdEditCancel;
        private System.Windows.Forms.Button btnStdEditSave;
    }
}
