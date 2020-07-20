using System;
using System.Collections.Generic;

namespace SmartSite.DB.Models
{
    public partial class DeviceDataElectric
    {
        public int Id { get; set; }
        public int? ElectricDeviceId { get; set; }
        public decimal? ElectricVoltage { get; set; }
        public decimal? ElectricCurrent { get; set; }
        public decimal? ElectricPower { get; set; }
        public decimal? ElectricNumber { get; set; }
        public decimal? ElectricNumberUse { get; set; }
        public bool? ElectricIsWarn { get; set; }
        public DateTime? ElectricDate { get; set; }
        public DateTime? ElectricDateLog { get; set; }
    }
}
