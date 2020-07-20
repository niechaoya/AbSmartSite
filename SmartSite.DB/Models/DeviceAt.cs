using System;
using System.Collections.Generic;

namespace SmartSite.DB.Models
{
    public partial class DeviceAt
    {
        public int Id { get; set; }
        public int? DeviceId { get; set; }
        public string DeviceAtType { get; set; }
        public string DeviceAtIntro { get; set; }
        public int? DeviceAtStatus { get; set; }
        public DateTime? DeviceAtDate { get; set; }
    }
}
