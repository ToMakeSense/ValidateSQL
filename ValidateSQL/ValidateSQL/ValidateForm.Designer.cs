namespace ValidateSQL
{
    partial class ValidateForm
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
            this.databaseCmb = new System.Windows.Forms.ComboBox();
            this.validateBtn = new System.Windows.Forms.Button();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.sqlTxt = new System.Windows.Forms.RichTextBox();
            this.messageTxt = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // databaseCmb
            // 
            this.databaseCmb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.databaseCmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.databaseCmb.FormattingEnabled = true;
            this.databaseCmb.Location = new System.Drawing.Point(12, 15);
            this.databaseCmb.Name = "databaseCmb";
            this.databaseCmb.Size = new System.Drawing.Size(516, 21);
            this.databaseCmb.TabIndex = 0;
            this.databaseCmb.SelectedIndexChanged += new System.EventHandler(this.databaseCmb_SelectedIndexChanged);
            // 
            // validateBtn
            // 
            this.validateBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.validateBtn.Location = new System.Drawing.Point(534, 14);
            this.validateBtn.Name = "validateBtn";
            this.validateBtn.Size = new System.Drawing.Size(79, 23);
            this.validateBtn.TabIndex = 2;
            this.validateBtn.Text = "执行检查";
            this.validateBtn.UseVisualStyleBackColor = true;
            this.validateBtn.Click += new System.EventHandler(this.validateBtn_Click);
            // 
            // splitContainer
            // 
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.Location = new System.Drawing.Point(0, 0);
            this.splitContainer.Name = "splitContainer";
            this.splitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.sqlTxt);
            this.splitContainer.Panel1.Controls.Add(this.databaseCmb);
            this.splitContainer.Panel1.Controls.Add(this.validateBtn);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.messageTxt);
            this.splitContainer.Size = new System.Drawing.Size(624, 441);
            this.splitContainer.SplitterDistance = 310;
            this.splitContainer.TabIndex = 3;
            // 
            // sqlTxt
            // 
            this.sqlTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sqlTxt.Location = new System.Drawing.Point(12, 43);
            this.sqlTxt.Name = "sqlTxt";
            this.sqlTxt.Size = new System.Drawing.Size(601, 264);
            this.sqlTxt.TabIndex = 3;
            this.sqlTxt.Text = "";
            // 
            // messageTxt
            // 
            this.messageTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.messageTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.messageTxt.Location = new System.Drawing.Point(11, 3);
            this.messageTxt.Name = "messageTxt";
            this.messageTxt.Size = new System.Drawing.Size(601, 112);
            this.messageTxt.TabIndex = 4;
            this.messageTxt.Text = "";
            // 
            // ValidateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.splitContainer);
            this.Name = "ValidateForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Validate SQL";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ValidateForm_FormClosing);
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox databaseCmb;
        private System.Windows.Forms.Button validateBtn;
        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.RichTextBox sqlTxt;
        private System.Windows.Forms.RichTextBox messageTxt;
    }
}

