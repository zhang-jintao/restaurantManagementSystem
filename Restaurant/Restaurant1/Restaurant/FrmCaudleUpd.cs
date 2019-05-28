using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Restaurant.BLL;
using Restaurant.Models;

namespace Restaurant
{
    public partial class FrmCaudleUpd : Form
    {
        DataGridViewRow row = null;
        CaudleManager cm = new CaudleManager();
        public FrmCaudleUpd(DataGridViewRow row)
        {
            InitializeComponent();
            this.row = row;
        }
        #region 检查
        public bool CheckNull()
        {
            decimal money1 = Convert.ToDecimal(this.txtMoney.Text);
            decimal money2 = Convert.ToDecimal(this.txtGoldenCalf.Text);
            bool flag = false;
            if (this.txtMoney.Text=="" && money1<money2)
            {
                MessageBox.Show("请填写文本值");
                this.txtMoney.Focus();
            }
            else if (this.txtGoldenCalf.Text=="" && money2>money1)
            {
                MessageBox.Show("请填写文本值");
                this.txtGoldenCalf.Focus();
            }
            else
            {
                flag = true;
            }
            return flag;
        }
        #endregion

        private void FrmCaudleUpd_Load(object sender, EventArgs e)
        {
            this.txtId.Text = row.Cells["CaudleId"].Value.ToString();
            this.txtName.Text = row.Cells["CaudleName"].Value.ToString();
            this.txtMoney.Text = row.Cells["CaudleMoney"].Value.ToString();
            this.txtGoldenCalf.Text = row.Cells["CaudleGoldenCalf"].Value.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(this.txtId.Text);
            decimal money1 = Convert.ToDecimal(this.txtMoney.Text);
            decimal money2 = Convert.ToDecimal(this.txtGoldenCalf.Text);
            if (CheckNull())
            {
                if (cm.UpdCaudle(id,money1,money2)>0)
                {
                    MessageBox.Show("修改成功");
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
