using System;
using System.Collections.Generic;

namespace SmartSite.DB.Models
{
    public partial class SysLoginType
    {
        public int Id { get; set; }
        public string LoginTypeNmae { get; set; }
        public DateTime? LoginTypeDate { get; set; }
    }
}
