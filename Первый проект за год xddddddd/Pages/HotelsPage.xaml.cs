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
using word = Microsoft.Office.Interop.Word;
namespace Первый_проект_за_год_xddddddd.Pages
{
    /// <summary>
    /// Логика взаимодействия для HotelsPage.xaml
    /// </summary>
    public partial class HotelsPage : Page
    {
        public HotelsPage()
        {
            InitializeComponent();
            dgHotels.ItemsSource = MainWindow.baza.Hotel.ToList();
            CBType2.ItemsSource = MainWindow.baza.Country.ToList();
            /*dgHotels.ItemsSource = Enumerable.Where(MainWindow.baza.Hotel.ToList(), n => n.Name.Length <= 10);*/
            
        }

        private void Hotel_Edit(object sender, RoutedEventArgs e)
        {
            var editButton = sender as Button;
            var selectedHotel = editButton.DataContext as Hotel;
            Windows.HotelEditWin win = new Windows.HotelEditWin(selectedHotel);
            win.ShowDialog();
        }

        private void Hotel_Delete(object sender, RoutedEventArgs e)
        {

        }

        private void Hotel_Add(object sender, RoutedEventArgs e)
        {

        }


        List<Hotel> listCountryHotel;
        private void CBTypeSelectionChanged2(object sender, SelectionChangedEventArgs e)
        {
            Country selectedCountry = CBType2.SelectedItem as Country;
            listCountryHotel = MainWindow.baza.Hotel.ToList();
            listCountryHotel = listCountryHotel.Where(p => p.Country.Code == selectedCountry.Code).ToList();
            dgHotels.ItemsSource = listCountryHotel;
        }

        word.Application app = new word.Application();
        private void hotels_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            word.Document doc = app.Documents.Open(@"D:\Ну типа\3 курс\Лапухина\МДК 01.02 - поддержка и тестирование программных модулей\Первый проект за год xddddddd\bin\Debug\Договор2.docx");
            var hotel = dgHotels.SelectedItem as Hotel;
            FindAndReplace(@"Отчет", "Отчет № " + hotel.Id.ToString());
            FindAndReplace(@"Название отеля", "Название отеля:" + hotel.Name);
            FindAndReplace(@"Количество звезд", "Количество звезд: " + hotel.CountOfStars.ToString());
            FindAndReplace(@"Количество туров", "Количество туров: " + hotel.Tour.Count.ToString());
            FindAndReplace(@"Страна", "Страна: " + hotel.Country.Name);
            app.Visible = true;
        }
        private void FindAndReplace(string f, string r)
        {
            app.Selection.Find.ClearFormatting();
            word.Range range = app.Selection.Range;
            app.Selection.Find.Replacement.ClearFormatting();
            app.Selection.Find.Replacement.Text = r;
            app.Selection.Find.Execute(f, Replace: word.WdReplace.wdReplaceAll);

            app.Selection.WholeStory();
            app.Options.DefaultHighlightColorIndex = word.WdColorIndex.wdNoHighlight;
            app.Selection.Range.HighlightColorIndex = word.WdColorIndex.wdWhite;
        }
    }
}
