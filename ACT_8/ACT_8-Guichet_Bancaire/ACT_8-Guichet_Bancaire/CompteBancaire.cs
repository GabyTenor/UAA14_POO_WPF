using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACT_8_Guichet_Bancaire
{
    abstract class CompteBancaire
    {
        protected float _porteMonnaie;
        protected string _numeroCompte;

        public CompteBancaire(float porteMonnaie, string numeroCompte)
        {
            this._porteMonnaie = porteMonnaie;
            this._numeroCompte = numeroCompte;
        }

        public abstract string Transaction(CompteCourant client, string typeTransaction, float virement);

        public abstract string Afficher();
        
        public float PorteMonnaie
        {
            get { return _porteMonnaie; }
            set { _porteMonnaie = value; }
        }

        public string NumeroCompte
        {
            get { return _numeroCompte; }
            set { _numeroCompte = value; }
        }

    }
}
