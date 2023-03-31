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
        Image _imageChien;
        private int[] _positionCourante = new int[2];
        private bool _gagne;
         
        public Dog(int numChien, int[] positionCourante)
        {
            this._longueurPiste = 1500;
            
            this._numChien = numChien;

            this._positionCourante = positionCourante;
           

            
        }

        public void GenererImage() {
            BitmapImage img = new BitmapImage();
            img.BeginInit();
            img.UriSource = new Uri("/Resources/dog.png", UriKind.Relative);
            img.EndInit();

            MainWindow plateau = (MainWindow)System.Windows.Application.Current.MainWindow;

            Image monImage = new Image();
            monImage.Source = img;
            monImage.Stretch = Stretch.None;

            _imageChien = monImage;

        }

        public BitmapImage ImageChien
        {
            get { return _imageChien; }
            set { _imageChien = value; }
        }

        public int[] PositionCourante
        {
            get { return _positionCourante; }
            set { _positionCourante = value; }
        }


    }
}
