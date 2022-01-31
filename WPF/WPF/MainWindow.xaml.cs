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

namespace WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        int autot = 0;
        int kuormaautot = 0;

        public MainWindow()
        {
            InitializeComponent();
            TB_Auto.Text = autot.ToString();
            TB_kuormaauto.Text = kuormaautot.ToString();
        }

        private void btn_kuormaauto_Click(object sender, RoutedEventArgs e)
        {
            kuormaautot++;
            TB_kuormaauto.Text = kuormaautot.ToString();
        }

        private void btn_auto_Click(object sender, RoutedEventArgs e)
        {
            autot++;
            TB_Auto.Text = autot.ToString();
        }
    }
}
