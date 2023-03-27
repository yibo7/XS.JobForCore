using Quartz;
using XS.JobForCore.JobUtils;
using XS.JobForCore.MCore;

namespace XS.JobForCore.Modules.Job
{
    public partial class LastReport : Form
    {
        private string JobKey;
        public LastReport(string jobKey)
        {
            InitializeComponent();
            JobKey = jobKey;
            BindData(jobKey);
            
        }

        private async void BindData(string jobKey )
        {
            var model = QuartzHelper.JosModels[jobKey]; 
            string sTitle = "";
            if (model.LastReports.Count>0) {
                sTitle = $"任务【{model.JobName}】最后有{model.LastReports.Count}条报告，最多只保留{Settings.Instance.MaxLastReport}条,双击可查看详情";
                //string ReportInfo = "";
                int iIndex = 1;
                foreach (string item in model.LastReports)
                {
                    string itemInfo = $"{iIndex}、{item}";
                    lbReport.Items.Add(itemInfo);
                    iIndex++;
                }
                
                //rtxtBox.Text = ReportInfo;
            }
            else
            {
                sTitle = $"任务【{model.JobName}】还未有工作，没的报告信息";
            }
            lbTitle.Text = sTitle;
              
            lbTaskInfo.Text = model.Description;

        }

        private void lbReport_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            string txt = lbReport.SelectedItem.ToString();
            txtInfo.Text = txt; 
        }
    }
}
