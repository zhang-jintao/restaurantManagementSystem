using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Models
{
    public class Turnover
    {
        /// <summary>
        /// 编号
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// 名称
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 卖出次数
        /// </summary>
        public int Number { get; set; }
        /// <summary>
        /// 获得利润
        /// </summary>
        public decimal AllMoney { get; set; }
        /// <summary>
        /// 卖出时间
        /// </summary>
        public string DateTime { get; set; }
    }
}
