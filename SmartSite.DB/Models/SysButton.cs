using System;
using System.Collections.Generic;

namespace SmartSite.DB.Models
{
    public partial class SysButton
    {
        public int Id { get; set; }
        public string ButtonNo { get; set; }
        public string ButtonName { get; set; }
        public string ButtonClick { get; set; }
        public string ButtonIcon { get; set; }
        public int? ButtonIsShow { get; set; }
        public string ButtonType { get; set; }
        public string ButtonIf { get; set; }
        public int? ButtonOrder { get; set; }
        public string ButtonRemark { get; set; }
    }
}
