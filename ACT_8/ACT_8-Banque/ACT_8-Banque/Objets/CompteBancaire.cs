using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACT_8_Banque.Objets 
{
    public abstract class CompteBancaire
    {
        protected float _porteMonnaie;
        protected string _numeroCompte;
        protected Personne _proprietaire;

        public abstract string Transaction(CompteEpargne[] epargne, CompteCourant[] client, string typeTransaction, float virement, int login, int destinataire);
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
