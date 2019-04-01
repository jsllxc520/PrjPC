using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace DeviceControl
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {

        
        //System.Timers.Timer timer;


        public MainWindow()
        {
            InitializeComponent();
            InitTimer();
        }



        private void InitTimer()
        {
            int iTimeCnt = 1000; //单位为mS

            //
            DispatcherTimer timer = new DispatcherTimer();
            //设置定时间隔(毫秒为单位)
            timer.Tick += new EventHandler(OnTimedEvent);
            // 
            timer.Interval = new TimeSpan(10000000);
            ////设置执行一次（false）还是一直执行(true)
            //timer.AutoReset = true;
            ////设置是否执行System.Timers.Timer.Elapsed事件
            //timer.Enabled = true;
            ////绑定Elapsed事件
            //timer.Elapsed += new System.Timers.ElapsedEventHandler(OnTimedEvent);
            //启动timer
            timer.Start();
            
        }

        private void OnTimedEvent(object sender, EventArgs e)
        {

            Console.WriteLine("The Elapsed event was raised at {0}", DateTime.Now.ToString());
            //string tttt = e.SignalTime.ToString();
            //this.Title = string.Concat("ffd", DateTime.Now.ToString());

            //testttt(DateTime.Now.ToString());
            //SHOWBOX.AppendText("fff");
            Tmp.Content = DateTime.Now.ToString();



        }

        private void testttt(string aaa)
        {
            this.Title = aaa;
        }

        private void Grid_Initialized(object sender, EventArgs e)
        {

        }
    }
}
