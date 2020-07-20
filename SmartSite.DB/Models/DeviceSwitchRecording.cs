using System;
using System.Collections.Generic;

namespace SmartSite.DB.Models
{
    public partial class DeviceSwitchRecording
    {
        public int Id { get; set; }
        public string DeviceNo { get; set; }
        public string DeviceName { get; set; }
        public DateTime? CreateTime { get; set; }
        public int? Switch { get; set; }
        public string Operator { get; set; }
        public int Type { get; set; }
        public int ProjectId { get; set; }
        public int Uid { get; set; }
        public int DeviceType { get; set; }
    }
}
