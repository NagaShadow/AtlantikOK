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
    public partial class ModifBateau : Form
    {
        public ModifBateau()
        {
            InitializeComponent();
        }

        private void cmbModifBateau_Click(object sender, EventArgs e)
        {
            cmbModifBateau.Items.Clear();
            MySqlConnection maCnx;
            MySqlDataReader jeuEnr = null;
            maCnx = new MySqlConnection("server=localhost;user=root;database=atlantikok;port=3306;password=");
            try
            {
                string requête;
                maCnx.Open();
                requête = "SELECT * FROM bateau";
                var maCde = new MySqlCommand(requête, maCnx);
                jeuEnr = maCde.ExecuteReader();
                while (jeuEnr.Read())
                {
                    cmbModifBateau.Items.Add(new Bateau((int)jeuEnr["nobateau"], (string)jeuEnr["nom"]));
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

        private void btnModifBateau_Click(object sender, EventArgs e)
        {
            MySqlConnection maCnx;
            maCnx = new MySqlConnection("server=localhost;user=root;database=atlantikok;port=3306;password=");
            MySqlConnection maCnxInsertA;
            maCnxInsertA = new MySqlConnection("server=localhost;user=root;database=atlantikok;port=3306;password=");
            MySqlConnection maCnxInsertB;
            maCnxInsertB = new MySqlConnection("server=localhost;user=root;database=atlantikok;port=3306;password=");
            MySqlConnection maCnxInsertC;
            maCnxInsertC = new MySqlConnection("server=localhost;user=root;database=atlantikok;port=3306;password=");
            try
            {
                string requête2;
                maCnxInsertA.Open();
                requête2 = "UPDATE contenir SET capacitemax = @capaciteA WHERE lettrecategorie = 'A' AND nobateau = @nobateau";
                var maCde2 = new MySqlCommand(requête2, maCnxInsertA);
                maCde2.Parameters.AddWithValue("@nobateau", ((Bateau)cmbModifBateau.SelectedItem).GetNo());
                maCde2.Parameters.AddWithValue("@capaciteA", int.Parse(tbxA.Text));
                maCde2.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Erreur " + ex.ToString());
            }
            finally
            {
                if (maCnxInsertA is object & maCnxInsertA.State == ConnectionState.Open)
                {
                    maCnxInsertA.Close(); // on se déconnecte
                }
            }
            try
            {
                string requête3;
                maCnxInsertB.Open();
                requête3 = "UPDATE contenir SET capacitemax = @capaciteB WHERE lettrecategorie = 'B' AND nobateau = @nobateau";
                var maCde3 = new MySqlCommand(requête3, maCnxInsertB);
                maCde3.Parameters.AddWithValue("@nobateau", ((Bateau)cmbModifBateau.SelectedItem).GetNo());
                maCde3.Parameters.AddWithValue("@capaciteB", int.Parse(tbxB.Text));
                maCde3.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Erreur " + ex.ToString());
            }
            finally
            {
                if (maCnxInsertB is object & maCnxInsertB.State == ConnectionState.Open)
                {
                    maCnxInsertB.Close(); // on se déconnecte
                }
            }
            try
            {
                string requête4;
                maCnxInsertC.Open();
                requête4 = "UPDATE contenir SET capacitemax = @capaciteC WHERE lettrecategorie = 'C' AND nobateau = @nobateau";
                var maCde4 = new MySqlCommand(requête4, maCnxInsertC);
                maCde4.Parameters.AddWithValue("@nobateau", ((Bateau)cmbModifBateau.SelectedItem).GetNo());
                maCde4.Parameters.AddWithValue("@capaciteC", int.Parse(tbxC.Text));
                maCde4.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Erreur " + ex.ToString());
            }
            finally
            {
                lblModifBateau.Text = "La bateau à été modifié !";
                tbxA.Text = "";
                tbxB.Text = "";
                tbxC.Text = "";
                if (maCnxInsertC is object & maCnxInsertC.State == ConnectionState.Open)
                {
                    maCnxInsertC.Close(); // on se déconnecte
                }
            }
        }
    }
}
