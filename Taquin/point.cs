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
<<<<<<< HEAD
         
        public string Nom_Voisin
=======
        public string NomVoisin
>>>>>>> refs/remotes/origin/master
        {
            get { return _nomVoisin;}
            set{ _nomVoisin = value;}
        }
        public int Distance
        {
            get { return _distance; }
            set { _distance = value; }
<<<<<<< HEAD
        }
        public lien(string nom, int dist)
        {
            _nomVoisin = nom;
            _distance = dist;
=======
>>>>>>> refs/remotes/origin/master
        }
    }
    class Point
    {
<<<<<<< HEAD
        string nom_Point;
        List<lien> list_voisins;
        bool ferme;
=======
        private string _nomPoint;
        private List<lien> _list_Voisins;
>>>>>>> refs/remotes/origin/master

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
        public Point(string nom, List<lien> voisins)
        {
<<<<<<< HEAD
            nom_Point = nom;
            list_voisins = voisins;
            ferme = false;
        }
        public Point(string nom, List<lien> voisins, bool farm)
        {
            nom_Point = nom;
            list_voisins = voisins;
            ferme = farm;
        }     
=======
            _nomPoint = nom;
            _list_Voisins = voisins;
        }
>>>>>>> refs/remotes/origin/master
    }
}
