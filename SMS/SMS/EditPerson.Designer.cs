namespace SMS
{
    partial class EditPerson
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
            this.cmbSelectBlood = new System.Windows.Forms.ComboBox();
            this.lblFather = new System.Windows.Forms.Label();
            this.TxtFather = new System.Windows.Forms.TextBox();
            this.personAddressBox = new System.Windows.Forms.GroupBox();
            this.cmbSelectDistrict = new System.Windows.Forms.ComboBox();
            this.lblZip = new System.Windows.Forms.Label();
            this.lblDistrict = new System.Windows.Forms.Label();
            this.TxtZip = new System.Windows.Forms.TextBox();
            this.TxtCity = new System.Windows.Forms.TextBox();
            this.TxtStreet = new System.Windows.Forms.TextBox();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblStreet = new System.Windows.Forms.Label();
            this.personGrpBox = new System.Windows.Forms.GroupBox();
            this.btnPersonEditCancel = new System.Windows.Forms.Button();
            this.btnPersonEditSave = new System.Windows.Forms.Button();
            this.TxtLName = new System.Windows.Forms.TextBox();
            this.TxtFName = new System.Windows.Forms.TextBox();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.TxtMother = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblBlood = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblMother = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.personRichTxtBox = new System.Windows.Forms.RichTextBox();
            this.PersonList = new System.Windows.Forms.ListBox();
            this.topBarBox = new System.Windows.Forms.GroupBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.btnForward = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.lblAdminHome = new System.Windows.Forms.Label();
            this.lblSearch = new System.Windows.Forms.Label();
            this.sortListBox = new System.Windows.Forms.TextBox();
            this.personAddressBox.SuspendLayout();
            this.personGrpBox.SuspendLayout();
            this.topBarBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbSelectBlood
            // 
            this.cmbSelectBlood.FormattingEnabled = true;
            this.cmbSelectBlood.Location = new System.Drawing.Point(467, 204);
            this.cmbSelectBlood.Name = "cmbSelectBlood";
            this.cmbSelectBlood.Size = new System.Drawing.Size(257, 21);
            this.cmbSelectBlood.TabIndex = 10;
            // 
            // lblFather
            // 
            this.lblFather.AutoSize = true;
            this.lblFather.BackColor = System.Drawing.Color.White;
            this.lblFather.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFather.Location = new System.Drawing.Point(355, 101);
            this.lblFather.Name = "lblFather";
            this.lblFather.Size = new System.Drawing.Size(85, 15);
            this.lblFather.TabIndex = 9;
            this.lblFather.Text = "Father\'s Name:";
            // 
            // TxtFather
            // 
            this.TxtFather.Location = new System.Drawing.Point(467, 93);
            this.TxtFather.Name = "TxtFather";
            this.TxtFather.Size = new System.Drawing.Size(257, 20);
            this.TxtFather.TabIndex = 7;
            // 
            // personAddressBox
            // 
            this.personAddressBox.BackColor = System.Drawing.Color.White;
            this.personAddressBox.Controls.Add(this.cmbSelectDistrict);
            this.personAddressBox.Controls.Add(this.lblZip);
            this.personAddressBox.Controls.Add(this.lblDistrict);
            this.personAddressBox.Controls.Add(this.TxtZip);
            this.personAddressBox.Controls.Add(this.TxtCity);
            this.personAddressBox.Controls.Add(this.TxtStreet);
            this.personAddressBox.Controls.Add(this.lblCity);
            this.personAddressBox.Controls.Add(this.lblStreet);
            this.personAddressBox.Location = new System.Drawing.Point(467, 301);
            this.personAddressBox.Name = "personAddressBox";
            this.personAddressBox.Size = new System.Drawing.Size(257, 144);
            this.personAddressBox.TabIndex = 5;
            this.personAddressBox.TabStop = false;
            // 
            // cmbSelectDistrict
            // 
            this.cmbSelectDistrict.FormattingEnabled = true;
            this.cmbSelectDistrict.Location = new System.Drawing.Point(90, 76);
            this.cmbSelectDistrict.Name = "cmbSelectDistrict";
            this.cmbSelectDistrict.Size = new System.Drawing.Size(134, 21);
            this.cmbSelectDistrict.TabIndex = 10;
            // 
            // lblZip
            // 
            this.lblZip.AutoSize = true;
            this.lblZip.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblZip.Location = new System.Drawing.Point(28, 111);
            this.lblZip.Name = "lblZip";
            this.lblZip.Size = new System.Drawing.Size(27, 15);
            this.lblZip.TabIndex = 5;
            this.lblZip.Text = "Zip:";
            // 
            // lblDistrict
            // 
            this.lblDistrict.AutoSize = true;
            this.lblDistrict.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDistrict.Location = new System.Drawing.Point(27, 78);
            this.lblDistrict.Name = "lblDistrict";
            this.lblDistrict.Size = new System.Drawing.Size(47, 15);
            this.lblDistrict.TabIndex = 5;
            this.lblDistrict.Text = "District:";
            // 
            // TxtZip
            // 
            this.TxtZip.Location = new System.Drawing.Point(90, 109);
            this.TxtZip.Name = "TxtZip";
            this.TxtZip.Size = new System.Drawing.Size(134, 20);
            this.TxtZip.TabIndex = 7;
            // 
            // TxtCity
            // 
            this.TxtCity.Location = new System.Drawing.Point(90, 43);
            this.TxtCity.Name = "TxtCity";
            this.TxtCity.Size = new System.Drawing.Size(134, 20);
            this.TxtCity.TabIndex = 7;
            // 
            // TxtStreet
            // 
            this.TxtStreet.Location = new System.Drawing.Point(90, 13);
            this.TxtStreet.Name = "TxtStreet";
            this.TxtStreet.Size = new System.Drawing.Size(134, 20);
            this.TxtStreet.TabIndex = 7;
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCity.Location = new System.Drawing.Point(28, 45);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(31, 15);
            this.lblCity.TabIndex = 5;
            this.lblCity.Text = "City:";
            // 
            // lblStreet
            // 
            this.lblStreet.AutoSize = true;
            this.lblStreet.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStreet.Location = new System.Drawing.Point(27, 18);
            this.lblStreet.Name = "lblStreet";
            this.lblStreet.Size = new System.Drawing.Size(42, 15);
            this.lblStreet.TabIndex = 5;
            this.lblStreet.Text = "Street:";
            // 
            // personGrpBox
            // 
            this.personGrpBox.Controls.Add(this.lblSearch);
            this.personGrpBox.Controls.Add(this.sortListBox);
            this.personGrpBox.Controls.Add(this.btnPersonEditCancel);
            this.personGrpBox.Controls.Add(this.btnPersonEditSave);
            this.personGrpBox.Controls.Add(this.cmbSelectBlood);
            this.personGrpBox.Controls.Add(this.lblFather);
            this.personGrpBox.Controls.Add(this.TxtLName);
            this.personGrpBox.Controls.Add(this.TxtFName);
            this.personGrpBox.Controls.Add(this.TxtEmail);
            this.personGrpBox.Controls.Add(this.TxtMother);
            this.personGrpBox.Controls.Add(this.TxtFather);
            this.personGrpBox.Controls.Add(this.personAddressBox);
            this.personGrpBox.Controls.Add(this.lblAddress);
            this.personGrpBox.Controls.Add(this.lblBlood);
            this.personGrpBox.Controls.Add(this.lblEmail);
            this.personGrpBox.Controls.Add(this.lblMother);
            this.personGrpBox.Controls.Add(this.lblName);
            this.personGrpBox.Controls.Add(this.personRichTxtBox);
            this.personGrpBox.Controls.Add(this.PersonList);
            this.personGrpBox.Location = new System.Drawing.Point(18, 104);
            this.personGrpBox.Name = "personGrpBox";
            this.personGrpBox.Size = new System.Drawing.Size(787, 521);
            this.personGrpBox.TabIndex = 17;
            this.personGrpBox.TabStop = false;
            // 
            // btnPersonEditCancel
            // 
            this.btnPersonEditCancel.BackColor = System.Drawing.Color.Silver;
            this.btnPersonEditCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnPersonEditCancel.FlatAppearance.BorderSize = 2;
            this.btnPersonEditCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPersonEditCancel.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPersonEditCancel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnPersonEditCancel.Location = new System.Drawing.Point(525, 467);
            this.btnPersonEditCancel.Name = "btnPersonEditCancel";
            this.btnPersonEditCancel.Size = new System.Drawing.Size(92, 39);
            this.btnPersonEditCancel.TabIndex = 11;
            this.btnPersonEditCancel.Text = "Cancel";
            this.btnPersonEditCancel.UseVisualStyleBackColor = false;
            this.btnPersonEditCancel.Click += new System.EventHandler(this.btnPersonEditCancel_Click);
            // 
            // btnPersonEditSave
            // 
            this.btnPersonEditSave.BackColor = System.Drawing.Color.Silver;
            this.btnPersonEditSave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnPersonEditSave.FlatAppearance.BorderSize = 2;
            this.btnPersonEditSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPersonEditSave.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPersonEditSave.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnPersonEditSave.Location = new System.Drawing.Point(406, 467);
            this.btnPersonEditSave.Name = "btnPersonEditSave";
            this.btnPersonEditSave.Size = new System.Drawing.Size(92, 39);
            this.btnPersonEditSave.TabIndex = 12;
            this.btnPersonEditSave.Text = "Save";
            this.btnPersonEditSave.UseVisualStyleBackColor = false;
            this.btnPersonEditSave.Click += new System.EventHandler(this.btnPersonEditSave_Click);
            // 
            // TxtLName
            // 
            this.TxtLName.Location = new System.Drawing.Point(598, 38);
            this.TxtLName.Name = "TxtLName";
            this.TxtLName.Size = new System.Drawing.Size(126, 20);
            this.TxtLName.TabIndex = 7;
            // 
            // TxtFName
            // 
            this.TxtFName.Location = new System.Drawing.Point(467, 38);
            this.TxtFName.Name = "TxtFName";
            this.TxtFName.Size = new System.Drawing.Size(125, 20);
            this.TxtFName.TabIndex = 7;
            // 
            // TxtEmail
            // 
            this.TxtEmail.Location = new System.Drawing.Point(467, 258);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(257, 20);
            this.TxtEmail.TabIndex = 7;
            // 
            // TxtMother
            // 
            this.TxtMother.Location = new System.Drawing.Point(467, 149);
            this.TxtMother.Name = "TxtMother";
            this.TxtMother.Size = new System.Drawing.Size(257, 20);
            this.TxtMother.TabIndex = 7;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.BackColor = System.Drawing.Color.White;
            this.lblAddress.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.Location = new System.Drawing.Point(355, 317);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(56, 15);
            this.lblAddress.TabIndex = 3;
            this.lblAddress.Text = "Address:";
            // 
            // lblBlood
            // 
            this.lblBlood.AutoSize = true;
            this.lblBlood.BackColor = System.Drawing.Color.White;
            this.lblBlood.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBlood.Location = new System.Drawing.Point(355, 213);
            this.lblBlood.Name = "lblBlood";
            this.lblBlood.Size = new System.Drawing.Size(78, 15);
            this.lblBlood.TabIndex = 3;
            this.lblBlood.Text = "Blood Group:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.BackColor = System.Drawing.Color.White;
            this.lblEmail.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(355, 266);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(38, 15);
            this.lblEmail.TabIndex = 3;
            this.lblEmail.Text = "Email:";
            // 
            // lblMother
            // 
            this.lblMother.AutoSize = true;
            this.lblMother.BackColor = System.Drawing.Color.White;
            this.lblMother.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMother.Location = new System.Drawing.Point(355, 157);
            this.lblMother.Name = "lblMother";
            this.lblMother.Size = new System.Drawing.Size(91, 15);
            this.lblMother.TabIndex = 3;
            this.lblMother.Text = "Mother\'s Name:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.White;
            this.lblName.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(355, 43);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(40, 15);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "Name:";
            // 
            // personRichTxtBox
            // 
            this.personRichTxtBox.BackColor = System.Drawing.Color.White;
            this.personRichTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.personRichTxtBox.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.personRichTxtBox.Location = new System.Drawing.Point(273, 17);
            this.personRichTxtBox.Name = "personRichTxtBox";
            this.personRichTxtBox.Size = new System.Drawing.Size(508, 497);
            this.personRichTxtBox.TabIndex = 2;
            this.personRichTxtBox.Text = "";
            // 
            // PersonList
            // 
            this.PersonList.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PersonList.FormattingEnabled = true;
            this.PersonList.ItemHeight = 17;
            this.PersonList.Location = new System.Drawing.Point(7, 51);
            this.PersonList.Name = "PersonList";
            this.PersonList.Size = new System.Drawing.Size(260, 463);
            this.PersonList.TabIndex = 0;
            this.PersonList.SelectedIndexChanged += new System.EventHandler(this.PersonList_SelectedIndexChanged);
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
            this.btnRefresh.TabIndex = 20;
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
            this.lblAdminHome.Location = new System.Drawing.Point(329, 637);
            this.lblAdminHome.Name = "lblAdminHome";
            this.lblAdminHome.Size = new System.Drawing.Size(156, 18);
            this.lblAdminHome.TabIndex = 18;
            this.lblAdminHome.Text = "ADMIN : USER AREA";
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.Location = new System.Drawing.Point(8, 23);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(52, 15);
            this.lblSearch.TabIndex = 14;
            this.lblSearch.Text = "Search:";
            // 
            // sortListBox
            // 
            this.sortListBox.Location = new System.Drawing.Point(62, 21);
            this.sortListBox.Name = "sortListBox";
            this.sortListBox.Size = new System.Drawing.Size(203, 20);
            this.sortListBox.TabIndex = 13;
            this.sortListBox.TextChanged += new System.EventHandler(this.sortListBox_TextChanged);
            // 
            // EditPerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImage = global::SMS.Properties.Resources.back_edit;
            this.Controls.Add(this.personGrpBox);
            this.Controls.Add(this.topBarBox);
            this.Controls.Add(this.lblAdminHome);
            this.Name = "EditPerson";
            this.Size = new System.Drawing.Size(823, 671);
            this.personAddressBox.ResumeLayout(false);
            this.personAddressBox.PerformLayout();
            this.personGrpBox.ResumeLayout(false);
            this.personGrpBox.PerformLayout();
            this.topBarBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbSelectBlood;
        private System.Windows.Forms.Label lblFather;
        private System.Windows.Forms.TextBox TxtFather;
        private System.Windows.Forms.GroupBox personAddressBox;
        private System.Windows.Forms.ComboBox cmbSelectDistrict;
        private System.Windows.Forms.Label lblZip;
        private System.Windows.Forms.Label lblDistrict;
        private System.Windows.Forms.TextBox TxtZip;
        private System.Windows.Forms.TextBox TxtCity;
        private System.Windows.Forms.TextBox TxtStreet;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblStreet;
        private System.Windows.Forms.GroupBox personGrpBox;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblBlood;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblMother;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.RichTextBox personRichTxtBox;
        private System.Windows.Forms.ListBox PersonList;
        private System.Windows.Forms.GroupBox topBarBox;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Button btnForward;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Label lblAdminHome;
        private System.Windows.Forms.TextBox TxtFName;
        private System.Windows.Forms.TextBox TxtEmail;
        private System.Windows.Forms.TextBox TxtMother;
        private System.Windows.Forms.TextBox TxtLName;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnPersonEditCancel;
        private System.Windows.Forms.Button btnPersonEditSave;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox sortListBox;

    }
}
