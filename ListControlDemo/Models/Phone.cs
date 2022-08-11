namespace ListControlDemo.Models
{
    // данные о телефоне (как товаре)
    class Phone
    {
        
        // модель телефона
        private string _title;
        public string Title {
            get => _title;
            set => _title = string.IsNullOrWhiteSpace(value)?_title:value;
        } // Title

        // производитель телефона
        private string _company;
        public string Company {
            get => _company;
            set => _company = value;
        } // Company

        // стоимость телефона
        private int _price;
        public int Price {
            get => _price;
            set => _price = value;
        } // Price

    } // class Phone
}
