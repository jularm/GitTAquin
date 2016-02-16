using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace projettaquin
{
    class NodeLait : GenericNode
    {
        public override double GetArcCost(GenericNode node)
        {
            NodeLait resultat;
            resultat=listeVoisin.find(voisin => voisin.nom == node.GetNom());
            if (resultat!=null)
            {
                return resultat.distance;
            }
            else
            {
                string erreur = "ce point n'a pas de voisin correspondant au nom " + node.GetNom();
                throw new Exception(erreur);
            }
        }

    }
}
