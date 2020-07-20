using System;
using System.Collections.Generic;

namespace SmartSite.DB.Models
{
    public partial class DeviceDataDust
    {
        public int Id { get; set; }
        public int? DeviceId { get; set; }
        public decimal? DeviceDataPm25 { get; set; }
        public decimal? DeviceDataPm10 { get; set; }
        public decimal? DeviceDataTsp { get; set; }
        public decimal? DeviceDataTemp { get; set; }
        public decimal? DeviceDataHumidity { get; set; }
        public decimal? DeviceDataWd { get; set; }
        public decimal? DeviceDataWs { get; set; }
        public decimal? DeviceDataWp { get; set; }
        public decimal? DeviceDataPa { get; set; }
        public decimal? DeviceDataZs { get; set; }
        public decimal? DeviceDataO3 { get; set; }
        public decimal? DeviceDataSo2 { get; set; }
        public decimal? DeviceDataNo2 { get; set; }
        public decimal? DeviceDataCo { get; set; }
        public decimal? DeviceDataB03 { get; set; }
        public decimal? DeviceDataH01 { get; set; }
        public decimal? DeviceDataT01 { get; set; }
        public decimal? DeviceDataW01 { get; set; }
        public decimal? DeviceDataW02 { get; set; }
        public decimal? DeviceDataPrimary { get; set; }
        public bool? DeviceIsWarn { get; set; }
        public DateTime? DeviceDate { get; set; }
        public DateTime? DeviceDateLog { get; set; }
    }
}
