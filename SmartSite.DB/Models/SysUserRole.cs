using System;
using System.Collections.Generic;

namespace SmartSite.DB.Models
{
    public partial class SysUserRole
    {
        public int Id { get; set; }
        public string UserRoleName { get; set; }
        public string UserRoleLogo { get; set; }
        public string UserRoleRemark { get; set; }
        public int? UserRoleStatus { get; set; }
        public int? UserRoleAgencyId { get; set; }
        public string UserRoleAgencyName { get; set; }
        public int? UserRoleOrder { get; set; }
        public string UserRolePower { get; set; }
        public string UserRolePowerMenu { get; set; }
        public int? UserRoleLoginTypeId { get; set; }
        public bool? UserRoleIsRef { get; set; }
        public bool? UserRoleIsAdmin { get; set; }
        public int? UserRoleAddMan { get; set; }
        public DateTime? UserRoleAddDate { get; set; }
        public int? UserProjectId { get; set; }
    }
}
