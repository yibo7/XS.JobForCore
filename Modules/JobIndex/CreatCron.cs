using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using XS.JobForCore.JobUtils;

namespace XS.JobForCore.Modules.Job
{
    public partial class CreatCron : XsWinFormsTools.WinMiniformBase
    {
        public CreatCron()
        {
            InitializeComponent();
            InitData();
        }

        private void InitData()
        {
            for (int i = 1; i < 60; i++)
            {
                cbSecondMin.Items.Add(i);
            }
            for (int i = 1; i < 24; i++)
            {
                cbHourList.Items.Add(i);
            }


            List<CronModel> lst = new List<CronModel>();
            lst.Add(new CronModel() { ItemName = "每天中午12点触发", CronString = "0 0 12 * * ?" });
            lst.Add(new CronModel() { ItemName = "每周星期天凌晨1点", CronString = "0 0 1 ? * L" });
            lst.Add(new CronModel() { ItemName = "每月1号凌晨1点", CronString = "0 0 1 1 * ?" });
            lst.Add(new CronModel() { ItemName = "每天凌晨1点", CronString = "0 0 1 * * ?" });
            lst.Add(new CronModel() { ItemName = "每天23点执行一次", CronString = "0 0 23 * * ?" });
            lst.Add(new CronModel() { ItemName = "每月最后一天23点", CronString = "0 0 23 L * ?" });
            lst.Add(new CronModel() { ItemName = "每天的0点、13点、18点、21点", CronString = "0 0 0,13,18,21 * * ?" });
            lst.Add(new CronModel() { ItemName = "周一至周五的上午10:15", CronString = "0 15 10 ? * MON-FRI" });
            lst.Add(new CronModel() { ItemName = "每月最后一日的上午10:15", CronString = "0 15 10 L * ?" });
            lst.Add(new CronModel() { ItemName = "每月的第一个中午开始每隔5天触发", CronString = "0 0 12 1/5 * ?" });
            lst.Add(new CronModel() { ItemName = "每月的第三周的星期五", CronString = "0 15 10 ? * 6#3" });
            lst.Add(new CronModel() { ItemName = "每月最后一周的星期五的10点15分", CronString = "0 15 10 ? * 6L" });
            lst.Add(new CronModel() { ItemName = "3月每周三下午的 2点10分和2点44分", CronString = "0 10,44 14 ? 3 WED" });
            lst.Add(new CronModel() { ItemName = "每年的11月11号 11点11分-光棍节", CronString = "0 11 11 11 11 ?" });
            lst.Add(new CronModel() { ItemName = "每天早上7点,中午13点，下午16点,19点,22点各执行一次", CronString = "0 0 7,13,16,19,22 * * ?" });
            lst.Add(new CronModel() { ItemName = "每过两天的早上9点执行一次", CronString = "0 0 9 1/2 * ? *" });


            lvCronList.DisplayMember = "ItemName";
            lvCronList.ValueMember = "CronString";
            lvCronList.DataSource = lst;

            cbSelTimeType.SelectedIndex = 0;
            cbSecondMin.SelectedIndex = 5;
            cbHourList.SelectedIndex = 0;
 
        }
        private void cbSecondMin_SelectedValueChanged(object sender, EventArgs e)
        {
            CreatCronStringNone();
        }

        private void cbSelTimeType_SelectedIndexChanged(object sender, EventArgs e)
        {
            CreatCronStringNone();
        }
        private void cbHourList_SelectedIndexChanged(object sender, EventArgs e)
        {
            CreatCronStringNone();
        }

        private void lvCronList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            CronModel model = lvCronList.SelectedItem as CronModel;
            txtCron.Text = model.CronString;
        }
        private void CreatCronStringNone()
        {
            string sCronString = string.Empty;
            if (radioButton1.Checked)
            {
                string sSelTimeType = cbSelTimeType.Text;

                string sSecondMin = cbSecondMin.Text;

                if (sSelTimeType.Equals("秒"))
                {
                    sCronString = string.Format("*/{0} * * * * ?", sSecondMin);
                }
                else
                {
                    sCronString = string.Format("0 */{0} * * * ?", sSecondMin);
                }

            }
            else if (radioButton2.Checked)
            {
                string sHourList = cbHourList.Text;
                sCronString = string.Format("0 0 */{0} * * ? ", sHourList);
            }
            txtCron.Text = sCronString;
        }

        private void txtCron_TextChanged(object sender, EventArgs e)
        {
            string sExpression = txtCron.Text;
            if (string.IsNullOrEmpty(sExpression))
            {
                rtxtBox.Text = string.Empty;
                return;
            }

            try
            {
                List<DateTime> list = QuartzHelper.GetNextFireTime(sExpression, 10);


                StringBuilder sb = new StringBuilder();
                foreach (var time in list)
                {
                    sb.AppendFormat("{0} {1}\n", time.ToLongDateString(), time.ToLongTimeString());
                }

                rtxtBox.Text = sb.ToString();
            }
            catch (Exception exception)
            {
                rtxtBox.Text = string.Format("表达式不对：{0}", exception.Message);
            }


        }
    }

    public class CronModel
    {
        public string ItemName { get; set; }
        public string CronString { get; set; }
    }
}
