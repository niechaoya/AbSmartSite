using System;
using System.Collections.Generic;

namespace SmartSite.DB.Models
{
    public partial class ProjectShotLog
    {
        public long Id { get; set; }
        public DateTime? LogDate { get; set; }
        public int? LogType { get; set; }
        public int? LogShotId { get; set; }
        public int? LogAuditMemberId { get; set; }
        public string LogAuditMemberName { get; set; }
        public int? LogAuditStatusId { get; set; }
        public string LogAuditStatusName { get; set; }
        public string LogIntro { get; set; }
    }
}
