using System;
using System.Collections.Generic;

namespace SmartSite.DB.Models
{
    public partial class SysShare
    {
        public int Id { get; set; }
        public DateTime? ShareDate { get; set; }
        public int? ShareMemberId { get; set; }
        public int? ShareObjectType { get; set; }
        public int? ShareObjectId { get; set; }
        public string ShareObjectIntro { get; set; }
        public string ShareType { get; set; }
        public string ShareUrl { get; set; }
        public int? ShareCountView { get; set; }
        public int? ShareCountIp { get; set; }
    }
}
