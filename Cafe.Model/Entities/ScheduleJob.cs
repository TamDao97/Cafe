using System;
using System.Collections.Generic;
using System.Text;

namespace Cafe.Model.Entities
{
    public class ScheduleJob
    {
        public int Id { get; set; }

        /// <summary>
        /// Mã ca làm việc
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// Tên ca làm việc
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Thời gian bắt đầu
        /// </summary>
        public string TimeStart { get; set; }

        /// <summary>
        /// Thời gian kết thúc
        /// </summary>
        public string TimeEnd { get; set; }

        /// <summary>
        /// Tiền công
        /// </summary>
        public double Price { get; set; }
    }
}
