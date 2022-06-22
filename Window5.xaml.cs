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
    /// Логика взаимодействия для Window5.xaml
    /// </summary>
    public partial class Window5 : Window
    {
        public Window5()
        {
            InitializeComponent();
            GenreBox.ItemsSource = Enum.GetValues(typeof(Genre)).Cast<Genre>();
        }

        private void HeightSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            PageText.Text = $"Количество страниц: {HeightSlider.Value}";
        }

        private void Сonfirm_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"Название книги: {NameBox.Text} \nАвтор: {AuthorBox.Text} \nЖанр: {GenreBox.SelectedItem}\nДата выпуска: {DateBox.SelectedDate?.ToString("dd.MM.yyyy")} \nПеревод: {((CheckRus.IsChecked ?? false) ? "Да" : "Нет")}\n{PageText.Text}", "Вывод");

        }
    }
}
