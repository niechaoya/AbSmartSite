using System;
using System.Collections.Generic;

namespace SmartSite.DB.Models
{
    public partial class WeixinMsg
    {
        public int Id { get; set; }
        public string MsgTitle { get; set; }
        public string MsgDesc { get; set; }
        public string FormMsgType { get; set; }
        public string FormMsgKeyword { get; set; }
        public string ToMsgType { get; set; }
        public string ToMsgContent { get; set; }
        public int? ToMsgRowCount { get; set; }
        public int? ToMsgSectionId { get; set; }
        public int? ToMsgCateId { get; set; }
        public string ToMsgLogId { get; set; }
        public string ToMsgCatePower { get; set; }
    }
}
