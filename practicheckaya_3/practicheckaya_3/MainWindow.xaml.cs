using practicheckaya_3.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
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

namespace practicheckaya_3
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnEnter_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Сервис пока не работает, пожалуйста войдите как гость.", "Внимание", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void btnEnterGuests_Click(object sender, RoutedEventArgs e)
        {
            var clientWindow = new Window
            {
                Title = "Клиент",
                Height = 450,
                Width = 800,
                Content = new Client(),
                WindowStartupLocation = WindowStartupLocation.CenterScreen
            };
            clientWindow.Show();
            this.Close();
        }
    }
}