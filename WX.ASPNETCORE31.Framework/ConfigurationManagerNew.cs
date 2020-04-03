using Microsoft.Extensions.Configuration;
using System.IO;
using System.Linq;

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
            _SqlConnectionStringWrite = configuationRoot["ConnectionString:WriteConn"];
            _SqlConnectionStringRead = configuationRoot.GetSection("ConnectionString").GetSection("ReadConn").GetChildren().Select(s => s.Value).ToArray();
        }

        private static string _SqlConnectionStringWrite = null;

        public static string SqlConnectionStringWrite
        {
            get { return _SqlConnectionStringWrite; }
        }

        private static string[] _SqlConnectionStringRead = null;

        public static string[] SqlConnectionStringRead
        {
            get { return _SqlConnectionStringRead; }
        }
    }
}
