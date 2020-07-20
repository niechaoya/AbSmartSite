using System;
using System.Collections.Generic;

namespace SmartSite.DB.Models
{
    public partial class NewsType
    {
        public int Id { get; set; }
        public string NewsTypeName { get; set; }
        public string NewsTypeKeyword { get; set; }
        public string NewsTypeIntro { get; set; }
        public int? NewsTypePid { get; set; }
        public int? NewsTypeOrder { get; set; }
        public string NewsTypePhoto { get; set; }
        public string NewsTypePath { get; set; }
        public int? NewsTypeViewCount { get; set; }
        public int? NewsTypeViewIp { get; set; }
    }
}
