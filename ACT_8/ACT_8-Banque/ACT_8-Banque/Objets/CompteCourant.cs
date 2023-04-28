using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACT_8_Banque.Objets
{
    public class CompteCourant : CompteBancaire
    {
        private float _decouvertMax;

        public CompteCourant(float decouvertMax, float porteMonnaie, string numeroCompte, Personne proprietaire)
        {
            this._decouvertMax = decouvertMax;
            this._porteMonnaie = porteMonnaie;
            this._numeroCompte = numeroCompte;
            this._proprietaire = proprietaire;
        }

        public override string Afficher()
        {
            return "Plafond autorisé : " + _decouvertMax + "--Porte Monnaie : " + _porteMonnaie + "--Numéro de compte : " + _numeroCompte + "--Propriétaire : " + _proprietaire.Nom + " " + _proprietaire.Prenom;
        }

        public override string Transaction(CompteEpargne[] epargne, CompteCourant[] client, string typeTransaction, float virement, int login, int destinataire)
        {
            switch (typeTransaction)
            {
                case "Virement Autre Personne":

                    if (TransactionEntrePersonnes(client, virement, login, destinataire))
                    {
                        return "Transaction effectué avec succès !";
                    }
                    else
                    {
                        return "Transaction impossible";
                    }
                    break;

                case "Transaction Compte Epargne":

                    if (TransactionEpargne(epargne, virement, login, destinataire))
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

        private bool TransactionEntrePersonnes(CompteCourant[] client, float virement, int login, int destinataire)
        {
            if (_proprietaire.Nom != client[login].Proprietaire.Nom)
            {
                if ((_porteMonnaie - virement) < _decouvertMax)
                {
                    _porteMonnaie -= virement;
                    client[login].PorteMonnaie += virement;

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

        private bool TransactionEpargne(CompteEpargne[] epargne, float virement, int login, int destinataire)
        {
            if (_proprietaire.Nom == epargne[login].Proprieraire.Nom)
            {
                if ((_porteMonnaie - virement) < _decouvertMax)
                {
                    _porteMonnaie -= virement;
                    epargne[login].PorteMonnaie += virement;

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
