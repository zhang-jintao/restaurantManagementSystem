using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using Anteroom.Models;
using Anteroom.BLL;


namespace Anteroom
{
    public class Timers
    {
        public Timer tim;
        public bool flag = true;
        public int id;
        bool f = true;
        private MenuManager mm = new MenuManager();
        private CaudleManager cm = new CaudleManager();
        public Panel p;
        public Menus m;
        public Timers(){ }
        public void timerStart_Tick(object sender, EventArgs e)
        {
            if (f)
            {
                if (p.BackColor == Color.Red)
                {
                    f = true;
                    tim.Enabled = false;
                    return;
                }
                DialogResult result = MessageBox.Show(id+"号餐桌预定时间到，是否保留预定", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (DialogResult.No == result)
                {
                    p.BackColor = Color.Lime;
                    p.Controls["lb"+id+"type"].Text = "空闲";

                    foreach (KeyValuePair<int, Menu1> item in m.mens)
                    {
                        if (mm.TuiMenu(item.Value, item.Key) > 0)
                        {
                            MessageBox.Show("退菜成功，返还食材库存");
                        }
                        else
                        {
                            MessageBox.Show("退菜失败");
                            break;
                        }
                    }
                    foreach (KeyValuePair<int, Caudle> item in m.caus)
                    {
                        if (cm.TuiCaudle(item.Value, item.Key) > 0)
                        {
                            MessageBox.Show("退酒成功，返还酒水库存");
                        }
                        else
                        {
                            MessageBox.Show("退酒失败");
                            break;
                        }
                    }
                    m.mens.Clear();
                    m.caus.Clear();
                }
                tim.Enabled = false;
                flag = true;
            }
            flag = false;
        }
    }
}
