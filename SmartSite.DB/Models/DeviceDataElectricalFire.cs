using System;
using System.Collections.Generic;

namespace SmartSite.DB.Models
{
    public partial class DeviceDataElectricalFire
    {
        public int Id { get; set; }
        public int? ElectricalFireDeviceId { get; set; }
        public decimal? ElectricalFireTemp { get; set; }
        public decimal? ElectricalFireCurrent { get; set; }
        public decimal? ElectricalFireVoltage { get; set; }
        public decimal? ElectricalFirePower { get; set; }
        public decimal? ElectricalFireElectricEnergy { get; set; }
        public decimal? ElectricalFireHarmonic { get; set; }
        public bool? ElectricalIsWarn { get; set; }
        public DateTime? ElectricalFireDate { get; set; }
        public DateTime? ElectricalFireDateLog { get; set; }
    }
}
