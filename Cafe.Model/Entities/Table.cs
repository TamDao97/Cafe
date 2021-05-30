using System;
using System.Collections.Generic;
using System.Text;

namespace Cafe.Model.Entities
{
    public class Table
    {
        public int Id { get; set; }

        /// <summary>
        /// Mã bàn
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// Tên bàn
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        ///Mã Khu vực
        /// </summary>
        public string AreaId { get; set; }

        /// <summary>
        /// Mô tả
        /// </summary>
        public string Description { get; set; }
    }
}
