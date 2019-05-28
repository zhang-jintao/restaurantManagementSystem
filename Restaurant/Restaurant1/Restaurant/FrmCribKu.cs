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
    public partial class FrmCribKu : Form
    {
        CribManager cm = new CribManager();
        DataGridViewRow row = null;
        private int k = 0;
        public FrmCribKu(DataGridViewRow row)
        {
            InitializeComponent();
            this.row = row;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #region 读DGV行数据
        public void DuQuDGV()
        {
            this.txtName.Text = row.Cells["CridName"].Value.ToString();
            k =Convert.ToInt32(row.Cells["CridId"].Value.ToString());
        }
        #endregion

        private void FrmCribKu_Load(object sender, EventArgs e)
        {
            DuQuDGV();
        }
        #region 检查文本框值是否合格
        public bool CheckNull()
        {
            double dou = Convert.ToDouble(this.txtDou.Text);
            bool flag = false;
            if (this.txtDou.Text=="")
            {
                MessageBox.Show("请填写数值");
            }
            else if (dou<=0)
            {
                MessageBox.Show("请填写正确数值");
            }
            else
            {
                flag = true;
            }
            return flag;
        }
        #endregion

        private void btnOk_Click(object sender, EventArgs e)
        {
            double dou = Convert.ToDouble(this.txtDou.Text);
            string name = this.txtName.Text;
            if (CheckNull())
            {
                if (cm.ZengJia(k,dou)>0)
                {
                    MessageBox.Show("增加食材成功");
                }
            }
        }
    }
}
