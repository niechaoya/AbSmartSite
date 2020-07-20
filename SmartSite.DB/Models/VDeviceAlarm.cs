using System;
using System.Collections.Generic;

namespace SmartSite.DB.Models
{
    public partial class VDeviceAlarm
    {
        public int Id { get; set; }
        public int? AlarmDeviceId { get; set; }
        public int? AlarmDeviceDataId { get; set; }
        public int? AlarmDeviceType { get; set; }
        public string AlarmWarnName { get; set; }
        public decimal? AlarmValue { get; set; }
        public decimal? AlarmWarningValue { get; set; }
        public decimal? AlarmExceedValue { get; set; }
        public string AlarmIntro { get; set; }
        public DateTime? AlarmDate { get; set; }
        public string DeviceName { get; set; }
        public int? DeviceProjectId { get; set; }
    }
}
