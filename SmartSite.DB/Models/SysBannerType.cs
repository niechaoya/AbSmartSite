using System;
using System.Collections.Generic;

namespace SmartSite.DB.Models
{
    public partial class SysBannerType
    {
        public int Id { get; set; }
        public string BannerTypeName { get; set; }
        public string BannerTypeIntro { get; set; }
        public int? BannerTypeOrder { get; set; }
    }
}
