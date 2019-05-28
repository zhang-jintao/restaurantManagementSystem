namespace Anteroom
{
    partial class FrmDian
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
            this.cboTables = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.num1Count = new System.Windows.Forms.NumericUpDown();
            this.btn1Cha = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txt1Name = new System.Windows.Forms.TextBox();
            this.dgv1Show = new System.Windows.Forms.DataGridView();
            this.DishId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DishName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DishMoney = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CribOne = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CribTwo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CribOneX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CribTwoX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MenuCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btn2Add = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.num2Count = new System.Windows.Forms.NumericUpDown();
            this.btn2Cha = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txt2Name = new System.Windows.Forms.TextBox();
            this.dgv2Show = new System.Windows.Forms.DataGridView();
            this.CaudleId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CaudleName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CaudleMoney = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CaudleGoldenCalf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CaudleRepertory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CauCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.lvShow = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiTui = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num1Count)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1Show)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num2Count)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv2Show)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cboTables
            // 
            this.cboTables.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTables.FormattingEnabled = true;
            this.cboTables.Location = new System.Drawing.Point(226, 37);
            this.cboTables.Name = "cboTables";
            this.cboTables.Size = new System.Drawing.Size(195, 20);
            this.cboTables.TabIndex = 0;
            this.cboTables.SelectedIndexChanged += new System.EventHandler(this.cboTables_SelectedIndexChanged);
            this.cboTables.Click += new System.EventHandler(this.cboTables_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(120, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "请选择桌号：";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 60);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(530, 363);
            this.tabControl1.TabIndex = 15;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnAdd);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.num1Count);
            this.tabPage1.Controls.Add(this.btn1Cha);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.txt1Name);
            this.tabPage1.Controls.Add(this.dgv1Show);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(522, 337);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "菜品";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(354, 275);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 24;
            this.btnAdd.Text = "添加";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(126, 280);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 23;
            this.label4.Text = "数量：";
            // 
            // num1Count
            // 
            this.num1Count.Location = new System.Drawing.Point(205, 278);
            this.num1Count.Name = "num1Count";
            this.num1Count.ReadOnly = true;
            this.num1Count.Size = new System.Drawing.Size(116, 21);
            this.num1Count.TabIndex = 22;
            // 
            // btn1Cha
            // 
            this.btn1Cha.Location = new System.Drawing.Point(354, 38);
            this.btn1Cha.Name = "btn1Cha";
            this.btn1Cha.Size = new System.Drawing.Size(75, 23);
            this.btn1Cha.TabIndex = 21;
            this.btn1Cha.Text = "查询";
            this.btn1Cha.UseVisualStyleBackColor = true;
            this.btn1Cha.Click += new System.EventHandler(this.btn1Cha_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(135, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 20;
            this.label3.Text = "菜名：";
            // 
            // txt1Name
            // 
            this.txt1Name.Location = new System.Drawing.Point(205, 40);
            this.txt1Name.Name = "txt1Name";
            this.txt1Name.Size = new System.Drawing.Size(116, 21);
            this.txt1Name.TabIndex = 19;
            // 
            // dgv1Show
            // 
            this.dgv1Show.AllowUserToAddRows = false;
            this.dgv1Show.AllowUserToDeleteRows = false;
            this.dgv1Show.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv1Show.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv1Show.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DishId,
            this.DishName,
            this.DishMoney,
            this.CribOne,
            this.CribTwo,
            this.CribOneX,
            this.CribTwoX,
            this.MenuCount});
            this.dgv1Show.Location = new System.Drawing.Point(23, 74);
            this.dgv1Show.Name = "dgv1Show";
            this.dgv1Show.ReadOnly = true;
            this.dgv1Show.RowTemplate.Height = 23;
            this.dgv1Show.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv1Show.Size = new System.Drawing.Size(473, 189);
            this.dgv1Show.TabIndex = 18;
            // 
            // DishId
            // 
            this.DishId.DataPropertyName = "DishId";
            this.DishId.HeaderText = "编号";
            this.DishId.Name = "DishId";
            this.DishId.ReadOnly = true;
            // 
            // DishName
            // 
            this.DishName.DataPropertyName = "DishName";
            this.DishName.HeaderText = "菜名";
            this.DishName.Name = "DishName";
            this.DishName.ReadOnly = true;
            // 
            // DishMoney
            // 
            this.DishMoney.DataPropertyName = "DishMoney";
            this.DishMoney.HeaderText = "单价";
            this.DishMoney.Name = "DishMoney";
            this.DishMoney.ReadOnly = true;
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
            // CribOneX
            // 
            this.CribOneX.DataPropertyName = "CribOneX";
            this.CribOneX.HeaderText = "CribOneX";
            this.CribOneX.Name = "CribOneX";
            this.CribOneX.ReadOnly = true;
            this.CribOneX.Visible = false;
            // 
            // CribTwoX
            // 
            this.CribTwoX.DataPropertyName = "CribTwoX";
            this.CribTwoX.HeaderText = "CribTwoX";
            this.CribTwoX.Name = "CribTwoX";
            this.CribTwoX.ReadOnly = true;
            this.CribTwoX.Visible = false;
            // 
            // MenuCount
            // 
            this.MenuCount.DataPropertyName = "Count";
            this.MenuCount.HeaderText = "Count";
            this.MenuCount.Name = "MenuCount";
            this.MenuCount.ReadOnly = true;
            this.MenuCount.Visible = false;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btn2Add);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.num2Count);
            this.tabPage2.Controls.Add(this.btn2Cha);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.txt2Name);
            this.tabPage2.Controls.Add(this.dgv2Show);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(522, 337);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "酒水";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btn2Add
            // 
            this.btn2Add.Location = new System.Drawing.Point(354, 275);
            this.btn2Add.Name = "btn2Add";
            this.btn2Add.Size = new System.Drawing.Size(75, 23);
            this.btn2Add.TabIndex = 31;
            this.btn2Add.Text = "添加";
            this.btn2Add.UseVisualStyleBackColor = true;
            this.btn2Add.Click += new System.EventHandler(this.btn2Add_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(126, 280);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 30;
            this.label2.Text = "数量：";
            // 
            // num2Count
            // 
            this.num2Count.Location = new System.Drawing.Point(205, 278);
            this.num2Count.Name = "num2Count";
            this.num2Count.ReadOnly = true;
            this.num2Count.Size = new System.Drawing.Size(116, 21);
            this.num2Count.TabIndex = 29;
            // 
            // btn2Cha
            // 
            this.btn2Cha.Location = new System.Drawing.Point(354, 38);
            this.btn2Cha.Name = "btn2Cha";
            this.btn2Cha.Size = new System.Drawing.Size(75, 23);
            this.btn2Cha.TabIndex = 28;
            this.btn2Cha.Text = "查询";
            this.btn2Cha.UseVisualStyleBackColor = true;
            this.btn2Cha.Click += new System.EventHandler(this.btn2Cha_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(135, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 27;
            this.label6.Text = "酒名：";
            // 
            // txt2Name
            // 
            this.txt2Name.Location = new System.Drawing.Point(205, 40);
            this.txt2Name.Name = "txt2Name";
            this.txt2Name.Size = new System.Drawing.Size(116, 21);
            this.txt2Name.TabIndex = 26;
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
            this.CaudleRepertory,
            this.CauCount});
            this.dgv2Show.Location = new System.Drawing.Point(23, 74);
            this.dgv2Show.Name = "dgv2Show";
            this.dgv2Show.ReadOnly = true;
            this.dgv2Show.RowTemplate.Height = 23;
            this.dgv2Show.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv2Show.Size = new System.Drawing.Size(473, 189);
            this.dgv2Show.TabIndex = 25;
            // 
            // CaudleId
            // 
            this.CaudleId.DataPropertyName = "CaudleId";
            this.CaudleId.HeaderText = "编号";
            this.CaudleId.Name = "CaudleId";
            this.CaudleId.ReadOnly = true;
            // 
            // CaudleName
            // 
            this.CaudleName.DataPropertyName = "CaudleName";
            this.CaudleName.HeaderText = "酒水";
            this.CaudleName.Name = "CaudleName";
            this.CaudleName.ReadOnly = true;
            // 
            // CaudleMoney
            // 
            this.CaudleMoney.DataPropertyName = "CaudleMoney";
            this.CaudleMoney.HeaderText = "单价";
            this.CaudleMoney.Name = "CaudleMoney";
            this.CaudleMoney.ReadOnly = true;
            // 
            // CaudleGoldenCalf
            // 
            this.CaudleGoldenCalf.DataPropertyName = "CaudleGoldenCalf";
            this.CaudleGoldenCalf.HeaderText = "CaudleGoldenCalf";
            this.CaudleGoldenCalf.Name = "CaudleGoldenCalf";
            this.CaudleGoldenCalf.ReadOnly = true;
            this.CaudleGoldenCalf.Visible = false;
            // 
            // CaudleRepertory
            // 
            this.CaudleRepertory.DataPropertyName = "CaudleRepertory";
            this.CaudleRepertory.HeaderText = "CaudleRepertory";
            this.CaudleRepertory.Name = "CaudleRepertory";
            this.CaudleRepertory.ReadOnly = true;
            this.CaudleRepertory.Visible = false;
            // 
            // CauCount
            // 
            this.CauCount.DataPropertyName = "Count";
            this.CauCount.HeaderText = "Count";
            this.CauCount.Name = "CauCount";
            this.CauCount.ReadOnly = true;
            this.CauCount.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(127, 449);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 28;
            this.label5.Text = "已点：";
            // 
            // lvShow
            // 
            this.lvShow.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lvShow.ContextMenuStrip = this.contextMenuStrip1;
            this.lvShow.FullRowSelect = true;
            this.lvShow.Location = new System.Drawing.Point(226, 429);
            this.lvShow.Name = "lvShow";
            this.lvShow.Size = new System.Drawing.Size(253, 211);
            this.lvShow.TabIndex = 27;
            this.lvShow.UseCompatibleStateImageBehavior = false;
            this.lvShow.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "名称";
            this.columnHeader1.Width = 94;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "数量";
            this.columnHeader2.Width = 82;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "价格";
            this.columnHeader3.Width = 73;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiTui});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(101, 26);
            // 
            // tsmiTui
            // 
            this.tsmiTui.Name = "tsmiTui";
            this.tsmiTui.Size = new System.Drawing.Size(100, 22);
            this.tsmiTui.Text = "退菜";
            this.tsmiTui.Click += new System.EventHandler(this.tsmiTui_Click);
            // 
            // FrmDian
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 656);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lvShow);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboTables);
            this.Name = "FrmDian";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "点餐主页";
            this.Load += new System.EventHandler(this.FrmDian_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num1Count)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1Show)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num2Count)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv2Show)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboTables;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown num1Count;
        private System.Windows.Forms.Button btn1Cha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt1Name;
        private System.Windows.Forms.DataGridView dgv1Show;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListView lvShow;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button btn2Add;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown num2Count;
        private System.Windows.Forms.Button btn2Cha;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt2Name;
        private System.Windows.Forms.DataGridView dgv2Show;
        private System.Windows.Forms.DataGridViewTextBoxColumn DishId;
        private System.Windows.Forms.DataGridViewTextBoxColumn DishName;
        private System.Windows.Forms.DataGridViewTextBoxColumn DishMoney;
        private System.Windows.Forms.DataGridViewTextBoxColumn CribOne;
        private System.Windows.Forms.DataGridViewTextBoxColumn CribTwo;
        private System.Windows.Forms.DataGridViewTextBoxColumn CribOneX;
        private System.Windows.Forms.DataGridViewTextBoxColumn CribTwoX;
        private System.Windows.Forms.DataGridViewTextBoxColumn MenuCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn CaudleId;
        private System.Windows.Forms.DataGridViewTextBoxColumn CaudleName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CaudleMoney;
        private System.Windows.Forms.DataGridViewTextBoxColumn CaudleGoldenCalf;
        private System.Windows.Forms.DataGridViewTextBoxColumn CaudleRepertory;
        private System.Windows.Forms.DataGridViewTextBoxColumn CauCount;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmiTui;
    }
}