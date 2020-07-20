﻿using System;
using System.Collections.Generic;

namespace SmartSite.DB.Models
{
    public partial class ProjectCheckRoute
    {
        public int Id { get; set; }
        public int? RouteProjectId { get; set; }
        public int? RouteMemberId { get; set; }
        public string RoutePointCheckIdArr { get; set; }
        public string RouteName { get; set; }
        public string RouteDescribe { get; set; }
        public DateTime? RouteDate { get; set; }
    }
}
