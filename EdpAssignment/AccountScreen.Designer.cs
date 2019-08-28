namespace EdpAssignment
{
    partial class AccountScreen
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
            this.LblFName = new System.Windows.Forms.Label();
            this.LblSName = new System.Windows.Forms.Label();
            this.LblBalance = new System.Windows.Forms.Label();
            this.BtnLogout = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblFName
            // 
            this.LblFName.AutoSize = true;
            this.LblFName.Location = new System.Drawing.Point(256, 89);
            this.LblFName.Name = "LblFName";
            this.LblFName.Size = new System.Drawing.Size(66, 13);
            this.LblFName.TabIndex = 0;
            this.LblFName.Text = "Place holder";
            // 
            // LblSName
            // 
            this.LblSName.AutoSize = true;
            this.LblSName.Location = new System.Drawing.Point(478, 89);
            this.LblSName.Name = "LblSName";
            this.LblSName.Size = new System.Drawing.Size(66, 13);
            this.LblSName.TabIndex = 1;
            this.LblSName.Text = "Place holder";
            // 
            // LblBalance
            // 
            this.LblBalance.AutoSize = true;
            this.LblBalance.Location = new System.Drawing.Point(359, 224);
            this.LblBalance.Name = "LblBalance";
            this.LblBalance.Size = new System.Drawing.Size(83, 13);
            this.LblBalance.TabIndex = 2;
            this.LblBalance.Text = "Current Balance";
            // 
            // BtnLogout
            // 
            this.BtnLogout.Location = new System.Drawing.Point(19, 459);
            this.BtnLogout.Name = "BtnLogout";
            this.BtnLogout.Size = new System.Drawing.Size(80, 40);
            this.BtnLogout.TabIndex = 3;
            this.BtnLogout.Text = "Logout";
            this.BtnLogout.UseVisualStyleBackColor = true;
            this.BtnLogout.Click += new System.EventHandler(this.OnLogoutClick);
            // 
            // BtnExit
            // 
            this.BtnExit.BackColor = System.Drawing.Color.Silver;
            this.BtnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnExit.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.BtnExit.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.BtnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnExit.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExit.Location = new System.Drawing.Point(738, 459);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(80, 40);
            this.BtnExit.TabIndex = 5;
            this.BtnExit.Text = "Exit";
            this.BtnExit.UseVisualStyleBackColor = false;
            this.BtnExit.Click += new System.EventHandler(this.OnExitClick);
            // 
            // AccountScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.BtnLogout);
            this.Controls.Add(this.LblBalance);
            this.Controls.Add(this.LblSName);
            this.Controls.Add(this.LblFName);
            this.Name = "AccountScreen";
            this.Size = new System.Drawing.Size(840, 520);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblFName;
        private System.Windows.Forms.Label LblSName;
        private System.Windows.Forms.Label LblBalance;
        private System.Windows.Forms.Button BtnLogout;
        private System.Windows.Forms.Button BtnExit;
    }
}
