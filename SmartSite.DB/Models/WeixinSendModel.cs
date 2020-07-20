using System;
using System.Collections.Generic;

namespace SmartSite.DB.Models
{
    public partial class WeixinSendModel
    {
        public int Id { get; set; }
        public string ModelName { get; set; }
        public string ModelPic1 { get; set; }
        public string ModelPic2 { get; set; }
        public string ModelMemo { get; set; }
    }
}
