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

namespace WpfAppDemo
{
    /// <summary>
    /// WpfAppDemoHome.xaml 的交互逻辑
    /// </summary>
    public partial class WpfAppDemoHome : Page
    {
        public WpfAppDemoHome()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // View Expense Report
            FeeReportPage feeReportPage = new FeeReportPage(this.peopleListBox.SelectedItem);
            this.NavigationService.Navigate(feeReportPage);
        }
    }
}
