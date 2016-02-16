using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace projettaquin
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
    class Point
    {
        string nom_Point;
        List<lien> list_voisins;

        public string Nom_Voisin
        {
            get { return nom_Point; }
            set { nom_Point = value; }
        }
        public List<lien> Voisin
        {
            get { return list_voisins; }
        }
        public void Point(string nom, List<lien> voisins)
        {
            nom_Point = nom;
            list_voisins = voisins;
        }

    }


}
