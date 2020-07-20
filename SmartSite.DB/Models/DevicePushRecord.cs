using System;
using System.Collections.Generic;

namespace SmartSite.DB.Models
{
    public partial class DevicePushRecord
    {
        public int Id { get; set; }
        public int? DeviceId { get; set; }
        public int? PushRecordMemberId { get; set; }
        public string PushRecordContent { get; set; }
        public int? PushRecordStatus { get; set; }
        public DateTime? PushRecordDate { get; set; }
    }
}
