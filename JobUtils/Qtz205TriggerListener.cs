using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Quartz;
using XS.Core2;
using XS.JobForCore.Modules.Job;

namespace XS.JobForCore.JobUtils
{
    public class Qtz205TriggerListener : ITriggerListener
    {
        public int FireCount { get; private set; }

        public string Name => "Qtz205TriggerListener";
        /// <summary>
        /// Job执行时调用
        /// </summary>
        /// <param name="trigger"></param>
        /// <param name="context"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public Task TriggerFired(ITrigger trigger, IJobExecutionContext context, CancellationToken cancellationToken)
        {
            FireCount++;
            return Task.FromResult(true);
        }
        /// <summary>
        /// 在这里更新一个任务的最后执行时间,Trigger触发后，job执行时调用本方法。true即否决，job后面不执行。
        /// </summary>
        /// <param name="trigger"></param>
        /// <param name="context"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public Task<bool> VetoJobExecution(ITrigger trigger, IJobExecutionContext context, CancellationToken cancellationToken)
        {
            //if (FireCount >= 3)
            //{
            //    return Task.FromResult(true);
            //}
            string sKey = trigger.JobKey.Name;
            //Log.Factory.GetInstance().InfoLog("VetoJobExecution:" + sKey);
            try
            {

                var model = QuartzHelper.JosModels[sKey];// Bll.JobTask.Instance.GetEntity(new Guid(sKey));

                model.RecentRunTime = TimeZoneInfo.ConvertTimeFromUtc(context.FireTimeUtc.DateTime, TimeZoneInfo.Local);
                model.NextFireTime = trigger.GetNextFireTimeUtc().Value.LocalDateTime;//TimeZoneInfo.ConvertTimeFromUtc(trigger.GetNextFireTimeUtc().Value.LocalDateTime, TimeZoneInfo.Local);

                

                //Bll.JobTask.Instance.Update(model);
            }
            catch (Exception e)
            {
                LogHelper.Write($"在VetoJobExecution更新任务运行时间出错,{e.Message},任务Id:{sKey}");
            }
            return Task.FromResult(false);
        }
        /// <summary>
        /// 错过触发时调用
        /// </summary>
        /// <param name="trigger"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public Task TriggerMisfired(ITrigger trigger, CancellationToken cancellationToken)
        {
            LogHelper.Write($"Jobs任务错过触发调用,任务Id:{trigger.JobKey.Name}");
            return Task.FromResult(true);
        }
        /// <summary>
        /// 当一个任务调用完成后触发
        /// </summary>
        public Action<ExchangeJosModel> OnTriggerComplete { get; set; }
        /// <summary>
        /// Job完成时调用
        /// </summary>
        /// <param name="trigger"></param>
        /// <param name="context"></param>
        /// <param name="triggerInstructionCode"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public Task TriggerComplete(ITrigger trigger,
            IJobExecutionContext context,
            SchedulerInstruction triggerInstructionCode,
            CancellationToken cancellationToken)
        {
            string sKey = context.JobDetail.Key.Name;
            try
            {

                var model = QuartzHelper.JosModels[sKey];// Bll.JobTask.Instance.GetEntity(new Guid(sKey));
                
                var dataMap = context.JobDetail.JobDataMap;
                string lastOne = dataMap.GetString("report");
                if (!string.IsNullOrEmpty(lastOne))
                {
                    model.LastRezult = lastOne;
                    model.LastReports.Enqueue(lastOne);
                }
                
                //else
                //{
                //    model.LastRezult = "获取不到结果，当前任务没有设置dataMap[\"report\",value]";
                //}
                //int iCount = model.FireCount+1;
                //model.FireCount = iCount;
                if (!Equals(OnTriggerComplete, null))
                {
                    OnTriggerComplete(model);
                }
                //Bll.JobTask.Instance.Update(model);



            }
            catch (Exception e)
            {

                LogHelper.Write($"在VetoJobExecution更新任务运行时间出错,{e.Message},任务Id:{sKey}");
            }
            return Task.FromResult(true);
        }
    }

}
