using System.Linq;
using System.Windows;

namespace WPFtask4 
{
    public partial class Task2Window : Window
    {
        public Task2Window()
        {
            InitializeComponent();
        }

        private void ShowSquares_Click(object sender, RoutedEventArgs e)
        {
            var squares = string.Join(", ", Enumerable.Range(10, 11).Select(x => x * x));
            ResultBlock.Text = $"Квадраты чисел от 10 до 20: {squares}";
        }
    }
}
