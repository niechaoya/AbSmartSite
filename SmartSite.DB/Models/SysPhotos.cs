using System;
using System.Collections.Generic;

namespace SmartSite.DB.Models
{
    public partial class SysPhotos
    {
        public int Id { get; set; }
        public string PhotoType { get; set; }
        public string PhotoTitle { get; set; }
        public string PhotoIntro { get; set; }
        public string PhotoUrl { get; set; }
        public string PhotoPath { get; set; }
        public int? PhotoOrder { get; set; }
    }
}
