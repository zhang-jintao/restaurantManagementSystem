using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Anteroom
{
    public partial class FrmUpdateTable : Form
    {
        private FrmMain fm;
        private bool flag;
        public FrmUpdateTable()
        {
            InitializeComponent();
        }
        public FrmUpdateTable(FrmMain fm,bool flag)
        {
            InitializeComponent();
            this.fm = fm;
            this.flag = flag;
        }

        private void FrmUpdateTable_Load(object sender, EventArgs e)
        {
            if (flag)
            {
                label1.Text = "原桌数";
                label2.Text = "现桌数";
                txtYuan.Text = fm.TableCount.ToString();
            }
            else
            {
                label1.Text = "原包厢数";
                label2.Text = "现包厢数";
                txtYuan.Text = fm.BaoCount.ToString();
            }
        }
        private bool CheckNull()
        {
            bool flag = true;
            if (txtNow.Text.Equals(string.Empty))
            {
                flag = false;
                MessageBox.Show("不能为空");
            }
            return flag;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (CheckNull())
            {
                int k = 0;
                try
                {
                    k = Convert.ToInt32(txtNow.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("请输入数字");
                    return;
                }
                if (k<0)
                {
                    MessageBox.Show("不能为负数");
                    return;
                }
                DialogResult result = MessageBox.Show("必须重启才能保存修改，是否重新启动？","退出提示",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                if (result==DialogResult.No)
                {
                    MessageBox.Show("取消操作");
                    return;
                }
                for (int i = 1; i <= fm.pns.Count; i++)
                {
                    if (fm.pns[i].BackColor == Color.Red)
                    {
                        MessageBox.Show("必须全部客离才能执行此操作!");
                        return;
                    }
                }
                if (flag)
                {
                    Menus.DeleteTable(k,fm.TableCount);
                    fm.TableCount = k;
                }
                else
                {
                    Menus.DeleteTBao(k,fm.BaoCount,fm.TableCount);
                    fm.BaoCount = k;
                }
                fm.AddBao();
                fm.TabLoad(fm.pns.Values.ToList());
                Application.Exit();
            }
        }

    }
}
