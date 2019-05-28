using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Restaurant.Models;
using Restaurant.DAL;

namespace Restaurant.BLL
{
    public class TurnoverManager
    {
        //创建菜品与酒水对象
        MenuTurnOverService mtos = new MenuTurnOverService();
        CaudleTurnoverService cts = new CaudleTurnoverService();
        public List<Turnover> GetAllMenuTurnOver(DateTime date1,DateTime date2)
        {
            List<Turnover> list = mtos.GetAllMenuTurnOver(date1,date2);
            return list;
        }
        public List<Turnover> GetAllCaudleTurnOver(DateTime date1,DateTime date2)
        {
            List<Turnover> list = cts.GetAllCaudleTurnover(date1,date2);
            return list;
        }
    }
}
