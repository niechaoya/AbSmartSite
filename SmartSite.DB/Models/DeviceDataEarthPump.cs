using System;
using System.Collections.Generic;

namespace SmartSite.DB.Models
{
    public partial class DeviceDataEarthPump
    {
        public int Id { get; set; }
        public int? EarthPumpDeviceId { get; set; }
        public decimal? EarthPumpVoltage { get; set; }
        public decimal? EarthPumpElectricCurrent { get; set; }
        public decimal? EarthPumpTemp { get; set; }
        public decimal? EarthPumpWeight { get; set; }
        public bool? EarthPumpIsWarn { get; set; }
        public DateTime? EarthPumpDate { get; set; }
        public DateTime? EarthPumpDateLog { get; set; }
    }
}
