using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using 内存监控;

namespace 资源监视器
{
    public partial class Form1 : Form
    {
        private static string appName = "资源监控器";
        private static string appVersion = "v1.0";
        private static string appAuth = "345280563@qq.com";

        private static string appTitle = appName + " " + appVersion + " " + appAuth;

        /// <summary>
        /// 是否开启监控
        /// </summary>
        private static bool isStart = false;
     
        public Form1()
        {
            InitializeComponent();
            this.Text = appTitle;
        }


        /// <summary>
        /// 刷新进程
        /// </summary>
        private void refreshProcess()
        {
            Process[] ps = Process.GetProcesses();
            foreach (Process p in ps)
            {
                string info = "";
                try
                {
                    info = p.Id + "  " + p.ProcessName + "  " + p.MainWindowTitle;
                }
                catch (Exception ex)
                {
                    info = ex.Message;
                }
                Console.WriteLine(info);
            }
            //if(this.InvokeRequired)
            //{

            //}
            comboBox_process.DataSource = ps;
            comboBox_process.DisplayMember = "ProcessName";
            int count = ps.Length;
            Console.WriteLine(string.Format("进程总数[{0}]", count));
            groupBox_process.Text = string.Format("进程总数[{0}]", count);
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            refreshProcess();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }

        private void button_refresh_Click(object sender, EventArgs e)
        {
            refreshProcess();
        }

        /// <summary>
        /// 开启监控
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_start_Click(object sender, EventArgs e)
        {
            if (isStart)
            {
                //关闭监控
                this.Text = appTitle;
                isStart = false;
                button_start.Text = "开始监控";
            }
            else
            {
                //开启监控
                this.Text = appTitle+" ......正在监控中......";
                isStart = true;
                button_start.Text = "关闭监控";
                startWatch();
            }
        }


        SystemInfo sys = new SystemInfo();
        const int KB_DIV = 1024;
        const int MB_DIV = 1024 * 1024;
        const int GB_DIV = 1024 * 1024 * 1024;

        PerformanceCounter curpcp = null;
        //PerformanceCounter curpc = null;
        PerformanceCounter curtime = null;

        private void startWatch()
        {
            richTextBox_res.Clear();

            txData2.Clear();
            tyData2.Clear();
            txData3.Clear();
            tyData3.Clear();


            //获取当前选择进程对象
            Process cur = (Process)comboBox_process.SelectedItem;
            Console.WriteLine(string.Format("选择进程[{0},{1}]", cur.Id, cur.ProcessName));
            if (cur == null)
            {
                MessageBox.Show("指定的进程不存在!");
                return;
            }
            //Sleep的时间间隔
            int interval = int.Parse(numericUpDown_frequence.Value.ToString());
             curpcp = new PerformanceCounter("Process", "Working Set - Private", cur.ProcessName);
            // curpc = new PerformanceCounter("Process", "Working Set", cur.ProcessName);
             curtime = new PerformanceCounter("Process", "% Processor Time", cur.ProcessName);

           
            //上次记录CPU的时间
            //TimeSpan prevCpuTime = TimeSpan.Zero;


            //PerformanceCounter totalcpu = new PerformanceCounter("Processor", "% Processor Time", "_Total");


            Thread watch= new Thread(() =>
            {
            
                while (isStart)
                {
                    //第一种方法计算CPU使用率
                    //当前时间
                    //TimeSpan curCpuTime = cur.TotalProcessorTime;
                    //计算
                    //double value = (curCpuTime - prevCpuTime).TotalMilliseconds / interval / Environment.ProcessorCount * 100;
                    //prevCpuTime = curCpuTime;

                    //Console.WriteLine("{0}:{1} {2:N}KB CPU使用率：{3}", cur.ProcessName, "工作集(进程类)", cur.WorkingSet64 / 1024, value);//这个工作集只是在一开始初始化，后期不变
                    //Console.WriteLine("{0}:{1} {2:N}KB CPU使用率：{3}", cur.ProcessName, "工作集    ", curpc.NextValue() / 1024, value);//这个工作集是动态更新的
                    //第二种计算CPU使用率的方法
                    //Console.WriteLine("{0}:{1} {2}KB CPU使用率：{3}%", cur.ProcessName, "私有工作集  ", Math.Round(curpcp.NextValue() / 1024), Math.Round(curtime.NextValue() / Environment.ProcessorCount));
                    //Thread.Sleep(interval);



                    //第一种方法获取系统CPU使用情况
                    //Console.Write("\r系统CPU使用率：{0}%", totalcpu.NextValue());
                    //Thread.Sleep(interval);

                    //第二章方法获取系统CPU和内存使用情况
                    //Console.WriteLine("系统CPU使用率：{0}%，系统内存使用大小：{1}MB({2}GB)", sys.CpuLoad, (sys.PhysicalMemory - sys.MemoryAvailable) / MB_DIV, (sys.PhysicalMemory - sys.MemoryAvailable) / (double)GB_DIV);

                   
                    //c = txData3.Count();
                    //txData3.Add(c + 1);
                    //tyData3.Add(int.Parse(Math.Round(curtime.NextValue() / Environment.ProcessorCount).ToString()));


                    StringBuilder sb = new StringBuilder();
                    sb.Append(DateTime.Now).Append(",").Append(Math.Round(curpcp.NextValue() / 1024).ToString()).Append(",").Append(Math.Round(curtime.NextValue() / Environment.ProcessorCount).ToString()).Append(Environment.NewLine);

                    if (richTextBox_res.InvokeRequired)
                    {
                        DeRichTextBoxAdd de = new DeRichTextBoxAdd(richTextBoxAdd);
                        Invoke(de, sb.ToString());
                    }
                    else
                    {
                        richTextBoxAdd(sb.ToString());
                    }
                    Thread.Sleep(interval);
                }
            });
           watch.Start();
        }

        List<int> txData2 = new List<int>();
        List<int> tyData2 = new List<int>();

        List<int> txData3 = new List<int>();
        List<int> tyData3 = new List<int>();

        private delegate void DeRichTextBoxAdd(string msg);

        int c = 0;
        private void richTextBoxAdd(string msg)
        {
            //Console.WriteLine(sys.PhysicalMemory);
            c++;
            if (chart_memory.Series[0] == null)
            {
                chart_memory.Series.Add(new Series()); //添加一个图表序列
                chart_memory.Series.Add(new Series()); //添加一个图表序列
            }
            chart_memory.Series[0].LegendText = "内存(KB)";
            //chart_memory.Series[0].Label = "#VAL"; //设置显示X Y的值 
            chart_memory.Series[0].ChartType = SeriesChartType.Spline; //图类型(折线)
            //chart_memory.Series[0].Points.DataBindXY(txData2, tyData2); //添加数据
           

            chart_memory.Series[0].Points.AddXY(c, Math.Round(curpcp.NextValue() / 1024).ToString());


            chart_memory.Series[1].LegendText = "CPU(%)";
            //chart_memory.Series[1].Label = "#VAL"; //设置显示X Y的值 
            chart_memory.Series[1].ChartType = SeriesChartType.Spline; //图类型(折线)
            chart_memory.Series[1].Points.AddXY(c, Math.Round(curtime.NextValue() / Environment.ProcessorCount).ToString()); //添加数据

            richTextBox_res.AppendText(msg);
        }
    }
}
