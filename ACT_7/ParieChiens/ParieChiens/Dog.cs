﻿using System;
using System.Windows.Controls;
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
            this._longueurPiste = 700;         
            this._numChien = numChien;
            this._positionCourante = positionCourante;
            GenererImage();          
        }

        public void GenererImage() 
        {
            MainWindow plateau = (ParieChiens.MainWindow)App.Current.MainWindow;

            BitmapImage imageChien = new BitmapImage();
            imageChien.BeginInit();
            imageChien.UriSource = new Uri("Resources/dog.png", UriKind.Relative);
            imageChien.EndInit();

            _imageChien = new Image();
            _imageChien.Source = imageChien;
            _imageChien.Stretch = System.Windows.Media.Stretch.None;

            Canvas.SetLeft(_imageChien, _positionCourante[0]);
            Canvas.SetTop(_imageChien, _positionCourante[1]);
            plateau.circuit.Children.Add(_imageChien);
        }

        /*public int[] PositionCourante
        {
            get { return _positionCourante; }
            set { _positionCourante = value; }
        }*/

        public bool Gagne
        {
            get { return _gagne; }
        }

        public void Court()
        {
            MainWindow plateau = (ParieChiens.MainWindow)App.Current.MainWindow;
            Random rnd = new Random();
           
            _positionCourante[0] += (int)(rnd.Next(0,51));
            Canvas.SetLeft(_imageChien, _positionCourante[0]);
         
            if(_positionCourante[0] > _longueurPiste)
            {
                _gagne = true;
            }
        }
    }
}
