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
        AnteJeu preJeu = new AnteJeu();

        Dog[] chiens = new Dog[4];
        Bet pari = new Bet();
        User[] participants = new User[3]
        {
            new User("Joe", 50),
            new User("Bob", 50),
            new User("Bill", 50)
        };

        public string miseur = "";
        public bool coche;

        public MainWindow()
        {
            InitializeComponent();
            CreerChien();

            mise.PreviewTextInput += new TextCompositionEventHandler(preJeu.PreviewMise);
            numChien.PreviewTextInput += new TextCompositionEventHandler(preJeu.PreviewNumChien);

            parie.Click += new RoutedEventHandler(MettrePari);
            demarrer.Click += new RoutedEventHandler(LancerLaCourse);

            joe.Checked += new RoutedEventHandler(preJeu.Coche);
            bob.Checked += new RoutedEventHandler(preJeu.Coche);
            bill.Checked += new RoutedEventHandler(preJeu.Coche);
           
        }
        public void CreerChien()
        {
            for (int i = 0; i < chiens.Length; i++)
            {
                chiens[i] = new Dog(i + 1, new int[2] { 40, 70 * i });
            }
        }
 
        public void MettrePari(object sender, RoutedEventArgs e)
        {
            int miseEcus;
            int numChienMise;
            bool done = false;

            mise.Background = Brushes.White;
            numChien.Background = Brushes.White;
            informations.Text = "";

            if (int.TryParse(mise.Text, out miseEcus) && int.TryParse(numChien.Text, out numChienMise) && coche)
            {
                informations.Text = "Mise validée!";

                switch (miseur)
                {
                    case "Joe":
                        if (participants[0].PlaceTheBet(miseEcus))
                        {
                            done = true;
                        }

                        break;

                    case "Bob":
                        if (participants[1].PlaceTheBet(miseEcus))
                        {
                            done = true;
                        }

                        break;

                    case "Bill":
                        if (participants[2].PlaceTheBet(miseEcus))
                        {
                            done = true;
                        }
                        break;
                }
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
    }
}
