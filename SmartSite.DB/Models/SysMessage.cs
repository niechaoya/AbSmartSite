using System;
using System.Collections.Generic;

namespace SmartSite.DB.Models
{
    public partial class SysMessage
    {
        public int Id { get; set; }
        public string MessageType { get; set; }
        public string MessageTitle { get; set; }
        public string MessageContent { get; set; }
        public bool? MessageIsRead { get; set; }
        public int? MessageProjectId { get; set; }
        public string MessageMemberIdTo { get; set; }
        public string CreateMember { get; set; }
        public DateTime? CreateDate { get; set; }
    }
}
