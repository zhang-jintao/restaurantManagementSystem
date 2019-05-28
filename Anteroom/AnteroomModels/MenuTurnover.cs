using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Models
{
    public class MenuTurnover
    {
        /// <summary>
        /// 菜品编号
        /// </summary>
        public int MenuId { get; set; }
        /// <summary>
        /// 菜品卖出次数
        /// </summary>
        public int MenuNumber { get; set; }
        /// <summary>
        /// 菜品利润
        /// </summary>
        public decimal AllMoneyMenu { get; set; }
        /// <summary>
        /// 菜品卖出时间
        /// </summary>
        public DateTime DateTime { get; set; }
    }
}
