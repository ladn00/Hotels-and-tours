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
    /// Логика взаимодействия для TypeEditWin.xaml
    /// </summary>
    public partial class TypeEditWin : Window
    {
        Type type;
        public TypeEditWin(Type type)
        {
            InitializeComponent();
            this.type = type;
            DataContext = type;
        }

        private void bt_SaveClick(object sender, RoutedEventArgs e)
        {

        }
    }
}
