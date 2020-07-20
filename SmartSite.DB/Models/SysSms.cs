using System;
using System.Collections.Generic;

namespace SmartSite.DB.Models
{
    public partial class SysSms
    {
        public int Id { get; set; }
        public string SmsMobile { get; set; }
        public string SmsCode { get; set; }
        public DateTime? SmsDate { get; set; }
        public int? SmsCheckFlag { get; set; }
        public DateTime? SmsCheckDate { get; set; }
        public string SmsCheckIp { get; set; }
        public string SmsCheckModel { get; set; }
        public string SmsCheckLocation { get; set; }
        public string SmsType { get; set; }
    }
}
