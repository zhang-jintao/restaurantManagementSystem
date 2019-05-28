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
    public partial class FrmYuDing : Form
    {
        #region 字段
        //主窗体
        private FrmMain fm;
        private CaudleManager cm = new CaudleManager();
        private MenuManager mm = new MenuManager();
        private Dictionary<int, Menu1> men = new Dictionary<int, Menu1>();
        private Dictionary<int, Caudle> cau = new Dictionary<int, Caudle>();
        Dictionary<int, Menu1> meInt = new Dictionary<int, Menu1>();
        Dictionary<int, Caudle> cauInt = new Dictionary<int, Caudle>();
        #endregion
        #region 初始化方法
        public FrmYuDing(FrmMain fm)
        {
            InitializeComponent();
            this.fm = fm;
        }

        private void FrmYuDing_Load(object sender, EventArgs e)
        {
            LoadCbo();
            ChaCai();
            ChaJiu();
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
                if (!fm.pns[i+1].Controls["lb"+(i+1)+"type"].Text.Equals("空闲"))
                {
                    continue;
                }
                Tables t = new Tables();
                t.Name = fm.pns[i + 1].Controls["lb" + (i + 1) + "Name"].Text;
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
            foreach (Menu1 item in meInt.Values)
            {
                ListViewItem it = new ListViewItem(item.DishName);
                it.SubItems.Add(item.Count.ToString());
                sum += (double)(item.Count * item.DishMoney);
                it.SubItems.Add(((double)(item.Count * item.DishMoney)).ToString());
                lvShow.Items.Add(it);
            }
            foreach (Caudle item in cauInt.Values)
            {
                ListViewItem it = new ListViewItem(item.CaudleName);
                it.SubItems.Add(item.Count.ToString());
                sum += (double)(item.Count * item.CaudleMoney);
                it.SubItems.Add(((double)(item.Count * item.CaudleMoney)).ToString());
                lvShow.Items.Add(it);
            }

            ListViewItem zong = new ListViewItem("合计");
            zong.SubItems.Add("");
            zong.SubItems.Add(sum.ToString());
            if (lvShow.Items.Count > 0)
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
            if (dgv1Show.SelectedRows.Count != 1)
            {
                MessageBox.Show("请先选择一行");
                return;
            }
            if (num1Count.Value <= 0)
            {
                MessageBox.Show("请选择数量");
                return;
            }
            int menu = Convert.ToInt32(dgv1Show.SelectedRows[0].Cells["DishId"].Value);//菜品编号
            if (mm.UpdateCrib(men[menu], Convert.ToInt32(num1Count.Value)) > 0)
            {
                AddMenu(menu);
            }
            else
            {
                MessageBox.Show(men[menu].DishName + "材料不足，点菜失败!");
                return;
            }
            LoadListView();
        }
        //添加酒水
        private void btn2Add_Click(object sender, EventArgs e)
        {
            if (dgv2Show.SelectedRows.Count != 1)
            {
                MessageBox.Show("请先选择一行");
                return;
            }
            if (num2Count.Value <= 0)
            {
                MessageBox.Show("请选择数量");
                return;
            }
            int caudle = Convert.ToInt32(dgv2Show.SelectedRows[0].Cells["CaudleId"].Value);//酒水编号
            if (cm.UpdateCaudle(cau[caudle], Convert.ToInt32(num2Count.Value)) > 0)
            {
                AddCaudle(caudle);
            }
            else
            {
                MessageBox.Show(cau[caudle].CaudleName + "库存不足，请及时上货！");
            }
            LoadListView();
        }
        #region 添加酒水方法
        public void AddCaudle(int caudle)
        {
            if (cauInt.ContainsKey(caudle))
            {
                Caudle cd = cauInt[caudle];
                cd.Count += (int)num2Count.Value;
                MessageBox.Show("增加" + num2Count.Value + "个" + cd.CaudleName + "到\n" + cboTables.SelectedText);
            }
            else
            {
                Caudle cd = cau[caudle];
                cd.Count = (int)num2Count.Value;
                cauInt.Add(cd.CaudleId, cd);
                MessageBox.Show("添加" + cd.Count + "个" + cd.CaudleName + "到" + cboTables.SelectedValue + "号桌", "提示");
            }

        }
        #endregion

        #region 添加菜方法
        public void AddMenu(int menu)
        {
            if (meInt.ContainsKey(menu))
            {
                Menu1 me = meInt[menu];
                me.Count += (int)num1Count.Value;
                MessageBox.Show("增加" + num1Count.Value + "个" + me.DishName + "到" + cboTables.SelectedValue + "号桌");
            }
            else
            {
                Menu1 me = men[menu];
                me.Count = (int)num1Count.Value;
                meInt.Add(me.DishId, me);
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

        private bool YuDing = false;
        DateTime dt = new DateTime();
        //窗体关闭前的事件
        #region 窗体关闭前的事件
        private void FrmYuDing_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (YuDing)
            {
                if (cauInt.Values.Count != 0 || meInt.Values.Count != 0)
                {
                    
                    Panel p = fm.pns[Convert.ToInt32(cboTables.SelectedValue)];
                    p.BackColor = Color.Yellow;
                    p.Controls["lb" + cboTables.SelectedValue.ToString() + "type"].Text = "预定中";
                    AddMenu();
                    TimerLoad();
                    MessageBox.Show("预定成功");
                    this.Close();
                }
                else
                {
                    Panel p = fm.pns[Convert.ToInt32(cboTables.SelectedValue)];
                    p.BackColor = Color.Yellow;
                    p.Controls["lb" + cboTables.SelectedValue.ToString() + "type"].Text = "预定中";
                    TimerLoad();
                    MessageBox.Show("预定成功");
                    this.Close();
                    
                }
            }
            else
            {
                MessageBox.Show("取消预定");
            }
        }
        #region 填充已点到主窗体
        private void AddMenu()
        {
            fm.mes[Convert.ToInt32(cboTables.SelectedValue)].mens = meInt;
            fm.mes[Convert.ToInt32(cboTables.SelectedValue)].caus = cauInt;
        }
        #endregion
        #endregion
        /// <summary>
        /// 根据时间启动主窗体时间控件
        /// </summary>
        #region 根据时间启动主窗体时间控件
        private void TimerLoad()
        {
            int d = (int)((dt - DateTime.Now).TotalMilliseconds);//毫秒数
            //测试
            int id = Convert.ToInt32(cboTables.SelectedValue);
            
            fm.timers[id].tim.Interval = d;
            fm.timers[id].tim.Enabled = true;
            fm.timers[id].tim.Start();
        }
        #endregion
        //预定点击事件
        #region 单击预定
        private void btnYuDing_Click(object sender, EventArgs e)
        {
            if (CheckTime(ref dt))
            {
                YuDing = true;
                if (cauInt.Values.Count == 0 && meInt.Values.Count == 0)
                {
                    DialogResult result = MessageBox.Show("是否添加菜品", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (DialogResult.Yes== result)
                    {
                        txt1Name.Focus();
                        return;
                    }
                }
                this.Close();
            }
            else
            {
                txtShi.Focus();
                YuDing = false;
            }
        }
        #endregion
        /// <summary>
        /// 检查时间是否合法
        /// </summary>
        /// <param name="dt"></param>
        /// <returns></returns>
        #region 检查时间是否合法
        public bool CheckTime(ref DateTime dt)
        {
            bool flag = true;
            if (txtShi.Text.Length > 2 || txtFen.Text.Length > 2 || txtShi.Text.Length == 0) 
            {
                MessageBox.Show("时间格式不正确,请检查时间格式");
                return false;
            };
            try
            {
                 dt = Convert.ToDateTime(txtShi.Text.PadLeft(2,'0')+":"+txtFen.Text.PadLeft(2,'0'));
                 if (DateTime.Now>=dt)
                 {
                     MessageBox.Show("预约时间必须大于当前时间");
                     flag = false;
                 }
            }
            catch (Exception)
            {
                flag=false;
                MessageBox.Show("时间格式不正确，请检查时间格式");
            }
            return flag;
        }
        #endregion

        #region 退菜
        private void tsmiTui_Click(object sender, EventArgs e)
        {
            if (lvShow.SelectedItems.Count<=0)
            {
                MessageBox.Show("请先选择一行");
                return;
            }
            string name = lvShow.SelectedItems[0].Text;
            TuiCai(name);
        }
        #region 退菜方法
        public void TuiCai(string name)
        {
            foreach (KeyValuePair<int,Menu1> m1 in meInt)
            {
                if (m1.Value.DishName.Equals(name))
                {
                    if (mm.TuiMenu(m1.Value, m1.Value.Count)>0)
                    {
                        meInt.Remove(m1.Key);
                        LoadListView();
                        MessageBox.Show("取消" + name + "成功！");
                        return;
                    }
                    else
                    {
                        MessageBox.Show("出现错误，请联系管理员");
                        return;
                    }
                    
                }
            }
            foreach (KeyValuePair<int,Caudle> cau in cauInt)
            {
                if (cau.Value.CaudleName.Equals(name))
                {
                    if (cm.TuiCaudle(cau.Value,cau.Value.Count)>0)
                    {
                        cauInt.Remove(cau.Key);
                        LoadListView();
                        MessageBox.Show("取消" + name + "成功！");
                        return;
                    }
                    else
                    {
                        MessageBox.Show("出现错误，请联系管理员");
                    }
                }
            }
        }
        #endregion
        #endregion
    }
}
