using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtlantikOK
{
    class Port
    {
        private int noport;
        private int nosecteur;
        private string nom;

        public Port(int noport, int nosecteur, string nom)
        {
            this.noport = noport;
            this.nosecteur = nosecteur;
            this.nom = nom;
        }
        public int GetNoPort()
        {
            return this.noport;
        }
        public int GetNoSecteur()
        {
            return this.nosecteur;
        }
        public string GetNomPort()
        {
            return this.nom;
        }
        public override string ToString()
        {
            return this.nom.ToString();
        }
    }
}
