using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XS.JobForCore.MCore;

namespace XS.JobForCore.JobUtils
{
    public class ExchangeJosModel
    {
        public ExchangeJosModel() {

            LastReports = new QueuFixed<string>(Settings.Instance.MaxLastReport);
        }
        public string Id { get; set; }
        /// <summary>
        /// 任务名称
        /// </summary>
        public string JobName { get; set; }
        /// <summary>
        /// Cron 表达式
        /// </summary>
        public string Cron { get; set; }
        /// <summary>
        /// 是否加载
        /// </summary>
        public bool Enable { get; set; }
        /// <summary>
        /// 最后执行时间
        /// </summary>
        public DateTime RecentRunTime { get; set; }
        /// <summary>
        /// 下次执行时间
        /// </summary>
        public DateTime NextFireTime { get; set; }
        /// <summary>
        /// 最后执行结果
        /// </summary>
        public string LastRezult { get; set; }
        /// <summary>
        /// 任务简介
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// 本次启动后执行的次数
        /// </summary>
        public int RunCount { get; set; }
        /// <summary>
        /// 默认保留最后100条报告
        /// </summary>
        public QueuFixed<string> LastReports;
        /// <summary>
        /// 排序id,越小越靠前
        /// </summary>
        public int OrderById { get; set; }
        /// <summary>
        /// 自定义配置
        /// </summary>
        public Dictionary<string,string> CustomConfigs { get; set; }
        /// <summary>
        /// 自定义配置说明文档
        /// </summary>
        public string ConfigDemo { get; set; }  


    }
}
