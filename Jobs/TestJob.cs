using System; 
using System.Text;
using XS.JobForCore.JobUtils;

namespace WalletMiddleware.Jobs
{
    /// <summary>
    /// 定时检测审核通过的提币记录，调用热钱包发币
    /// </summary>
    public class TestJob : AJobXs, IJobXs
    {
        public string JobName => "测试任务";
        //public string Cron => "*/6 * * * * ?"; //每3分钟执行     // 每10秒执行："*/10 * * * * ?";     每3分钟执行：0 */3 * * * ?

        public bool Enable => IsOpen;
        //public string Id => "e8f6be3c-53a4-4144-8090-8df3d0eb1563";
        override public string JobId => "e8f6be3c-53a4-4144-8090-8df3d0eb1563";
        public string Cron => "*/6 * * * * ?"; //每10秒执行 
        public string Description => "这是一个测试任务，定时获取。";
        public int OrderById => 1; // 超大越靠前


        async protected override Task<string> Run()
        {
            return "未获得锁";
        }
    }
}
