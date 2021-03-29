using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtlantikOK
{
    class Liaison
    {
        private int nolaison;
        private string port_depart;
        private string port_arrivee;
        private double distance;

        public Liaison(int pNolaison, string pNoport_dpart, string pNoport_arrivee, double pDistance)
        {
            this.nolaison = pNolaison;
            this.port_depart = pNoport_dpart;
            this.port_arrivee = pNoport_arrivee;
            this.distance = pDistance;
        }
        public int GetNo()
        {
            return this.nolaison;
        }
        public string GetPort_depart()
        {
            return this.port_depart;
        }
        public string GetPort_arrivee()
        {
            return this.port_arrivee;
        }
        public double GetDistance()
        {
            return this.distance;
        }
        public override string ToString()
        {
            return port_depart + " " + port_arrivee;
        }
    }
}
