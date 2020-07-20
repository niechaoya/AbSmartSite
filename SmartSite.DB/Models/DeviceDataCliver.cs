using System;
using System.Collections.Generic;

namespace SmartSite.DB.Models
{
    public partial class DeviceDataCliver
    {
        public int Id { get; set; }
        public int? CliverDeviceId { get; set; }
        public decimal? CliverTemp { get; set; }
        public decimal? CliverHumidity { get; set; }
        public decimal? CliverVoltage { get; set; }
        public decimal? CliverWeight { get; set; }
        public decimal? CliverMoment { get; set; }
        public decimal? CliverHeight { get; set; }
        public decimal? CliverRange { get; set; }
        public decimal? CliverWindSpeed { get; set; }
        public decimal? CliverRotation { get; set; }
        public decimal? CliverDipAngle { get; set; }
        public bool? CliverIsWarn { get; set; }
        public DateTime? CliverDate { get; set; }
        public DateTime? CliverDateLog { get; set; }
    }
}
