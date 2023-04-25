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
using ACT_8_Banque.Fenetres;
using ACT_8_Banque.Objets;

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

        public int login;

        public MainWindow()
        {
            InitializeComponent();                  
            
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

            contenu.Content = new Connexion();
        }

        
    }
}
