using System;
using System.Linq;
using Quartz;
using Quartz.Impl;
using Quartz.Impl.Triggers;
using Quartz.Spi; 
using XS.Core2;
using XS.JobForCore.MCore;

namespace XS.JobForCore.JobUtils
{
    public  class QuartzHelper
    {
        private static IScheduler scheduler = null;
        public static Dictionary<string, ExchangeJosModel> JosModels = new Dictionary<string, ExchangeJosModel>();
        //public static List<ExchangeJosModel> exchangeJosModels = new List<ExchangeJosModel>();
        /// <summary> 
        /// 初始化任务调度对象
        /// </summary>
        public static async void InitScheduler(Action<ExchangeJosModel> onComp)
        {
            try
            {

                if (scheduler == null)
                {
                    #region quartz 实例配置
                    //NameValueCollection properties = new NameValueCollection();

                    //properties["quartz.scheduler.instanceName"] = "ExampleQuartzScheduler";

                    //properties["quartz.threadPool.type"] = "Quartz.Simpl.SimpleThreadPool, Quartz";

                    //properties["quartz.threadPool.threadCount"] = "10";

                    //properties["quartz.threadPool.threadPriority"] = "Normal";

                    //properties["quartz.jobStore.misfireThreshold"] = "60000";

                    //properties["quartz.jobStore.type"] = "Quartz.Simpl.RAMJobStore, Quartz";

                    //properties["quartz.scheduler.exporter.type"] = "Quartz.Simpl.RemotingSchedulerExporter, Quartz";

                    //properties["quartz.scheduler.exporter.port"] = "555";

                    //properties["quartz.scheduler.exporter.bindName"] = "QuartzScheduler";

                    //properties["quartz.scheduler.exporter.channelType"] = scheme;

                    //ISchedulerFactory factory = new StdSchedulerFactory(properties);

                    //scheduler = factory.GetScheduler();
                    #endregion
                    //// 配置文件的方式，配置quartz实例
                    ISchedulerFactory schedulerFactory = new StdSchedulerFactory();
                     
                    scheduler = await schedulerFactory.GetScheduler();
                     
                    //添加全局监听 

                    Qtz205TriggerListener triggerListener = new Qtz205TriggerListener();
                    triggerListener.OnTriggerComplete += onComp;
                    triggerListener.OnTriggerComplete += onCompRun;
                    //Qtz205ScheListener schedulerListener = new Qtz205ScheListener();
                    //scheduler.ListenerManager.AddSchedulerListener(schedulerListener); 
                    scheduler.ListenerManager.AddTriggerListener(triggerListener);
                    await scheduler.Start();
                    LogHelper.Info<QuartzHelper>("Quartz正常启动");
                }

            }
            catch (Exception ex)
            {
                //MessageBox.Show("初始化任务调度失败:" + ex.Message);
                LogHelper.Error<QuartzHelper>($"Quartz启动失败:{ex.Message}"); 
            }
        }

        private static void onCompRun(ExchangeJosModel task)
        {
            task.RunCount++; 
        }

        public static void LoadExchangeJobs()
        {
            var tTypes = AppDomain.CurrentDomain.GetAssemblies()
                .SelectMany(a => a.GetTypes().Where(t => t.GetInterfaces().Contains(typeof(IJobXs))))
                .ToArray();
            //需要等待Job加载完成之后才能获取HotWallets和Cointypes。如果放在他之前，将会发生错误。
            //AppStaticData.InitData();
            foreach (var type in tTypes)
            {
                if (type.IsClass)
                {
                    IJobXs jobInst = Activator.CreateInstance(type) as IJobXs;
                    if (!Equals(jobInst, null))
                    {
                        ExchangeJosModel ejm = new ExchangeJosModel();
                        
                        ejm.JobName = jobInst.JobName;
                        ejm.Enable = jobInst.Enable;
                        ejm.Cron = jobInst.Cron;
                        ejm.Description = jobInst.Description;
                        ejm.OrderById= jobInst.OrderById;

                        var jobObj = (AJobXs)jobInst;
                        ejm.CustomConfigs = jobObj.GetCustomConfigs();
                        ejm.Id = jobObj.JobId;// Guid.NewGuid().ToString();
                        ejm.ConfigDemo= jobObj.ConfigDemo;
                        // 自定义了Cron表达式
                        if (JobSettings.GetInstance().Config.Inst.Cron.ContainsKey(ejm.Id))
                        {
                            ejm.Cron = JobSettings.GetInstance().Config.Inst.Cron[ejm.Id];
                        } 

                        if (ejm.Enable)
                        {
                            if (!string.IsNullOrEmpty(ejm.Cron)&&ValidExpression(ejm.Cron))
                            {
                                IJobDetail job = new JobDetailImpl(ejm.Id, type);
                                CronTriggerImpl trigger = new CronTriggerImpl();
                                
                                trigger.Name = ejm.JobName;
                                trigger.Description = ejm.Description;
                                trigger.CronExpressionString = ejm.Cron;
                                

                                scheduler.ScheduleJob(job, trigger);

                                ejm.LastRezult = "任务成功加载！";
                            }
                            else
                            {
                                ejm.LastRezult = "任务的Cron表达式错误导致无法运行，请检查！";
                            }

                        }
                        JosModels.Add(ejm.Id,ejm);
                    }
                } 
            }
            //// 从大到小排序
            //var sortedJosModels = JosModels.OrderByDescending(x => x.Value.OrderById);

            // 从小到大排序
            var sortedJosModels = JosModels.OrderBy(x => x.Value.OrderById);
            JosModels = sortedJosModels.ToDictionary(x => x.Key, x => x.Value);
        }

        /// <summary>
        /// 暂停指定任务
        /// </summary>
        /// <param name="JobKey"></param>
        public static async System.Threading.Tasks.Task PauseJobAsync(string JobKey)
        {
            try
            {
                JobKey jk = new JobKey(JobKey);
                if (await scheduler.CheckExists(jk))
                {
                    
                    //任务已经存在则暂停任务
                    scheduler.PauseJob(jk); 
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// 恢复运行暂停的任务
        /// </summary>
        /// <param name="JobKey">任务key</param>
        public static async System.Threading.Tasks.Task ResumeJobAsync(string JobKey)
        {
            try
            {
                JobKey jk = new JobKey(JobKey);
                if (await scheduler.CheckExists(jk))
                {
                    //任务已经存在则暂停任务
                    scheduler.ResumeJob(jk); 
                }
            }
            catch (Exception ex)
            {
                LogHelper.Error<QuartzHelper>($"恢复任务失败！{ex}");
            }
        }
        /// <summary>
        /// 校验字符串是否为正确的Cron表达式
        /// </summary>
        /// <param name="cronExpression">带校验表达式</param>
        /// <returns></returns>
        public static bool ValidExpression(string cronExpression)
        {
            return CronExpression.IsValidExpression(cronExpression);
        }
        /// <summary>
        /// 获取任务在未来周期内哪些时间会运行
        /// </summary>
        /// <param name="CronExpressionString">Cron表达式</param>
        /// <param name="numTimes">运行次数</param>
        /// <returns>运行时间段</returns>
        public static List<DateTime> GetNextFireTime(string CronExpressionString, int numTimes)
        {


            if (numTimes < 0)
            {
                throw new Exception("参数numTimes值大于等于0");
            }
            //时间表达式
            ITrigger trigger = TriggerBuilder.Create().WithCronSchedule(CronExpressionString).Build();
            var dates = TriggerUtils.ComputeFireTimes(trigger as IOperableTrigger, null, numTimes);
            List<DateTime> list = new List<DateTime>();
            foreach (DateTimeOffset dtf in dates)
            {
                list.Add(TimeZoneInfo.ConvertTimeFromUtc(dtf.DateTime, TimeZoneInfo.Local));
            }
            return list;
        }
        /// <summary>
        /// 删除现有任务
        /// </summary>
        /// <param name="JobKey"></param>
        public static async System.Threading.Tasks.Task DeleteJobAsync(string JobKey)
        {
            try
            {
                JobKey jk = new JobKey(JobKey);
                if (await scheduler.CheckExists(jk))
                {
                    //任务已经存在则删除
                    await scheduler.DeleteJob(jk);
                    LogHelper.Error<QuartzHelper>($"任务“{JobKey}”被删除");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static void Shutdown()
        {
            try
            {
                //判断调度是否已经关闭
                if (!scheduler.IsShutdown)
                { 
                    scheduler.Shutdown(true); 
                }
            }
            catch (Exception ex)
            {
                LogHelper.Error<QuartzHelper>($"恢复任务失败！{ex}");

            }
        }
        public static void PauseAll()
        {
            scheduler.PauseAll();
        }
        public static void ResumeAll()
        {
            scheduler.ResumeAll();
        }
        public static void Start()
        {
            scheduler.Start();
        }
        /// <summary>
        /// 立即执行一个任务
        /// </summary>
        /// <param name="jobKey"></param>
        public static async void RunNow(string jobKey)
        {
            JobKey jk = new JobKey(jobKey);
            if (await scheduler.CheckExists(jk))
            {
               await scheduler.TriggerJob(jk);
            }
                
        }
        /// <summary>
        /// 获取一个Job实现实例
        /// </summary>
        /// <param name="JobKey"></param>
        /// <returns></returns>
        public static async Task<AJobXs> GetJobInstanceAsync(string JobKey)
        {
            // 定义 JobKey
            JobKey jobKey = new JobKey(JobKey);

            // 获取 JobDetail
            IJobDetail jobDetail = await scheduler.GetJobDetail(jobKey);

            // 获取 Job 类型
            Type jobType = jobDetail.JobType;

            // 通过反射创建 Job 实例
            return (AJobXs)Activator.CreateInstance(jobType);

        }
        

    }
}
