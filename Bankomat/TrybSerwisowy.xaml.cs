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

namespace Bankomat
{
    /// <summary>
    /// Logika interakcji dla klasy Window3.xaml
    /// </summary>
    public partial class Window3 : Window
    {
        public Window3()
        {
            InitializeComponent();
            StanyBankomatu();
            IlośćNominałów();
        }

        private void PowrótDoMenuZ_TrybSerwisowy_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
        }

        void StanyBankomatu()
        {

            if (ZbiornikiNominałów.NOM10 == 0 && ZbiornikiNominałów.NOM20 == 0 && ZbiornikiNominałów.NOM50 == 0 && ZbiornikiNominałów.NOM100 == 0 && ZbiornikiNominałów.NOM200 == 0)
            {
                TextBlock_StanDziałania.Text = "Stan: Pusty";
                TextBlock_StanDziałania.Foreground = new SolidColorBrush(Colors.Red);
            }
            else
            {
                TextBlock_StanDziałania.Text = "Stan: Gotowy do działania";
                TextBlock_StanDziałania.Foreground = new SolidColorBrush(Colors.Green);
            }
        }

        void IlośćNominałów()
        {

            TextBlock_nom10szt.Text = ZbiornikiNominałów.NOM10.ToString();
            TextBlock_nom20szt.Text = ZbiornikiNominałów.NOM20.ToString();
            TextBlock_nom50szt.Text = ZbiornikiNominałów.NOM50.ToString();
            TextBlock_nom100szt.Text = ZbiornikiNominałów.NOM100.ToString();
            TextBlock_nom200szt.Text = ZbiornikiNominałów.NOM200.ToString();
        }
    }
}
