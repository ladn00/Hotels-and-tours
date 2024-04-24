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
    /// Логика взаимодействия для HotelsAndToursPage.xaml
    /// </summary>
    public partial class HotelsAndToursPage : Page
    {

        public HotelsAndToursPage()
        {
            InitializeComponent();
            dgHotels.ItemsSource = MainWindow.baza.Hotel.ToList();
            lw1.ItemsSource = MainWindow.baza.Tour.ToList();
        }

        private void Hotels_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var selectedHotel = dgHotels.SelectedItem as Hotel;
            var toursInHotel = selectedHotel.Tour;
            lw1.ItemsSource = toursInHotel;
            int actualCount = 0;
            foreach(Tour t in toursInHotel)
            {
                if (t.IsActual) actualCount++;
            }
            CountOfTours.Content = $"Кол-во туров в отеле {selectedHotel.Name}: {toursInHotel.Count}. \nИз них {actualCount} актуальных";
        }

        private void Hotel_Edit(object sender, RoutedEventArgs e)
        {

        }

        private void Hotel_Delete(object sender, RoutedEventArgs e)
        {

        }

        private void lwTours_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var selectedTour = lw1.SelectedItem as Tour;
            var toursInHotel = selectedTour.Hotel;
            dgHotels.ItemsSource = toursInHotel;
            int count45 = 0, count23 = 0;
            foreach(Hotel h in toursInHotel)
            {
                if (h.CountOfStars == 4 || h.CountOfStars == 5)
                    count45++;
                else
                    count23++;
            }
            CountOfTours.Content = $"Кол-во отелей в туре: {toursInHotel.Count}.\nИз них 2-3 звездочных: {count23}\nи 4-5 звездочных: {count45}";
        }
    }
}
