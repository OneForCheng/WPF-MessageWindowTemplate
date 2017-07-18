using System;
using System.Windows;
using System.Windows.Media.Animation;
using ForCheng.WindowTemplate;

namespace TestWpfApplication
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void First_Click(object sender, RoutedEventArgs e)
        {
            var msgWin = new MessageWindow(new Message("温馨提示:模式一", MessageBoxMode.SingleMode))
            {
                MiddleBtnContent = "确定(Y)",
                WindowStartupLocation = WindowStartupLocation.CenterScreen,
            };
            msgWin.SetOpacityAnimation(new DoubleAnimation(1, 0.1, new Duration(TimeSpan.FromSeconds(10))), msgWin.Close);
            msgWin.ShowDialog();
        }

        private void Second_Click(object sender, RoutedEventArgs e)
        {
            var msg = new Message("温馨提示:模式二", MessageBoxMode.DoubleMode);
            var msgWin = new MessageWindow(msg)
            {
      
                //LeftBtnContent = "确定(Y)",
                //RightBtnContent = "取消(N)",
                WindowStartupLocation = WindowStartupLocation.CenterScreen,
            };
            msgWin.ShowDialog();
            switch (msg.Result)
            {
                case ClickResult.LeftBtn:
                    //..
                    break;
                case ClickResult.RightBtn:
                    //..
                    break;
                case ClickResult.Close:
                    //..
                    break;
              
            }
        }

        private void Third_Click(object sender, RoutedEventArgs e)
        {
            var msg = new Message("温馨提示:模式三", MessageBoxMode.ThreeMode);
            var msgWin = new MessageWindow(msg)
            {
         
                LeftBtnContent = "执行(Y)",
                MiddleBtnContent = "撤销(N)",
                RightBtnContent = "取消(N)",
                WindowStartupLocation = WindowStartupLocation.CenterScreen,
            };
            msgWin.ShowDialog();
            switch (msg.Result)
            {
                case ClickResult.LeftBtn:
                    //..
                    break;
                case ClickResult.MiddleBtn:
                    //..
                    break;
                case ClickResult.RightBtn:
                    //..
                    break;
                case ClickResult.Close:
                    //..
                    break;
              
            }
        }
    }
}
