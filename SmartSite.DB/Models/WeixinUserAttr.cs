using System;
using System.Collections.Generic;

namespace SmartSite.DB.Models
{
    public partial class WeixinUserAttr
    {
        public int Id { get; set; }
        public int? WxUserId { get; set; }
        public string AttrName { get; set; }
        public string AttrValue { get; set; }
    }
}
