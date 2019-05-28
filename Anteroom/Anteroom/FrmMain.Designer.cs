namespace Anteroom
{
    partial class FrmMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.系统操作ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.系统登录ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.注销账户ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.查看库存ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDian = new System.Windows.Forms.ToolStripMenuItem();
            this.预定ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.记忆功能ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.恢复上次数据ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.离开ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.离开ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.关于ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.版本信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsiRight = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiJieZhang = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiJiaCai = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiTuiZhuo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiKeLi = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiGo = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tvShow = new System.Windows.Forms.TreeView();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tpTable = new System.Windows.Forms.TabPage();
            this.pb = new System.Windows.Forms.PictureBox();
            this.系统设置YToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.设置桌数量WToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.设置包厢数量LToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.cmsiRight.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.系统操作ToolStripMenuItem,
            this.查看库存ToolStripMenuItem,
            this.记忆功能ToolStripMenuItem,
            this.离开ToolStripMenuItem,
            this.系统设置YToolStripMenuItem,
            this.关于ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1276, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 系统操作ToolStripMenuItem
            // 
            this.系统操作ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.系统登录ToolStripMenuItem,
            this.注销账户ToolStripMenuItem,
            this.toolStripMenuItem2});
            this.系统操作ToolStripMenuItem.Name = "系统操作ToolStripMenuItem";
            this.系统操作ToolStripMenuItem.Size = new System.Drawing.Size(84, 21);
            this.系统操作ToolStripMenuItem.Text = "系统操作(&A)";
            // 
            // 系统登录ToolStripMenuItem
            // 
            this.系统登录ToolStripMenuItem.Name = "系统登录ToolStripMenuItem";
            this.系统登录ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.系统登录ToolStripMenuItem.Text = "系统登录(&L)";
            this.系统登录ToolStripMenuItem.Click += new System.EventHandler(this.系统登录ToolStripMenuItem_Click);
            // 
            // 注销账户ToolStripMenuItem
            // 
            this.注销账户ToolStripMenuItem.Name = "注销账户ToolStripMenuItem";
            this.注销账户ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.注销账户ToolStripMenuItem.Text = "注销账户(&I)";
            this.注销账户ToolStripMenuItem.Click += new System.EventHandler(this.注销账户ToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(152, 22);
            this.toolStripMenuItem2.Text = "退出程序(&E)";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // 查看库存ToolStripMenuItem
            // 
            this.查看库存ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiDian,
            this.预定ToolStripMenuItem});
            this.查看库存ToolStripMenuItem.Name = "查看库存ToolStripMenuItem";
            this.查看库存ToolStripMenuItem.Size = new System.Drawing.Size(84, 21);
            this.查看库存ToolStripMenuItem.Text = "点餐操作(&B)";
            // 
            // tsmiDian
            // 
            this.tsmiDian.Name = "tsmiDian";
            this.tsmiDian.Size = new System.Drawing.Size(152, 22);
            this.tsmiDian.Text = "点餐(&S)";
            this.tsmiDian.Click += new System.EventHandler(this.tsmiDian_Click);
            // 
            // 预定ToolStripMenuItem
            // 
            this.预定ToolStripMenuItem.Name = "预定ToolStripMenuItem";
            this.预定ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.预定ToolStripMenuItem.Text = "预定(&X)";
            this.预定ToolStripMenuItem.Click += new System.EventHandler(this.预定ToolStripMenuItem_Click);
            // 
            // 记忆功能ToolStripMenuItem
            // 
            this.记忆功能ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.恢复上次数据ToolStripMenuItem});
            this.记忆功能ToolStripMenuItem.Name = "记忆功能ToolStripMenuItem";
            this.记忆功能ToolStripMenuItem.Size = new System.Drawing.Size(84, 21);
            this.记忆功能ToolStripMenuItem.Text = "记忆功能(&C)";
            // 
            // 恢复上次数据ToolStripMenuItem
            // 
            this.恢复上次数据ToolStripMenuItem.Name = "恢复上次数据ToolStripMenuItem";
            this.恢复上次数据ToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.恢复上次数据ToolStripMenuItem.Text = "恢复上次数据(&N)";
            this.恢复上次数据ToolStripMenuItem.Click += new System.EventHandler(this.恢复上次数据ToolStripMenuItem_Click);
            // 
            // 离开ToolStripMenuItem
            // 
            this.离开ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.离开ToolStripMenuItem1});
            this.离开ToolStripMenuItem.Name = "离开ToolStripMenuItem";
            this.离开ToolStripMenuItem.Size = new System.Drawing.Size(85, 21);
            this.离开ToolStripMenuItem.Text = "吧员操作(&D)";
            // 
            // 离开ToolStripMenuItem1
            // 
            this.离开ToolStripMenuItem1.Name = "离开ToolStripMenuItem1";
            this.离开ToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.离开ToolStripMenuItem1.Text = "离开(&P)";
            this.离开ToolStripMenuItem1.Click += new System.EventHandler(this.离开ToolStripMenuItem1_Click);
            // 
            // 关于ToolStripMenuItem
            // 
            this.关于ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.版本信息ToolStripMenuItem});
            this.关于ToolStripMenuItem.Name = "关于ToolStripMenuItem";
            this.关于ToolStripMenuItem.Size = new System.Drawing.Size(59, 21);
            this.关于ToolStripMenuItem.Text = "关于(&E)";
            // 
            // 版本信息ToolStripMenuItem
            // 
            this.版本信息ToolStripMenuItem.Name = "版本信息ToolStripMenuItem";
            this.版本信息ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.版本信息ToolStripMenuItem.Text = "版本信息(&Z)";
            this.版本信息ToolStripMenuItem.Click += new System.EventHandler(this.版本信息ToolStripMenuItem_Click);
            // 
            // cmsiRight
            // 
            this.cmsiRight.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiJieZhang,
            this.tsmiJiaCai,
            this.tsmiTuiZhuo,
            this.tsmiKeLi,
            this.tsmiGo});
            this.cmsiRight.Name = "cmsiRight";
            this.cmsiRight.Size = new System.Drawing.Size(125, 114);
            // 
            // tsmiJieZhang
            // 
            this.tsmiJieZhang.Name = "tsmiJieZhang";
            this.tsmiJieZhang.Size = new System.Drawing.Size(124, 22);
            this.tsmiJieZhang.Text = "结账";
            this.tsmiJieZhang.Click += new System.EventHandler(this.tsmiJieZhang_Click);
            // 
            // tsmiJiaCai
            // 
            this.tsmiJiaCai.Name = "tsmiJiaCai";
            this.tsmiJiaCai.Size = new System.Drawing.Size(124, 22);
            this.tsmiJiaCai.Text = "查看菜单";
            this.tsmiJiaCai.Click += new System.EventHandler(this.tsmiJiaCai_Click);
            // 
            // tsmiTuiZhuo
            // 
            this.tsmiTuiZhuo.Name = "tsmiTuiZhuo";
            this.tsmiTuiZhuo.Size = new System.Drawing.Size(124, 22);
            this.tsmiTuiZhuo.Text = "退桌";
            this.tsmiTuiZhuo.Click += new System.EventHandler(this.tsmiTuiZhuo_Click);
            // 
            // tsmiKeLi
            // 
            this.tsmiKeLi.Name = "tsmiKeLi";
            this.tsmiKeLi.Size = new System.Drawing.Size(124, 22);
            this.tsmiKeLi.Text = "客离";
            this.tsmiKeLi.Click += new System.EventHandler(this.tsmiKeLi_Click);
            // 
            // tsmiGo
            // 
            this.tsmiGo.Name = "tsmiGo";
            this.tsmiGo.Size = new System.Drawing.Size(124, 22);
            this.tsmiGo.Text = "走菜";
            this.tsmiGo.Click += new System.EventHandler(this.tsmiGo_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(12, 33);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(200, 671);
            this.tabControl1.TabIndex = 11;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tvShow);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(192, 645);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "筛选";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tvShow
            // 
            this.tvShow.Location = new System.Drawing.Point(6, 6);
            this.tvShow.Name = "tvShow";
            this.tvShow.Size = new System.Drawing.Size(180, 643);
            this.tvShow.TabIndex = 12;
            this.tvShow.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // tabControl2
            // 
            this.tabControl2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tabControl2.Controls.Add(this.tpTable);
            this.tabControl2.Location = new System.Drawing.Point(226, 33);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(1050, 671);
            this.tabControl2.TabIndex = 0;
            // 
            // tpTable
            // 
            this.tpTable.AutoScroll = true;
            this.tpTable.Location = new System.Drawing.Point(4, 22);
            this.tpTable.Name = "tpTable";
            this.tpTable.Padding = new System.Windows.Forms.Padding(3);
            this.tpTable.Size = new System.Drawing.Size(1042, 645);
            this.tpTable.TabIndex = 0;
            this.tpTable.Text = "全部";
            this.tpTable.UseVisualStyleBackColor = true;
            // 
            // pb
            // 
            this.pb.BackColor = System.Drawing.Color.Transparent;
            this.pb.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pb.BackgroundImage")));
            this.pb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb.Location = new System.Drawing.Point(1266, 0);
            this.pb.Name = "pb";
            this.pb.Size = new System.Drawing.Size(1292, 768);
            this.pb.TabIndex = 2;
            this.pb.TabStop = false;
            this.pb.Visible = false;
            // 
            // 系统设置YToolStripMenuItem
            // 
            this.系统设置YToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.设置桌数量WToolStripMenuItem,
            this.设置包厢数量LToolStripMenuItem});
            this.系统设置YToolStripMenuItem.Name = "系统设置YToolStripMenuItem";
            this.系统设置YToolStripMenuItem.Size = new System.Drawing.Size(83, 21);
            this.系统设置YToolStripMenuItem.Text = "系统设置(&Y)";
            // 
            // 设置桌数量WToolStripMenuItem
            // 
            this.设置桌数量WToolStripMenuItem.Name = "设置桌数量WToolStripMenuItem";
            this.设置桌数量WToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.设置桌数量WToolStripMenuItem.Text = "设置桌数量(&W)";
            this.设置桌数量WToolStripMenuItem.Click += new System.EventHandler(this.设置桌数量WToolStripMenuItem_Click);
            // 
            // 设置包厢数量LToolStripMenuItem
            // 
            this.设置包厢数量LToolStripMenuItem.Name = "设置包厢数量LToolStripMenuItem";
            this.设置包厢数量LToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.设置包厢数量LToolStripMenuItem.Text = "设置包厢数量(&U)";
            this.设置包厢数量LToolStripMenuItem.Click += new System.EventHandler(this.设置包厢数量LToolStripMenuItem_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1276, 730);
            this.Controls.Add(this.pb);
            this.Controls.Add(this.tabControl2);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "餐厅前台操作系统";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmMain_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.cmsiRight.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 查看库存ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiDian;
        private System.Windows.Forms.ContextMenuStrip cmsiRight;
        private System.Windows.Forms.ToolStripMenuItem tsmiJieZhang;
        private System.Windows.Forms.ToolStripMenuItem tsmiJiaCai;
        private System.Windows.Forms.ToolStripMenuItem 预定ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiTuiZhuo;
        private System.Windows.Forms.ToolStripMenuItem tsmiKeLi;
        private System.Windows.Forms.ToolStripMenuItem tsmiGo;
        private System.Windows.Forms.ToolStripMenuItem 离开ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 离开ToolStripMenuItem1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tpTable;
        private System.Windows.Forms.TreeView tvShow;
        public System.Windows.Forms.PictureBox pb;
        private System.Windows.Forms.ToolStripMenuItem 系统操作ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 系统登录ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 注销账户ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem 记忆功能ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 恢复上次数据ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关于ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 版本信息ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 系统设置YToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 设置桌数量WToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 设置包厢数量LToolStripMenuItem;
    }
}

