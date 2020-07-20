using System;
using System.Collections.Generic;

namespace SmartSite.DB.Models
{
    public partial class DeviceThresholdSetting
    {
        public int Id { get; set; }
        public int? ThresholdDeviceType { get; set; }
        public string ThresholdName { get; set; }
        public decimal? ThresholdWarningValue { get; set; }
        public decimal? ThresholdExceedValue { get; set; }
        public int? ThresholdStatus { get; set; }
        public DateTime? ThresholdDate { get; set; }
    }
}
