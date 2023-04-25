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

namespace ACT_8_Banque.Fenetres
{
    /// <summary>
    /// Logique d'interaction pour Connexion.xaml
    /// </summary>
    public partial class Connexion : Page
    {
        public MainWindow mainWindow = (MainWindow)App.Current.MainWindow;

        public Connexion()
        {
            InitializeComponent();
            connexion.Click += new RoutedEventHandler(Login);
        }
        public void Login(object sender, RoutedEventArgs e)
        {
            int mdp;

            if (prenomInput.Text != "" && nomInput.Text != "" && TryParse(mdpInput.Text, out mdp))
            {
                bool fail = true;
                int i = 0;

                do
                {
                    if (prenomInput.Text == mainWindow.proprietaires[i].Prenom && nomInput.Text == mainWindow.proprietaires[i].Nom && mdp == mainWindow.proprietaires[i].Mdp)
                    {
                        fail = false;
                        int id = mainWindow.proprietaires[i].Id;
                    }
                    else
                    {
                        i++;
                    }
                    
                } while (fail && i != mainWindow.proprietaires.Length);

                if (!fail)
                {
                    mainWindow.contenu.Content = new Interface();
                    mainWindow.login = i;
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
