
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.TreeView_utilisateurs = new System.Windows.Forms.TreeView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.labellogin = new System.Windows.Forms.Label();
            this.textlogin = new System.Windows.Forms.TextBox();
            this.textMotePasse = new System.Windows.Forms.TextBox();
            this.labelpassword = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radioAdmin = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.textPrenom = new System.Windows.Forms.TextBox();
            this.labelprenom = new System.Windows.Forms.Label();
            this.textNom = new System.Windows.Forms.TextBox();
            this.labelnom = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Ajouter = new System.Windows.Forms.ToolStripButton();
            this.Modification = new System.Windows.Forms.ToolStripButton();
            this.Suppression = new System.Windows.Forms.ToolStripButton();
            this.Recherche = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
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
            this.toolStrip1.Size = new System.Drawing.Size(1233, 87);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 87);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox5);
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox1);
            this.splitContainer1.Panel2.Controls.Add(this.TreeView_utilisateurs);
            this.splitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
            this.splitContainer1.Size = new System.Drawing.Size(1233, 625);
            this.splitContainer1.SplitterDistance = 127;
            this.splitContainer1.TabIndex = 1;
            // 
            // TreeView_utilisateurs
            // 
            this.TreeView_utilisateurs.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TreeView_utilisateurs.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.TreeView_utilisateurs.Location = new System.Drawing.Point(12, 15);
            this.TreeView_utilisateurs.Name = "TreeView_utilisateurs";
            this.TreeView_utilisateurs.Size = new System.Drawing.Size(468, 465);
            this.TreeView_utilisateurs.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(506, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(715, 465);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.textMotePasse);
            this.groupBox2.Controls.Add(this.labelpassword);
            this.groupBox2.Controls.Add(this.textlogin);
            this.groupBox2.Controls.Add(this.labellogin);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(15, 21);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(685, 306);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Profile";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // labellogin
            // 
            this.labellogin.AutoSize = true;
            this.labellogin.Location = new System.Drawing.Point(55, 36);
            this.labellogin.Name = "labellogin";
            this.labellogin.Size = new System.Drawing.Size(47, 20);
            this.labellogin.TabIndex = 0;
            this.labellogin.Text = "Login";
            // 
            // textlogin
            // 
            this.textlogin.Location = new System.Drawing.Point(188, 24);
            this.textlogin.Multiline = true;
            this.textlogin.Name = "textlogin";
            this.textlogin.Size = new System.Drawing.Size(214, 32);
            this.textlogin.TabIndex = 1;
            // 
            // textMotePasse
            // 
            this.textMotePasse.Location = new System.Drawing.Point(188, 82);
            this.textMotePasse.Multiline = true;
            this.textMotePasse.Name = "textMotePasse";
            this.textMotePasse.Size = new System.Drawing.Size(214, 32);
            this.textMotePasse.TabIndex = 3;
            // 
            // labelpassword
            // 
            this.labelpassword.AutoSize = true;
            this.labelpassword.Location = new System.Drawing.Point(55, 94);
            this.labelpassword.Name = "labelpassword";
            this.labelpassword.Size = new System.Drawing.Size(107, 20);
            this.labelpassword.TabIndex = 2;
            this.labelpassword.Text = "Mote de passe";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radioButton3);
            this.groupBox3.Controls.Add(this.radioButton2);
            this.groupBox3.Controls.Add(this.radioAdmin);
            this.groupBox3.Location = new System.Drawing.Point(59, 142);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 158);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Neaveau d\'Access";
            // 
            // radioAdmin
            // 
            this.radioAdmin.AutoSize = true;
            this.radioAdmin.Location = new System.Drawing.Point(35, 38);
            this.radioAdmin.Name = "radioAdmin";
            this.radioAdmin.Size = new System.Drawing.Size(104, 24);
            this.radioAdmin.TabIndex = 0;
            this.radioAdmin.TabStop = true;
            this.radioAdmin.Text = "Administra";
            this.radioAdmin.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(35, 68);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(77, 24);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Utilisat";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(35, 98);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(77, 24);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Operat";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.textPrenom);
            this.groupBox4.Controls.Add(this.labelprenom);
            this.groupBox4.Controls.Add(this.textNom);
            this.groupBox4.Controls.Add(this.labelnom);
            this.groupBox4.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(15, 333);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(685, 105);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "identification";
            // 
            // textPrenom
            // 
            this.textPrenom.Location = new System.Drawing.Point(188, 63);
            this.textPrenom.Multiline = true;
            this.textPrenom.Name = "textPrenom";
            this.textPrenom.Size = new System.Drawing.Size(214, 32);
            this.textPrenom.TabIndex = 7;
            // 
            // labelprenom
            // 
            this.labelprenom.AutoSize = true;
            this.labelprenom.Location = new System.Drawing.Point(55, 66);
            this.labelprenom.Name = "labelprenom";
            this.labelprenom.Size = new System.Drawing.Size(63, 20);
            this.labelprenom.TabIndex = 6;
            this.labelprenom.Text = "Prenom";
            // 
            // textNom
            // 
            this.textNom.Location = new System.Drawing.Point(188, 25);
            this.textNom.Multiline = true;
            this.textNom.Name = "textNom";
            this.textNom.Size = new System.Drawing.Size(214, 32);
            this.textNom.TabIndex = 5;
            // 
            // labelnom
            // 
            this.labelnom.AutoSize = true;
            this.labelnom.Location = new System.Drawing.Point(55, 37);
            this.labelnom.Name = "labelnom";
            this.labelnom.Size = new System.Drawing.Size(43, 20);
            this.labelnom.TabIndex = 4;
            this.labelnom.Text = "Nom";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.textBox3);
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Controls.Add(this.textBox4);
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Controls.Add(this.textBox1);
            this.groupBox5.Controls.Add(this.label1);
            this.groupBox5.Controls.Add(this.textBox2);
            this.groupBox5.Controls.Add(this.label2);
            this.groupBox5.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(12, 3);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(1209, 102);
            this.groupBox5.TabIndex = 2;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Reacherche";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(183, 63);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(285, 32);
            this.textBox1.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Mote de passe";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(183, 25);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(285, 32);
            this.textBox2.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Login";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(612, 63);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(277, 32);
            this.textBox3.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(515, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Prenom";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(612, 25);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(277, 32);
            this.textBox4.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(515, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Nom";
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
            this.Modification.Click += new System.EventHandler(this.Modification_Click);
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
            this.Recherche.Click += new System.EventHandler(this.Recherche_Click);
            // 
            // gestion_Utilisateur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1233, 712);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "gestion_Utilisateur";
            this.Text = "gestion_Utilisateur";
            this.Load += new System.EventHandler(this.gestion_Utilisateur_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton Ajouter;
        private System.Windows.Forms.ToolStripButton Modification;
        private System.Windows.Forms.ToolStripButton Suppression;
        private System.Windows.Forms.ToolStripButton Recherche;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TreeView TreeView_utilisateurs;
        private System.Windows.Forms.TextBox textMotePasse;
        private System.Windows.Forms.Label labelpassword;
        private System.Windows.Forms.TextBox textlogin;
        private System.Windows.Forms.Label labellogin;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioAdmin;
        private System.Windows.Forms.TextBox textPrenom;
        private System.Windows.Forms.Label labelprenom;
        private System.Windows.Forms.TextBox textNom;
        private System.Windows.Forms.Label labelnom;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
    }
}