using System;
using System.Collections.Generic;
using System.Text;

namespace SmartSite.Common
{
    public class DIHelper
    {
        public static IServiceProvider ServiceProvider;
        public static object GetService<IService>()
        {
            return ServiceProvider.GetService(typeof(IService));
        }
    }
}
