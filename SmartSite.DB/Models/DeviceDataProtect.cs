using System;
using System.Collections.Generic;

namespace SmartSite.DB.Models
{
    public partial class DeviceDataProtect
    {
        public int Id { get; set; }
        public int? ProtectDeviceId { get; set; }
        public decimal? ProtectVoltage { get; set; }
        public decimal? ProtectElectricCurrent { get; set; }
        public bool? ProtectIsWarn { get; set; }
        public DateTime? ProtectDate { get; set; }
        public DateTime? ProtectDateLog { get; set; }
    }
}
