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
using System.Globalization;

namespace Isolate
{
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(Properties.Resources.Hello);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            // 日本語化
            Properties.Resources.Culture = CultureInfo.GetCultureInfo("ja-JP");
            // Bindingを強制アップデート(動的にカルチャー切り替えない限りは必要ない)
            button1.GetBindingExpression(Button.ContentProperty).UpdateTarget();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            // 英語化
            Properties.Resources.Culture = CultureInfo.GetCultureInfo("en-US");
            // Bindingを強制アップデート(動的にカルチャー切り替えない限りは必要ない)
            button1.GetBindingExpression(Button.ContentProperty).UpdateTarget();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            // 英語化
            Properties.Resources.Culture = CultureInfo.GetCultureInfo("zh-CN");
            // Bindingを強制アップデート(動的にカルチャー切り替えない限りは必要ない)
            button1.GetBindingExpression(Button.ContentProperty).UpdateTarget();
        }
    }
}
