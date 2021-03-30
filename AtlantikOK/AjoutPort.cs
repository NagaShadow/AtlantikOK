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
using System.Text.RegularExpressions;

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
            // On prends tout les secteurs contenu dans Secteur et on les ajoute dans la ListBox //
            MySqlConnection CnxSecteurs = new MySqlConnection("server=localhost;user=root;database=atlantik;port=3306;password=");
            MySqlDataReader jeuEnr = null;
            try
            {
                CnxSecteurs.Open();
                string requête = "Select * from secteur";
                var maCde = new MySqlCommand(requête, CnxSecteurs);
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
                jeuEnr.Close();
                CnxSecteurs.Close();
            }
        }

        private void btnAjouterPort_Click(object sender, EventArgs e)
        {
            // Controle de saisie sur la TextBox du Port //
            var objetRegEx = new Regex("^[a-zA-Zéèêëçàâôù ûïî]*$"); 
            var résultatTest = objetRegEx.Match(tbxNomPort.Text);
            // On ajout dans la DTB le port //



            if (résultatTest.Success)
            {
                tbxNomPort.FillColor = SystemColors.Control;
                MySqlConnection CnxInsertPort = new MySqlConnection("server=localhost;user=root;database=atlantik;port=3306;password=");
                try
                {
                    CnxInsertPort.Open();
                    string requête = "Insert into port(nosecteur, nom) values (@lbxSelectionne, @TextSelection)";
                    var maCde = new MySqlCommand(requête, CnxInsertPort);
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
                    tbxNomPort.Text = "";
                    lblPortAjouter.Text = "Ajout effectué avec succès !";
                    CnxInsertPort.Close();
                }
            }
            // Si la condition n'est pas remplis, on informe l'utilisateur de rentrer un nom correct //
            else
            {
                tbxNomPort.FillColor = Color.Red;
                MessageBox.Show("Entrée un nom correct (Ex : Bordeaux)");
            }

        }
    }
}
