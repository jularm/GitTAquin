using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace projettaquin
{
    class Monde
    {
        private string _nomMonde;
        private static List<Point> list_Points;

        public string NomMonde
        {
            get { return _nomMonde; }
            set { _nomMonde = value; }
        }
        public static List<Point> List_Points
        {
            get { return list_Points; }
        }
        public Monde(string nom, List<Point> points)
        {
            _nomMonde = nom;
            list_Points = points;
        }


        public List<Point> Impasses()
        {
            List<Point> res = new List<Point>();
            foreach (Point P in list_Points)
            {
                if (P.List_Voisins.Count == 1)
                {
                    res.Add(P);
                }
            }
            return res;
        }


    }
}
