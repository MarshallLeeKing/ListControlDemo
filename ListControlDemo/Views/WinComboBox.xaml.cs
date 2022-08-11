using System.Windows;

namespace ListControlDemo.Views
{
    /// <summary>
    /// Логика взаимодействия для WinComboBox.xaml
    /// </summary>
    public partial class WinComboBox : Window
    {
        public WinComboBox() {
            InitializeComponent();

            // программное заполнение комбо-бокса
            CbCars.ItemsSource = new [] { "Понтиак", "Волга", "Газель", "Импала", "Бобер", "Ежик"};
        } // WinComboBox

        // Обработчик выбора в комбо-боксе
        private void CbFruits_SelectionChanged(object sender, RoutedEventArgs e) {
            TxbSelected.Text = CbFruits.SelectedItem.ToString();
        } // CbFruits_SelectionChanged

        // Обработчик выбора в комбо-боксе cbCars
        private void CbCars_SelectionChanged(object sender, RoutedEventArgs e)
        {
            TxbSelected.Text = CbCars.SelectedItem.ToString();
        } // CbCars_SelectionChanged
    } // class WinComboBox
}
