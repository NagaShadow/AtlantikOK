
namespace AtlantikOK
{
    partial class FormAccueil
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.DragControl = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.PanelDrag = new Guna.UI2.WinForms.Guna2Panel();
            this.btnAccueil = new Guna.UI2.WinForms.Guna2Button();
            this.guna2ControlBox2 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ControlBox3 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.PanelMenu = new Guna.UI2.WinForms.Guna2Panel();
            this.btnMenuAjoutPort = new Guna.UI2.WinForms.Guna2Button();
            this.btnMenuAjoutSecteur = new Guna.UI2.WinForms.Guna2Button();
            this.btnMenuCreateBateau = new Guna.UI2.WinForms.Guna2Button();
            this.btnMenuParametreSite = new Guna.UI2.WinForms.Guna2Button();
            this.btnMenuCreerTraverser = new Guna.UI2.WinForms.Guna2Button();
            this.btnMenuCreateModifTarif = new Guna.UI2.WinForms.Guna2Button();
            this.btnMenuReservationClient = new Guna.UI2.WinForms.Guna2Button();
            this.btnMenuListerLaisons = new Guna.UI2.WinForms.Guna2Button();
            this.btnMenuCreateLiaison = new Guna.UI2.WinForms.Guna2Button();
            this.PanelMain = new Guna.UI2.WinForms.Guna2Panel();
            this.btnModifBateau = new Guna.UI2.WinForms.Guna2Button();
            this.btnCreateBateau = new Guna.UI2.WinForms.Guna2Button();
            this.PanelDrag.SuspendLayout();
            this.PanelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // DragControl
            // 
            this.DragControl.ContainerControl = this;
            this.DragControl.DockIndicatorColor = System.Drawing.Color.Black;
            this.DragControl.TargetControl = this.PanelDrag;
            this.DragControl.TransparentWhileDrag = true;
            this.DragControl.UseTransparentDrag = true;
            // 
            // PanelDrag
            // 
            this.PanelDrag.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.PanelDrag.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.PanelDrag.BorderRadius = 1;
            this.PanelDrag.BorderThickness = 1;
            this.PanelDrag.Controls.Add(this.btnAccueil);
            this.PanelDrag.Controls.Add(this.guna2ControlBox2);
            this.PanelDrag.Controls.Add(this.guna2ControlBox3);
            this.PanelDrag.Controls.Add(this.guna2ControlBox1);
            this.PanelDrag.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelDrag.Location = new System.Drawing.Point(0, 0);
            this.PanelDrag.Name = "PanelDrag";
            this.PanelDrag.ShadowDecoration.Parent = this.PanelDrag;
            this.PanelDrag.Size = new System.Drawing.Size(1280, 30);
            this.PanelDrag.TabIndex = 3;
            // 
            // btnAccueil
            // 
            this.btnAccueil.BackColor = System.Drawing.Color.Transparent;
            this.btnAccueil.BackgroundImage = global::AtlantikOK.Properties.Resources.LogoAccueil;
            this.btnAccueil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAccueil.CheckedState.Parent = this.btnAccueil;
            this.btnAccueil.CustomImages.Parent = this.btnAccueil;
            this.btnAccueil.FillColor = System.Drawing.Color.Transparent;
            this.btnAccueil.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAccueil.ForeColor = System.Drawing.Color.Transparent;
            this.btnAccueil.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.btnAccueil.HoverState.Parent = this.btnAccueil;
            this.btnAccueil.Location = new System.Drawing.Point(11, 4);
            this.btnAccueil.Name = "btnAccueil";
            this.btnAccueil.PressedColor = System.Drawing.Color.Transparent;
            this.btnAccueil.ShadowDecoration.Parent = this.btnAccueil;
            this.btnAccueil.Size = new System.Drawing.Size(180, 23);
            this.btnAccueil.TabIndex = 3;
            this.btnAccueil.Click += new System.EventHandler(this.btnAccueil_Click);
            // 
            // guna2ControlBox2
            // 
            this.guna2ControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox2.BackColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox2.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MaximizeBox;
            this.guna2ControlBox2.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox2.HoverState.Parent = this.guna2ControlBox2;
            this.guna2ControlBox2.IconColor = System.Drawing.Color.Black;
            this.guna2ControlBox2.Location = new System.Drawing.Point(1185, 0);
            this.guna2ControlBox2.Name = "guna2ControlBox2";
            this.guna2ControlBox2.ShadowDecoration.Parent = this.guna2ControlBox2;
            this.guna2ControlBox2.Size = new System.Drawing.Size(45, 29);
            this.guna2ControlBox2.TabIndex = 1;
            // 
            // guna2ControlBox3
            // 
            this.guna2ControlBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox3.BackColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox3.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.guna2ControlBox3.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox3.HoverState.Parent = this.guna2ControlBox3;
            this.guna2ControlBox3.IconColor = System.Drawing.Color.Black;
            this.guna2ControlBox3.Location = new System.Drawing.Point(1137, 0);
            this.guna2ControlBox3.Name = "guna2ControlBox3";
            this.guna2ControlBox3.ShadowDecoration.Parent = this.guna2ControlBox3;
            this.guna2ControlBox3.Size = new System.Drawing.Size(45, 29);
            this.guna2ControlBox3.TabIndex = 2;
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox1.HoverState.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.Black;
            this.guna2ControlBox1.Location = new System.Drawing.Point(1233, 0);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.ShadowDecoration.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.Size = new System.Drawing.Size(45, 29);
            this.guna2ControlBox1.TabIndex = 0;
            // 
            // PanelMenu
            // 
            this.PanelMenu.BackColor = System.Drawing.SystemColors.ControlDark;
            this.PanelMenu.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.PanelMenu.Controls.Add(this.btnMenuAjoutPort);
            this.PanelMenu.Controls.Add(this.btnMenuAjoutSecteur);
            this.PanelMenu.Controls.Add(this.btnMenuCreateBateau);
            this.PanelMenu.Controls.Add(this.btnMenuParametreSite);
            this.PanelMenu.Controls.Add(this.btnMenuCreerTraverser);
            this.PanelMenu.Controls.Add(this.btnMenuCreateModifTarif);
            this.PanelMenu.Controls.Add(this.btnMenuReservationClient);
            this.PanelMenu.Controls.Add(this.btnMenuListerLaisons);
            this.PanelMenu.Controls.Add(this.btnMenuCreateLiaison);
            this.PanelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelMenu.Location = new System.Drawing.Point(0, 30);
            this.PanelMenu.Name = "PanelMenu";
            this.PanelMenu.ShadowDecoration.Parent = this.PanelMenu;
            this.PanelMenu.Size = new System.Drawing.Size(200, 690);
            this.PanelMenu.TabIndex = 4;
            // 
            // btnMenuAjoutPort
            // 
            this.btnMenuAjoutPort.CheckedState.Parent = this.btnMenuAjoutPort;
            this.btnMenuAjoutPort.CustomImages.Parent = this.btnMenuAjoutPort;
            this.btnMenuAjoutPort.FillColor = System.Drawing.Color.Transparent;
            this.btnMenuAjoutPort.Font = new System.Drawing.Font("Miriam CLM", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnMenuAjoutPort.ForeColor = System.Drawing.Color.White;
            this.btnMenuAjoutPort.HoverState.Parent = this.btnMenuAjoutPort;
            this.btnMenuAjoutPort.Location = new System.Drawing.Point(0, 66);
            this.btnMenuAjoutPort.Name = "btnMenuAjoutPort";
            this.btnMenuAjoutPort.ShadowDecoration.Parent = this.btnMenuAjoutPort;
            this.btnMenuAjoutPort.Size = new System.Drawing.Size(200, 69);
            this.btnMenuAjoutPort.TabIndex = 1;
            this.btnMenuAjoutPort.Text = "Ajout De Port";
            this.btnMenuAjoutPort.Click += new System.EventHandler(this.btnMenuAjoutPort_Click);
            // 
            // btnMenuAjoutSecteur
            // 
            this.btnMenuAjoutSecteur.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnMenuAjoutSecteur.CheckedState.Parent = this.btnMenuAjoutSecteur;
            this.btnMenuAjoutSecteur.CustomImages.Parent = this.btnMenuAjoutSecteur;
            this.btnMenuAjoutSecteur.FillColor = System.Drawing.Color.Transparent;
            this.btnMenuAjoutSecteur.Font = new System.Drawing.Font("Miriam CLM", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnMenuAjoutSecteur.ForeColor = System.Drawing.Color.White;
            this.btnMenuAjoutSecteur.HoverState.Parent = this.btnMenuAjoutSecteur;
            this.btnMenuAjoutSecteur.Location = new System.Drawing.Point(0, 0);
            this.btnMenuAjoutSecteur.Name = "btnMenuAjoutSecteur";
            this.btnMenuAjoutSecteur.ShadowDecoration.Parent = this.btnMenuAjoutSecteur;
            this.btnMenuAjoutSecteur.Size = new System.Drawing.Size(200, 69);
            this.btnMenuAjoutSecteur.TabIndex = 0;
            this.btnMenuAjoutSecteur.Text = "Ajout Secteur";
            this.btnMenuAjoutSecteur.Click += new System.EventHandler(this.btnMenuAjoutSecteur_Click);
            // 
            // btnMenuCreateBateau
            // 
            this.btnMenuCreateBateau.CheckedState.Parent = this.btnMenuCreateBateau;
            this.btnMenuCreateBateau.CustomImages.Parent = this.btnMenuCreateBateau;
            this.btnMenuCreateBateau.FillColor = System.Drawing.Color.Transparent;
            this.btnMenuCreateBateau.Font = new System.Drawing.Font("Miriam CLM", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnMenuCreateBateau.ForeColor = System.Drawing.Color.White;
            this.btnMenuCreateBateau.HoverState.Parent = this.btnMenuCreateBateau;
            this.btnMenuCreateBateau.Location = new System.Drawing.Point(0, 276);
            this.btnMenuCreateBateau.Name = "btnMenuCreateBateau";
            this.btnMenuCreateBateau.ShadowDecoration.Parent = this.btnMenuCreateBateau;
            this.btnMenuCreateBateau.Size = new System.Drawing.Size(200, 69);
            this.btnMenuCreateBateau.TabIndex = 4;
            this.btnMenuCreateBateau.Text = "Créer/Modifier un Bateau";
            this.btnMenuCreateBateau.MouseHover += new System.EventHandler(this.btnMenuCreateBateau_MouseHover);
            // 
            // btnMenuParametreSite
            // 
            this.btnMenuParametreSite.CheckedState.Parent = this.btnMenuParametreSite;
            this.btnMenuParametreSite.CustomImages.Parent = this.btnMenuParametreSite;
            this.btnMenuParametreSite.FillColor = System.Drawing.Color.Transparent;
            this.btnMenuParametreSite.Font = new System.Drawing.Font("Miriam CLM", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnMenuParametreSite.ForeColor = System.Drawing.Color.White;
            this.btnMenuParametreSite.HoverState.Parent = this.btnMenuParametreSite;
            this.btnMenuParametreSite.Location = new System.Drawing.Point(0, 552);
            this.btnMenuParametreSite.Name = "btnMenuParametreSite";
            this.btnMenuParametreSite.ShadowDecoration.Parent = this.btnMenuParametreSite;
            this.btnMenuParametreSite.Size = new System.Drawing.Size(200, 69);
            this.btnMenuParametreSite.TabIndex = 9;
            this.btnMenuParametreSite.Text = "Paramètres du Site";
            this.btnMenuParametreSite.Click += new System.EventHandler(this.btnMenuParametreSite_Click);
            // 
            // btnMenuCreerTraverser
            // 
            this.btnMenuCreerTraverser.CheckedState.Parent = this.btnMenuCreerTraverser;
            this.btnMenuCreerTraverser.CustomImages.Parent = this.btnMenuCreerTraverser;
            this.btnMenuCreerTraverser.FillColor = System.Drawing.Color.Transparent;
            this.btnMenuCreerTraverser.Font = new System.Drawing.Font("Miriam CLM", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnMenuCreerTraverser.ForeColor = System.Drawing.Color.White;
            this.btnMenuCreerTraverser.HoverState.Parent = this.btnMenuCreerTraverser;
            this.btnMenuCreerTraverser.Location = new System.Drawing.Point(0, 345);
            this.btnMenuCreerTraverser.Name = "btnMenuCreerTraverser";
            this.btnMenuCreerTraverser.ShadowDecoration.Parent = this.btnMenuCreerTraverser;
            this.btnMenuCreerTraverser.Size = new System.Drawing.Size(200, 69);
            this.btnMenuCreerTraverser.TabIndex = 6;
            this.btnMenuCreerTraverser.Text = "Créer Traversée";
            this.btnMenuCreerTraverser.Click += new System.EventHandler(this.btnMenuCreerTraverser_Click);
            // 
            // btnMenuCreateModifTarif
            // 
            this.btnMenuCreateModifTarif.CheckedState.Parent = this.btnMenuCreateModifTarif;
            this.btnMenuCreateModifTarif.CustomImages.Parent = this.btnMenuCreateModifTarif;
            this.btnMenuCreateModifTarif.FillColor = System.Drawing.Color.Transparent;
            this.btnMenuCreateModifTarif.Font = new System.Drawing.Font("Miriam CLM", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnMenuCreateModifTarif.ForeColor = System.Drawing.Color.White;
            this.btnMenuCreateModifTarif.HoverState.Parent = this.btnMenuCreateModifTarif;
            this.btnMenuCreateModifTarif.Location = new System.Drawing.Point(0, 207);
            this.btnMenuCreateModifTarif.Name = "btnMenuCreateModifTarif";
            this.btnMenuCreateModifTarif.ShadowDecoration.Parent = this.btnMenuCreateModifTarif;
            this.btnMenuCreateModifTarif.Size = new System.Drawing.Size(200, 69);
            this.btnMenuCreateModifTarif.TabIndex = 3;
            this.btnMenuCreateModifTarif.Text = "Créer/Modifier Tarif";
            this.btnMenuCreateModifTarif.Click += new System.EventHandler(this.btnMenuCreateModifTarif_Click);
            // 
            // btnMenuReservationClient
            // 
            this.btnMenuReservationClient.CheckedState.Parent = this.btnMenuReservationClient;
            this.btnMenuReservationClient.CustomImages.Parent = this.btnMenuReservationClient;
            this.btnMenuReservationClient.FillColor = System.Drawing.Color.Transparent;
            this.btnMenuReservationClient.Font = new System.Drawing.Font("Miriam CLM", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnMenuReservationClient.ForeColor = System.Drawing.Color.White;
            this.btnMenuReservationClient.HoverState.Parent = this.btnMenuReservationClient;
            this.btnMenuReservationClient.Location = new System.Drawing.Point(0, 483);
            this.btnMenuReservationClient.Name = "btnMenuReservationClient";
            this.btnMenuReservationClient.ShadowDecoration.Parent = this.btnMenuReservationClient;
            this.btnMenuReservationClient.Size = new System.Drawing.Size(200, 69);
            this.btnMenuReservationClient.TabIndex = 8;
            this.btnMenuReservationClient.Text = "Réservation Client";
            this.btnMenuReservationClient.Click += new System.EventHandler(this.btnMenuReservationClient_Click);
            // 
            // btnMenuListerLaisons
            // 
            this.btnMenuListerLaisons.CheckedState.Parent = this.btnMenuListerLaisons;
            this.btnMenuListerLaisons.CustomImages.Parent = this.btnMenuListerLaisons;
            this.btnMenuListerLaisons.FillColor = System.Drawing.Color.Transparent;
            this.btnMenuListerLaisons.Font = new System.Drawing.Font("Miriam CLM", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnMenuListerLaisons.ForeColor = System.Drawing.Color.White;
            this.btnMenuListerLaisons.HoverState.Parent = this.btnMenuListerLaisons;
            this.btnMenuListerLaisons.Location = new System.Drawing.Point(0, 414);
            this.btnMenuListerLaisons.Name = "btnMenuListerLaisons";
            this.btnMenuListerLaisons.ShadowDecoration.Parent = this.btnMenuListerLaisons;
            this.btnMenuListerLaisons.Size = new System.Drawing.Size(200, 69);
            this.btnMenuListerLaisons.TabIndex = 7;
            this.btnMenuListerLaisons.Text = "Lister les traversées de la Journée";
            this.btnMenuListerLaisons.Click += new System.EventHandler(this.btnMenuListerLaisons_Click);
            // 
            // btnMenuCreateLiaison
            // 
            this.btnMenuCreateLiaison.CheckedState.Parent = this.btnMenuCreateLiaison;
            this.btnMenuCreateLiaison.CustomImages.Parent = this.btnMenuCreateLiaison;
            this.btnMenuCreateLiaison.FillColor = System.Drawing.Color.Transparent;
            this.btnMenuCreateLiaison.Font = new System.Drawing.Font("Miriam CLM", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnMenuCreateLiaison.ForeColor = System.Drawing.Color.White;
            this.btnMenuCreateLiaison.HoverState.Parent = this.btnMenuCreateLiaison;
            this.btnMenuCreateLiaison.Location = new System.Drawing.Point(0, 138);
            this.btnMenuCreateLiaison.Name = "btnMenuCreateLiaison";
            this.btnMenuCreateLiaison.ShadowDecoration.Parent = this.btnMenuCreateLiaison;
            this.btnMenuCreateLiaison.Size = new System.Drawing.Size(200, 69);
            this.btnMenuCreateLiaison.TabIndex = 2;
            this.btnMenuCreateLiaison.Text = "Créer une Liaison";
            this.btnMenuCreateLiaison.Click += new System.EventHandler(this.btnMenuCreateLiaison_Click);
            // 
            // PanelMain
            // 
            this.PanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelMain.Location = new System.Drawing.Point(200, 30);
            this.PanelMain.Name = "PanelMain";
            this.PanelMain.ShadowDecoration.Parent = this.PanelMain;
            this.PanelMain.Size = new System.Drawing.Size(1080, 690);
            this.PanelMain.TabIndex = 6;
            // 
            // btnModifBateau
            // 
            this.btnModifBateau.CheckedState.Parent = this.btnModifBateau;
            this.btnModifBateau.CustomImages.Parent = this.btnModifBateau;
            this.btnModifBateau.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnModifBateau.ForeColor = System.Drawing.Color.White;
            this.btnModifBateau.HoverState.Parent = this.btnModifBateau;
            this.btnModifBateau.Location = new System.Drawing.Point(200, 341);
            this.btnModifBateau.Name = "btnModifBateau";
            this.btnModifBateau.ShadowDecoration.Parent = this.btnModifBateau;
            this.btnModifBateau.Size = new System.Drawing.Size(180, 45);
            this.btnModifBateau.TabIndex = 1;
            this.btnModifBateau.Text = "Modifier un Bateau";
            this.btnModifBateau.Click += new System.EventHandler(this.BtnModifBateau_Click);
            // 
            // btnCreateBateau
            // 
            this.btnCreateBateau.CheckedState.Parent = this.btnCreateBateau;
            this.btnCreateBateau.CustomImages.Parent = this.btnCreateBateau;
            this.btnCreateBateau.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCreateBateau.ForeColor = System.Drawing.Color.White;
            this.btnCreateBateau.HoverState.Parent = this.btnCreateBateau;
            this.btnCreateBateau.Location = new System.Drawing.Point(200, 296);
            this.btnCreateBateau.Name = "btnCreateBateau";
            this.btnCreateBateau.ShadowDecoration.Parent = this.btnCreateBateau;
            this.btnCreateBateau.Size = new System.Drawing.Size(180, 45);
            this.btnCreateBateau.TabIndex = 7;
            this.btnCreateBateau.Text = "Creer un Bateau";
            this.btnCreateBateau.Click += new System.EventHandler(this.BtnCreateBateau_Click);
            // 
            // FormAccueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.btnCreateBateau);
            this.Controls.Add(this.btnModifBateau);
            this.Controls.Add(this.PanelMain);
            this.Controls.Add(this.PanelMenu);
            this.Controls.Add(this.PanelDrag);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAccueil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Accueil";
            this.Load += new System.EventHandler(this.FormAccueil_Load);
            this.PanelDrag.ResumeLayout(false);
            this.PanelMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
        private Guna.UI2.WinForms.Guna2DragControl DragControl;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox3;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox2;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Guna.UI2.WinForms.Guna2Panel PanelDrag;
        private Guna.UI2.WinForms.Guna2Panel PanelMenu;
        private Guna.UI2.WinForms.Guna2Button btnMenuReservationClient;
        private Guna.UI2.WinForms.Guna2Button btnMenuListerLaisons;
        private Guna.UI2.WinForms.Guna2Button btnMenuCreerTraverser;
        private Guna.UI2.WinForms.Guna2Button btnMenuCreateBateau;
        private Guna.UI2.WinForms.Guna2Button btnMenuCreateModifTarif;
        private Guna.UI2.WinForms.Guna2Panel PanelMain;
        private Guna.UI2.WinForms.Guna2Button btnMenuAjoutPort;
        private Guna.UI2.WinForms.Guna2Button btnMenuAjoutSecteur;
        private Guna.UI2.WinForms.Guna2Button btnMenuCreateLiaison;
        private Guna.UI2.WinForms.Guna2Button btnAccueil;
        private Guna.UI2.WinForms.Guna2Button btnModifBateau;
        private Guna.UI2.WinForms.Guna2Button btnCreateBateau;
        private Guna.UI2.WinForms.Guna2Button btnMenuParametreSite;
    }
}

