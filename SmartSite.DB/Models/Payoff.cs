using System;
using System.Collections.Generic;

namespace SmartSite.DB.Models
{
    public partial class Payoff
    {
        public int Id { get; set; }
        public int Uid { get; set; }
        public DateTime IssuedTime { get; set; }
        public DateTime CreateTime { get; set; }
        public string Issuer { get; set; }
        public string FileAddress { get; set; }
    }
}
