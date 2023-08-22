using Quartz;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using XS.JobForCore.JobUtils;
using XS.JobForCore.MCore;

namespace XS.JobForCore.Modules.Job
{
    public partial class NextTime : XsWinFormsTools.WinMiniformBase
    {
        private string JobKey;
        public NextTime(string jobKey)
        {
            InitializeComponent();
            JobKey = jobKey;
            BindData(jobKey);
            
        }

        private async void BindData(string jobKey )
        {
            var model = QuartzHelper.JosModels[jobKey]; 
             
            this.Text = $"【{model.JobName}】表达式";
            txtCron.Text= model.Cron;
            SetNextTime(model.Cron); 
        }

        private void SetNextTime(string sExpression)
        {
            try
            {
                List<DateTime> list = QuartzHelper.GetNextFireTime(sExpression, 10);


                StringBuilder sb = new StringBuilder();
                foreach (var time in list)
                {
                    sb.AppendFormat("{0} {1}\n", time.ToLongDateString(), time.ToLongTimeString());
                }

                rtxtBoxNexTime.Text = sb.ToString();
            }
            catch (Exception exception)
            {
                rtxtBoxNexTime.Text = string.Format("表达式不对：{0}", exception.Message);
            }
        }

        private void btnTestCron_Click(object sender, EventArgs e)
        {             
            SetNextTime(txtCron.Text.Trim());
        }

        private void btnSaveCron_Click(object sender, EventArgs e)
        {
            if (XsWinFormsTools.Dialogs.ConfirmDialog("在保存前请确保你已经测试通过，确定要保存吗"))
            {
                JobSetModel.Instance.Cron[JobKey] = txtCron.Text.Trim();
                JobSetModel.Instance.Save();
                MessageBox.Show("保存成功，此Cron表达会在重启软件后生效！");
            }
        }
    }
}
