using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SmartSite.Common;

namespace SmartSite.Web.Controllers
{
    public class HomeController : BaseController
    {
        public string Index()
        {
            RedisHelper.StringSet("a", "444");
            return "index";
        }
    }
}
