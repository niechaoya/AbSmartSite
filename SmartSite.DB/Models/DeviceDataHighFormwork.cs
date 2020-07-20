using System;
using System.Collections.Generic;

namespace SmartSite.DB.Models
{
    public partial class DeviceDataHighFormwork
    {
        public int Id { get; set; }
        public int? HighFormworkDeviceId { get; set; }
        public decimal? HighFormworkSettle { get; set; }
        public decimal? HighFormworkShift { get; set; }
        public decimal? HighFormworkTilt { get; set; }
        public decimal? HighFormworkAxialForce { get; set; }
        public bool? HighFormworkIsWarn { get; set; }
        public DateTime? HighFormworkDate { get; set; }
        public DateTime? HighFormworkDateLog { get; set; }
    }
}
