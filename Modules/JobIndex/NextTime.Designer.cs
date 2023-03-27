namespace XS.JobForCore.Modules.Job
{
    partial class NextTime
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.rtxtBoxNexTime = new System.Windows.Forms.RichTextBox();
            this.txtCron = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnTestCron = new System.Windows.Forms.Button();
            this.btnSaveCron = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "未来10次执行时间";
            // 
            // rtxtBoxNexTime
            // 
            this.rtxtBoxNexTime.Location = new System.Drawing.Point(12, 94);
            this.rtxtBoxNexTime.Name = "rtxtBoxNexTime";
            this.rtxtBoxNexTime.ReadOnly = true;
            this.rtxtBoxNexTime.Size = new System.Drawing.Size(306, 198);
            this.rtxtBoxNexTime.TabIndex = 6;
            this.rtxtBoxNexTime.Text = "";
            // 
            // txtCron
            // 
            this.txtCron.Location = new System.Drawing.Point(12, 33);
            this.txtCron.Name = "txtCron";
            this.txtCron.Size = new System.Drawing.Size(248, 23);
            this.txtCron.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "表达式";
            // 
            // btnTestCron
            // 
            this.btnTestCron.Location = new System.Drawing.Point(266, 33);
            this.btnTestCron.Name = "btnTestCron";
            this.btnTestCron.Size = new System.Drawing.Size(52, 23);
            this.btnTestCron.TabIndex = 10;
            this.btnTestCron.Text = "测试";
            this.btnTestCron.UseVisualStyleBackColor = true;
            this.btnTestCron.Click += new System.EventHandler(this.btnTestCron_Click);
            // 
            // btnSaveCron
            // 
            this.btnSaveCron.Location = new System.Drawing.Point(109, 310);
            this.btnSaveCron.Name = "btnSaveCron";
            this.btnSaveCron.Size = new System.Drawing.Size(83, 35);
            this.btnSaveCron.TabIndex = 11;
            this.btnSaveCron.Text = "修改并保存";
            this.btnSaveCron.UseVisualStyleBackColor = true;
            this.btnSaveCron.Click += new System.EventHandler(this.btnSaveCron_Click);
            // 
            // NextTime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 357);
            this.Controls.Add(this.btnSaveCron);
            this.Controls.Add(this.btnTestCron);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rtxtBoxNexTime);
            this.Controls.Add(this.txtCron);
            this.Controls.Add(this.label2);
            this.Name = "NextTime";
            this.Text = "Cron表达式";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label1;
        private RichTextBox rtxtBoxNexTime;
        private TextBox txtCron;
        private Label label2;
        private Button btnTestCron;
        private Button btnSaveCron;
    }
}