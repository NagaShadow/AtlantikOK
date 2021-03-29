using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtlantikOK
{
    class Secteur
    {
        private int nosecteur;
        private string nomsecteur;

        public Secteur(int no, string nom)
        {
            nosecteur = no;
            nomsecteur = nom;
        }
        public int GetNo()
        {
            return nosecteur;
        }
        public string GetNom()
        {
            return nomsecteur;
        }
        public override string ToString()
        {
            return nomsecteur.ToString();
        }
    }


}
