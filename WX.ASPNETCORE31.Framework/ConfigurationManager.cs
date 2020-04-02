using Microsoft.Extensions.Configuration;
using System.IO;

namespace WX.ASPNETCORE31.Framework
{
    public class ConfigurationManager
    {
        /// <summary>
        /// 读取appsettings.json配置
        /// </summary>
        static ConfigurationManager()
        {
            var builder = new ConfigurationBuilder()
              .SetBasePath(Directory.GetCurrentDirectory())
              .AddJsonFile("appsettings.json");

            IConfigurationRoot configuationRoot = builder.Build();
            _ConfigurationManagerCustom = configuationRoot["ConnectionString:WriteConn"];
        }

        private static string _ConfigurationManagerCustom = null;

        public static string ConfigurationManagerCustom
        {
            get { return _ConfigurationManagerCustom; }
        }
    }
}
