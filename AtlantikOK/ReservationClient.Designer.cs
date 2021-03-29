
namespace AtlantikOK
{
    partial class ReservationClient
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
            this.cmbClient = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.gbxInfoClient = new Guna.UI2.WinForms.Guna2GroupBox();
            this.LblVoiture = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblVoitureInf5m = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblEnfantNombre = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblMontantTotalNombre = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblJuniorNombre = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblAdulteNombre = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblRegler = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblMontantTotal = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblEnfant = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblJunior = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblAdulte = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lvReservationClient = new System.Windows.Forms.ListView();
            this.gbxInfoClient.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbClient
            // 
            this.cmbClient.BackColor = System.Drawing.Color.Transparent;
            this.cmbClient.BorderColor = System.Drawing.Color.Black;
            this.cmbClient.BorderRadius = 18;
            this.cmbClient.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbClient.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbClient.FillColor = System.Drawing.SystemColors.Control;
            this.cmbClient.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbClient.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbClient.FocusedState.Parent = this.cmbClient;
            this.cmbClient.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbClient.ForeColor = System.Drawing.Color.Black;
            this.cmbClient.HoverState.Parent = this.cmbClient;
            this.cmbClient.ItemHeight = 30;
            this.cmbClient.ItemsAppearance.Parent = this.cmbClient;
            this.cmbClient.Location = new System.Drawing.Point(223, 114);
            this.cmbClient.Name = "cmbClient";
            this.cmbClient.ShadowDecoration.Parent = this.cmbClient;
            this.cmbClient.Size = new System.Drawing.Size(332, 36);
            this.cmbClient.TabIndex = 66;
            this.cmbClient.SelectedIndexChanged += new System.EventHandler(this.cmbClient_SelectedIndexChanged);
            // 
            // guna2HtmlLabel4
            // 
            this.guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel4.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel4.Location = new System.Drawing.Point(38, 116);
            this.guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            this.guna2HtmlLabel4.Size = new System.Drawing.Size(153, 26);
            this.guna2HtmlLabel4.TabIndex = 65;
            this.guna2HtmlLabel4.Text = "Nom, Prénom :";
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.FillColor = System.Drawing.Color.Black;
            this.guna2Panel1.Location = new System.Drawing.Point(38, 72);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(370, 3);
            this.guna2Panel1.TabIndex = 62;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(38, 26);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(377, 39);
            this.guna2HtmlLabel1.TabIndex = 61;
            this.guna2HtmlLabel1.Text = "Détails d\'une Résrvation";
            // 
            // gbxInfoClient
            // 
            this.gbxInfoClient.Controls.Add(this.LblVoiture);
            this.gbxInfoClient.Controls.Add(this.lblVoitureInf5m);
            this.gbxInfoClient.Controls.Add(this.lblEnfantNombre);
            this.gbxInfoClient.Controls.Add(this.lblMontantTotalNombre);
            this.gbxInfoClient.Controls.Add(this.lblJuniorNombre);
            this.gbxInfoClient.Controls.Add(this.lblAdulteNombre);
            this.gbxInfoClient.Controls.Add(this.lblRegler);
            this.gbxInfoClient.Controls.Add(this.lblMontantTotal);
            this.gbxInfoClient.Controls.Add(this.lblEnfant);
            this.gbxInfoClient.Controls.Add(this.lblJunior);
            this.gbxInfoClient.Controls.Add(this.lblAdulte);
            this.gbxInfoClient.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gbxInfoClient.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.gbxInfoClient.Location = new System.Drawing.Point(617, 114);
            this.gbxInfoClient.Name = "gbxInfoClient";
            this.gbxInfoClient.ShadowDecoration.Parent = this.gbxInfoClient;
            this.gbxInfoClient.Size = new System.Drawing.Size(365, 370);
            this.gbxInfoClient.TabIndex = 73;
            this.gbxInfoClient.Text = "Informations Client";
            // 
            // LblVoiture
            // 
            this.LblVoiture.BackColor = System.Drawing.Color.White;
            this.LblVoiture.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblVoiture.ForeColor = System.Drawing.Color.Black;
            this.LblVoiture.Location = new System.Drawing.Point(245, 218);
            this.LblVoiture.Name = "LblVoiture";
            this.LblVoiture.Size = new System.Drawing.Size(15, 26);
            this.LblVoiture.TabIndex = 9;
            this.LblVoiture.Text = "0";
            // 
            // lblVoitureInf5m
            // 
            this.lblVoitureInf5m.BackColor = System.Drawing.Color.Transparent;
            this.lblVoitureInf5m.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVoitureInf5m.ForeColor = System.Drawing.Color.Black;
            this.lblVoitureInf5m.Location = new System.Drawing.Point(23, 218);
            this.lblVoitureInf5m.Name = "lblVoitureInf5m";
            this.lblVoitureInf5m.Size = new System.Drawing.Size(143, 26);
            this.lblVoitureInf5m.TabIndex = 8;
            this.lblVoitureInf5m.Text = "Voiture inf 5m :";
            // 
            // lblEnfantNombre
            // 
            this.lblEnfantNombre.BackColor = System.Drawing.Color.White;
            this.lblEnfantNombre.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnfantNombre.ForeColor = System.Drawing.Color.Black;
            this.lblEnfantNombre.Location = new System.Drawing.Point(245, 168);
            this.lblEnfantNombre.Name = "lblEnfantNombre";
            this.lblEnfantNombre.Size = new System.Drawing.Size(15, 26);
            this.lblEnfantNombre.TabIndex = 7;
            this.lblEnfantNombre.Text = "0";
            // 
            // lblMontantTotalNombre
            // 
            this.lblMontantTotalNombre.BackColor = System.Drawing.Color.Transparent;
            this.lblMontantTotalNombre.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMontantTotalNombre.ForeColor = System.Drawing.Color.Black;
            this.lblMontantTotalNombre.Location = new System.Drawing.Point(245, 267);
            this.lblMontantTotalNombre.Name = "lblMontantTotalNombre";
            this.lblMontantTotalNombre.Size = new System.Drawing.Size(15, 26);
            this.lblMontantTotalNombre.TabIndex = 7;
            this.lblMontantTotalNombre.Text = "0";
            // 
            // lblJuniorNombre
            // 
            this.lblJuniorNombre.BackColor = System.Drawing.Color.Transparent;
            this.lblJuniorNombre.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJuniorNombre.ForeColor = System.Drawing.Color.Black;
            this.lblJuniorNombre.Location = new System.Drawing.Point(245, 112);
            this.lblJuniorNombre.Name = "lblJuniorNombre";
            this.lblJuniorNombre.Size = new System.Drawing.Size(15, 26);
            this.lblJuniorNombre.TabIndex = 6;
            this.lblJuniorNombre.Text = "0";
            // 
            // lblAdulteNombre
            // 
            this.lblAdulteNombre.BackColor = System.Drawing.Color.Transparent;
            this.lblAdulteNombre.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdulteNombre.ForeColor = System.Drawing.Color.Black;
            this.lblAdulteNombre.Location = new System.Drawing.Point(245, 58);
            this.lblAdulteNombre.Name = "lblAdulteNombre";
            this.lblAdulteNombre.Size = new System.Drawing.Size(15, 26);
            this.lblAdulteNombre.TabIndex = 5;
            this.lblAdulteNombre.Text = "0";
            // 
            // lblRegler
            // 
            this.lblRegler.BackColor = System.Drawing.Color.Transparent;
            this.lblRegler.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegler.ForeColor = System.Drawing.Color.Black;
            this.lblRegler.Location = new System.Drawing.Point(23, 318);
            this.lblRegler.Name = "lblRegler";
            this.lblRegler.Size = new System.Drawing.Size(3, 2);
            this.lblRegler.TabIndex = 4;
            this.lblRegler.Text = null;
            // 
            // lblMontantTotal
            // 
            this.lblMontantTotal.BackColor = System.Drawing.Color.Transparent;
            this.lblMontantTotal.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMontantTotal.ForeColor = System.Drawing.Color.Black;
            this.lblMontantTotal.Location = new System.Drawing.Point(23, 267);
            this.lblMontantTotal.Name = "lblMontantTotal";
            this.lblMontantTotal.Size = new System.Drawing.Size(142, 26);
            this.lblMontantTotal.TabIndex = 3;
            this.lblMontantTotal.Text = "Montant Total : ";
            // 
            // lblEnfant
            // 
            this.lblEnfant.BackColor = System.Drawing.Color.Transparent;
            this.lblEnfant.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnfant.ForeColor = System.Drawing.Color.Black;
            this.lblEnfant.Location = new System.Drawing.Point(23, 168);
            this.lblEnfant.Name = "lblEnfant";
            this.lblEnfant.Size = new System.Drawing.Size(198, 26);
            this.lblEnfant.TabIndex = 2;
            this.lblEnfant.Text = "Enfant de 0 à 8 ans :";
            // 
            // lblJunior
            // 
            this.lblJunior.BackColor = System.Drawing.Color.Transparent;
            this.lblJunior.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJunior.ForeColor = System.Drawing.Color.Black;
            this.lblJunior.Location = new System.Drawing.Point(23, 112);
            this.lblJunior.Name = "lblJunior";
            this.lblJunior.Size = new System.Drawing.Size(178, 26);
            this.lblJunior.TabIndex = 1;
            this.lblJunior.Text = "Junior 8 à 18 ans :";
            // 
            // lblAdulte
            // 
            this.lblAdulte.BackColor = System.Drawing.Color.Transparent;
            this.lblAdulte.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdulte.ForeColor = System.Drawing.Color.Black;
            this.lblAdulte.Location = new System.Drawing.Point(23, 58);
            this.lblAdulte.Name = "lblAdulte";
            this.lblAdulte.Size = new System.Drawing.Size(72, 26);
            this.lblAdulte.TabIndex = 0;
            this.lblAdulte.Text = "Adulte :";
            // 
            // lvReservationClient
            // 
            this.lvReservationClient.HideSelection = false;
            this.lvReservationClient.Location = new System.Drawing.Point(38, 172);
            this.lvReservationClient.Name = "lvReservationClient";
            this.lvReservationClient.Size = new System.Drawing.Size(517, 312);
            this.lvReservationClient.TabIndex = 74;
            this.lvReservationClient.UseCompatibleStateImageBehavior = false;
            this.lvReservationClient.SelectedIndexChanged += new System.EventHandler(this.lvReservationClient_SelectedIndexChanged);
            // 
            // ReservationClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 690);
            this.Controls.Add(this.lvReservationClient);
            this.Controls.Add(this.gbxInfoClient);
            this.Controls.Add(this.cmbClient);
            this.Controls.Add(this.guna2HtmlLabel4);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ReservationClient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReservationClient";
            this.Load += new System.EventHandler(this.ReservationClient_Load);
            this.gbxInfoClient.ResumeLayout(false);
            this.gbxInfoClient.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2ComboBox cmbClient;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2GroupBox gbxInfoClient;
        private System.Windows.Forms.ListView lvReservationClient;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblMontantTotalNombre;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblJuniorNombre;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblAdulteNombre;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblRegler;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblMontantTotal;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblEnfant;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblJunior;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblAdulte;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblEnfantNombre;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblVoitureInf5m;
        private Guna.UI2.WinForms.Guna2HtmlLabel LblVoiture;
    }
}