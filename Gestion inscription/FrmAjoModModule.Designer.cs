
namespace Gestion_inscription
{
    partial class FrmAjoModModule
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnValider = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textNomModule = new System.Windows.Forms.TextBox();
            this.Nevgater = new System.Windows.Forms.GroupBox();
            this.btnPre = new System.Windows.Forms.Button();
            this.btnSuivant = new System.Windows.Forms.Button();
            this.s = new System.Windows.Forms.Button();
            this.btnNouveau = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.Nevgater.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnValider);
            this.groupBox1.Controls.Add(this.btnAnnuler);
            this.groupBox1.Controls.Add(this.btnModifier);
            this.groupBox1.Controls.Add(this.btnSupprimer);
            this.groupBox1.Controls.Add(this.btnAjouter);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 309);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Menu Module";
            // 
            // btnValider
            // 
            this.btnValider.Image = global::Gestion_inscription.Properties.Resources.btEnregistrer32;
            this.btnValider.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnValider.Location = new System.Drawing.Point(24, 214);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(148, 41);
            this.btnValider.TabIndex = 4;
            this.btnValider.Text = "   valider";
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Image = global::Gestion_inscription.Properties.Resources.btRetour32;
            this.btnAnnuler.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAnnuler.Location = new System.Drawing.Point(24, 167);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(148, 41);
            this.btnAnnuler.TabIndex = 3;
            this.btnAnnuler.Text = "    Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // btnModifier
            // 
            this.btnModifier.Image = global::Gestion_inscription.Properties.Resources.btModifier32;
            this.btnModifier.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModifier.Location = new System.Drawing.Point(24, 120);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(148, 41);
            this.btnModifier.TabIndex = 2;
            this.btnModifier.Text = "    Modifier";
            this.btnModifier.UseVisualStyleBackColor = true;
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Image = global::Gestion_inscription.Properties.Resources.btSupprimer32;
            this.btnSupprimer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSupprimer.Location = new System.Drawing.Point(24, 73);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(148, 41);
            this.btnSupprimer.TabIndex = 1;
            this.btnSupprimer.Text = "       Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // btnAjouter
            // 
            this.btnAjouter.Image = global::Gestion_inscription.Properties.Resources.add;
            this.btnAjouter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAjouter.Location = new System.Drawing.Point(24, 26);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(148, 41);
            this.btnAjouter.TabIndex = 0;
            this.btnAjouter.Text = "     Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(53, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nom Module :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textNomModule);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(230, 40);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(679, 167);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ajouter/Supprimer Module";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // textNomModule
            // 
            this.textNomModule.Location = new System.Drawing.Point(178, 73);
            this.textNomModule.Multiline = true;
            this.textNomModule.Name = "textNomModule";
            this.textNomModule.Size = new System.Drawing.Size(415, 36);
            this.textNomModule.TabIndex = 2;
            // 
            // Nevgater
            // 
            this.Nevgater.Controls.Add(this.btnPre);
            this.Nevgater.Controls.Add(this.btnSuivant);
            this.Nevgater.Controls.Add(this.s);
            this.Nevgater.Controls.Add(this.btnNouveau);
            this.Nevgater.Location = new System.Drawing.Point(230, 214);
            this.Nevgater.Name = "Nevgater";
            this.Nevgater.Size = new System.Drawing.Size(679, 135);
            this.Nevgater.TabIndex = 3;
            this.Nevgater.TabStop = false;
            // 
            // btnPre
            // 
            this.btnPre.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPre.Location = new System.Drawing.Point(24, 47);
            this.btnPre.Name = "btnPre";
            this.btnPre.Size = new System.Drawing.Size(148, 41);
            this.btnPre.TabIndex = 8;
            this.btnPre.Text = "<<   Precedent";
            this.btnPre.UseVisualStyleBackColor = true;
            this.btnPre.Click += new System.EventHandler(this.btnPre_Click);
            // 
            // btnSuivant
            // 
            this.btnSuivant.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuivant.Location = new System.Drawing.Point(178, 47);
            this.btnSuivant.Name = "btnSuivant";
            this.btnSuivant.Size = new System.Drawing.Size(148, 41);
            this.btnSuivant.TabIndex = 7;
            this.btnSuivant.Text = "Suivant    >>";
            this.btnSuivant.UseVisualStyleBackColor = true;
            this.btnSuivant.Click += new System.EventHandler(this.btnSuivant_Click);
            // 
            // s
            // 
            this.s.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.s.Image = global::Gestion_inscription.Properties.Resources.btFermer32;
            this.s.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.s.Location = new System.Drawing.Point(486, 47);
            this.s.Name = "s";
            this.s.Size = new System.Drawing.Size(148, 41);
            this.s.TabIndex = 5;
            this.s.Text = "    Fermer";
            this.s.UseVisualStyleBackColor = true;
            // 
            // btnNouveau
            // 
            this.btnNouveau.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNouveau.Location = new System.Drawing.Point(332, 47);
            this.btnNouveau.Name = "btnNouveau";
            this.btnNouveau.Size = new System.Drawing.Size(148, 41);
            this.btnNouveau.TabIndex = 6;
            this.btnNouveau.Text = "Nouveau";
            this.btnNouveau.UseVisualStyleBackColor = true;
            // 
            // FrmAjoModModule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 396);
            this.Controls.Add(this.Nevgater);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAjoModModule";
            this.Text = "FrmAjoModModule";
            this.Load += new System.EventHandler(this.FrmAjoModModule_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.Nevgater.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textNomModule;
        private System.Windows.Forms.GroupBox Nevgater;
        private System.Windows.Forms.Button btnPre;
        private System.Windows.Forms.Button btnSuivant;
        private System.Windows.Forms.Button s;
        private System.Windows.Forms.Button btnNouveau;
    }
}