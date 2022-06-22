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
    /// Логика взаимодействия для Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        public Window2()
        {
            InitializeComponent();
            SpecBox.ItemsSource = Enum.GetValues(typeof(Major)).Cast<Major>();
        }

        private void ZaoRadio_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void CreditSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            SliderText.Text = $"Количество кредитов: {CreditSlider.Value}"; 
        }

        private void NameBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            string text = NameBox.Text;
            if (string.IsNullOrEmpty(text))
            {
                AbbrBox.Text = string.Empty;
                return;
            }
            text = text.Replace('-', ' ');
            var arr = text.Trim().Split(' ').ToList();
            arr.RemoveAll(n => n.Equals("в") || n.Equals("и") || string.IsNullOrEmpty(n));
            if (arr.Count == 0)
            {
                AbbrBox.Text = string.Empty;
                return;
            }
            var chArr = arr.Select(n =>char.ToUpper(n[0])).ToArray();
            text = new string(chArr);
            AbbrBox.Text = text;
        }

        private void Сonfirm_Click(object sender, RoutedEventArgs e)
        {
            string studyForm;
            if (ZaoRadio.IsChecked ?? false)
            {
                studyForm = "Заочная";
            }
            else if (DayRadio.IsChecked ?? false)
            {
                studyForm = "Дневная";
            }
            else if (EvenRadio.IsChecked ?? false)
            {
                studyForm = "Вечерняя";
            }
            else
            {
                studyForm = "Не указано";
            }
            MessageBox.Show($"Название: {NameBox.Text} \nАббревиатура: {AbbrBox.Text} \nСпециальность: {SpecBox.SelectedItem}\nФорма Обучения: {studyForm}\nКоличество кредитов: {CreditSlider.Value} \nЭкзамен: {((CheckExam.IsChecked ?? false) ? "Да" : "Нет")}\nКурсовая Работа: {((CheckCP.IsChecked ?? false) ? "Да" : "Нет")}", "Вывод");
        }
    }
}
