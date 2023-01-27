using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace ExSimplifieSerpent
{
    class Joueur
    {
       

        private int _totalJoueur;
        private int _ancienneValeur;
        private int[] _positionPionJoueur = new int[2];
        private string _pionJoueur;

        public Joueur(int totalJoueur, int ancienneValeur, int[] positionPionJoueur, string pionJoueur)
        {
            this._totalJoueur = totalJoueur;
            this._ancienneValeur = ancienneValeur;
            this._positionPionJoueur = positionPionJoueur;
            this._pionJoueur = pionJoueur;
        }

        
        public void TourJoueur()
        {
            MainWindow plateau = (ExSimplifieSerpent.MainWindow)App.Current.MainWindow;

            Random rnd = new Random();
            int de = rnd.Next(1, 7);

            string numeroDe = de.ToString();
            plateau.face.Text = numeroDe;

            _ancienneValeur = _totalJoueur + 1;
            _totalJoueur += de;
            int reste = _totalJoueur - 10 * (_positionPionJoueur[0] + 1);
            plateau.buttons[_positionPionJoueur[0], _positionPionJoueur[1]].Content = _ancienneValeur;
            plateau.buttons[_positionPionJoueur[0], _positionPionJoueur[1]].Foreground = Brushes.Black;

            if (reste < 0)
            {
                reste += 10;
            }
            else
            {
                _positionPionJoueur[0] += 1;
            }

            if (_positionPionJoueur[0] % 2 != 0)
            {
                _positionPionJoueur[1] = 9 - reste;
            }
            else
            {
                _positionPionJoueur[1] = reste;
            }

            if (_positionPionJoueur[0] <= 9)
            {
                plateau.buttons[_positionPionJoueur[0], _positionPionJoueur[1]].Content = _pionJoueur;
                plateau.buttons[_positionPionJoueur[0], _positionPionJoueur[1]].Foreground = Brushes.Gold;
            }
            else
            {
                plateau.buttons[9, 0].Content = _pionJoueur;
                plateau.buttons[9, 0].Foreground = Brushes.Gold;
                plateau.play.IsEnabled = false;
                plateau.victoire.Text = "Vous avez gagné!";
            }
        }
    }
}
