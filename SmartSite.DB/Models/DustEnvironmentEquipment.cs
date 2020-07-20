using System;
using System.Collections.Generic;

namespace SmartSite.DB.Models
{
    public partial class DustEnvironmentEquipment
    {
        public int Id { get; set; }
        public int HjPguid { get; set; }
        public string Jdbh { get; set; }
        public string HjDguid { get; set; }
        public string HjPm10 { get; set; }
        public string HjPm25 { get; set; }
        public string HjFs { get; set; }
        public string HjFx { get; set; }
        public string HjWd { get; set; }
        public string HjSd { get; set; }
        public string HjQy { get; set; }
        public string HjDy { get; set; }
        public string HjBzjd { get; set; }
        public string HjBzwd { get; set; }
        public string HjBzwdX { get; set; }
        public string HjBzsd { get; set; }
        public DateTime Yxsk { get; set; }
        public string Tsp { get; set; }
        public string SubId { get; set; }
        public string HjZs { get; set; }
    }
}
