namespace XS.JobForCore.Modules.Job
{
    partial class JobList
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
            this.components = new System.ComponentModel.Container();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnPassAll = new System.Windows.Forms.ToolStripButton();
            this.btnCronShow = new System.Windows.Forms.ToolStripButton();
            this.lvData = new XsWinFormsTools.XsListView.XsListViewBox();
            this.contextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.暂停ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.立即执行ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.自定义配置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cron表达式ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1.SuspendLayout();
            this.contextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnPassAll,
            this.btnCronShow});
            this.toolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 39);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnPassAll
            // 
            this.btnPassAll.Image = global::XS.JobForCore.Resource.spass;
            this.btnPassAll.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnPassAll.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPassAll.Name = "btnPassAll";
            this.btnPassAll.Size = new System.Drawing.Size(92, 36);
            this.btnPassAll.Text = "暂停所有";
            this.btnPassAll.Click += new System.EventHandler(this.btnPassAll_Click);
            // 
            // btnCronShow
            // 
            this.btnCronShow.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnCronShow.Image = global::XS.JobForCore.Resource.word;
            this.btnCronShow.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCronShow.Name = "btnCronShow";
            this.btnCronShow.Size = new System.Drawing.Size(128, 36);
            this.btnCronShow.Text = "Cron表达式生成器";
            this.btnCronShow.Click += new System.EventHandler(this.btnCronShow_Click);
            // 
            // lvData
            // 
            this.lvData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvData.FullRowSelect = true;
            this.lvData.GridLines = true;
            this.lvData.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvData.Location = new System.Drawing.Point(0, 39);
            this.lvData.Name = "lvData";
            this.lvData.Size = new System.Drawing.Size(800, 411);
            this.lvData.TabIndex = 3;
            this.lvData.UseCompatibleStateImageBehavior = false;
            this.lvData.View = System.Windows.Forms.View.Details;
            this.lvData.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lvData_MouseDoubleClick);
            // 
            // contextMenu
            // 
            this.contextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.暂停ToolStripMenuItem,
            this.立即执行ToolStripMenuItem,
            this.自定义配置ToolStripMenuItem,
            this.cron表达式ToolStripMenuItem});
            this.contextMenu.Name = "contextMenu";
            this.contextMenu.Size = new System.Drawing.Size(181, 114);
            // 
            // 暂停ToolStripMenuItem
            // 
            this.暂停ToolStripMenuItem.Name = "暂停ToolStripMenuItem";
            this.暂停ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.暂停ToolStripMenuItem.Text = "暂停/继续";
            this.暂停ToolStripMenuItem.Click += new System.EventHandler(this.暂停ToolStripMenuItem_Click);
            // 
            // 立即执行ToolStripMenuItem
            // 
            this.立即执行ToolStripMenuItem.Name = "立即执行ToolStripMenuItem";
            this.立即执行ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.立即执行ToolStripMenuItem.Text = "立即执行";
            this.立即执行ToolStripMenuItem.Click += new System.EventHandler(this.立即执行ToolStripMenuItem_Click);
            // 
            // 自定义配置ToolStripMenuItem
            // 
            this.自定义配置ToolStripMenuItem.Name = "自定义配置ToolStripMenuItem";
            this.自定义配置ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.自定义配置ToolStripMenuItem.Text = "自定义配置";
            this.自定义配置ToolStripMenuItem.Click += new System.EventHandler(this.自定义配置ToolStripMenuItem_Click);
            // 
            // cron表达式ToolStripMenuItem
            // 
            this.cron表达式ToolStripMenuItem.Name = "cron表达式ToolStripMenuItem";
            this.cron表达式ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cron表达式ToolStripMenuItem.Text = "Cron表达式";
            this.cron表达式ToolStripMenuItem.Click += new System.EventHandler(this.cron表达式ToolStripMenuItem_Click);
            // 
            // JobList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lvData);
            this.Controls.Add(this.toolStrip1);
            this.Name = "JobList";
            this.Text = "TestModule";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.contextMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ToolStrip toolStrip1;
        private XsWinFormsTools.XsListView.XsListViewBox lvData;
        private ToolStripButton btnPassAll;
        private ContextMenuStrip contextMenu;
        private ToolStripMenuItem 暂停ToolStripMenuItem;
        private ToolStripButton btnCronShow;
        private ToolStripMenuItem 立即执行ToolStripMenuItem;
        private ToolStripMenuItem 自定义配置ToolStripMenuItem;
        private ToolStripMenuItem cron表达式ToolStripMenuItem;
    }
}