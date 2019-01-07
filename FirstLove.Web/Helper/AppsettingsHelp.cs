using System;
using Microsoft.Extensions.Configuration;

namespace FirstLove.Web
{
    public class AppsettingsHelp
    {
        /// <summary>
        /// 获取联系DB_echo数据库的连接字符串
        /// </summary>
        /// <returns></returns>
        public static string MySql_DB_echo { get; } = ConfigurationHelp._appsettings.GetConnectionString("DB_echo");
    }
}