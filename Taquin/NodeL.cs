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
            
        }

        public override List<NodeL> GetListSucc()
        {
           List<NodeL> list_succ = new List<NodeL>();




           return list_succ;
        }

        public override void CalculeHCost()
        {
            SetEstimation(0);
        }

        private string GetStringFromTab(char[,] tab)
        {
            string newname = "";
            for (int j = 0; j <= 2; j++)
                for (int i = 0; i <= 2; i++)
                {
                    newname = newname + tab[i, j];
                }
            return newname;
        }
    }
}
