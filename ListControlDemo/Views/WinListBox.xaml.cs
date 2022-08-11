using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using ListControlDemo.Models;

namespace ListControlDemo.Views
{
    /// <summary>
    /// Логика взаимодействия для WinListBox.xaml
    /// </summary>
    public partial class WinListBox : Window
    {
        public WinListBox() {
            InitializeComponent();

            // ListBox имеет свойство Items - коллекция элементов списка
            // добавить элемент в список lbTest (верхний левый квадрант окна)
            LbTest.Items.Add("Авокадо - добавлен из кода");

            // назначить источнику данных списка массив строк (вместо массива м.б.
            // также List) 
            string[] cars = { "Понтиак", "Волга", "Газель", "Импала", "Бобер", "Ежик"};
            LbProgrFill.ItemsSource = cars;

            // назначить источнику данных списка коллекцию объектов
            LbProgrFillObj.ItemsSource = new List<Phone> {
                new Phone { Title="Galaxy S7", Company="Samsung", Price=15000 },
                new Phone { Title="iPhone 7", Company="Apple", Price=25000 },
                new Phone { Title="Lumia P12", Company="Microsoft", Price=10000},
                new Phone { Title="Meizu Mi5", Company="Meizu", Price=5000},
                new Phone { Title="Galaxy J7", Company="Samsung", Price=12000},
                new Phone { Title="OneTouch 123", Company="Alcatel", Price=3000}
            };
            LbProgrFillObj.DisplayMemberPath = "Title";
        } // WinListBox


        // Обработчик события "Выбран элемент ListBox" - добавление 
        // выбранного элемента в другой ListBox
        private void lbPhones_SelectionChanged(object sender, RoutedEventArgs e) {
            // получить выбранный телефон из коллекции 
            ListBox listBox = sender as ListBox;
            if (listBox == null) return;
            Phone p = (Phone)listBox.SelectedItem;

            // быстро, но грязно...
            // Phone p = (Phone)(sender as ListBox).SelectedItem;

            // добавить название телефона (т.е. строку) в список строк
            // lbTest - в левый верхний угол окна
            LbTest.Items.Add($"{p.Title} - {p.Price:n2} руб.");
        } // lbPhones_SelectionChanged

        // Обработчик выбора в ListBox с машинами
        private void lbProgrFill_Selected(object sender, SelectionChangedEventArgs e) {
            string str = (string)(sender as ListBox)?.SelectedItem;
            MessageBox.Show($"Выбрана строка \"{str}\"", "К сведению");
        } // lbProgrFill_Selected

        // TODO: добраться до текста в разметке элемента
        // Обработчик выбора в ListBox со сложным дизайном - с коллекцией самолетов
        private void lbAirliners_SelectionChanged(object sender, SelectionChangedEventArgs e) {
            ListBoxItem listBoxItem = (ListBoxItem)(sender as ListBox)?.SelectedItem;

            MessageBox.Show($"Выбран самолет \"{listBoxItem}\"", "К сведению", MessageBoxButton.OK, MessageBoxImage.Information);
        } // lbAirliners_SelectionChanged
    } // class WinListBox
}
