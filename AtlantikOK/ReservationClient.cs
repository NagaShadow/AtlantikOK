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
    public partial class ReservationClient : Form
    {
        MySqlConnection maCnx = new MySqlConnection("server=localhost;user=root;database=atlantikok;port=3306;password=");
        public ReservationClient()
        {
            InitializeComponent();
        }

        private void ReservationClient_Load(object sender, EventArgs e)
        {
            MySqlDataReader jeuEnr = null;
            try
            {
                string requête;
                maCnx.Open();
                requête = "Select * from client";
                var maCde = new MySqlCommand(requête, maCnx);
                jeuEnr = maCde.ExecuteReader();
                while (jeuEnr.Read())
                {
                    cmbClient.Items.Add(new Client((int)jeuEnr["noclient"], (int)jeuEnr["codepostal"], (string)jeuEnr["nom"], (string)jeuEnr["prenom"], (string)jeuEnr["adresse"], (string)jeuEnr["ville"], (string)jeuEnr["telephonefixe"], (string)jeuEnr["telephonemobile"], (string)jeuEnr["mel"], (string)jeuEnr["motdepasse"]));
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

        private void cmbClient_SelectedIndexChanged(object sender, EventArgs e)
        {
            MySqlConnection maCnx;
            maCnx = new MySqlConnection("server=localhost;user=root;database=atlantikok;port=3306;password=");
            string requête = "SELECT * FROM traversee, reservation, liaison WHERE noclient = @noclient AND traversee.notraversee = reservation.notraversee AND liaison.noliaison = traversee.noliaison";
            MySqlDataReader jeuEnr = null;
            try
            {
                lvReservationClient.Clear();
                lvReservationClient.View = View.Details;
                lvReservationClient.GridLines = true;
                lvReservationClient.FullRowSelect = true;

                lvReservationClient.Columns.Add("N° Réservation", 70);
                lvReservationClient.Columns.Add("Liaison", 200);
                lvReservationClient.Columns.Add("N° Traversée", 70);
                lvReservationClient.Columns.Add("Date départ", 200);

                maCnx.Open();
                var maCde = new MySqlCommand(requête, maCnx);
                maCde.Parameters.AddWithValue("@noclient", ((Client)cmbClient.SelectedItem).GetNo());
                jeuEnr = maCde.ExecuteReader();
                MySqlConnection maCnx2;
                string requête2, nomdepart, nomarrivee;
                MySqlDataReader jeuEnr2 = null;

                while (jeuEnr.Read())
                {
                    maCnx2 = new MySqlConnection("server=localhost;user=root;database=atlantikok;port=3306;password=");
                    maCnx2.Open();
                    requête2 = "SELECT * FROM port, liaison WHERE port.noport = liaison.noport_depart AND liaison.noliaison = @noliaison";
                    var maCde2 = new MySqlCommand(requête2, maCnx2);
                    maCde2.Parameters.AddWithValue("@noliaison", (int)jeuEnr["noliaison"]);
                    jeuEnr2 = maCde2.ExecuteReader();
                    jeuEnr2.Read();
                    nomdepart = jeuEnr2["nom"].ToString();
                    jeuEnr2.Close();
                    maCnx2.Close();

                    MySqlConnection maCnx3;
                    maCnx3 = new MySqlConnection("server=localhost;user=root;database=atlantikok;port=3306;password=");
                    maCnx3.Open();
                    requête2 = "SELECT * FROM port, liaison WHERE port.noport = liaison.noport_arrivee AND liaison.noliaison = @noliaison";
                    var maCde3 = new MySqlCommand(requête2, maCnx3);
                    maCde3.Parameters.AddWithValue("@noliaison", (int)jeuEnr["noliaison"]);
                    jeuEnr2 = maCde3.ExecuteReader();
                    jeuEnr2.Read();
                    nomarrivee = jeuEnr2["nom"].ToString();
                    jeuEnr2.Close();
                    maCnx2.Close();
                    var tabItem = new string[5];
                    ListViewItem unItem;
                    tabItem[0] = ((int)jeuEnr["noreservation"]).ToString();
                    tabItem[1] = nomdepart + " - " + nomarrivee;
                    tabItem[2] = ((int)jeuEnr["notraversee"]).ToString();
                    tabItem[3] = ((DateTime)jeuEnr["dateheure"]).ToString("yyyy-MM-dd HH:mm:ss");
                    unItem = new ListViewItem(tabItem);
                    lvReservationClient.Items.Add(unItem);
                }

            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                jeuEnr.Close();
                maCnx.Close();
            }
        }

        private void lvReservationClient_SelectedIndexChanged(object sender, EventArgs e)
        {
            MySqlConnection maCnx;
            maCnx = new MySqlConnection("server=localhost;user=root;database=atlantikok;port=3306;password=");
            MySqlDataReader jeuEnr = null;
            try
            {
                maCnx.Open();
                string requete = "SELECT * FROM enregistrer, reservation WHERE reservation.noreservation = enregistrer.noreservation";
                var maCde = new MySqlCommand(requete, maCnx);
                jeuEnr = maCde.ExecuteReader();
                while (jeuEnr.Read())
                {
                    MySqlConnection maCnx2;
                    maCnx2 = new MySqlConnection("server=localhost;user=root;database=atlantikok;port=3306;password=");
                    MySqlDataReader jeuEnr2 = null;
                    try
                    {
                        maCnx2.Open();
                        for (int i = 0; i < 4; i++)
                        {
                            string lettrecategorie = "";
                            int notype = 0;
                            switch (i)
                            {
                                case 0:
                                    lettrecategorie = "A";
                                    notype = 1;
                                    break;
                                case 1:
                                    lettrecategorie = "A";
                                    notype = 2;
                                    break;
                                case 2:
                                    lettrecategorie = "A";
                                    notype = 3;
                                    break;
                                case 4:
                                    lettrecategorie = "B";
                                    notype = 2;
                                    break;
                            }
                            string requête2 = "SELECT * FROM enregistrer WHERE lettrecategorie = @lettrecategorie AND notype = @notype";
                            var maCde2 = new MySqlCommand(requête2, maCnx2);
                            maCde2.Parameters.AddWithValue("@lettrecategorie", lettrecategorie);
                            maCde2.Parameters.AddWithValue("@notype", notype);
                            jeuEnr2 = maCde2.ExecuteReader();
                            while (jeuEnr2.Read())
                                {
                                int quantite = (int)jeuEnr2["quantite"];
                                switch (i)
                                {
                                    case 0:
                                        lblAdulteNombre.Text = quantite.ToString();
                                        break;

                                    case 1:
                                        lblJuniorNombre.Text = quantite.ToString();
                                        break;

                                    case 2:
                                        lblEnfantNombre.Text = quantite.ToString();
                                        break;

                                    case 3:
                                        LblVoiture.Text = quantite.ToString();
                                        break;
                                }
                            }
                            jeuEnr2.Close();
                        }
                        lblRegler.Text = (string)jeuEnr["modereglement"];
                        lblMontantTotalNombre.Text = ((double)jeuEnr["montanttotal"]).ToString() + " €";
                    }


                    catch (MySqlException ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                    finally
                    {
                        if (maCnx2 is object & maCnx2.State == ConnectionState.Open)
                        {
                            maCnx2.Close(); // on se déconnecte
                        }
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                jeuEnr.Close();
                maCnx.Close();
            }
        }
    }
}
