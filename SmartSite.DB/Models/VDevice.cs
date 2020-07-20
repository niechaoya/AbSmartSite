using System;
using System.Collections.Generic;

namespace SmartSite.DB.Models
{
    public partial class VDevice
    {
        public int Id { get; set; }
        public string DeviceNo { get; set; }
        public string DeviceName { get; set; }
        public int? DeviceTypeId { get; set; }
        public int? DeviceStatus { get; set; }
        public int? DeviceArea1Id { get; set; }
        public string DeviceArea1 { get; set; }
        public int? DeviceArea2Id { get; set; }
        public string DeviceArea2 { get; set; }
        public int? DeviceArea3Id { get; set; }
        public string DeviceArea3 { get; set; }
        public string DeviceAddress { get; set; }
        public string DeviceLongitude { get; set; }
        public string DeviceLatitude { get; set; }
        public DateTime? DeviceCreateDate { get; set; }
        public string DeviceTypeName { get; set; }
        public string ProjectName { get; set; }
        public int? DeviceProjectId { get; set; }
        public string TradeName { get; set; }
        public string ProjectArea1 { get; set; }
        public string ProjectArea2 { get; set; }
        public string ProjectArea3 { get; set; }
        public string DeviceTypeAppUrl { get; set; }
        public int? DeviceType1Id { get; set; }
    }
}
