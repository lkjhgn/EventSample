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

namespace EventSample
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            //属性值 方法处理器 挂载事件 timer类(event)
            InitializeComponent();
            //实例化 timer()
            DispatcherTimer timer = new DispatcherTimer();
            //实用多长seconds生成 timespan
            timer.Interval = TimeSpan.FromSeconds(1);
            // 用 += 将 timer_tick 函数 挂接到 事件 当timer.tick发生 执行方法
            //事件处理器
            timer.Tick += Timer_Tick ;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            this.timeTextBox.Text = DateTime.Now.ToString();
        }
    }
}
