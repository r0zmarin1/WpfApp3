using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace WpfApp3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        private Producti selectedProducti;

        public event PropertyChangedEventHandler? PropertyChanged;

        public List<Producti> Products { get; set; }
        public Producti SelectedProducti
        {
            get => selectedProducti;
            set
            {
                selectedProducti = value;
                PropertyChanged?.Invoke(this,
                    new PropertyChangedEventArgs(nameof(SelectedProducti)));
            }
        }
        public MainWindow()
        {
            InitializeComponent();

            Products = new List<Producti>();
            Products.Add(new Producti
            {
                Name = "Помидоры",
                Quantity = "1 кг",
                Price = 139
            });
            Products.Add(new Producti
            {
                Name = "Французкий батон",
                Quantity = "1  шт",
                Price = 49
            });
            Products.Add(new Producti
            {
                Name = "Маслины",
                Quantity = "2 банки",
                Price = 246
            });
            Products.Add(new Producti
            {
                Name = "Колбаса докторская",
                Quantity = "1 кг",
                Price = 509
            });
            Products.Add(new Producti
            {
                Name = "Сыр пармезан",
                Quantity = "400 гр",
                Price = 336
            });
            Products.Add(new Producti
            {
                Name = "Рис круглозерный",
                Quantity = "900 г",
                Price = 289
            });
            DataContext = this;
        }

        public class Producti
        {
            public string Name { get; set; }
            public int Price { get; set; }
            public string Quantity { get; set; }
        }
    }
}
