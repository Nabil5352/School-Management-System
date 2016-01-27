namespace SMS
{
    partial class UserLog
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
            this.UserLogBox = new System.Windows.Forms.GroupBox();
            this.topBarBox = new System.Windows.Forms.GroupBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.btnForward = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.topBarBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // UserLogBox
            // 
            this.UserLogBox.Location = new System.Drawing.Point(18, 105);
            this.UserLogBox.Name = "UserLogBox";
            this.UserLogBox.Size = new System.Drawing.Size(787, 521);
            this.UserLogBox.TabIndex = 23;
            this.UserLogBox.TabStop = false;
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
            this.topBarBox.TabIndex = 25;
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
            // UserLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.UserLogBox);
            this.Controls.Add(this.topBarBox);
            this.Name = "UserLog";
            this.Size = new System.Drawing.Size(823, 671);
            this.topBarBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox UserLogBox;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Button btnForward;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.GroupBox topBarBox;
    }
}
