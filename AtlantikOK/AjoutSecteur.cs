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
    public partial class AjoutSecteur : Form
    {

        public AjoutSecteur()
        {
            InitializeComponent();
        }

        public void AjoutSecteur_Load(object sender, EventArgs e)
        {
            lblAjoutOK.Text = "";
        }

        private void btnAjouterSecteur_Click(object sender, EventArgs e)
        {
            string TextSelection;
            TextSelection = tbxNomSecteur.Text;
            MySqlConnection maCnx;
            maCnx = new MySqlConnection("server=localhost;user=root;database=atlantikok;port=3306;password=");
            try
            {
                string requête;
                maCnx.Open();
                requête = "Insert into secteur(nom) values (@TextSelection)";
                var maCde = new MySqlCommand(requête, maCnx);
                maCde.Parameters.AddWithValue("@TextSelection", TextSelection);
                maCde.ExecuteNonQuery();
                lblAjoutOK.Text = "Ajout effectué avec succès !";
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Erreur " + ex.ToString());
            }
            finally
            {
                tbxNomSecteur.Text = "";
                if (maCnx is object & maCnx.State == ConnectionState.Open)
                {
                    maCnx.Close(); // on se déconnecte
                }
            }
        }
    }
}
