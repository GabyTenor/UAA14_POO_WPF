using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;


namespace ParieChiens
{
    class Dog
    {
        private int _longueurPiste;
        private int _numChien;
        BitmapImage _imageChien = new BitmapImage();
        int[] _positionCourante = new int[2];
        bool _gagne;
         
        public Dog(int numChien, int[] positionCourante)
        {
            this._longueurPiste = 1500;
            
            this._numChien = numChien;

            this._positionCourante = positionCourante;
            
            this._imageChien.BeginInit();
            this._imageChien.UriSource = new Uri("/dog.png", UriKind.Relative);
            this._imageChien.EndInit();

            MainWindow plateau = (ParieChiens.MainWindow)App.Current.MainWindow;

            Image monImage = new Image();
            monImage.Source = _imageChien;
            monImage.Stretch = System.Windows.Media.Stretch.None;

            Canvas.SetLeft(monImage, _positionCourante[0]);
            Canvas.SetTop(monImage, _positionCourante[1]);
            plateau.circuit.Children.Add(monImage);

        }

        public BitmapImage ImageChien
        {
            get { return _imageChien; }
            set { _imageChien = value; }
        }

    }
}
