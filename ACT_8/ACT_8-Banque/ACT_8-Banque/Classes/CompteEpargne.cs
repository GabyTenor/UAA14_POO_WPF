using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACT_8_Banque
{
    public class CompteEpargne : CompteBancaire
    {
        private float _taux;
        public CompteEpargne(float taux, float porteMonnaie, string numeroCompte, Personne proprietaire)
        {
            this._taux = taux;
            this._porteMonnaie = porteMonnaie;
            this._numeroCompte = numeroCompte;
        }

        public override string Afficher()
        {
            return "Taux d'interêt : " + _taux + "\nPorte Monnaie : " + _porteMonnaie + "\nNuméro de compte : " + _numeroCompte + "\nPropriétaire : " + _proprietaire.Nom + " " + _proprietaire.Prenom;
        }

        public override string Transaction(CompteEpargne epargne, CompteCourant client, string typeTransaction, float virement)
        {
            if (_proprietaire.Nom == client.Proprietaire.Nom)
            {
                if (virement < _porteMonnaie / 2)
                {
                    _porteMonnaie -= virement;
                    client.PorteMonnaie += virement;

                    return "Transaction effectué!";
                }
                else
                {
                    return "Votre virement est supérieure à la moitié de l'argent dans votre compte épargne";
                }

            }
            else
            {
                return "Ce n'est pas votre compte!!";
            }
        }

        public Personne Proprieraire
        {
            get { return _proprietaire; }
        }

    }
}
