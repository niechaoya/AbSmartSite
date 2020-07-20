using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SmartSite.Web.Controllers
{
    public class HomeController : BaseController
    {
        public string Index()
        {
            return "index";
        }
    }
}
