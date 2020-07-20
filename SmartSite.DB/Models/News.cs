using System;
using System.Collections.Generic;

namespace SmartSite.DB.Models
{
    public partial class News
    {
        public int Id { get; set; }
        public string NewsTitle { get; set; }
        public DateTime? NewsDate { get; set; }
        public string NewsKeyword { get; set; }
        public string NewsPhoto { get; set; }
        public string NewsPhotoList { get; set; }
        public string NewsContent { get; set; }
        public string NewsPower { get; set; }
        public string NewsIntro { get; set; }
        public int? NewsCountView { get; set; }
        public int? NewsCountViewIp { get; set; }
        public int? NewsType { get; set; }
        public string NewsTypeName { get; set; }
        public string NewsUrl { get; set; }
        public string NewsUrlWx { get; set; }
        public int? NewsAddMan { get; set; }
        public string NewsAddManName { get; set; }
    }
}
