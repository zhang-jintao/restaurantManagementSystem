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

namespace Restaurant
{
    public partial class FrmMain : Form
    {
        private bool flag;//是否为老板登录
        public FrmMain(bool flag)
        {
            InitializeComponent();
            this.flag = flag;
        }


        #region 窗体加载事件
        /// <summary>
        /// 窗体加载方法
        /// </summary>
        private void FormLoad()
        {
            this.tsmiUpdateAdmin.Enabled = flag;
        }
        /// <summary>
        /// 窗体Load事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmMain_Load(object sender, EventArgs e)
        {
            FormLoad();
        }
        #endregion

        #region 菜单项
        #region 查看营业额
        private void tsmiSee_Click(object sender, EventArgs e)
        {
            FrmSee fs = new FrmSee();
            fs.MdiParent = this;
            fs.Show();
        }
        #endregion
        #region 修改菜单信息
        private void tsmiUpdateMoney_Click(object sender, EventArgs e)
        {
            FrmMenu fm = new FrmMenu();
            fm.MdiParent = this;
            fm.Show();
        }
        #endregion
        #region 修改账号信息
        private void tsmiUpdateAdmin_Click(object sender, EventArgs e)
        {
            FrmAdmin fa = new FrmAdmin();
            fa.MdiParent = this;
            fa.Show();
        }
        #endregion
        #region 关闭
        private void tsmiExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion
        #region 关于
        /// <summary>
        /// 关于
        /// </summary>
        private void tsmiGuanYu_Click(object sender, EventArgs e)
        {
            MessageBox.Show("张金涛，赵凯制作","制作提示",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
        #endregion
        #endregion
    }
}
