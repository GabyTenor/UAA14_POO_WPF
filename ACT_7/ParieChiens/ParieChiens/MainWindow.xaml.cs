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
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Dog[] chien = new Dog[4]
        {
            new Dog(1, new int[2] {0, 0}),
            new Dog(2, new int[2] {0, 0}),
            new Dog(3, new int[2] {0, 0}),
            new Dog(4, new int[2] {0, 0}),
        };

        string miseur;

        public MainWindow()
        {
            InitializeComponent();
            mise.PreviewTextInput += new TextCompositionEventHandler(PreviewMise);
            numChien.PreviewTextInput += new TextCompositionEventHandler(PreviewNumChien);

            parie.Click += new RoutedEventHandler(MettrePari);
            demarrer.Click += new RoutedEventHandler(LancerLaCourse);

            joe.Checked += new RoutedEventHandler(Coche);
            bob.Checked += new RoutedEventHandler(Coche);
            bill.Checked += new RoutedEventHandler(Coche);
        }
        public void PreviewMise(object sender, TextCompositionEventArgs e)
        {
            if (!EstEntier(e.Text))
            {
                e.Handled = true;
            }
            else
            {
                if(((TextBox)sender).Text.Length > 2)
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
                if (((TextBox)sender).Text.Length > 0)
                {
                    e.Handled = true;
                }
                switch (e.Text)
                {
                    case "1":

                        break;

                    case "2":

                        break;

                    case "3":

                        break;

                    case "4":

                        break;

                    default:

                        e.Handled = true;
                        break;
                }
            }
        }

        public void Coche(object sender, RoutedEventArgs e)
        {
            
        }

        

        public void MettrePari(object sender, RoutedEventArgs e)
        {
            int miseEcus;
            int numChienMise;

            if(int.TryParse(mise.Text, out miseEcus) && int.TryParse(numChien.Text, out numChienMise))
            {                
                mise.Background = Brushes.White;
                numChien.Background = Brushes.White;
            }
            else
            {
                mise.Background = Brushes.Red;
                numChien.Background = Brushes.Red;
            }
        }

        public void LancerLaCourse(object sender, RoutedEventArgs e)
        {

        }

        public void PlacerChien()
        {
            for (int i = 0; i < chien.Length; i++)
            {
                chien[i].GenererImage();
                circuit.Children.Add(chien[i]);
            }
        }

        public bool EstEntier(string text)
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
