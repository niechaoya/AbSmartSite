using System;
using System.Collections.Generic;

namespace SmartSite.DB.Models
{
    public partial class LifterRealTime
    {
        public int Id { get; set; }
        public string HxzFactory { get; set; }
        public string HxzId { get; set; }
        public string WorkNo { get; set; }
        public string PeopleCnt { get; set; }
        public string Weight { get; set; }
        public string Speed { get; set; }
        public string Height { get; set; }
        public string Floor { get; set; }
        public string ObliguityX { get; set; }
        public string ObliguityY { get; set; }
        public string WindSpeed { get; set; }
        public string WindLevel { get; set; }
        public int? NoError { get; set; }
        public int? IdError { get; set; }
        public int? PeopleCntError { get; set; }
        public int? WeightError { get; set; }
        public int? SpeedError { get; set; }
        public int? HeightError { get; set; }
        public int? FloorError { get; set; }
        public int? ObliguityXerror { get; set; }
        public int? NoPreAlarm { get; set; }
        public int? WeightPreAlarm { get; set; }
        public int? SpeedPreAlarm { get; set; }
        public int? HeightPreAlarm { get; set; }
        public int? ObliguityXpreAlarm { get; set; }
        public int? ObliguityYpreAlarm { get; set; }
        public int? WindSpeedPreAlarm { get; set; }
        public int? NoAlarm { get; set; }
        public int? PeopleCntAlarm { get; set; }
        public int? WeightAlarm { get; set; }
        public int? SpeedAlarm { get; set; }
        public int? HeightAlarm { get; set; }
        public int? ObliguityXalarm { get; set; }
        public int? ObliguityYalarm { get; set; }
        public int? WindSpeedAlarm { get; set; }
        public int? Motor1Alarm { get; set; }
        public int? Motor2Alarm { get; set; }
        public int? Motor3Alarm { get; set; }
        public int? TopAlarm { get; set; }
        public int? FallAlarm { get; set; }
        public int? DoorState { get; set; }
        public string Name { get; set; }
        public string IdNo { get; set; }
        public int? BottomAlarm { get; set; }
        public DateTime Rtime { get; set; }
    }
}
