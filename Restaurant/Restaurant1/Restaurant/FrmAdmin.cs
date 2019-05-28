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
    public partial class FrmAdmin : Form
    {
        public FrmAdmin()
        {
            InitializeComponent();
        }
        //关闭窗口
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        AdminManager am = new AdminManager();
        private void FrmAdmin_Load(object sender, EventArgs e)
        {
            List<Admin> list = new List<Admin>();
            
            list = am.GetAllLoginId();
            this.cboUser.DataSource = list;
            this.cboUser.DisplayMember = "LoginId";
        }
        /// <summary>
        /// 修改点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e">修改点击事件</param>
        private void btnOk_Click(object sender, EventArgs e)
        {
            if (CheckNull())
            {
                Admin ad = new Admin();
                ad.LoginId = this.cboUser.Text;
                ad.LoginPwd = this.txtPwd1.Text;
                if (am.UpdatePwd(ad)>0)
                {
                    MessageBox.Show("修改成功");
                    this.cboUser.Text = "";
                    this.txtPwd1.Text = "";
                    this.txtPwd2.Text = "";
                }
                else
                {
                    MessageBox.Show("修改失败");
                }
            }
            
        }
        /// <summary>
        /// 非空验证
        /// </summary>
        /// <returns>非空验证</returns>
        private bool CheckNull()
        {
            bool flag = true;
            if (this.cboUser.SelectedIndex==-1)
            {
                MessageBox.Show("请选择要修改的账户");
                this.cboUser.Focus();
                flag=false;
            }
            else if(this.txtPwd1.Text.Equals(""))
            {
                MessageBox.Show("请填写新的密码");
                this.txtPwd1.Focus();
                flag = false;
            }
            else if (this.txtPwd2.Text.Equals(""))
            {
                MessageBox.Show("请填写确认密码");
                this.txtPwd2.Focus();
                flag = false;
            }
            else if (this.txtPwd1.Text!=this.txtPwd2.Text)
            {
                MessageBox.Show("两次填写密码不一致");
                this.txtPwd2.Focus();
                flag = false;
            }
            return flag;
        }
    }
}
