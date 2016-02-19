using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace projettaquin
{
    struct lien
    {
        private string _nomVoisin;
        private int _distance;
        public string NomVoisin
        {
            get { return _nomVoisin;}
            set{ _nomVoisin = value;}
        }
        public int Distance
        {
            get { return _distance; }
            set { _distance = value; }
        }
    }
    class Point
    {
        private string _nomPoint;
        private List<lien> _list_Voisins;

        public string NomVoisin
        {
            get { return _nomPoint; }
            set { _nomPoint = value; }
        }
        public List<lien> Voisin
        {
            get { return _list_Voisins; }
            set { _list_Voisins = value; }
        }
        public void Point(string nom, List<lien> voisins)
        {
            _nomPoint = nom;
            _list_Voisins = voisins;
        }
    }
}
