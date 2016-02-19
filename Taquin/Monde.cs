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
        public void Monde(string nom, List<Point> points)
        {
            _nomMonde = nom;
            list_Points = points;
        }
    }
}
