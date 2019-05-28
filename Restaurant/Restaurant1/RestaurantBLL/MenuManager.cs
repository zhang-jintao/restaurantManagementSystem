using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Restaurant.DAL;
using Restaurant.Models;

namespace Restaurant.BLL
{
    public class MenuManager
    {
        MenuService ms = new MenuService();
        #region 删除菜品
        public int DelMenu(int id)
        {
            int k = ms.DelMneu(id);
            return k;
        }
        #endregion
        #region 修改菜品
        public int UpdateMenu(int id,decimal money, double dou1, double dou2)
        {
            int k = ms.UpdateMenu(id,money,dou1,dou2);
            return k;
        }
        #endregion
        #region 绑定食材列表
        public List<Crib> Crib()
        {
            List<Crib> list = ms.Crib();
            return list;
        }
        #endregion
        #region 根据食材查询编号
        public int CribId(string name)
        {
            int k = ms.CribID(name);
            return k;
        }
        #endregion
        #region 增加菜品
        public int InsertMneu(string name, decimal money, int no1, int no2, double dou1, double dou2)
        {
            int k = ms.InsertMenu(name,money,no1,no2,dou1,dou2);
            return k;
        }
        #endregion
    }
}
