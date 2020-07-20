using System;
using System.Collections.Generic;

namespace SmartSite.DB.Models
{
    public partial class VDeviceDataDustByDay
    {
        public int? DeviceId { get; set; }
        public decimal? Pm25 { get; set; }
        public decimal? Pm10 { get; set; }
        public decimal? Zs { get; set; }
        public int? Hh { get; set; }
        public string DeviceDate { get; set; }
    }
}
