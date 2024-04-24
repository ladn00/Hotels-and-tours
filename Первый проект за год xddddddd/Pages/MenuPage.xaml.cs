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
    /// Логика взаимодействия для MenuPage.xaml
    /// </summary>
    public partial class MenuPage : Page
    {
        public MenuPage()
        {
            InitializeComponent();
        }

        private void Tur_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Pages.ToursPage());
        }

        private void Hotels_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Pages.HotelsPage());
        }

        private void Countries_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Pages.CountryPage());
        }

        private void Types_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Pages.TypePage());
        }

        private void NewHotels_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Pages.HotelsAndToursPage());
        }

    }
}
