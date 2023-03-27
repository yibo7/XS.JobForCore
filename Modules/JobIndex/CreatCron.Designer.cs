namespace XS.JobForCore.Modules.Job
{
    partial class CreatCron
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lvCronList = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbHourList = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbSelTimeType = new System.Windows.Forms.ComboBox();
            this.cbSecondMin = new System.Windows.Forms.ComboBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCron = new System.Windows.Forms.TextBox();
            this.rtxtBox = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lvCronList);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cbHourList);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbSelTimeType);
            this.groupBox1.Controls.Add(this.cbSecondMin);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(350, 426);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "执行规律";
            // 
            // lvCronList
            // 
            this.lvCronList.FormattingEnabled = true;
            this.lvCronList.ItemHeight = 17;
            this.lvCronList.Location = new System.Drawing.Point(10, 226);
            this.lvCronList.Name = "lvCronList";
            this.lvCronList.Size = new System.Drawing.Size(334, 174);
            this.lvCronList.TabIndex = 11;
            this.lvCronList.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lvCronList_MouseDoubleClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(152, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "常见Cron表达式(双击测试)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "每阁";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(136, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "执行一次";
            // 
            // cbHourList
            // 
            this.cbHourList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbHourList.FormattingEnabled = true;
            this.cbHourList.Location = new System.Drawing.Point(45, 151);
            this.cbHourList.Name = "cbHourList";
            this.cbHourList.Size = new System.Drawing.Size(85, 25);
            this.cbHourList.TabIndex = 6;
            this.cbHourList.SelectedIndexChanged += new System.EventHandler(this.cbHourList_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "每阁";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(227, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "执行一次";
            // 
            // cbSelTimeType
            // 
            this.cbSelTimeType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSelTimeType.FormattingEnabled = true;
            this.cbSelTimeType.Items.AddRange(new object[] {
            "秒",
            "分"});
            this.cbSelTimeType.Location = new System.Drawing.Point(136, 76);
            this.cbSelTimeType.Name = "cbSelTimeType";
            this.cbSelTimeType.Size = new System.Drawing.Size(85, 25);
            this.cbSelTimeType.TabIndex = 3;
            this.cbSelTimeType.SelectedIndexChanged += new System.EventHandler(this.cbSelTimeType_SelectedIndexChanged);
            // 
            // cbSecondMin
            // 
            this.cbSecondMin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSecondMin.FormattingEnabled = true;
            this.cbSecondMin.Location = new System.Drawing.Point(45, 76);
            this.cbSecondMin.Name = "cbSecondMin";
            this.cbSecondMin.Size = new System.Drawing.Size(85, 25);
            this.cbSecondMin.TabIndex = 2;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(6, 119);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(98, 21);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "小时重复执行";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(6, 36);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(98, 21);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "分秒重复执行";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(379, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "表达式";
            // 
            // txtCron
            // 
            this.txtCron.Location = new System.Drawing.Point(379, 45);
            this.txtCron.Name = "txtCron";
            this.txtCron.Size = new System.Drawing.Size(247, 23);
            this.txtCron.TabIndex = 13;
            this.txtCron.TextChanged += new System.EventHandler(this.txtCron_TextChanged);
            // 
            // rtxtBox
            // 
            this.rtxtBox.Location = new System.Drawing.Point(379, 110);
            this.rtxtBox.Name = "rtxtBox";
            this.rtxtBox.Size = new System.Drawing.Size(247, 328);
            this.rtxtBox.TabIndex = 14;
            this.rtxtBox.Text = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(379, 88);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 17);
            this.label7.TabIndex = 15;
            this.label7.Text = "未来10次执行时间";
            // 
            // CreatCron
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 450);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.rtxtBox);
            this.Controls.Add(this.txtCron);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox1);
            this.Name = "CreatCron";
            this.Text = "CreatCron";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox groupBox1;
        private Label label2;
        private Label label1;
        private ComboBox cbSelTimeType;
        private ComboBox cbSecondMin;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private Label label3;
        private Label label4;
        private ComboBox cbHourList;
        private Label label5;
        private ListBox lvCronList;
        private Label label6;
        private TextBox txtCron;
        private RichTextBox rtxtBox;
        private Label label7;
    }
}