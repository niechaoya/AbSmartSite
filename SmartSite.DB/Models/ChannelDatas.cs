using System;
using System.Collections.Generic;

namespace SmartSite.DB.Models
{
    public partial class ChannelDatas
    {
        public int Id { get; set; }
        public int? ChannelNum { get; set; }
        public int? DataType { get; set; }
        public string Value { get; set; }
        public int IdP { get; set; }
    }
}
