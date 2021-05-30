using System;
using System.Collections.Generic;
using System.Text;

namespace Cafe.Model.Entities
{
    public class SalaryDetail
    {
        public int Id { get; set; }

        /// <summary>
        /// Ca làm
        /// </summary>
        public int ScheduleJobId { get; set; }

        /// <summary>
        /// Nhân viên
        /// </summary>
        public int EmployeeId { get; set; }

        /// <summary>
        /// Tổng số ca làm trong tháng
        /// </summary>
        public int TotalScheduleJob { get; set; }

        /// <summary>
        /// Tổng lương
        /// </summary>
        public double TotalSalary { get; set; }
    }
}
