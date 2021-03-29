using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtlantikOK
{
    class Bateau
    {
        private int nobateau;
        private string nom;

        public Bateau(int pNobateau, string pNom)
        {
            nobateau = pNobateau;
            nom = pNom;
        }
        public int GetNo()
        {
            return nobateau;
        }
        public string GetNom()
        {
            return nom;
        }
        public override string ToString()
        {
            return nom;
        }
    }
}
