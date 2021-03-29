using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace AtlantikOK
{
    public partial class CreerLiaison : Form
    {
        public CreerLiaison()
        {
            InitializeComponent();
        }

        private void CreerLiaison_Load(object sender, EventArgs e)
        {
            MySqlConnection maCnx;
            MySqlDataReader jeuEnr = null;
            maCnx = new MySqlConnection("server=localhost;user=root;database=atlantikok;port=3306;password=");
            try
            {
                string requête;
                maCnx.Open();
                requête = "Select * from secteur";
                var maCde = new MySqlCommand(requête, maCnx);
                jeuEnr = maCde.ExecuteReader();
                while (jeuEnr.Read())
                {
                    lbxSecteurs.Items.Add(new Secteur((int)jeuEnr["nosecteur"], (string)jeuEnr["nom"]));
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Erreur " + ex.ToString());
            }
            finally
            {
                if (jeuEnr is object & !jeuEnr.IsClosed)
                {
                    jeuEnr.Close(); // s'il existe et n'est pas déjà fermé
                }
                if (maCnx is object & maCnx.State == ConnectionState.Open)
                {
                    maCnx.Close(); // on se déconnecte
                }
            }
            cmbArriver.Items.Clear();
            MySqlConnection maCnx2;
            MySqlDataReader jeuEnr2 = null;
            maCnx2 = new MySqlConnection("server=localhost;user=root;database=atlantikok;port=3306;password=");
            string requête2;
            try
            {
                maCnx2.Open();
                requête2 = "Select * from port";
                var maCde2 = new MySqlCommand(requête2, maCnx2);
                jeuEnr2 = maCde2.ExecuteReader();
                while (jeuEnr2.Read())
                {
                    cmbArriver.Items.Add(new Port((int)jeuEnr2["noport"], (int)jeuEnr2["nosecteur"], (string)jeuEnr2["nom"]));
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Erreur " + ex.ToString());
            }
            finally
            {
                if (jeuEnr2 is object & !jeuEnr2.IsClosed)
                {
                    jeuEnr2.Close(); // s'il existe et n'est pas déjà fermé
                }
                if (maCnx2 is object & maCnx2.State == ConnectionState.Open)
                {
                    maCnx2.Close(); // on se déconnecte
                }
            }
        }

        private void lbxSecteurs_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbDepart.Items.Clear();
            MySqlConnection maCnx;
            MySqlDataReader jeuEnr = null;
            maCnx = new MySqlConnection("server=localhost;user=root;database=atlantikok;port=3306;password=");
            try
            {
                string requête;
                maCnx.Open();
                requête = "Select * from port where nosecteur = @nosecteur";
                var maCde = new MySqlCommand(requête, maCnx);
                maCde.Parameters.AddWithValue("@nosecteur", ((Secteur)lbxSecteurs.SelectedItem).GetNo());
                jeuEnr = maCde.ExecuteReader();
                while (jeuEnr.Read())
                {
                    cmbDepart.Items.Add(new Port((int)jeuEnr["noport"], (int)jeuEnr["nosecteur"], (string)jeuEnr["nom"]));
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Erreur " + ex.ToString());
            }
            finally 
            {
                if (jeuEnr is object & !jeuEnr.IsClosed)
                {
                    jeuEnr.Close(); // s'il existe et n'est pas déjà fermé
                }
                if (maCnx is object & maCnx.State == ConnectionState.Open)
                {
                    maCnx.Close(); // on se déconnecte
                }
            }
        }
        private void btnAjouterSecteur_Click(object sender, EventArgs e)
        {
            MySqlConnection maCnx;
            maCnx = new MySqlConnection("server=localhost;user=root;database=atlantikok;port=3306;password=");
            try
            {
                string requête;
                maCnx.Open();
                requête = "Insert into liaison(noport_depart, noport_arrivee, distance) values (@portdepart, @portarriver, @distance)";
                var maCde = new MySqlCommand(requête, maCnx);
                maCde.Parameters.AddWithValue("@portdepart", ((Port)cmbDepart.SelectedItem).GetNoPort());
                maCde.Parameters.AddWithValue("@portarriver", ((Port)cmbArriver.SelectedItem).GetNoPort());
                maCde.Parameters.AddWithValue("@distance", tbxDistance.Text);
                maCde.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Erreur " + ex.ToString());
            }
            finally
            {
                if (maCnx is object & maCnx.State == ConnectionState.Open)
                {
                    maCnx.Close(); // on se déconnecte
                }
            }
            tbxDistance.Text = "";
            lblLiaisonCreer.Text = "Liaison crée avec succès !";
        }
    }
 }

