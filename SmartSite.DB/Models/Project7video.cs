using System;
using System.Collections.Generic;

namespace SmartSite.DB.Models
{
    public partial class Project7video
    {
        public int Id { get; set; }
        public int? VideoProjectId { get; set; }
        public string VideoCode { get; set; }
        public string VideoName { get; set; }
        public string VideoUrl { get; set; }
        public int? VideoStatus { get; set; }
        public string VideoInstallAddress { get; set; }
        public DateTime? VideoInstallDate { get; set; }
        public string VideoType { get; set; }
        public string RegionForUse { get; set; }
    }
}
