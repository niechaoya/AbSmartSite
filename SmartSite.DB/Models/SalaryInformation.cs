using System;
using System.Collections.Generic;

namespace SmartSite.DB.Models
{
    public partial class SalaryInformation
    {
        public int Id { get; set; }
        public int Uid { get; set; }
        public int Bid { get; set; }
        public string OpeningBank { get; set; }
        public string BankCard { get; set; }
        public decimal? DailyWages { get; set; }
    }
}
