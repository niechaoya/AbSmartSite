using System;
using System.Collections.Generic;

namespace SmartSite.DB.Models
{
    public partial class Project6milepost
    {
        public int Id { get; set; }
        public int? MilepostProjectId { get; set; }
        public string MilepostName { get; set; }
        public string MilepostDescribe { get; set; }
        public DateTime? MilepostStartDate { get; set; }
        public DateTime? MilepostEndDate { get; set; }
        public int? MilepostStatus { get; set; }
    }
}
