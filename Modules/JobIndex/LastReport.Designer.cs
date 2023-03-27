namespace XS.JobForCore.Modules.Job
{
    partial class LastReport
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.lbReport = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbTaskInfo = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbTitle = new System.Windows.Forms.Label();
            this.txtInfo = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.lbReport);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.txtInfo);
            this.splitContainer1.Size = new System.Drawing.Size(791, 472);
            this.splitContainer1.SplitterDistance = 491;
            this.splitContainer1.TabIndex = 12;
            // 
            // lbReport
            // 
            this.lbReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbReport.FormattingEnabled = true;
            this.lbReport.ItemHeight = 17;
            this.lbReport.Location = new System.Drawing.Point(0, 40);
            this.lbReport.Name = "lbReport";
            this.lbReport.Size = new System.Drawing.Size(491, 323);
            this.lbReport.TabIndex = 14;
            this.lbReport.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lbReport_MouseDoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbTaskInfo);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(0, 363);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(491, 109);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "任务说明";
            // 
            // lbTaskInfo
            // 
            this.lbTaskInfo.Location = new System.Drawing.Point(12, 21);
            this.lbTaskInfo.Name = "lbTaskInfo";
            this.lbTaskInfo.Size = new System.Drawing.Size(508, 76);
            this.lbTaskInfo.TabIndex = 0;
            this.lbTaskInfo.Text = "任务说明";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbTitle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(491, 40);
            this.panel1.TabIndex = 12;
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Location = new System.Drawing.Point(14, 9);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(78, 17);
            this.lbTitle.TabIndex = 3;
            this.lbTitle.Text = "最后N条报告";
            // 
            // txtInfo
            // 
            this.txtInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtInfo.Location = new System.Drawing.Point(0, 0);
            this.txtInfo.Name = "txtInfo";
            this.txtInfo.ReadOnly = true;
            this.txtInfo.Size = new System.Drawing.Size(296, 472);
            this.txtInfo.TabIndex = 0;
            this.txtInfo.Text = "";
            // 
            // LastReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 472);
            this.Controls.Add(this.splitContainer1);
            this.Name = "LastReport";
            this.Text = "任务详情";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private SplitContainer splitContainer1;
        private ListBox lbReport;
        private GroupBox groupBox1;
        private Label lbTaskInfo;
        private Panel panel1;
        private Label lbTitle;
        private RichTextBox txtInfo;
    }
}