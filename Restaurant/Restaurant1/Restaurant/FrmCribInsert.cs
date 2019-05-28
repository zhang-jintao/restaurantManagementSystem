using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Restaurant.Models;
using Restaurant.BLL;

namespace Restaurant
{
    public partial class FrmCribInsert : Form
    {
        public FrmCribInsert()
        {
            InitializeComponent();
        }
        CribManager cm = new CribManager();
        private void btnInsert_Click(object sender, EventArgs e)
        {
            Insert();
        }
        /// <summary>
        /// 添加食材
        /// </summary>
        public void Insert()
        {
            string name = this.txtName.Text;
            decimal money = Convert.ToDecimal(this.txtMoney.Text);
            double kucun = Convert.ToDouble(this.txtKuCun.Text);
            if (CheckNull())
            {
                //检查是否存在食材
                if (cm.CheckName(name)>0)
                {
                    MessageBox.Show("已存在食材");
                    return;
                }
                if (cm.InsertCrib(name,money,kucun)>0)
                {
                    MessageBox.Show("添加食材成功");
                    this.txtKuCun.Text = "";
                    this.txtMoney.Text = "";
                    this.txtName.Text = "";
                }
            }
        }
        /// <summary>
        /// 检查添加信息
        /// </summary>
        /// <returns></returns>
        public bool CheckNull()
        {
            bool flag = true;
            if (this.txtName.Text=="")
            {
                flag = false;
                MessageBox.Show("文本框不能为空");
                this.txtName.Focus();
            }
            else if (this.txtMoney.Text=="")
            {
                flag = false;
                MessageBox.Show("文本框不能为空");
                this.txtMoney.Focus();
            }
            else if (this.txtKuCun.Text=="")
            {
                flag = false;
                MessageBox.Show("文本框不能为空");
                this.txtKuCun.Focus();
            }
            decimal money = Convert.ToDecimal(this.txtMoney.Text);
            double kucun = Convert.ToDouble(this.txtKuCun.Text);
            if (!(money>0))
            {
                MessageBox.Show("进价必须大于0");
                this.txtMoney.Focus();
                flag = false;
            }
            else if (!(kucun>0))
            {
                MessageBox.Show("库存必须大于0");
                this.txtKuCun.Focus();
                flag = false;
            }
            return flag;
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
