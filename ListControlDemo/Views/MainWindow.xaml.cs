using System.Windows;

namespace ListControlDemo.Views
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow() {
            InitializeComponent();
        } // MainWindow


        // Завершение работы приложения
        private void btnExit_Click(object sender, RoutedEventArgs e) {
            Application.Current.Shutdown();
        } // btnExit_Click

        // Переходы на окна приложения:

        // Переход на окно демонстрации ListBox 
        private void btnListBox_Click(object sender, RoutedEventArgs e) {
            WinListBox win = new WinListBox();
            win.ShowDialog();
        } // btnListBox_Click

        // Переход на окно демонстрации ComboBox
        private void btnComboBox_Click(object sender, RoutedEventArgs e) {
            WinComboBox win = new WinComboBox();
            win.ShowDialog();
        } // btnComboBox_Click

        // Переход на окно демонстрации ListView
        private void btnListView_Click(object sender, RoutedEventArgs e) {
            WinListView win = new WinListView();
            win.ShowDialog();
        } // btnListView_Click
    } // class MainWindow
}
