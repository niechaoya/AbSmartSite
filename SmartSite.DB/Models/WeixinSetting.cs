using System;
using System.Collections.Generic;

namespace SmartSite.DB.Models
{
    public partial class WeixinSetting
    {
        public int Id { get; set; }
        public string WxId { get; set; }
        public string WxId1 { get; set; }
        public string WxId2 { get; set; }
        public string WxName { get; set; }
        public string WxAccount { get; set; }
        public string WxPwd { get; set; }
        public string WxAppId { get; set; }
        public string WxAppSecret { get; set; }
        public string WxToken { get; set; }
        public string WxUrl { get; set; }
        public string WxEncodingAeskey { get; set; }
        public int? WxEncodingType { get; set; }
        public string WxMchid { get; set; }
        public string WxMchkey { get; set; }
        public string WxAddlink { get; set; }
    }
}
