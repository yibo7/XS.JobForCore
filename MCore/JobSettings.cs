using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using XS.Core2;
using XS.Core2.FSO;
using XS.JobForCore.Modules.Job;

namespace XS.JobForCore.MCore
{
    public class JobSetModel
    {
       public Dictionary<string, string> Cron  = new Dictionary<string, string>();
        public Dictionary<string, Dictionary<string, string>> CustomConfigs = new Dictionary<string, Dictionary<string, string>>();
    }
    public class JobSettings:Singleton<JobSettings>
    {
        public JsonFile<JobSetModel> Config;
        public JobSettings() { 
            Config = new JsonFile<JobSetModel>($"{XsWinFormsTools.Utils.GetCuurentPath()}\\JobSetting\\settings.json");
        }

        public Dictionary<string,string> GetCustomConfigs(string jobId)
        {
            if (this.Config.Inst.CustomConfigs.ContainsKey(jobId))
            {
                return Config.Inst.CustomConfigs[jobId];
            }
            return null;
        }
        public void SaveCustomConfigs(string jobId, Dictionary<string, string> cf)
        {
            if (cf!=null)
            {
                Config.Inst.CustomConfigs[jobId] = cf;
                Config.Save();  

            } 
        }
    }
}
