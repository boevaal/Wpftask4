using System;
using System.Linq;
using System.Windows;

namespace WPFtask4
{
    public partial class Task3Window : Window
    {
        public Task3Window()
        {
            InitializeComponent();
        }

        private void CalculateSum_Click(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(InputN.Text, out int n) && n > 0)
            {
                int sum = Enumerable.Range(1, n).Sum();
                ResultBlock.Text = $"Сумма чисел от 1 до {n}: {sum}";
            }
            else
            {
                ResultBlock.Text = "Введите корректное положительное число.";
            }
        }
    }
}
