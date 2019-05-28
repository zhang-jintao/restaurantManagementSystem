using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Anteroom.Models;
using Anteroom.BLL;

namespace Anteroom
{
    public partial class FrmLogin : Form
    {
        #region 所有账号集合，和数据访问层对象
        /// <summary>
        /// 数据层对象
        /// </summary>
        private AdminManager admins = new AdminManager();
        /// <summary>
        /// 记住的账号密码集合
        /// </summary>
        private Dictionary<string, Admin> dic = new Dictionary<string, Admin>();
        private FrmMain fm;
        #endregion
        public FrmLogin(FrmMain fm)
        {
            InitializeComponent();
            this.fm = fm;
        }
        #region Load事件
        private void FrmLogin_Load(object sender, EventArgs e)
        {
            dic = admins.GetAllUser();
            List<Admin> lis = dic.Values.ToList();
            cboName.DataSource = lis;
            cboName.ValueMember = "LoginPwd";
            cboName.DisplayMember = "LoginId";
            if (cboName.Items.Count > 0)
            {
                cboName.SelectedIndex = 0;
                CboCommitted();
            }
        }
        #endregion
        /// <summary>
        /// 检查用户名或密码不能为空
        /// </summary>
        /// <returns></returns>
        #region 检查用户名或密码不能为空
        private bool CheckNull()
        {
            bool flag = false;
            if (cboName.Text.Equals(string.Empty))
            {
                MessageBox.Show("用户名不能为空", "提示");
                this.cboName.Focus();
            }
            else if (txtPwd.Text.Equals(string.Empty))
            {
                MessageBox.Show("密码不能为空", "提示");
                this.txtPwd.Focus();
            }
            else
            {
                flag = true;
            }
            return flag;
        }
        #endregion
        /// <summary>
        /// 单击登录按钮时触发
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        #region 单击店长登录按钮
        private void btnLogin_Click(object sender, EventArgs e)
        {
            Login();
        }
        #endregion
        /// <summary>
        /// 登录方法，参数为按钮对象
        /// </summary>
        /// <param name="sender"></param>
        #region 登录方法
        private void Login()
        {
            if (CheckNull())
            {
                Admin ad = new Admin();
                ad.LoginId = cboName.Text;
                ad.LoginPwd = txtPwd.Text;
                    
                if (admins.CheckAdmin(ad))//填写连库查询
                {
                    MessageBox.Show("登录成功", "提示");
                    //记录账号信息
                    JiLu();
                    fm.flag = true;
                    fm.QuanXian();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("用户名或密码错误", "提示");
                }
            }
        }
        #endregion
        /// <summary>
        /// 记录账号密码到本地
        /// </summary>
        #region 记录账号密码到本地
        private void JiLu()
        {
            Admin adm = new Admin();
            adm.LoginId = cboName.Text;
            if (cbJiZhu.Checked)
            {
                adm.LoginPwd = txtPwd.Text;
            }
            else
            {
                adm.LoginPwd = string.Empty;
            }
            
            if (dic.ContainsKey(adm.LoginId))
            {
                dic[adm.LoginId] = adm;
            }
            else
            {
                dic.Add(adm.LoginId, adm);
            }
            List<Admin> l = dic.Values.ToList();
            admins.AddAdminTxt(l);
        }
        #endregion


        /// <summary>
        ///  更改密码和记住密码为用户上次登录时的状态
        /// </summary>
        #region 更改密码和记住密码为用户上次登录时的状态
        private void CboCommitted()
        {
            txtPwd.Text = dic[cboName.Text].LoginPwd;
            if (!dic[cboName.Text].LoginPwd.Equals(string.Empty))
            {
                cbJiZhu.Checked = true;
            }
            else
            {
                cbJiZhu.Checked = false;
            }

        }
        #endregion

        #region 单击关闭按钮事件
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
        #region 下拉选择事件
        private bool flag = true;//防止Load发生错误的标识
        private void cboName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (flag)
            {
                return;
            }
            CboCommitted();
        }
        //鼠标单击下拉框时
        private void cboName_Click(object sender, EventArgs e)
        {
            flag = false;
        }
        #endregion
    }
}
