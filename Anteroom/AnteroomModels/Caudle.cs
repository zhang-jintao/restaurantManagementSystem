using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anteroom.Models
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
        public double CaudleMoney { get; set; }
        /// <summary>
        /// 酒水进价
        /// </summary>
        public double CaudleGoldenCalf { get; set; }
        /// <summary>
        /// 酒水库存
        /// </summary>
        public int CaudleRepertory { get; set; }
        /// <summary>
        /// 已点数量
        /// </summary>
        public int Count { get; set; }
    }
}
