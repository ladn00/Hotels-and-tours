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
    /// Логика взаимодействия для CountryEditWin.xaml
    /// </summary>
    public partial class CountryEditWin : Window
    {
        Country country;
        public CountryEditWin(Country country)
        {
            InitializeComponent();
            this.country = country;
            DataContext = country;
        }

        private void bt_SaveClick(object sender, RoutedEventArgs e)
        {

        }
    }
}
