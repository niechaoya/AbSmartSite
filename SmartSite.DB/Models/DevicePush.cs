using System;
using System.Collections.Generic;

namespace SmartSite.DB.Models
{
    public partial class DevicePush
    {
        public int Id { get; set; }
        public int? DeviceId { get; set; }
        public int? DevicePushStatus { get; set; }
        public int? DevicePushType { get; set; }
        public int? DevicePushAlarmType { get; set; }
        public string DevicePushMemberId { get; set; }
        public DateTime? DevicePushDate { get; set; }
    }
}
