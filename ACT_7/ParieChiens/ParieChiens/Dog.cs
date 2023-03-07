using System;
using System.Collections.Generic;
using System.Text;

namespace ParieChiens
{
    class Dog
    {
        private int _number;
        private double[] _position;

        public Dog(int number)
        {
            this._number = number;
            this._position = new double[2];
        }

        public void Move()
        {

        }

        public int Number
        {
            get { return _number; }
            set { _number = value; }
        }

        public double[] Position
        {
            get { return _position; }
            set { _position = value; }
        }
    }
}
