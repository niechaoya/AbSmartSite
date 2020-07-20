using System;
using System.Collections.Generic;

namespace SmartSite.DB.Models
{
    public partial class WeixinSend
    {
        public int Id { get; set; }
        public int? SendPid { get; set; }
        public string SendTitle { get; set; }
        public string SendDesc { get; set; }
        public DateTime? SendDate { get; set; }
        public int? SendLogId { get; set; }
        public int? SendOrder { get; set; }
        public int? SendStatus { get; set; }
        public DateTime? SendStatusDate { get; set; }
        public string SendUrl { get; set; }
    }
}
