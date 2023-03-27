using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Text;
using System.Threading.Tasks;
using Quartz;

namespace XS.JobForCore.JobUtils
{ 
     

    public interface IJobXs
    {
        ///// <summary>
        ///// 唯一ID，可以采用Guid生成
        ///// </summary>
        //string Id { get; }
        /// <summary>
        /// 任务名称
        /// </summary>
        string JobName { get;}
        /// <summary>
        /// Cron 表达式
        /// </summary>
        string Cron { get; }
        /// <summary>
        /// 是否加载
        /// </summary>
        bool Enable { get; }
        /// <summary>
        /// 任务说明
        /// </summary>
        string Description { get; }
        public int OrderById => 0; // 超大越靠前


    }
    
}