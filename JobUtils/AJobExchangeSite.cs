using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Quartz;
using XS.Core2.Models;
using XS.Core2.XsExtensions;
using XS.JobForCore.MCore;

namespace XS.JobForCore.JobUtils
{
    /// <summary>
    /// 定时获取退货单
    /// </summary>
    /// <remarks>
    /// 该Job有两个自定义声明，分明说明如下：
    /// 1.PersistJobDataAfterExecution:支持多次执行数据持久化到该对象中，每次执行完毕之后，会把数据放入JobDataMap，以便下次使用。
    /// 2.DisallowConcurrentExecution:不允许并发执行，如果服务开时执行时，上次执行还没有完成，则等待上次完成后，本次执行才开始；
    /// </remarks>   
    [DisallowConcurrentExecution]
    public abstract class AJobXs : IJob
    {

        /// <summary>
        /// 唯一ID，可以采用Guid生成
        /// </summary>
        abstract public string JobId { get; }
        virtual protected bool IsOpen
        {
            get { return Settings.Instance.IsOpen == 1; }
        }
        /// <summary>
        /// 配置说明
        /// </summary>
        virtual public string ConfigDemo => "没有自定义配置项";
        virtual public Dictionary<string, string> InitConfig() => new Dictionary<string, string>();

        public Dictionary<string, string> GetCustomConfigs()
        {
            var cf = JobSetModel.Instance.GetCustomConfigs(JobId);
            if (cf == null)
                cf = InitConfig();
            return cf;
        }
        public string GetCf(string key)
        {
            var cf = GetCustomConfigs();
            if (cf.ContainsKey(key))
            {
                return cf[key];
            }
            return "";
        }

        protected int GetCfToInt(string key)
        {
            string ddd = "123"; 
            return GetCf(key).ToInt();
        }
        protected float GetCfToFloat(string key)
        {
            return GetCf(key).ToFloat();
        }

        /// <summary>
        /// 要实现的主要任务执行方法
        /// </summary>
        /// <returns></returns>
        abstract protected Task<string> Run();
        //async protected override Task<string>
        public async Task Execute(IJobExecutionContext context)
        {
            string sRzInfo = await Run();
            if (!string.IsNullOrEmpty(sRzInfo))
            {
                sRzInfo = string.Format("最后报告:{0},时间:{1}", sRzInfo, DateTime.Now); 
            }
            else
            {
                sRzInfo = string.Format("时间:{0}!{1}", DateTime.Now, "警告！未能获取最后分析报告,或报告为空"); 
            }
             
            context.JobDetail.JobDataMap.Add("report", sRzInfo);
            //return Task.FromResult(true);
        } 

    }
}
