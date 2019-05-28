namespace Restaurant
{
    partial class FrmMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmiMoney = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSee = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiUpdateMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiUpdateAdmin = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiExit = new System.Windows.Forms.ToolStripMenuItem();
            this.关于我们ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiGuanYu = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiMoney,
            this.关于我们ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(665, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmiMoney
            // 
            this.tsmiMoney.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiSee,
            this.tsmiUpdateMenu,
            this.tsmiUpdateAdmin,
            this.tsmiExit});
            this.tsmiMoney.Name = "tsmiMoney";
            this.tsmiMoney.Size = new System.Drawing.Size(68, 21);
            this.tsmiMoney.Text = "餐厅管理";
            // 
            // tsmiSee
            // 
            this.tsmiSee.Name = "tsmiSee";
            this.tsmiSee.Size = new System.Drawing.Size(148, 22);
            this.tsmiSee.Text = "查看营业额";
            this.tsmiSee.Click += new System.EventHandler(this.tsmiSee_Click);
            // 
            // tsmiUpdateMenu
            // 
            this.tsmiUpdateMenu.Name = "tsmiUpdateMenu";
            this.tsmiUpdateMenu.Size = new System.Drawing.Size(148, 22);
            this.tsmiUpdateMenu.Text = "修改菜单信息";
            this.tsmiUpdateMenu.Click += new System.EventHandler(this.tsmiUpdateMoney_Click);
            // 
            // tsmiUpdateAdmin
            // 
            this.tsmiUpdateAdmin.Name = "tsmiUpdateAdmin";
            this.tsmiUpdateAdmin.Size = new System.Drawing.Size(148, 22);
            this.tsmiUpdateAdmin.Text = "修改账号信息";
            this.tsmiUpdateAdmin.Click += new System.EventHandler(this.tsmiUpdateAdmin_Click);
            // 
            // tsmiExit
            // 
            this.tsmiExit.Name = "tsmiExit";
            this.tsmiExit.Size = new System.Drawing.Size(148, 22);
            this.tsmiExit.Text = "退出";
            this.tsmiExit.Click += new System.EventHandler(this.tsmiExit_Click);
            // 
            // 关于我们ToolStripMenuItem
            // 
            this.关于我们ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiGuanYu});
            this.关于我们ToolStripMenuItem.Name = "关于我们ToolStripMenuItem";
            this.关于我们ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.关于我们ToolStripMenuItem.Text = "关于我们";
            // 
            // tsmiGuanYu
            // 
            this.tsmiGuanYu.Name = "tsmiGuanYu";
            this.tsmiGuanYu.Size = new System.Drawing.Size(152, 22);
            this.tsmiGuanYu.Text = "关于";
            this.tsmiGuanYu.Click += new System.EventHandler(this.tsmiGuanYu_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 494);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "餐厅管理系统";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmiMoney;
        private System.Windows.Forms.ToolStripMenuItem tsmiUpdateMenu;
        private System.Windows.Forms.ToolStripMenuItem 关于我们ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiGuanYu;
        private System.Windows.Forms.ToolStripMenuItem tsmiSee;
        private System.Windows.Forms.ToolStripMenuItem tsmiUpdateAdmin;
        private System.Windows.Forms.ToolStripMenuItem tsmiExit;
    }
}