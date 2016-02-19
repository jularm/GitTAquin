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

            foreach ( NodeL N in this.list_Lien )
            {
                if (N.GetNoeud_Parent() == null)
                {
                    N.SetNoeud_Parent(this);

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
