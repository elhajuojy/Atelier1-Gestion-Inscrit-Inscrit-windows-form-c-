namespace Gestion_inscription
{
    partial class formateur
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
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnFrmer = new System.Windows.Forms.Button();
            this.BtnEnrg = new System.Windows.Forms.Button();
            this.btnModifi = new System.Windows.Forms.Button();
            this.btnRecherche = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.textMatricule = new System.Windows.Forms.TextBox();
            this.textNom = new System.Windows.Forms.TextBox();
            this.labelMatricule = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textprenom = new System.Windows.Forms.TextBox();
            this.btnSuivant = new System.Windows.Forms.Button();
            this.btnprecedent = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(12, 12);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(75, 58);
            this.btnAjouter.TabIndex = 17;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // btnFrmer
            // 
            this.btnFrmer.Location = new System.Drawing.Point(464, 12);
            this.btnFrmer.Name = "btnFrmer";
            this.btnFrmer.Size = new System.Drawing.Size(75, 58);
            this.btnFrmer.TabIndex = 16;
            this.btnFrmer.Text = "Fermer";
            this.btnFrmer.UseVisualStyleBackColor = true;
            this.btnFrmer.Click += new System.EventHandler(this.btnFrmer_Click);
            // 
            // BtnEnrg
            // 
            this.BtnEnrg.Location = new System.Drawing.Point(359, 12);
            this.BtnEnrg.Name = "BtnEnrg";
            this.BtnEnrg.Size = new System.Drawing.Size(99, 58);
            this.BtnEnrg.TabIndex = 15;
            this.BtnEnrg.Text = "Enregistrer";
            this.BtnEnrg.UseVisualStyleBackColor = true;
            this.BtnEnrg.Click += new System.EventHandler(this.BtnEnrg_Click);
            // 
            // btnModifi
            // 
            this.btnModifi.Location = new System.Drawing.Point(278, 12);
            this.btnModifi.Name = "btnModifi";
            this.btnModifi.Size = new System.Drawing.Size(75, 58);
            this.btnModifi.TabIndex = 14;
            this.btnModifi.Text = "Modifi";
            this.btnModifi.UseVisualStyleBackColor = true;
            this.btnModifi.Click += new System.EventHandler(this.btnModifi_Click);
            // 
            // btnRecherche
            // 
            this.btnRecherche.Location = new System.Drawing.Point(93, 12);
            this.btnRecherche.Name = "btnRecherche";
            this.btnRecherche.Size = new System.Drawing.Size(94, 58);
            this.btnRecherche.TabIndex = 13;
            this.btnRecherche.Text = "Recherche";
            this.btnRecherche.UseVisualStyleBackColor = true;
            this.btnRecherche.Click += new System.EventHandler(this.btnRecherche_Click);
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Location = new System.Drawing.Point(193, 12);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(79, 58);
            this.btnSupprimer.TabIndex = 18;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // textMatricule
            // 
            this.textMatricule.Location = new System.Drawing.Point(193, 158);
            this.textMatricule.Multiline = true;
            this.textMatricule.Name = "textMatricule";
            this.textMatricule.Size = new System.Drawing.Size(181, 30);
            this.textMatricule.TabIndex = 19;
            // 
            // textNom
            // 
            this.textNom.Location = new System.Drawing.Point(193, 215);
            this.textNom.Multiline = true;
            this.textNom.Name = "textNom";
            this.textNom.Size = new System.Drawing.Size(181, 30);
            this.textNom.TabIndex = 20;
            // 
            // labelMatricule
            // 
            this.labelMatricule.AutoSize = true;
            this.labelMatricule.Location = new System.Drawing.Point(66, 169);
            this.labelMatricule.Name = "labelMatricule";
            this.labelMatricule.Size = new System.Drawing.Size(61, 16);
            this.labelMatricule.TabIndex = 21;
            this.labelMatricule.Text = "Matricule";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 226);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 16);
            this.label1.TabIndex = 22;
            this.label1.Text = "Nom";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 290);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 16);
            this.label2.TabIndex = 24;
            this.label2.Text = "Prenom";
            // 
            // textprenom
            // 
            this.textprenom.Location = new System.Drawing.Point(193, 279);
            this.textprenom.Multiline = true;
            this.textprenom.Name = "textprenom";
            this.textprenom.Size = new System.Drawing.Size(181, 30);
            this.textprenom.TabIndex = 23;
            // 
            // btnSuivant
            // 
            this.btnSuivant.Location = new System.Drawing.Point(559, 435);
            this.btnSuivant.Name = "btnSuivant";
            this.btnSuivant.Size = new System.Drawing.Size(89, 58);
            this.btnSuivant.TabIndex = 26;
            this.btnSuivant.Text = "Suivant";
            this.btnSuivant.UseVisualStyleBackColor = true;
            this.btnSuivant.Click += new System.EventHandler(this.btnSuivant_Click);
            // 
            // btnprecedent
            // 
            this.btnprecedent.Location = new System.Drawing.Point(464, 435);
            this.btnprecedent.Name = "btnprecedent";
            this.btnprecedent.Size = new System.Drawing.Size(89, 58);
            this.btnprecedent.TabIndex = 25;
            this.btnprecedent.Text = "Precedent";
            this.btnprecedent.UseVisualStyleBackColor = true;
            this.btnprecedent.Click += new System.EventHandler(this.btnprecedent_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(746, 213);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(619, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 16);
            this.label3.TabIndex = 28;
            this.label3.Text = "Date_amnauche";
            // 
            // formateur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1043, 540);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btnSuivant);
            this.Controls.Add(this.btnprecedent);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textprenom);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelMatricule);
            this.Controls.Add(this.textNom);
            this.Controls.Add(this.textMatricule);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.btnFrmer);
            this.Controls.Add(this.BtnEnrg);
            this.Controls.Add(this.btnModifi);
            this.Controls.Add(this.btnRecherche);
            this.Name = "formateur";
            this.Text = "formateur";
            this.Load += new System.EventHandler(this.formateur_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Button btnFrmer;
        private System.Windows.Forms.Button BtnEnrg;
        private System.Windows.Forms.Button btnModifi;
        private System.Windows.Forms.Button btnRecherche;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.TextBox textMatricule;
        private System.Windows.Forms.TextBox textNom;
        private System.Windows.Forms.Label labelMatricule;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textprenom;
        private System.Windows.Forms.Button btnSuivant;
        private System.Windows.Forms.Button btnprecedent;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label3;
    }
}