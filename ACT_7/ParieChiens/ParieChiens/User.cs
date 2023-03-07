using System;
using System.Collections.Generic;
using System.Text;

namespace ParieChiens
{
    class User
    {
        private string _name;
        private int _money;

        public User(string name, int money)
        {
            this._name = name;
            this._money = money;
        }

        public void PlaceTheBet()
        {

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

    }
}
