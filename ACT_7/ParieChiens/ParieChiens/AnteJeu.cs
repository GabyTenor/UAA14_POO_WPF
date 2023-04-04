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

namespace ParieChiens
{
    public struct AnteJeu
    {
        public void PreviewMise(object sender, TextCompositionEventArgs e)
        {
            if (!EstEntier(e.Text))
            {
                e.Handled = true;
            }
            else
            {
                if (((TextBox)sender).Text.Length > 2)
                {
                    e.Handled = true;
                }
            }

        }

        public void PreviewNumChien(object sender, TextCompositionEventArgs e)
        {
            if (!EstEntier(e.Text))
            {
                e.Handled = true;
            }
            else
            {
                int numChien;
                int.TryParse(e.Text, out numChien);

                if (((TextBox)sender).Text.Length > 0)
                {
                    e.Handled = true;
                }
                if (numChien > 4 || numChien < 1)
                {
                    e.Handled = true;
                }
            }
        }

        public void Coche(object sender, RoutedEventArgs e)
        {
            MainWindow fenetre = (ParieChiens.MainWindow)App.Current.MainWindow;

            fenetre.coche = false;

            if (fenetre.joe.IsChecked == true)
            {
                fenetre.miseur = "Joe";
                fenetre.coche = true;
            }
            else if (fenetre.bob.IsChecked == true)
            {
                fenetre.miseur = "Bob";
                fenetre.coche = true;
            }
            else if (fenetre.bill.IsChecked == true)
            {
                fenetre.miseur = "Bill";
                fenetre.coche = true;
            }

            fenetre.personneCochee.Text = fenetre.miseur;
        }
        private bool EstEntier(string text)
        {
            bool isInt;

            int entier;

            if (int.TryParse(text, out entier))
            {
                isInt = true;
            }
            else
            {
                isInt = false;
            }

            return isInt;
        }

    }
}
