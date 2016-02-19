﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

<<<<<<< HEAD
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
=======
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

>>>>>>> refs/remotes/origin/master
    }
}
