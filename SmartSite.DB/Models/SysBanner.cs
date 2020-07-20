using System;
using System.Collections.Generic;

namespace SmartSite.DB.Models
{
    public partial class SysBanner
    {
        public int Id { get; set; }
        public int? BannerType { get; set; }
        public DateTime? BannerDate { get; set; }
        public DateTime? BannerDateStart { get; set; }
        public DateTime? BannerDateEnd { get; set; }
        public string BannerTitle { get; set; }
        public string BannerPath { get; set; }
        public string BannerPath1 { get; set; }
        public string BannerPath2 { get; set; }
        public int? BannerOrder { get; set; }
        public int? BannerViewCount { get; set; }
        public int? BannerViewIp { get; set; }
        public int? BannerViewCount1 { get; set; }
        public int? BannerViewIp1 { get; set; }
        public int? BannerViewCount2 { get; set; }
        public int? BannerViewIp2 { get; set; }
        public string BannerRemark { get; set; }
    }
}
