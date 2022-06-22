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
    /// Логика взаимодействия для Window4.xaml
    /// </summary>
    public partial class Window4 : Window
    {
        public Window4()
        {
            InitializeComponent();
        }

        private void HeightSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            HeightText.Text = $"Рост: {HeightSlider.Value} см";
        }

        private void WeightSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            WeightText.Text = $"Вес: {WeightSlider.Value}  кг";
        }

        private void Сonfirm_Click(object sender, RoutedEventArgs e)
        {
            string sex;
            if (SexM.IsChecked ?? false)
            {
                sex = "Мужчина";
            }
            else if(SexF.IsChecked ?? false)
            {
                sex = "Женщина";
            }
            else
            {
                sex = "Не указан";
            }
            MessageBox.Show($"ФИО: {NameBox.Text} \nПол: {sex} \nДата рождения: {DateBox.SelectedDate?.ToString("dd.MM.yyyy")} \nЖенат/замужем: {((CheckMarried.IsChecked ?? false) ? "Да" : "Нет")}\n{HeightText.Text}\n{WeightText.Text}", "Вывод");
        }
    }
}
