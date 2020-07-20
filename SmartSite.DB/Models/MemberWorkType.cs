using System;
using System.Collections.Generic;

namespace SmartSite.DB.Models
{
    public partial class MemberWorkType
    {
        public int Id { get; set; }
        public string WorkTypeName { get; set; }
        public string WorkTypeIntro { get; set; }
    }
}
