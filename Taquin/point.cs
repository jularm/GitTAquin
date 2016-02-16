using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Taquin
{
    struct lien
    {
        private string nom_Voisin;
        private int distance;
         
        public string Nom_Voisin
        {
            get { return nom_Voisin;}
            set{ nom_Voisin = value;}
        }
        public int Distance
        {
            get { return distance; }
            set { distance = value; }
        }
    }
    class point
    {
        string nom_Point;
        List<lien> voisin;

        public string Nom_Voisin
        {
            get { return nom_Point; }
            set { nom_Point = value; }
        }
        public List<lien> Voisin
        {
            get { return voisin; }
        }
        public void Point(string nom, List<lien> voisins)
        {
            nom_Point = nom;
            voisin = voisins;
        }
    }


}
