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
    public partial class CreerTraversee : Form
    {
        MySqlConnection maCnx = new MySqlConnection("server=localhost;user=root;database=atlantik;port=3306;password=");
        public CreerTraversee()
        {
            InitializeComponent();
        }

        private void CreerTraversee_Load(object sender, EventArgs e)
        {
            int nobateau;
            MySqlDataReader jeuEnr = null;
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
            try
            {
                string requête;
                maCnx.Open();
                requête = "Select * from bateau";
                var maCde = new MySqlCommand(requête, maCnx);
                jeuEnr = maCde.ExecuteReader();
                while (jeuEnr.Read())
                {
                    cmbBateau.Items.Add(new Bateau((int)jeuEnr["nobateau"], (string)jeuEnr["nom"]));
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Erreur " + ex.ToString());
            }
            finally
            {
                nobateau = (int)jeuEnr["nobateau"];
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

        private void lbxSecteurs_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbLiaison.Items.Clear();
            MySqlConnection maCnx;
            maCnx = new MySqlConnection("server=localhost;user=root;database=atlantik;port=3306;password=");
            MySqlDataReader jeuEnr = null;
            string requête = "";
            if (lbxSecteurs.SelectedItem != null)
            {
                requête = "SELECT * FROM liaison, port WHERE liaison.noport_depart = port.noport AND port.nosecteur = " + ((Secteur)lbxSecteurs.SelectedItem).GetNo();
            }
            else
            {
                requête = "SELECT * FROM liaison, port WHERE liaison.noport_depart = port.noport AND port.nosecteur = 0";
            }
            try
            {
                maCnx.Open();
                var maCde = new MySqlCommand(requête, maCnx);
                jeuEnr = maCde.ExecuteReader();
                string nomdepart;
                string nomarrivee;
                while (jeuEnr.Read())
                {

                    MySqlConnection maCnx2;
                    maCnx2 = new MySqlConnection("server=localhost;user=root;database=atlantik;port=3306;password=");
                    MySqlDataReader jeuEnr2 = null;
                    string requête2 = "SELECT nom FROM port WHERE noport = " + (int)jeuEnr["noport_depart"];
                    try
                    {
                        maCnx2.Open();
                        var maCde2 = new MySqlCommand(requête2, maCnx2);
                        jeuEnr2 = maCde2.ExecuteReader();
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                    finally
                    {
                        jeuEnr2.Read();
                        nomdepart = (string)jeuEnr2["nom"] + " -";
                        jeuEnr2.Close();
                        maCnx2.Close();
                    }
                    MySqlConnection maCnx3;
                    maCnx3 = new MySqlConnection("server=localhost;user=root;database=atlantik;port=3306;password=");
                    MySqlDataReader jeuEnr3 = null;
                    string requête3 = "SELECT nom FROM port WHERE noport = " + (int)jeuEnr["noport_arrivee"];
                    try
                    {
                        maCnx3.Open();
                        var maCde3 = new MySqlCommand(requête3, maCnx3);
                        jeuEnr3 = maCde3.ExecuteReader();
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                    finally
                    {
                        jeuEnr3.Read();
                        nomarrivee = (string)jeuEnr3["nom"];
                        jeuEnr3.Close();
                        maCnx3.Close();
                    }
                    cmbLiaison.Items.Add(new Liaison((int)jeuEnr["noliaison"], nomdepart, nomarrivee, (double)jeuEnr["distance"]));
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                if (jeuEnr is object & !jeuEnr.IsClosed)
                {
                    jeuEnr.Close();
                }
                if (maCnx is object & maCnx.State == ConnectionState.Open)
                {
                    maCnx.Close();
                }

            }
        }

        private void btnCreerTraversee_Click(object sender, EventArgs e)
        {
            try
            {
                string requête;
                maCnx.Open();
                requête = "Insert into traversee(noliaison, nobateau, dateheuredepart, dateheurearrivee) values (@noliaison, @nobateau, @dateheuredepart, @dateheurearrivee)";
                var maCde = new MySqlCommand(requête, maCnx);
                maCde.Parameters.AddWithValue("@noliaison", ((Liaison)cmbLiaison.SelectedItem).GetNo());
                maCde.Parameters.AddWithValue("@nobateau", ((Bateau)cmbBateau.SelectedItem).GetNo());
                maCde.Parameters.AddWithValue("@dateheuredepart", dateDepart.Value.Date + dateTimeDepart.Value.TimeOfDay);
                maCde.Parameters.AddWithValue("@dateheurearrivee", dateArriver.Value.Date + dateTimeArriver.Value.TimeOfDay); ;
                maCde.ExecuteScalar();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show ("Erreur " + ex.ToString());
            }
            finally
            {
                lblTraverseeCreer.Text = "La traversée à été créer avec succès !";
                if (maCnx is object & maCnx.State == ConnectionState.Open)
                {
                    maCnx.Close(); // on se déconnecte
                }
            }
        }
    }
}
