using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Anteroom.DAL;
using Anteroom.Models;

namespace Anteroom.BLL
{
    public class JieZhang
    {
        CaudleTurnoverService cts = new CaudleTurnoverService();
        MenuTurnoverService mts = new MenuTurnoverService();
        public int AddCaudleTurnoverService(Dictionary<int,Caudle> dic)
        {
            return cts.AddCaudlTurnover(dic);
        }
        public int AddMenuTurnoverService(Dictionary<int, Menu1> dic)
        {
            return mts.AddMenuTurnover(dic);
        }
    }
}
