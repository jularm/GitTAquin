using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projettaquin
{
    class NodeL : GenericNode
    {

        public NodeL(string newname)
            : base(newname)
        {
        }

        public override bool EndState()
        {
            return (this.GetNom() == "12345678?");
        }

        public override List<NodeL> GetListSucc()
        {
            List<NodeL> list_succ = new List<NodeL>();

            foreach (NodeL N in this.list_Lien)
            {
                if (N.GetNoeud_Parent() == null)
                {
                    N.SetNoeud_Parent(this);
                }

                foreach (NodeL N in this.Enfants)
                {
                    list_succ.Add(N);
                }
            }
        }

        /*renvoit la distance entre le point correspondant au noeud this et le point correspondant au noeud node*/
        public override double GetArcCost(GenericNode node)
        {
            //on cherche à quel point ce node (this) correspond parmis les points du monde
            Point pointNode = Monde.List_Points.Find(point => point.NomPoint == node.GetNom());
            if (pointNode != null)
            {
                //on cherche à quel point voisin le noeud node correspond
                lien resultat = pointNode.List_Voisins.Find(voisin => voisin.NomVoisin == node.GetNom()); ;
                return resultat.Distance;
                
                /*if (resultat!=null)
                {
                    return resultat.distance;
                }
                else
                {
                    string erreur = "ce point n'a pas de voisin correspondant au nom " + node.GetNom();
                    throw new Exception(erreur);
                }*/
            }

            foreach (NodeL N in this.Enfants)
            {
                list_succ.Add(N);
            }

            return list_succ;
        }


        public override void CalculeHCost()
        {
            SetEstimation(0);
        }
                

    }
}
