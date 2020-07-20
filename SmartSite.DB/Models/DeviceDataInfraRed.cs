using System;
using System.Collections.Generic;

namespace SmartSite.DB.Models
{
    public partial class DeviceDataInfraRed
    {
        public int Id { get; set; }
        public int? InfraRedDeviceId { get; set; }
        public decimal? InfraRedDistance { get; set; }
        public int? InfraRedLightNum { get; set; }
        public string InfraRedMode { get; set; }
        public decimal? InfraRedElectricCurrent { get; set; }
        public decimal? InfraRedVoltage { get; set; }
        public decimal? InfraRedTemp { get; set; }
        public decimal? InfraRedLightSource { get; set; }
        public decimal? InfraRedLnductionSpeed { get; set; }
        public bool? InfraRedIsWarn { get; set; }
        public DateTime? InfraRedDate { get; set; }
        public DateTime? InfraRedDateLog { get; set; }
    }
}
