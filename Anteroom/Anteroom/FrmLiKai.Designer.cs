namespace Anteroom
{
    partial class FrmLiKai
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtpwd = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtpwd2 = new System.Windows.Forms.TextBox();
            this.lbname = new System.Windows.Forms.Label();
            this.lbpwd = new System.Windows.Forms.Label();
            this.btnlogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "请设置密码：";
            // 
            // txtpwd
            // 
            this.txtpwd.Location = new System.Drawing.Point(111, 45);
            this.txtpwd.Name = "txtpwd";
            this.txtpwd.Size = new System.Drawing.Size(100, 21);
            this.txtpwd.TabIndex = 1;
            this.txtpwd.UseSystemPasswordChar = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(223, 43);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "确定";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAdmin
            // 
            this.btnAdmin.Location = new System.Drawing.Point(90, 79);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(138, 23);
            this.btnAdmin.TabIndex = 3;
            this.btnAdmin.Text = "忘记密码管理员登录";
            this.btnAdmin.UseVisualStyleBackColor = true;
            this.btnAdmin.Visible = false;
            this.btnAdmin.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(46, 108);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(100, 21);
            this.txtname.TabIndex = 4;
            this.txtname.UseSystemPasswordChar = true;
            this.txtname.Visible = false;
            // 
            // txtpwd2
            // 
            this.txtpwd2.Location = new System.Drawing.Point(198, 108);
            this.txtpwd2.Name = "txtpwd2";
            this.txtpwd2.Size = new System.Drawing.Size(100, 21);
            this.txtpwd2.TabIndex = 5;
            this.txtpwd2.UseSystemPasswordChar = true;
            this.txtpwd2.Visible = false;
            // 
            // lbname
            // 
            this.lbname.AutoSize = true;
            this.lbname.Location = new System.Drawing.Point(11, 111);
            this.lbname.Name = "lbname";
            this.lbname.Size = new System.Drawing.Size(29, 12);
            this.lbname.TabIndex = 6;
            this.lbname.Text = "账号";
            this.lbname.Visible = false;
            // 
            // lbpwd
            // 
            this.lbpwd.AutoSize = true;
            this.lbpwd.Location = new System.Drawing.Point(163, 111);
            this.lbpwd.Name = "lbpwd";
            this.lbpwd.Size = new System.Drawing.Size(29, 12);
            this.lbpwd.TabIndex = 7;
            this.lbpwd.Text = "密码";
            this.lbpwd.Visible = false;
            // 
            // btnlogin
            // 
            this.btnlogin.Location = new System.Drawing.Point(117, 135);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(75, 23);
            this.btnlogin.TabIndex = 8;
            this.btnlogin.Text = "登录";
            this.btnlogin.UseVisualStyleBackColor = true;
            this.btnlogin.Visible = false;
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // FrmLiKai
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(310, 160);
            this.Controls.Add(this.btnlogin);
            this.Controls.Add(this.lbpwd);
            this.Controls.Add(this.lbname);
            this.Controls.Add(this.txtpwd2);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.btnAdmin);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtpwd);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmLiKai";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmLiKai";
            this.Load += new System.EventHandler(this.FrmLiKai_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtpwd;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnAdmin;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtpwd2;
        private System.Windows.Forms.Label lbname;
        private System.Windows.Forms.Label lbpwd;
        private System.Windows.Forms.Button btnlogin;
    }
}