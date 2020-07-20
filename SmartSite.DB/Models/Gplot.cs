using System;
using System.Collections.Generic;

namespace SmartSite.DB.Models
{
    public partial class Gplot
    {
        public int Id { get; set; }
        public int ParentId { get; set; }
        public string ValuesName { get; set; }
        public int? Cid { get; set; }
        public int? Pid { get; set; }
    }
}
