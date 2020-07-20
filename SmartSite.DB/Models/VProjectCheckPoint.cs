using System;
using System.Collections.Generic;

namespace SmartSite.DB.Models
{
    public partial class VProjectCheckPoint
    {
        public int Id { get; set; }
        public int? PointProjectId { get; set; }
        public int? PointMemberId { get; set; }
        public string PointName { get; set; }
        public string PointMatter { get; set; }
        public string PointLongitude { get; set; }
        public string PointLatitude { get; set; }
        public DateTime? PointDate { get; set; }
        public string MemberName { get; set; }
        public string MemberTel { get; set; }
    }
}
