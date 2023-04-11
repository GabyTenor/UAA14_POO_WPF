using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACT_8_Guichet_Bancaire
{
    class CompteCourant : CompteBancaire
    {
        private float _decouvertMax;

        public CompteCourant(float decouvertMax , float porteMonnaie, string numeroCompte): base(porteMonnaie, numeroCompte)
        {
            this._decouvertMax = decouvertMax;
        }

        public override string Afficher()
        {
            return "";
        }

        public override string Transaction(CompteCourant client, string typeTransaction, float virement)
        {
            switch (typeTransaction)
            {
                case "Virement Autre Personne":

                    if (TransactionEntrePersonnes(client, virement))
                    {
                        return "Transaction effectué avec succès !";
                    }
                    else
                    {
                        return "Transaction impossible, vérifier le montant de votre virement";
                    }
                    break;

                case "Transaction Compte Epargne":

                    return "";

                    break;


                default:
                    return "";
                    break;
            }
        }

        private bool TransactionEntrePersonnes(CompteCourant client, float virement)
        {
            if ((_porteMonnaie - virement) < _decouvertMax)
            {
                _porteMonnaie -= virement;
                client.PorteMonnaie += virement;

                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
