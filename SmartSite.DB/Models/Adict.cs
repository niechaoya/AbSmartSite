using System;
using System.Collections.Generic;

namespace SmartSite.DB.Models
{
    public partial class Adict
    {
        public int Id { get; set; }
        public string SysCode { get; set; }
        public string SysName { get; set; }
        public string AltCode { get; set; }
        public string AltName { get; set; }
        public string GrpCode { get; set; }
        public string GrpName { get; set; }
        public int? DictPid { get; set; }
    }
}
