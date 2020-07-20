using System;
using System.Collections.Generic;

namespace SmartSite.DB.Models
{
    public partial class SysLog
    {
        public int Id { get; set; }
        public DateTime? LogDate { get; set; }
        public string LogFormCode { get; set; }
        public string LogFormName { get; set; }
        public string LogActiveType { get; set; }
        public string LogActiveName { get; set; }
        public string LogActiveFnction { get; set; }
        public string LogActiveUrl { get; set; }
        public string LogActiveUrlQuery { get; set; }
        public string LogActiveUrlForm { get; set; }
        public string LogActiveIntro { get; set; }
        public int? LogStatus { get; set; }
        public string LogStatusName { get; set; }
        public int? LogMemberId { get; set; }
        public string LogMemberName { get; set; }
        public int? LogProjectId { get; set; }
    }
}
