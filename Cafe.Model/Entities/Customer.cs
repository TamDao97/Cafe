using System;
using System.Collections.Generic;
using System.Text;

namespace Cafe.Model.Entities
{
    public class Customer
    {
        public int Id { get; set; }

        /// <summary>
        /// Loại khách hàng
        /// </summary>
        public int CustomerTypeId { get; set; }

        /// <summary>
        /// Mã khách hàng
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// Tên khách hàng
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

        /// <summary>
        /// Điểm tích lũy
        /// </summary>
        public int AccumulatedPoint { get; set; }
    }
}
