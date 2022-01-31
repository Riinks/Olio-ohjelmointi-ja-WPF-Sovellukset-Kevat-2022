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

namespace Hissi
{
    /// <summary>
    /// Interaction logic for Kerros1.xaml
    /// </summary>
    public partial class Kerros1 : Page
    {
        public Kerros1()
        {
            InitializeComponent();
        }

        private void btn_kerros1_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(MainWindow.Kerrokset[0]);
        }

        private void btn_kerros2_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(MainWindow.Kerrokset[1]);
        }

        private void btn_kerros3_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(MainWindow.Kerrokset[2]);
        }

        private void btn_kerros4_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(MainWindow.Kerrokset[3]);
        }
    }
}
