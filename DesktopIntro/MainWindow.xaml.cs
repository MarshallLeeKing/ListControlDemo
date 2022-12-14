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

namespace DesktopIntro
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Exit_Click(object sender, RoutedEventArgs e) => Application.Current.Shutdown(0);

        private void New_Click(object sender, RoutedEventArgs e) {
            MessageBox.Show("Команда меню New", "К сведению", MessageBoxButton.OK, MessageBoxImage.Information);
        }
        private void Open_Click(object sender, RoutedEventArgs e) {
            MessageBox.Show("Команда меню Open", "К сведению", MessageBoxButton.OK, MessageBoxImage.Information);
        }


    }
}
