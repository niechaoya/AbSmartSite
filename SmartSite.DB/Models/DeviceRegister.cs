using System;
using System.Collections.Generic;

namespace SmartSite.DB.Models
{
    public partial class DeviceRegister
    {
        public int Id { get; set; }
        public int? RegisterDeviceId { get; set; }
        public string RegisterDeviceNo { get; set; }
        public string RegisterDeviceName { get; set; }
        public string RegisterDeviceSpec { get; set; }
        public string RegisterDeviceCode { get; set; }
        public string RegisterDeviceProduction { get; set; }
        public int? RegisterMemberId { get; set; }
        public int? RegisterProjectId { get; set; }
        public string RegisterPhoto { get; set; }
        public DateTime? RegisterAcceptanceDate { get; set; }
        public DateTime? RegisterApproachDate { get; set; }
        public DateTime? RegisterCreateDate { get; set; }
    }
}
