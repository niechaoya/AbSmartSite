using System;
using System.Collections.Generic;

namespace SmartSite.DB.Models
{
    public partial class UnloadingDeviceRealTimeData
    {
        public int Id { get; set; }
        public string HxzId { get; set; }
        public DateTime? Rtime { get; set; }
        public string Weight { get; set; }
        public string Weight1 { get; set; }
        public string Weight2 { get; set; }
        public string WeightPercent { get; set; }
        public string ObliguityX { get; set; }
        public string ObliguityY { get; set; }
        public string Obliguity { get; set; }
        public string BatteryPercent { get; set; }
        public int? Weight1Status { get; set; }
        public int? Weight2Status { get; set; }
        public int? ObliguityXstatus { get; set; }
        public int? ObliguityYstatus { get; set; }
        public int? BatteryStatus { get; set; }
        public int? GpsStatus { get; set; }
        public string Appsecret { get; set; }
        public string HxzFactory { get; set; }
        public string Appid { get; set; }
        public string WeightStatus { get; set; }
    }
}
