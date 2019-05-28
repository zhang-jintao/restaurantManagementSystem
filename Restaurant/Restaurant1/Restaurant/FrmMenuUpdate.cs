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

namespace Restaurant
{
    public partial class FrmMenuUpdate : Form
    {
        DataGridViewRow row = null;
        MenuManager mm = new MenuManager();
        public FrmMenuUpdate(DataGridViewRow row)
        {
            InitializeComponent();
            this.row = row;
        }
        #region 检查
        public bool CheckNull()
        {
            decimal money = Convert.ToDecimal(this.txtMoney.Text);
            double dou1 = Convert.ToDouble(this.txtCribOneX.Text);
            double dou2 = Convert.ToDouble(this.txtCribTwoX.Text);
            bool flag = false;
            if (this.txtMoney.Text=="" && money<=0)
            {
                MessageBox.Show("请填写正确");
                this.txtMoney.Focus();
            }
            else if (this.txtCribOneX.Text=="" && dou1<=0)
            {
                MessageBox.Show("请正确填写");
                this.txtCribOneX.Focus();
            }
            else if (this.txtCribTwoX.Text=="" && dou2<=0)
            {
                MessageBox.Show("请正确填写");
                this.txtCribTwoX.Focus();
            }
            else
            {
                flag = true;
            }
            return flag;
        }
        #endregion
        #region 修改
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int k = Convert.ToInt32(row.Cells["DishId"].Value.ToString());
            decimal money = Convert.ToDecimal(this.txtMoney.Text);
            double dou1 = Convert.ToDouble(this.txtCribOneX.Text);
            double dou2 = Convert.ToDouble(this.txtCribTwoX.Text);
            if (CheckNull())
            {
                if (mm.UpdateMenu(k,money,dou1,dou2)>0)
                {
                    MessageBox.Show("修改菜品信息成功");
                }
            }
        }
        #endregion
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// 加载文本框值
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmMenuUpdate_Load(object sender, EventArgs e)
        {
            this.txtMoney.Text = row.Cells["DishMoney"].Value.ToString();
            this.txtCribOneX.Text = row.Cells["CribOneX"].Value.ToString();
            this.txtCribTwoX.Text = row.Cells["CribTwoX"].Value.ToString();
            this.txtName.Text = row.Cells["DishName"].Value.ToString();
            this.txtCribOne.Text = row.Cells["CribOne"].Value.ToString();
            this.txtCribTwo.Text = row.Cells["CribTwo"].Value.ToString();
        }




    }
}
