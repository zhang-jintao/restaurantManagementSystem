using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Restaurant.DAL;
using Restaurant.Models;

namespace Restaurant.BLL
{
    public class CaudleManager
    {
        CaudleService cs = new CaudleService();
        #region 删除酒水
        public int DelCaucle(int id)
        {
            int k = cs.DelCaudle(id);
            return k;
        }
        #endregion
        #region 新增酒水
        public int InsertCaudle(string name, decimal money1, decimal money2, int no)
        {
            int k = cs.InsertCaudle(name,money1,money2,no);
            return k;
        }
        #endregion
        #region 修改酒水
        public int UpdCaudle(int id, decimal money1, decimal money2)
        {
            int k = cs.UpdCaudle(id,money1,money2);
            return k;
        }
        #endregion
        #region 增加库存
        public int InsertCaudleUpdate(int no, int id)
        {
            int k = cs.UpdateCaudle(no,id);
            return k;
        }
        #endregion
    }
}
