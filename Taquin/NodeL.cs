using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Taquin
{
    class NodeL : GenericNode
    {

         public NodeL( string newname ) : base(newname)
        {
        }


        public abstract double GetArcCost(GenericNode N2);
        public abstract bool EndState();
        public abstract List<GenericNode> GetListSucc();
        public abstract void CalculeHCost();
    }
}
