using System;
using System.Collections.Generic;

namespace SmartSite.DB.Models
{
    public partial class ProjectShotSafeMember
    {
        public int Id { get; set; }
        public int? ShotId { get; set; }
        public int? ShotMemberId { get; set; }
        public DateTime? ShotDate { get; set; }
    }
}
