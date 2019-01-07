using System;
using Microsoft.Extensions.Configuration;

namespace FirstLove.Web
{
    /// <summary>
    /// 加载.JSON文件
    /// </summary>
    public class ConfigurationHelp
    {
        public readonly static IConfiguration _appsettings;
    
        /// <summary>
        /// 构造函数
        /// </summary>
        static ConfigurationHelp()
        {
            /// <summary>
            /// _appsettings 加载了appsetting.json文件
            /// </summary>
            /// <returns></returns>
            _appsettings = new ConfigurationBuilder()
                .SetBasePath(System.IO.Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json",optional:true)
                .Build();
        }
    }
}