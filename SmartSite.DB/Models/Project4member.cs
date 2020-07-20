using System;
using System.Collections.Generic;

namespace SmartSite.DB.Models
{
    public partial class Project4member
    {
        public int Id { get; set; }
        public int? ProjectId { get; set; }
        public int? ProjectCompanyId { get; set; }
        public string ProjectDept1Name { get; set; }
        public string ProjectDept2Name { get; set; }
        public string ProjectDept3Name { get; set; }
        public int? MemberId { get; set; }
        public string MemberName { get; set; }
        public string MemberTel { get; set; }
        public string MemberType { get; set; }
        public int? MemberSysRole { get; set; }
        public int? MemberSysAuditStatus { get; set; }
        public DateTime? MemberSysAuditDate { get; set; }
        public int? MemberIsAccount { get; set; }
        public DateTime? MemberCreateDate { get; set; }
        public int? MemberIsShow { get; set; }
    }
}
