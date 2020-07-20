using System;
using System.Collections.Generic;

namespace SmartSite.DB.Models
{
    public partial class SysDept
    {
        public int Id { get; set; }
        public string DeptName { get; set; }
        public string DeptIntro { get; set; }
        public int? DeptPid { get; set; }
        public int? DeptMemberQty { get; set; }
        public string DeptLinkMan { get; set; }
        public string DeptLinkTel { get; set; }
    }
}
