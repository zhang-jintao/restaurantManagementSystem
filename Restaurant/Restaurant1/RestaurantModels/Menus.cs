using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Models
{
    public class Menus
    {
        /// <summary>
        /// 菜品编号
        /// </summary>
        public int DishId { get; set; }
        /// <summary>
        /// 菜品名称
        /// </summary>
        public string DishName { get; set; }
        /// <summary>
        /// 菜品价格
        /// </summary>
        public decimal DishMoney { get; set; }
        /// <summary>
        /// 食材·1
        /// </summary>
        public int CribOne { get; set; }
        /// <summary>
        /// 食材·2
        /// </summary>
        public int CribTwo { get; set; }
        /// <summary>
        /// 食材·1·需要数量
        /// </summary>
        public Double CribOneX { get; set; }
        /// <summary>
        /// 食材·2·需要数量
        /// </summary>
        public Double CribTwoX { get; set; }
        /// <summary>
        /// 食材·1·名称
        /// </summary>
        public string CribOneMenu { get; set; }
        /// <summary>
        /// 食材·2·名称
        /// </summary>
        public string CribTwoMenu { get; set; }
    }
}
