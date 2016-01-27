namespace SMS
{
    partial class AdminSettings
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
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.topBarBox = new System.Windows.Forms.GroupBox();
            this.btnForward = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.teachGrpBox = new System.Windows.Forms.GroupBox();
            this.UserArrow = new System.Windows.Forms.PictureBox();
            this.AdminArrow = new System.Windows.Forms.PictureBox();
            this.personalPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.OldPassTxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.NewPassTxt = new System.Windows.Forms.TextBox();
            this.newUsernameTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.userPanel = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.selectUserCombo = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.btnCancelUser = new System.Windows.Forms.Button();
            this.btnSaveUser = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.userPass = new System.Windows.Forms.TextBox();
            this.userUsername = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnUsrDelete = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.EditUserInfoBox = new System.Windows.Forms.GroupBox();
            this.btnEditCancel = new System.Windows.Forms.Button();
            this.btnEditSave = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.EditPassword = new System.Windows.Forms.TextBox();
            this.EditUserTxt = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.selectUser = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnUser = new System.Windows.Forms.Button();
            this.btnPersonal = new System.Windows.Forms.Button();
            this.lblAdminHome = new System.Windows.Forms.Label();
            this.topBarBox.SuspendLayout();
            this.teachGrpBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UserArrow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AdminArrow)).BeginInit();
            this.personalPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.userPanel.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.EditUserInfoBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
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
            // teachGrpBox
            // 
            this.teachGrpBox.Controls.Add(this.UserArrow);
            this.teachGrpBox.Controls.Add(this.userPanel);
            this.teachGrpBox.Controls.Add(this.AdminArrow);
            this.teachGrpBox.Controls.Add(this.personalPanel);
            this.teachGrpBox.Controls.Add(this.btnUser);
            this.teachGrpBox.Controls.Add(this.btnPersonal);
            this.teachGrpBox.Location = new System.Drawing.Point(18, 105);
            this.teachGrpBox.Name = "teachGrpBox";
            this.teachGrpBox.Size = new System.Drawing.Size(787, 521);
            this.teachGrpBox.TabIndex = 17;
            this.teachGrpBox.TabStop = false;
            // 
            // UserArrow
            // 
            this.UserArrow.Image = global::SMS.Properties.Resources.down_arrow1;
            this.UserArrow.Location = new System.Drawing.Point(558, 62);
            this.UserArrow.Name = "UserArrow";
            this.UserArrow.Size = new System.Drawing.Size(32, 57);
            this.UserArrow.TabIndex = 3;
            this.UserArrow.TabStop = false;
            // 
            // AdminArrow
            // 
            this.AdminArrow.Image = global::SMS.Properties.Resources.down_arrow1;
            this.AdminArrow.Location = new System.Drawing.Point(182, 62);
            this.AdminArrow.Name = "AdminArrow";
            this.AdminArrow.Size = new System.Drawing.Size(32, 57);
            this.AdminArrow.TabIndex = 2;
            this.AdminArrow.TabStop = false;
            // 
            // personalPanel
            // 
            this.personalPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.personalPanel.Controls.Add(this.panel1);
            this.personalPanel.Controls.Add(this.button1);
            this.personalPanel.Controls.Add(this.label1);
            this.personalPanel.Controls.Add(this.pictureBox1);
            this.personalPanel.Location = new System.Drawing.Point(23, 119);
            this.personalPanel.Name = "personalPanel";
            this.personalPanel.Size = new System.Drawing.Size(740, 386);
            this.personalPanel.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.OldPassTxt);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.NewPassTxt);
            this.panel1.Controls.Add(this.newUsernameTxt);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(356, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(358, 325);
            this.panel1.TabIndex = 7;
            // 
            // btnCancel
            // 
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.SystemColors.GrayText;
            this.btnCancel.FlatAppearance.BorderSize = 2;
            this.btnCancel.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.HotTrack;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnCancel.Location = new System.Drawing.Point(185, 275);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(71, 35);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.SystemColors.GrayText;
            this.btnSave.FlatAppearance.BorderSize = 2;
            this.btnSave.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.HotTrack;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnSave.Location = new System.Drawing.Point(96, 275);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(71, 35);
            this.btnSave.TabIndex = 14;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(43, 201);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "Old Password:";
            // 
            // OldPassTxt
            // 
            this.OldPassTxt.Location = new System.Drawing.Point(137, 198);
            this.OldPassTxt.Name = "OldPassTxt";
            this.OldPassTxt.Size = new System.Drawing.Size(178, 20);
            this.OldPassTxt.TabIndex = 7;
            this.OldPassTxt.UseSystemPasswordChar = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(43, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 15);
            this.label6.TabIndex = 11;
            this.label6.Text = "New Username:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(43, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 15);
            this.label4.TabIndex = 12;
            this.label4.Text = "New Password:";
            // 
            // NewPassTxt
            // 
            this.NewPassTxt.Location = new System.Drawing.Point(137, 162);
            this.NewPassTxt.Name = "NewPassTxt";
            this.NewPassTxt.Size = new System.Drawing.Size(178, 20);
            this.NewPassTxt.TabIndex = 8;
            this.NewPassTxt.UseSystemPasswordChar = true;
            // 
            // newUsernameTxt
            // 
            this.newUsernameTxt.Location = new System.Drawing.Point(137, 46);
            this.newUsernameTxt.Name = "newUsernameTxt";
            this.newUsernameTxt.Size = new System.Drawing.Size(178, 20);
            this.newUsernameTxt.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(136, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Admin Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(132, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "Admin Username";
            // 
            // userPanel
            // 
            this.userPanel.Controls.Add(this.tabPage1);
            this.userPanel.Controls.Add(this.tabPage2);
            this.userPanel.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userPanel.Location = new System.Drawing.Point(23, 119);
            this.userPanel.Name = "userPanel";
            this.userPanel.SelectedIndex = 0;
            this.userPanel.Size = new System.Drawing.Size(736, 386);
            this.userPanel.TabIndex = 6;
            // 
            // tabPage1
            // 
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage1.Controls.Add(this.selectUserCombo);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label13);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.btnCancelUser);
            this.tabPage1.Controls.Add(this.btnSaveUser);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.userPass);
            this.tabPage1.Controls.Add(this.userUsername);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Controls.Add(this.pictureBox2);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(728, 358);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Create new";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // selectUserCombo
            // 
            this.selectUserCombo.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectUserCombo.FormattingEnabled = true;
            this.selectUserCombo.Location = new System.Drawing.Point(505, 72);
            this.selectUserCombo.Name = "selectUserCombo";
            this.selectUserCombo.Size = new System.Drawing.Size(178, 23);
            this.selectUserCombo.TabIndex = 33;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(430, 78);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 15);
            this.label7.TabIndex = 32;
            this.label7.Text = "Select:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(512, 43);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(73, 18);
            this.label13.TabIndex = 30;
            this.label13.Text = "Select User";
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(303, 205);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(26, 37);
            this.button2.TabIndex = 29;
            this.button2.Text = "+";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnCancelUser
            // 
            this.btnCancelUser.FlatAppearance.BorderColor = System.Drawing.SystemColors.GrayText;
            this.btnCancelUser.FlatAppearance.BorderSize = 2;
            this.btnCancelUser.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.HotTrack;
            this.btnCancelUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelUser.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelUser.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnCancelUser.Location = new System.Drawing.Point(553, 289);
            this.btnCancelUser.Name = "btnCancelUser";
            this.btnCancelUser.Size = new System.Drawing.Size(71, 35);
            this.btnCancelUser.TabIndex = 27;
            this.btnCancelUser.Text = "Cancel";
            this.btnCancelUser.UseVisualStyleBackColor = true;
            this.btnCancelUser.Click += new System.EventHandler(this.btnCancelUser_Click);
            // 
            // btnSaveUser
            // 
            this.btnSaveUser.FlatAppearance.BorderColor = System.Drawing.SystemColors.GrayText;
            this.btnSaveUser.FlatAppearance.BorderSize = 2;
            this.btnSaveUser.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.HotTrack;
            this.btnSaveUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveUser.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveUser.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnSaveUser.Location = new System.Drawing.Point(464, 289);
            this.btnSaveUser.Name = "btnSaveUser";
            this.btnSaveUser.Size = new System.Drawing.Size(71, 35);
            this.btnSaveUser.TabIndex = 28;
            this.btnSaveUser.Text = "Save";
            this.btnSaveUser.UseVisualStyleBackColor = true;
            this.btnSaveUser.Click += new System.EventHandler(this.btnSaveUser_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(418, 141);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 15);
            this.label8.TabIndex = 25;
            this.label8.Text = "Username:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(418, 214);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 15);
            this.label9.TabIndex = 26;
            this.label9.Text = "Password:";
            // 
            // userPass
            // 
            this.userPass.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userPass.Location = new System.Drawing.Point(505, 211);
            this.userPass.Name = "userPass";
            this.userPass.Size = new System.Drawing.Size(178, 22);
            this.userPass.TabIndex = 23;
            this.userPass.UseSystemPasswordChar = true;
            // 
            // userUsername
            // 
            this.userUsername.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userUsername.Location = new System.Drawing.Point(505, 138);
            this.userUsername.Name = "userUsername";
            this.userUsername.Size = new System.Drawing.Size(178, 22);
            this.userUsername.TabIndex = 24;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(507, 180);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(85, 18);
            this.label10.TabIndex = 20;
            this.label10.Text = "Set Password";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(503, 107);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(89, 18);
            this.label11.TabIndex = 21;
            this.label11.Text = "Set Username";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(128, 255);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(79, 18);
            this.label12.TabIndex = 22;
            this.label12.Text = "User Picture";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.Highlight;
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Location = new System.Drawing.Point(42, 26);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(287, 216);
            this.pictureBox2.TabIndex = 19;
            this.pictureBox2.TabStop = false;
            // 
            // tabPage2
            // 
            this.tabPage2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage2.Controls.Add(this.btnUsrDelete);
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Controls.Add(this.EditUserInfoBox);
            this.tabPage2.Controls.Add(this.selectUser);
            this.tabPage2.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(728, 358);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Edit User";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnUsrDelete
            // 
            this.btnUsrDelete.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnUsrDelete.FlatAppearance.BorderSize = 2;
            this.btnUsrDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsrDelete.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsrDelete.ForeColor = System.Drawing.Color.Red;
            this.btnUsrDelete.Location = new System.Drawing.Point(68, 237);
            this.btnUsrDelete.Name = "btnUsrDelete";
            this.btnUsrDelete.Size = new System.Drawing.Size(89, 33);
            this.btnUsrDelete.TabIndex = 32;
            this.btnUsrDelete.Text = "Delete User";
            this.btnUsrDelete.UseVisualStyleBackColor = true;
            this.btnUsrDelete.Click += new System.EventHandler(this.btnUsrDelete_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(79, 102);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(73, 18);
            this.label14.TabIndex = 31;
            this.label14.Text = "Select User";
            // 
            // EditUserInfoBox
            // 
            this.EditUserInfoBox.Controls.Add(this.btnEditCancel);
            this.EditUserInfoBox.Controls.Add(this.btnEditSave);
            this.EditUserInfoBox.Controls.Add(this.label15);
            this.EditUserInfoBox.Controls.Add(this.label16);
            this.EditUserInfoBox.Controls.Add(this.EditPassword);
            this.EditUserInfoBox.Controls.Add(this.EditUserTxt);
            this.EditUserInfoBox.Controls.Add(this.button3);
            this.EditUserInfoBox.Controls.Add(this.pictureBox3);
            this.EditUserInfoBox.Location = new System.Drawing.Point(249, 6);
            this.EditUserInfoBox.Name = "EditUserInfoBox";
            this.EditUserInfoBox.Size = new System.Drawing.Size(471, 344);
            this.EditUserInfoBox.TabIndex = 1;
            this.EditUserInfoBox.TabStop = false;
            // 
            // btnEditCancel
            // 
            this.btnEditCancel.FlatAppearance.BorderColor = System.Drawing.SystemColors.GrayText;
            this.btnEditCancel.FlatAppearance.BorderSize = 2;
            this.btnEditCancel.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.HotTrack;
            this.btnEditCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditCancel.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditCancel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnEditCancel.Location = new System.Drawing.Point(211, 287);
            this.btnEditCancel.Name = "btnEditCancel";
            this.btnEditCancel.Size = new System.Drawing.Size(71, 35);
            this.btnEditCancel.TabIndex = 37;
            this.btnEditCancel.Text = "Cancel";
            this.btnEditCancel.UseVisualStyleBackColor = true;
            this.btnEditCancel.Click += new System.EventHandler(this.btnEditCancel_Click);
            // 
            // btnEditSave
            // 
            this.btnEditSave.FlatAppearance.BorderColor = System.Drawing.SystemColors.GrayText;
            this.btnEditSave.FlatAppearance.BorderSize = 2;
            this.btnEditSave.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.HotTrack;
            this.btnEditSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditSave.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditSave.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnEditSave.Location = new System.Drawing.Point(122, 287);
            this.btnEditSave.Name = "btnEditSave";
            this.btnEditSave.Size = new System.Drawing.Size(71, 35);
            this.btnEditSave.TabIndex = 38;
            this.btnEditSave.Text = "Save";
            this.btnEditSave.UseVisualStyleBackColor = true;
            this.btnEditSave.Click += new System.EventHandler(this.btnEditSave_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(73, 174);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(83, 15);
            this.label15.TabIndex = 35;
            this.label15.Text = "Edit Username:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(73, 225);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(81, 15);
            this.label16.TabIndex = 36;
            this.label16.Text = "Edit Password:";
            // 
            // EditPassword
            // 
            this.EditPassword.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditPassword.Location = new System.Drawing.Point(178, 218);
            this.EditPassword.Name = "EditPassword";
            this.EditPassword.Size = new System.Drawing.Size(178, 22);
            this.EditPassword.TabIndex = 33;
            this.EditPassword.UseSystemPasswordChar = true;
            // 
            // EditUserTxt
            // 
            this.EditUserTxt.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditUserTxt.Location = new System.Drawing.Point(178, 171);
            this.EditUserTxt.Name = "EditUserTxt";
            this.EditUserTxt.Size = new System.Drawing.Size(178, 22);
            this.EditUserTxt.TabIndex = 34;
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(288, 96);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(25, 30);
            this.button3.TabIndex = 30;
            this.button3.Text = "+";
            this.button3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.SystemColors.Highlight;
            this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox3.Location = new System.Drawing.Point(146, 20);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(167, 106);
            this.pictureBox3.TabIndex = 20;
            this.pictureBox3.TabStop = false;
            // 
            // selectUser
            // 
            this.selectUser.FormattingEnabled = true;
            this.selectUser.Location = new System.Drawing.Point(23, 139);
            this.selectUser.Name = "selectUser";
            this.selectUser.Size = new System.Drawing.Size(197, 23);
            this.selectUser.TabIndex = 0;
            this.selectUser.SelectedIndexChanged += new System.EventHandler(this.selectUser_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(291, 229);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(26, 37);
            this.button1.TabIndex = 5;
            this.button1.Text = "+";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(116, 279);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Account Picture";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Highlight;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(30, 50);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(287, 216);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnUser
            // 
            this.btnUser.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUser.Location = new System.Drawing.Point(402, 19);
            this.btnUser.Name = "btnUser";
            this.btnUser.Size = new System.Drawing.Size(361, 43);
            this.btnUser.TabIndex = 0;
            this.btnUser.Text = "User Account Settings";
            this.btnUser.UseVisualStyleBackColor = true;
            this.btnUser.Click += new System.EventHandler(this.btnUser_Click);
            // 
            // btnPersonal
            // 
            this.btnPersonal.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPersonal.Location = new System.Drawing.Point(23, 19);
            this.btnPersonal.Name = "btnPersonal";
            this.btnPersonal.Size = new System.Drawing.Size(361, 43);
            this.btnPersonal.TabIndex = 0;
            this.btnPersonal.Text = "Personal Account Settings";
            this.btnPersonal.UseVisualStyleBackColor = true;
            this.btnPersonal.Click += new System.EventHandler(this.btnPersonal_Click);
            // 
            // lblAdminHome
            // 
            this.lblAdminHome.AutoSize = true;
            this.lblAdminHome.Font = new System.Drawing.Font("Algerian", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdminHome.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblAdminHome.Location = new System.Drawing.Point(350, 638);
            this.lblAdminHome.Name = "lblAdminHome";
            this.lblAdminHome.Size = new System.Drawing.Size(105, 18);
            this.lblAdminHome.TabIndex = 18;
            this.lblAdminHome.Text = "ADMIN AREA";
            // 
            // AdminSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImage = global::SMS.Properties.Resources.back_adminSetting;
            this.Controls.Add(this.topBarBox);
            this.Controls.Add(this.teachGrpBox);
            this.Controls.Add(this.lblAdminHome);
            this.Name = "AdminSettings";
            this.Size = new System.Drawing.Size(823, 671);
            this.topBarBox.ResumeLayout(false);
            this.teachGrpBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.UserArrow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AdminArrow)).EndInit();
            this.personalPanel.ResumeLayout(false);
            this.personalPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.userPanel.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.EditUserInfoBox.ResumeLayout(false);
            this.EditUserInfoBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.GroupBox topBarBox;
        private System.Windows.Forms.Button btnForward;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.GroupBox teachGrpBox;
        private System.Windows.Forms.Label lblAdminHome;
        private System.Windows.Forms.Button btnUser;
        private System.Windows.Forms.Button btnPersonal;
        private System.Windows.Forms.Panel personalPanel;
        private System.Windows.Forms.PictureBox AdminArrow;
        private System.Windows.Forms.PictureBox UserArrow;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabControl userPanel;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnCancelUser;
        private System.Windows.Forms.Button btnSaveUser;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox userPass;
        private System.Windows.Forms.TextBox userUsername;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox selectUserCombo;
        private System.Windows.Forms.GroupBox EditUserInfoBox;
        private System.Windows.Forms.ComboBox selectUser;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnEditCancel;
        private System.Windows.Forms.Button btnEditSave;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox EditPassword;
        private System.Windows.Forms.TextBox EditUserTxt;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button btnUsrDelete;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox OldPassTxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox NewPassTxt;
        private System.Windows.Forms.TextBox newUsernameTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}
