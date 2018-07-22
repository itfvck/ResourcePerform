namespace 资源监视器
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.基础 = new System.Windows.Forms.TabPage();
            this.待定 = new System.Windows.Forms.TabPage();
            this.groupBox_process = new System.Windows.Forms.GroupBox();
            this.comboBox_process = new System.Windows.Forms.ComboBox();
            this.button_start = new System.Windows.Forms.Button();
            this.button_refresh = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown_frequence = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.richTextBox_res = new System.Windows.Forms.RichTextBox();
            this.chart_memory = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabControl1.SuspendLayout();
            this.基础.SuspendLayout();
            this.groupBox_process.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_frequence)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_memory)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.基础);
            this.tabControl1.Controls.Add(this.待定);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(747, 391);
            this.tabControl1.TabIndex = 0;
            // 
            // 基础
            // 
            this.基础.Controls.Add(this.groupBox1);
            this.基础.Controls.Add(this.groupBox_process);
            this.基础.Location = new System.Drawing.Point(4, 22);
            this.基础.Name = "基础";
            this.基础.Padding = new System.Windows.Forms.Padding(3);
            this.基础.Size = new System.Drawing.Size(739, 365);
            this.基础.TabIndex = 0;
            this.基础.Text = "基础";
            this.基础.UseVisualStyleBackColor = true;
            // 
            // 待定
            // 
            this.待定.Location = new System.Drawing.Point(4, 22);
            this.待定.Name = "待定";
            this.待定.Padding = new System.Windows.Forms.Padding(3);
            this.待定.Size = new System.Drawing.Size(739, 365);
            this.待定.TabIndex = 1;
            this.待定.Text = "待定";
            this.待定.UseVisualStyleBackColor = true;
            // 
            // groupBox_process
            // 
            this.groupBox_process.Controls.Add(this.numericUpDown_frequence);
            this.groupBox_process.Controls.Add(this.label1);
            this.groupBox_process.Controls.Add(this.button_refresh);
            this.groupBox_process.Controls.Add(this.button_start);
            this.groupBox_process.Controls.Add(this.comboBox_process);
            this.groupBox_process.Location = new System.Drawing.Point(7, 16);
            this.groupBox_process.Name = "groupBox_process";
            this.groupBox_process.Size = new System.Drawing.Size(726, 55);
            this.groupBox_process.TabIndex = 0;
            this.groupBox_process.TabStop = false;
            this.groupBox_process.Text = "进程选择";
            // 
            // comboBox_process
            // 
            this.comboBox_process.FormattingEnabled = true;
            this.comboBox_process.Location = new System.Drawing.Point(7, 21);
            this.comboBox_process.Name = "comboBox_process";
            this.comboBox_process.Size = new System.Drawing.Size(115, 20);
            this.comboBox_process.TabIndex = 0;
            // 
            // button_start
            // 
            this.button_start.Location = new System.Drawing.Point(634, 17);
            this.button_start.Name = "button_start";
            this.button_start.Size = new System.Drawing.Size(75, 23);
            this.button_start.TabIndex = 1;
            this.button_start.Text = "开始监控";
            this.button_start.UseVisualStyleBackColor = true;
            this.button_start.Click += new System.EventHandler(this.button_start_Click);
            // 
            // button_refresh
            // 
            this.button_refresh.Location = new System.Drawing.Point(128, 19);
            this.button_refresh.Name = "button_refresh";
            this.button_refresh.Size = new System.Drawing.Size(60, 23);
            this.button_refresh.TabIndex = 2;
            this.button_refresh.Text = "刷新";
            this.button_refresh.UseVisualStyleBackColor = true;
            this.button_refresh.Click += new System.EventHandler(this.button_refresh_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(195, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "输出频率（毫秒）：";
            // 
            // numericUpDown_frequence
            // 
            this.numericUpDown_frequence.Increment = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numericUpDown_frequence.Location = new System.Drawing.Point(306, 20);
            this.numericUpDown_frequence.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.numericUpDown_frequence.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown_frequence.Name = "numericUpDown_frequence";
            this.numericUpDown_frequence.Size = new System.Drawing.Size(79, 21);
            this.numericUpDown_frequence.TabIndex = 4;
            this.numericUpDown_frequence.Value = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chart_memory);
            this.groupBox1.Controls.Add(this.richTextBox_res);
            this.groupBox1.Location = new System.Drawing.Point(9, 77);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(724, 282);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "结果|内存KB(专用工作集)|CPU%(专用)";
            // 
            // richTextBox_res
            // 
            this.richTextBox_res.HideSelection = false;
            this.richTextBox_res.Location = new System.Drawing.Point(6, 20);
            this.richTextBox_res.Name = "richTextBox_res";
            this.richTextBox_res.Size = new System.Drawing.Size(712, 256);
            this.richTextBox_res.TabIndex = 0;
            this.richTextBox_res.Text = "";
            // 
            // chart_memory
            // 
            chartArea1.AxisX.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea1.Name = "ChartArea1";
            this.chart_memory.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart_memory.Legends.Add(legend1);
            this.chart_memory.Location = new System.Drawing.Point(161, 35);
            this.chart_memory.Name = "chart_memory";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "内存";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "CPU";
            this.chart_memory.Series.Add(series1);
            this.chart_memory.Series.Add(series2);
            this.chart_memory.Size = new System.Drawing.Size(546, 241);
            this.chart_memory.TabIndex = 1;
            this.chart_memory.Text = "chart1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 436);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.基础.ResumeLayout(false);
            this.groupBox_process.ResumeLayout(false);
            this.groupBox_process.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_frequence)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart_memory)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage 基础;
        private System.Windows.Forms.TabPage 待定;
        private System.Windows.Forms.GroupBox groupBox_process;
        private System.Windows.Forms.Button button_start;
        private System.Windows.Forms.ComboBox comboBox_process;
        private System.Windows.Forms.Button button_refresh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown_frequence;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox richTextBox_res;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_memory;
    }
}

