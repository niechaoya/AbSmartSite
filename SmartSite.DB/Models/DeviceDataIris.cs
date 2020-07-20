using System;
using System.Collections.Generic;

namespace SmartSite.DB.Models
{
    public partial class DeviceDataIris
    {
        public int Id { get; set; }
        public int? IrisDeviceId { get; set; }
        public decimal? IrisTemp { get; set; }
        public decimal? IrisHumidity { get; set; }
        public decimal? IrisLight { get; set; }
        public decimal? IrisElectricCurrent { get; set; }
        public decimal? IrisVoltage { get; set; }
        public decimal? IrisWeight { get; set; }
        public decimal? IrisDistance { get; set; }
        public bool? IrisIsWarn { get; set; }
        public DateTime? IrisDate { get; set; }
        public DateTime? IrisDateLog { get; set; }
    }
}
