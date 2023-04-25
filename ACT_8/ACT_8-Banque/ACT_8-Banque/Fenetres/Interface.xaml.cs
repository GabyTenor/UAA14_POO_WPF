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
    /// Logique d'interaction pour Interface.xaml
    /// </summary>
    public partial class Interface : Page
    {
        public MainWindow mainWindow = (MainWindow)App.Current.MainWindow;
        public int compteChoisi;
        public string choix;
        float somme;
        public Interface()
        {
            InitializeComponent();
            courant.Checked += new RoutedEventHandler(Informations);
            epargne.Checked += new RoutedEventHandler(Informations);

            transCourant.Checked += new RoutedEventHandler(ChoixTransaction);
            transEpargne.Checked += new RoutedEventHandler(ChoixTransaction);

            montant.PreviewTextInput += new TextCompositionEventHandler(RentrerNombre);

            valider.Click += new RoutedEventHandler(Transaction);
        }

        public void Informations(object sender, RoutedEventArgs e)
        {
            if (courant.IsChecked == true)
            {
                compteChoisi = 0;
                compte.Text = mainWindow.comptesCourant[mainWindow.login].Afficher();
            }
            else if(epargne.IsChecked == true)
            {
                compteChoisi = 1;
                compte.Text = mainWindow.comptesEpargne[mainWindow.login].Afficher();
            }
        }

        public void ChoixTransaction(object sender, RoutedEventArgs e)
        {
            if (transCourant.IsChecked == true)
            {
                choix = "Virement Autre Personne";
            }
            else if (transEpargne.IsChecked == true)
            {
                choix = "Transaction Compte Epargne";
            }
        }

        public void RentrerNombre(object sender, TextCompositionEventArgs e)
        {
            if (e.Text != "," && !TryParse(e.Text))
            {
                e.Handled = true;
            }
            else if (e.Text == ",")
            {
                if (((TextBox)sender).Text.IndexOf(e.Text) > -1)
                {
                    e.Handled = true;
                }
                else
                {
                    float.TryParse(e.Text, out somme);
                }
            }
        }

        public void Transaction(object sender, RoutedEventArgs e)
        {
            if(compteChoisi == 0)
            {
                resultat.Text = mainWindow.comptesCourant[mainWindow.login].Transaction(mainWindow.comptesEpargne, mainWindow.comptesCourant, choix, somme);
            }
        }
        
        public bool TryParse(string entree)
        {
            float sortie;

            if (float.TryParse(entree, out sortie))
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
