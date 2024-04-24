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
    /// Логика взаимодействия для TypePage.xaml
    /// </summary>
    public partial class TypePage : Page
    {
        public TypePage()
        {
            InitializeComponent();
            dgTypes.ItemsSource = MainWindow.baza.Type.ToList();
        }

        private void Type_Delete(object sender, RoutedEventArgs e)
        {
            
        }

        private void Type_Edit(object sender, RoutedEventArgs e)
        {
            var editButton = sender as Button;
            var selectedType = editButton.DataContext as Type;
            Windows.TypeEditWin win = new Windows.TypeEditWin(selectedType);
            win.ShowDialog();
        }

        private void Type_Add(object sender, RoutedEventArgs e)
        {

        }
    }
}
