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

namespace ExSimplifieSerpent
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public Button[,] buttons = new Button[10, 10];
        Plateau lancerPlateau = new Plateau();

        int[] posij1 = new int[2] { 0, 0 };
        Joueur joueur1 = new Joueur(0, 0, posij1 , "X");
        public MainWindow()
        {
            Grid plate = new Grid();
            InitializeComponent();
            lancerPlateau.SetUpGame(buttons, plate);

            play.Click += new RoutedEventHandler(Jouer);
        }
        public void Jouer(object sender, RoutedEventArgs e)
        {            
            TourJoueur();
        }
    }
}
