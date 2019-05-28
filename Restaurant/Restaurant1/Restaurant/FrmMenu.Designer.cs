namespace Restaurant
{
    partial class FrmMenu
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
            this.components = new System.ComponentModel.Container();
            this.btnExit = new System.Windows.Forms.Button();
            this.dgv1Show = new System.Windows.Forms.DataGridView();
            this.DishId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CribOne = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CribTwo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DishName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DishMoney = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name22 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CribOneX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CribTwoX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmsOne = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiZengJia = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDel = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiUpdate = new System.Windows.Forms.ToolStripMenuItem();
            this.txt1Name = new System.Windows.Forms.TextBox();
            this.btn1Cha = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabP1 = new System.Windows.Forms.TabPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgv2Show = new System.Windows.Forms.DataGridView();
            this.CaudleId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CaudleName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CaudleMoney = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CaudleGoldenCalf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CaudleRepertory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmsTwo = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmi2Zengjia = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi2Del = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi2Update = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi2KuCun = new System.Windows.Forms.ToolStripMenuItem();
            this.btn2Cha = new System.Windows.Forms.Button();
            this.txt2Name = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgv3Show = new System.Windows.Forms.DataGridView();
            this.CridId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CridName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CridMoney = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CridRepertory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmsThree = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tmsi3ZengJia = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi3Del = new System.Windows.Forms.ToolStripMenuItem();
            this.tmsiUpdate = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi3JinHuo = new System.Windows.Forms.ToolStripMenuItem();
            this.btn3Cha = new System.Windows.Forms.Button();
            this.txt3Name = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1Show)).BeginInit();
            this.cmsOne.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabP1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv2Show)).BeginInit();
            this.cmsTwo.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv3Show)).BeginInit();
            this.cmsThree.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(596, 486);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "关闭";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // dgv1Show
            // 
            this.dgv1Show.AllowUserToAddRows = false;
            this.dgv1Show.AllowUserToDeleteRows = false;
            this.dgv1Show.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv1Show.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv1Show.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DishId,
            this.CribOne,
            this.CribTwo,
            this.DishName,
            this.DishMoney,
            this.name22,
            this.Name2,
            this.CribOneX,
            this.CribTwoX});
            this.dgv1Show.ContextMenuStrip = this.cmsOne;
            this.dgv1Show.Location = new System.Drawing.Point(3, 47);
            this.dgv1Show.Name = "dgv1Show";
            this.dgv1Show.ReadOnly = true;
            this.dgv1Show.RowTemplate.Height = 23;
            this.dgv1Show.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv1Show.Size = new System.Drawing.Size(759, 358);
            this.dgv1Show.TabIndex = 1;
            // 
            // DishId
            // 
            this.DishId.DataPropertyName = "DishId";
            this.DishId.HeaderText = "菜品编号";
            this.DishId.Name = "DishId";
            this.DishId.ReadOnly = true;
            // 
            // CribOne
            // 
            this.CribOne.DataPropertyName = "CribOne";
            this.CribOne.HeaderText = "CribOne";
            this.CribOne.Name = "CribOne";
            this.CribOne.ReadOnly = true;
            this.CribOne.Visible = false;
            // 
            // CribTwo
            // 
            this.CribTwo.DataPropertyName = "CribTwo";
            this.CribTwo.HeaderText = "CribTwo";
            this.CribTwo.Name = "CribTwo";
            this.CribTwo.ReadOnly = true;
            this.CribTwo.Visible = false;
            // 
            // DishName
            // 
            this.DishName.DataPropertyName = "DishName";
            this.DishName.HeaderText = "菜品名称";
            this.DishName.Name = "DishName";
            this.DishName.ReadOnly = true;
            // 
            // DishMoney
            // 
            this.DishMoney.DataPropertyName = "DishMoney";
            this.DishMoney.HeaderText = "菜品价格";
            this.DishMoney.Name = "DishMoney";
            this.DishMoney.ReadOnly = true;
            // 
            // name22
            // 
            this.name22.DataPropertyName = "CribOneMenu";
            this.name22.HeaderText = "食材1名称";
            this.name22.Name = "name22";
            this.name22.ReadOnly = true;
            // 
            // Name2
            // 
            this.Name2.DataPropertyName = "CribTwoMenu";
            this.Name2.HeaderText = "食材2名称";
            this.Name2.Name = "Name2";
            this.Name2.ReadOnly = true;
            // 
            // CribOneX
            // 
            this.CribOneX.DataPropertyName = "CribOneX";
            this.CribOneX.HeaderText = "食材1分量";
            this.CribOneX.Name = "CribOneX";
            this.CribOneX.ReadOnly = true;
            // 
            // CribTwoX
            // 
            this.CribTwoX.DataPropertyName = "CribTwoX";
            this.CribTwoX.HeaderText = "食材2分量";
            this.CribTwoX.Name = "CribTwoX";
            this.CribTwoX.ReadOnly = true;
            // 
            // cmsOne
            // 
            this.cmsOne.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiZengJia,
            this.tsmiDel,
            this.tsmiUpdate});
            this.cmsOne.Name = "contextMenuStrip1";
            this.cmsOne.Size = new System.Drawing.Size(125, 70);
            // 
            // tsmiZengJia
            // 
            this.tsmiZengJia.Name = "tsmiZengJia";
            this.tsmiZengJia.Size = new System.Drawing.Size(124, 22);
            this.tsmiZengJia.Text = "增加菜品";
            this.tsmiZengJia.Click += new System.EventHandler(this.tsmiZengJia_Click);
            // 
            // tsmiDel
            // 
            this.tsmiDel.Name = "tsmiDel";
            this.tsmiDel.Size = new System.Drawing.Size(124, 22);
            this.tsmiDel.Text = "删除菜品";
            this.tsmiDel.Click += new System.EventHandler(this.tsmiDel_Click);
            // 
            // tsmiUpdate
            // 
            this.tsmiUpdate.Name = "tsmiUpdate";
            this.tsmiUpdate.Size = new System.Drawing.Size(124, 22);
            this.tsmiUpdate.Text = "修改菜品";
            this.tsmiUpdate.Click += new System.EventHandler(this.tsmiUpdate_Click);
            // 
            // txt1Name
            // 
            this.txt1Name.Location = new System.Drawing.Point(425, 20);
            this.txt1Name.Name = "txt1Name";
            this.txt1Name.Size = new System.Drawing.Size(100, 21);
            this.txt1Name.TabIndex = 2;
            // 
            // btn1Cha
            // 
            this.btn1Cha.Location = new System.Drawing.Point(549, 18);
            this.btn1Cha.Name = "btn1Cha";
            this.btn1Cha.Size = new System.Drawing.Size(75, 23);
            this.btn1Cha.TabIndex = 3;
            this.btn1Cha.Text = "查询";
            this.btn1Cha.UseVisualStyleBackColor = true;
            this.btn1Cha.Click += new System.EventHandler(this.btn1Cha_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabP1);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 468);
            this.tabControl1.TabIndex = 4;
            // 
            // tabP1
            // 
            this.tabP1.Controls.Add(this.dgv1Show);
            this.tabP1.Controls.Add(this.btn1Cha);
            this.tabP1.Controls.Add(this.txt1Name);
            this.tabP1.Location = new System.Drawing.Point(4, 22);
            this.tabP1.Name = "tabP1";
            this.tabP1.Padding = new System.Windows.Forms.Padding(3);
            this.tabP1.Size = new System.Drawing.Size(768, 442);
            this.tabP1.TabIndex = 1;
            this.tabP1.Text = "查询菜品";
            this.tabP1.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgv2Show);
            this.tabPage1.Controls.Add(this.btn2Cha);
            this.tabPage1.Controls.Add(this.txt2Name);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(768, 442);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "查询酒水";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgv2Show
            // 
            this.dgv2Show.AllowUserToAddRows = false;
            this.dgv2Show.AllowUserToDeleteRows = false;
            this.dgv2Show.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv2Show.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv2Show.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CaudleId,
            this.CaudleName,
            this.CaudleMoney,
            this.CaudleGoldenCalf,
            this.CaudleRepertory});
            this.dgv2Show.ContextMenuStrip = this.cmsTwo;
            this.dgv2Show.Location = new System.Drawing.Point(6, 46);
            this.dgv2Show.Name = "dgv2Show";
            this.dgv2Show.ReadOnly = true;
            this.dgv2Show.RowTemplate.Height = 23;
            this.dgv2Show.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv2Show.Size = new System.Drawing.Size(756, 363);
            this.dgv2Show.TabIndex = 4;
            // 
            // CaudleId
            // 
            this.CaudleId.DataPropertyName = "CaudleId";
            this.CaudleId.HeaderText = "酒水编号";
            this.CaudleId.Name = "CaudleId";
            this.CaudleId.ReadOnly = true;
            // 
            // CaudleName
            // 
            this.CaudleName.DataPropertyName = "CaudleName";
            this.CaudleName.HeaderText = "酒水名称";
            this.CaudleName.Name = "CaudleName";
            this.CaudleName.ReadOnly = true;
            // 
            // CaudleMoney
            // 
            this.CaudleMoney.DataPropertyName = "CaudleMoney";
            this.CaudleMoney.HeaderText = "酒水价格";
            this.CaudleMoney.Name = "CaudleMoney";
            this.CaudleMoney.ReadOnly = true;
            // 
            // CaudleGoldenCalf
            // 
            this.CaudleGoldenCalf.DataPropertyName = "CaudleGoldenCalf";
            this.CaudleGoldenCalf.HeaderText = "酒水进价";
            this.CaudleGoldenCalf.Name = "CaudleGoldenCalf";
            this.CaudleGoldenCalf.ReadOnly = true;
            // 
            // CaudleRepertory
            // 
            this.CaudleRepertory.DataPropertyName = "CaudleRepertory";
            this.CaudleRepertory.HeaderText = "酒水库存";
            this.CaudleRepertory.Name = "CaudleRepertory";
            this.CaudleRepertory.ReadOnly = true;
            // 
            // cmsTwo
            // 
            this.cmsTwo.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi2Zengjia,
            this.tsmi2Del,
            this.tsmi2Update,
            this.tsmi2KuCun});
            this.cmsTwo.Name = "contextMenuStrip1";
            this.cmsTwo.Size = new System.Drawing.Size(125, 92);
            // 
            // tsmi2Zengjia
            // 
            this.tsmi2Zengjia.Name = "tsmi2Zengjia";
            this.tsmi2Zengjia.Size = new System.Drawing.Size(124, 22);
            this.tsmi2Zengjia.Text = "增加酒水";
            this.tsmi2Zengjia.Click += new System.EventHandler(this.tsmi2Zengjia_Click);
            // 
            // tsmi2Del
            // 
            this.tsmi2Del.Name = "tsmi2Del";
            this.tsmi2Del.Size = new System.Drawing.Size(124, 22);
            this.tsmi2Del.Text = "删除酒水";
            this.tsmi2Del.Click += new System.EventHandler(this.tsmi2Del_Click);
            // 
            // tsmi2Update
            // 
            this.tsmi2Update.Name = "tsmi2Update";
            this.tsmi2Update.Size = new System.Drawing.Size(124, 22);
            this.tsmi2Update.Text = "修改酒水";
            this.tsmi2Update.Click += new System.EventHandler(this.tsmi2Update_Click);
            // 
            // tsmi2KuCun
            // 
            this.tsmi2KuCun.Name = "tsmi2KuCun";
            this.tsmi2KuCun.Size = new System.Drawing.Size(124, 22);
            this.tsmi2KuCun.Text = "增加库存";
            this.tsmi2KuCun.Click += new System.EventHandler(this.tsmi2KuCun_Click);
            // 
            // btn2Cha
            // 
            this.btn2Cha.Location = new System.Drawing.Point(549, 12);
            this.btn2Cha.Name = "btn2Cha";
            this.btn2Cha.Size = new System.Drawing.Size(75, 23);
            this.btn2Cha.TabIndex = 6;
            this.btn2Cha.Text = "查询";
            this.btn2Cha.UseVisualStyleBackColor = true;
            this.btn2Cha.Click += new System.EventHandler(this.btn2Cha_Click);
            // 
            // txt2Name
            // 
            this.txt2Name.Location = new System.Drawing.Point(425, 14);
            this.txt2Name.Name = "txt2Name";
            this.txt2Name.Size = new System.Drawing.Size(100, 21);
            this.txt2Name.TabIndex = 5;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dgv3Show);
            this.tabPage2.Controls.Add(this.btn3Cha);
            this.tabPage2.Controls.Add(this.txt3Name);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(768, 442);
            this.tabPage2.TabIndex = 2;
            this.tabPage2.Text = "查询食材";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgv3Show
            // 
            this.dgv3Show.AllowUserToAddRows = false;
            this.dgv3Show.AllowUserToDeleteRows = false;
            this.dgv3Show.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv3Show.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv3Show.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CridId,
            this.CridName,
            this.CridMoney,
            this.CridRepertory});
            this.dgv3Show.ContextMenuStrip = this.cmsThree;
            this.dgv3Show.Location = new System.Drawing.Point(6, 46);
            this.dgv3Show.Name = "dgv3Show";
            this.dgv3Show.ReadOnly = true;
            this.dgv3Show.RowTemplate.Height = 23;
            this.dgv3Show.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv3Show.Size = new System.Drawing.Size(756, 390);
            this.dgv3Show.TabIndex = 4;
            // 
            // CridId
            // 
            this.CridId.DataPropertyName = "CribId";
            this.CridId.HeaderText = "食材编号";
            this.CridId.Name = "CridId";
            this.CridId.ReadOnly = true;
            // 
            // CridName
            // 
            this.CridName.DataPropertyName = "CribName";
            this.CridName.HeaderText = "食材名称";
            this.CridName.Name = "CridName";
            this.CridName.ReadOnly = true;
            // 
            // CridMoney
            // 
            this.CridMoney.DataPropertyName = "CribMoney";
            this.CridMoney.HeaderText = "食材进价";
            this.CridMoney.Name = "CridMoney";
            this.CridMoney.ReadOnly = true;
            // 
            // CridRepertory
            // 
            this.CridRepertory.DataPropertyName = "CribRepertory";
            this.CridRepertory.HeaderText = "食材库存";
            this.CridRepertory.Name = "CridRepertory";
            this.CridRepertory.ReadOnly = true;
            // 
            // cmsThree
            // 
            this.cmsThree.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tmsi3ZengJia,
            this.tsmi3Del,
            this.tmsiUpdate,
            this.tsmi3JinHuo});
            this.cmsThree.Name = "contextMenuStrip1";
            this.cmsThree.Size = new System.Drawing.Size(125, 92);
            // 
            // tmsi3ZengJia
            // 
            this.tmsi3ZengJia.Name = "tmsi3ZengJia";
            this.tmsi3ZengJia.Size = new System.Drawing.Size(124, 22);
            this.tmsi3ZengJia.Text = "新增食材";
            this.tmsi3ZengJia.Click += new System.EventHandler(this.tmsi3ZengJia_Click);
            // 
            // tsmi3Del
            // 
            this.tsmi3Del.Name = "tsmi3Del";
            this.tsmi3Del.Size = new System.Drawing.Size(124, 22);
            this.tsmi3Del.Text = "删除食材";
            this.tsmi3Del.Click += new System.EventHandler(this.tsmi3Del_Click);
            // 
            // tmsiUpdate
            // 
            this.tmsiUpdate.Name = "tmsiUpdate";
            this.tmsiUpdate.Size = new System.Drawing.Size(124, 22);
            this.tmsiUpdate.Text = "修改食材";
            this.tmsiUpdate.Click += new System.EventHandler(this.tmsiUpdate_Click);
            // 
            // tsmi3JinHuo
            // 
            this.tsmi3JinHuo.Name = "tsmi3JinHuo";
            this.tsmi3JinHuo.Size = new System.Drawing.Size(124, 22);
            this.tsmi3JinHuo.Text = "增加库存";
            this.tsmi3JinHuo.Click += new System.EventHandler(this.tsmi3JinHuo_Click);
            // 
            // btn3Cha
            // 
            this.btn3Cha.Location = new System.Drawing.Point(549, 12);
            this.btn3Cha.Name = "btn3Cha";
            this.btn3Cha.Size = new System.Drawing.Size(75, 23);
            this.btn3Cha.TabIndex = 6;
            this.btn3Cha.Text = "查询";
            this.btn3Cha.UseVisualStyleBackColor = true;
            this.btn3Cha.Click += new System.EventHandler(this.btn3Cha_Click);
            // 
            // txt3Name
            // 
            this.txt3Name.Location = new System.Drawing.Point(425, 14);
            this.txt3Name.Name = "txt3Name";
            this.txt3Name.Size = new System.Drawing.Size(100, 21);
            this.txt3Name.TabIndex = 5;
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 521);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnExit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FrmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "查看菜单";
            this.Load += new System.EventHandler(this.FrmMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv1Show)).EndInit();
            this.cmsOne.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabP1.ResumeLayout(false);
            this.tabP1.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv2Show)).EndInit();
            this.cmsTwo.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv3Show)).EndInit();
            this.cmsThree.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.DataGridView dgv1Show;
        private System.Windows.Forms.TextBox txt1Name;
        private System.Windows.Forms.Button btn1Cha;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabP1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dgv2Show;
        private System.Windows.Forms.Button btn2Cha;
        private System.Windows.Forms.TextBox txt2Name;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dgv3Show;
        private System.Windows.Forms.Button btn3Cha;
        private System.Windows.Forms.TextBox txt3Name;
        private System.Windows.Forms.ContextMenuStrip cmsOne;
        private System.Windows.Forms.ToolStripMenuItem tsmiZengJia;
        private System.Windows.Forms.ToolStripMenuItem tsmiDel;
        private System.Windows.Forms.ToolStripMenuItem tsmiUpdate;
        private System.Windows.Forms.ContextMenuStrip cmsTwo;
        private System.Windows.Forms.ToolStripMenuItem tsmi2Zengjia;
        private System.Windows.Forms.ToolStripMenuItem tsmi2Del;
        private System.Windows.Forms.ToolStripMenuItem tsmi2Update;
        private System.Windows.Forms.ContextMenuStrip cmsThree;
        private System.Windows.Forms.ToolStripMenuItem tmsi3ZengJia;
        private System.Windows.Forms.ToolStripMenuItem tsmi3Del;
        private System.Windows.Forms.ToolStripMenuItem tsmi3JinHuo;
        private System.Windows.Forms.DataGridViewTextBoxColumn CaudleId;
        private System.Windows.Forms.DataGridViewTextBoxColumn CaudleName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CaudleMoney;
        private System.Windows.Forms.DataGridViewTextBoxColumn CaudleGoldenCalf;
        private System.Windows.Forms.DataGridViewTextBoxColumn CaudleRepertory;
        private System.Windows.Forms.DataGridViewTextBoxColumn DishId;
        private System.Windows.Forms.DataGridViewTextBoxColumn CribOne;
        private System.Windows.Forms.DataGridViewTextBoxColumn CribTwo;
        private System.Windows.Forms.DataGridViewTextBoxColumn DishName;
        private System.Windows.Forms.DataGridViewTextBoxColumn DishMoney;
        private System.Windows.Forms.DataGridViewTextBoxColumn name22;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name2;
        private System.Windows.Forms.DataGridViewTextBoxColumn CribOneX;
        private System.Windows.Forms.DataGridViewTextBoxColumn CribTwoX;
        private System.Windows.Forms.ToolStripMenuItem tmsiUpdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn CridId;
        private System.Windows.Forms.DataGridViewTextBoxColumn CridName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CridMoney;
        private System.Windows.Forms.DataGridViewTextBoxColumn CridRepertory;
        private System.Windows.Forms.ToolStripMenuItem tsmi2KuCun;
    }
}