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

namespace Harjoitus16
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        float KmToMiles = 0.62137f;
        float MilesToKm = 1.60934f;

        public MainWindow()

        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btn_kmtomiles(object sender, RoutedEventArgs e)
        {
            float value = float.Parse(txt_input.Text);
            float muunnettuArvo = value + MilesToKm;
            tb_lopputulos.Text = value + "mailia on " + muunnettuArvo + "km";
        }

        private void btn_milestokm(object sender, RoutedEventArgs e)
        {
            float value = float.Parse(txt_input.Text);
            float muunnettuArvo = value + MilesToKm;
            tb_lopputulos.Text = value + "mailia on " + muunnettuArvo + "km";
        }
    }
}
