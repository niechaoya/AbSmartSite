using System;
using System.Collections.Generic;

namespace SmartSite.DB.Models
{
    public partial class DeviceDataTowerCrane
    {
        public int Id { get; set; }
        public string HxzId { get; set; }
        public DateTime TowerCraneDate { get; set; }
        public decimal? TowerCraneHeight { get; set; }
        public decimal? TowerCraneBigArm { get; set; }
        public decimal? TowerCraneRotate { get; set; }
        public decimal? TowerCraneWindPole { get; set; }
        public decimal? TowerCraneDipAngleX { get; set; }
        public decimal? TowerCraneDipAngleY { get; set; }
        public decimal? TowerCraneMoment { get; set; }
        public decimal? TowerCraneRange { get; set; }
        public decimal? TowerCraneTemp { get; set; }
        public decimal? TowerCraneWeight { get; set; }
        public decimal? TowerCraneCurrent { get; set; }
        public decimal? TowerCraneVoltage { get; set; }
        public decimal? TowerCranePower { get; set; }
        public bool? TowerCraneIsWarn { get; set; }
        public DateTime? TowerCraneDateLog { get; set; }
        public decimal? WindSpeed { get; set; }
        public int? MomentAlarm { get; set; }
        public int? WindSpeedAlarm { get; set; }
        public int? MinRangeAlarm { get; set; }
        public int? HeightAlarm { get; set; }
        public int? AngleError { get; set; }
        public int? ObliguityError { get; set; }
        public int? MultiAlarmAll { get; set; }
        public string Name { get; set; }
        public int? WorkStatus { get; set; }
        public string IdNo { get; set; }
        public string HxzFactory { get; set; }
        public int? MaxRangeAlarm { get; set; }
        public int? PosAngleAlarm { get; set; }
        public int? NegAngleAlarm { get; set; }
        public int? ObliguityAlarm { get; set; }
        public int? NoAlarm { get; set; }
    }
}
