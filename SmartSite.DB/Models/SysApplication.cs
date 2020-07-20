using System;
using System.Collections.Generic;

namespace SmartSite.DB.Models
{
    public partial class SysApplication
    {
        public int Id { get; set; }
        public string AppNo { get; set; }
        public string AppName { get; set; }
        public string AppPhoto { get; set; }
        public string AppIntro { get; set; }
        public decimal? AppPrice { get; set; }
        public int? AppPid { get; set; }
        public int? AppMenuId { get; set; }
        public string AppContent { get; set; }
        public string AppTitle { get; set; }
    }
}
