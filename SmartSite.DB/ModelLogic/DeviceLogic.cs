using System;
using System.Collections.Generic;
using System.Text;
using SmartSite.DB.EFBase;
using SmartSite.DB.Models;
using System.Threading.Tasks;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace SmartSite.DB.ModelLogic
{
    /// <summary>
    /// 第三方设备相关操作类
    /// </summary>
    public class DeviceLogic:CrudBase<Device>
    {
        public async Task<List<Device>> GetDevices()
        {
            return await base.GetEntities();
        }

        public async Task<Device> GetDeviceBySN(string deviceSN)
        {
            return await DbContext.Device.Where(d => d.DeviceNo == deviceSN).FirstOrDefaultAsync();
        }
    }
}
