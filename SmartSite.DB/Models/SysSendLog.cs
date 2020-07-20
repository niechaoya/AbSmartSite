using System;
using System.Collections.Generic;

namespace SmartSite.DB.Models
{
    public partial class SysSendLog
    {
        public int Id { get; set; }
        public int? SendId { get; set; }
        public int? SendMemberId { get; set; }
        public DateTime? SendDate { get; set; }
        public string SendIntro { get; set; }
    }
}
