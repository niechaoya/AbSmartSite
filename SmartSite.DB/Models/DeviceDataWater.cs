using System;
using System.Collections.Generic;

namespace SmartSite.DB.Models
{
    public partial class DeviceDataWater
    {
        public int Id { get; set; }
        public int? WaterDeviceId { get; set; }
        public decimal? WaterNumber { get; set; }
        public decimal? WaterNumberUse { get; set; }
        public DateTime? WaterDate { get; set; }
        public DateTime? WaterDateLog { get; set; }
    }
}
