using System;
using System.Collections.Generic;
using System.Text;

namespace ParieChiens
{
    class Bet
    {
        private int _mise;
        private User _joueur;
        private int _numberChien;

        public Bet() { }

        public int Mise
        {
            get { return _mise; }
            set { _mise = value; }
        }

    }
}
