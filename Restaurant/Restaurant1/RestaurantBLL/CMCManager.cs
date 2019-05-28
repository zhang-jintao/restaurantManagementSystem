using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Restaurant.Models;
using Restaurant.DAL;

namespace Restaurant.BLL
{
    public class CMCManager
    {
        CribService cbs = new CribService();
        CaudleService ces = new CaudleService();
        MenuService ms = new MenuService();
        /// <summary>
        /// 获取食材表
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public List<Crib> GetAllCrib(string str)
        {
            List<Crib> list = cbs.GetAllCirb(str); ;
            return list;
        }
        /// <summary>
        /// 获取酒水表
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public List<Caudle> GetAllCaudle(string str)
        {
            List<Caudle> list = ces.GetAllCaudle(str);
            return list;
        }
        /// <summary>
        /// 获取菜品表
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public List<Menus> GetAllMenu(string str)
        {
            List<Menus> list = ms.GetAllMenu(str);
            return list;
        }
        public string GetCribName(int id)
        {
            return cbs.GetCribName(id);
        }
    }
}
