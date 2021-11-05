using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Bankomat
{
    /// <summary>
    /// Logika interakcji dla klasy TrybUżytkownika.xaml
    /// </summary>
    public partial class TrybUżytkownika : Window
    {
		public TrybUżytkownika()
        {
            InitializeComponent();
            StanyBankomatu();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string kwota = TextBox_kwoty.Text.ToString();
			int liczba = int.Parse(kwota);

			if (IsAllDigits(kwota) == true)
            {
                if (liczba%10 == 0)
                {
                    if (liczba < 0)
                    {
                        MessageBox.Show("Kwota nie może być ujemna. Wpisz ponownie kwotę.");
                    }
                    else
                    {
                        if (liczba <= ZbiornikiNominałów.NOM10X + ZbiornikiNominałów.NOM20X + ZbiornikiNominałów.NOM50X + ZbiornikiNominałów.NOM100X + ZbiornikiNominałów.NOM200X)
                        {
							if (ZbiornikiNominałów.NOM200 > 0)
							{
								if (ZbiornikiNominałów.NOM200 - (liczba / 200) < 0)
								{

									while (ZbiornikiNominałów.NOM200 > 0)
									{
                                        ZbiornikiNominałów.NOM200X = ZbiornikiNominałów.NOM200X - 200;
										ZbiornikiNominałów.NOM200--;
                                        liczba = liczba - 200;
                                    }
								}
								else
								{
									int liczbaNom200 = liczba / 200;
									liczba -= (liczbaNom200 * 200);
									ZbiornikiNominałów.NOM200 -= liczbaNom200;
                                    ZbiornikiNominałów.NOM200X -= liczbaNom200 * 200;
                                }
							}

							if (ZbiornikiNominałów.NOM100 > 0)
							{
								if (ZbiornikiNominałów.NOM100 - (liczba / 100) < 0)
								{

									while (ZbiornikiNominałów.NOM100 > 0)
									{
										ZbiornikiNominałów.NOM100--;
                                        ZbiornikiNominałów.NOM100X = ZbiornikiNominałów.NOM100X - 100;
                                        liczba = liczba - 100;
                                    }
								}
								else
								{
									int liczbaNom100 = liczba / 100;
									liczba -= (liczbaNom100 * 100);
									ZbiornikiNominałów.NOM100 -= liczbaNom100;
                                    ZbiornikiNominałów.NOM100X -= liczbaNom100 * 100;
                                }
							}
							if (ZbiornikiNominałów.NOM50 > 0)
							{
								if (ZbiornikiNominałów.NOM50 - (liczba/50) < 0)
								{

									while (ZbiornikiNominałów.NOM50 > 0)
									{
										ZbiornikiNominałów.NOM50--;
                                        ZbiornikiNominałów.NOM50X = ZbiornikiNominałów.NOM50X - 50;
                                        liczba = liczba - 50;
                                    }
								}
								else
								{
									int liczbaNom50 = liczba / 50;
									liczba -= (liczbaNom50 * 50);
									ZbiornikiNominałów.NOM50 -= liczbaNom50;
                                    ZbiornikiNominałów.NOM50X -= liczbaNom50 * 50;
                                }
							}
							if (ZbiornikiNominałów.NOM20 > 0)
							{
								if (ZbiornikiNominałów.NOM20 - (liczba/20) < 0)
								{

									while (ZbiornikiNominałów.NOM20 > 0)
									{
										ZbiornikiNominałów.NOM20--;
                                        ZbiornikiNominałów.NOM20X = ZbiornikiNominałów.NOM20X - 20;
                                        liczba = liczba - 20;
                                    }
								}
								else
								{
									int liczbaNom20 = liczba / 20;
									liczba -= (liczbaNom20 * 20);
									ZbiornikiNominałów.NOM20 -= liczbaNom20;
                                    ZbiornikiNominałów.NOM20X -= liczbaNom20 * 20;
                                }
							}
							if (ZbiornikiNominałów.NOM10 > 0)
							{
								if (ZbiornikiNominałów.NOM10 - (liczba/10) < 0)
								{

									while (ZbiornikiNominałów.NOM10 > 0)
									{
										liczba = liczba - 10;
										ZbiornikiNominałów.NOM10--;
                                        ZbiornikiNominałów.NOM20X = ZbiornikiNominałów.NOM20X - 10;
                                    }
								}
								else
								{
									int liczbaNom10 = liczba / 10;
									liczba -= (liczbaNom10 * 10);
									ZbiornikiNominałów.NOM10 -= liczbaNom10;
                                    ZbiornikiNominałów.NOM10X -= liczbaNom10 * 10;
                                }
							}
							MessageBox.Show("Pieniądze zostały poprawnie wypłacone. Dziękujemy za skorzystanie z naszych usług.");
						}
                        else
                        {
                            MessageBox.Show("W bankomacie nie ma wystarczających funduszy do wypłacenia podanej kwoty! Wpisz ponownie mniejszą kwotę.");
                        }
                    }

                }
                else
                {
                    MessageBox.Show("W puli nominałów do wydania są tylko nominały 10zł, 20 zł, 50 zł, 100zł i 200zł! Podaj ponownie kwotę z zerem na końcu.");
                }
            }
            else
            {
                MessageBox.Show("Podana kwota musi się składać z samych cyfer! Wpisz ponownie kwotę.");
            }
        }

        private void PowrótDoMenuZ_TrybUżytkownika_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
        }

        bool IsAllDigits(string s)
        {
            foreach (char c in s)
            {
                if (!char.IsDigit(c))
                    return false;
            }
            return true;
        }

        void StanyBankomatu()
		{ 

			if ( ZbiornikiNominałów.NOM10 == 0 && ZbiornikiNominałów.NOM20 == 0 && ZbiornikiNominałów.NOM50 == 0 && ZbiornikiNominałów.NOM100 == 0 && ZbiornikiNominałów.NOM200 == 0)
            {
                TextBlock_StanDziałania.Text = "Stan: Pusty";
                TextBlock_StanDziałania.Foreground = new SolidColorBrush(Colors.Red);
            }
            else if (ZbiornikiNominałów.NOM10 == 0 || ZbiornikiNominałów.NOM20 == 0 || ZbiornikiNominałów.NOM50 == 0 || ZbiornikiNominałów.NOM100 == 0 || ZbiornikiNominałów.NOM200 == 0)
            {
                TextBlock_StanDziałania.Text = "Stan: Działający";
                TextBlock_StanDziałania.Foreground = new SolidColorBrush(Colors.Yellow);
            }
            else
            {
                TextBlock_StanDziałania.Text = "Stan: Gotowy do działania";
                TextBlock_StanDziałania.Foreground = new SolidColorBrush(Colors.Green); 
            }
        }
    }
}
