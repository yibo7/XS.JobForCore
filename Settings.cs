using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XS.Core2;

namespace XS.JobForCore
{
    public class Settings
    {
        public readonly static Settings Instance = new Settings();
        private IniParser iniParser;

        private Settings()
        {
            string sPath = AppDomain.CurrentDomain.BaseDirectory;
#if DEBUG
            if (sPath.EndsWith("\\bin"))
                sPath = sPath.Replace("\\bin", "");
#endif
            iniParser = new IniParser(string.Concat(sPath, @"\conf\conf.ini"));

            //app 
            Email = iniParser.GetSetting("App", "Email");
            IsOpen = iniParser.GetSettingInt("App", "IsOpen");
            MaxLastReport = iniParser.GetSettingInt("App", "MaxLastReport");
            OpenApiKeys = iniParser.GetSetting("App", "OpenApiKeys");
             
        }

        public void Save()
        {
            //app 
            iniParser.AddSetting("App", "Email", Email);

            iniParser.SaveSettings();

        }


        //app 
        /// <summary>
        /// 汇报Email
        /// </summary>
        public string Email { get; set; }
        /// <summary>
        /// 默认是否启动所有任务
        /// </summary>
        public int IsOpen = 1;
        /// <summary>
        /// 最后报告保留多少条
        /// </summary>
        public int MaxLastReport = 30;


        //以下代码为自定义
        /// <summary>
        /// OPENAI的api key ，多个用英文逗号分开（目前只使用一个，用完后再换）
        /// </summary>
        public string OpenApiKeys = "";
        ///// <summary>
        ///// 发布文件到爱弹琴的随机数上限，越大越难命中
        ///// </summary>
        //public int PushToAtqRand = 20;

    }
}
