using System;
using System.Collections.Generic;

namespace SmartSite.DB.Models
{
    public partial class DeviceAlarm
    {
        public int Id { get; set; }
        public int? AlarmDeviceDataId { get; set; }
        public int? AlarmDeviceType { get; set; }
        public string AlarmWarnName { get; set; }
        public decimal? AlarmValue { get; set; }
        public decimal? AlarmWarningValue { get; set; }
        public decimal? AlarmExceedValue { get; set; }
        public string AlarmIntro { get; set; }
        public DateTime AlarmDate { get; set; }
        public int? EnvironmentAlarm { get; set; }
        public string DeviceNo { get; set; }
        public string AlarmDeviceId { get; set; }
    }
}
