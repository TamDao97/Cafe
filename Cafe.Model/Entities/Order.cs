using System;
using System.Collections.Generic;
using System.Text;

namespace Cafe.Model.Entities
{
    public class Order
    {
        public int Id { get; set; }

        /// <summary>
        /// Mã Hóa đơn
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// Nhân viên
        /// </summary>
        public int EmployeeId { get; set; }

        /// <summary>
        /// Khách hàng
        /// </summary>
        public int CustomerId { get; set; }

        /// <summary>
        /// Bàn
        /// </summary>
        public int TableId { get; set; }

        /// <summary>
        /// Ngày lập hóa đơn
        /// </summary>
        public DateTime DateOrder { get; set; }

        /// <summary>
        /// Tổng tiền
        /// </summary>
        public double TotalPrice { get; set; }

        /// <summary>
        /// Điểm tích lũy
        /// </summary>
        public double AccumulatedPoint { get; set; }

        /// <summary>
        /// Giảm giá
        /// </summary>
        public double Discount { get; set; }

        /// <summary>
        /// Chi phí khác
        /// </summary>
        public string OrtherCosts { get; set; }
    }
}
