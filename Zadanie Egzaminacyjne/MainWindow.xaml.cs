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

namespace Zadanie_Egzaminacyjne
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (imie.Text != "" || nazwisko.Text != "")
            {
                string kolor = "";

                if (niebieskie.IsChecked == true)
                {
                    kolor = "niebieskie";
                }
                else if (zielone.IsChecked == true)
                {
                    kolor = "zielone";
                }
                else if (piwne.IsChecked == true)
                {
                    kolor = "piwne";
                }

                MessageBox.Show(imie.Text + " " + nazwisko.Text + " kolor oczu " + kolor);
            }
            else
            {
                MessageBox.Show("Wprowadź dane.");
            }

        }

        private void numer_TextChanged(object sender, TextChangedEventArgs e)
        {
            if(numer.Text == "000" || numer.Text == "111" || numer.Text == "333")
            {
                zdjecie.Source = new BitmapImage(new Uri(numer.Text+"-zdjecie.jpg",UriKind.Relative));
                odcisk.Source = new BitmapImage(new Uri(numer.Text + "-odcisk.jpg",UriKind.Relative));
            }
            else
            {
                zdjecie.Source = null;
                odcisk.Source = null;
            }
        }
    }
}
