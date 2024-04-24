using System;
using System.Collections.Generic;
using System.Drawing;
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
using Excel = Microsoft.Office.Interop.Excel;
using word = Microsoft.Office.Interop.Word;

namespace Первый_проект_за_год_xddddddd.Pages
{
    /// <summary>
    /// Логика взаимодействия для ToursPage.xaml
    /// </summary>
    public partial class ToursPage : Page
    {
        IEnumerable<Tour> listForExcel = MainWindow.baza.Tour.ToList();

        public ToursPage()
        {
            InitializeComponent();
            lw1.ItemsSource = MainWindow.baza.Tour.ToList();
            List<string> x = new List<string>();
            x.Add("Все туры");

            var y = MainWindow.baza.Type.ToList();

            foreach (var item in y)
            {
                x.Add(item.Name);
            }
            CBType.ItemsSource = x;
            CBType.SelectedItem = x[0];
            Refresh();
            
        }

        private void Hotel_Edit(object sender, RoutedEventArgs e)
        {
            var editButton = sender as Button;
            var selectedTour = editButton.DataContext as Tour;
            Windows.ToursEditWin tourEdit = new Windows.ToursEditWin(selectedTour);
            tourEdit.ShowDialog();
        }

        private void Hotel_Delete(object sender, RoutedEventArgs e)
        {

        }

        private void Hotel_Add(object sender, RoutedEventArgs e)
        {
            Hotel hotel = new Hotel();
            hotel.Id = 0;
            Windows.HotelEditWin add = new Windows.HotelEditWin(hotel);
            add.ShowDialog();
            lw1.ItemsSource = null;
            lw1.ItemsSource = MainWindow.baza.Hotel.ToList();
        }

        private void CBTypeSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var selectedType = CBType.SelectedItem as string;
            if (selectedType != "Все туры")
            {
               listForExcel = Enumerable.Where(MainWindow.baza.Tour.ToList(), n => n.Type.Any(t => t.Name == selectedType));
            }
            else
            {
                listForExcel = MainWindow.baza.Tour.ToList();
            }
            lw1.ItemsSource = listForExcel;
        }

        private void searchTextChanged(object sender, TextChangedEventArgs e)
        {
            var x = MainWindow.baza.Tour.ToList();
            string seachText = tbSearchText.Text;
            if (!string.IsNullOrWhiteSpace(seachText))
            {
                x = x.Where(p => p.Name.ToLower().StartsWith(seachText.ToLower())).ToList();
            }
            lw1.ItemsSource = x;
        }
        private int _currentPage = 1;
        private int _countTours = 10;
        private int _maxPages;

        private void Refresh()
        {
            var listTours = MainWindow.baza.Tour.ToList();
            _maxPages = (int)Math.Ceiling(listTours.Count * 1.0 / _countTours);

            var listHotelPage = listTours.Skip((_currentPage - 1) * _countTours).Take(_countTours).ToList();

            TxtCurrentPage.Text = _currentPage.ToString();
            LblTotalPages.Content = "of " + _maxPages;

            LblInfo.Content = $"Всего {listTours.Count} записи, по {_countTours} записей на одной странице";

            lw1.ItemsSource = listHotelPage;
        }

        private void GoToFirstPage(object sender, RoutedEventArgs e)
        {
            _currentPage = 1;
            Refresh();

        }

        private void GoToPreviousPage(object sender, RoutedEventArgs e)
        {
            if (_currentPage <= 1) _currentPage = 1;
            else
                _currentPage--;
            Refresh();
        }

        private void GoToNextPage(object sender, RoutedEventArgs e)
        {
            if (_currentPage >= _maxPages) _currentPage = _maxPages;
            else
                _currentPage++;
            Refresh();
        }

        private void GoToLastPage(object sender, RoutedEventArgs e)
        {
            _currentPage = _maxPages;
            Refresh();
        }

        private void ToursExcel_Click(object sender, RoutedEventArgs e)
        {
            Excel.Application excelApp = new Excel.Application();
            Excel.Workbook workbook;
            workbook = excelApp.Workbooks.Add();
            Excel.Worksheet worksheet = (Excel.Worksheet)workbook.Worksheets[1];
            excelApp.Visible = true;
            excelApp.UserControl = true;

            worksheet.Cells[1, 1] = "Наименование";
            worksheet.Cells[1, 2] = "Описание";
            worksheet.Cells[1, 3] = "Стоимость";
            worksheet.Cells[1, 4] = "Кол-во билетов";
            worksheet.Cells[2, 1] = CBType.SelectedItem.ToString() + ":";
            Excel.Range rng= worksheet.Range["A2:D2"];
            rng.Merge();
            rng.Interior.Color = Excel.XlRgbColor.rgbBisque;
            rng.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
            var list = listForExcel.ToList();

            for (int i = 0; i < list.Count; i++)
            {
                worksheet.Cells[i + 3, 1] = list[i].Name;
                worksheet.Cells[i + 3, 2] = list[i].Description;
                worksheet.Cells[i + 3, 3] = list[i].Price;
                worksheet.Cells[i + 3, 4] = list[i].TicketCount;
            }

            Excel.Range rangeAllTable = worksheet.Range["A1:D" + (list.Count + 2).ToString()];
            Excel.Range rangeHeader = worksheet.Range["A1:D1"];
            ;
            rangeAllTable.EntireColumn.AutoFit();
            rangeAllTable.Borders.Color = ColorTranslator.ToOle(System.Drawing.Color.Black);
            rangeHeader.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
            rangeHeader.Interior.Color = ColorTranslator.ToOle(System.Drawing.Color.Yellow);

        }

        private void ToursByTypesExcel_Click(object sender, RoutedEventArgs e)
        {
            Excel.Application excelApp = new Excel.Application();
            Excel.Workbook workbook;
            workbook = excelApp.Workbooks.Add();
            Excel.Worksheet worksheet = (Excel.Worksheet)workbook.Worksheets[1];
            excelApp.Visible = true;
            excelApp.UserControl = true;

            worksheet.Cells[1, 1] = "Наименование";
            worksheet.Cells[1, 2] = "Описание";
            worksheet.Cells[1, 3] = "Стоимость";
            worksheet.Cells[1, 4] = "Кол-во билетов";
            Excel.Range rangeTypeName = worksheet.Range["A2:D2"];
            rangeTypeName.Merge();
            int index = 1;
            var baza = MainWindow.baza.Type.ToList();
            var list = baza[0].Tour.ToList();

            for (int j = 0; j < baza.Count; j++)
            {
                index++;
                worksheet.Cells[index, 1] = baza[j].Name;
                rangeTypeName = worksheet.Range["A" + index + ":" + "D" + index];
                rangeTypeName.Interior.Color = Excel.XlRgbColor.rgbBisque;
                rangeTypeName.Merge();
                rangeTypeName.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                list = baza[j].Tour.ToList();

                for (int i = 0; i < list.Count; i++)
                {
                    index++;
                    worksheet.Cells[index, 1] = list[i].Name;
                    worksheet.Cells[index, 2] = list[i].Description;
                    worksheet.Cells[index, 3] = list[i].Price;
                    worksheet.Cells[index, 4] = list[i].TicketCount;
                }
            }
            

            Excel.Range rangeAllTable = worksheet.Range["A1:D" + index];
            Excel.Range rangeHeader = worksheet.Range["A1:D1"];
            rangeAllTable.EntireColumn.AutoFit();
            rangeAllTable.Borders.Color = ColorTranslator.ToOle(System.Drawing.Color.Black);
            rangeHeader.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
            rangeHeader.Interior.Color = ColorTranslator.ToOle(System.Drawing.Color.Yellow);
        }

        private void ToursWord_Click(object sender, RoutedEventArgs e)
        {
            word.Application app = new word.Application();
            word.Document doc = new word.Document();
            doc.PageSetup.Orientation = word.WdOrientation.wdOrientLandscape;
            doc.PageSetup.LeftMargin = app.CentimetersToPoints(1f);
            word.Paragraph p1 = doc.Paragraphs[1];
            p1.Range.Text = "Таблица \"Знакомые\"";
            p1.Range.Bold = 1;
            p1.Alignment = word.WdParagraphAlignment.wdAlignParagraphCenter;
            p1.Range.Font.Size = 16f;
            p1.Range.Font.Color = word.WdColor.wdColorDarkRed;
            doc.Paragraphs.Add();
            doc.Paragraphs[2].Range.Text = "Дата: " + DateTime.Today.ToLongDateString();
            doc.Paragraphs[2].Alignment = word.WdParagraphAlignment.wdAlignParagraphLeft;
            doc.Paragraphs[2].Range.Font.Color = word.WdColor.wdColorBlack;
            doc.Paragraphs[2].Range.Bold = 0;
            doc.Paragraphs[2].Range.Font.Size = 12f;

            var allTypes = MainWindow.baza.Type.ToList();
            

            foreach(Type t in allTypes)
            {
                var allTours = t.Tour.ToList();
                word.Paragraph tourParagraph = doc.Paragraphs.Add();
                word.Range tourRange = tourParagraph.Range;
                tourRange.Text = "\n" + t.Name;
                tourRange.InsertParagraphAfter();
            
            word.Paragraph tableParagraph = doc.Paragraphs.Add();
            word.Range tableRange = tableParagraph.Range;
            word.Table toursTable = doc.Tables.Add(tableRange, allTours.Count + 1, 4);
            toursTable.Borders.InsideLineStyle = toursTable.Borders.OutsideLineStyle = word.WdLineStyle.wdLineStyleSingle;
            toursTable.Range.Cells.VerticalAlignment = word.WdCellVerticalAlignment.wdCellAlignVerticalCenter;
            word.Range cellRange;
            cellRange = toursTable.Cell(1, 1).Range;
            cellRange.Text = "Наименование";
            cellRange = toursTable.Cell(1, 2).Range;
            cellRange.Text = "Цена";
            cellRange = toursTable.Cell(1, 3).Range;
            cellRange.Text = "Кол-во билетов";
            cellRange = toursTable.Cell(1, 4).Range;
            cellRange.Text = "Картинка";

            toursTable.Rows[1].Range.Bold = 1;
            toursTable.Rows[1].Range.ParagraphFormat.Alignment = word.WdParagraphAlignment.wdAlignParagraphCenter;

            for (int i = 0; i < allTours.Count; i++)
            {
                var currentTour = allTours[i];
                cellRange = toursTable.Cell(i + 2, 1).Range;
                cellRange.Text = currentTour.Name;

                cellRange = toursTable.Cell(i + 2, 2).Range;
                cellRange.Text = currentTour.Price.ToString();

                cellRange = toursTable.Cell(i + 2, 3).Range;
                cellRange.Text = currentTour.TicketCount.ToString();

                cellRange = toursTable.Cell(i + 2, 4).Range;
                word.InlineShape imageShape = cellRange.InlineShapes.AddPicture(AppDomain.CurrentDomain.BaseDirectory +"..\\..\\" + currentTour.ImagePath);
                imageShape.Width = imageShape.Height = 40;
                cellRange.ParagraphFormat.Alignment = word.WdParagraphAlignment.wdAlignParagraphCenter;
            }
            }
            app.Visible = true;
        }

        
    }
}
