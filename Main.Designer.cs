namespace XS.JobForCore
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            dockPanel = new WeifenLuo.WinFormsUI.Docking.DockPanel();
            vS2015LightTheme1 = new WeifenLuo.WinFormsUI.Docking.VS2015LightTheme();
            menuStrip1 = new MenuStrip();
            视图ToolStripMenuItem = new ToolStripMenuItem();
            首页ToolStripMenuItem = new ToolStripMenuItem();
            工具栏ToolStripMenuItem = new ToolStripMenuItem();
            关于ToolStripMenuItem = new ToolStripMenuItem();
            软件注册ToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // dockPanel
            // 
            dockPanel.Dock = DockStyle.Fill;
            dockPanel.Location = new Point(0, 25);
            dockPanel.Name = "dockPanel";
            dockPanel.Size = new Size(834, 490);
            dockPanel.TabIndex = 0;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { 视图ToolStripMenuItem, 关于ToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(834, 25);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // 视图ToolStripMenuItem
            // 
            视图ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { 首页ToolStripMenuItem, 工具栏ToolStripMenuItem });
            视图ToolStripMenuItem.Name = "视图ToolStripMenuItem";
            视图ToolStripMenuItem.Size = new Size(44, 21);
            视图ToolStripMenuItem.Text = "视图";
            // 
            // 首页ToolStripMenuItem
            // 
            首页ToolStripMenuItem.Name = "首页ToolStripMenuItem";
            首页ToolStripMenuItem.Size = new Size(112, 22);
            首页ToolStripMenuItem.Text = "首页";
            首页ToolStripMenuItem.Click += 首页ToolStripMenuItem_Click;
            // 
            // 工具栏ToolStripMenuItem
            // 
            工具栏ToolStripMenuItem.Name = "工具栏ToolStripMenuItem";
            工具栏ToolStripMenuItem.Size = new Size(112, 22);
            工具栏ToolStripMenuItem.Text = "工具栏";
            工具栏ToolStripMenuItem.Click += 工具栏ToolStripMenuItem_Click;
            // 
            // 关于ToolStripMenuItem
            // 
            关于ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { 软件注册ToolStripMenuItem });
            关于ToolStripMenuItem.Name = "关于ToolStripMenuItem";
            关于ToolStripMenuItem.Size = new Size(44, 21);
            关于ToolStripMenuItem.Text = "关于";
            // 
            // 软件注册ToolStripMenuItem
            // 
            软件注册ToolStripMenuItem.Name = "软件注册ToolStripMenuItem";
            软件注册ToolStripMenuItem.Size = new Size(124, 22);
            软件注册ToolStripMenuItem.Text = "软件注册";
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(834, 515);
            Controls.Add(dockPanel);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Name = "Main";
            Text = "XS任务管理器";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private WeifenLuo.WinFormsUI.Docking.DockPanel dockPanel;
        private WeifenLuo.WinFormsUI.Docking.VS2015LightTheme vS2015LightTheme1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem 视图ToolStripMenuItem;
        private ToolStripMenuItem 首页ToolStripMenuItem;
        private ToolStripMenuItem 工具栏ToolStripMenuItem;
        private ToolStripMenuItem 关于ToolStripMenuItem;
        private ToolStripMenuItem 软件注册ToolStripMenuItem;
    }
}