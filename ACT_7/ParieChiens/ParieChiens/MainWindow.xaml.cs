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
        Dog chien1 = new Dog(1, new int[2] { 0, 0});
        Dog chien2 = new Dog(2, new int[2] { 0, 0 });
        Dog chien3 = new Dog(3, new int[2] { 0, 0 });
        Dog chien4 = new Dog(4, new int[2] { 0, 0 });

        public MainWindow()
        {
            InitializeComponent();
            mise.PreviewTextInput += new TextCompositionEventHandler(PreviewMise);
            numChien.PreviewTextInput += new TextCompositionEventHandler(PreviewNumChien);

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
                if(((TextBox)sender).Text.Length > 0)
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

        public void PlacerChien()
        {
            Image monImage = new Image();
            monImage.Source = chien1.ImageChien;
            monImage.Stretch = System.Windows.Media.Stretch.None;


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
