using System;
using System.Collections.Generic;

namespace SmartSite.DB.Models
{
    public partial class WeixinUser
    {
        public int Id { get; set; }
        public int? UserId { get; set; }
        public string Openid { get; set; }
        public string WeiXinId { get; set; }
        public string Name { get; set; }
        public string Nickname { get; set; }
        public string Sex { get; set; }
        public string HeadImgUrl { get; set; }
        public string HeadImgUrlMin { get; set; }
        public string Country { get; set; }
        public string Province { get; set; }
        public string City { get; set; }
        public string Department { get; set; }
        public string Position { get; set; }
        public string Mobile { get; set; }
        public string Email { get; set; }
        public string Lng { get; set; }
        public string Lat { get; set; }
        public int? Status { get; set; }
        public DateTime? SubscribeTime { get; set; }
        public DateTime? CreateTime { get; set; }
        public DateTime? UpdateTime { get; set; }
    }
}
