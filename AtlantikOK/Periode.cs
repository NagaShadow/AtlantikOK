using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtlantikOK
{
    class Periode
    {
        private int noperiode;
        private string datedebut;
        private string datefin;

        public Periode(int noperiode, string datedebut, string datefin)
        {
            this.noperiode = noperiode;
            this.datedebut = datedebut;
            this.datefin = datefin;
        }
        public int GetNoPeriode()
        {
            return this.noperiode;
        }
        public string GetDateDebut()
        {
            return this.datedebut;
        }
        public string GetDateFin()
        {
            return this.datefin;
        }
        public override string ToString()
        {
            return this.datedebut + " " + this.datefin;
        }
    }
}
