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
    public partial class ListerTraversee : Form
    {
        MySqlConnection maCnx = new MySqlConnection("server=localhost;user=root;database=atlantik;port=3306;password=");
        public ListerTraversee()
        {
            InitializeComponent();
        }

        private void ListerTraversee_Load(object sender, EventArgs e)
        {
            DatePicker.Value = DateTime.Now;
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
        private void btnListerTraverser_Click(object sender, EventArgs e)
        {
            lvTraversee.Items.Clear();
            lvTraversee.Columns.Clear();
            MySqlDataReader jeuEnr = null;
            try
            {
                lvTraversee.View = View.Details;
                lvTraversee.GridLines = true;
                lvTraversee.FullRowSelect = true;
                maCnx.Open();
                string requête = "SELECT * FROM traversee,bateau,secteur,port,liaison WHERE  liaison.noport_depart = port.noport AND port.nosecteur = secteur.nosecteur AND secteur.nosecteur = @nosecteur AND traversee.nobateau = bateau.nobateau AND dateheuredepart >= @date1 AND dateheuredepart <= @date2 AND traversee.noliaison = @noliaison GROUP BY traversee.nobateau";
                var maCde = new MySqlCommand(requête, maCnx);
                maCde.Parameters.AddWithValue("@nosecteur", ((Secteur)lbxSecteurs.SelectedItem).GetNo());
                maCde.Parameters.AddWithValue("@date1", DatePicker.Value.Date.ToString("yyyy-MM-dd 00:00:00"));
                maCde.Parameters.AddWithValue("@date2", DatePicker.Value.Date.ToString("yyyy-MM-dd 23:59:59"));
                maCde.Parameters.AddWithValue("@noliaison", ((Liaison)cmbLiaison.SelectedItem).GetNo());
                jeuEnr = maCde.ExecuteReader();

                lvTraversee.Columns.Add("N° Traversée", 106);
                lvTraversee.Columns.Add("Heure", 106);
                lvTraversee.Columns.Add("Bateau", 106);
                lvTraversee.Columns.Add("A - Passager", 106);
                lvTraversee.Columns.Add("B - Véhicules < 2 m", 106);
                lvTraversee.Columns.Add("C - Véhicules > 2 m", 106);

                MySqlConnection maCnx2;
                string requête2;
                int i;

                while (jeuEnr.Read())
                {
                    maCnx2 = new MySqlConnection("server=localhost;user=root;database=atlantik;port=3306;password=");
                    MySqlDataReader jeuEnr2 = null;
                    requête2 = "SELECT * FROM bateau, contenir WHERE bateau.nobateau = contenir.nobateau AND bateau.nobateau = @bateau";
                    maCnx2.Open();
                    var maCde2 = new MySqlCommand(requête2, maCnx2);
                    maCde2.Parameters.AddWithValue("@bateau", (int)jeuEnr["nobateau"]);
                    jeuEnr2 = maCde2.ExecuteReader();
                    var tabItem = new string[6];
                    ListViewItem unItem;
                    tabItem[0] = ((int)jeuEnr["notraversee"]).ToString();
                    tabItem[1] = ((DateTime)jeuEnr["dateheuredepart"]).ToString("HH:mm:ss");
                    tabItem[2] = (string)jeuEnr["nom"];
                    i = 3;
                    while (jeuEnr2.Read())
                    {
                        tabItem[i] = ((int)jeuEnr2["capacitemax"]).ToString();
                        i = i + 1;
                    }
                    jeuEnr2.Close();
                    maCnx2.Close();
                    unItem = new ListViewItem(tabItem);
                    lvTraversee.Items.Add(unItem);
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
                    jeuEnr.Close(); // s'il existe et n'est pas déjà fermé
                }
                if (maCnx is object & maCnx.State == ConnectionState.Open)
                {
                    maCnx.Close(); // on se déconnecte
                }
            }
        }
    }
}
