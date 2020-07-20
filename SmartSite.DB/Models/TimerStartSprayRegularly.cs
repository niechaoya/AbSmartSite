using System;
using System.Collections.Generic;

namespace SmartSite.DB.Models
{
    public partial class TimerStartSprayRegularly
    {
        public int Id { get; set; }
        public DateTime? CreateTime { get; set; }
        public int? Switch { get; set; }
        public string Operator { get; set; }
        public int Type { get; set; }
        public int Uid { get; set; }
        public string StartTime { get; set; }
        public string EndTime { get; set; }
        public string Pm25 { get; set; }
        public string Pm10 { get; set; }
        public string Tsp { get; set; }
        public string DeviceNo { get; set; }
        public int? ProjectId { get; set; }
    }
}
