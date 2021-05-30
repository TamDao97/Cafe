using System;
using System.Collections.Generic;
using System.Text;

namespace Cafe.Model.Entities
{
    public class CustomerType
    {
        public int Id { get; set; }

        /// <summary>
        /// Tên loại
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Giảm giá
        /// </summary>
        public double Discount { get; set; }
    }
}
