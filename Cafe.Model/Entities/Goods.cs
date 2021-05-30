using System;
using System.Collections.Generic;
using System.Text;

namespace Cafe.Model.Entities
{
    public class Goods
    {
        public int Id { get; set; }

        /// <summary>
        /// Mã hàng 
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// Tên hàng
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Loại hàng
        /// </summary>
        public string GoodsTypeId { get; set; }

        /// <summary>
        /// Nhà cung cấp
        /// </summary>
        public int SupplierId { get; set; }

        /// <summary>
        /// ảnh
        /// </summary>
        public string ImagePath { get; set; }

        /// <summary>
        /// Giá
        /// </summary>
        public double Price { get; set; }
    }
}
