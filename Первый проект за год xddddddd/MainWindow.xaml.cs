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

namespace Первый_проект_за_год_xddddddd
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static ToursBaseEntities baza = new ToursBaseEntities();

        public MainWindow()
        {
            InitializeComponent();
            frame1.NavigationService.Navigate(new Pages.MenuPage());
        }
    }
}
