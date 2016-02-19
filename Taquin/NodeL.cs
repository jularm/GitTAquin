using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace projettaquin
{
    class NodeL : GenericNode
    {
        /*renvoit la distance entre le point correspondant au noeud this et le point correspondant au noeud node*/
        public override double GetArcCost(GenericNode node)
        {
            Point pointNode = Monde.list_Points.find(point => point.nom == node.GetNom());
            if (pointNode != null)
            {
                NodeL resultat = pointNode.list_Voisins.find(voisin => voisin.nom == node.GetNom()); ;
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
            else
            {
                string erreur = "ce point n'a pas de voisin correspondant au nom " + node.GetNom();
                throw new Exception(erreur);
            }
        }
    }
}
