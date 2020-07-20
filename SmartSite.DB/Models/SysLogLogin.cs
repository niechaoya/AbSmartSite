using System;
using System.Collections.Generic;

namespace SmartSite.DB.Models
{
    public partial class SysLogLogin
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int? UserType { get; set; }
        public DateTime? LoginDate { get; set; }
        public string LoginMacId { get; set; }
        public string LoginMacType { get; set; }
        public string LoginLocation { get; set; }
        public int? LoginType { get; set; }
        public int? LoginProjectId { get; set; }
    }
}
