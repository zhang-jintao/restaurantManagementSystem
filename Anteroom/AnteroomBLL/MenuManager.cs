using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Anteroom.DAL;
using Anteroom.Models;

namespace Anteroom.BLL
{
    public class MenuManager
    {
        MenuService ms = new MenuService();
        /// <summary>
        /// 根据参数内的值，模糊查询所有酒水
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        #region 获取所有酒水
        public Dictionary<int,Menu1> GetAllMenu(string name)
        {
            return ms.GetAllMenu(name);
        }
        #endregion
        /// <summary>
        /// 检查食材库存
        /// </summary>
        /// <param name="me"></param>
        /// <param name="shu"></param>
        /// <returns></returns>
        #region 检查食材是否够用
        public int UpdateCrib(Menu1 me, int shu)
        {
            return ms.UpDateCrib(me, shu);
        }
        #endregion
        /// <summary>
        /// 退菜
        /// </summary>
        /// <param name="me"></param>
        /// <param name="shu"></param>
        /// <returns></returns>
        #region 退菜
        public int TuiMenu(Menu1 me, int shu)
        {
            return ms.TuiMenu(me, shu);
        }
        #endregion
    }
}
