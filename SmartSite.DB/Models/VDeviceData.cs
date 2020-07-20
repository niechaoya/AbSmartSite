using System;
using System.Collections.Generic;

namespace SmartSite.DB.Models
{
    public partial class VDeviceData
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
        public int Expr1 { get; set; }
        public int? DeviceId { get; set; }
        public string Expr2 { get; set; }
        public string Expr3 { get; set; }
        public DateTime? DeviceDate { get; set; }
        public DateTime? DeviceDateLog { get; set; }
        public string Expr4 { get; set; }
        public string Expr5 { get; set; }
        public string Expr6 { get; set; }
        public string Expr7 { get; set; }
        public string DeviceLocation { get; set; }
        public string DeviceLocationBaidu { get; set; }
    }
}
