using System;
using System.Collections.Generic;

namespace SmartSite.DB.Models
{
    public partial class VProjectMember
    {
        public int Id { get; set; }
        public int? ProjectId { get; set; }
        public int? ProjectCompanyId { get; set; }
        public string ProjectDept1Name { get; set; }
        public string ProjectDept2Name { get; set; }
        public int? MemberId { get; set; }
        public string MemberName { get; set; }
        public string MemberTel { get; set; }
        public string MemberType { get; set; }
        public int? MemberSysRole { get; set; }
        public int? MemberSysAuditStatus { get; set; }
        public DateTime? MemberSysAuditDate { get; set; }
        public int? MemberIsAccount { get; set; }
        public DateTime? MemberCreateDate { get; set; }
        public string ProjectName { get; set; }
        public string ProjectPhoto { get; set; }
        public string ProjectEffectPhoto { get; set; }
        public string UserRoleName { get; set; }
        public int? MemberIsShow { get; set; }
        public string ProjectDept3Name { get; set; }
        public int? ProjectStatus { get; set; }
        public int? ProjectType { get; set; }
        public int? ProjectIsKeyPoint { get; set; }
        public string ProjectArea1 { get; set; }
        public string ProjectArea2 { get; set; }
        public string ProjectArea3 { get; set; }
        public string ProjectAddress { get; set; }
    }
}
