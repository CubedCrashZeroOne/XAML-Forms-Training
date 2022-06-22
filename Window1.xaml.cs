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
using System.Windows.Shapes;

namespace MyVP1
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
            PlatformBox.ItemsSource = Enum.GetValues(typeof(Platform)).Cast<Platform>();
        }

        private void Сonfirm_Click(object sender, RoutedEventArgs e)
        {
            string region;
            if(RegNA.IsChecked ?? false)
            {
                region = "North America (NTSC-U)";
            }
            else if (RegJP.IsChecked ?? false)
            {
                region = "Japan (NTSC-J)";
            }
            else if (RegEU.IsChecked ?? false)
            {
                region = "Europe (PAL)";
            }
            else if (RegAU.IsChecked ?? false)
            {
                region = "Australia (PAL)";
            }
            else
            {
                region = "Не указано";
            }
            MessageBox.Show($"Название: {NameBox.Text} \nРегион: {region} \nДата выхода: {DateBox.SelectedDate?.ToString("dd.MM.yyyy")} \nПлатформа: {PlatformBox.SelectedItem} \nПеревод: {((CheckRus.IsChecked ?? false) ? "Да" : "Нет")}", "Вывод");
        }

        private void RegNA_Checked(object sender, RoutedEventArgs e)
        {

        }
    }
}
