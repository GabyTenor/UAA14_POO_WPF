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

namespace ACT_8_Banque
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public Personne[] proprietaires = new Personne[3]
        {
            new Personne("Leemans", "Nathan", "nathan.leemans@gmail.com", 0467121030, "3 Rue Random, JeSaisPas", 1234, 589195, 1),
            new Personne("Tarnus", "Gabriel", "gabtardorval@gmail.com", 0467129115, "15 Orval", 6823, 196045, 2),
            new Personne("Baudson", "Béatrice", "baudb@site.asty-moulin.be", 0467194581, "1 Boulevard AuPif, NullePart", 6000, 690175, 3)
        };

        public CompteCourant[] comptesCourant;
        public CompteEpargne[] comptesEpargne;



        public MainWindow()
        {
            InitializeComponent();
            contenu.Content = new Connexion();
            connexion.Click += new RoutedEventHandler(Connexion);

            comptesCourant = new CompteCourant[3]
            {
                new CompteCourant(-500, 5000, "BE50 3910 8601 6587", proprietaires[0]),
                new CompteCourant(-500, 10000, "BE50 5923 3914 2105", proprietaires[1]),
                new CompteCourant(-500, 7000, "BE50 3910 8601 6587", proprietaires[2])
            };

            comptesEpargne = new CompteEpargne[3]
            {
                new CompteEpargne(1.05F, 5000, "BE50 1995 0693 0569", proprietaires[0]),
                new CompteEpargne(1.10F, 5000, "BE50 1995 0693 0569", proprietaires[1]),
                new CompteEpargne(1.07F, 5000, "BE50 1995 0693 0569", proprietaires[2])
            };
        }

        public void Connexion(object sender, RoutedEventArgs e)
        {
            int mdp;

            if (prenomInput.Text != "" && nomInput.Text != "" && TryParse(mdpInput.Text, out mdp))
            {
                bool fail = true;
                int i = 0;

                do
                {
                    if (prenomInput.Text == proprietaires[i].Prenom && nomInput.Text == proprietaires[i].Nom && mdp == proprietaires[i].Mdp)
                    {
                        fail = false;
                        int id = proprietaires[i].Id;
                    }
                    i++;
                } while (fail && i != proprietaires.Length);

                if (!fail)
                {
                    contenu.Content = new Interface();
                }
            }
        }

        public bool TryParse(string entree, out int sortie)
        {
            if (int.TryParse(entree, out sortie))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
