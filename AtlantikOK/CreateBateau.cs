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
    public partial class CreateBateau : Form
    {
        public CreateBateau()
        {
            InitializeComponent();
        }

        private void btnCreerBateau_Click(object sender, EventArgs e)
        {
            string TextSelection;
            TextSelection = tbxNomBateau.Text;
            MySqlConnection maCnx;
            MySqlDataReader jeuEnr = null;
            maCnx = new MySqlConnection("server=localhost;user=root;database=atlantik;port=3306;password=");
            try
            {
                string requête;
                maCnx.Open();
                requête = "Insert into bateau(nom) values (@TextSelection)";
                var maCde = new MySqlCommand(requête, maCnx);
                maCde.Parameters.AddWithValue("@TextSelection", TextSelection);
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
            int nobateau;
            try
            {
                string requête;
                maCnx.Open();
                requête = "Select nobateau from bateau where nom = @TextSelection";
                var maCde = new MySqlCommand(requête, maCnx);
                maCde.Parameters.AddWithValue("@TextSelection", TextSelection);
                jeuEnr = maCde.ExecuteReader();
                jeuEnr.Read();
                nobateau = (int)jeuEnr["nobateau"];
                MySqlConnection maCnxInsertA;
                maCnxInsertA = new MySqlConnection("server=localhost;user=root;database=atlantik;port=3306;password=");
                MySqlConnection maCnxInsertB;
                maCnxInsertB = new MySqlConnection("server=localhost;user=root;database=atlantik;port=3306;password=");
                MySqlConnection maCnxInsertC;
                maCnxInsertC = new MySqlConnection("server=localhost;user=root;database=atlantik;port=3306;password=");
                try
                {
                    string requête2;
                    maCnxInsertA.Open();
                    requête2 = "Insert into contenir(lettrecategorie, nobateau, capacitemax) values ('A', @nobateau, @capaciteA)";
                    var maCde2 = new MySqlCommand(requête2, maCnxInsertA);
                    maCde2.Parameters.AddWithValue("@nobateau", nobateau);
                    maCde2.Parameters.AddWithValue("@capaciteA", tbxCapaciteA.Text);
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
                    requête3 = "Insert into contenir(lettrecategorie, nobateau, capacitemax) values ('B', @nobateau, @capaciteB)";
                    var maCde3 = new MySqlCommand(requête3, maCnxInsertB);
                    maCde3.Parameters.AddWithValue("@nobateau", nobateau);
                    maCde3.Parameters.AddWithValue("@capaciteB", tbxCapaciteB.Text);
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
                    requête4 = "Insert into contenir(lettrecategorie, nobateau, capacitemax) values ('C', @nobateau, @capaciteC)";
                    var maCde4 = new MySqlCommand(requête4, maCnxInsertC);
                    maCde4.Parameters.AddWithValue("@nobateau", nobateau);
                    maCde4.Parameters.AddWithValue("@capaciteC", tbxCapaciteC.Text);
                    maCde4.ExecuteNonQuery();
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Erreur " + ex.ToString());
                }
                finally
                {
                    if (maCnxInsertC is object & maCnxInsertC.State == ConnectionState.Open)
                    {
                        maCnxInsertC.Close(); // on se déconnecte
                    }
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
            tbxNomBateau.Text = "";
            tbxCapaciteA.Text = "";
            tbxCapaciteB.Text = "";
            tbxCapaciteC.Text = "";
            lblCreationReussis.Text = "La création du bateau à été effectuée !";
        }
    }
}
