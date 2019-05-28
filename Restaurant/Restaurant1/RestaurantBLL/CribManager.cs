using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Restaurant.DAL;
using Restaurant.Models;

namespace Restaurant.BLL
{
    public class CribManager
    {
        CribService cs = new CribService();

        #region 检查食材是否存在
        /// <summary>
        /// 检查食材是否存在
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public int CheckName(string name)
        {
            int k = cs.CheckName(name);
            return k;
        }
        #endregion

        #region 新增食材
        /// <summary>
        /// 新增食材
        /// </summary>
        /// <param name="name"></param>
        /// <param name="money"></param>
        /// <param name="kucun"></param>
        /// <returns></returns>
        public int InsertCrib(string name,decimal money,double kucun)
        {
            int k = cs.InsertCribs(name,money,kucun);
            return k;
        }        
        #endregion

        #region 修改食材
        /// <summary>
        /// 修改食材
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="money"></param>
        /// <returns></returns>
        public int UpdateCrib(int id ,string name ,decimal money)
        {
            int k = cs.UpdateCrib(id ,name,money);
            return k;
        }
        #endregion

        #region 删除食材
        public int DeleteCrib(int id)
        {
            int k = cs.DeleteCrib(id);
            return k;
        }
        #endregion

        #region 增加食材库存
        public int ZengJia(int id, double liang)
        {
            int k = cs.InertCrib(id,liang);
            return k;
        }
        #endregion


    }
}
