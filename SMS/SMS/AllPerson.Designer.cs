namespace SMS
{
    partial class AllPerson
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
            this.PersonGrpBox = new System.Windows.Forms.GroupBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.sortListBox = new System.Windows.Forms.TextBox();
            this.tabGeneral = new System.Windows.Forms.TabControl();
            this.tabPageGnrl = new System.Windows.Forms.TabPage();
            this.lblBloodTxt = new System.Windows.Forms.Label();
            this.lblSexTxt = new System.Windows.Forms.Label();
            this.lblRoleTxt = new System.Windows.Forms.Label();
            this.lblMotherTxt = new System.Windows.Forms.Label();
            this.lblFatherTxt = new System.Windows.Forms.Label();
            this.lblNameTxt = new System.Windows.Forms.Label();
            this.lblBlood = new System.Windows.Forms.Label();
            this.lblSex = new System.Windows.Forms.Label();
            this.lblRole = new System.Windows.Forms.Label();
            this.lblMotherName = new System.Windows.Forms.Label();
            this.lblFatherName = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.tabPageCntct = new System.Windows.Forms.TabPage();
            this.addressBox = new System.Windows.Forms.GroupBox();
            this.lblStreet = new System.Windows.Forms.Label();
            this.lblStreetTxt = new System.Windows.Forms.Label();
            this.lblZipTxt = new System.Windows.Forms.Label();
            this.lblZip = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblDistrict = new System.Windows.Forms.Label();
            this.lblDistrictTxt = new System.Windows.Forms.Label();
            this.lblCityTxt = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblEmailTxt = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.PersonOptionBox = new System.Windows.Forms.GroupBox();
            this.btnPersonDelete = new System.Windows.Forms.Button();
            this.btnPersonEdit = new System.Windows.Forms.Button();
            this.btnPersonCreate = new System.Windows.Forms.Button();
            this.PersonList = new System.Windows.Forms.ListBox();
            this.topBarBox = new System.Windows.Forms.GroupBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.btnForward = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.lblAdminHome = new System.Windows.Forms.Label();
            this.PersonGrpBox.SuspendLayout();
            this.tabGeneral.SuspendLayout();
            this.tabPageGnrl.SuspendLayout();
            this.tabPageCntct.SuspendLayout();
            this.addressBox.SuspendLayout();
            this.PersonOptionBox.SuspendLayout();
            this.topBarBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // PersonGrpBox
            // 
            this.PersonGrpBox.Controls.Add(this.lblSearch);
            this.PersonGrpBox.Controls.Add(this.sortListBox);
            this.PersonGrpBox.Controls.Add(this.tabGeneral);
            this.PersonGrpBox.Controls.Add(this.PersonOptionBox);
            this.PersonGrpBox.Controls.Add(this.PersonList);
            this.PersonGrpBox.Location = new System.Drawing.Point(18, 104);
            this.PersonGrpBox.Name = "PersonGrpBox";
            this.PersonGrpBox.Size = new System.Drawing.Size(787, 521);
            this.PersonGrpBox.TabIndex = 11;
            this.PersonGrpBox.TabStop = false;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.Location = new System.Drawing.Point(4, 21);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(52, 15);
            this.lblSearch.TabIndex = 5;
            this.lblSearch.Text = "Search:";
            // 
            // sortListBox
            // 
            this.sortListBox.Location = new System.Drawing.Point(58, 19);
            this.sortListBox.Name = "sortListBox";
            this.sortListBox.Size = new System.Drawing.Size(203, 20);
            this.sortListBox.TabIndex = 4;
            this.sortListBox.TextChanged += new System.EventHandler(this.sortListBox_TextChanged);
            // 
            // tabGeneral
            // 
            this.tabGeneral.Controls.Add(this.tabPageGnrl);
            this.tabGeneral.Controls.Add(this.tabPageCntct);
            this.tabGeneral.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabGeneral.Location = new System.Drawing.Point(273, 19);
            this.tabGeneral.Name = "tabGeneral";
            this.tabGeneral.SelectedIndex = 0;
            this.tabGeneral.Size = new System.Drawing.Size(508, 338);
            this.tabGeneral.TabIndex = 3;
            // 
            // tabPageGnrl
            // 
            this.tabPageGnrl.Controls.Add(this.lblBloodTxt);
            this.tabPageGnrl.Controls.Add(this.lblSexTxt);
            this.tabPageGnrl.Controls.Add(this.lblRoleTxt);
            this.tabPageGnrl.Controls.Add(this.lblMotherTxt);
            this.tabPageGnrl.Controls.Add(this.lblFatherTxt);
            this.tabPageGnrl.Controls.Add(this.lblNameTxt);
            this.tabPageGnrl.Controls.Add(this.lblBlood);
            this.tabPageGnrl.Controls.Add(this.lblSex);
            this.tabPageGnrl.Controls.Add(this.lblRole);
            this.tabPageGnrl.Controls.Add(this.lblMotherName);
            this.tabPageGnrl.Controls.Add(this.lblFatherName);
            this.tabPageGnrl.Controls.Add(this.lblName);
            this.tabPageGnrl.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPageGnrl.Location = new System.Drawing.Point(4, 24);
            this.tabPageGnrl.Name = "tabPageGnrl";
            this.tabPageGnrl.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageGnrl.Size = new System.Drawing.Size(500, 310);
            this.tabPageGnrl.TabIndex = 0;
            this.tabPageGnrl.Text = "General";
            this.tabPageGnrl.UseVisualStyleBackColor = true;
            // 
            // lblBloodTxt
            // 
            this.lblBloodTxt.AutoSize = true;
            this.lblBloodTxt.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBloodTxt.Location = new System.Drawing.Point(230, 248);
            this.lblBloodTxt.Name = "lblBloodTxt";
            this.lblBloodTxt.Size = new System.Drawing.Size(12, 18);
            this.lblBloodTxt.TabIndex = 2;
            this.lblBloodTxt.Text = "-";
            // 
            // lblSexTxt
            // 
            this.lblSexTxt.AutoSize = true;
            this.lblSexTxt.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSexTxt.Location = new System.Drawing.Point(230, 210);
            this.lblSexTxt.Name = "lblSexTxt";
            this.lblSexTxt.Size = new System.Drawing.Size(12, 18);
            this.lblSexTxt.TabIndex = 2;
            this.lblSexTxt.Text = "-";
            // 
            // lblRoleTxt
            // 
            this.lblRoleTxt.AutoSize = true;
            this.lblRoleTxt.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoleTxt.Location = new System.Drawing.Point(230, 170);
            this.lblRoleTxt.Name = "lblRoleTxt";
            this.lblRoleTxt.Size = new System.Drawing.Size(12, 18);
            this.lblRoleTxt.TabIndex = 2;
            this.lblRoleTxt.Text = "-";
            // 
            // lblMotherTxt
            // 
            this.lblMotherTxt.AutoSize = true;
            this.lblMotherTxt.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMotherTxt.Location = new System.Drawing.Point(230, 128);
            this.lblMotherTxt.Name = "lblMotherTxt";
            this.lblMotherTxt.Size = new System.Drawing.Size(12, 18);
            this.lblMotherTxt.TabIndex = 2;
            this.lblMotherTxt.Text = "-";
            // 
            // lblFatherTxt
            // 
            this.lblFatherTxt.AutoSize = true;
            this.lblFatherTxt.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFatherTxt.Location = new System.Drawing.Point(230, 84);
            this.lblFatherTxt.Name = "lblFatherTxt";
            this.lblFatherTxt.Size = new System.Drawing.Size(12, 18);
            this.lblFatherTxt.TabIndex = 2;
            this.lblFatherTxt.Text = "-";
            // 
            // lblNameTxt
            // 
            this.lblNameTxt.AutoSize = true;
            this.lblNameTxt.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameTxt.Location = new System.Drawing.Point(230, 46);
            this.lblNameTxt.Name = "lblNameTxt";
            this.lblNameTxt.Size = new System.Drawing.Size(12, 18);
            this.lblNameTxt.TabIndex = 2;
            this.lblNameTxt.Text = "-";
            // 
            // lblBlood
            // 
            this.lblBlood.AutoSize = true;
            this.lblBlood.Location = new System.Drawing.Point(90, 248);
            this.lblBlood.Name = "lblBlood";
            this.lblBlood.Size = new System.Drawing.Size(78, 15);
            this.lblBlood.TabIndex = 1;
            this.lblBlood.Text = "Blood Group:";
            // 
            // lblSex
            // 
            this.lblSex.AutoSize = true;
            this.lblSex.Location = new System.Drawing.Point(90, 210);
            this.lblSex.Name = "lblSex";
            this.lblSex.Size = new System.Drawing.Size(28, 15);
            this.lblSex.TabIndex = 1;
            this.lblSex.Text = "Sex:";
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.Location = new System.Drawing.Point(90, 170);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(34, 15);
            this.lblRole.TabIndex = 1;
            this.lblRole.Text = "Role:";
            // 
            // lblMotherName
            // 
            this.lblMotherName.AutoSize = true;
            this.lblMotherName.Location = new System.Drawing.Point(90, 128);
            this.lblMotherName.Name = "lblMotherName";
            this.lblMotherName.Size = new System.Drawing.Size(91, 15);
            this.lblMotherName.TabIndex = 1;
            this.lblMotherName.Text = "Mother\'s Name:";
            // 
            // lblFatherName
            // 
            this.lblFatherName.AutoSize = true;
            this.lblFatherName.Location = new System.Drawing.Point(90, 84);
            this.lblFatherName.Name = "lblFatherName";
            this.lblFatherName.Size = new System.Drawing.Size(85, 15);
            this.lblFatherName.TabIndex = 1;
            this.lblFatherName.Text = "Father\'s Name:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(90, 46);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(40, 15);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name:";
            // 
            // tabPageCntct
            // 
            this.tabPageCntct.Controls.Add(this.addressBox);
            this.tabPageCntct.Controls.Add(this.lblAddress);
            this.tabPageCntct.Controls.Add(this.lblEmailTxt);
            this.tabPageCntct.Controls.Add(this.lblEmail);
            this.tabPageCntct.Location = new System.Drawing.Point(4, 24);
            this.tabPageCntct.Name = "tabPageCntct";
            this.tabPageCntct.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCntct.Size = new System.Drawing.Size(500, 310);
            this.tabPageCntct.TabIndex = 1;
            this.tabPageCntct.Text = "Contact";
            this.tabPageCntct.UseVisualStyleBackColor = true;
            // 
            // addressBox
            // 
            this.addressBox.Controls.Add(this.lblStreet);
            this.addressBox.Controls.Add(this.lblStreetTxt);
            this.addressBox.Controls.Add(this.lblZipTxt);
            this.addressBox.Controls.Add(this.lblZip);
            this.addressBox.Controls.Add(this.lblCity);
            this.addressBox.Controls.Add(this.lblDistrict);
            this.addressBox.Controls.Add(this.lblDistrictTxt);
            this.addressBox.Controls.Add(this.lblCityTxt);
            this.addressBox.Location = new System.Drawing.Point(170, 80);
            this.addressBox.Name = "addressBox";
            this.addressBox.Size = new System.Drawing.Size(201, 187);
            this.addressBox.TabIndex = 2;
            this.addressBox.TabStop = false;
            // 
            // lblStreet
            // 
            this.lblStreet.AutoSize = true;
            this.lblStreet.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStreet.Location = new System.Drawing.Point(27, 27);
            this.lblStreet.Name = "lblStreet";
            this.lblStreet.Size = new System.Drawing.Size(58, 15);
            this.lblStreet.TabIndex = 0;
            this.lblStreet.Text = "Street no:";
            // 
            // lblStreetTxt
            // 
            this.lblStreetTxt.AutoSize = true;
            this.lblStreetTxt.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStreetTxt.Location = new System.Drawing.Point(94, 27);
            this.lblStreetTxt.Name = "lblStreetTxt";
            this.lblStreetTxt.Size = new System.Drawing.Size(12, 18);
            this.lblStreetTxt.TabIndex = 0;
            this.lblStreetTxt.Text = "-";
            // 
            // lblZipTxt
            // 
            this.lblZipTxt.AutoSize = true;
            this.lblZipTxt.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblZipTxt.Location = new System.Drawing.Point(94, 149);
            this.lblZipTxt.Name = "lblZipTxt";
            this.lblZipTxt.Size = new System.Drawing.Size(12, 18);
            this.lblZipTxt.TabIndex = 0;
            this.lblZipTxt.Text = "-";
            // 
            // lblZip
            // 
            this.lblZip.AutoSize = true;
            this.lblZip.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblZip.Location = new System.Drawing.Point(27, 149);
            this.lblZip.Name = "lblZip";
            this.lblZip.Size = new System.Drawing.Size(57, 15);
            this.lblZip.TabIndex = 0;
            this.lblZip.Text = "Zip code:";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCity.Location = new System.Drawing.Point(27, 65);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(32, 15);
            this.lblCity.TabIndex = 0;
            this.lblCity.Text = "City:";
            // 
            // lblDistrict
            // 
            this.lblDistrict.AutoSize = true;
            this.lblDistrict.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDistrict.Location = new System.Drawing.Point(27, 106);
            this.lblDistrict.Name = "lblDistrict";
            this.lblDistrict.Size = new System.Drawing.Size(49, 15);
            this.lblDistrict.TabIndex = 0;
            this.lblDistrict.Text = "District:";
            // 
            // lblDistrictTxt
            // 
            this.lblDistrictTxt.AutoSize = true;
            this.lblDistrictTxt.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDistrictTxt.Location = new System.Drawing.Point(94, 106);
            this.lblDistrictTxt.Name = "lblDistrictTxt";
            this.lblDistrictTxt.Size = new System.Drawing.Size(12, 18);
            this.lblDistrictTxt.TabIndex = 0;
            this.lblDistrictTxt.Text = "-";
            // 
            // lblCityTxt
            // 
            this.lblCityTxt.AutoSize = true;
            this.lblCityTxt.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCityTxt.Location = new System.Drawing.Point(94, 65);
            this.lblCityTxt.Name = "lblCityTxt";
            this.lblCityTxt.Size = new System.Drawing.Size(12, 18);
            this.lblCityTxt.TabIndex = 0;
            this.lblCityTxt.Text = "-";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.Location = new System.Drawing.Point(90, 102);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(56, 15);
            this.lblAddress.TabIndex = 1;
            this.lblAddress.Text = "Address:";
            // 
            // lblEmailTxt
            // 
            this.lblEmailTxt.AutoSize = true;
            this.lblEmailTxt.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmailTxt.Location = new System.Drawing.Point(167, 47);
            this.lblEmailTxt.Name = "lblEmailTxt";
            this.lblEmailTxt.Size = new System.Drawing.Size(12, 18);
            this.lblEmailTxt.TabIndex = 0;
            this.lblEmailTxt.Text = "-";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(90, 47);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(42, 15);
            this.lblEmail.TabIndex = 0;
            this.lblEmail.Text = "E-mail:";
            // 
            // PersonOptionBox
            // 
            this.PersonOptionBox.Controls.Add(this.btnPersonDelete);
            this.PersonOptionBox.Controls.Add(this.btnPersonEdit);
            this.PersonOptionBox.Controls.Add(this.btnPersonCreate);
            this.PersonOptionBox.Location = new System.Drawing.Point(308, 363);
            this.PersonOptionBox.Name = "PersonOptionBox";
            this.PersonOptionBox.Size = new System.Drawing.Size(423, 140);
            this.PersonOptionBox.TabIndex = 1;
            this.PersonOptionBox.TabStop = false;
            // 
            // btnPersonDelete
            // 
            this.btnPersonDelete.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPersonDelete.Image = global::SMS.Properties.Resources.AllDelete;
            this.btnPersonDelete.Location = new System.Drawing.Point(289, 19);
            this.btnPersonDelete.Name = "btnPersonDelete";
            this.btnPersonDelete.Size = new System.Drawing.Size(112, 109);
            this.btnPersonDelete.TabIndex = 0;
            this.btnPersonDelete.Text = "Delete Person";
            this.btnPersonDelete.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPersonDelete.UseVisualStyleBackColor = true;
            this.btnPersonDelete.Click += new System.EventHandler(this.btnPersonDelete_Click);
            // 
            // btnPersonEdit
            // 
            this.btnPersonEdit.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPersonEdit.Image = global::SMS.Properties.Resources.AllEdit;
            this.btnPersonEdit.Location = new System.Drawing.Point(154, 19);
            this.btnPersonEdit.Name = "btnPersonEdit";
            this.btnPersonEdit.Size = new System.Drawing.Size(112, 109);
            this.btnPersonEdit.TabIndex = 0;
            this.btnPersonEdit.Text = "Edit Person";
            this.btnPersonEdit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPersonEdit.UseVisualStyleBackColor = true;
            this.btnPersonEdit.Click += new System.EventHandler(this.btnPersonEdit_Click);
            // 
            // btnPersonCreate
            // 
            this.btnPersonCreate.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPersonCreate.Image = global::SMS.Properties.Resources.AllAdd;
            this.btnPersonCreate.Location = new System.Drawing.Point(20, 19);
            this.btnPersonCreate.Name = "btnPersonCreate";
            this.btnPersonCreate.Size = new System.Drawing.Size(112, 109);
            this.btnPersonCreate.TabIndex = 0;
            this.btnPersonCreate.Text = "Create Person";
            this.btnPersonCreate.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPersonCreate.UseVisualStyleBackColor = true;
            this.btnPersonCreate.Click += new System.EventHandler(this.btnPersonCreate_Click);
            // 
            // PersonList
            // 
            this.PersonList.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PersonList.FormattingEnabled = true;
            this.PersonList.ItemHeight = 17;
            this.PersonList.Location = new System.Drawing.Point(6, 51);
            this.PersonList.Name = "PersonList";
            this.PersonList.Size = new System.Drawing.Size(255, 446);
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
            this.topBarBox.TabIndex = 13;
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
            this.lblAdminHome.Location = new System.Drawing.Point(350, 637);
            this.lblAdminHome.Name = "lblAdminHome";
            this.lblAdminHome.Size = new System.Drawing.Size(105, 18);
            this.lblAdminHome.TabIndex = 12;
            this.lblAdminHome.Text = "ADMIN AREA";
            // 
            // AllPerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImage = global::SMS.Properties.Resources.back_start;
            this.Controls.Add(this.PersonGrpBox);
            this.Controls.Add(this.topBarBox);
            this.Controls.Add(this.lblAdminHome);
            this.Name = "AllPerson";
            this.Size = new System.Drawing.Size(823, 671);
            this.PersonGrpBox.ResumeLayout(false);
            this.PersonGrpBox.PerformLayout();
            this.tabGeneral.ResumeLayout(false);
            this.tabPageGnrl.ResumeLayout(false);
            this.tabPageGnrl.PerformLayout();
            this.tabPageCntct.ResumeLayout(false);
            this.tabPageCntct.PerformLayout();
            this.addressBox.ResumeLayout(false);
            this.addressBox.PerformLayout();
            this.PersonOptionBox.ResumeLayout(false);
            this.topBarBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox PersonGrpBox;
        private System.Windows.Forms.GroupBox PersonOptionBox;
        private System.Windows.Forms.Button btnPersonDelete;
        private System.Windows.Forms.Button btnPersonEdit;
        private System.Windows.Forms.Button btnPersonCreate;
        private System.Windows.Forms.ListBox PersonList;
        private System.Windows.Forms.GroupBox topBarBox;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Button btnForward;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Label lblAdminHome;
        private System.Windows.Forms.TabControl tabGeneral;
        private System.Windows.Forms.TabPage tabPageGnrl;
        private System.Windows.Forms.TabPage tabPageCntct;
        private System.Windows.Forms.Label lblBlood;
        private System.Windows.Forms.Label lblSex;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.Label lblMotherName;
        private System.Windows.Forms.Label lblFatherName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblBloodTxt;
        private System.Windows.Forms.Label lblSexTxt;
        private System.Windows.Forms.Label lblRoleTxt;
        private System.Windows.Forms.Label lblMotherTxt;
        private System.Windows.Forms.Label lblFatherTxt;
        private System.Windows.Forms.Label lblNameTxt;
        private System.Windows.Forms.Label lblZip;
        private System.Windows.Forms.Label lblDistrict;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblStreet;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblZipTxt;
        private System.Windows.Forms.Label lblDistrictTxt;
        private System.Windows.Forms.Label lblCityTxt;
        private System.Windows.Forms.Label lblStreetTxt;
        private System.Windows.Forms.Label lblEmailTxt;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.GroupBox addressBox;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.TextBox sortListBox;
        private System.Windows.Forms.Label lblSearch;

    }
}
