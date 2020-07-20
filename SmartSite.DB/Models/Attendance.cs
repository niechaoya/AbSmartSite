using System;
using System.Collections.Generic;

namespace SmartSite.DB.Models
{
    public partial class Attendance
    {
        public int Id { get; set; }
        public int? Uid { get; set; }
        public DateTime? ClockInTime { get; set; }
        public int? State { get; set; }
        public DateTime? CreateTime { get; set; }
        public string Picture { get; set; }
        public int? TypeOfPunch { get; set; }
    }
}
