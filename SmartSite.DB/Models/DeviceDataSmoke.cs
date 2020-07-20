using System;
using System.Collections.Generic;

namespace SmartSite.DB.Models
{
    public partial class DeviceDataSmoke
    {
        public int Id { get; set; }
        public int? SmokeDeviceId { get; set; }
        public decimal? SmokeVoltage { get; set; }
        public decimal? SmokeOutVoltage { get; set; }
        public decimal? SmokePowerValue { get; set; }
        public decimal? SmokeElectricCurrent { get; set; }
        public decimal? SmokeTemp { get; set; }
        public decimal? SmokeHumidity { get; set; }
        public decimal? SmokeWarnConcentration { get; set; }
        public decimal? SmokePowerSupply { get; set; }
        public bool? SmokeIsWarn { get; set; }
        public int? SmokeWarnType { get; set; }
        public DateTime? SmokeDate { get; set; }
        public DateTime? SmokeDateLog { get; set; }
        public string SmokeTimeStamp { get; set; }
    }
}
