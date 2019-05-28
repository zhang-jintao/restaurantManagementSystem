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
    public partial class FrmSee : Form
    {
        public FrmSee()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 关闭
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        TurnoverManager tm = new TurnoverManager();
        private void btnSelect_Click(object sender, EventArgs e)
        {
            if (this.cboXuan.SelectedIndex==1)
            {
                Caudle();
                SumMoney();
            }
            else if (this.cboXuan.SelectedIndex==2)
            {
                Menus();
                SumMoney();
            }
            else
            {
                MessageBox.Show("请选择要查询的项");
            }
        }

        private void FrmSee_Load(object sender, EventArgs e)
        {
            this.cboXuan.SelectedIndex = 0;
        }
        public void Caudle()
        {
            DateTime date1 = Convert.ToDateTime(this.dtpStart.Text);
            DateTime date2 = Convert.ToDateTime(this.dtpStop.Text);
            List<Turnover> list = tm.GetAllCaudleTurnOver(date1, date2);
            this.dgvShow.DataSource = list;
        }
        public void Menus()
        {
            DateTime date1 = Convert.ToDateTime(this.dtpStart.Text);
            DateTime date2 = Convert.ToDateTime(this.dtpStop.Text);
            List<Turnover> list = tm.GetAllMenuTurnOver(date1,date2);
            this.dgvShow.DataSource = list;
        }
        /// <summary>
        /// 计算查询出的所有行总利润
        /// </summary>
        private void SumMoney()
        {
            decimal sum = 0;
            foreach (DataGridViewRow row in dgvShow.Rows)
            {
                sum += Convert.ToInt32(row.Cells["AllMoney"].Value);
            }
            if (sum==0)
            {
                label4.Visible = false;
                lbMoney.Visible = false;
            }
            else
            {
                lbMoney.Visible = true;
                label4.Visible = true;
            }
            lbMoney.Text = sum.ToString()+" 元";
            
        }
    }
}
