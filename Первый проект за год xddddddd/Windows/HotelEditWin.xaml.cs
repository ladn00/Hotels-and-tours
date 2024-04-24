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
using System.Windows.Shapes;

namespace Первый_проект_за_год_xddddddd.Windows
{
    /// <summary>
    /// Логика взаимодействия для HotelEditWin.xaml
    /// </summary>
    public partial class HotelEditWin : Window
    {
        Hotel hotel;

        public HotelEditWin(Hotel hotel)
        {
            InitializeComponent();
            this.hotel = hotel;
            DataContext = hotel;
            cb_Countries.ItemsSource = MainWindow.baza.Country.ToList();
        }

        private void bt_SaveClick(object sender, RoutedEventArgs e)
        {

        }
    }
}
