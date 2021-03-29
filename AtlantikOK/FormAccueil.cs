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
    public partial class FormAccueil : Form
    {
        public FormAccueil()
        {
            InitializeComponent();
        }
        private void FormAccueil_Load(object sender, EventArgs e)
        {
            PanelMain.Controls.Clear();
            Image myimage = new Bitmap(@"C:\1 - Cours Julien\Projet AtlantikOK\PageAccueil.png");
            PanelMain.BackgroundImage = myimage;
            btnCreateBateau.Visible = false;
            btnModifBateau.Visible = false;
        }
        private void btnAccueil_Click(object sender, EventArgs e)
        {
            PanelMain.Controls.Clear();
            Image myimage = new Bitmap(@"C:\1 - Cours Julien\Projet AtlantikOK\PageAccueil.png");
            PanelMain.BackgroundImage = myimage;
        }

        private void btnMenuAjoutSecteur_Click(object sender, EventArgs e)
        {
            PanelMain.Controls.Clear();
            AjoutSecteur form = new AjoutSecteur();
            form.TopLevel = false;
            PanelMain.Controls.Add(form);
            form.Show();
        }

        private void btnMenuAjoutPort_Click(object sender, EventArgs e)
        {
            PanelMain.Controls.Clear();
            AjoutPort form = new AjoutPort();
            form.TopLevel = false;
            PanelMain.Controls.Add(form);
            form.Show();
        }
        private void btnMenuCreateLiaison_Click(object sender, EventArgs e)
        {
            PanelMain.Controls.Clear();
            CreerLiaison form = new CreerLiaison();
            form.TopLevel = false;
            PanelMain.Controls.Add(form);
            form.Show();
        }

        private void btnMenuCreateModifTarif_Click(object sender, EventArgs e)
        {
            PanelMain.Controls.Clear();
            CreateModifTarif form = new CreateModifTarif();
            form.TopLevel = false;
            PanelMain.Controls.Add(form);
            form.Show();
        }

        private async void btnMenuCreateBateau_MouseHover(object sender, EventArgs e)
        {
            btnCreateBateau.Visible = true;
            btnModifBateau.Visible = true;
            await Task.Delay(2000);
            btnCreateBateau.Visible = false;
            btnModifBateau.Visible = false;
        }

        private void BtnCreateBateau_Click(object sender, EventArgs e)
        {
            PanelMain.Controls.Clear();
            CreateBateau form = new CreateBateau();
            form.TopLevel = false;
            PanelMain.Controls.Add(form);
            form.Show();
        }

        private void BtnModifBateau_Click(object sender, EventArgs e)
        {
            PanelMain.Controls.Clear();
            ModifBateau form = new ModifBateau();
            form.TopLevel = false;
            PanelMain.Controls.Add(form);
            form.Show();
        }

        private void btnMenuCreerTraverser_Click(object sender, EventArgs e)
        {
            PanelMain.Controls.Clear();
            CreerTraversee form = new CreerTraversee();
            form.TopLevel = false;
            PanelMain.Controls.Add(form);
            form.Show();
        }
        private void btnMenuListerLaisons_Click(object sender, EventArgs e)
        {
            PanelMain.Controls.Clear();
            ListerTraversee form = new ListerTraversee();
            form.TopLevel = false;
            PanelMain.Controls.Add(form);
            form.Show();
        }

        private void btnMenuReservationClient_Click(object sender, EventArgs e)
        {
            PanelMain.Controls.Clear();
            ReservationClient form = new ReservationClient();
            form.TopLevel = false;
            PanelMain.Controls.Add(form);
            form.Show();
        }
        private void btnMenuParametreSite_Click(object sender, EventArgs e)
        {
            PanelMain.Controls.Clear();
            ParametreSite form = new ParametreSite();
            form.TopLevel = false;
            PanelMain.Controls.Add(form);
            form.Show();
        }
    }
}
