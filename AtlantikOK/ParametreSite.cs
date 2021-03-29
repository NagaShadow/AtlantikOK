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
    public partial class ParametreSite : Form
    {
        public ParametreSite()
        {
            InitializeComponent();
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            MySqlConnection maCnx;
            maCnx = new MySqlConnection("server=localhost;user=root;database=atlantikok;port=3306;password=");
            try
            {
                string requête;
                maCnx.Open();
                requête = "UPDATE parametres SET noidentifiant = @noidentifiant, site_pb = @site_pb, rang_pb = @rang_pb, clehmac_pb = @clehmac_pb";
                var maCde = new MySqlCommand(requête, maCnx);
                maCde.Parameters.AddWithValue("@noidentifiant", tbxIdentifiant.Text);
                maCde.Parameters.AddWithValue("@site_pb", tbxSite.Text);
                maCde.Parameters.AddWithValue("@rang_pb", tbxRang.Text);
                maCde.Parameters.AddWithValue("@clehmac_pb", tbxClé.Text);
                maCde.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Erreur " + ex.ToString());
            }
            finally
            {
                tbxIdentifiant.Text = "";
                tbxSite.Text = "";
                tbxRang.Text = "";
                tbxClé.Text = "";
                if (maCnx is object & maCnx.State == ConnectionState.Open)
                {
                    maCnx.Close(); // on se déconnecte
                }
            }
        }
    }
}
