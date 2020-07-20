using System;
using System.Collections.Generic;

namespace SmartSite.DB.Models
{
    public partial class DeviceDataStrongElectricity
    {
        public int Id { get; set; }
        public int? StrongElectricityDeviceId { get; set; }
        public decimal? StrongElectricityFrequency { get; set; }
        public string StrongElectricityMode { get; set; }
        public decimal? StrongElectricityPower { get; set; }
        public decimal? StrongElectricityVoltage { get; set; }
        public decimal? StrongElectricityCurrent { get; set; }
        public bool? StrongElectricityIsWarn { get; set; }
        public DateTime? StrongElectricityDate { get; set; }
        public DateTime? StrongElectricityDateLog { get; set; }
    }
}
