using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.Json;
using SmartSite.Log;

namespace SmartSite.Common
{
    /// <summary>
    /// 读取appsettings.json配置文件内容
    /// </summary>
    public class ReadAppConfig
    {
        /// <summary>
        /// 读取配置文件中的连接字符串
        /// </summary>
        /// <param name="connectName"></param>
        /// <returns></returns>
        public static string ReadConnectString(string connectName)
        {
            var config = new ConfigurationBuilder().Add(new JsonConfigurationSource()
            {
                Path = "appsettings.json",
                Optional = true
            }).Build();
            var connectionString = config.GetConnectionString(connectName);
            if(string.IsNullOrEmpty(connectionString))
            {
                LogHelper.WriteErrorLog($"在appsettings.json中，无法找到名称为{connectName}的连接字符串");
                return null;
            }
            return connectionString;
        }
    }
}
