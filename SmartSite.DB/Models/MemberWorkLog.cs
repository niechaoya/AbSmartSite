using System;
using System.Collections.Generic;

namespace SmartSite.DB.Models
{
    public partial class MemberWorkLog
    {
        public int Id { get; set; }
        public int? WorkLogMembeId { get; set; }
        public int? WorkLogProjectId { get; set; }
        public DateTime? WorkLogStartDate { get; set; }
        public DateTime? WorkLogEndDate { get; set; }
        public decimal? WorkLogHour { get; set; }
    }
}
