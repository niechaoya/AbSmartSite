using System;
using System.Collections.Generic;

namespace SmartSite.DB.Models
{
    public partial class DeviceData
    {
        public int Id { get; set; }
        public int? DeviceId { get; set; }
        public string DeviceNo { get; set; }
        public string DeviceName { get; set; }
        public DateTime? DeviceDate { get; set; }
        public DateTime? DeviceDateLog { get; set; }
        public string DeviceArea1 { get; set; }
        public string DeviceArea2 { get; set; }
        public string DeviceArea3 { get; set; }
        public string DeviceAddress { get; set; }
        public string DeviceLocation { get; set; }
        public string DeviceLocationBaidu { get; set; }
    }
}
