using System;
using System.Collections.Generic;
using System.Text;

namespace ParieChiens
{
    class User
    {
        private string _name;
        private int _money;
        private Bet _monPari;
        private bool _hasBetted;

        public User(string name, int money)
        {
            this._name = name;
            this._money = money;
            _monPari = new Bet();
            _hasBetted = false;
        }

        public bool PlaceTheBet(int miseEcus)
        {
            bool done = false;

            if (!_hasBetted)
            {
                if (_money > miseEcus)
                {
                    _monPari.Mise += _money;
                    _money -= miseEcus;
                    done = true;
                }
            }
            
            return done;
        }

        public void AddMoney()
        {

        }
        
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int Money
        {
            get { return _money; }
            set { _money = value; }
        }

        public bool HasBetted
        {
            set { _hasBetted = value; }
            get { return _hasBetted; }
        }

        public Bet MonPari
        {
            get { return _monPari; }
        }

    }
}
