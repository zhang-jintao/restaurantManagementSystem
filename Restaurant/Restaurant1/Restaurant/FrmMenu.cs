using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Restaurant.BLL;
using Restaurant.Models;

namespace Restaurant
{
    public partial class FrmMenu : Form
    {

        public FrmMenu()
        {
            InitializeComponent();
            
        }
        #region 食材
        CMCManager cm = new CMCManager();
        CribManager cribM = new CribManager();
        private void btn3Cha_Click(object sender, EventArgs e)
        {
            List<Crib> list = cm.GetAllCrib(this.txt3Name.Text);
            this.dgv3Show.DataSource = list;
            this.txt3Name.Text = "";
        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {
            DgvLoad();
        }
        #region 填充食材DGV
        /// <summary>
        /// 填充菜品DGV
        /// </summary>
        public void DgvLoad()
        {
            this.dgv3Show.DataSource = cm.GetAllCrib(this.txt3Name.Text);
            this.dgv1Show.DataSource = cm.GetAllMenu(this.txt1Name.Text);
            foreach (DataGridViewRow row in dgv1Show.Rows)
            {
                int id = Convert.ToInt32(row.Cells["CribOne"].Value);
                string name = cm.GetCribName(id);
                row.Cells["name22"].Value = name;
            }
            foreach (DataGridViewRow row in dgv1Show.Rows)
            {
                int id = Convert.ToInt32(row.Cells["CribTwo"].Value);
                row.Cells["Name2"].Value = cm.GetCribName(id);
            }
            this.dgv2Show.DataSource = cm.GetAllCaudle(this.txt2Name.Text);
        }
        #endregion


        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #region 食材菜单选项
        private void tmsi3ZengJia_Click(object sender, EventArgs e)
        {
            FrmCribInsert ca = new FrmCribInsert();
            ca.ShowDialog();
            List<Crib> list = cm.GetAllCrib(this.txt3Name.Text);
            this.dgv3Show.DataSource = list;
        }

        private void tmsiUpdate_Click(object sender, EventArgs e)
        {
            FrmCribUpdate fcu = new FrmCribUpdate(dgv3Show.SelectedRows[0]);
            fcu.ShowDialog();
            List<Crib> list = cm.GetAllCrib(this.txt3Name.Text);
            this.dgv3Show.DataSource = list;
        }
        #endregion
        #region 删除食材
        /// <summary>
        /// 删除食材
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmi3Del_Click(object sender, EventArgs e)
        {
            int k = Convert.ToInt32(dgv3Show.SelectedRows[0].Cells[0].Value);
            if (cribM.DeleteCrib(k) > 0)
            {
                MessageBox.Show("删除成功");
            }
            List<Crib> list = cm.GetAllCrib(this.txt3Name.Text);
            this.dgv3Show.DataSource = list;

        }
        #endregion
        #region 增加食材库存
        /// <summary>
        /// 增加食材库存
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmi3JinHuo_Click(object sender, EventArgs e)
        {
            FrmCribKu fk = new FrmCribKu(dgv3Show.SelectedRows[0]);
            fk.ShowDialog();
            List<Crib> list = cm.GetAllCrib(this.txt3Name.Text);
            this.dgv3Show.DataSource = list;
        }
        #endregion        
        #endregion

/// //////////////////////////////////////////////

        #region 酒水

        CaudleManager cmr = new CaudleManager();

        #region 绑定酒水DGV
        /// <summary>
        /// 绑定酒水DGV
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn2Cha_Click(object sender, EventArgs e)
        {
            List<Caudle> list = cm.GetAllCaudle(this.txt2Name.Text);
            this.dgv2Show.DataSource = list;
            this.txt2Name.Text = "";
        }        
        #endregion

        #region 删除酒水
        private void tsmi2Del_Click(object sender, EventArgs e)
        {
            int k=Convert.ToInt32(this.dgv2Show.SelectedRows[0].Cells[0].Value);
            if (cmr.DelCaucle(k)>0)
            {
                MessageBox.Show("删除成功");
            }
            List<Caudle> list = cm.GetAllCaudle(this.txt2Name.Text);
            this.dgv2Show.DataSource = list;
        }        
        #endregion

        #region 跳转新增加酒水窗体
        private void tsmi2Zengjia_Click(object sender, EventArgs e)
        {
            FrmCaudleInsert fci = new FrmCaudleInsert();
            fci.ShowDialog();
            List<Caudle> list = cm.GetAllCaudle(this.txt2Name.Text);
            this.dgv2Show.DataSource = list;
        }        
        #endregion

        #region 跳转修改酒水信息
        private void tsmi2Update_Click(object sender, EventArgs e)
        {
            FrmCaudleUpd fc = new FrmCaudleUpd(this.dgv2Show.SelectedRows[0]);
            fc.ShowDialog();
            List<Caudle> list = cm.GetAllCaudle(this.txt2Name.Text);
            this.dgv2Show.DataSource = list;
        }
        #endregion

        #region 跳转增加库存窗体
        private void tsmi2KuCun_Click(object sender, EventArgs e)
        {
            FrmCaudleUpdate fcu = new FrmCaudleUpdate(dgv2Show.SelectedRows[0]);
            fcu.ShowDialog();
            List<Caudle> list = cm.GetAllCaudle(this.txt2Name.Text);
            this.dgv2Show.DataSource = list;
        }
        #endregion

        #endregion

/// /////////////////////////////////////////////////

        #region 菜品
        #region 绑定菜品DGV
        /// <summary>
        /// 绑定菜品DGV
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn1Cha_Click(object sender, EventArgs e)
        {
            DgvLoad();
            this.txt1Name.Text = "";
        }

        #endregion
        MenuManager mm = new MenuManager();
        #region 删除菜品
        private void tsmiDel_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(this.dgv1Show.SelectedRows[0].Cells[0].Value);
            if (mm.DelMenu(id)>0)
            {
                MessageBox.Show("删除成功");
            }
            List<Menus> list = cm.GetAllMenu(this.txt1Name.Text);
            this.dgv1Show.DataSource = list;
            DgvLoad();
        }
        #endregion

        #region 修改菜品
        private void tsmiUpdate_Click(object sender, EventArgs e)
        {
            FrmMenuUpdate fmu = new FrmMenuUpdate(this.dgv1Show.SelectedRows[0]);
            fmu.ShowDialog();
            List<Menus> list = cm.GetAllMenu(this.txt1Name.Text);
            this.dgv1Show.DataSource = list;
            DgvLoad();
        }
        #endregion

        #region 新增菜品
        private void tsmiZengJia_Click(object sender, EventArgs e)
        {
            FrmMenuInsert fmi = new FrmMenuInsert();
            fmi.ShowDialog(); List<Menus> list = cm.GetAllMenu(this.txt1Name.Text);
            this.dgv1Show.DataSource = list;
            DgvLoad();
        }
        #endregion

        #endregion
    }
}
