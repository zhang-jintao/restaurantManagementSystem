namespace Restaurant
{
    partial class FrmCaudleUpdate
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnZengJia = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtXinZeng = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "酒水名称：";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(83, 12);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(100, 21);
            this.txtName.TabIndex = 1;
            // 
            // btnZengJia
            // 
            this.btnZengJia.Location = new System.Drawing.Point(24, 67);
            this.btnZengJia.Name = "btnZengJia";
            this.btnZengJia.Size = new System.Drawing.Size(75, 23);
            this.btnZengJia.TabIndex = 2;
            this.btnZengJia.Text = "增   加";
            this.btnZengJia.UseVisualStyleBackColor = true;
            this.btnZengJia.Click += new System.EventHandler(this.btnZengJia_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "新增库存：";
            // 
            // txtXinZeng
            // 
            this.txtXinZeng.Location = new System.Drawing.Point(83, 39);
            this.txtXinZeng.Name = "txtXinZeng";
            this.txtXinZeng.Size = new System.Drawing.Size(100, 21);
            this.txtXinZeng.TabIndex = 1;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(115, 66);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "关   闭";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // FrmCaudleUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(206, 102);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnZengJia);
            this.Controls.Add(this.txtXinZeng);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCaudleUpdate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "增加酒水库存";
            this.Load += new System.EventHandler(this.FrmCaudleUpdate_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnZengJia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtXinZeng;
        private System.Windows.Forms.Button btnClose;
    }
}