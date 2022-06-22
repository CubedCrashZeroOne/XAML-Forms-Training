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

namespace MyVP1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Var1_Click(object sender, RoutedEventArgs e)
        {
            var w1 = new Window1();
            w1.ShowDialog();
        }

        private void Var2_Click(object sender, RoutedEventArgs e)
        {
            var w2 = new Window2();
            w2.ShowDialog();
        }

        private void Var3_Click(object sender, RoutedEventArgs e)
        {
            var w3 = new Window3();
            w3.ShowDialog();
        }

        private void Var4_Click(object sender, RoutedEventArgs e)
        {
            var w4 = new Window4();
            w4.ShowDialog();
        }

        private void Var5_Click(object sender, RoutedEventArgs e)
        {
            var w5 = new Window5();
            w5.ShowDialog();
        }

        private void Var6_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Var7_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Var8_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
