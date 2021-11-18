
namespace Gestion_inscription
{
    partial class gestion_Utilisateur
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.Ajouter = new System.Windows.Forms.ToolStripButton();
            this.Modification = new System.Windows.Forms.ToolStripButton();
            this.Suppression = new System.Windows.Forms.ToolStripButton();
            this.Recherche = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Ajouter,
            this.Modification,
            this.Suppression,
            this.Recherche});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1233, 60);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // Ajouter
            // 
            this.Ajouter.AutoSize = false;
            this.Ajouter.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Ajouter.Image = global::Gestion_inscription.Properties.Resources.plus__1_;
            this.Ajouter.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Ajouter.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Ajouter.Name = "Ajouter";
            this.Ajouter.Size = new System.Drawing.Size(50, 57);
            this.Ajouter.Text = "Ajouter";
            // 
            // Modification
            // 
            this.Modification.AutoSize = false;
            this.Modification.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Modification.Image = global::Gestion_inscription.Properties.Resources.edit__1_;
            this.Modification.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Modification.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Modification.Name = "Modification";
            this.Modification.Size = new System.Drawing.Size(50, 57);
            this.Modification.Text = "Modification";
            // 
            // Suppression
            // 
            this.Suppression.AutoSize = false;
            this.Suppression.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Suppression.Image = global::Gestion_inscription.Properties.Resources.remove1;
            this.Suppression.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Suppression.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Suppression.Name = "Suppression";
            this.Suppression.Size = new System.Drawing.Size(50, 57);
            this.Suppression.Text = "Suppression";
            // 
            // Recherche
            // 
            this.Recherche.AutoSize = false;
            this.Recherche.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Recherche.Image = global::Gestion_inscription.Properties.Resources.search;
            this.Recherche.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Recherche.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Recherche.Name = "Recherche";
            this.Recherche.Size = new System.Drawing.Size(50, 57);
            this.Recherche.Text = " Recherche";
            // 
            // gestion_Utilisateur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1233, 609);
            this.Controls.Add(this.toolStrip1);
            this.Name = "gestion_Utilisateur";
            this.Text = "gestion_Utilisateur";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton Ajouter;
        private System.Windows.Forms.ToolStripButton Modification;
        private System.Windows.Forms.ToolStripButton Suppression;
        private System.Windows.Forms.ToolStripButton Recherche;
    }
}