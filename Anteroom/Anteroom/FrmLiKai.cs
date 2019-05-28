using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Anteroom.Common;
using Anteroom.BLL;
using Anteroom.Models;

namespace Anteroom
{
    public partial class FrmLiKai : Form
    {
        Leave l = new Leave();
        AdminManager am = new AdminManager();
        public FrmLiKai()
        {
            InitializeComponent();
            
        }
        public FrmMain fm;
        public string name;
        public bool flag;//是否为第二次
        private void button1_Click(object sender, EventArgs e)
        {
            LoadFrm();
            
        }
        #region 初始化窗体
        private void LoadFrm()
        {
            if (flag)
            {
                if (txtpwd.Text.Equals(name))
                {
                    l.DeleteLeave();
                    fm.pb.Visible = false;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("密码错误");
                    return;
                }
            }
            else
            {
                if (txtpwd.Text.Equals(""))
                {
                    MessageBox.Show("请设置密码");
                    return;
                }
                DialogResult result = MessageBox.Show("确认离开吗", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    PbLoad();
                }
            }
        }
        private void PbLoad()
        {
            label1.Text = "请输入密码";
            if (flag)
            {
                 name = l.ReadLeave();
            }
            else
            {
                name = txtpwd.Text;
            }
            txtpwd.Text = string.Empty;
            fm.pb.Location = new System.Drawing.Point(0, 0);
            fm.pb.Size = new System.Drawing.Size(fm.ClientSize.Width, fm.ClientSize.Height);
            fm.pb.Visible = true;
            flag = true;
            btnAdmin.Visible = true;
            l.AddLeave(name);
        }
        #endregion

        private void FrmLiKai_Load(object sender, EventArgs e)
        {
            if (flag)
            {
                PbLoad();
            }
            else
            {
                label1.Text = "请设置密码";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lbname.Visible = true;
            lbpwd.Visible = true;
            txtname.Visible = true;
            txtpwd2.Visible = true;
            btnlogin.Visible = true;
        }
        private bool CheckNull()
        {
            bool flag = true;
            if (txtname.Text.Equals(string.Empty)||txtpwd2.Text.Equals(string.Empty))
            {
                flag = false;
                MessageBox.Show("请填写账号密码");
            }
            return flag;
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            if (!CheckNull())
            {
                return;
            }
            Admin ad = new Admin();
            ad.LoginId = txtname.Text;
            ad.LoginPwd = txtpwd2.Text;
            if (am.CheckAdmin(ad))
            {
                l.DeleteLeave();
                fm.pb.Visible = false;
                this.Close();
            }
            else
            {
                MessageBox.Show("账号或密码错误");
            }
        }
    }
}
