using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Models
{
    public class Caudle
    {
        /// <summary>
        /// 酒水ID
        /// </summary>
        public int CaudleId { get; set; }
        /// <summary>
        /// 酒水名称
        /// </summary>
        public string CaudleName { get; set; }
        /// <summary>
        /// 酒水价格
        /// </summary>
        public decimal CaudleMoney { get; set; }
        /// <summary>
        /// 酒水购入价格
        /// </summary>
        public decimal CaudleGoldenCalf { get; set; }
        /// <summary>
        /// 酒水库存
        /// </summary>
        public int CaudleRepertory { get; set; }
    }
}
