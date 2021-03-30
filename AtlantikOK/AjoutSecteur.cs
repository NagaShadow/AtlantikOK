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
    public partial class AjoutSecteur : Form
    {

        public AjoutSecteur()
        {
            InitializeComponent();
        }

        private void btnAjouterSecteur_Click(object sender, EventArgs e)
        {
            // COntrole de saisie avec la TextBox pour avoir uniquement des lettres //
            string TextSelection = tbxNomSecteur.Text;
            var objetRegEx = new Regex("^[a-zA-Zéèêëçàâôù ûïî]*$");
            var résultatTest = objetRegEx.Match(tbxNomSecteur.Text);

            if (!résultatTest.Success)
            {
                tbxNomSecteur.FillColor = Color.Red;
                MessageBox.Show("Entrée un nom correct (Ex : Bordeaux)");
            }
            else
            {
                tbxNomSecteur.FillColor = SystemColors.Control;
                MySqlConnection maCnx = new MySqlConnection("server=localhost;user=root;database=atlantikok;port=3306;password=");
                try
                {
                    maCnx.Open();
                    string requête = "Insert into secteur(nom) values (@TextSelection)";
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
                        maCnx.Close();
                    }
                }
            }
        }
    }
}
