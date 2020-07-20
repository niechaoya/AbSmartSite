using System;
using System.Collections.Generic;

namespace SmartSite.DB.Models
{
    public partial class MemberProject
    {
        public int Id { get; set; }
        public int? MemberId { get; set; }
        public int? MemberProjectId { get; set; }
        public int? MemberStatus { get; set; }
        public DateTime? MemberDate { get; set; }
    }
}
