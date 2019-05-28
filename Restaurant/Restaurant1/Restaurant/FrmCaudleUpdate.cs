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
    public partial class FrmCaudleUpdate : Form
    {
        DataGridViewRow row = null;
        CaudleManager cm = new CaudleManager();
        public FrmCaudleUpdate(DataGridViewRow row)
        {
            InitializeComponent();
            this.row = row;
        }

        private void FrmCaudleUpdate_Load(object sender, EventArgs e)
        {
            this.txtName.Text = row.Cells["CaudleName"].Value.ToString();
        }

        private void btnZengJia_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(row.Cells["CaudleId"].Value.ToString());
            int no = Convert.ToInt32(this.txtXinZeng.Text);
            if (this.txtXinZeng.Text!="" && no>0)
            {
                if (cm.InsertCaudleUpdate(no,id)>0)
                {
                    MessageBox.Show("增加库存成功");
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
