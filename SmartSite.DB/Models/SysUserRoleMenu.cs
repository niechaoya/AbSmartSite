using System;
using System.Collections.Generic;

namespace SmartSite.DB.Models
{
    public partial class SysUserRoleMenu
    {
        public int Id { get; set; }
        public int? RoleId { get; set; }
        public int? MenuId { get; set; }
        public string ButtonIds { get; set; }
        public DateTime? UpdateTime { get; set; }
        public int? UpdateUser { get; set; }
    }
}
