using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACT_8_Guichet_Bancaire
{
    public class Personne
    {
        private string _nom;
        private string _prenom;
        private string _email;
        private int _telephone;
        private string _adresse;
        private int _codePostal;
        private int _mdp;

        public Personne(string nom, string prenom, string email, int telephone, string adresse, int codePostal, int mdp)
        {
            this._nom = nom;
            this._prenom = prenom;
            this._email = email;
            this._telephone = telephone;
            this._adresse = adresse;
            this._codePostal = codePostal;
            this._mdp = mdp;
        }
        public string Nom
        {
            get { return _nom; }
            set { _nom = value; }
        }

        public string Prenom
        {
            get { return _prenom; }
            set { _prenom = value; }
        }

        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }

        public int Telephone
        {
            get { return _telephone; }
            set { _telephone = value; }
        }

        public string Adresse
        {
            get { return _adresse; }
            set { _adresse = value; }
        }
        public int CodePostal
        {
            get { return _codePostal; }
            set { _codePostal = value; }
        }

        public int Mdp
        {
            get { return _mdp; }
            set { _mdp = value; }
        }
    }
}
