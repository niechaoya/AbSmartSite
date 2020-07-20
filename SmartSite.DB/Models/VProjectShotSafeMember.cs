using System;
using System.Collections.Generic;

namespace SmartSite.DB.Models
{
    public partial class VProjectShotSafeMember
    {
        public int Id { get; set; }
        public int? ShotId { get; set; }
        public int? ShotMemberId { get; set; }
        public DateTime? ShotDate { get; set; }
        public string MemberName { get; set; }
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
