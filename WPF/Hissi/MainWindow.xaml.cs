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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static List<Page> Kerrokset = new List<Page>();

        public MainWindow()
        {
            InitializeComponent();

            Kerrokset.Add(new Kerros1());
            Kerrokset.Add(new Kerros2());
            Kerrokset.Add(new Kerros3());
            Kerrokset.Add(new Kerros4());

            main_frame.NavigationService.Navigate(Kerrokset[0]);
        }
    }
}
