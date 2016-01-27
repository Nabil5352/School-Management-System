namespace SMS
{
    partial class lblStatus
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
            this.stdGrpBox = new System.Windows.Forms.GroupBox();
            this.SelectClassCombo = new System.Windows.Forms.ComboBox();
            this.SelectShiftCombo = new System.Windows.Forms.ComboBox();
            this.studentInfoTab = new System.Windows.Forms.TabControl();
            this.tabGeneral = new System.Windows.Forms.TabPage();
            this.lblRollTxt = new System.Windows.Forms.Label();
            this.lblStatusTxt = new System.Windows.Forms.Label();
            this.lblSectionTxt = new System.Windows.Forms.Label();
            this.lblShiftTxt = new System.Windows.Forms.Label();
            this.lblNameTxt = new System.Windows.Forms.Label();
            this.lblRoll = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblSection = new System.Windows.Forms.Label();
            this.lblShift = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.tabBio = new System.Windows.Forms.TabPage();
            this.lblAchievement = new System.Windows.Forms.Label();
            this.lblBlood = new System.Windows.Forms.Label();
            this.lblMother = new System.Windows.Forms.Label();
            this.lblAchievementTxt = new System.Windows.Forms.Label();
            this.lblBloodTxt = new System.Windows.Forms.Label();
            this.lblMotherTxt = new System.Windows.Forms.Label();
            this.lblFatherTxt = new System.Windows.Forms.Label();
            this.lblFather = new System.Windows.Forms.Label();
            this.tabContact = new System.Windows.Forms.TabPage();
            this.lblEmailTxt = new System.Windows.Forms.Label();
            this.lblGuardianTxt = new System.Windows.Forms.Label();
            this.stdAddressBox = new System.Windows.Forms.GroupBox();
            this.lblZipTxt = new System.Windows.Forms.Label();
            this.lblDistrictTxt = new System.Windows.Forms.Label();
            this.lblCityTxt = new System.Windows.Forms.Label();
            this.lblStreetTxt = new System.Windows.Forms.Label();
            this.lblZip = new System.Windows.Forms.Label();
            this.lblDistrict = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblStreet = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblGuardian = new System.Windows.Forms.Label();
            this.tabResult = new System.Windows.Forms.TabPage();
            this.lblTerm = new System.Windows.Forms.Label();
            this.stdTermInfoGrid = new System.Windows.Forms.DataGridView();
            this.selectStdTerm = new System.Windows.Forms.ComboBox();
            this.stdOptionBox = new System.Windows.Forms.GroupBox();
            this.stdList = new System.Windows.Forms.ListBox();
            this.topBarBox = new System.Windows.Forms.GroupBox();
            this.lblAdminHome = new System.Windows.Forms.Label();
            this.btnStdDelete = new System.Windows.Forms.Button();
            this.btnStdEdit = new System.Windows.Forms.Button();
            this.btnStdCreate = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.btnForward = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.stdGrpBox.SuspendLayout();
            this.studentInfoTab.SuspendLayout();
            this.tabGeneral.SuspendLayout();
            this.tabBio.SuspendLayout();
            this.tabContact.SuspendLayout();
            this.stdAddressBox.SuspendLayout();
            this.tabResult.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stdTermInfoGrid)).BeginInit();
            this.stdOptionBox.SuspendLayout();
            this.topBarBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // stdGrpBox
            // 
            this.stdGrpBox.Controls.Add(this.SelectClassCombo);
            this.stdGrpBox.Controls.Add(this.SelectShiftCombo);
            this.stdGrpBox.Controls.Add(this.studentInfoTab);
            this.stdGrpBox.Controls.Add(this.stdOptionBox);
            this.stdGrpBox.Controls.Add(this.stdList);
            this.stdGrpBox.Location = new System.Drawing.Point(18, 104);
            this.stdGrpBox.Name = "stdGrpBox";
            this.stdGrpBox.Size = new System.Drawing.Size(787, 521);
            this.stdGrpBox.TabIndex = 11;
            this.stdGrpBox.TabStop = false;
            // 
            // SelectClassCombo
            // 
            this.SelectClassCombo.FormattingEnabled = true;
            this.SelectClassCombo.Location = new System.Drawing.Point(135, 20);
            this.SelectClassCombo.Name = "SelectClassCombo";
            this.SelectClassCombo.Size = new System.Drawing.Size(121, 21);
            this.SelectClassCombo.TabIndex = 3;
            this.SelectClassCombo.SelectedIndexChanged += new System.EventHandler(this.SelectClassCombo_SelectedIndexChanged);
            // 
            // SelectShiftCombo
            // 
            this.SelectShiftCombo.FormattingEnabled = true;
            this.SelectShiftCombo.Location = new System.Drawing.Point(7, 20);
            this.SelectShiftCombo.Name = "SelectShiftCombo";
            this.SelectShiftCombo.Size = new System.Drawing.Size(121, 21);
            this.SelectShiftCombo.TabIndex = 3;
            this.SelectShiftCombo.SelectedIndexChanged += new System.EventHandler(this.SelectShiftCombo_SelectedIndexChanged);
            // 
            // studentInfoTab
            // 
            this.studentInfoTab.Controls.Add(this.tabGeneral);
            this.studentInfoTab.Controls.Add(this.tabBio);
            this.studentInfoTab.Controls.Add(this.tabContact);
            this.studentInfoTab.Controls.Add(this.tabResult);
            this.studentInfoTab.Location = new System.Drawing.Point(272, 17);
            this.studentInfoTab.Name = "studentInfoTab";
            this.studentInfoTab.SelectedIndex = 0;
            this.studentInfoTab.Size = new System.Drawing.Size(508, 340);
            this.studentInfoTab.TabIndex = 2;
            // 
            // tabGeneral
            // 
            this.tabGeneral.Controls.Add(this.lblRollTxt);
            this.tabGeneral.Controls.Add(this.lblStatusTxt);
            this.tabGeneral.Controls.Add(this.lblSectionTxt);
            this.tabGeneral.Controls.Add(this.lblShiftTxt);
            this.tabGeneral.Controls.Add(this.lblNameTxt);
            this.tabGeneral.Controls.Add(this.lblRoll);
            this.tabGeneral.Controls.Add(this.label4);
            this.tabGeneral.Controls.Add(this.lblSection);
            this.tabGeneral.Controls.Add(this.lblShift);
            this.tabGeneral.Controls.Add(this.lblName);
            this.tabGeneral.Location = new System.Drawing.Point(4, 22);
            this.tabGeneral.Name = "tabGeneral";
            this.tabGeneral.Padding = new System.Windows.Forms.Padding(3);
            this.tabGeneral.Size = new System.Drawing.Size(500, 314);
            this.tabGeneral.TabIndex = 0;
            this.tabGeneral.Text = "General";
            this.tabGeneral.UseVisualStyleBackColor = true;
            // 
            // lblRollTxt
            // 
            this.lblRollTxt.AutoSize = true;
            this.lblRollTxt.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRollTxt.Location = new System.Drawing.Point(150, 186);
            this.lblRollTxt.Name = "lblRollTxt";
            this.lblRollTxt.Size = new System.Drawing.Size(12, 18);
            this.lblRollTxt.TabIndex = 1;
            this.lblRollTxt.Text = "-";
            // 
            // lblStatusTxt
            // 
            this.lblStatusTxt.AutoSize = true;
            this.lblStatusTxt.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatusTxt.Location = new System.Drawing.Point(150, 240);
            this.lblStatusTxt.Name = "lblStatusTxt";
            this.lblStatusTxt.Size = new System.Drawing.Size(12, 18);
            this.lblStatusTxt.TabIndex = 1;
            this.lblStatusTxt.Text = "-";
            // 
            // lblSectionTxt
            // 
            this.lblSectionTxt.AutoSize = true;
            this.lblSectionTxt.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSectionTxt.Location = new System.Drawing.Point(150, 134);
            this.lblSectionTxt.Name = "lblSectionTxt";
            this.lblSectionTxt.Size = new System.Drawing.Size(12, 18);
            this.lblSectionTxt.TabIndex = 1;
            this.lblSectionTxt.Text = "-";
            // 
            // lblShiftTxt
            // 
            this.lblShiftTxt.AutoSize = true;
            this.lblShiftTxt.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShiftTxt.Location = new System.Drawing.Point(149, 87);
            this.lblShiftTxt.Name = "lblShiftTxt";
            this.lblShiftTxt.Size = new System.Drawing.Size(12, 18);
            this.lblShiftTxt.TabIndex = 1;
            this.lblShiftTxt.Text = "-";
            // 
            // lblNameTxt
            // 
            this.lblNameTxt.AutoSize = true;
            this.lblNameTxt.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameTxt.Location = new System.Drawing.Point(149, 43);
            this.lblNameTxt.Name = "lblNameTxt";
            this.lblNameTxt.Size = new System.Drawing.Size(12, 18);
            this.lblNameTxt.TabIndex = 1;
            this.lblNameTxt.Text = "-";
            // 
            // lblRoll
            // 
            this.lblRoll.AutoSize = true;
            this.lblRoll.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoll.Location = new System.Drawing.Point(85, 187);
            this.lblRoll.Name = "lblRoll";
            this.lblRoll.Size = new System.Drawing.Size(31, 15);
            this.lblRoll.TabIndex = 0;
            this.lblRoll.Text = "Roll:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(85, 241);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Status:";
            // 
            // lblSection
            // 
            this.lblSection.AutoSize = true;
            this.lblSection.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSection.Location = new System.Drawing.Point(85, 137);
            this.lblSection.Name = "lblSection";
            this.lblSection.Size = new System.Drawing.Size(50, 15);
            this.lblSection.TabIndex = 0;
            this.lblSection.Text = "Section:";
            // 
            // lblShift
            // 
            this.lblShift.AutoSize = true;
            this.lblShift.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShift.Location = new System.Drawing.Point(85, 90);
            this.lblShift.Name = "lblShift";
            this.lblShift.Size = new System.Drawing.Size(35, 15);
            this.lblShift.TabIndex = 0;
            this.lblShift.Text = "Shift:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(85, 46);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(40, 15);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name:";
            // 
            // tabBio
            // 
            this.tabBio.Controls.Add(this.lblAchievement);
            this.tabBio.Controls.Add(this.lblBlood);
            this.tabBio.Controls.Add(this.lblMother);
            this.tabBio.Controls.Add(this.lblAchievementTxt);
            this.tabBio.Controls.Add(this.lblBloodTxt);
            this.tabBio.Controls.Add(this.lblMotherTxt);
            this.tabBio.Controls.Add(this.lblFatherTxt);
            this.tabBio.Controls.Add(this.lblFather);
            this.tabBio.Location = new System.Drawing.Point(4, 22);
            this.tabBio.Name = "tabBio";
            this.tabBio.Padding = new System.Windows.Forms.Padding(3);
            this.tabBio.Size = new System.Drawing.Size(500, 314);
            this.tabBio.TabIndex = 1;
            this.tabBio.Text = "Bio";
            this.tabBio.UseVisualStyleBackColor = true;
            // 
            // lblAchievement
            // 
            this.lblAchievement.AutoSize = true;
            this.lblAchievement.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAchievement.Location = new System.Drawing.Point(84, 211);
            this.lblAchievement.Name = "lblAchievement";
            this.lblAchievement.Size = new System.Drawing.Size(81, 15);
            this.lblAchievement.TabIndex = 0;
            this.lblAchievement.Text = "Achievement:";
            // 
            // lblBlood
            // 
            this.lblBlood.AutoSize = true;
            this.lblBlood.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBlood.Location = new System.Drawing.Point(84, 153);
            this.lblBlood.Name = "lblBlood";
            this.lblBlood.Size = new System.Drawing.Size(74, 15);
            this.lblBlood.TabIndex = 0;
            this.lblBlood.Text = "Blood group";
            // 
            // lblMother
            // 
            this.lblMother.AutoSize = true;
            this.lblMother.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMother.Location = new System.Drawing.Point(84, 102);
            this.lblMother.Name = "lblMother";
            this.lblMother.Size = new System.Drawing.Size(91, 15);
            this.lblMother.TabIndex = 0;
            this.lblMother.Text = "Mother\'s Name:";
            // 
            // lblAchievementTxt
            // 
            this.lblAchievementTxt.AutoSize = true;
            this.lblAchievementTxt.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAchievementTxt.Location = new System.Drawing.Point(191, 210);
            this.lblAchievementTxt.Name = "lblAchievementTxt";
            this.lblAchievementTxt.Size = new System.Drawing.Size(12, 18);
            this.lblAchievementTxt.TabIndex = 0;
            this.lblAchievementTxt.Text = "-";
            // 
            // lblBloodTxt
            // 
            this.lblBloodTxt.AutoSize = true;
            this.lblBloodTxt.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBloodTxt.Location = new System.Drawing.Point(191, 150);
            this.lblBloodTxt.Name = "lblBloodTxt";
            this.lblBloodTxt.Size = new System.Drawing.Size(12, 18);
            this.lblBloodTxt.TabIndex = 0;
            this.lblBloodTxt.Text = "-";
            // 
            // lblMotherTxt
            // 
            this.lblMotherTxt.AutoSize = true;
            this.lblMotherTxt.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMotherTxt.Location = new System.Drawing.Point(191, 101);
            this.lblMotherTxt.Name = "lblMotherTxt";
            this.lblMotherTxt.Size = new System.Drawing.Size(12, 18);
            this.lblMotherTxt.TabIndex = 0;
            this.lblMotherTxt.Text = "-";
            // 
            // lblFatherTxt
            // 
            this.lblFatherTxt.AutoSize = true;
            this.lblFatherTxt.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFatherTxt.Location = new System.Drawing.Point(191, 49);
            this.lblFatherTxt.Name = "lblFatherTxt";
            this.lblFatherTxt.Size = new System.Drawing.Size(12, 18);
            this.lblFatherTxt.TabIndex = 0;
            this.lblFatherTxt.Text = "-";
            // 
            // lblFather
            // 
            this.lblFather.AutoSize = true;
            this.lblFather.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFather.Location = new System.Drawing.Point(84, 52);
            this.lblFather.Name = "lblFather";
            this.lblFather.Size = new System.Drawing.Size(85, 15);
            this.lblFather.TabIndex = 0;
            this.lblFather.Text = "Father\'s Name:";
            // 
            // tabContact
            // 
            this.tabContact.Controls.Add(this.lblEmailTxt);
            this.tabContact.Controls.Add(this.lblGuardianTxt);
            this.tabContact.Controls.Add(this.stdAddressBox);
            this.tabContact.Controls.Add(this.lblAddress);
            this.tabContact.Controls.Add(this.lblEmail);
            this.tabContact.Controls.Add(this.lblGuardian);
            this.tabContact.Location = new System.Drawing.Point(4, 22);
            this.tabContact.Name = "tabContact";
            this.tabContact.Size = new System.Drawing.Size(500, 314);
            this.tabContact.TabIndex = 2;
            this.tabContact.Text = "Contact";
            this.tabContact.UseVisualStyleBackColor = true;
            // 
            // lblEmailTxt
            // 
            this.lblEmailTxt.AutoSize = true;
            this.lblEmailTxt.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmailTxt.Location = new System.Drawing.Point(200, 98);
            this.lblEmailTxt.Name = "lblEmailTxt";
            this.lblEmailTxt.Size = new System.Drawing.Size(12, 18);
            this.lblEmailTxt.TabIndex = 2;
            this.lblEmailTxt.Text = "-";
            // 
            // lblGuardianTxt
            // 
            this.lblGuardianTxt.AutoSize = true;
            this.lblGuardianTxt.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGuardianTxt.Location = new System.Drawing.Point(200, 48);
            this.lblGuardianTxt.Name = "lblGuardianTxt";
            this.lblGuardianTxt.Size = new System.Drawing.Size(12, 18);
            this.lblGuardianTxt.TabIndex = 2;
            this.lblGuardianTxt.Text = "-";
            // 
            // stdAddressBox
            // 
            this.stdAddressBox.Controls.Add(this.lblZipTxt);
            this.stdAddressBox.Controls.Add(this.lblDistrictTxt);
            this.stdAddressBox.Controls.Add(this.lblCityTxt);
            this.stdAddressBox.Controls.Add(this.lblStreetTxt);
            this.stdAddressBox.Controls.Add(this.lblZip);
            this.stdAddressBox.Controls.Add(this.lblDistrict);
            this.stdAddressBox.Controls.Add(this.lblCity);
            this.stdAddressBox.Controls.Add(this.lblStreet);
            this.stdAddressBox.Location = new System.Drawing.Point(203, 146);
            this.stdAddressBox.Name = "stdAddressBox";
            this.stdAddressBox.Size = new System.Drawing.Size(263, 151);
            this.stdAddressBox.TabIndex = 1;
            this.stdAddressBox.TabStop = false;
            // 
            // lblZipTxt
            // 
            this.lblZipTxt.AutoSize = true;
            this.lblZipTxt.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblZipTxt.Location = new System.Drawing.Point(101, 118);
            this.lblZipTxt.Name = "lblZipTxt";
            this.lblZipTxt.Size = new System.Drawing.Size(12, 18);
            this.lblZipTxt.TabIndex = 1;
            this.lblZipTxt.Text = "-";
            // 
            // lblDistrictTxt
            // 
            this.lblDistrictTxt.AutoSize = true;
            this.lblDistrictTxt.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDistrictTxt.Location = new System.Drawing.Point(101, 88);
            this.lblDistrictTxt.Name = "lblDistrictTxt";
            this.lblDistrictTxt.Size = new System.Drawing.Size(12, 18);
            this.lblDistrictTxt.TabIndex = 1;
            this.lblDistrictTxt.Text = "-";
            // 
            // lblCityTxt
            // 
            this.lblCityTxt.AutoSize = true;
            this.lblCityTxt.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCityTxt.Location = new System.Drawing.Point(101, 53);
            this.lblCityTxt.Name = "lblCityTxt";
            this.lblCityTxt.Size = new System.Drawing.Size(12, 18);
            this.lblCityTxt.TabIndex = 1;
            this.lblCityTxt.Text = "-";
            // 
            // lblStreetTxt
            // 
            this.lblStreetTxt.AutoSize = true;
            this.lblStreetTxt.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStreetTxt.Location = new System.Drawing.Point(101, 23);
            this.lblStreetTxt.Name = "lblStreetTxt";
            this.lblStreetTxt.Size = new System.Drawing.Size(12, 18);
            this.lblStreetTxt.TabIndex = 1;
            this.lblStreetTxt.Text = "-";
            // 
            // lblZip
            // 
            this.lblZip.AutoSize = true;
            this.lblZip.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblZip.Location = new System.Drawing.Point(41, 121);
            this.lblZip.Name = "lblZip";
            this.lblZip.Size = new System.Drawing.Size(28, 15);
            this.lblZip.TabIndex = 0;
            this.lblZip.Text = "Zip:";
            // 
            // lblDistrict
            // 
            this.lblDistrict.AutoSize = true;
            this.lblDistrict.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDistrict.Location = new System.Drawing.Point(41, 91);
            this.lblDistrict.Name = "lblDistrict";
            this.lblDistrict.Size = new System.Drawing.Size(49, 15);
            this.lblDistrict.TabIndex = 0;
            this.lblDistrict.Text = "District:";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCity.Location = new System.Drawing.Point(41, 56);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(32, 15);
            this.lblCity.TabIndex = 0;
            this.lblCity.Text = "City:";
            // 
            // lblStreet
            // 
            this.lblStreet.AutoSize = true;
            this.lblStreet.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStreet.Location = new System.Drawing.Point(41, 26);
            this.lblStreet.Name = "lblStreet";
            this.lblStreet.Size = new System.Drawing.Size(41, 15);
            this.lblStreet.TabIndex = 0;
            this.lblStreet.Text = "Street:";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.Location = new System.Drawing.Point(84, 163);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(56, 15);
            this.lblAddress.TabIndex = 0;
            this.lblAddress.Text = "Address:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(84, 101);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(42, 15);
            this.lblEmail.TabIndex = 0;
            this.lblEmail.Text = "E-mail:";
            // 
            // lblGuardian
            // 
            this.lblGuardian.AutoSize = true;
            this.lblGuardian.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGuardian.Location = new System.Drawing.Point(84, 51);
            this.lblGuardian.Name = "lblGuardian";
            this.lblGuardian.Size = new System.Drawing.Size(103, 15);
            this.lblGuardian.TabIndex = 0;
            this.lblGuardian.Text = "Guardian Contact:";
            // 
            // tabResult
            // 
            this.tabResult.Controls.Add(this.lblTerm);
            this.tabResult.Controls.Add(this.stdTermInfoGrid);
            this.tabResult.Controls.Add(this.selectStdTerm);
            this.tabResult.Location = new System.Drawing.Point(4, 22);
            this.tabResult.Name = "tabResult";
            this.tabResult.Size = new System.Drawing.Size(500, 314);
            this.tabResult.TabIndex = 3;
            this.tabResult.Text = "Result";
            this.tabResult.UseVisualStyleBackColor = true;
            // 
            // lblTerm
            // 
            this.lblTerm.AutoSize = true;
            this.lblTerm.Font = new System.Drawing.Font("Constantia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTerm.Location = new System.Drawing.Point(144, 24);
            this.lblTerm.Name = "lblTerm";
            this.lblTerm.Size = new System.Drawing.Size(38, 14);
            this.lblTerm.TabIndex = 2;
            this.lblTerm.Text = "Term:";
            // 
            // stdTermInfoGrid
            // 
            this.stdTermInfoGrid.AllowUserToAddRows = false;
            this.stdTermInfoGrid.AllowUserToDeleteRows = false;
            this.stdTermInfoGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.stdTermInfoGrid.Location = new System.Drawing.Point(8, 66);
            this.stdTermInfoGrid.Name = "stdTermInfoGrid";
            this.stdTermInfoGrid.ReadOnly = true;
            this.stdTermInfoGrid.Size = new System.Drawing.Size(484, 240);
            this.stdTermInfoGrid.TabIndex = 1;
            // 
            // selectStdTerm
            // 
            this.selectStdTerm.FormattingEnabled = true;
            this.selectStdTerm.Location = new System.Drawing.Point(184, 21);
            this.selectStdTerm.Name = "selectStdTerm";
            this.selectStdTerm.Size = new System.Drawing.Size(151, 21);
            this.selectStdTerm.TabIndex = 0;
            // 
            // stdOptionBox
            // 
            this.stdOptionBox.Controls.Add(this.btnStdDelete);
            this.stdOptionBox.Controls.Add(this.btnStdEdit);
            this.stdOptionBox.Controls.Add(this.btnStdCreate);
            this.stdOptionBox.Location = new System.Drawing.Point(309, 361);
            this.stdOptionBox.Name = "stdOptionBox";
            this.stdOptionBox.Size = new System.Drawing.Size(423, 140);
            this.stdOptionBox.TabIndex = 1;
            this.stdOptionBox.TabStop = false;
            // 
            // stdList
            // 
            this.stdList.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stdList.FormattingEnabled = true;
            this.stdList.ItemHeight = 17;
            this.stdList.Location = new System.Drawing.Point(7, 51);
            this.stdList.Name = "stdList";
            this.stdList.Size = new System.Drawing.Size(249, 446);
            this.stdList.TabIndex = 0;
            this.stdList.SelectedIndexChanged += new System.EventHandler(this.stdList_SelectedIndexChanged);
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
            // lblAdminHome
            // 
            this.lblAdminHome.AutoSize = true;
            this.lblAdminHome.Font = new System.Drawing.Font("Algerian", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdminHome.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblAdminHome.Location = new System.Drawing.Point(329, 637);
            this.lblAdminHome.Name = "lblAdminHome";
            this.lblAdminHome.Size = new System.Drawing.Size(156, 18);
            this.lblAdminHome.TabIndex = 12;
            this.lblAdminHome.Text = "ADMIN : USER AREA";
            // 
            // btnStdDelete
            // 
            this.btnStdDelete.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStdDelete.Image = global::SMS.Properties.Resources.stdDelete;
            this.btnStdDelete.Location = new System.Drawing.Point(289, 19);
            this.btnStdDelete.Name = "btnStdDelete";
            this.btnStdDelete.Size = new System.Drawing.Size(112, 109);
            this.btnStdDelete.TabIndex = 0;
            this.btnStdDelete.Text = "Delete Student";
            this.btnStdDelete.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnStdDelete.UseVisualStyleBackColor = true;
            this.btnStdDelete.Click += new System.EventHandler(this.btnStdDelete_Click);
            // 
            // btnStdEdit
            // 
            this.btnStdEdit.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStdEdit.Image = global::SMS.Properties.Resources.stdEdit;
            this.btnStdEdit.Location = new System.Drawing.Point(157, 19);
            this.btnStdEdit.Name = "btnStdEdit";
            this.btnStdEdit.Size = new System.Drawing.Size(112, 109);
            this.btnStdEdit.TabIndex = 0;
            this.btnStdEdit.Text = "Edit Student";
            this.btnStdEdit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnStdEdit.UseVisualStyleBackColor = true;
            this.btnStdEdit.Click += new System.EventHandler(this.btnStdEdit_Click);
            // 
            // btnStdCreate
            // 
            this.btnStdCreate.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStdCreate.Image = global::SMS.Properties.Resources.stdAdd;
            this.btnStdCreate.Location = new System.Drawing.Point(23, 19);
            this.btnStdCreate.Name = "btnStdCreate";
            this.btnStdCreate.Size = new System.Drawing.Size(112, 109);
            this.btnStdCreate.TabIndex = 0;
            this.btnStdCreate.Text = "Create Student";
            this.btnStdCreate.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnStdCreate.UseVisualStyleBackColor = true;
            this.btnStdCreate.Click += new System.EventHandler(this.btnStdCreate_Click);
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
            // lblStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImage = global::SMS.Properties.Resources.back_start;
            this.Controls.Add(this.stdGrpBox);
            this.Controls.Add(this.topBarBox);
            this.Controls.Add(this.lblAdminHome);
            this.Name = "lblStatus";
            this.Size = new System.Drawing.Size(823, 671);
            this.stdGrpBox.ResumeLayout(false);
            this.studentInfoTab.ResumeLayout(false);
            this.tabGeneral.ResumeLayout(false);
            this.tabGeneral.PerformLayout();
            this.tabBio.ResumeLayout(false);
            this.tabBio.PerformLayout();
            this.tabContact.ResumeLayout(false);
            this.tabContact.PerformLayout();
            this.stdAddressBox.ResumeLayout(false);
            this.stdAddressBox.PerformLayout();
            this.tabResult.ResumeLayout(false);
            this.tabResult.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stdTermInfoGrid)).EndInit();
            this.stdOptionBox.ResumeLayout(false);
            this.topBarBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox stdGrpBox;
        private System.Windows.Forms.GroupBox stdOptionBox;
        private System.Windows.Forms.Button btnStdDelete;
        private System.Windows.Forms.Button btnStdEdit;
        private System.Windows.Forms.Button btnStdCreate;
        private System.Windows.Forms.ListBox stdList;
        private System.Windows.Forms.GroupBox topBarBox;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Button btnForward;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Label lblAdminHome;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.TabControl studentInfoTab;
        private System.Windows.Forms.TabPage tabGeneral;
        private System.Windows.Forms.TabPage tabBio;
        private System.Windows.Forms.TabPage tabContact;
        private System.Windows.Forms.TabPage tabResult;
        private System.Windows.Forms.ComboBox SelectShiftCombo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblSection;
        private System.Windows.Forms.Label lblShift;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblStatusTxt;
        private System.Windows.Forms.Label lblSectionTxt;
        private System.Windows.Forms.Label lblShiftTxt;
        private System.Windows.Forms.Label lblNameTxt;
        private System.Windows.Forms.Label lblRollTxt;
        private System.Windows.Forms.Label lblRoll;
        private System.Windows.Forms.Label lblAchievement;
        private System.Windows.Forms.Label lblBlood;
        private System.Windows.Forms.Label lblMother;
        private System.Windows.Forms.Label lblFather;
        private System.Windows.Forms.Label lblAchievementTxt;
        private System.Windows.Forms.Label lblBloodTxt;
        private System.Windows.Forms.Label lblMotherTxt;
        private System.Windows.Forms.Label lblFatherTxt;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblGuardian;
        private System.Windows.Forms.Label lblEmailTxt;
        private System.Windows.Forms.Label lblGuardianTxt;
        private System.Windows.Forms.GroupBox stdAddressBox;
        private System.Windows.Forms.Label lblZipTxt;
        private System.Windows.Forms.Label lblDistrictTxt;
        private System.Windows.Forms.Label lblCityTxt;
        private System.Windows.Forms.Label lblStreetTxt;
        private System.Windows.Forms.Label lblZip;
        private System.Windows.Forms.Label lblDistrict;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblStreet;
        private System.Windows.Forms.DataGridView stdTermInfoGrid;
        private System.Windows.Forms.ComboBox selectStdTerm;
        private System.Windows.Forms.Label lblTerm;
        private System.Windows.Forms.ComboBox SelectClassCombo;
    }
}
