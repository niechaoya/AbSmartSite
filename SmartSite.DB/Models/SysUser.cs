using System;
using System.Collections.Generic;

namespace SmartSite.DB.Models
{
    public partial class SysUser
    {
        public int Id { get; set; }
        public string UserNo { get; set; }
        public int? UserCompanyId { get; set; }
        public string UserAccount { get; set; }
        public string UserKey { get; set; }
        public string UserPhotoHead { get; set; }
        public string UserName { get; set; }
        public string UserNickName { get; set; }
        public string UserPhone { get; set; }
        public string UserEmail { get; set; }
        public string UserPwd { get; set; }
        public int? UserStatus { get; set; }
        public bool? UserIsAdmin { get; set; }
        public bool? UserIsRef { get; set; }
        public int? UserIsWx { get; set; }
        public DateTime? UserDateCreate { get; set; }
        public DateTime? UserDateLogin { get; set; }
        public DateTime? UserDateLoginApi { get; set; }
        public DateTime? UserDateRequest { get; set; }
        public DateTime? UserDateRequestApi { get; set; }
        public string UserPower { get; set; }
        public string UserPowerMenu { get; set; }
        public int? UserRoleId { get; set; }
        public string UserRoleName { get; set; }
        public int? UserTypeId { get; set; }
        public int? UserGroupId { get; set; }
        public int? UserLoginTypeId { get; set; }
        public int? UserLoginTypeObjectId { get; set; }
        public int? UserMemberId { get; set; }
        public int? UserProjectId { get; set; }
        public string UserLanguage { get; set; }
        public int? UserTimeZone { get; set; }
        public string UserSendid { get; set; }
        public string UserLocation { get; set; }
        public string UserUrlWx { get; set; }
        public string UserMemo { get; set; }
        public string UserJobNumber { get; set; }
    }
}
