using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Taquin
{
    class Monde
    {
        private string nom_Monde;
        List<Point> list_Points;
        public string Nom_Monde
        {
            get { return nom_Monde; }
            set { nom_Monde = value; }
        }
        public List<Point> List_Points
        {
            get { return list_Points; }
        }
        public void Point(string nom, List<Point> points)
        {
            nom_Monde = nom;
            list_Points = points;
        }
    }
}
