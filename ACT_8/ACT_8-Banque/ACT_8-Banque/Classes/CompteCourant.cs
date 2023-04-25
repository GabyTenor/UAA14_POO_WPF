using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACT_8_Banque
{
    public class CompteCourant : CompteBancaire
    {
        private float _decouvertMax;

        public CompteCourant(float decouvertMax, float porteMonnaie, string numeroCompte, Personne proprietaire)
        {
            this._decouvertMax = decouvertMax;
            this._porteMonnaie = porteMonnaie;
            this._numeroCompte = numeroCompte;
        }

        public override string Afficher()
        {
            return "Plafond autorisé : " + _decouvertMax + "\nPorte Monnaie : " + _porteMonnaie + "\nNuméro de compte : " + _numeroCompte + "\nPropriétaire : " + _proprietaire.Nom + " " + _proprietaire.Prenom;
        }

        public override string Transaction(CompteEpargne epargne, CompteCourant client, string typeTransaction, float virement)
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
                        return "Transaction impossible";
                    }
                    break;

                case "Transaction Compte Epargne":

                    if (TransactionEpargne(epargne, virement))
                    {
                        return "Transaction effectué avec succès !";
                    }
                    else
                    {
                        return "Transaction impossible";
                    }
                    break;

                default:
                    return "";
                    break;
            }
        }

        private bool TransactionEntrePersonnes(CompteCourant client, float virement)
        {
            if (_proprietaire.Nom != client.Proprietaire.Nom)
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
            else
            {
                return false;
            }

        }

        private bool TransactionEpargne(CompteEpargne epargne, float virement)
        {
            if (_proprietaire.Nom == epargne.Proprieraire.Nom)
            {
                if ((_porteMonnaie - virement) < _decouvertMax)
                {
                    _porteMonnaie -= virement;
                    epargne.PorteMonnaie += virement;

                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }

        }

        public Personne Proprietaire
        {
            get { return _proprietaire; }
        }

    }
}
