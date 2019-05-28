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
    public partial class FrmCribUpdate : Form
    {
        CribManager cm = new CribManager();
        DataGridViewRow row = null;
        public FrmCribUpdate(DataGridViewRow row)
        {
            InitializeComponent();
            this.row = row;
        }
        #region 检查文本框是否为空
        public bool CheckNull()
        {
            bool flag = false;
            string name = this.txtName.Text;
            decimal money =Convert.ToDecimal(this.txtMoney.Text);
            if (name=="")
            {
                MessageBox.Show("请填写文本");
                this.txtName.Focus();
            }
            else if (money<=0)
            {
                MessageBox.Show("请填写文本");
                this.txtMoney.Focus();
            }
            else
            {
                flag = true;
            }
            return flag;
        }
        #endregion

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (this.CheckNull())
            {
                int id =Convert.ToInt32(this.txtId.Text);
                string name = this.txtName.Text;
                decimal money = Convert.ToDecimal(this.txtMoney.Text);
                if (cm.UpdateCrib(id,name,money)>0)
                {
                    MessageBox.Show("修改食材成功");
                }
            }
        }

        #region 读取DGV中整行数据
        public void DuQuDGV()
        {
            txtId.Text = row.Cells["CridId"].Value.ToString();
            txtName.Text = row.Cells["CridName"].Value.ToString();
            txtMoney.Text = row.Cells["CridMoney"].Value.ToString();
            
        }
        #endregion

        private void FrmCribUpdate_Load(object sender, EventArgs e)
        {
            DuQuDGV();
        }

    }
}
