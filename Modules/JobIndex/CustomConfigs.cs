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
    public partial class CustomConfigs : Form
    {
        private string JobKey;
        private ExchangeJosModel model;
        public CustomConfigs(string jobKey)
        {
            InitializeComponent();
            dgData.AllowUserToAddRows = false;

            JobKey = jobKey;
            BindData();
        }

        private void BindData()
        {
            model = QuartzHelper.JosModels[JobKey];

            lbTitle.Text = $"正在修改【{model.JobName}】自定义配置";
            lbTaskInfo.Text = model.ConfigDemo.Trim();

            foreach (var item in model.CustomConfigs)
            {
                dgData.Rows.Add(item.Key, item.Value);
            }

        }


        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void btnSaveConfigs_Click(object sender, EventArgs e)
        {
            if (dgData.Rows.Count < 1)
            {
                MessageBox.Show("没有可配置的项");
                return;
            }

            if (XsWinFormsTools.Dialogs.ConfirmDialog("确定要保存吗"))
            {
                foreach (DataGridViewRow row in dgData.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        // 获取当前行的K和V列的值
                        string key = row.Cells["Key"].Value.ToString();
                        string value = row.Cells["Value"].Value.ToString();
                        if (!string.IsNullOrEmpty(value))
                            model.CustomConfigs[key] = value.Trim();
                    }
                }
                JobSettings.GetInstance().SaveCustomConfigs(JobKey, model.CustomConfigs);
                MessageBox.Show("保存成功，配置会在重启软件后生效！");
            }
        }
    }
}
