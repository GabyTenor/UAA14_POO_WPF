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

namespace ACT_8_Guichet_Bancaire
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public Personne[] proprietaires = new Personne[3]
        {
            new Personne("Leemans", "Nathan", "nathan.leemans@gmail.com", 0467121030, "3 Rue Random, JeSaisPas", 1234, 589195),
            new Personne("Tarnus", "Gabriel", "gabtardorval@gmail.com", 0467129115, "15 Orval", 6823, 196045),
            new Personne("Baudson", "Béatrice", "baudb@site.asty-moulin.be", 0467194581, "1 Boulevard AuPif, NullePart", 6000, 690175)
        };
        public MainWindow()
        {
            InitializeComponent();
            connexion.Click += new RoutedEventHandler(Connexion);
        }

        public void Connexion(object sender, RoutedEventArgs e)
        {
            int mdp;

            if(prenomInput.Text != "" && nomInput.Text != "" && TryParse(mdpInput.Text, out mdp))
            {
                bool fail = true;
                int i = 0;
                
                do
                {
                    if(prenomInput.Text == proprietaires[i].Prenom && nomInput.Text == proprietaires[i].Nom && mdp == proprietaires[i].Mdp)
                    {
                        fail = false;
                    }
                    i++;
                } while (fail && i != proprietaires.Length);

                if (!fail)
                {
                    Menu menu = new Menu();
                    menu.Show();
                    
                    MainWindow connexion = new MainWindow();
                    connexion.Close();
                }
            }
        }

        public bool TryParse(string entree, out int sortie)
        {
            if(int.TryParse(entree, out sortie))
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
