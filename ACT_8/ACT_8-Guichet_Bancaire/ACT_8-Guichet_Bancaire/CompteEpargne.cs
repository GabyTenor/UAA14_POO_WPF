using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACT_8_Guichet_Bancaire
{
    class CompteEpargne : CompteBancaire
    {
        private float _taux;
        public CompteEpargne(float taux, float porteMonnaie, string numeroCompte) : base(porteMonnaie, numeroCompte)
        {
            this._taux = taux;
        }

        public override string Afficher()
        {
            return "";
        }

        public override string Transaction(CompteCourant client, string typeTransaction, float virement)
        {
            return "";
        }
    }
}
