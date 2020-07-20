using System;
using System.Collections.Generic;

namespace SmartSite.DB.Models
{
    public partial class ProjectCheckPoint
    {
        public int Id { get; set; }
        public int? PointProjectId { get; set; }
        public int? PointMemberId { get; set; }
        public string PointCode { get; set; }
        public string PointName { get; set; }
        public string PointTitle { get; set; }
        public string PointMatter { get; set; }
        public int? PointDistance { get; set; }
        public string PointImg { get; set; }
        public string PointLongitude { get; set; }
        public string PointLatitude { get; set; }
        public DateTime? PointDate { get; set; }
    }
}
