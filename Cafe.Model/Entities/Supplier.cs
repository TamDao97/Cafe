using System;
using System.Collections.Generic;
using System.Text;

namespace Cafe.Model.Entities
{
    public class Supplier
    {
        public int Id { get; set; }

        /// <summary>
        /// Mã nhà cung cấp
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// Tên nhà cung cấp
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Địa chỉ
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// Số điện thoại
        /// </summary>
        public string Phone { get; set; }
    }
}
