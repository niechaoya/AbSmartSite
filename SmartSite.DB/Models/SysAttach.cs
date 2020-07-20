using System;
using System.Collections.Generic;

namespace SmartSite.DB.Models
{
    public partial class SysAttach
    {
        public int Id { get; set; }
        public string AttachType { get; set; }
        public string AttachName { get; set; }
        public string AttachPath { get; set; }
    }
}
