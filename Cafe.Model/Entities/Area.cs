using System;
using System.Collections.Generic;
using System.Text;

namespace Cafe.Model.Entities
{
    public class Area
    {
        public int Id { get; set; }

        /// <summary>
        /// Mã khu vực
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// Tên khu vực
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Trạng thái
        /// </summary>
        public string Status { get; set; }
    }
}
