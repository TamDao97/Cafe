using System;
using System.Collections.Generic;
using System.Text;

namespace Cafe.Model.Entities
{
    public class Employee
    {
        public int Id { get; set; }

        /// <summary>
        /// Mã nhân viên
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// Tên nhân viên
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Giới tính
        /// </summary>
        public string Gender { get; set; }

        /// <summary>
        /// Chức vụ
        /// </summary>
        public string Level { get; set; }

        /// <summary>
        /// Ngày vào làm
        /// </summary>
        public string WorkStartDate { get; set; }

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
