using System;
using System.Collections.Generic;

namespace SmartSite.DB.Models
{
    public partial class ProjectShot
    {
        public int Id { get; set; }
        public int? ShotProjectId { get; set; }
        public string ShotTitle { get; set; }
        public string ShotDescribe { get; set; }
        public string ShotPhoto { get; set; }
        public DateTime? ShotDate { get; set; }
        public DateTime? ShotDateAudit { get; set; }
        public int? ShotMemberId { get; set; }
        public string ShotMemberName { get; set; }
        public string ShotMemberTel { get; set; }
        public int? ShotMemberIdAuditSelected { get; set; }
        public string ShotMemberIdsAudit { get; set; }
        public string ShotMemberIdsCopy { get; set; }
        public string ShotStatus { get; set; }
    }
}
