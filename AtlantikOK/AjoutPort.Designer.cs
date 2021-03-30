
namespace AtlantikOK
{
    partial class AjoutPort
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
            this.btnAjouterPort = new Guna.UI2.WinForms.Guna2Button();
            this.tbxNomPort = new Guna.UI2.WinForms.Guna2TextBox();
            this.LblTitreNomPort = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.panelBarre = new Guna.UI2.WinForms.Guna2Panel();
            this.lblTitre = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblTitreSecteurs = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lbxSecteurs = new System.Windows.Forms.ListBox();
            this.lblPortAjouter = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.SuspendLayout();
            // 
            // btnAjouterPort
            // 
            this.btnAjouterPort.BorderRadius = 22;
            this.btnAjouterPort.CheckedState.Parent = this.btnAjouterPort;
            this.btnAjouterPort.CustomImages.Parent = this.btnAjouterPort;
            this.btnAjouterPort.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnAjouterPort.ForeColor = System.Drawing.Color.White;
            this.btnAjouterPort.HoverState.Parent = this.btnAjouterPort;
            this.btnAjouterPort.Location = new System.Drawing.Point(336, 175);
            this.btnAjouterPort.Name = "btnAjouterPort";
            this.btnAjouterPort.ShadowDecoration.Parent = this.btnAjouterPort;
            this.btnAjouterPort.Size = new System.Drawing.Size(180, 45);
            this.btnAjouterPort.TabIndex = 9;
            this.btnAjouterPort.Text = "Ajouter";
            this.btnAjouterPort.Click += new System.EventHandler(this.btnAjouterPort_Click);
            // 
            // tbxNomPort
            // 
            this.tbxNomPort.BorderColor = System.Drawing.Color.Black;
            this.tbxNomPort.BorderRadius = 12;
            this.tbxNomPort.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbxNomPort.DefaultText = "";
            this.tbxNomPort.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbxNomPort.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbxNomPort.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbxNomPort.DisabledState.Parent = this.tbxNomPort;
            this.tbxNomPort.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbxNomPort.FillColor = System.Drawing.SystemColors.Control;
            this.tbxNomPort.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbxNomPort.FocusedState.Parent = this.tbxNomPort;
            this.tbxNomPort.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbxNomPort.ForeColor = System.Drawing.Color.Black;
            this.tbxNomPort.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbxNomPort.HoverState.Parent = this.tbxNomPort;
            this.tbxNomPort.Location = new System.Drawing.Point(493, 120);
            this.tbxNomPort.Name = "tbxNomPort";
            this.tbxNomPort.PasswordChar = '\0';
            this.tbxNomPort.PlaceholderText = "";
            this.tbxNomPort.SelectedText = "";
            this.tbxNomPort.ShadowDecoration.Parent = this.tbxNomPort;
            this.tbxNomPort.Size = new System.Drawing.Size(213, 25);
            this.tbxNomPort.TabIndex = 8;
            // 
            // LblTitreNomPort
            // 
            this.LblTitreNomPort.BackColor = System.Drawing.Color.Transparent;
            this.LblTitreNomPort.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitreNomPort.Location = new System.Drawing.Point(336, 119);
            this.LblTitreNomPort.Name = "LblTitreNomPort";
            this.LblTitreNomPort.Size = new System.Drawing.Size(142, 26);
            this.LblTitreNomPort.TabIndex = 7;
            this.LblTitreNomPort.Text = "Nom du  Port :";
            // 
            // panelBarre
            // 
            this.panelBarre.FillColor = System.Drawing.Color.Black;
            this.panelBarre.Location = new System.Drawing.Point(38, 72);
            this.panelBarre.Name = "panelBarre";
            this.panelBarre.ShadowDecoration.Parent = this.panelBarre;
            this.panelBarre.Size = new System.Drawing.Size(245, 3);
            this.panelBarre.TabIndex = 6;
            // 
            // lblTitre
            // 
            this.lblTitre.BackColor = System.Drawing.Color.Transparent;
            this.lblTitre.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitre.Location = new System.Drawing.Point(38, 26);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(235, 39);
            this.lblTitre.TabIndex = 5;
            this.lblTitre.Text = "Ajouter un Port";
            // 
            // lblTitreSecteurs
            // 
            this.lblTitreSecteurs.BackColor = System.Drawing.Color.Transparent;
            this.lblTitreSecteurs.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitreSecteurs.Location = new System.Drawing.Point(38, 119);
            this.lblTitreSecteurs.Name = "lblTitreSecteurs";
            this.lblTitreSecteurs.Size = new System.Drawing.Size(106, 26);
            this.lblTitreSecteurs.TabIndex = 17;
            this.lblTitreSecteurs.Text = "Secteurs : ";
            // 
            // lbxSecteurs
            // 
            this.lbxSecteurs.BackColor = System.Drawing.SystemColors.Control;
            this.lbxSecteurs.FormattingEnabled = true;
            this.lbxSecteurs.Location = new System.Drawing.Point(38, 168);
            this.lbxSecteurs.Name = "lbxSecteurs";
            this.lbxSecteurs.Size = new System.Drawing.Size(245, 381);
            this.lbxSecteurs.TabIndex = 16;
            // 
            // lblPortAjouter
            // 
            this.lblPortAjouter.BackColor = System.Drawing.Color.Transparent;
            this.lblPortAjouter.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblPortAjouter.Location = new System.Drawing.Point(336, 251);
            this.lblPortAjouter.Name = "lblPortAjouter";
            this.lblPortAjouter.Size = new System.Drawing.Size(3, 2);
            this.lblPortAjouter.TabIndex = 18;
            this.lblPortAjouter.Text = null;
            // 
            // AjoutPort
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 690);
            this.Controls.Add(this.lblPortAjouter);
            this.Controls.Add(this.lblTitreSecteurs);
            this.Controls.Add(this.lbxSecteurs);
            this.Controls.Add(this.btnAjouterPort);
            this.Controls.Add(this.tbxNomPort);
            this.Controls.Add(this.LblTitreNomPort);
            this.Controls.Add(this.panelBarre);
            this.Controls.Add(this.lblTitre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AjoutPort";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AjoutPort";
            this.Load += new System.EventHandler(this.AjoutPort_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnAjouterPort;
        private Guna.UI2.WinForms.Guna2TextBox tbxNomPort;
        private Guna.UI2.WinForms.Guna2HtmlLabel LblTitreNomPort;
        private Guna.UI2.WinForms.Guna2Panel panelBarre;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTitre;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTitreSecteurs;
        private System.Windows.Forms.ListBox lbxSecteurs;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblPortAjouter;
    }
}