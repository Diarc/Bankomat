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

namespace Bankomat
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void bt_trybUzytkownika_Click(object sender, RoutedEventArgs e)
        {
            Hide();
            new TrybUżytkownika().ShowDialog();
            ShowDialog();
        }

        private void tb_trybSerwisowy_Click(object sender, RoutedEventArgs e)
        {
            Hide();
            new Window3().ShowDialog();
            ShowDialog();
        }
    }
}
