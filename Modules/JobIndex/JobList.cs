using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using WeifenLuo.WinFormsUI.Docking;
using XS.JobForCore.JobUtils;
using XS.JobForCore.MCore;

namespace XS.JobForCore.Modules.Job
{
    public partial class JobList : XsDockContent //, IModules 作为首页，不用在模块中加载
    {
        public string Title => "任务管理器";//要实现模块名称
        public Image Ico => Resource.books; //要实现模块图标

        public JobList()
        {
            InitializeComponent(); 
            lvData.AddColum("Id", 0);
            lvData.AddColum("任务名称", 200); 
            lvData.AddColum("状态", 80);
            lvData.AddColum("最后执行时间", 150);
            lvData.AddColum("下次执行时间", 150);
            lvData.AddColum("执行次数", 80);
            lvData.AddColum("最后执行报告", 500);
            lvData.AddColum("备注", 300);

            lvData.InitContextMenu(this.contextMenu);


            Action<ExchangeJosModel> action = (task) =>
            {
                foreach (ListViewItem item in lvData.Items)
                {
                    if (item.Text.Equals(task.Id))
                    {
                        //更新当前这个任务完成信息
                        item.SubItems[3].Text = task.RecentRunTime.ToString(); //最后执行时间
                        item.SubItems[4].Text = task.NextFireTime.ToString(); //下次执行时间
                        item.SubItems[5].Text = (task.RunCount+1).ToString(); //执行次数,由于总是等待下一个任务执行才将上一任务的次数显示 ，所以加1就正确了
                        item.SubItems[6].Text = task.LastRezult; //下次执行时间
                    }
                }
            };
            // 当有任务完成时触发，可以在这里更新任务信息
            QuartzHelper.InitScheduler((ExchangeJosModel task) =>
            {
                lvData.Invoke(action, task);

            });
            QuartzHelper.LoadExchangeJobs();
            BindData();
        }

        public void BindData()
        {
            lvData.Items.Clear();

            var lst = QuartzHelper.JosModels;
            int iIndex = 1;
            foreach (var model in lst)
            {
                lvData.AddItem(
                    model.Value.Enable?Color.White: Color.LightGray
                    , model.Key, $"{iIndex}、{model.Value.JobName}"
                    , model.Value.Enable ? "运行中" : "暂停"
                    , model.Value.RecentRunTime.ToString()
                    , model.Value.NextFireTime.ToString()
                    , model.Value.RunCount.ToString()
                    , model.Value.LastRezult
                    , model.Value.Description

                    );
                iIndex++;
            }
        }

        private async void 暂停ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (isPause)
            {
                MessageBox.Show("目前处于暂停所有任务的状态，如果想要单独操作请先开户所有任务！");
                return;
            }

            if (lvData.SelectedItems.Count > 0)
            { 
                string sId = lvData.GetSelectItemValue(0);
                
                var model = QuartzHelper.JosModels[sId];
                model.Enable = !model.Enable;

                if (model.Enable)
                {
                    
                    await QuartzHelper.ResumeJobAsync(sId);

                }
                else
                {
                    await QuartzHelper.PauseJobAsync(sId);
                }

                BindData();
            }
            else
            {
                MessageBox.Show("请选择一个任务！");
            }
        }

    

        private void btnCronShow_Click(object sender, EventArgs e)
        {
            CreatCron creatCron= new CreatCron();
            creatCron.ShowDialog();
        }
        bool isPause = false;
        private void btnPassAll_Click(object sender, EventArgs e)
        {
            if (XsWinFormsTools.Dialogs.ConfirmDialog(isPause?"确定要继续所有任务吗？": "确定要暂停所有任务吗？"))
            {
                if (!isPause)
                {
                    QuartzHelper.PauseAll();
                    isPause = true;
                    btnPassAll.Text = "继续执行";
                    btnPassAll.Image = XS.JobForCore.Resource.play;
                    foreach (var item in QuartzHelper.JosModels.Values)
                    {
                        item.Enable = false;
                    }
                }
                else
                {
                    QuartzHelper.ResumeAll();
                    isPause = false;
                    btnPassAll.Text = "暂停所有";
                    btnPassAll.Image = XS.JobForCore.Resource.spass;

                    foreach (var item in QuartzHelper.JosModels.Values)
                    {
                        item.Enable = true;
                    }
                }

                this.BindData();

            }
            
            

        }

        private void 立即执行ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lvData.SelectedItems.Count > 0)
            {
                string sId = lvData.GetSelectItemValue(0);

                QuartzHelper.RunNow(sId);
            }
            else
            {
                MessageBox.Show("请选择一个任务！");
            }
        }

    

        private void lvData_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            string id = lvData.GetSelectItemValue(0);
            if (string.IsNullOrEmpty(id))
            {
                MessageBox.Show("请选择数据！");
                return;
            }
                
            LastReport lastReport = new LastReport(id);
            lastReport.ShowDialog();    
        }

        private void 自定义配置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string id = lvData.GetSelectItemValue(0);
            if (string.IsNullOrEmpty(id))
            {
                MessageBox.Show("请选择数据！");
                return;
            }
            CustomConfigs cc = new CustomConfigs(id);
            cc.ShowDialog();
        }

        private void cron表达式ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string id = lvData.GetSelectItemValue(0);
            NextTime nextTime = new NextTime(id);
            nextTime.ShowDialog();  
        }
    }
}
