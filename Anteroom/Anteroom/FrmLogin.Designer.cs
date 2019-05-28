namespace Anteroom
{
    partial class FrmLogin
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
            this.btnExit = new System.Windows.Forms.Button();
            this.cbJiZhu = new System.Windows.Forms.CheckBox();
            this.btnBoss = new System.Windows.Forms.Button();
            this.txtPwd = new System.Windows.Forms.TextBox();
            this.cboName = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(197, 183);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 19;
            this.btnExit.Text = "取消";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // cbJiZhu
            // 
            this.cbJiZhu.AutoSize = true;
            this.cbJiZhu.Location = new System.Drawing.Point(263, 131);
            this.cbJiZhu.Name = "cbJiZhu";
            this.cbJiZhu.Size = new System.Drawing.Size(72, 16);
            this.cbJiZhu.TabIndex = 16;
            this.cbJiZhu.Text = "记住密码";
            this.cbJiZhu.UseVisualStyleBackColor = true;
            // 
            // btnBoss
            // 
            this.btnBoss.Location = new System.Drawing.Point(92, 183);
            this.btnBoss.Name = "btnBoss";
            this.btnBoss.Size = new System.Drawing.Size(75, 23);
            this.btnBoss.TabIndex = 18;
            this.btnBoss.Text = "登录";
            this.btnBoss.UseVisualStyleBackColor = true;
            this.btnBoss.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtPwd
            // 
            this.txtPwd.Location = new System.Drawing.Point(108, 126);
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.PasswordChar = '*';
            this.txtPwd.Size = new System.Drawing.Size(139, 21);
            this.txtPwd.TabIndex = 15;
            // 
            // cboName
            // 
            this.cboName.FormattingEnabled = true;
            this.cboName.Location = new System.Drawing.Point(108, 56);
            this.cboName.Name = "cboName";
            this.cboName.Size = new System.Drawing.Size(139, 20);
            this.cboName.TabIndex = 14;
            this.cboName.SelectedIndexChanged += new System.EventHandler(this.cboName_SelectedIndexChanged);
            this.cboName.Click += new System.EventHandler(this.cboName_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 13;
            this.label2.Text = "密码：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 12;
            this.label1.Text = "用户名：";
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 247);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.cbJiZhu);
            this.Controls.Add(this.btnBoss);
            this.Controls.Add(this.txtPwd);
            this.Controls.Add(this.cboName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "系统登录";
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.CheckBox cbJiZhu;
        private System.Windows.Forms.Button btnBoss;
        private System.Windows.Forms.TextBox txtPwd;
        private System.Windows.Forms.ComboBox cboName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}