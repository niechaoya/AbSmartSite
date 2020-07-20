using System;
using System.Collections.Generic;

namespace SmartSite.DB.Models
{
    public partial class MemberLocation
    {
        public int Id { get; set; }
        public int? LocationDeviceId { get; set; }
        public int? LocationMemberId { get; set; }
        public string LocationLongitude { get; set; }
        public string LocationLatitude { get; set; }
        public int? LocationStatus { get; set; }
        public DateTime? LocationDate { get; set; }
    }
}
