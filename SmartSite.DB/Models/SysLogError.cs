using System;
using System.Collections.Generic;

namespace SmartSite.DB.Models
{
    public partial class SysLogError
    {
        public int Id { get; set; }
        public int? MemberId { get; set; }
        public string ErrorUrl { get; set; }
        public string ErrorAction { get; set; }
        public string ErrorActionName { get; set; }
        public DateTime? ErrorAddTime { get; set; }
        public string ErrorArgs { get; set; }
        public string ErrorIntro { get; set; }
        public int? ErrorType { get; set; }
        public string ErrorFlag { get; set; }
        public int? ErrorProjectId { get; set; }
    }
}
