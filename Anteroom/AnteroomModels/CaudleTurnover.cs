using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Models
{
    public class CaudleTurnover
    {
        /// <summary>
        /// 酒水编号
        /// </summary>
        public int CaudleId { get; set; }
        /// <summary>
        /// 酒水卖出次数
        /// </summary>
        public int CaudleNumber { get; set; }
        /// <summary>
        /// 酒水获得利润
        /// </summary>
        public double AllMoneyCaudle { get; set; }
        /// <summary>
        /// 菜品卖出时间
        /// </summary>
        public DateTime DateTime { get; set; }
    }
}
