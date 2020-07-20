using System;
using System.Collections.Generic;

namespace SmartSite.DB.Models
{
    public partial class Device
    {
        public int Id { get; set; }
        public int? DeviceProjectId { get; set; }
        public string DeviceNo { get; set; }
        public string DeviceName { get; set; }
        public int? DeviceTypeId { get; set; }
        public int? DeviceType1Id { get; set; }
        public int? DeviceStatus { get; set; }
        public int? DeviceArea1Id { get; set; }
        public string DeviceArea1 { get; set; }
        public int? DeviceArea2Id { get; set; }
        public string DeviceArea2 { get; set; }
        public int? DeviceArea3Id { get; set; }
        public string DeviceArea3 { get; set; }
        public string DeviceAddress { get; set; }
        public string DeviceSpecs { get; set; }
        public string DeviceRecordNumber { get; set; }
        public string DeviceProductionName { get; set; }
        public string DeviceLongitude { get; set; }
        public string DeviceLatitude { get; set; }
        public DateTime? DeviceInstallDate { get; set; }
        public DateTime? DeviceHeartDate { get; set; }
        public DateTime? DeviceAtDate { get; set; }
        public DateTime? DeviceCreateDate { get; set; }
        public string DeviceGroup { get; set; }
        public int? DeviceSwitch { get; set; }
        public string InternetContenProvider { get; set; }
        public string Version { get; set; }
        public string Manufacturers { get; set; }
        public string DeviceLocation { get; set; }
        public string TradeName { get; set; }
        public string DeviceDoorName { get; set; }
        public int? DeviceDirection { get; set; }
        public string DeviceTypeName { get; set; }
        public string BlackBoxNumber { get; set; }
    }
}
