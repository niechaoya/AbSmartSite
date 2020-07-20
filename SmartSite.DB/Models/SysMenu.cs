using System;
using System.Collections.Generic;

namespace SmartSite.DB.Models
{
    public partial class SysMenu
    {
        public int Id { get; set; }
        public int TypeId { get; set; }
        public int MenuId { get; set; }
        public int? ParentMenuId { get; set; }
        public string MenuName { get; set; }
        public string MenuIcon { get; set; }
        public string MenuUrl { get; set; }
        public string MenuButton { get; set; }
        public int? MenuLevel { get; set; }
        public int? MenuOrder { get; set; }
        public bool? MenuIsShow { get; set; }
        public bool? MenuAppFlag { get; set; }
        public string MenuAppGroup { get; set; }
        public string MenuAppName { get; set; }
        public string MenuAppIntro { get; set; }
        public string MenuAppPhoto { get; set; }
        public string Remark { get; set; }
        public DateTime? AddDate { get; set; }
        public int? AddMan { get; set; }
    }
}
