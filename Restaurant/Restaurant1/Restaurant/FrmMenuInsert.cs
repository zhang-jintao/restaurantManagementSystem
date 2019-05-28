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
    public partial class FrmMenuInsert : Form
    {
        private int no1=0;
        private int no2=0;
        public FrmMenuInsert()
        {
            InitializeComponent();
        }
        MenuManager mm = new MenuManager();
        private void FrmMenuInsert_Load(object sender, EventArgs e)
        {
            List<Crib> list = mm.Crib();
            this.cboCribOne.DataSource = list;
            this.cboCribOne.DisplayMember = "CribName";
            List<Crib> lis = mm.Crib();
            this.cboCribTwo.DataSource = lis;
            this.cboCribTwo.DisplayMember = "CribName";
        }
        #region 根据食材查询编号
        public void CribId()
        {
            string name1 = this.cboCribOne.Text;
            string name2 = this.cboCribTwo.Text;
            this.no1 = mm.CribId(name1);
            this.no2 = mm.CribId(name2);
        }
        #endregion



        #region 检查
        public bool CheckNull()
        {
            decimal money = Convert.ToDecimal(this.txtMoney.Text);
            double no1 = Convert.ToDouble(this.txtCribOne.Text);
            double no2 = Convert.ToDouble(this.txtCribTwo.Text);
            bool flag = false;
            if (this.txtName.Text=="")
            {
                MessageBox.Show("请填写菜品名");
                this.txtName.Focus();
            }
            else if (this.txtMoney.Text=="" && money<=0)
            {
                MessageBox.Show("请填写菜品价格");
                this.txtMoney.Focus();
            }
            else if (this.txtCribOne.Text=="" && no1<=0)
            {
                MessageBox.Show("请填写菜品分量");
                this.txtCribOne.Focus();
            }
            else if (this.txtCribTwo.Text=="" && no2<=0)
            {
                MessageBox.Show("请填写菜品分量");
                this.txtCribTwo.Focus();
            }
            else
            {
                flag = true;
            }
            return flag;
        }
        #endregion
        #region 新增菜品
        private void btnInsert_Click(object sender, EventArgs e)
        {
            CribId();
            decimal money = Convert.ToDecimal(this.txtMoney.Text);
            double no11 = Convert.ToDouble(this.txtCribOne.Text);
            double no22 = Convert.ToDouble(this.txtCribTwo.Text);
            string name = this.txtName.Text;
            if (CheckNull())
            {
                if (mm.InsertMneu(name,money,no1,no2,no11,no22)>0)
                {
                    MessageBox.Show("添加菜品成功");
                }
            }
        }       
        #endregion

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
