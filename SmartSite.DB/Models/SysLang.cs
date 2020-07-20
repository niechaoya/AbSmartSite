using System;
using System.Collections.Generic;

namespace SmartSite.DB.Models
{
    public partial class SysLang
    {
        public int Id { get; set; }
        public string Form { get; set; }
        public string No { get; set; }
        public string Cn { get; set; }
        public string En { get; set; }
        public string Sp { get; set; }
        public string Datatype { get; set; }
        public int? Datawidth { get; set; }
        public bool? Datashow { get; set; }
        public string Dataurl { get; set; }
        public string Dataurlparam { get; set; }
        public int? Datasort { get; set; }
    }
}
