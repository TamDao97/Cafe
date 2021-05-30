using System;
using System.Collections.Generic;
using System.Text;

namespace Cafe.Model.Entities
{
    public class ReceiptDetail
    {
        public int Id { get; set; }

        /// <summary>
        /// Phiếu nhập
        /// </summary>
        public int ReceiptId { get; set; }

        /// <summary>
        /// Hàng hóa
        /// </summary>
        public int GoodsId { get; set; }

        /// <summary>
        /// Số lượng
        /// </summary>
        public int Amount { get; set; }

        /// <summary>
        /// Thành tiền
        /// </summary>
        public double Price { get; set; }
    }
}
