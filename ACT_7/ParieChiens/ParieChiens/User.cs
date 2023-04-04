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
            _hasBetted = false;
        }

        public bool PlaceTheBet(int miseEcus)
        {
            bool pariee = false;

            if(_money > 4)
            {
                _monPari.Mise += _money;
                _money -= miseEcus;
                _hasBetted = true;
            }

            return pariee;
        }

        public void RemoveMoney()
        {

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
            get { return _hasBetted; }
        }

    }
}
