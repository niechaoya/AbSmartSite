using System;
using System.Collections.Generic;

namespace SmartSite.DB.Models
{
    public partial class DeviceDataUnloading
    {
        public int Id { get; set; }
        public int? UnloadingDeviceId { get; set; }
        public decimal? UnloadingWeight { get; set; }
        public decimal? UnloadingWarningValue { get; set; }
        public decimal? UnloadingDipAngleX { get; set; }
        public decimal? UnloadingDipAngleY { get; set; }
        public decimal? UnloadingElectric { get; set; }
        public decimal? UnloadingTemp { get; set; }
        public decimal? UnloadingPull { get; set; }
        public bool? UnloadingIsWarn { get; set; }
        public DateTime? UnloadingDate { get; set; }
        public DateTime? UnloadingDateLog { get; set; }
    }
}
