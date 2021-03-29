
namespace AtlantikOK
{
    partial class CreerLiaison
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbxSecteurs = new System.Windows.Forms.ListBox();
            this.btnAjouterSecteur = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.cmbDepart = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cmbArriver = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2HtmlLabel5 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel6 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.tbxDistance = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblLiaisonCreer = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.SuspendLayout();
            // 
            // lbxSecteurs
            // 
            this.lbxSecteurs.BackColor = System.Drawing.SystemColors.Control;
            this.lbxSecteurs.FormattingEnabled = true;
            this.lbxSecteurs.Location = new System.Drawing.Point(38, 156);
            this.lbxSecteurs.Name = "lbxSecteurs";
            this.lbxSecteurs.Size = new System.Drawing.Size(245, 381);
            this.lbxSecteurs.TabIndex = 0;
            this.lbxSecteurs.SelectedIndexChanged += new System.EventHandler(this.lbxSecteurs_SelectedIndexChanged);
            // 
            // btnAjouterSecteur
            // 
            this.btnAjouterSecteur.BorderRadius = 22;
            this.btnAjouterSecteur.CheckedState.Parent = this.btnAjouterSecteur;
            this.btnAjouterSecteur.CustomImages.Parent = this.btnAjouterSecteur;
            this.btnAjouterSecteur.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnAjouterSecteur.ForeColor = System.Drawing.Color.White;
            this.btnAjouterSecteur.HoverState.Parent = this.btnAjouterSecteur;
            this.btnAjouterSecteur.Location = new System.Drawing.Point(315, 341);
            this.btnAjouterSecteur.Name = "btnAjouterSecteur";
            this.btnAjouterSecteur.ShadowDecoration.Parent = this.btnAjouterSecteur;
            this.btnAjouterSecteur.Size = new System.Drawing.Size(180, 45);
            this.btnAjouterSecteur.TabIndex = 14;
            this.btnAjouterSecteur.Text = "Créer";
            this.btnAjouterSecteur.Click += new System.EventHandler(this.btnAjouterSecteur_Click);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.FillColor = System.Drawing.Color.Black;
            this.guna2Panel1.Location = new System.Drawing.Point(38, 72);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(275, 3);
            this.guna2Panel1.TabIndex = 11;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(38, 26);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(276, 39);
            this.guna2HtmlLabel1.TabIndex = 10;
            this.guna2HtmlLabel1.Text = "Créer une Liaison";
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(38, 107);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(106, 26);
            this.guna2HtmlLabel3.TabIndex = 15;
            this.guna2HtmlLabel3.Text = "Secteurs : ";
            // 
            // guna2HtmlLabel4
            // 
            this.guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel4.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel4.Location = new System.Drawing.Point(315, 160);
            this.guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            this.guna2HtmlLabel4.Size = new System.Drawing.Size(83, 26);
            this.guna2HtmlLabel4.TabIndex = 16;
            this.guna2HtmlLabel4.Text = "Départ : ";
            // 
            // cmbDepart
            // 
            this.cmbDepart.BackColor = System.Drawing.Color.Transparent;
            this.cmbDepart.BorderColor = System.Drawing.Color.Black;
            this.cmbDepart.BorderRadius = 18;
            this.cmbDepart.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbDepart.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDepart.FillColor = System.Drawing.SystemColors.Control;
            this.cmbDepart.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbDepart.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbDepart.FocusedState.Parent = this.cmbDepart;
            this.cmbDepart.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbDepart.ForeColor = System.Drawing.Color.Black;
            this.cmbDepart.HoverState.Parent = this.cmbDepart;
            this.cmbDepart.ItemHeight = 30;
            this.cmbDepart.ItemsAppearance.Parent = this.cmbDepart;
            this.cmbDepart.Location = new System.Drawing.Point(435, 156);
            this.cmbDepart.Name = "cmbDepart";
            this.cmbDepart.ShadowDecoration.Parent = this.cmbDepart;
            this.cmbDepart.Size = new System.Drawing.Size(203, 36);
            this.cmbDepart.TabIndex = 17;
            // 
            // cmbArriver
            // 
            this.cmbArriver.BackColor = System.Drawing.Color.Transparent;
            this.cmbArriver.BorderColor = System.Drawing.Color.Black;
            this.cmbArriver.BorderRadius = 18;
            this.cmbArriver.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbArriver.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbArriver.FillColor = System.Drawing.SystemColors.Control;
            this.cmbArriver.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbArriver.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbArriver.FocusedState.Parent = this.cmbArriver;
            this.cmbArriver.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbArriver.ForeColor = System.Drawing.Color.Black;
            this.cmbArriver.HoverState.Parent = this.cmbArriver;
            this.cmbArriver.ItemHeight = 30;
            this.cmbArriver.ItemsAppearance.Parent = this.cmbArriver;
            this.cmbArriver.Location = new System.Drawing.Point(435, 213);
            this.cmbArriver.Name = "cmbArriver";
            this.cmbArriver.ShadowDecoration.Parent = this.cmbArriver;
            this.cmbArriver.Size = new System.Drawing.Size(203, 36);
            this.cmbArriver.TabIndex = 19;
            // 
            // guna2HtmlLabel5
            // 
            this.guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel5.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel5.Location = new System.Drawing.Point(315, 217);
            this.guna2HtmlLabel5.Name = "guna2HtmlLabel5";
            this.guna2HtmlLabel5.Size = new System.Drawing.Size(89, 26);
            this.guna2HtmlLabel5.TabIndex = 18;
            this.guna2HtmlLabel5.Text = "Arrivée :";
            // 
            // guna2HtmlLabel6
            // 
            this.guna2HtmlLabel6.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel6.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel6.Location = new System.Drawing.Point(315, 273);
            this.guna2HtmlLabel6.Name = "guna2HtmlLabel6";
            this.guna2HtmlLabel6.Size = new System.Drawing.Size(104, 26);
            this.guna2HtmlLabel6.TabIndex = 20;
            this.guna2HtmlLabel6.Text = "Distance : ";
            // 
            // tbxDistance
            // 
            this.tbxDistance.BackColor = System.Drawing.Color.Transparent;
            this.tbxDistance.BorderColor = System.Drawing.Color.Black;
            this.tbxDistance.BorderRadius = 18;
            this.tbxDistance.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbxDistance.DefaultText = "";
            this.tbxDistance.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbxDistance.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbxDistance.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbxDistance.DisabledState.Parent = this.tbxDistance;
            this.tbxDistance.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbxDistance.FillColor = System.Drawing.SystemColors.Control;
            this.tbxDistance.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbxDistance.FocusedState.Parent = this.tbxDistance;
            this.tbxDistance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbxDistance.ForeColor = System.Drawing.Color.Black;
            this.tbxDistance.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbxDistance.HoverState.Parent = this.tbxDistance;
            this.tbxDistance.Location = new System.Drawing.Point(435, 268);
            this.tbxDistance.Name = "tbxDistance";
            this.tbxDistance.PasswordChar = '\0';
            this.tbxDistance.PlaceholderText = "";
            this.tbxDistance.SelectedText = "";
            this.tbxDistance.ShadowDecoration.Parent = this.tbxDistance;
            this.tbxDistance.Size = new System.Drawing.Size(203, 36);
            this.tbxDistance.TabIndex = 21;
            // 
            // lblLiaisonCreer
            // 
            this.lblLiaisonCreer.BackColor = System.Drawing.Color.Transparent;
            this.lblLiaisonCreer.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblLiaisonCreer.Location = new System.Drawing.Point(315, 421);
            this.lblLiaisonCreer.Name = "lblLiaisonCreer";
            this.lblLiaisonCreer.Size = new System.Drawing.Size(3, 2);
            this.lblLiaisonCreer.TabIndex = 22;
            // 
            // CreerLiaison
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 690);
            this.Controls.Add(this.lblLiaisonCreer);
            this.Controls.Add(this.tbxDistance);
            this.Controls.Add(this.guna2HtmlLabel6);
            this.Controls.Add(this.cmbArriver);
            this.Controls.Add(this.guna2HtmlLabel5);
            this.Controls.Add(this.cmbDepart);
            this.Controls.Add(this.guna2HtmlLabel4);
            this.Controls.Add(this.guna2HtmlLabel3);
            this.Controls.Add(this.btnAjouterSecteur);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.lbxSecteurs);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CreerLiaison";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CreerLiaison";
            this.Load += new System.EventHandler(this.CreerLiaison_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbxSecteurs;
        private Guna.UI2.WinForms.Guna2Button btnAjouterSecteur;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
        private Guna.UI2.WinForms.Guna2ComboBox cmbDepart;
        private Guna.UI2.WinForms.Guna2ComboBox cmbArriver;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel5;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel6;
        private Guna.UI2.WinForms.Guna2TextBox tbxDistance;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblLiaisonCreer;
    }
}