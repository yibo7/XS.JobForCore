namespace XS.JobForCore.Modules.Job
{
    partial class CustomConfigs
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
            lbTitle = new Label();
            groupBox1 = new GroupBox();
            lbTaskInfo = new Label();
            dgData = new DataGridView();
            Key = new DataGridViewTextBoxColumn();
            Value = new DataGridViewTextBoxColumn();
            btnSaveConfig = new ToolStrip();
            btnSaveConfigs = new ToolStripButton();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgData).BeginInit();
            btnSaveConfig.SuspendLayout();
            SuspendLayout();
            // 
            // lbTitle
            // 
            lbTitle.AutoSize = true;
            lbTitle.Location = new Point(12, 9);
            lbTitle.Name = "lbTitle";
            lbTitle.Size = new Size(92, 17);
            lbTitle.TabIndex = 3;
            lbTitle.Text = "修改自定义配置";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lbTaskInfo);
            groupBox1.Dock = DockStyle.Right;
            groupBox1.Location = new Point(368, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(240, 345);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "配置修改说明项";
            // 
            // lbTaskInfo
            // 
            lbTaskInfo.Location = new Point(12, 21);
            lbTaskInfo.Name = "lbTaskInfo";
            lbTaskInfo.Size = new Size(222, 290);
            lbTaskInfo.TabIndex = 0;
            lbTaskInfo.Text = "任务说明";
            // 
            // dgData
            // 
            dgData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgData.Columns.AddRange(new DataGridViewColumn[] { Key, Value });
            dgData.Dock = DockStyle.Fill;
            dgData.Location = new Point(0, 0);
            dgData.Name = "dgData";
            dgData.RowTemplate.Height = 25;
            dgData.Size = new Size(368, 345);
            dgData.TabIndex = 9;
            // 
            // Key
            // 
            Key.HeaderText = "配置键";
            Key.Name = "Key";
            Key.ReadOnly = true;
            // 
            // Value
            // 
            Value.HeaderText = "配置的值";
            Value.Name = "Value";
            Value.Width = 500;
            // 
            // btnSaveConfig
            // 
            btnSaveConfig.Items.AddRange(new ToolStripItem[] { btnSaveConfigs });
            btnSaveConfig.Location = new Point(0, 0);
            btnSaveConfig.Name = "btnSaveConfig";
            btnSaveConfig.Size = new Size(368, 25);
            btnSaveConfig.TabIndex = 12;
            btnSaveConfig.Text = "toolStrip1";
            // 
            // btnSaveConfigs
            // 
            btnSaveConfigs.Image = Resource.blueprints;
            btnSaveConfigs.ImageTransparentColor = Color.Magenta;
            btnSaveConfigs.Name = "btnSaveConfigs";
            btnSaveConfigs.Size = new Size(76, 22);
            btnSaveConfigs.Text = "保存配置";
            btnSaveConfigs.Click += btnSaveConfigs_Click;
            // 
            // CustomConfigs
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(608, 345);
            Controls.Add(btnSaveConfig);
            Controls.Add(dgData);
            Controls.Add(groupBox1);
            Controls.Add(lbTitle);
            Name = "CustomConfigs";
            Text = "修改自定义配置";
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgData).EndInit();
            btnSaveConfig.ResumeLayout(false);
            btnSaveConfig.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lbTitle;
        private GroupBox groupBox1;
        private Label lbTaskInfo;
        private DataGridView dgData;
        private DataGridViewTextBoxColumn Key;
        private DataGridViewTextBoxColumn Value;
        private ToolStrip btnSaveConfig;
        private ToolStripButton btnSaveConfigs;
    }
}