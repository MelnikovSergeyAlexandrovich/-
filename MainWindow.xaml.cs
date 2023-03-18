using System.Windows;
using FirstPracticeTask.dataWPFDataSetTableAdapters;

namespace FirstPracticeTask
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        pizzasTableAdapter Pizza = new pizzasTableAdapter();
        piesTableAdapter Pie = new piesTableAdapter();
        bakeryShopTableAdapter BakeryShop = new bakeryShopTableAdapter();   

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Window2 window2 = new Window2();
            window2.BakeryData.ItemsSource = BakeryShop.GetData();
            window2.Show();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Window1 window1 = new Window1();
            window1.PizzasData.ItemsSource = Pizza.GetData();
            window1.Show();
        }

        private void PiesDataBaseButton_Click(object sender, RoutedEventArgs e)
        {
            Window3 window3 = new Window3();
            window3.PiesData.ItemsSource = Pie.GetData();
            window3.Show();
        }
    }
}
