using System;
using System.Collections.Generic;

namespace SmartSite.DB.Models
{
    public partial class ProjectCheckNote
    {
        public int Id { get; set; }
        public int? CheckCompanyId { get; set; }
        public string CheckCompanyName { get; set; }
        public string CheckDeptName { get; set; }
        public int? CheckProjectId { get; set; }
        public int? CheckType { get; set; }
        public string CheckParts { get; set; }
        public int? CheckCreateMemberId { get; set; }
        public int? CheckMemberId { get; set; }
        public int? CheckApprovalMemberId { get; set; }
        public int? CheckCopyMemberId { get; set; }
        public string CheckTitle { get; set; }
        public int? CheckScore { get; set; }
        public string CheckFile { get; set; }
        public string CheckPhoto { get; set; }
        public string CheckDesc { get; set; }
        public int? CheckStatus { get; set; }
        public DateTime? CheckTime { get; set; }
        public DateTime? CheckDate { get; set; }
    }
}
