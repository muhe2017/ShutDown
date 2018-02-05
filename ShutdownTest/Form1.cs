using System;
using System.Diagnostics;
using System.Threading;
using System.Windows.Forms;

/*
 * 1，可以根据CPU占用率的大小来控制关机。
 * 2，可以根据多少分钟之后关机（最多24小时）。
 * 
 * 程序：lxl
 * 完成：2018年1月5日16:35:42
 * 版本：v1.0
 * 
 * 修改：
 * 
 */
namespace ShutdownTest
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// 线程
        /// </summary>
        Thread myThread;
        /// <summary>
        /// 按钮点击状态
        /// </summary>
        private bool isClick = false;
        /// <summary>
        /// 手动设置CPU占用率
        /// </summary>
        string Occupys = "10";

        public Form1()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false; //设置是否捕获跨线程调用
            this.FormBorderStyle = FormBorderStyle.FixedSingle; //禁止调整窗口大小
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            Init();

        }

        /// <summary>
        /// CPU使用率控制关机
        /// </summary>
        private void UsageRate()
        {
            //持有CPU占用率
            PerformanceCounter _oPerformanceCounter =
                new PerformanceCounter("Processor", "% Processor Time", "_Total");
            //CPU占用率
            float nVal;
            //循环检测标识
            bool flag = true;
            //超时计数器，到时关闭计算机。
            int ii = 0;
            //线程检测时间间隔
            int time = 1000;
            //设定的CPU占用率上限
            Occupys = InText.Text;
            //定时检测
            bool isMaxMin;

            //判断用大于还是小于
            if (MaxRadioBtn.Checked)
            {
                isMaxMin = false;
            }
            else
            {
                isMaxMin = true;
            }

            while (flag)
            {
                //每次更新UI显示新的占用率
                nVal = _oPerformanceCounter.NextValue();
                CPUlabel.Text = string.Format("{0:F}", nVal) + "%";
                if (isMaxMin)
                {   //小于上限值
                    //如果超过上限值，就让超时计数器+1
                    if (nVal < int.Parse(Occupys.ToString()))
                    {
                        System.Threading.Thread.Sleep(time / 2);
                        //再次检测CPU占用率，如果低于COU占用上限值，则把超时计数器重置
                        //否则超时计数器+1
                        nVal = _oPerformanceCounter.NextValue();
                        if (nVal > int.Parse(Occupys.ToString()))
                        {
                            ii = 0;
                        }
                        else
                        {
                            ++ii;
                        }
                        //超时检测，如果超过时间则跳出循环
                        if (ii > int.Parse(Overtime.Text.ToString()))
                        {
                            flag = false;
                        }
                    }
                }
                else
                {
                    //大于上限值
                    //如果超过上限值，就让超时计数器+1
                    if (nVal > int.Parse(Occupys.ToString()))
                    {
                        System.Threading.Thread.Sleep(time / 2);
                        //再次检测CPU占用率，如果低于COU占用上限值，则把超时计数器重置
                        //否则超时计数器+1
                        nVal = _oPerformanceCounter.NextValue();
                        if (nVal < int.Parse(Occupys.ToString()))
                        {
                            ii = 0;
                        }
                        else
                        {
                            ++ii;
                        }
                        //超时检测，如果超过时间则跳出循环
                        if (ii > int.Parse(Overtime.Text.ToString()))
                        {
                            flag = false;
                        }
                    }
                }

                System.Threading.Thread.Sleep(time / 2);
            }

            CloseLab.Visible = true;
            Second.Visible = true;
            for (int i = 10; i >= 0; i--)
            {
                Second.Text = i.ToString();
                System.Threading.Thread.Sleep(time);
            }
            Shutdown(0);
            //Environment.Exit(0);
        }

        /// <summary>
        /// 按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            
            isClick = !isClick;
                
            if (isClick)
            {
                button1.Text = "取消";
                //CloseLab.Visible = true;
               // ClosingLab.Visible = true;
                //Second.Visible = true;

                switch (IsPatternRadioBtn())
                {
                    case 0:
                        myThread = new Thread(UsageRate);
                        myThread.Start();
                        break;
                    case 1:
                        myThread = new Thread(CountDown);
                        myThread.Start();
                        break;
                    default:
                        break;
                }
                return;
            }
            if (myThread.IsAlive)
                myThread.Abort();

            button1.Text = "开始";
            Second.Text = "X";
            CPUlabel.Text = "0%";
            ClosingLab.Text = "时间";
            CloseLab.Visible = false;
            //ClosingLab.Visible = false;
            Second.Visible = false;


        }

        /// <summary>
        /// 右上角关闭按钮相应事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            //只要按了按钮，则关闭所有线程
            Environment.Exit(0);
        }

        /// <summary>
        /// 关机选择
        /// </summary>
        /// <param name="number">0：关机，1：注销</param>
        /// <param name="tiem">时间</param>
        private void Shutdown(int number, int tiem = 0)
        {
            switch (number)
            {
                case 0:
                    System.Diagnostics.Process.Start("shutdown.exe", "-s"); // 关机
                    break;
                case 1:
                    System.Diagnostics.Process.Start("shutdown.exe", "-l"); // 注销
                    break;
                default:
                    break;
            }
        }

        /// <summary>
        /// 判断是选择哪个模式进行关机控制
        /// </summary>
        /// <returns>0：CPU占用率，1：时间</returns>
        private int IsPatternRadioBtn()
        {
            if (CPURadioBtn.Checked == true)
            {
                //CPU占用率控制模式
                return 0;
            }

            if (TimeRadioBtn.Checked == true)
            {
                //时间控制模式
                return 1;
            }
            return -1;
        }

        /// <summary>
        /// 初始化
        /// </summary>
        private void Init()
        {
            CloseLab.Visible = false;
            Second.Visible = false;
            //ClosingLab.Visible = false;
            CPURadioBtn.Checked = true;
            MinRadioBtn.Checked = true;
        }

        /// <summary>
        /// 倒计时关机
        /// </summary>
        private void CountDown()
        {
            //线程检测间隔时间
            int timeCount = 1000;
            int minute = int.Parse(Minute.Text.ToString());
            var time = DateTime.Now.AddMinutes(minute);

            ClosingLab.Text = time.ToString("t");
            bool isTime = true;
            while (isTime)
            {
                if (time.ToString("t").Equals(DateTime.Now.ToString("t")))
                    isTime = false;
                System.Threading.Thread.Sleep(timeCount);
            }
            //ClosingLab.Text = "关机了";
            Shutdown(0);
            //Environment.Exit(0);
        }

        private void InText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar!='\b')//这是允许输入退格键
            {
                if ((e.KeyChar < '0') || (e.KeyChar > '9')) //这是允许输入0-9数字
                {
                    e.Handled = true;
                }
            }
        }

        private void Overtime_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '\b') //这是允许输入退格键
            {
                if ((e.KeyChar < '0') || (e.KeyChar > '9')) //这是允许输入0-9数字
                {
                    e.Handled = true;
                }
            }
        }

        private void Minute_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '\b') //这是允许输入退格键
            {
                if ((e.KeyChar < '0') || (e.KeyChar > '9')) //这是允许输入0-9数字
                {
                    e.Handled = true;
                }
            }
        }
    }
}
