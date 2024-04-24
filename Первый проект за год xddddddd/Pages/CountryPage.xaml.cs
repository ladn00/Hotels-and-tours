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

namespace Первый_проект_за_год_xddddddd.Pages
{
    /// <summary>
    /// Логика взаимодействия для CountryPage.xaml
    /// </summary>
    public partial class CountryPage : Page
    {
        public CountryPage()
        {
            InitializeComponent();
            dgCountries.ItemsSource = MainWindow.baza.Country.ToList();
        }
        private void Country_Edit(object sender, RoutedEventArgs e)
        {
            var editButton = sender as Button;
            var selectedCountry = editButton.DataContext as Country;
            Windows.CountryEditWin win = new Windows.CountryEditWin(selectedCountry);
            win.ShowDialog();
        }

        private void Country_Delete(object sender, RoutedEventArgs e)
        {

        }

        private void Hotel_Add(object sender, RoutedEventArgs e)
        {

        }
    }
}
