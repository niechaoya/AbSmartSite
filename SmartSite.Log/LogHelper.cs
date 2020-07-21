using System;
using System.Collections.Generic;
using System.Text;
using log4net;
using log4net.Config;
using log4net.Repository;
using System.IO;

namespace SmartSite.Log
{
    /// <summary>
    /// log4net帮助类
    /// </summary>
    public class LogHelper
    {
        private static ILog _log4net;
        private static ILoggerRepository _repository = LogManager.CreateRepository("AspNetCoreLog4netRepository");

        static LogHelper()
        {
            //log4net从log4net.config文件中读取配置信息
            _log4net = LogManager.GetLogger(_repository.Name,typeof(LogHelper));
            XmlConfigurator.Configure(_repository, new FileInfo("log4net.config"));            
        }

        public static void WriteErrorLog(string logMessage)
        {
            _log4net.Error(logMessage);
        }

        public static void WriteInfoLog(string logMessage)
        {
            _log4net.Info(logMessage);
        }
    }
}
