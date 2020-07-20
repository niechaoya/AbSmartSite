using System;
using System.Collections.Generic;

namespace SmartSite.DB.Models
{
    public partial class DeviceType
    {
        public int Id { get; set; }
        public int? DeviceType1 { get; set; }
        public string DeviceTypeName { get; set; }
        public string DeviceTypeIntro { get; set; }
        public int? DeviceTypeIndex { get; set; }
        public string DeviceTypeAppUrl { get; set; }
        public DateTime? DeviceTypeCreateDate { get; set; }
    }
}
