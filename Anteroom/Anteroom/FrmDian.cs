using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Anteroom.BLL;
using Anteroom.Models;

namespace Anteroom
{
    public partial class FrmDian : Form
    {
        #region 字段
        //主窗体
        private FrmMain fm;
        private CaudleManager cm = new CaudleManager();
        private MenuManager mm = new MenuManager();
        private Dictionary<int,Menu1> men = new Dictionary<int, Menu1>();
        private Dictionary<int,Caudle> cau = new Dictionary<int, Caudle>();
        #endregion
        #region 初始化方法
        public FrmDian(FrmMain fm)
        {
            InitializeComponent();
            this.fm = fm;
        }
        //窗体Load事件
        private void FrmDian_Load(object sender, EventArgs e)
        {
            LoadCbo();
            ChaCai();
            ChaJiu();
            LoadListView();
        }
        /// <summary>
        /// 初始化下拉框方法 LoadCbo()
        /// </summary>
        #region 根据桌的数量绑定下拉框
        private void LoadCbo()
        {
            List<Tables> list = new List<Tables>();
            for (int i = 0; i < fm.pns.Values.Count; i++)
            {
                Tables t = new Tables();
                t.Name = fm.pns[i+1].Controls["lb" + (i+1) + "Name"].Text;
                t.Num = i + 1;
                list.Add(t);
            }
            cboTables.ValueMember = "Num";
            cboTables.DisplayMember = "Name";
            cboTables.DataSource = list;
            cboTables.SelectedIndex = 0;
        }
        #endregion
        /// <summary>
        /// 初始化该桌酒水和菜到lv列表
        /// </summary>
        #region 初始化当前桌已点的菜
        public void LoadListView()
        {
            lvShow.Items.Clear();
            double sum = 0;
            Dictionary<int,Menu1> d = fm.mes[Convert.ToInt32(cboTables.SelectedValue)].mens;
            foreach (Menu1 item in d.Values)
            {
                ListViewItem it = new ListViewItem(item.DishName);
                it.SubItems.Add(item.Count.ToString());
                sum += (double)(item.Count * item.DishMoney);
                it.SubItems.Add(((double)(item.Count*item.DishMoney)).ToString());
                lvShow.Items.Add(it);
            }
            Dictionary<int, Caudle> c = fm.mes[Convert.ToInt32(cboTables.SelectedValue)].caus;
            foreach (Caudle item in c.Values)
            {
                ListViewItem it = new ListViewItem(item.CaudleName);
                it.SubItems.Add(item.Count.ToString());
                sum += (double)(item.Count * item.CaudleMoney);
                it.SubItems.Add(((double)(item.Count*item.CaudleMoney)).ToString());
                lvShow.Items.Add(it);
            }

            ListViewItem zong = new ListViewItem("合计");
            zong.SubItems.Add("");
            zong.SubItems.Add(sum.ToString());
            if (lvShow.Items.Count>0)
            {
                lvShow.Items.Add(zong);  
            }
        }
        #endregion
        #endregion
        #region 查询
        /// <summary>
        /// 按名字模糊查询填充菜单DGV
        /// </summary>
        #region 查询菜单方法ChaCai()
        public void ChaCai()
        {
            men = mm.GetAllMenu(txt1Name.Text);
            dgv1Show.DataSource = new BindingList<Menu1>(men.Values.ToList());
        }
        #endregion
        /// <summary>
        /// 按名字模糊查询填充酒水DGV
        /// </summary>
        #region 查询酒水方法ChaJiu()
        public void ChaJiu()
        {
            cau = cm.GetAllCaudle(txt2Name.Text);
            dgv2Show.DataSource = new BindingList<Caudle>(cau.Values.ToList());
        }
        #endregion

        #region 查询菜单
        private void btn1Cha_Click(object sender, EventArgs e)
        {
            ChaCai();
        }
        #endregion
        #region 查询酒水
        private void btn2Cha_Click(object sender, EventArgs e)
        {
            ChaJiu();
        }
        #endregion
        #endregion
        #region 添加
        //添加菜品
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (dgv1Show.SelectedRows.Count!=1)
            {
                MessageBox.Show("请先选择一行");
                return;
            }
            if (num1Count.Value<=0)
            {
                MessageBox.Show("请选择数量");
                return;
            }
            int menu = Convert.ToInt32(dgv1Show.SelectedRows[0].Cells["DishId"].Value);//菜品编号
            if (mm.UpdateCrib(men[menu],Convert.ToInt32(num1Count.Value))>0)
            {
                AddMenu(menu);
            }
            else
            {
                MessageBox.Show(men[menu].DishName+"材料不足，点菜失败!");
                return;
            }
            if (fm.mes[Convert.ToInt32(cboTables.SelectedValue)].mens.Count!=0)
            {
                Panel p =  fm.pns[Convert.ToInt32(cboTables.SelectedValue)];
                if (p.BackColor==Color.Lime)
                {
                    p.BackColor = Color.Red;
                    p.Controls["lb" + cboTables.SelectedValue.ToString() + "type"].Text = "已占用";
                }
            }
            LoadListView();
        }
        //添加酒水
        private void btn2Add_Click(object sender, EventArgs e)
        {
            if (dgv2Show.SelectedRows.Count!=1)
            {
                MessageBox.Show("请先选择一行");
                return;
            }
            if (num2Count.Value<=0)
            {
                MessageBox.Show("请选择数量");
                return;
            }
            int caudle = Convert.ToInt32(dgv2Show.SelectedRows[0].Cells["CaudleId"].Value);//酒水编号
            if (cm.UpdateCaudle(cau[caudle],Convert.ToInt32(num2Count.Value))>0)
            {
                AddCaudle(caudle); 
            }
            else
            {
                MessageBox.Show(cau[caudle].CaudleName+"库存不足，请及时上货！");
            }
            if (fm.mes[Convert.ToInt32(cboTables.SelectedValue)].caus.Count != 0)
            {
                Panel p = fm.pns[Convert.ToInt32(cboTables.SelectedValue)];
                if (p.BackColor==Color.Lime)
                {
                    
                    p.BackColor = Color.Red;
                    p.Controls["lb" + cboTables.SelectedValue.ToString() + "type"].Text = "已占用";
                }
            }
            LoadListView();
        }
        #region 添加酒水方法
        public void AddCaudle(int caudle)
        {
            if (fm.mes[Convert.ToInt32(cboTables.SelectedValue)].caus.ContainsKey(caudle))
            {
                Caudle cd = fm.mes[Convert.ToInt32(cboTables.SelectedValue)].caus[caudle];
                cd.Count += (int)num2Count.Value;
                MessageBox.Show("增加"+num2Count.Value+"个"+cd.CaudleName+"到第"+cboTables.SelectedValue+"桌","提示");
            }
            else
            {
                Caudle cd = cau[caudle];
                cd.Count = (int)num2Count.Value;
                fm.mes[Convert.ToInt32(cboTables.SelectedValue)].caus.Add(cd.CaudleId,cd);
                MessageBox.Show("添加"+cd.Count+"个"+cd.CaudleName+"到第"+cboTables.SelectedValue+"桌","提示");
            }
            
        }
        #endregion

        #region 添加菜方法
        public void AddMenu(int menu)
        {
            if (fm.mes[Convert.ToInt32(cboTables.SelectedValue)].mens.ContainsKey(menu))
            {
                Menu1 me = fm.mes[Convert.ToInt32(cboTables.SelectedValue)].mens[menu];
                me.Count += (int)num1Count.Value;
                MessageBox.Show("增加" + num1Count.Value + "个" + me.DishName + "到" + cboTables.SelectedValue+"号桌");
            }
            else
            {
                Menu1 me = men[menu];
                me.Count = (int)num1Count.Value;
                fm.mes[Convert.ToInt32(cboTables.SelectedValue)].mens.Add(me.DishId,me);
                MessageBox.Show("添加" + num1Count.Value + "个" + me.DishName + "到" + cboTables.SelectedValue + "号桌");
            }
        }
        #endregion


        #endregion
        #region 刷新桌初始
        private bool flag = true;
        #region 点击和值变化事件
        private void cboTables_Click(object sender, EventArgs e)
        {
            flag = false;
        }
        private void cboTables_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (flag)
            {
                return;
            }
            ShuaXin();
        }
        #endregion
        /// <summary>
        /// 刷新窗体
        /// </summary>
        #region 刷新窗体
        private void ShuaXin()
        {
            txt1Name.Text = string.Empty;
            num1Count.Value = 0;
            txt2Name.Text = string.Empty;
            num2Count.Value = 0;
            ChaCai();
            ChaJiu();
            LoadListView();
        }
        #endregion

        
        #endregion
        #region 退菜
        private void tsmiTui_Click(object sender, EventArgs e)
        {
            if (lvShow.SelectedItems.Count<=0)
            {
                MessageBox.Show("请先选择一行");
                return;
            }
            foreach (KeyValuePair<int,Menu1> me in fm.mes[Convert.ToInt32(cboTables.SelectedValue)].mens)
            {
                if (me.Value.DishName.Equals(lvShow.SelectedItems[0].Text))
                {
                    mm.TuiMenu(me.Value,me.Value.Count);
                    fm.mes[Convert.ToInt32(cboTables.SelectedValue)].mens.Remove(me.Key);
                    MessageBox.Show("已退菜：" + lvShow.SelectedItems[0].Text);
                    LoadListView();
                    return;
                }
            }
            foreach (KeyValuePair<int,Caudle> cau in fm.mes[Convert.ToInt32(cboTables.SelectedValue)].caus)
            {
                if (cau.Value.CaudleName.Equals(lvShow.SelectedItems[0].Text))
                {
                    cm.TuiCaudle(cau.Value,cau.Value.Count);
                    fm.mes[Convert.ToInt32(cboTables.SelectedValue)].caus.Remove(cau.Key);
                    MessageBox.Show("已退酒水：" + lvShow.SelectedItems[0].Text);
                    LoadListView();
                    return;
                }
            }
        }
        #endregion

       


        
    }
}
