using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtlantikOK
{
    class Client
    {
        private int noclient, codepostal;
        private string nom, prenom, adresse, ville, telephonefixe, telephonemobile, mel, motdepasse;

        public Client(int pNocient, int pCodepostal, string pNom, string pPrenom, string pAdresse, string pVille, string pTelephone, string pTelephonemobile, string pMel, string pMotdepasse)
        {
            noclient = pNocient;
            codepostal = pCodepostal;
            nom = pNom;
            prenom = pPrenom;
            adresse = pAdresse;
            ville = pVille;
            telephonefixe = pTelephone;
            telephonemobile = pTelephonemobile;
            mel = pMel;
            motdepasse = pMotdepasse;
        }
        public int GetNo()
        {
            return noclient;
        }
        public int GetCodePostal()
        {
            return codepostal;
        }
        public string GetNom()
        {
            return nom;
        }
        public string GetPrenom()
        {
            return prenom;
        }
        public string GetAdresse()
        {
            return adresse;
        }
        public string GetVille()
        {
            return ville;
        }
        public string GetTelephone()
        {
            return telephonefixe;
        }
        public string GetTelephonemobile()
        {
            return telephonemobile;
        }
        public string GetMel()
        {
            return mel;
        }
        public string GetMotDePasse()
        {
            return motdepasse;
        }
        public override string ToString()
        {
            return nom + " " + prenom;
        }
    }
}
