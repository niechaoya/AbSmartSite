using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SmartSite.Web.Controllers;
using SmartSite.DB.Models;
using SmartSite.DB.ModelLogic;
using SmartSite.Log;

namespace SmartSite.Web.ApiControllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : BaseController
    {
        [Route("[action]")]
        public string Index()
        {
            return "This is API Controller Index";
        }
        [Route("[action]")]
        public async Task<List<Device>> GetDevices()
        {
            return await new DeviceLogic().GetDevices();
        }
        [Route("[action]")]
        public async Task<Device> GetDeviceBySN()
        {
            return await new DeviceLogic().GetDeviceBySN("19122303");
        }
        [Route("[action]")]
        public string WriteLogTest()
        {
            LogHelper.WriteErrorLog("log test");
            return "log ok";
        }
    }
}
