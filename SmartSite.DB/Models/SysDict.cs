using System;
using System.Collections.Generic;

namespace SmartSite.DB.Models
{
    public partial class SysDict
    {
        public int Id { get; set; }
        public int DictId { get; set; }
        public string DictName { get; set; }
        public string DictType { get; set; }
        public int? DictOrder { get; set; }
    }
}
