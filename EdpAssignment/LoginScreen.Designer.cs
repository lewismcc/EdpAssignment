namespace EdpAssignment
{
    partial class LoginScreen
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
            this.TxtBoxEmail = new System.Windows.Forms.TextBox();
            this.TxtBoxPassword = new System.Windows.Forms.TextBox();
            this.LblEmailAddress = new System.Windows.Forms.Label();
            this.LblPassword = new System.Windows.Forms.Label();
            this.BtnExit = new System.Windows.Forms.Button();
            this.BtnSubmit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnHelp = new System.Windows.Forms.Button();
            this.LblLoginWarning = new System.Windows.Forms.Label();
            this.TTSubmit = new System.Windows.Forms.ToolTip(this.components);
            this.TTExit = new System.Windows.Forms.ToolTip(this.components);
            this.TTHelp = new System.Windows.Forms.ToolTip(this.components);
            this.TTPassword = new System.Windows.Forms.ToolTip(this.components);
            this.TTEmail = new System.Windows.Forms.ToolTip(this.components);
            this.TTTitle = new System.Windows.Forms.ToolTip(this.components);
            this.BtnCancel = new System.Windows.Forms.Button();
            this.TTCancel = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // TxtBoxEmail
            // 
            this.TxtBoxEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtBoxEmail.Location = new System.Drawing.Point(373, 224);
            this.TxtBoxEmail.Name = "TxtBoxEmail";
            this.TxtBoxEmail.Size = new System.Drawing.Size(120, 13);
            this.TxtBoxEmail.TabIndex = 0;
            this.TTEmail.SetToolTip(this.TxtBoxEmail, "Please enter your email associated with your account");
            // 
            // TxtBoxPassword
            // 
            this.TxtBoxPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtBoxPassword.Location = new System.Drawing.Point(373, 280);
            this.TxtBoxPassword.Name = "TxtBoxPassword";
            this.TxtBoxPassword.PasswordChar = '*';
            this.TxtBoxPassword.Size = new System.Drawing.Size(120, 13);
            this.TxtBoxPassword.TabIndex = 1;
            this.TTPassword.SetToolTip(this.TxtBoxPassword, "Please enter super secure password here");
            // 
            // LblEmailAddress
            // 
            this.LblEmailAddress.AutoSize = true;
            this.LblEmailAddress.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEmailAddress.Location = new System.Drawing.Point(290, 218);
            this.LblEmailAddress.Name = "LblEmailAddress";
            this.LblEmailAddress.Size = new System.Drawing.Size(48, 21);
            this.LblEmailAddress.TabIndex = 2;
            this.LblEmailAddress.Text = "Email";
            this.TTEmail.SetToolTip(this.LblEmailAddress, "Please enter your email associated with your account");
            // 
            // LblPassword
            // 
            this.LblPassword.AutoSize = true;
            this.LblPassword.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPassword.Location = new System.Drawing.Point(290, 274);
            this.LblPassword.Name = "LblPassword";
            this.LblPassword.Size = new System.Drawing.Size(77, 21);
            this.LblPassword.TabIndex = 3;
            this.LblPassword.Text = "Password";
            this.TTPassword.SetToolTip(this.LblPassword, "Please enter super secure password here");
            // 
            // BtnExit
            // 
            this.BtnExit.BackColor = System.Drawing.Color.Silver;
            this.BtnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnExit.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.BtnExit.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.BtnExit.FlatAppearance.BorderSize = 0;
            this.BtnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnExit.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExit.Location = new System.Drawing.Point(738, 459);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(80, 40);
            this.BtnExit.TabIndex = 4;
            this.BtnExit.Text = "Exit";
            this.TTExit.SetToolTip(this.BtnExit, "Click here to exit program");
            this.BtnExit.UseVisualStyleBackColor = false;
            this.BtnExit.Click += new System.EventHandler(this.OnExitClick);
            // 
            // BtnSubmit
            // 
            this.BtnSubmit.BackColor = System.Drawing.Color.Silver;
            this.BtnSubmit.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.BtnSubmit.FlatAppearance.BorderSize = 0;
            this.BtnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSubmit.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSubmit.Location = new System.Drawing.Point(418, 347);
            this.BtnSubmit.Name = "BtnSubmit";
            this.BtnSubmit.Size = new System.Drawing.Size(75, 40);
            this.BtnSubmit.TabIndex = 5;
            this.BtnSubmit.Text = "Submit";
            this.TTSubmit.SetToolTip(this.BtnSubmit, "Click here to submit details");
            this.BtnSubmit.UseVisualStyleBackColor = false;
            this.BtnSubmit.Click += new System.EventHandler(this.OnSubmitClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(255, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(388, 38);
            this.label1.TabIndex = 6;
            this.label1.Text = "Bank of Lewis && McCormac";
            this.TTTitle.SetToolTip(this.label1, "Formerly bank of the big dogs biscuit");
            // 
            // BtnHelp
            // 
            this.BtnHelp.BackColor = System.Drawing.Color.Silver;
            this.BtnHelp.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.BtnHelp.FlatAppearance.BorderSize = 0;
            this.BtnHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnHelp.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnHelp.Location = new System.Drawing.Point(20, 459);
            this.BtnHelp.Name = "BtnHelp";
            this.BtnHelp.Size = new System.Drawing.Size(80, 40);
            this.BtnHelp.TabIndex = 7;
            this.BtnHelp.Text = "Help";
            this.TTHelp.SetToolTip(this.BtnHelp, "Click here to get help");
            this.BtnHelp.UseVisualStyleBackColor = false;
            this.BtnHelp.Click += new System.EventHandler(this.OnHelpClick);
            // 
            // LblLoginWarning
            // 
            this.LblLoginWarning.AutoSize = true;
            this.LblLoginWarning.Location = new System.Drawing.Point(500, 280);
            this.LblLoginWarning.Name = "LblLoginWarning";
            this.LblLoginWarning.Size = new System.Drawing.Size(35, 13);
            this.LblLoginWarning.TabIndex = 9;
            this.LblLoginWarning.Text = "label2";
            this.LblLoginWarning.Visible = false;
            // 
            // TTPassword
            // 
            this.TTPassword.IsBalloon = true;
            // 
            // TTEmail
            // 
            this.TTEmail.IsBalloon = true;
            // 
            // TTTitle
            // 
            this.TTTitle.IsBalloon = true;
            // 
            // BtnCancel
            // 
            this.BtnCancel.BackColor = System.Drawing.Color.Silver;
            this.BtnCancel.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.BtnCancel.FlatAppearance.BorderSize = 0;
            this.BtnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancel.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancel.Location = new System.Drawing.Point(312, 347);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(75, 40);
            this.BtnCancel.TabIndex = 10;
            this.BtnCancel.Text = "Cancel";
            this.TTCancel.SetToolTip(this.BtnCancel, "Click here to clear fields");
            this.BtnCancel.UseVisualStyleBackColor = false;
            this.BtnCancel.Click += new System.EventHandler(this.OnCancelClick);
            // 
            // LoginScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.LblLoginWarning);
            this.Controls.Add(this.BtnHelp);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnSubmit);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.LblPassword);
            this.Controls.Add(this.LblEmailAddress);
            this.Controls.Add(this.TxtBoxPassword);
            this.Controls.Add(this.TxtBoxEmail);
            this.Name = "LoginScreen";
            this.Size = new System.Drawing.Size(840, 520);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtBoxEmail;
        private System.Windows.Forms.TextBox TxtBoxPassword;
        private System.Windows.Forms.Label LblEmailAddress;
        private System.Windows.Forms.Label LblPassword;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Button BtnSubmit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnHelp;
        private System.Windows.Forms.Label LblLoginWarning;
        private System.Windows.Forms.ToolTip TTExit;
        private System.Windows.Forms.ToolTip TTSubmit;
        private System.Windows.Forms.ToolTip TTHelp;
        private System.Windows.Forms.ToolTip TTPassword;
        private System.Windows.Forms.ToolTip TTEmail;
        private System.Windows.Forms.ToolTip TTTitle;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.ToolTip TTCancel;
    }
}
