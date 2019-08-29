namespace EdpAssignment
{
    partial class TransactionMenu
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
            this.components = new System.ComponentModel.Container();
            this.TxtBoxDeposit = new System.Windows.Forms.TextBox();
            this.TxtBoxWithdraw = new System.Windows.Forms.TextBox();
            this.BtnDeposit = new System.Windows.Forms.Button();
            this.BtnWithdraw = new System.Windows.Forms.Button();
            this.LblWithdraw = new System.Windows.Forms.Label();
            this.LblDeposit = new System.Windows.Forms.Label();
            this.LblTitleTransaction = new System.Windows.Forms.Label();
            this.TTDeposit = new System.Windows.Forms.ToolTip(this.components);
            this.TTWithdraw = new System.Windows.Forms.ToolTip(this.components);
            this.TTDepositAmount = new System.Windows.Forms.ToolTip(this.components);
            this.TTWithdrawAmount = new System.Windows.Forms.ToolTip(this.components);
            this.LblDepositBox = new System.Windows.Forms.Label();
            this.LblWithdrawBox = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TxtBoxDeposit
            // 
            this.TxtBoxDeposit.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBoxDeposit.Location = new System.Drawing.Point(135, 94);
            this.TxtBoxDeposit.Name = "TxtBoxDeposit";
            this.TxtBoxDeposit.Size = new System.Drawing.Size(100, 29);
            this.TxtBoxDeposit.TabIndex = 0;
            this.TTDepositAmount.SetToolTip(this.TxtBoxDeposit, "Enter amount of funds to be deposited");
            // 
            // TxtBoxWithdraw
            // 
            this.TxtBoxWithdraw.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBoxWithdraw.Location = new System.Drawing.Point(135, 223);
            this.TxtBoxWithdraw.Name = "TxtBoxWithdraw";
            this.TxtBoxWithdraw.Size = new System.Drawing.Size(100, 29);
            this.TxtBoxWithdraw.TabIndex = 1;
            this.TTWithdrawAmount.SetToolTip(this.TxtBoxWithdraw, "Click here to withdraw funds");
            // 
            // BtnDeposit
            // 
            this.BtnDeposit.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDeposit.Location = new System.Drawing.Point(135, 129);
            this.BtnDeposit.Name = "BtnDeposit";
            this.BtnDeposit.Size = new System.Drawing.Size(100, 31);
            this.BtnDeposit.TabIndex = 2;
            this.BtnDeposit.Text = "Deposit ";
            this.TTDeposit.SetToolTip(this.BtnDeposit, "Click here to deposit money");
            this.BtnDeposit.UseVisualStyleBackColor = true;
            this.BtnDeposit.Click += new System.EventHandler(this.OnDepositMoneyClicked);
            // 
            // BtnWithdraw
            // 
            this.BtnWithdraw.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnWithdraw.Location = new System.Drawing.Point(135, 258);
            this.BtnWithdraw.Name = "BtnWithdraw";
            this.BtnWithdraw.Size = new System.Drawing.Size(100, 31);
            this.BtnWithdraw.TabIndex = 3;
            this.BtnWithdraw.Text = "Withdraw";
            this.TTWithdraw.SetToolTip(this.BtnWithdraw, "Click here to withdraw money");
            this.BtnWithdraw.UseVisualStyleBackColor = true;
            this.BtnWithdraw.Click += new System.EventHandler(this.OnWithdrawMoneyClicked);
            // 
            // LblWithdraw
            // 
            this.LblWithdraw.AutoSize = true;
            this.LblWithdraw.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblWithdraw.Location = new System.Drawing.Point(49, 226);
            this.LblWithdraw.Name = "LblWithdraw";
            this.LblWithdraw.Size = new System.Drawing.Size(80, 21);
            this.LblWithdraw.TabIndex = 4;
            this.LblWithdraw.Text = "WithDraw";
            this.TTWithdrawAmount.SetToolTip(this.LblWithdraw, "Click here to withdraw funds");
            // 
            // LblDeposit
            // 
            this.LblDeposit.AutoSize = true;
            this.LblDeposit.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDeposit.Location = new System.Drawing.Point(61, 94);
            this.LblDeposit.Name = "LblDeposit";
            this.LblDeposit.Size = new System.Drawing.Size(63, 21);
            this.LblDeposit.TabIndex = 5;
            this.LblDeposit.Text = "Deposit";
            this.TTDepositAmount.SetToolTip(this.LblDeposit, "Enter amount of funds to be deposited");
            // 
            // LblTitleTransaction
            // 
            this.LblTitleTransaction.AutoSize = true;
            this.LblTitleTransaction.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitleTransaction.Location = new System.Drawing.Point(64, 16);
            this.LblTitleTransaction.Name = "LblTitleTransaction";
            this.LblTitleTransaction.Size = new System.Drawing.Size(272, 30);
            this.LblTitleTransaction.TabIndex = 6;
            this.LblTitleTransaction.Text = "Deposit or Withdraw funds";
            // 
            // LblDepositBox
            // 
            this.LblDepositBox.AutoSize = true;
            this.LblDepositBox.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDepositBox.Location = new System.Drawing.Point(241, 97);
            this.LblDepositBox.Name = "LblDepositBox";
            this.LblDepositBox.Size = new System.Drawing.Size(95, 21);
            this.LblDepositBox.TabIndex = 7;
            this.LblDepositBox.Text = "Place holder";
            this.LblDepositBox.Visible = false;
            // 
            // LblWithdrawBox
            // 
            this.LblWithdrawBox.AutoSize = true;
            this.LblWithdrawBox.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblWithdrawBox.Location = new System.Drawing.Point(241, 226);
            this.LblWithdrawBox.Name = "LblWithdrawBox";
            this.LblWithdrawBox.Size = new System.Drawing.Size(95, 21);
            this.LblWithdrawBox.TabIndex = 8;
            this.LblWithdrawBox.Text = "Place holder";
            this.LblWithdrawBox.Visible = false;
            // 
            // TransactionMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.Controls.Add(this.LblWithdrawBox);
            this.Controls.Add(this.LblDepositBox);
            this.Controls.Add(this.LblTitleTransaction);
            this.Controls.Add(this.LblDeposit);
            this.Controls.Add(this.LblWithdraw);
            this.Controls.Add(this.BtnWithdraw);
            this.Controls.Add(this.BtnDeposit);
            this.Controls.Add(this.TxtBoxWithdraw);
            this.Controls.Add(this.TxtBoxDeposit);
            this.Name = "TransactionMenu";
            this.Size = new System.Drawing.Size(400, 360);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtBoxDeposit;
        private System.Windows.Forms.TextBox TxtBoxWithdraw;
        private System.Windows.Forms.Button BtnDeposit;
        private System.Windows.Forms.Button BtnWithdraw;
        private System.Windows.Forms.Label LblWithdraw;
        private System.Windows.Forms.Label LblDeposit;
        private System.Windows.Forms.Label LblTitleTransaction;
        private System.Windows.Forms.ToolTip TTDeposit;
        private System.Windows.Forms.ToolTip TTDepositAmount;
        private System.Windows.Forms.ToolTip TTWithdrawAmount;
        private System.Windows.Forms.ToolTip TTWithdraw;
        private System.Windows.Forms.Label LblDepositBox;
        private System.Windows.Forms.Label LblWithdrawBox;
    }
}
