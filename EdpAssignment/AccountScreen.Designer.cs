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
            this.LblBalance = new System.Windows.Forms.Label();
            this.BtnLogout = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.LblActiveBalance = new System.Windows.Forms.Label();
            this.BtnOpenTransMenu = new System.Windows.Forms.Button();
            this.TransactionPanel = new System.Windows.Forms.Panel();
            this.BtnCloseTransMenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblFName
            // 
            this.LblFName.AutoSize = true;
            this.LblFName.Font = new System.Drawing.Font("Yu Gothic UI Semilight", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFName.Location = new System.Drawing.Point(108, 65);
            this.LblFName.Name = "LblFName";
            this.LblFName.Size = new System.Drawing.Size(127, 30);
            this.LblFName.TabIndex = 0;
            this.LblFName.Text = "Place holder";
            // 
            // LblBalance
            // 
            this.LblBalance.AutoSize = true;
            this.LblBalance.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblBalance.Location = new System.Drawing.Point(75, 146);
            this.LblBalance.Name = "LblBalance";
            this.LblBalance.Size = new System.Drawing.Size(190, 32);
            this.LblBalance.TabIndex = 2;
            this.LblBalance.Text = "Current Balance";
            // 
            // BtnLogout
            // 
            this.BtnLogout.BackColor = System.Drawing.Color.Silver;
            this.BtnLogout.FlatAppearance.BorderSize = 0;
            this.BtnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLogout.Location = new System.Drawing.Point(19, 459);
            this.BtnLogout.Name = "BtnLogout";
            this.BtnLogout.Size = new System.Drawing.Size(80, 40);
            this.BtnLogout.TabIndex = 3;
            this.BtnLogout.Text = "Logout";
            this.BtnLogout.UseVisualStyleBackColor = false;
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
            // LblActiveBalance
            // 
            this.LblActiveBalance.AutoSize = true;
            this.LblActiveBalance.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblActiveBalance.Location = new System.Drawing.Point(108, 246);
            this.LblActiveBalance.Name = "LblActiveBalance";
            this.LblActiveBalance.Size = new System.Drawing.Size(112, 25);
            this.LblActiveBalance.TabIndex = 6;
            this.LblActiveBalance.Text = "Placeholder";
            // 
            // BtnOpenTransMenu
            // 
            this.BtnOpenTransMenu.BackColor = System.Drawing.Color.Silver;
            this.BtnOpenTransMenu.FlatAppearance.BorderSize = 0;
            this.BtnOpenTransMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnOpenTransMenu.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnOpenTransMenu.Location = new System.Drawing.Point(437, 448);
            this.BtnOpenTransMenu.Name = "BtnOpenTransMenu";
            this.BtnOpenTransMenu.Size = new System.Drawing.Size(124, 51);
            this.BtnOpenTransMenu.TabIndex = 7;
            this.BtnOpenTransMenu.Text = "Transaction Menu";
            this.BtnOpenTransMenu.UseVisualStyleBackColor = false;
            this.BtnOpenTransMenu.Click += new System.EventHandler(this.OnTransactionMenuClicked);
            // 
            // TransactionPanel
            // 
            this.TransactionPanel.Location = new System.Drawing.Point(437, 26);
            this.TransactionPanel.Name = "TransactionPanel";
            this.TransactionPanel.Size = new System.Drawing.Size(400, 400);
            this.TransactionPanel.TabIndex = 8;
            // 
            // BtnCloseTransMenu
            // 
            this.BtnCloseTransMenu.BackColor = System.Drawing.Color.Silver;
            this.BtnCloseTransMenu.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.BtnCloseTransMenu.FlatAppearance.BorderSize = 0;
            this.BtnCloseTransMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCloseTransMenu.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCloseTransMenu.Location = new System.Drawing.Point(576, 448);
            this.BtnCloseTransMenu.Name = "BtnCloseTransMenu";
            this.BtnCloseTransMenu.Size = new System.Drawing.Size(124, 51);
            this.BtnCloseTransMenu.TabIndex = 9;
            this.BtnCloseTransMenu.Text = "Close Menu";
            this.BtnCloseTransMenu.UseVisualStyleBackColor = false;
            this.BtnCloseTransMenu.Click += new System.EventHandler(this.OnCloseBtnClicked);
            // 
            // AccountScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.Controls.Add(this.BtnCloseTransMenu);
            this.Controls.Add(this.TransactionPanel);
            this.Controls.Add(this.BtnOpenTransMenu);
            this.Controls.Add(this.LblActiveBalance);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.BtnLogout);
            this.Controls.Add(this.LblBalance);
            this.Controls.Add(this.LblFName);
            this.Name = "AccountScreen";
            this.Size = new System.Drawing.Size(840, 520);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblFName;
        private System.Windows.Forms.Label LblBalance;
        private System.Windows.Forms.Button BtnLogout;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Label LblActiveBalance;
        private System.Windows.Forms.Button BtnOpenTransMenu;
        private System.Windows.Forms.Panel TransactionPanel;
        private System.Windows.Forms.Button BtnCloseTransMenu;
    }
}
