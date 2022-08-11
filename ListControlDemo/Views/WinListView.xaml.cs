using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using ListControlDemo.Models;

namespace ListControlDemo.Views
{
    /// <summary>
    /// Логика взаимодействия для WinListView.xaml
    /// </summary>
    public partial class WinListView : Window
    {
        private List<Phone> _phones;

        public WinListView() {
            InitializeComponent();

            // Если контент задан ресурсом в разметке ListView, то добавление в ListView
            // приведет к выбросу исключения
            // LvPhones1.Items.Add(new Phone { Company="BQ", Title="BQ 2300", Price=1990});

            _phones = new List<Phone>(new[] {
                new Phone{Title="Galaxy A03S",  Company = "Samsung", Price = 13_440},
                new Phone{Title="BQ-5031G Fun", Company = "BQ",      Price =  4_720},
                new Phone{Title="Spark 6 Go",   Company = "Tecno",   Price =  9_200},
                new Phone{Title="Blade A51",    Company = "ZTE",     Price =  9_760},
                new Phone{Title="C01 Plus",     Company = "Nokia",   Price =  6_960},
                new Phone{Title="C20",          Company = "Nokia",   Price =  8_640}
            });
            
            // добавление не в ListView, а в коллекцию - источник данных 
            LvPhones2.ItemsSource = _phones;
            _phones.Add(new Phone { Company = "BQ", Title = "BQ 2300", Price = 1990 });
        } // WinListView


        // обработка выбора элемента в ListView
        private void LvPhones_OnSelectionChanged(object sender, SelectionChangedEventArgs e) {
            ListView lvPhones = sender as ListView;
            
            if (lvPhones.SelectedIndex < 0) return;

            Phone phone = _phones[lvPhones.SelectedIndex];
            MessageBox.Show($"Выбран телефон {phone.Title} | {phone.Company} | {phone.Price:n2}",
                "Выбор", MessageBoxButton.OK, MessageBoxImage.Information); 
            e.Handled = true;
        }
    } // class WinListView
}
