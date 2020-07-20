using System;
using System.Collections.Generic;

namespace SmartSite.DB.Models
{
    public partial class Area
    {
        public int Id { get; set; }
        public int? AreaPid { get; set; }
        public int? AreaLevel { get; set; }
        public string AreaCode { get; set; }
        public string AreaName { get; set; }
        public string AreaRemark { get; set; }
        public string AreaPhoto { get; set; }
    }
}
