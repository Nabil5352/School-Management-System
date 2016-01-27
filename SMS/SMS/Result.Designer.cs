namespace SMS
{
    partial class Result
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
            this.topBarBox = new System.Windows.Forms.GroupBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.btnForward = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.ResultBox = new System.Windows.Forms.GroupBox();
            this.btnEditResultInfo = new System.Windows.Forms.Button();
            this.btnAddNewResult = new System.Windows.Forms.Button();
            this.resultView = new System.Windows.Forms.Panel();
            this.resultContainer = new System.Windows.Forms.SplitContainer();
            this.lblTerm = new System.Windows.Forms.Label();
            this.lblClass = new System.Windows.Forms.Label();
            this.lblShift = new System.Windows.Forms.Label();
            this.termSelectCombo = new System.Windows.Forms.ComboBox();
            this.ClassSelectCombo = new System.Windows.Forms.ComboBox();
            this.ShiftSelectCombo = new System.Windows.Forms.ComboBox();
            this.lblAdminHome = new System.Windows.Forms.Label();
            this.topBarBox.SuspendLayout();
            this.ResultBox.SuspendLayout();
            this.resultView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resultContainer)).BeginInit();
            this.resultContainer.SuspendLayout();
            this.SuspendLayout();
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
            // ResultBox
            // 
            this.ResultBox.Controls.Add(this.btnEditResultInfo);
            this.ResultBox.Controls.Add(this.btnAddNewResult);
            this.ResultBox.Controls.Add(this.resultView);
            this.ResultBox.Controls.Add(this.lblTerm);
            this.ResultBox.Controls.Add(this.lblClass);
            this.ResultBox.Controls.Add(this.lblShift);
            this.ResultBox.Controls.Add(this.termSelectCombo);
            this.ResultBox.Controls.Add(this.ClassSelectCombo);
            this.ResultBox.Controls.Add(this.ShiftSelectCombo);
            this.ResultBox.Location = new System.Drawing.Point(18, 105);
            this.ResultBox.Name = "ResultBox";
            this.ResultBox.Size = new System.Drawing.Size(787, 521);
            this.ResultBox.TabIndex = 17;
            this.ResultBox.TabStop = false;
            // 
            // btnEditResultInfo
            // 
            this.btnEditResultInfo.BackgroundImage = global::SMS.Properties.Resources.result_edit;
            this.btnEditResultInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnEditResultInfo.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditResultInfo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEditResultInfo.Location = new System.Drawing.Point(658, 23);
            this.btnEditResultInfo.Name = "btnEditResultInfo";
            this.btnEditResultInfo.Size = new System.Drawing.Size(105, 81);
            this.btnEditResultInfo.TabIndex = 5;
            this.btnEditResultInfo.Text = "Edit info";
            this.btnEditResultInfo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEditResultInfo.UseVisualStyleBackColor = true;
            // 
            // btnAddNewResult
            // 
            this.btnAddNewResult.BackgroundImage = global::SMS.Properties.Resources.result_add;
            this.btnAddNewResult.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAddNewResult.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewResult.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAddNewResult.Location = new System.Drawing.Point(538, 23);
            this.btnAddNewResult.Name = "btnAddNewResult";
            this.btnAddNewResult.Size = new System.Drawing.Size(105, 81);
            this.btnAddNewResult.TabIndex = 5;
            this.btnAddNewResult.Text = "Add New";
            this.btnAddNewResult.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAddNewResult.UseVisualStyleBackColor = true;
            this.btnAddNewResult.Click += new System.EventHandler(this.btnAddNewResult_Click);
            // 
            // resultView
            // 
            this.resultView.AutoScroll = true;
            this.resultView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.resultView.Controls.Add(this.resultContainer);
            this.resultView.Location = new System.Drawing.Point(6, 123);
            this.resultView.Name = "resultView";
            this.resultView.Size = new System.Drawing.Size(775, 392);
            this.resultView.TabIndex = 4;
            // 
            // resultContainer
            // 
            this.resultContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.resultContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.resultContainer.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultContainer.Location = new System.Drawing.Point(0, 0);
            this.resultContainer.Name = "resultContainer";
            // 
            // resultContainer.Panel1
            // 
            this.resultContainer.Panel1.AutoScroll = true;
            this.resultContainer.Panel1.BackColor = System.Drawing.Color.White;
            // 
            // resultContainer.Panel2
            // 
            this.resultContainer.Panel2.AutoScroll = true;
            this.resultContainer.Panel2.BackColor = System.Drawing.Color.White;
            this.resultContainer.Size = new System.Drawing.Size(773, 390);
            this.resultContainer.SplitterDistance = 198;
            this.resultContainer.SplitterWidth = 1;
            this.resultContainer.TabIndex = 0;
            // 
            // lblTerm
            // 
            this.lblTerm.AutoSize = true;
            this.lblTerm.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTerm.Location = new System.Drawing.Point(56, 89);
            this.lblTerm.Name = "lblTerm";
            this.lblTerm.Size = new System.Drawing.Size(76, 15);
            this.lblTerm.TabIndex = 2;
            this.lblTerm.Text = "Select Term:";
            // 
            // lblClass
            // 
            this.lblClass.AutoSize = true;
            this.lblClass.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClass.Location = new System.Drawing.Point(56, 57);
            this.lblClass.Name = "lblClass";
            this.lblClass.Size = new System.Drawing.Size(75, 15);
            this.lblClass.TabIndex = 2;
            this.lblClass.Text = "Select Class:";
            // 
            // lblShift
            // 
            this.lblShift.AutoSize = true;
            this.lblShift.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShift.Location = new System.Drawing.Point(56, 25);
            this.lblShift.Name = "lblShift";
            this.lblShift.Size = new System.Drawing.Size(75, 15);
            this.lblShift.TabIndex = 2;
            this.lblShift.Text = "Select Shift:";
            // 
            // termSelectCombo
            // 
            this.termSelectCombo.FormattingEnabled = true;
            this.termSelectCombo.Location = new System.Drawing.Point(144, 87);
            this.termSelectCombo.Name = "termSelectCombo";
            this.termSelectCombo.Size = new System.Drawing.Size(166, 21);
            this.termSelectCombo.TabIndex = 0;
            this.termSelectCombo.SelectedIndexChanged += new System.EventHandler(this.termSelectCombo_SelectedIndexChanged);
            // 
            // ClassSelectCombo
            // 
            this.ClassSelectCombo.FormattingEnabled = true;
            this.ClassSelectCombo.Location = new System.Drawing.Point(144, 55);
            this.ClassSelectCombo.Name = "ClassSelectCombo";
            this.ClassSelectCombo.Size = new System.Drawing.Size(166, 21);
            this.ClassSelectCombo.TabIndex = 0;
            this.ClassSelectCombo.SelectedIndexChanged += new System.EventHandler(this.ClassSelectCombo_SelectedIndexChanged);
            // 
            // ShiftSelectCombo
            // 
            this.ShiftSelectCombo.FormattingEnabled = true;
            this.ShiftSelectCombo.Location = new System.Drawing.Point(144, 23);
            this.ShiftSelectCombo.Name = "ShiftSelectCombo";
            this.ShiftSelectCombo.Size = new System.Drawing.Size(166, 21);
            this.ShiftSelectCombo.TabIndex = 0;
            this.ShiftSelectCombo.SelectedIndexChanged += new System.EventHandler(this.ShiftSelectCombo_SelectedIndexChanged);
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
            // Result
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImage = global::SMS.Properties.Resources.back_add;
            this.Controls.Add(this.topBarBox);
            this.Controls.Add(this.ResultBox);
            this.Controls.Add(this.lblAdminHome);
            this.Name = "Result";
            this.Size = new System.Drawing.Size(823, 671);
            this.topBarBox.ResumeLayout(false);
            this.ResultBox.ResumeLayout(false);
            this.ResultBox.PerformLayout();
            this.resultView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.resultContainer)).EndInit();
            this.resultContainer.ResumeLayout(false);
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
        private System.Windows.Forms.GroupBox ResultBox;
        private System.Windows.Forms.Label lblAdminHome;
        private System.Windows.Forms.ComboBox termSelectCombo;
        private System.Windows.Forms.ComboBox ClassSelectCombo;
        private System.Windows.Forms.ComboBox ShiftSelectCombo;
        private System.Windows.Forms.Label lblTerm;
        private System.Windows.Forms.Label lblClass;
        private System.Windows.Forms.Label lblShift;
        private System.Windows.Forms.Panel resultView;
        private System.Windows.Forms.SplitContainer resultContainer;
        private System.Windows.Forms.Button btnEditResultInfo;
        private System.Windows.Forms.Button btnAddNewResult;
    }
}
