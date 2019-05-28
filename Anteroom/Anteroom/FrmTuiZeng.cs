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
    public partial class FrmTuiZeng : Form
    {
        #region 字段
        private FrmMain fm;
        private int key;
        private MenuManager mm = new MenuManager();
        private CaudleManager cm = new CaudleManager();
        private Dictionary<int, Menu1> me = new Dictionary<int, Menu1>();
        private Dictionary<int,Caudle> cau=new Dictionary<int,Caudle>();
        #endregion
        public FrmTuiZeng(int key,FrmMain fm)
        {
            InitializeComponent();
            this.fm = fm;
            this.key = key;
        }
        #region 菜单初始化
        #region 初始化菜单
        private void MenuLoad()
        {
            lv1Show.Items.Clear();
            me=mm.GetAllMenu("");
            cau=cm.GetAllCaudle("");
            foreach (Menu1 m1 in me.Values)
            {
                ListViewItem it = new ListViewItem(m1.DishName);
                it.SubItems.Add(m1.DishMoney.ToString());
                lv1Show.Items.Add(it);
            }
            foreach (Caudle cd in cau.Values)
            {
                ListViewItem it = new ListViewItem(cd.CaudleName);
                it.SubItems.Add(cd.CaudleMoney.ToString());
                lv1Show.Items.Add(it);
            }
        }
        #endregion
        #region 已点初始化
        public void YiDianLoad()
        {
            lv2Show.Items.Clear();
            foreach (Menu1 m1 in fm.mes[key].mens.Values)
            {
                ListViewItem it = new ListViewItem(m1.DishName);
                it.SubItems.Add(m1.Count.ToString());
                it.SubItems.Add((m1.Count*m1.DishMoney).ToString());
                lv2Show.Items.Add(it);
            }
            foreach (Caudle ca in fm.mes[key].caus.Values)
            {
                ListViewItem it = new ListViewItem(ca.CaudleName);
                it.SubItems.Add(ca.Count.ToString());
                it.SubItems.Add((ca.Count*ca.CaudleMoney).ToString());
                lv2Show.Items.Add(it);
            }
        }
        #endregion
        private void FrmTuiZeng_Load(object sender, EventArgs e)
        {
            txtName.Text = key + " 号桌";
            MenuLoad();
            YiDianLoad();
        }
        #endregion
        #region 添加到菜单
        private void button1_Click(object sender, EventArgs e)
        {
            if (lv1Show.SelectedItems.Count==0)
            {
                MessageBox.Show("请先选择一行");
                return;
            }
            string name = lv1Show.SelectedItems[0].Text;
            AddMenu(name);
        }
        #region 添加方法
        private void AddMenu(string name)
        {
            Dictionary<int, Caudle> dicc = fm.mes[key].caus;
            Dictionary<int, Menu1> dicm = fm.mes[key].mens;
            foreach (KeyValuePair<int,Menu1> m1 in me)
            {
                if (name.Equals(m1.Value.DishName))
                {
                    if (dicm.ContainsKey(m1.Key))
                    {
                        if (mm.UpdateCrib(dicm[m1.Key], (int)numericUpDown1.Value)>0)
                        {
                            dicm[m1.Key].Count = dicm[m1.Key].Count + (int)numericUpDown1.Value;
                            MessageBox.Show("增加" + m1.Value.DishName + "成功");
                        }
                        else
                        {
                            MessageBox.Show(dicm[m1.Key].DishName+"库存不足");
                        }
                        YiDianLoad();
                        return;
                    }
                    else
                    {
                        Menu1 m = m1.Value;
                        m.Count = (int)numericUpDown1.Value;
                        if (mm.UpdateCrib(m, (int)numericUpDown1.Value) > 0)
                        {
                            dicm.Add(m1.Key, m);
                            MessageBox.Show("添加" + m1.Value.DishName + "成功");
                        }
                        else
                        {
                            MessageBox.Show(m1.Value.DishName+"库存不足");
                        }
                        
                        YiDianLoad();
                        return;
                    }
                }
            }
            foreach (KeyValuePair<int,Caudle> cd in cau)
            {
                if (name.Equals(cd.Value.CaudleName))
                {
                    if (dicc.ContainsKey(cd.Key))
                    {
                        
                        if (cm.UpdateCaudle(cd.Value, (int)numericUpDown1.Value)>0)
                        {
                            dicc[cd.Key].Count = dicc[cd.Key].Count + (int)numericUpDown1.Value;
                            MessageBox.Show("增加" + cd.Value.CaudleName + "成功");
                        }
                        else
                        {
                            MessageBox.Show(cd.Value.CaudleName+"库存不足");
                        }
                        YiDianLoad();
                        return;
                    }
                    else
                    {
                        Caudle c = cd.Value;
                        c.Count = (int)numericUpDown1.Value;
                        if (cm.UpdateCaudle(c, (int)numericUpDown1.Value)>0)
                        {
                            dicc.Add(cd.Key, c);
                            MessageBox.Show("添加" + cd.Value.CaudleName + "成功");
                        }
                        else
                        {
                            MessageBox.Show(c.CaudleName+"库存不足");
                        }
                        YiDianLoad();
                        return;
                    }
                    
                }
            }
        }
        #endregion
        #endregion
        #region 单击退菜
        private void button2_Click(object sender, EventArgs e)
        {
            if (this.lv2Show.SelectedItems.Count <= 0)
            {
                MessageBox.Show("请先选择一行");
                return;
            }
            foreach (KeyValuePair<int, Menu1> me in fm.mes[key].mens)
            {
                if (me.Value.DishName.Equals(lv2Show.SelectedItems[0].Text))
                {
                    mm.TuiMenu(me.Value, me.Value.Count);
                    fm.mes[key].mens.Remove(me.Key);
                    MessageBox.Show("已退菜：" + lv2Show.SelectedItems[0].Text);
                    YiDianLoad();
                    if (lv2Show.Items.Count==0)
                    {
                        fm.pns[key].BackColor = Color.Lime;
                        fm.pns[key].Controls["lb"+key+"type"].Text = "空闲";
                    }
                    return;
                }
            }
            foreach (KeyValuePair<int, Caudle> cau in fm.mes[key].caus)
            {
                if (cau.Value.CaudleName.Equals(lv2Show.SelectedItems[0].Text))
                {
                    cm.TuiCaudle(cau.Value, cau.Value.Count);
                    fm.mes[key].caus.Remove(cau.Key);
                    MessageBox.Show("已退酒水：" + lv2Show.SelectedItems[0].Text);
                    YiDianLoad();
                    if (lv2Show.Items.Count == 0)
                    {
                        fm.pns[key].BackColor = Color.Lime;
                        fm.pns[key].Controls["lb" + key + "type"].Text = "空闲";
                    }
                    return;
                }
            }
        }
        #endregion
    }
}
