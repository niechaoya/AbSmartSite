using System;
using System.Collections.Generic;

namespace SmartSite.DB.Models
{
    public partial class DeviceDataWeather
    {
        public int Id { get; set; }
        public int? WeatherDeviceId { get; set; }
        public decimal? WeatherO2 { get; set; }
        public decimal? WeatherCo { get; set; }
        public decimal? WeatherCo2 { get; set; }
        public decimal? WeatherNh3 { get; set; }
        public decimal? WeatherSo2 { get; set; }
        public decimal? WeatherN2 { get; set; }
        public decimal? WeatherCh2o { get; set; }
        public decimal? WeatherCh4 { get; set; }
        public decimal? WeatherH2s { get; set; }
        public decimal? WeatherTemp { get; set; }
        public decimal? WeatherHumidity { get; set; }
        public decimal? WeatherPressure { get; set; }
        public bool? WeatherIsWarn { get; set; }
        public DateTime? WeatherDate { get; set; }
        public DateTime? WeatherDateLog { get; set; }
    }
}
