using System;
using System.Collections.Generic;
using System.Text;
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

        public Dog(int numChien)
        {
            this._longueurPiste = 1500;
            
            this._numChien = numChien;
            
            this._imageChien.EndInit();
            this._imageChien.BeginInit();
            this._imageChien.UriSource = new Uri("/dog.png", UriKind.Relative);
        }
    }
}
