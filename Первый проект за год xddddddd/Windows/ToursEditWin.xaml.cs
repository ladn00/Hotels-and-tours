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
    /// Логика взаимодействия для ToursEditWin.xaml
    /// </summary>
    public partial class ToursEditWin : Window
    {
        Tour tour;
        public ToursEditWin(Tour tour)
        {
            InitializeComponent();
            this.tour = tour;
            DataContext = tour;
            cb_Images.ItemsSource = null;
            cb_Images.ItemsSource = MainWindow.baza.Tour.ToList();
        }

        private void bt_SaveClick(object sender, RoutedEventArgs e)
        {

        }
    }
}
