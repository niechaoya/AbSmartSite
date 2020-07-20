using System;
using System.Collections.Generic;

namespace SmartSite.DB.Models
{
    public partial class DustEnvironmentalData
    {
        public int Id { get; set; }
        public string ProjectId { get; set; }
        public string Jdbh { get; set; }
        public string DevGuid { get; set; }
        public string MdName { get; set; }
        public string MdType { get; set; }
        public string MdModel { get; set; }
        public string MeOption { get; set; }
        public DateTime? InstallDate { get; set; }
        public string InstallLocation { get; set; }
        public string RunningState { get; set; }
        public string SubId { get; set; }
    }
}
