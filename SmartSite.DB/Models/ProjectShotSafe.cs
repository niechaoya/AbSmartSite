using System;
using System.Collections.Generic;

namespace SmartSite.DB.Models
{
    public partial class ProjectShotSafe
    {
        public int Id { get; set; }
        public int? ShotProjectId { get; set; }
        public int? ShotProjectCompanytId { get; set; }
        public string ShotTitle { get; set; }
        public string ShotAddress { get; set; }
        public string ShotLocation { get; set; }
        public string ShotLocationBaidu { get; set; }
        public DateTime? ShotDate { get; set; }
        public DateTime? ShotDateCheck { get; set; }
        public DateTime? ShotDateSerice { get; set; }
        public DateTime? ShotDateAudit { get; set; }
        public string ShotIntro { get; set; }
        public string ShotPhoto { get; set; }
        public int? ShotCheckType { get; set; }
        public string ShotCheckPosition { get; set; }
        public string ShotCheckIntro { get; set; }
        public string ShotCheckPhoto { get; set; }
        public string ShotServiceIntro { get; set; }
        public string ShotServicePhoto { get; set; }
        public int? ShotMemberId { get; set; }
        public string ShotMemberName { get; set; }
        public string ShotMemberTel { get; set; }
        public int? ShotMemberIdCheck { get; set; }
        public string ShotMemberNameCheck { get; set; }
        public string ShotMemberTelCheck { get; set; }
        public int? ShotMemberIdService { get; set; }
        public string ShotMemberNameService { get; set; }
        public string ShotMemberTelService { get; set; }
        public int? ShotMemberIdAuditSelected { get; set; }
        public string ShotMemberIdsAudit { get; set; }
        public string ShotMemberIdsCopy { get; set; }
        public int? ShotStatus { get; set; }
        public int? ShotStatusResult { get; set; }
    }
}
