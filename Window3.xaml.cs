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
    /// Логика взаимодействия для Window3.xaml
    /// </summary>
    public partial class Window3 : Window
    {
        public Window3()
        {
            InitializeComponent();
            GenreBox.ItemsSource = Enum.GetValues(typeof(Genre)).Cast<Genre>();
        }

        private void Age_Checked(object sender, RoutedEventArgs e)
        {
            if (AgeNo.IsChecked ?? true)
            {
                RestrictionBox.IsEnabled = false;
            } 
            else
            {
                RestrictionBox.IsEnabled = true;
            }
        }

        private void Сonfirm_Click(object sender, RoutedEventArgs e)
        {
            string restriction;

            if (AgeNo.IsChecked ?? false)
            {
                restriction = "Нет";
            }
            else if (Age10.IsChecked ?? false)
            {
                restriction = "10+";
            }
            else if(Age13.IsChecked ?? false)
            {
                restriction = "13+";
            }
            else if(Age16.IsChecked ?? false)
            {
                restriction = "16+";
            }
            else if(Age18.IsChecked ?? false)
            {
                restriction = "18+";
            }
            else
            {
                restriction = "Не указано";
            }

            MessageBox.Show($"Название: {NameBox.Text} \nЖанр: {GenreBox.SelectedItem} \nВозрастное ограничение: {restriction}\n{(RestrictionBox.IsEnabled ? $"Причина: {RestrictionBox.Text}\n" : "")}3D: {((Check3D.IsChecked ?? false) ? "Да" : "Нет")}\nIMAX: {((CheckImax.IsChecked ?? false) ? "Да" : "Нет")}", "Вывод");
        }
    }
}
