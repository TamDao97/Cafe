using System;
using System.Collections.Generic;
using System.Text;

namespace Cafe.Model.Entities
{
    public class GoodsType
    {
        public int Id { get; set; }

        /// <summary>
        /// Mã loại hàng
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// Tên loại hàng
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Mô tả
        /// </summary>
        public string Description { get; set; }
    }
}
