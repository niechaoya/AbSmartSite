using System;
using System.Collections.Generic;

namespace SmartSite.DB.Models
{
    public partial class TowerRegistration
    {
        public int Ids { get; set; }
        public string HxzFactory { get; set; }
        public string HxzId { get; set; }
        public string HardwareVer { get; set; }
        public string SoftwareVer { get; set; }
        public string SimCardNo { get; set; }
        public int Type { get; set; }
        public int Id { get; set; }
        public string RecordId { get; set; }
        public DateTime? ServerTime { get; set; }
        public int? HeartBeatInterval { get; set; }
        public int? WorkInterval { get; set; }
        public int? NoWorkInterval { get; set; }
        public int? ErrorDelay { get; set; }
        public int? LockFlag { get; set; }
        public string LeaseStartDate { get; set; }
        public string LeaseEndDate { get; set; }
        public int? WeightSetError { get; set; }
        public int? WindSpeedSetError { get; set; }
        public int? RangeSetError { get; set; }
        public int? HeightSetError { get; set; }
        public int? AngleSetError { get; set; }
        public int? ObliguitySetError { get; set; }
        public int? GpsSetError { get; set; }
        public int? IdSetError { get; set; }
        public string LeasePhone { get; set; }
        public string StationPhone { get; set; }
        public string WorkPhone { get; set; }
        public string ServerIp { get; set; }
        public string ServerPort { get; set; }
    }
}
