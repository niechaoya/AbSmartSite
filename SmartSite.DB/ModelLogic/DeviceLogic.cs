using System;
using System.Collections.Generic;
using System.Text;
using SmartSite.DB.EFBase;
using SmartSite.DB.Models;
using System.Threading.Tasks;

namespace SmartSite.DB.ModelLogic
{
    public class DeviceLogic:CrudBase<Device>
    {
        public async Task<List<Device>> GetDevices()
        {
            return await base.GetEntities();
        }
    }
}
