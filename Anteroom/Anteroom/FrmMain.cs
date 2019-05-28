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
using Anteroom.Common;

namespace Anteroom
{
    public partial class FrmMain : Form
    {
        #region 字段
        public Dictionary<int,Panel> pns = new Dictionary<int,Panel>();
        public Dictionary<int, Menus> mes = new Dictionary<int, Menus>();
        private AdminManager am = new AdminManager();
        private CaudleManager cm = new CaudleManager();
        private MenuManager mm = new MenuManager();
        private JieZhang jz = new JieZhang();//结账
        private int key;//记录当前桌的键
        private Leave l = new Leave();
        public bool flag = false;//是否开权限
        private int tableCount = 8;//桌数量

        public int TableCount
        {
            get { return tableCount; }
            set { tableCount = value; }
        }
        private int baoCount = 2;//包厢数量

        public int BaoCount
        {
            get { return baoCount; }
            set { baoCount = value; }
        }
        public Dictionary<int,Timers> timers=new Dictionary<int,Timers>();//时间控件
        string[] bao = { "包厢", "餐桌" };
        #endregion
        
        #region 窗体初始化
        public FrmMain()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            int[] i = Menus.ReadCount();
            if (i!=null)
            {
                tableCount = i[0];
                baoCount = i[1];
            }
            FrmLoad();
            QuanXian();
        }
        /// <summary>
        /// 初始化窗体方法
        /// </summary>
        private void FrmLoad()
        {
            AddBao();
            TreeLoad();
            if (l.CheckLeave())
            {
                Likai();
            }
        }
        #region 添加桌和包厢
        public void AddBao()
        {
            mes.Clear();
            pns.Clear();
            timers.Clear();
            int i = 1;
            for (; i <= tableCount+baoCount; i++)
            {
                if (i<=tableCount)
                {
                    mes.Add(i, new Menus(i));//添加桌对象
                    AddPanel(i, 1);//添加桌对象
                    //动态添加时间控件
                    AddTimer(i);
                }
                else
                {
                    mes.Add(i, new Menus(i));//添加包厢对象
                    AddPanel(i, 0);//添加包厢对象
                    //动态添加时间控件
                    AddTimer(i);
                }
            }
        }
        #endregion
        #endregion
        #region 动态添加面板
        private void AddPanel(int i,int b)
        {
            Panel p = new Panel();
            p.Name = "pn"+i+"table";
            p.BackColor = Color.Lime;
            p.Size = new Size(390, 226);
            p.ContextMenuStrip=this.cmsiRight;
            p.Click += new System.EventHandler(this.pntable_Click);
            pns.Add(i,p);//添加到集合
            Label lbname = new Label();
            lbname.AutoSize = true;
            lbname.Font = new Font("华文行楷", 18F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(134)));
            lbname.Location = new Point(148, 30);
            lbname.Name = "lb"+i+"Name";
            lbname.Size = new Size(91, 25);
            lbname.Text = i + "号" + bao[b];
            Label lbzhuang = new Label();
            lbzhuang.AutoSize = true;
            lbzhuang.Font = new Font("宋体", 15F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(134)));
            lbzhuang.Location = new Point(93, 73);
            lbzhuang.Name = "label"+i+"1";
            lbzhuang.Size = new Size(69, 20);
            lbzhuang.Text = "状态：";
            Label lbtype = new Label();
            lbtype.AutoSize = true;
            lbtype.Font = new Font("宋体", 15F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(134)));
            lbtype.Location = new Point(227, 73);
            lbtype.Name = "lb"+i+"type";
            lbtype.Size = new Size(49, 20);
            lbtype.Text = "空闲";
            Label lbshifou = new Label();
            lbshifou.AutoSize = true;
            lbshifou.Font = new Font("宋体", 15F,FontStyle.Regular, GraphicsUnit.Point, ((byte)(134)));
            lbshifou.Location = new Point(53, 137);
            lbshifou.Name = "label"+i+"2";
            lbshifou.Size = new System.Drawing.Size(109, 20);
            lbshifou.Text = "是否结账：";
            Label lbBool = new Label();
            lbBool.AutoSize = true;
            lbBool.Font = new Font("宋体", 15F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(134)));
            lbBool.Location = new Point(227, 137);
            lbBool.Name = "lb"+i+"Bool";
            lbBool.Size = new Size(69, 20);
            lbBool.Text = "未结账";
            p.Controls.Add(lbname);
            p.Controls.Add(lbzhuang);
            p.Controls.Add(lbtype);
            p.Controls.Add(lbshifou);
            p.Controls.Add(lbBool);
        }
        #endregion
        #region 初始化treeView
        private void TreeLoad()
        {
            TreeNode tn = new TreeNode();
            tn.Text = "全部";
            TreeNode n1 = new TreeNode();
            n1.Text = "空桌";
            tn.Nodes.Add(n1);
            TreeNode n2 = new TreeNode();
            n2.Text = "预定";
            tn.Nodes.Add(n2);
            TreeNode n3 = new TreeNode();
            n3.Text = "正在用餐";
            TreeNode n31 = new TreeNode();
            n31.Text = "已结账";
            TreeNode n32 = new TreeNode();
            n32.Text = "未结账";
            n3.Nodes.Add(n31);
            n3.Nodes.Add(n32);
            tn.Nodes.Add(n3);

            tvShow.Nodes.Add(tn);
            tvShow.SelectedNode = tn;
        }
        #endregion
        #region 查看菜单
        private void tsmiDian_Click(object sender, EventArgs e)
        {
            FrmDian fd = new FrmDian(this);
            fd.ShowDialog();
        }
        #endregion
        #region 单击桌面事件
        private void pntable_Click(object sender, EventArgs e)
        {
            //获取当前点中对象的值
            foreach (KeyValuePair<int,Panel> item in pns)
            {
                if (item.Value==(Panel)sender)
                {
                    key = item.Key;
                    break;
                }
            }
            Loadtsmi((Panel)sender);
            
        }
        #endregion
        #region 根据panel控件，设置右键菜单隐藏或可见
        public void Loadtsmi(Panel p)
        {
            if (p.BackColor==Color.Red)
	        {
                tsmiJiaCai.Visible = true;
                if (p.Controls["lb" + key + "Bool"].Text.Equals("已结账"))
                {
                    tsmiJieZhang.Visible = false;
                }
                else
                {
                    tsmiJieZhang.Visible = true;
                }
                tsmiTuiZhuo.Visible = false;
                tsmiKeLi.Visible = true;
                tsmiGo.Visible = false;
	        }
            else if(p.BackColor==Color.Lime)
            {
                tsmiJiaCai.Visible = false;
                tsmiJieZhang.Visible = false;
                tsmiTuiZhuo.Visible = false;
                tsmiKeLi.Visible = false;
                tsmiGo.Visible = false;
            }
            else if (p.BackColor==Color.Yellow)
            {
                tsmiJiaCai.Visible = true ;
                tsmiJieZhang.Visible = false;
                tsmiTuiZhuo.Visible = true;
                tsmiKeLi.Visible = false;
                tsmiGo.Visible = true;
            }
            
            
        }
        #endregion
        //预定、
        #region 预定
        private void 预定ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmYuDing fyd = new FrmYuDing(this);
            fyd.ShowDialog();
        }
        #endregion
        #region 预定的Timer控件
        public void AddTimer(int i)
        {
            timers[i] = new Timers();
            timers[i].id = i;
            timers[i].m = mes[i];
            timers[i].p = pns[i];
            Timer tim = new Timer(this.components);
            timers[i].tim = tim;
            timers[i].tim.Tick += new System.EventHandler(timers[i].timerStart_Tick);
        }
        #endregion

        #region 单击结账
        private void tsmiJieZhang_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(key+"桌是否结账", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result==DialogResult.No)
            {
                return;
            }
            if (mes[key].caus.Count==0&&mes[key].mens.Count==0)
            {
                MessageBox.Show("结账成功");
                pns[key].Controls["lb" + key + "Bool"].Text = "已结账";
                return;
            }
            bool flag = false;
            int k = jz.AddCaudleTurnoverService(mes[key].caus);
            if (k>0)
            {
                flag = true;
            }
            int g = jz.AddMenuTurnoverService(mes[key].mens);
            if (g>0)
            {
                flag = true;
            }
            if (flag)
            {
                StringBuilder sb = new StringBuilder("结账成功,清单如下\n");
                foreach (Menu1 item in mes[key].mens.Values)
                {
                    sb.AppendLine(item.DishName+"*"+item.Count+"盘    "+Convert.ToDouble(item.DishMoney)+"元");
                }
                foreach (Caudle cau in mes[key].caus.Values)
                {
                    sb.AppendLine(cau.CaudleName+"*"+cau.Count+"瓶    "+Convert.ToDouble(cau.CaudleMoney)+"元");
                }
                MessageBox.Show(sb.ToString());
                pns[key].Controls["lb" + key + "Bool"].Text = "已结账";
            }
        }

        #endregion

        private void tsmiJiaCai_Click(object sender, EventArgs e)
        {
            FrmTuiZeng ftz = new FrmTuiZeng(key,this);
            ftz.ShowDialog();
        }
        #region 单击客离
        private void tsmiKeLi_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(key+"桌是否客离", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result==DialogResult.No)
            {
                return;
            }
            if (pns[key].Controls["lb"+key+"Bool"].Text.Equals("已结账"))
            {
                pns[key].Controls["lb" + key + "type"].Text = "空闲";
                pns[key].Controls["lb" + key + "Bool"].Text = "未结账";
                pns[key].BackColor=Color.Lime;
                mes[key].mens.Clear();
                mes[key].caus.Clear();
            }
            else
            {
                if (mes[key].caus.Count == 0 && mes[key].mens.Count == 0)
                {
                    pns[key].Controls["lb" + key + "type"].Text = "空闲";
                    pns[key].Controls["lb" + key + "Bool"].Text = "未结账";
                    pns[key].BackColor = Color.Lime;
                    mes[key].mens.Clear();
                    mes[key].caus.Clear();
                }
                else
                {
                    MessageBox.Show("请先结账，再离开");
                }
            }
        }
        #endregion
        #region 退预定
        private void tsmiTuiZhuo_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("是否退预定","提示",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (DialogResult.No==result)
            {
                return;
            }
            foreach (KeyValuePair<int,Menu1> m1 in mes[key].mens)
            {
                mm.TuiMenu(m1.Value,m1.Value.Count);
            }
            foreach (KeyValuePair<int,Caudle> cd in mes[key].caus)
            {
                cm.TuiCaudle(cd.Value,cd.Value.Count);
            }
            pns[key].Controls["lb" + key + "type"].Text = "空闲";
            pns[key].Controls["lb" + key + "Bool"].Text = "未结账";
            pns[key].BackColor = Color.Lime;
            timers[key].tim.Enabled = false;
            timers[key].flag = true;
        }
        #endregion
        #region 走菜
        private void tsmiGo_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(key+"桌是否走菜", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result==DialogResult.No)
            {
                return;
            }
            pns[key].BackColor = Color.Red;
            pns[key].Controls["lb" + key + "type"].Text = "已占用";
        }
        #endregion
        #region TreeView视图
        /// <summary>
        /// 添加筛选后的Panel到TAB控件
        /// </summary>
        /// <param name="ps"></param>
        #region 添加筛选后的Panel到TAB控件
        public void TabLoad(List<Panel> ps)
        {
            int chang = (tpTable.Size.Width-(2 * pns[1].Size.Width))/4;
            int gao = (tpTable.Size.Height - (2 * pns[1].Size.Height)) / 4;
            for (int i = 0; i < ps.Count; )
            {
                for (int j = 0; j < 2&&i<ps.Count; j++)
                {
                    ps[i].Visible = true;
                    ps[i].Location = new System.Drawing.Point(chang * (j + 1) + j * pns[1].Size.Width, gao * (int)((i + 2) / 2) + (int)(i / 2) * pns[1].Size.Height);
                    tpTable.Controls.Add(ps[i]);
                    i++;
                }
            }
        }
        #endregion
        #region treeview事件
        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TabLoad(GetPanel()); 
        }
        #endregion

        #region 根据选中节点返回面板
        public List<Panel> GetPanel()
        {
            List<Panel> list = new List<Panel>();
            if (tvShow.SelectedNode.Level == 0)
            {
                list = pns.Values.ToList();
                tpTable.Text = "全部";
            }
            else if (tvShow.SelectedNode.Level == 1)
            {
                if (tvShow.SelectedNode.Text.Equals("预定"))
                {
                    for (int i = 1; i <= pns.Values.Count; i++)
                    {
                        if (pns[i].Controls["lb" + i + "type"].Text.Equals("预定中"))
                        {
                            pns[i].Visible = true;
                            list.Add(pns[i]);
                        }
                        else
                        {
                            pns[i].Visible = false;
                        }
                    }
                    tpTable.Text = "预定";
                }
                else if (tvShow.SelectedNode.Text.Equals("空桌"))
                {
                    for (int i = 1; i <= pns.Values.Count; i++)
                    {
                        if (pns[i].Controls["lb" + i + "type"].Text.Equals("空闲"))
                        {
                            pns[i].Visible = true;
                            list.Add(pns[i]);
                        }
                        else
                        {
                            pns[i].Visible = false;
                        }
                    }
                    tpTable.Text = "空桌";
                }
                else if (tvShow.SelectedNode.Text.Equals("正在用餐"))
                {
                    for (int i = 1; i <= pns.Values.Count; i++)
                    {
                        if (pns[i].Controls["lb" + i + "type"].Text.Equals("已占用"))
                        {
                            pns[i].Visible = true;
                            list.Add(pns[i]);
                        }
                        else
                        {
                            pns[i].Visible = false;
                        }
                    }
                    tpTable.Text = "正在用餐";
                }
            }
            else if (tvShow.SelectedNode.Level == 2)
            {
                if (tvShow.SelectedNode.Text.Equals("已结账"))
                {
                    for (int i = 1; i <= pns.Values.Count; i++)
                    {
                        if (pns[i].Controls["lb" + i + "Bool"].Text.Equals("已结账"))
                        {
                            pns[i].Visible = true;
                            list.Add(pns[i]);
                        }
                        else
                        {
                            pns[i].Visible = false;
                        }
                    }
                }
                else if (tvShow.SelectedNode.Text.Equals("未结账"))
                {
                    for (int i = 1; i <= pns.Values.Count; i++)
                    {
                        if (pns[i].Controls["lb" + i + "Bool"].Text.Equals("未结账")&&pns[i].BackColor==Color.Red)
                        {
                            pns[i].Visible = true;
                            list.Add(pns[i]);
                        }
                        else
                        {
                            pns[i].Visible = false;
                        }
                    }
                }
            }
            return list;
        }
        #endregion
        private void 离开ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Likai();
        }

        #region 离开方法
        public void Likai()
        {
            FrmLiKai lk = new FrmLiKai();
            lk.fm = this;
            if (l.CheckLeave())
            {
                lk.flag = true;
            }
            pb.Visible = false;
            lk.ShowDialog();
        }
        #endregion
        #endregion
        #region 系统操作
        private void 系统登录ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmLogin fl = new FrmLogin(this);
            fl.ShowDialog();
        }
        private void 注销账户ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (flag)
            {
                DialogResult result = MessageBox.Show("确认注销账号吗", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    flag = false;
                    QuanXian();
                    MessageBox.Show("注销账户成功");
                }
            }
            else
            {
                MessageBox.Show("没有账号登录");
            }
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion
        #region 权限管理
        public void QuanXian()
        {
            查看库存ToolStripMenuItem.Enabled = flag;
            离开ToolStripMenuItem.Enabled = flag;
            注销账户ToolStripMenuItem.Enabled = flag;
            cmsiRight.Enabled = flag;
            记忆功能ToolStripMenuItem.Enabled = flag;
            系统设置YToolStripMenuItem.Enabled = flag;
        }
        #endregion
        #region 恢复
        public void HuiFu()
        {
            for (int i = 1; i <= pns.Count; i++)
            {
                mes[i] = new Menus(i);
                mes[i].ReadTxt();
                pns[i].Controls["lb" + i + "Name"].Text = mes[i].tables.Name;
                UpdateColor(mes[i].tables.Type,i);
                pns[i].Controls["lb" + i + "Bool"].Text = mes[i].tables.Bool;
            }
        }
        #region 修改状态
        private void UpdateColor(string type,int i)
        {
            switch (type)
            {
                case "空闲":
                    pns[i].BackColor = Color.Lime;
                    break;
                case "预定中":
                    pns[i].BackColor = Color.Yellow;
                    break;
                case "已占用":
                    pns[i].BackColor = Color.Red;
                    break;
                default:
                    break;
            }
            pns[i].Controls["lb" + i + "type"].Text = type;
        }
        #endregion

        
        #endregion
        #region 保存数据
        private void FrmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            for (int i = 1; i <= mes.Values.Count; i++)
            {
                mes[i].tables.Num = i;
                mes[i].tables.Name = pns[i].Controls["lb"+i+"Name"].Text;
                mes[i].tables.Type = pns[i].Controls["lb" + i + "type"].Text;
                mes[i].tables.Bool = pns[i].Controls["lb" + i + "Bool"].Text;
            }
            foreach (Menus me in mes.Values)
            {
                me.CreateTxt();
            }
            Menus.AddCount(tableCount,baoCount);
        }
        #endregion
        #region 恢复数据
        private void 恢复上次数据ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HuiFu();
            MessageBox.Show("恢复成功");
        }
        #endregion
        #region 关于我们
        private void 版本信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAbout fa = new FrmAbout();
            fa.ShowDialog();
        }
        #endregion
        #region 设置桌数量
        private void 设置桌数量WToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmUpdateTable fut = new FrmUpdateTable(this,true);
            fut.ShowDialog();
        }

        private void 设置包厢数量LToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmUpdateTable fut = new FrmUpdateTable(this,false);
            fut.ShowDialog();
        }
        #endregion
    }
}
