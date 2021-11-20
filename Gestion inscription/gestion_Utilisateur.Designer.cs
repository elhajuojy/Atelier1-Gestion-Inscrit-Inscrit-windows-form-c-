
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
            this.toolStripBtnAjouter = new System.Windows.Forms.ToolStripButton();
            this.Modification = new System.Windows.Forms.ToolStripButton();
            this.Suppression = new System.Windows.Forms.ToolStripButton();
            this.Recherche = new System.Windows.Forms.ToolStripButton();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnchercher = new System.Windows.Forms.Button();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtpw = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtlogin = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAfficher = new System.Windows.Forms.Button();
            this.groupBoxPorfile = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.idPrenom = new System.Windows.Forms.TextBox();
            this.labelprenom = new System.Windows.Forms.Label();
            this.idNom = new System.Windows.Forms.TextBox();
            this.labelnom = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radioOperat = new System.Windows.Forms.RadioButton();
            this.radioUtilisat = new System.Windows.Forms.RadioButton();
            this.radioAdmin = new System.Windows.Forms.RadioButton();
            this.textMotePasseProfile = new System.Windows.Forms.TextBox();
            this.labelpassword = new System.Windows.Forms.Label();
            this.textloginProfile = new System.Windows.Forms.TextBox();
            this.labellogin = new System.Windows.Forms.Label();
            this.TreeView_utilisateurs = new System.Windows.Forms.TreeView();
            this.btnclear = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBoxPorfile.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripBtnAjouter,
            this.Modification,
            this.Suppression,
            this.Recherche,
            this.btnclear});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1233, 86);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // toolStripBtnAjouter
            // 
            this.toolStripBtnAjouter.AutoSize = false;
            this.toolStripBtnAjouter.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripBtnAjouter.Image = global::Gestion_inscription.Properties.Resources.plus__1_;
            this.toolStripBtnAjouter.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripBtnAjouter.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnAjouter.Name = "toolStripBtnAjouter";
            this.toolStripBtnAjouter.Size = new System.Drawing.Size(50, 57);
            this.toolStripBtnAjouter.Text = "Ajouter";
            this.toolStripBtnAjouter.Click += new System.EventHandler(this.toolStripBtnAjouter_Click);
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
            this.Suppression.Click += new System.EventHandler(this.Suppression_Click);
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
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 86);
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
            this.splitContainer1.Panel2.Controls.Add(this.btnAfficher);
            this.splitContainer1.Panel2.Controls.Add(this.groupBoxPorfile);
            this.splitContainer1.Panel2.Controls.Add(this.TreeView_utilisateurs);
            this.splitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
            this.splitContainer1.Size = new System.Drawing.Size(1233, 626);
            this.splitContainer1.SplitterDistance = 109;
            this.splitContainer1.TabIndex = 1;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnchercher);
            this.groupBox5.Controls.Add(this.txtPrenom);
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Controls.Add(this.txtNom);
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Controls.Add(this.txtpw);
            this.groupBox5.Controls.Add(this.label1);
            this.groupBox5.Controls.Add(this.txtlogin);
            this.groupBox5.Controls.Add(this.label2);
            this.groupBox5.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(12, 3);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(1209, 102);
            this.groupBox5.TabIndex = 2;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Reacherche";
            // 
            // btnchercher
            // 
            this.btnchercher.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnchercher.Image = global::Gestion_inscription.Properties.Resources.btFiltre22;
            this.btnchercher.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnchercher.Location = new System.Drawing.Point(916, 63);
            this.btnchercher.Name = "btnchercher";
            this.btnchercher.Size = new System.Drawing.Size(136, 33);
            this.btnchercher.TabIndex = 3;
            this.btnchercher.Text = "Chercher";
            this.btnchercher.UseVisualStyleBackColor = true;
            this.btnchercher.Click += new System.EventHandler(this.btnchercher_Click);
            // 
            // txtPrenom
            // 
            this.txtPrenom.Location = new System.Drawing.Point(612, 63);
            this.txtPrenom.Multiline = true;
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(277, 32);
            this.txtPrenom.TabIndex = 11;
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
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(612, 25);
            this.txtNom.Multiline = true;
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(277, 32);
            this.txtNom.TabIndex = 9;
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
            // txtpw
            // 
            this.txtpw.Location = new System.Drawing.Point(183, 63);
            this.txtpw.Multiline = true;
            this.txtpw.Name = "txtpw";
            this.txtpw.Size = new System.Drawing.Size(285, 32);
            this.txtpw.TabIndex = 7;
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
            // txtlogin
            // 
            this.txtlogin.Location = new System.Drawing.Point(183, 25);
            this.txtlogin.Multiline = true;
            this.txtlogin.Name = "txtlogin";
            this.txtlogin.Size = new System.Drawing.Size(285, 32);
            this.txtlogin.TabIndex = 5;
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
            // btnAfficher
            // 
            this.btnAfficher.Location = new System.Drawing.Point(372, 15);
            this.btnAfficher.Name = "btnAfficher";
            this.btnAfficher.Size = new System.Drawing.Size(108, 39);
            this.btnAfficher.TabIndex = 2;
            this.btnAfficher.Text = "Afficher";
            this.btnAfficher.UseVisualStyleBackColor = true;
            this.btnAfficher.Click += new System.EventHandler(this.btnAfficher_Click);
            // 
            // groupBoxPorfile
            // 
            this.groupBoxPorfile.Controls.Add(this.groupBox4);
            this.groupBoxPorfile.Controls.Add(this.groupBox2);
            this.groupBoxPorfile.Location = new System.Drawing.Point(506, 15);
            this.groupBoxPorfile.Name = "groupBoxPorfile";
            this.groupBoxPorfile.Size = new System.Drawing.Size(715, 495);
            this.groupBoxPorfile.TabIndex = 1;
            this.groupBoxPorfile.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.idPrenom);
            this.groupBox4.Controls.Add(this.labelprenom);
            this.groupBox4.Controls.Add(this.idNom);
            this.groupBox4.Controls.Add(this.labelnom);
            this.groupBox4.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(15, 333);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(685, 105);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "identification";
            // 
            // idPrenom
            // 
            this.idPrenom.Location = new System.Drawing.Point(188, 63);
            this.idPrenom.Multiline = true;
            this.idPrenom.Name = "idPrenom";
            this.idPrenom.Size = new System.Drawing.Size(214, 32);
            this.idPrenom.TabIndex = 7;
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
            // idNom
            // 
            this.idNom.Location = new System.Drawing.Point(188, 25);
            this.idNom.Multiline = true;
            this.idNom.Name = "idNom";
            this.idNom.Size = new System.Drawing.Size(214, 32);
            this.idNom.TabIndex = 5;
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.textMotePasseProfile);
            this.groupBox2.Controls.Add(this.labelpassword);
            this.groupBox2.Controls.Add(this.textloginProfile);
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
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radioOperat);
            this.groupBox3.Controls.Add(this.radioUtilisat);
            this.groupBox3.Controls.Add(this.radioAdmin);
            this.groupBox3.Location = new System.Drawing.Point(59, 135);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 165);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Neaveau d\'Access";
            // 
            // radioOperat
            // 
            this.radioOperat.AutoSize = true;
            this.radioOperat.Location = new System.Drawing.Point(35, 98);
            this.radioOperat.Name = "radioOperat";
            this.radioOperat.Size = new System.Drawing.Size(77, 24);
            this.radioOperat.TabIndex = 2;
            this.radioOperat.TabStop = true;
            this.radioOperat.Text = "Operat";
            this.radioOperat.UseVisualStyleBackColor = true;
            // 
            // radioUtilisat
            // 
            this.radioUtilisat.AutoSize = true;
            this.radioUtilisat.Location = new System.Drawing.Point(35, 68);
            this.radioUtilisat.Name = "radioUtilisat";
            this.radioUtilisat.Size = new System.Drawing.Size(77, 24);
            this.radioUtilisat.TabIndex = 1;
            this.radioUtilisat.TabStop = true;
            this.radioUtilisat.Text = "Utilisat";
            this.radioUtilisat.UseVisualStyleBackColor = true;
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
            // textMotePasseProfile
            // 
            this.textMotePasseProfile.Location = new System.Drawing.Point(188, 82);
            this.textMotePasseProfile.Multiline = true;
            this.textMotePasseProfile.Name = "textMotePasseProfile";
            this.textMotePasseProfile.Size = new System.Drawing.Size(214, 32);
            this.textMotePasseProfile.TabIndex = 3;
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
            // textloginProfile
            // 
            this.textloginProfile.Location = new System.Drawing.Point(188, 24);
            this.textloginProfile.Multiline = true;
            this.textloginProfile.Name = "textloginProfile";
            this.textloginProfile.Size = new System.Drawing.Size(214, 32);
            this.textloginProfile.TabIndex = 1;
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
            // TreeView_utilisateurs
            // 
            this.TreeView_utilisateurs.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TreeView_utilisateurs.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.TreeView_utilisateurs.LineColor = System.Drawing.Color.DarkOrange;
            this.TreeView_utilisateurs.Location = new System.Drawing.Point(12, 60);
            this.TreeView_utilisateurs.Name = "TreeView_utilisateurs";
            this.TreeView_utilisateurs.PathSeparator = "*";
            this.TreeView_utilisateurs.Size = new System.Drawing.Size(468, 465);
            this.TreeView_utilisateurs.TabIndex = 0;
            // 
            // btnclear
            // 
            this.btnclear.AutoSize = false;
            this.btnclear.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnclear.Image = global::Gestion_inscription.Properties.Resources.btFermer32;
            this.btnclear.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnclear.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(50, 57);
            this.btnclear.Text = "clear ";
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
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
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBoxPorfile.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton Modification;
        private System.Windows.Forms.ToolStripButton Suppression;
        private System.Windows.Forms.ToolStripButton Recherche;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBoxPorfile;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TreeView TreeView_utilisateurs;
        private System.Windows.Forms.TextBox textMotePasseProfile;
        private System.Windows.Forms.Label labelpassword;
        private System.Windows.Forms.TextBox textloginProfile;
        private System.Windows.Forms.Label labellogin;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton radioOperat;
        private System.Windows.Forms.RadioButton radioUtilisat;
        private System.Windows.Forms.RadioButton radioAdmin;
        private System.Windows.Forms.TextBox idPrenom;
        private System.Windows.Forms.Label labelprenom;
        private System.Windows.Forms.TextBox idNom;
        private System.Windows.Forms.Label labelnom;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtpw;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtlogin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnchercher;
        public System.Windows.Forms.ToolStripButton toolStripBtnAjouter;
        private System.Windows.Forms.Button btnAfficher;
        private System.Windows.Forms.ToolStripButton btnclear;
    }
}