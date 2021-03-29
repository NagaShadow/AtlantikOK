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
    public partial class AjoutPort : Form
    {
        public AjoutPort()
        {
            InitializeComponent();
        }
        private void AjoutPort_Load(object sender, EventArgs e)
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
        }

        private void btnAjouterPort_Click(object sender, EventArgs e)
        {
            MySqlConnection maCnx;
            maCnx = new MySqlConnection("server=localhost;user=root;database=atlantikok;port=3306;password=");
            try
            {
                string requête;
                maCnx.Open();
                requête = "Insert into port(nosecteur, nom) values (@lbxSelectionne, @TextSelection)";
                var maCde = new MySqlCommand(requête, maCnx);
                maCde.Parameters.AddWithValue("@TextSelection", tbxNomPort.Text);
                maCde.Parameters.AddWithValue("@lbxSelectionne", ((Secteur)lbxSecteurs.SelectedItem).GetNo());
                maCde.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Erreur " + ex.ToString());
            }
            finally
            {
                lblPortAjouter.Text = "";
                if (maCnx is object & maCnx.State == ConnectionState.Open)
                {
                    maCnx.Close(); // on se déconnecte
                }
            }
            tbxNomPort.Text = "";
            lblPortAjouter.Text = "Ajout effectué avec succès !";
        }
    }
}
