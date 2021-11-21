
namespace Gestion_inscription
{
    partial class GestionInscrit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GestionInscrit));
            this.TooStrip = new System.Windows.Forms.ToolStrip();
            this.BtnNewinscrit = new System.Windows.Forms.ToolStripButton();
            this.NewInscrit = new System.Windows.Forms.ToolStripLabel();
            this.btnFilieres = new System.Windows.Forms.ToolStripButton();
            this.TextFilieres = new System.Windows.Forms.ToolStripLabel();
            this.BtnNotes = new System.Windows.Forms.ToolStripButton();
            this.textNote = new System.Windows.Forms.ToolStripLabel();
            this.btnModules = new System.Windows.Forms.ToolStripButton();
            this.textModules = new System.Windows.Forms.ToolStripLabel();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fichierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connexionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inscriptionsToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.inscrptionsToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.FilieresToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.notationsToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.notesToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.modulesToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.parametresToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionUtilisateurToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.LabelForUpperName = new System.Windows.Forms.Label();
            this.TooStrip.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // TooStrip
            // 
            this.TooStrip.AutoSize = false;
            this.TooStrip.Dock = System.Windows.Forms.DockStyle.Left;
            this.TooStrip.Enabled = false;
            this.TooStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.TooStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.TooStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtnNewinscrit,
            this.NewInscrit,
            this.btnFilieres,
            this.TextFilieres,
            this.BtnNotes,
            this.textNote,
            this.btnModules,
            this.textModules});
            this.TooStrip.Location = new System.Drawing.Point(0, 35);
            this.TooStrip.Name = "TooStrip";
            this.TooStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.TooStrip.Size = new System.Drawing.Size(130, 793);
            this.TooStrip.TabIndex = 19;
            this.TooStrip.Text = "ToolStrip";
            this.TooStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.TooStrip_ItemClicked);
            // 
            // BtnNewinscrit
            // 
            this.BtnNewinscrit.AutoSize = false;
            this.BtnNewinscrit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnNewinscrit.Image = global::Gestion_inscription.Properties.Resources.PikPng_com_profile_icon_png_80506811;
            this.BtnNewinscrit.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.BtnNewinscrit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnNewinscrit.Name = "BtnNewinscrit";
            this.BtnNewinscrit.Size = new System.Drawing.Size(140, 90);
            this.BtnNewinscrit.Text = "New inscrit";
            this.BtnNewinscrit.Click += new System.EventHandler(this.BtnNewinscrit_Click);
            // 
            // NewInscrit
            // 
            this.NewInscrit.AutoSize = false;
            this.NewInscrit.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewInscrit.ForeColor = System.Drawing.SystemColors.Highlight;
            this.NewInscrit.Name = "NewInscrit";
            this.NewInscrit.Size = new System.Drawing.Size(101, 20);
            this.NewInscrit.Text = "New inscrit ";
            // 
            // btnFilieres
            // 
            this.btnFilieres.AutoSize = false;
            this.btnFilieres.AutoToolTip = false;
            this.btnFilieres.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnFilieres.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnFilieres.Image = global::Gestion_inscription.Properties.Resources.icons8_folder_50;
            this.btnFilieres.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnFilieres.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnFilieres.Name = "btnFilieres";
            this.btnFilieres.RightToLeftAutoMirrorImage = true;
            this.btnFilieres.Size = new System.Drawing.Size(150, 80);
            this.btnFilieres.Text = "filieres";
            // 
            // TextFilieres
            // 
            this.TextFilieres.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextFilieres.ForeColor = System.Drawing.SystemColors.Highlight;
            this.TextFilieres.Name = "TextFilieres";
            this.TextFilieres.Size = new System.Drawing.Size(128, 20);
            this.TextFilieres.Text = "Filieres";
            // 
            // BtnNotes
            // 
            this.BtnNotes.AutoSize = false;
            this.BtnNotes.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnNotes.Image = global::Gestion_inscription.Properties.Resources.icons8_note_64;
            this.BtnNotes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.BtnNotes.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnNotes.Name = "BtnNotes";
            this.BtnNotes.Size = new System.Drawing.Size(150, 90);
            this.BtnNotes.Text = "Notes";
            // 
            // textNote
            // 
            this.textNote.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textNote.ForeColor = System.Drawing.SystemColors.Highlight;
            this.textNote.Name = "textNote";
            this.textNote.Size = new System.Drawing.Size(128, 20);
            this.textNote.Text = "Notes";
            // 
            // btnModules
            // 
            this.btnModules.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnModules.Image = global::Gestion_inscription.Properties.Resources.icons8_module_641;
            this.btnModules.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnModules.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnModules.Name = "btnModules";
            this.btnModules.Size = new System.Drawing.Size(128, 68);
            this.btnModules.Text = "Modules";
            // 
            // textModules
            // 
            this.textModules.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textModules.ForeColor = System.Drawing.SystemColors.Highlight;
            this.textModules.Name = "textModules";
            this.textModules.Size = new System.Drawing.Size(128, 20);
            this.textModules.Text = "Modules";
            // 
            // menuStrip
            // 
            this.menuStrip.AutoSize = false;
            this.menuStrip.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichierToolStripMenuItem,
            this.inscriptionsToolStrip,
            this.notationsToolStrip,
            this.parametresToolStrip});
            this.menuStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1366, 35);
            this.menuStrip.TabIndex = 18;
            this.menuStrip.Text = "MenuStrip";
            // 
            // fichierToolStripMenuItem
            // 
            this.fichierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connexionToolStripMenuItem,
            this.quitterToolStripMenuItem});
            this.fichierToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
            this.fichierToolStripMenuItem.Size = new System.Drawing.Size(69, 24);
            this.fichierToolStripMenuItem.Text = "Fichier";
            // 
            // connexionToolStripMenuItem
            // 
            this.connexionToolStripMenuItem.Name = "connexionToolStripMenuItem";
            this.connexionToolStripMenuItem.Size = new System.Drawing.Size(166, 26);
            this.connexionToolStripMenuItem.Text = "Connexion";
            this.connexionToolStripMenuItem.Click += new System.EventHandler(this.connexionToolStripMenuItem_Click);
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(166, 26);
            this.quitterToolStripMenuItem.Text = "Quitter";
            this.quitterToolStripMenuItem.Click += new System.EventHandler(this.quitterToolStripMenuItem_Click);
            // 
            // inscriptionsToolStrip
            // 
            this.inscriptionsToolStrip.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inscrptionsToolStrip,
            this.FilieresToolStrip});
            this.inscriptionsToolStrip.Enabled = false;
            this.inscriptionsToolStrip.ForeColor = System.Drawing.SystemColors.ControlText;
            this.inscriptionsToolStrip.Name = "inscriptionsToolStrip";
            this.inscriptionsToolStrip.Size = new System.Drawing.Size(101, 24);
            this.inscriptionsToolStrip.Text = "Inscriptions";
            // 
            // inscrptionsToolStrip
            // 
            this.inscrptionsToolStrip.Enabled = false;
            this.inscrptionsToolStrip.Name = "inscrptionsToolStrip";
            this.inscrptionsToolStrip.Size = new System.Drawing.Size(224, 26);
            this.inscrptionsToolStrip.Text = "Inscriptions";
            // 
            // FilieresToolStrip
            // 
            this.FilieresToolStrip.Enabled = false;
            this.FilieresToolStrip.Name = "FilieresToolStrip";
            this.FilieresToolStrip.Size = new System.Drawing.Size(224, 26);
            this.FilieresToolStrip.Text = "fillieres";
            // 
            // notationsToolStrip
            // 
            this.notationsToolStrip.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.notesToolStrip,
            this.modulesToolStrip});
            this.notationsToolStrip.Enabled = false;
            this.notationsToolStrip.ForeColor = System.Drawing.SystemColors.ControlText;
            this.notationsToolStrip.Name = "notationsToolStrip";
            this.notationsToolStrip.Size = new System.Drawing.Size(90, 24);
            this.notationsToolStrip.Text = "Notations";
            // 
            // notesToolStrip
            // 
            this.notesToolStrip.Enabled = false;
            this.notesToolStrip.Name = "notesToolStrip";
            this.notesToolStrip.Size = new System.Drawing.Size(224, 26);
            this.notesToolStrip.Text = "Notes";
            // 
            // modulesToolStrip
            // 
            this.modulesToolStrip.Enabled = false;
            this.modulesToolStrip.Name = "modulesToolStrip";
            this.modulesToolStrip.Size = new System.Drawing.Size(224, 26);
            this.modulesToolStrip.Text = "Modules";
            this.modulesToolStrip.Click += new System.EventHandler(this.modulesToolStrip_Click);
            // 
            // parametresToolStrip
            // 
            this.parametresToolStrip.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionUtilisateurToolStrip});
            this.parametresToolStrip.Enabled = false;
            this.parametresToolStrip.ForeColor = System.Drawing.SystemColors.ControlText;
            this.parametresToolStrip.Name = "parametresToolStrip";
            this.parametresToolStrip.Size = new System.Drawing.Size(100, 24);
            this.parametresToolStrip.Text = "Parametres";
            // 
            // gestionUtilisateurToolStrip
            // 
            this.gestionUtilisateurToolStrip.Enabled = false;
            this.gestionUtilisateurToolStrip.Name = "gestionUtilisateurToolStrip";
            this.gestionUtilisateurToolStrip.Size = new System.Drawing.Size(217, 26);
            this.gestionUtilisateurToolStrip.Text = "Gestion Utilisateur";
            this.gestionUtilisateurToolStrip.Click += new System.EventHandler(this.gestionUtilisateurToolStrip_Click);
            // 
            // LabelForUpperName
            // 
            this.LabelForUpperName.AutoSize = true;
            this.LabelForUpperName.BackColor = System.Drawing.Color.Transparent;
            this.LabelForUpperName.Location = new System.Drawing.Point(1198, 783);
            this.LabelForUpperName.Name = "LabelForUpperName";
            this.LabelForUpperName.Size = new System.Drawing.Size(0, 17);
            this.LabelForUpperName.TabIndex = 20;
            // 
            // GestionInscrit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1366, 828);
            this.Controls.Add(this.LabelForUpperName);
            this.Controls.Add(this.TooStrip);
            this.Controls.Add(this.menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "GestionInscrit";
            this.Text = "GestionInscrit";
            this.Load += new System.EventHandler(this.GestionInscrit_Load);
            this.TooStrip.ResumeLayout(false);
            this.TooStrip.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ToolStrip TooStrip;
        private System.Windows.Forms.ToolStripButton BtnNewinscrit;
        private System.Windows.Forms.ToolStripLabel NewInscrit;
        private System.Windows.Forms.ToolStripButton btnFilieres;
        private System.Windows.Forms.ToolStripLabel TextFilieres;
        private System.Windows.Forms.ToolStripButton BtnNotes;
        private System.Windows.Forms.ToolStripLabel textNote;
        private System.Windows.Forms.ToolStripButton btnModules;
        private System.Windows.Forms.ToolStripLabel textModules;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
        public System.Windows.Forms.Label LabelForUpperName;
        public System.Windows.Forms.ToolStripMenuItem inscrptionsToolStrip;
        public System.Windows.Forms.ToolStripMenuItem FilieresToolStrip;
        public System.Windows.Forms.ToolStripMenuItem notationsToolStrip;
        public System.Windows.Forms.ToolStripMenuItem modulesToolStrip;
        public System.Windows.Forms.ToolStripMenuItem gestionUtilisateurToolStrip;
        public System.Windows.Forms.ToolStripMenuItem notesToolStrip;
        public System.Windows.Forms.ToolStripMenuItem parametresToolStrip;
        public System.Windows.Forms.ToolStripMenuItem inscriptionsToolStrip;
        public System.Windows.Forms.ToolStripMenuItem fichierToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem connexionToolStripMenuItem;
    }
}