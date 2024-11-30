using System;
using System.Linq;
using System.Windows;

namespace WPFtask4
{
    public partial class Task1Window : Window
    {
        public Task1Window()
        {
            InitializeComponent();
        }

        private void CalculateSum_Click(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(InputA.Text, out int a) && int.TryParse(InputB.Text, out int b) && a < b)
            {
                int sum = Enumerable.Range(a + 1, b - a - 1).Sum();
                ResultBlock.Text = $"Сумма чисел между {a} и {b}: {sum}";
            }
            else
            {
                ResultBlock.Text = "Введите корректные числа (A < B)";
            }
        }

        private void ShowOddNumbers_Click(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(InputA.Text, out int a) && int.TryParse(InputB.Text, out int b) && a < b)
            {
                var oddNumbers = Enumerable.Range(a + 1, b - a - 1).Where(x => x % 2 != 0);
                ResultBlock.Text = $"Нечетные числа между {a} и {b}: {string.Join(", ", oddNumbers)}";
            }
            else
            {
                ResultBlock.Text = "Введите корректные числа (A < B)";
            }
        }
    }
}
