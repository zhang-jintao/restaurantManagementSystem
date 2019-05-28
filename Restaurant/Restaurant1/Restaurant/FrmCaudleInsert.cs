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
    public partial class FrmCaudleInsert : Form
    {
        public FrmCaudleInsert()
        {
            InitializeComponent();
        }
        CaudleManager cm = new CaudleManager();
        #region 检查
        public bool CheckNull()
        {
            decimal money1= Convert.ToDecimal(this.txtMoney.Text);
            decimal money2 = Convert.ToDecimal(this.txtGoldenCalf.Text);
            int k = Convert.ToInt32(this.txtRepertory.Text);
            bool flag = false;
            if (this.txtName.Text=="")
            {
                MessageBox.Show("请填写名称");
                this.txtName.Focus();
            }
            else if (this.txtMoney.Text=="" && money1<=0 )
            {
                MessageBox.Show("请填写酒水价格");
                this.txtMoney.Focus();
            }
            else if (this.txtGoldenCalf.Text=="" && money2<=0 &&money2>money1)
            {
                MessageBox.Show("请填写酒水进价");
                this.txtGoldenCalf.Focus();
            }
            else if (this.txtRepertory.Text=="" && k<=0)
            {
                MessageBox.Show("请填写酒水库存");
                this.txtRepertory.Focus();
            }
            else
            {
                flag = true;
            }
            return flag;
        }
        #endregion
        #region 新增酒水
        public void InsertCaudle()
        {
            string name = this.txtName.Text;
            decimal money1 = Convert.ToDecimal(this.txtMoney.Text);
            decimal money2 = Convert.ToDecimal(this.txtGoldenCalf.Text);
            int no = Convert.ToInt32(this.txtRepertory.Text);
            if (CheckNull())
            {
                if (cm.InsertCaudle(name, money1, money2, no)>0)
                {
                    MessageBox.Show("添加酒水成功") ;
                }
            }
        }
        #endregion

        private void btnInsert_Click(object sender, EventArgs e)
        {
            InsertCaudle();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
