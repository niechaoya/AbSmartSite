using System;
using System.Collections.Generic;

namespace SmartSite.DB.Models
{
    public partial class WeixinMenu
    {
        public int Id { get; set; }
        public string MenuName { get; set; }
        public string MenuKeyword { get; set; }
        public string MenuType { get; set; }
        public string MenuUrl { get; set; }
        public int? MenuPid { get; set; }
    }
}
