namespace SMS
{
    partial class AddResult
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddResult));
            this.lblAdminHome = new System.Windows.Forms.Label();
            this.topBarBox = new System.Windows.Forms.GroupBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.btnForward = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.ResultBox = new System.Windows.Forms.GroupBox();
            this.AddResultContainer = new System.Windows.Forms.GroupBox();
            this.ResultEntryPanel = new System.Windows.Forms.Panel();
            this.ResultInputEntry = new System.Windows.Forms.Panel();
            this.StdSelectYearCombox = new System.Windows.Forms.ComboBox();
            this.totalTxt = new System.Windows.Forms.TextBox();
            this.presenceTxt = new System.Windows.Forms.TextBox();
            this.CTtxt = new System.Windows.Forms.TextBox();
            this.writtenTxt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblYearSelect = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCancelResult = new System.Windows.Forms.Button();
            this.btnSaveResult = new System.Windows.Forms.Button();
            this.WarningPanel = new System.Windows.Forms.Panel();
            this.lblWarning = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTerm = new System.Windows.Forms.Label();
            this.lblClass = new System.Windows.Forms.Label();
            this.lblShift = new System.Windows.Forms.Label();
            this.SubjectSelectCombo = new System.Windows.Forms.ComboBox();
            this.StudentSelectCombo = new System.Windows.Forms.ComboBox();
            this.termSelectCombo = new System.Windows.Forms.ComboBox();
            this.ClassSelectCombo = new System.Windows.Forms.ComboBox();
            this.ShiftSelectCombo = new System.Windows.Forms.ComboBox();
            this.sideArrow = new System.Windows.Forms.PictureBox();
            this.topBarBox.SuspendLayout();
            this.ResultBox.SuspendLayout();
            this.AddResultContainer.SuspendLayout();
            this.ResultEntryPanel.SuspendLayout();
            this.ResultInputEntry.SuspendLayout();
            this.WarningPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sideArrow)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAdminHome
            // 
            this.lblAdminHome.AutoSize = true;
            this.lblAdminHome.Font = new System.Drawing.Font("Algerian", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdminHome.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblAdminHome.Location = new System.Drawing.Point(350, 638);
            this.lblAdminHome.Name = "lblAdminHome";
            this.lblAdminHome.Size = new System.Drawing.Size(105, 18);
            this.lblAdminHome.TabIndex = 21;
            this.lblAdminHome.Text = "ADMIN AREA";
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
            // ResultBox
            // 
            this.ResultBox.Controls.Add(this.AddResultContainer);
            this.ResultBox.Location = new System.Drawing.Point(18, 105);
            this.ResultBox.Name = "ResultBox";
            this.ResultBox.Size = new System.Drawing.Size(787, 521);
            this.ResultBox.TabIndex = 20;
            this.ResultBox.TabStop = false;
            // 
            // AddResultContainer
            // 
            this.AddResultContainer.Controls.Add(this.ResultEntryPanel);
            this.AddResultContainer.Controls.Add(this.label2);
            this.AddResultContainer.Controls.Add(this.label1);
            this.AddResultContainer.Controls.Add(this.lblTerm);
            this.AddResultContainer.Controls.Add(this.lblClass);
            this.AddResultContainer.Controls.Add(this.lblShift);
            this.AddResultContainer.Controls.Add(this.SubjectSelectCombo);
            this.AddResultContainer.Controls.Add(this.StudentSelectCombo);
            this.AddResultContainer.Controls.Add(this.termSelectCombo);
            this.AddResultContainer.Controls.Add(this.ClassSelectCombo);
            this.AddResultContainer.Controls.Add(this.ShiftSelectCombo);
            this.AddResultContainer.Controls.Add(this.sideArrow);
            this.AddResultContainer.Location = new System.Drawing.Point(19, 51);
            this.AddResultContainer.Name = "AddResultContainer";
            this.AddResultContainer.Size = new System.Drawing.Size(750, 450);
            this.AddResultContainer.TabIndex = 3;
            this.AddResultContainer.TabStop = false;
            // 
            // ResultEntryPanel
            // 
            this.ResultEntryPanel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ResultEntryPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ResultEntryPanel.Controls.Add(this.ResultInputEntry);
            this.ResultEntryPanel.Controls.Add(this.WarningPanel);
            this.ResultEntryPanel.Location = new System.Drawing.Point(394, 24);
            this.ResultEntryPanel.Name = "ResultEntryPanel";
            this.ResultEntryPanel.Size = new System.Drawing.Size(334, 402);
            this.ResultEntryPanel.TabIndex = 9;
            // 
            // ResultInputEntry
            // 
            this.ResultInputEntry.Controls.Add(this.StdSelectYearCombox);
            this.ResultInputEntry.Controls.Add(this.totalTxt);
            this.ResultInputEntry.Controls.Add(this.presenceTxt);
            this.ResultInputEntry.Controls.Add(this.CTtxt);
            this.ResultInputEntry.Controls.Add(this.writtenTxt);
            this.ResultInputEntry.Controls.Add(this.label7);
            this.ResultInputEntry.Controls.Add(this.label6);
            this.ResultInputEntry.Controls.Add(this.label5);
            this.ResultInputEntry.Controls.Add(this.lblYearSelect);
            this.ResultInputEntry.Controls.Add(this.label4);
            this.ResultInputEntry.Controls.Add(this.btnCancelResult);
            this.ResultInputEntry.Controls.Add(this.btnSaveResult);
            this.ResultInputEntry.Location = new System.Drawing.Point(3, 3);
            this.ResultInputEntry.Name = "ResultInputEntry";
            this.ResultInputEntry.Size = new System.Drawing.Size(326, 394);
            this.ResultInputEntry.TabIndex = 0;
            // 
            // StdSelectYearCombox
            // 
            this.StdSelectYearCombox.FormattingEnabled = true;
            this.StdSelectYearCombox.Location = new System.Drawing.Point(126, 41);
            this.StdSelectYearCombox.Name = "StdSelectYearCombox";
            this.StdSelectYearCombox.Size = new System.Drawing.Size(156, 21);
            this.StdSelectYearCombox.TabIndex = 22;
            // 
            // totalTxt
            // 
            this.totalTxt.Location = new System.Drawing.Point(126, 251);
            this.totalTxt.Name = "totalTxt";
            this.totalTxt.Size = new System.Drawing.Size(156, 20);
            this.totalTxt.TabIndex = 17;
            // 
            // presenceTxt
            // 
            this.presenceTxt.Location = new System.Drawing.Point(126, 192);
            this.presenceTxt.Name = "presenceTxt";
            this.presenceTxt.Size = new System.Drawing.Size(156, 20);
            this.presenceTxt.TabIndex = 18;
            // 
            // CTtxt
            // 
            this.CTtxt.Location = new System.Drawing.Point(126, 139);
            this.CTtxt.Name = "CTtxt";
            this.CTtxt.Size = new System.Drawing.Size(156, 20);
            this.CTtxt.TabIndex = 19;
            // 
            // writtenTxt
            // 
            this.writtenTxt.Location = new System.Drawing.Point(126, 86);
            this.writtenTxt.Name = "writtenTxt";
            this.writtenTxt.Size = new System.Drawing.Size(156, 20);
            this.writtenTxt.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(45, 256);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 15);
            this.label7.TabIndex = 12;
            this.label7.Text = "Total:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(45, 197);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 15);
            this.label6.TabIndex = 13;
            this.label6.Text = "Presence:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(45, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 15);
            this.label5.TabIndex = 14;
            this.label5.Text = "CT:";
            // 
            // lblYearSelect
            // 
            this.lblYearSelect.AutoSize = true;
            this.lblYearSelect.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYearSelect.Location = new System.Drawing.Point(44, 47);
            this.lblYearSelect.Name = "lblYearSelect";
            this.lblYearSelect.Size = new System.Drawing.Size(33, 15);
            this.lblYearSelect.TabIndex = 15;
            this.lblYearSelect.Text = "Year:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(44, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 15);
            this.label4.TabIndex = 15;
            this.label4.Text = "Written:";
            // 
            // btnCancelResult
            // 
            this.btnCancelResult.FlatAppearance.BorderSize = 2;
            this.btnCancelResult.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelResult.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelResult.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCancelResult.Location = new System.Drawing.Point(176, 328);
            this.btnCancelResult.Name = "btnCancelResult";
            this.btnCancelResult.Size = new System.Drawing.Size(71, 36);
            this.btnCancelResult.TabIndex = 10;
            this.btnCancelResult.Text = "Cancel";
            this.btnCancelResult.UseVisualStyleBackColor = true;
            this.btnCancelResult.Click += new System.EventHandler(this.btnCancelResult_Click);
            // 
            // btnSaveResult
            // 
            this.btnSaveResult.FlatAppearance.BorderSize = 2;
            this.btnSaveResult.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveResult.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveResult.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnSaveResult.Location = new System.Drawing.Point(79, 328);
            this.btnSaveResult.Name = "btnSaveResult";
            this.btnSaveResult.Size = new System.Drawing.Size(71, 36);
            this.btnSaveResult.TabIndex = 11;
            this.btnSaveResult.Text = "Save";
            this.btnSaveResult.UseVisualStyleBackColor = true;
            this.btnSaveResult.Click += new System.EventHandler(this.btnSaveResult_Click);
            // 
            // WarningPanel
            // 
            this.WarningPanel.Controls.Add(this.lblWarning);
            this.WarningPanel.Location = new System.Drawing.Point(3, 132);
            this.WarningPanel.Name = "WarningPanel";
            this.WarningPanel.Size = new System.Drawing.Size(326, 100);
            this.WarningPanel.TabIndex = 0;
            // 
            // lblWarning
            // 
            this.lblWarning.AutoSize = true;
            this.lblWarning.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWarning.ForeColor = System.Drawing.Color.Red;
            this.lblWarning.Location = new System.Drawing.Point(27, 39);
            this.lblWarning.Name = "lblWarning";
            this.lblWarning.Size = new System.Drawing.Size(272, 22);
            this.lblWarning.TabIndex = 11;
            this.lblWarning.Text = "An entry for this subject already exists";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Constantia", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(152, 331);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Select Subject:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Constantia", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(152, 255);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Select Student:";
            // 
            // lblTerm
            // 
            this.lblTerm.AutoSize = true;
            this.lblTerm.Font = new System.Drawing.Font("Constantia", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTerm.Location = new System.Drawing.Point(153, 172);
            this.lblTerm.Name = "lblTerm";
            this.lblTerm.Size = new System.Drawing.Size(82, 15);
            this.lblTerm.TabIndex = 6;
            this.lblTerm.Text = "Select Term:";
            // 
            // lblClass
            // 
            this.lblClass.AutoSize = true;
            this.lblClass.Font = new System.Drawing.Font("Constantia", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClass.Location = new System.Drawing.Point(153, 96);
            this.lblClass.Name = "lblClass";
            this.lblClass.Size = new System.Drawing.Size(82, 15);
            this.lblClass.TabIndex = 7;
            this.lblClass.Text = "Select Class:";
            // 
            // lblShift
            // 
            this.lblShift.AutoSize = true;
            this.lblShift.Font = new System.Drawing.Font("Constantia", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShift.Location = new System.Drawing.Point(153, 24);
            this.lblShift.Name = "lblShift";
            this.lblShift.Size = new System.Drawing.Size(79, 15);
            this.lblShift.TabIndex = 8;
            this.lblShift.Text = "Select Shift:";
            // 
            // SubjectSelectCombo
            // 
            this.SubjectSelectCombo.FormattingEnabled = true;
            this.SubjectSelectCombo.Location = new System.Drawing.Point(111, 360);
            this.SubjectSelectCombo.Name = "SubjectSelectCombo";
            this.SubjectSelectCombo.Size = new System.Drawing.Size(166, 21);
            this.SubjectSelectCombo.TabIndex = 3;
            this.SubjectSelectCombo.SelectedIndexChanged += new System.EventHandler(this.SubjectSelectCombo_SelectedIndexChanged);
            // 
            // StudentSelectCombo
            // 
            this.StudentSelectCombo.FormattingEnabled = true;
            this.StudentSelectCombo.Location = new System.Drawing.Point(111, 287);
            this.StudentSelectCombo.Name = "StudentSelectCombo";
            this.StudentSelectCombo.Size = new System.Drawing.Size(166, 21);
            this.StudentSelectCombo.TabIndex = 3;
            this.StudentSelectCombo.SelectedIndexChanged += new System.EventHandler(this.StudentSelectCombo_SelectedIndexChanged);
            // 
            // termSelectCombo
            // 
            this.termSelectCombo.FormattingEnabled = true;
            this.termSelectCombo.Location = new System.Drawing.Point(111, 210);
            this.termSelectCombo.Name = "termSelectCombo";
            this.termSelectCombo.Size = new System.Drawing.Size(166, 21);
            this.termSelectCombo.TabIndex = 3;
            this.termSelectCombo.SelectedIndexChanged += new System.EventHandler(this.termSelectCombo_SelectedIndexChanged);
            // 
            // ClassSelectCombo
            // 
            this.ClassSelectCombo.FormattingEnabled = true;
            this.ClassSelectCombo.Location = new System.Drawing.Point(111, 128);
            this.ClassSelectCombo.Name = "ClassSelectCombo";
            this.ClassSelectCombo.Size = new System.Drawing.Size(166, 21);
            this.ClassSelectCombo.TabIndex = 4;
            this.ClassSelectCombo.SelectedIndexChanged += new System.EventHandler(this.ClassSelectCombo_SelectedIndexChanged);
            // 
            // ShiftSelectCombo
            // 
            this.ShiftSelectCombo.FormattingEnabled = true;
            this.ShiftSelectCombo.Location = new System.Drawing.Point(111, 53);
            this.ShiftSelectCombo.Name = "ShiftSelectCombo";
            this.ShiftSelectCombo.Size = new System.Drawing.Size(166, 21);
            this.ShiftSelectCombo.TabIndex = 5;
            this.ShiftSelectCombo.SelectedIndexChanged += new System.EventHandler(this.ShiftSelectCombo_SelectedIndexChanged);
            // 
            // sideArrow
            // 
            this.sideArrow.Image = ((System.Drawing.Image)(resources.GetObject("sideArrow.Image")));
            this.sideArrow.Location = new System.Drawing.Point(283, 331);
            this.sideArrow.Name = "sideArrow";
            this.sideArrow.Size = new System.Drawing.Size(144, 61);
            this.sideArrow.TabIndex = 10;
            this.sideArrow.TabStop = false;
            // 
            // AddResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImage = global::SMS.Properties.Resources.back_add;
            this.Controls.Add(this.ResultBox);
            this.Controls.Add(this.lblAdminHome);
            this.Controls.Add(this.topBarBox);
            this.Name = "AddResult";
            this.Size = new System.Drawing.Size(823, 671);
            this.topBarBox.ResumeLayout(false);
            this.ResultBox.ResumeLayout(false);
            this.AddResultContainer.ResumeLayout(false);
            this.AddResultContainer.PerformLayout();
            this.ResultEntryPanel.ResumeLayout(false);
            this.ResultInputEntry.ResumeLayout(false);
            this.ResultInputEntry.PerformLayout();
            this.WarningPanel.ResumeLayout(false);
            this.WarningPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sideArrow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAdminHome;
        private System.Windows.Forms.Button btnForward;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.GroupBox topBarBox;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.GroupBox ResultBox;
        private System.Windows.Forms.GroupBox AddResultContainer;
        private System.Windows.Forms.Label lblTerm;
        private System.Windows.Forms.Label lblClass;
        private System.Windows.Forms.Label lblShift;
        private System.Windows.Forms.ComboBox termSelectCombo;
        private System.Windows.Forms.ComboBox ClassSelectCombo;
        private System.Windows.Forms.ComboBox ShiftSelectCombo;
        private System.Windows.Forms.Panel ResultEntryPanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox SubjectSelectCombo;
        private System.Windows.Forms.ComboBox StudentSelectCombo;
        private System.Windows.Forms.PictureBox sideArrow;
        private System.Windows.Forms.Panel ResultInputEntry;
        private System.Windows.Forms.TextBox totalTxt;
        private System.Windows.Forms.TextBox presenceTxt;
        private System.Windows.Forms.TextBox CTtxt;
        private System.Windows.Forms.TextBox writtenTxt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCancelResult;
        private System.Windows.Forms.Button btnSaveResult;
        private System.Windows.Forms.Panel WarningPanel;
        private System.Windows.Forms.Label lblWarning;
        private System.Windows.Forms.Label lblYearSelect;
        private System.Windows.Forms.ComboBox StdSelectYearCombox;
    }
}
