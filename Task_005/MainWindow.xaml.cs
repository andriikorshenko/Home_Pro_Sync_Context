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

namespace Task_005
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

        private async void cmdButton_Start_Click(object sender, RoutedEventArgs e)
        {
            Task<int> task = Task.Run(() => AdditionAsync(2, 3));
            var result = await task.ConfigureAwait(false);

            Dispatcher?.Invoke(() => 
            { 
                TextOutput.Text = result.ToString(); 
            });            
        }

        private async Task<int> AdditionAsync(int x, int y)
        {
            await Task.Delay(100);
            return x + y;
        }
    }
}
