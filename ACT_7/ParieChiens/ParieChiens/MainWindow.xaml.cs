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
using System.Windows.Threading;
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
        DispatcherTimer timer = new DispatcherTimer();
        public MainWindow()
        {
            InitializeComponent();
            CreerChien();

            mise.PreviewTextInput += new TextCompositionEventHandler(preJeu.PreviewMise);
            numChien.PreviewTextInput += new TextCompositionEventHandler(preJeu.PreviewNumChien);

            parie.Click += new RoutedEventHandler(MettrePari);
            demarrer.Click += new RoutedEventHandler(LancerLaCourse);

            joel.Checked += new RoutedEventHandler(preJeu.Coche);
            bob.Checked += new RoutedEventHandler(preJeu.Coche);
            bill.Checked += new RoutedEventHandler(preJeu.Coche);
      
            timer.Interval = TimeSpan.FromSeconds(.05);
            timer.Tick += new EventHandler(Timer_Tick);
        }
        public void CreerChien()
        {
            for (int i = 0; i < chiens.Length; i++)
            {
                chiens[i] = new Dog(i + 1, new int[2] { 40, 75 * i });
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
                if(miseEcus > 4)
                {
                    informations.Text = "Mise validée!";

                    switch (miseur)
                    {
                        case "Joe":
                            if (!participants[0].PlaceTheBet(miseEcus))
                            {
                                joel.Content = "Joel possède " + participants[0].Money + " écus";
                                joelInfo.Text = "Joel a parié " + miseEcus + " écus sur le chien " + numChienMise;
                                participants[0].HasBetted = true;
                            }
                            else
                            {
                                informations.Text = "Joel a déjà parié";
                            }

                            break;

                        case "Bob":
                            if (!participants[1].PlaceTheBet(miseEcus))
                            {
                                bob.Content = "Bob possède " + participants[1].Money + " écus";
                                bobInfo.Text = "Bob a parié " + miseEcus + " écus sur le chien " + numChienMise;
                                participants[1].HasBetted = true;
                            }
                            else
                            {
                                informations.Text = "Bob a déjà parié";
                            }

                            break;

                        case "Bill":
                            if (!participants[2].PlaceTheBet(miseEcus))
                            {
                                bill.Content = "Bill possède " + participants[2].Money + " écus";
                                billInfo.Text = "Bill a parié " + miseEcus + " écus sur le chien " + numChienMise;
                                participants[2].HasBetted = true;
                            }
                            else
                            {
                                informations.Text = "Bill a déjà parié";
                            }
                            break;
                    }
                }
                else
                {
                    informations.Text = "Il vous faut poser un minimum de 5 écus pour jouer";
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
            bool launchable = true;
            for (int i = 0; i < participants.Length; i++)
            {
                if (!participants[i].HasBetted)
                {
                    launchable = false;
                    informations.Text = "Il faut que tous les joueurs aient parié!";
                }
            }

            if (launchable)
            {
                timer.Start();
                demarrer.IsEnabled = false;
            }
        }

        public void Timer_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < chiens.Length; i++)
            {
                chiens[i].Court();
                if (chiens[i].Gagne)
                {
                    timer.Stop();
                    informations.Text = "Fini_ Bravo au chien numéro " + (i + 1) + " qui a gagné!";
                }
            }

        }
    }
}
