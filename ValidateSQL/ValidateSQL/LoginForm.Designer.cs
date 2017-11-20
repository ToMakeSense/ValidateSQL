namespace ValidateSQL
{
    partial class LoginForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.serverNameLbl = new System.Windows.Forms.Label();
            this.authentiocationCmb = new System.Windows.Forms.ComboBox();
            this.authentiocationLbl = new System.Windows.Forms.Label();
            this.userNameLbl = new System.Windows.Forms.Label();
            this.passwordLbl = new System.Windows.Forms.Label();
            this.passwordTxt = new System.Windows.Forms.TextBox();
            this.RememberLbl = new System.Windows.Forms.CheckBox();
            this.connectBtn = new System.Windows.Forms.Button();
            this.serverNameTxt = new System.Windows.Forms.TextBox();
            this.userNameTxt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // serverNameLbl
            // 
            this.serverNameLbl.AutoSize = true;
            this.serverNameLbl.Location = new System.Drawing.Point(12, 17);
            this.serverNameLbl.Name = "serverNameLbl";
            this.serverNameLbl.Size = new System.Drawing.Size(72, 13);
            this.serverNameLbl.TabIndex = 0;
            this.serverNameLbl.Text = "Server Name:";
            // 
            // authentiocationCmb
            // 
            this.authentiocationCmb.FormattingEnabled = true;
            this.authentiocationCmb.Items.AddRange(new object[] {
            "SQL Server Authentiocation",
            "Windows Authentiocation"});
            this.authentiocationCmb.Location = new System.Drawing.Point(104, 52);
            this.authentiocationCmb.Name = "authentiocationCmb";
            this.authentiocationCmb.Size = new System.Drawing.Size(204, 21);
            this.authentiocationCmb.TabIndex = 3;
            this.authentiocationCmb.SelectedValueChanged += new System.EventHandler(this.authentiocationCmb_SelectedValueChanged);
            // 
            // authentiocationLbl
            // 
            this.authentiocationLbl.AutoSize = true;
            this.authentiocationLbl.Location = new System.Drawing.Point(12, 55);
            this.authentiocationLbl.Name = "authentiocationLbl";
            this.authentiocationLbl.Size = new System.Drawing.Size(84, 13);
            this.authentiocationLbl.TabIndex = 2;
            this.authentiocationLbl.Text = "Authentiocation:";
            // 
            // userNameLbl
            // 
            this.userNameLbl.AutoSize = true;
            this.userNameLbl.Location = new System.Drawing.Point(12, 93);
            this.userNameLbl.Name = "userNameLbl";
            this.userNameLbl.Size = new System.Drawing.Size(63, 13);
            this.userNameLbl.TabIndex = 4;
            this.userNameLbl.Text = "User Name:";
            // 
            // passwordLbl
            // 
            this.passwordLbl.AutoSize = true;
            this.passwordLbl.Location = new System.Drawing.Point(12, 131);
            this.passwordLbl.Name = "passwordLbl";
            this.passwordLbl.Size = new System.Drawing.Size(56, 13);
            this.passwordLbl.TabIndex = 6;
            this.passwordLbl.Text = "Password:";
            // 
            // passwordTxt
            // 
            this.passwordTxt.Location = new System.Drawing.Point(104, 128);
            this.passwordTxt.Name = "passwordTxt";
            this.passwordTxt.Size = new System.Drawing.Size(204, 20);
            this.passwordTxt.TabIndex = 7;
            // 
            // RememberLbl
            // 
            this.RememberLbl.AutoSize = true;
            this.RememberLbl.Checked = true;
            this.RememberLbl.CheckState = System.Windows.Forms.CheckState.Checked;
            this.RememberLbl.Location = new System.Drawing.Point(15, 167);
            this.RememberLbl.Name = "RememberLbl";
            this.RememberLbl.Size = new System.Drawing.Size(126, 17);
            this.RememberLbl.TabIndex = 8;
            this.RememberLbl.Text = "Remember Password";
            this.RememberLbl.UseVisualStyleBackColor = true;
            // 
            // connectBtn
            // 
            this.connectBtn.Location = new System.Drawing.Point(233, 163);
            this.connectBtn.Name = "connectBtn";
            this.connectBtn.Size = new System.Drawing.Size(75, 23);
            this.connectBtn.TabIndex = 9;
            this.connectBtn.Text = "Connect";
            this.connectBtn.UseVisualStyleBackColor = true;
            this.connectBtn.Click += new System.EventHandler(this.connectBtn_Click);
            // 
            // serverNameTxt
            // 
            this.serverNameTxt.Location = new System.Drawing.Point(104, 14);
            this.serverNameTxt.Name = "serverNameTxt";
            this.serverNameTxt.Size = new System.Drawing.Size(204, 20);
            this.serverNameTxt.TabIndex = 10;
            // 
            // userNameTxt
            // 
            this.userNameTxt.Location = new System.Drawing.Point(104, 90);
            this.userNameTxt.Name = "userNameTxt";
            this.userNameTxt.Size = new System.Drawing.Size(204, 20);
            this.userNameTxt.TabIndex = 11;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 201);
            this.Controls.Add(this.userNameTxt);
            this.Controls.Add(this.serverNameTxt);
            this.Controls.Add(this.connectBtn);
            this.Controls.Add(this.RememberLbl);
            this.Controls.Add(this.passwordTxt);
            this.Controls.Add(this.passwordLbl);
            this.Controls.Add(this.userNameLbl);
            this.Controls.Add(this.authentiocationCmb);
            this.Controls.Add(this.authentiocationLbl);
            this.Controls.Add(this.serverNameLbl);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Connect to Server";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label serverNameLbl;
        private System.Windows.Forms.ComboBox authentiocationCmb;
        private System.Windows.Forms.Label authentiocationLbl;
        private System.Windows.Forms.Label userNameLbl;
        private System.Windows.Forms.Label passwordLbl;
        private System.Windows.Forms.TextBox passwordTxt;
        private System.Windows.Forms.CheckBox RememberLbl;
        private System.Windows.Forms.Button connectBtn;
        private System.Windows.Forms.TextBox serverNameTxt;
        private System.Windows.Forms.TextBox userNameTxt;
    }
}