using System;
using System.Collections.Generic;

namespace SmartSite.DB.Models
{
    public partial class ParametersElectricBox
    {
        public int Id { get; set; }
        public string ProjectId { get; set; }
        public string Jdbh { get; set; }
        public string DevGuid { get; set; }
        public string DevType { get; set; }
        public string DevTypeName { get; set; }
        public string CompanyName { get; set; }
        public string CompanyAddress { get; set; }
        public string InstallAddress { get; set; }
        public string InstallAddrtype { get; set; }
        public int? DtuId { get; set; }
        public string Latitude { get; set; }
        public decimal TempLimit { get; set; }
        public int ElecLimit { get; set; }
        public decimal AroundTempLimit { get; set; }
        public string SubId { get; set; }
        public string Longtitude { get; set; }
    }
}
