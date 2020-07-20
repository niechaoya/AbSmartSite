using System;
using System.Collections.Generic;

namespace SmartSite.DB.Models
{
    public partial class VUserRoleMenu
    {
        public int Id { get; set; }
        public int? RoleId { get; set; }
        public int? MenuId { get; set; }
        public string ButtonIds { get; set; }
        public DateTime? UpdateTime { get; set; }
        public int? UpdateUser { get; set; }
        public string MenuName { get; set; }
        public int? MenuOrder { get; set; }
        public string MenuUrl { get; set; }
        public int? AddMan { get; set; }
    }
}
