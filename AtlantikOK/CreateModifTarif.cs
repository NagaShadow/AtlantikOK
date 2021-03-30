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
    public partial class CreateModifTarif : Form
    {
        public CreateModifTarif()
        {
            InitializeComponent();
        }

        private void CreateModifTarif_Load(object sender, EventArgs e)
        {
            MySqlConnection maCnx;
            MySqlDataReader jeuEnr = null;
            maCnx = new MySqlConnection("server=localhost;user=root;database=atlantik;port=3306;password=");
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
        private void lbxSecteurs_SelectedIndexChanged(object sender, EventArgs e)
        {
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
            MySqlConnection maCnx4;
            maCnx4 = new MySqlConnection("server=localhost;user=root;database=atlantik;port=3306;password=;"); 
            MySqlDataReader jeuEnr4 = null;
            try
            {
                maCnx4.Open();
                string requête4 = "SELECT * FROM periode";
                var maCde4 = new MySqlCommand(requête4, maCnx4);
                jeuEnr4 = maCde4.ExecuteReader();
                while (jeuEnr4.Read())
                {
                    int noperiode = jeuEnr4.GetInt32("noperiode");
                    string datedebut = jeuEnr4.GetDateTime("datedebut").ToShortDateString();
                    string datefin = jeuEnr4.GetDateTime("datefin").ToShortDateString();
                    cmbPeriode.Items.Add(new Periode(noperiode, datedebut, datefin));
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                jeuEnr4.Close();
                maCnx4.Close();
            }
        }

        private void btnAjouterSecteur_Click(object sender, EventArgs e)
        {

            MySqlConnection maCnxInsertTarif;
            maCnxInsertTarif = new MySqlConnection("server=localhost;user=root;database=atlantik;port=3306;password=");
            try
            {
                maCnxInsertTarif.Open();
                for (int i = 0; i < 8; i++)
                {
                    string lettrecategorie = "";
                    int notype = 0;
                    double tarif = 0;
                    switch (i)
                    {
                        case 0:
                            lettrecategorie = "A";
                            notype = 1;
                            tarif = double.Parse(tbxA1.Text);
                            break;
                        case 1:
                            lettrecategorie = "A";
                            notype = 2;
                            tarif = double.Parse(tbxA2.Text);
                            break;
                        case 2:
                            lettrecategorie = "A";
                            notype = 3;
                            tarif = double.Parse(tbxA3.Text);
                            break;
                        case 3:
                            lettrecategorie = "B";
                            notype = 1;
                            tarif = double.Parse(tbxB1.Text);
                            break;
                        case 4:
                            lettrecategorie = "B";
                            notype = 2;
                            tarif = double.Parse(tbxB2.Text);
                            break;
                        case 5:
                            lettrecategorie = "C";
                            notype = 1;
                            tarif = double.Parse(tbxC1.Text);
                            break;
                        case 6:
                            lettrecategorie = "C";
                            notype = 2;
                            tarif = double.Parse(tbxC2.Text);
                            break;
                        case 7:
                            lettrecategorie = "C";
                            notype = 3;
                            tarif = double.Parse(tbxC3.Text);
                            break;
                    }
                    string requête = "Insert into tarifer(noperiode, lettrecategorie, notype, noliaison, tarif) values (@noperiode, @lettrecategorie, @notype, @noliaison, @tarif)";
                    var maCde2 = new MySqlCommand(requête, maCnxInsertTarif);
                    maCde2.Parameters.AddWithValue("@noperiode", ((Periode)cmbPeriode.SelectedItem).GetNoPeriode());
                    maCde2.Parameters.AddWithValue("@noliaison", ((Liaison)cmbLiaison.SelectedItem).GetNo());
                    maCde2.Parameters.AddWithValue("@lettrecategorie", lettrecategorie);
                    maCde2.Parameters.AddWithValue("@notype", notype);
                    maCde2.Parameters.AddWithValue("@tarif", tarif);
                    maCde2.ExecuteNonQuery();
                    lblTarifCreer.Text = "Le tarif à été créer avec succès !";
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                tbxA1.Text = "";
                tbxA2.Text = "";
                tbxA3.Text = "";
                tbxB1.Text = "";
                tbxB2.Text = "";
                tbxC1.Text = "";
                tbxC2.Text = "";
                tbxC3.Text = "";
                if (maCnxInsertTarif is object & maCnxInsertTarif.State == ConnectionState.Open)
                {
                    maCnxInsertTarif.Close(); // on se déconnecte
                }
            }
        }
    }
}
