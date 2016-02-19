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

        public override double GetArcCost(GenericNode N2)
        {
            return (1);
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
