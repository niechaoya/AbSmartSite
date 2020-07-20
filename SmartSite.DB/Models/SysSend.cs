using System;
using System.Collections.Generic;

namespace SmartSite.DB.Models
{
    public partial class SysSend
    {
        public int Id { get; set; }
        public DateTime? SendDate { get; set; }
        public string SendTitle { get; set; }
        public string SendIntro { get; set; }
        public int? SendMan { get; set; }
        public string SendManName { get; set; }
        public string SendMemberListPlan { get; set; }
        public string SendMemberListGo { get; set; }
        public string SendMemberListOk { get; set; }
        public string SendKeyword { get; set; }
        public DateTime? SendDateUpdate { get; set; }
        public DateTime? SendDateSend { get; set; }
        public int? SendObjectId { get; set; }
        public int? SendObjectType { get; set; }
        public string SendObjectTypeName { get; set; }
        public int? SendStatus { get; set; }
    }
}
