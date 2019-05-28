using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Anteroom.Models;
using Anteroom.DAL;

namespace Anteroom.BLL
{
    public class CaudleManager
    {
        CaudleService cs = new CaudleService();
        /// <summary>
        /// 根据参数内的值，模糊查询所有酒水
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        #region 获取全部酒
        public Dictionary<int,Caudle> GetAllCaudle(string name)
        {
            return cs.GetAllCaudle(name);
        }
        #endregion
        /// <summary>
        /// 减少酒库存，如果不足则返回-1
        /// </summary>
        /// <param name="c"></param>
        /// <param name="shu"></param>
        /// <returns></returns>
        #region 减少酒库存
        public int UpdateCaudle(Caudle c, int shu)
        {
            return cs.UpdateCaudle(c,shu);
        }
        #endregion
        /// <summary>
        /// 根据酒对象退酒
        /// </summary>
        /// <param name="c"></param>
        /// <param name="shu"></param>
        /// <returns></returns>
        #region 退酒
        public int TuiCaudle(Caudle c, int shu)
        {
            return cs.TuiCaudle(c, shu);
        }
        #endregion
       
    }
}
