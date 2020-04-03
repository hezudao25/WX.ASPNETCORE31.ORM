using System;
using System.Collections.Generic;
using System.Text;
using WX.ASPNETCORE31.Framework;

namespace WX.ASPNETCORE31.DAL
{
    public class SqlConnectionStringPool
    {
        internal static string GetConnectionString(DBOperateType dBOperateType)
        {
            string connString = null;
            switch (dBOperateType)
            {
                case DBOperateType.Write:
                    connString = ConfigurationManager.SqlConnectionStringWrite;
                    break;
                case DBOperateType.Read:
                    connString = DispatcherConn();
                    break;
                default:
                    throw new Exception("类型错误");
            }
            return connString;
        }

        /// <summary>
        /// 读库选择合适一个库 
        /// </summary>
        /// <returns></returns>
        private static string DispatcherConn()
        {
            //轮询
            return ConfigurationManager.SqlConnectionStringRead[iIndex++ % ConfigurationManager.SqlConnectionStringRead.Length];
            //随机
            //return ConfigurationManager.SqlConnectionStringRead[new Random().Next(0, ConfigurationManager.SqlConnectionStringRead.Length)];
            // 权重 首先要有配置--读取配置
        }

        private static long iIndex = 0;

        internal enum DBOperateType
        {
            Write,
            Read
        }
    }
}
