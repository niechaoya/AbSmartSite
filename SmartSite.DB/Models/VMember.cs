using System;
using System.Collections.Generic;

namespace SmartSite.DB.Models
{
    public partial class VMember
    {
        public int Id { get; set; }
        public int? MemberCompanyId { get; set; }
        public int? MemberProjectId { get; set; }
        public int? MemberWorkTypeId { get; set; }
        public int? MemberDeptId { get; set; }
        public string MemberName { get; set; }
        public string MemberTel { get; set; }
        public string MemberPwd { get; set; }
        public string MemberIntro { get; set; }
        public string MemberPhoto { get; set; }
        public string MemberPhotoHead { get; set; }
        public int? MemberSex { get; set; }
        public int? MemberAge { get; set; }
        public int? MemberType { get; set; }
        public string MemberIdCard { get; set; }
        public string MemberIdCardPhoto { get; set; }
        public string MemberCardBook { get; set; }
        public string MemberContract { get; set; }
        public string MemberEmail { get; set; }
        public string MemberSendId { get; set; }
        public string MemberLocation { get; set; }
        public int? MemberArea1Id { get; set; }
        public string MemberArea1 { get; set; }
        public int? MemberArea2Id { get; set; }
        public string MemberArea2 { get; set; }
        public int? MemberArea3Id { get; set; }
        public string MemberArea3 { get; set; }
        public string MemberAddress { get; set; }
        public int? MemberStatus { get; set; }
        public int? MemberPid { get; set; }
        public int? MemberRoleId { get; set; }
        public int? MemberAuditStatus { get; set; }
        public DateTime? MemberAuditDate { get; set; }
        public DateTime? MemberDateBirthday { get; set; }
        public DateTime? MemberDateReg { get; set; }
        public DateTime? MemberDateUpdate { get; set; }
        public string UserRoleName { get; set; }
        public string CompanyName { get; set; }
    }
}
