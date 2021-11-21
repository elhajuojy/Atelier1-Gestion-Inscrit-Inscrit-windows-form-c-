using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_inscription
{
    public partial class GestionInscrit : Form
    {
        //create mdiparent object for active toolstrip in connexion form 
        public static GestionInscrit object_GestionIn;



        public GestionInscrit()
        {
            InitializeComponent();
        }

        private void connexionToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (connexionToolStripMenuItem.Text == "Connexion")
            {
                FormLogin ConxFrm = new FormLogin();
                ConxFrm.MdiParent = this;
                ConxFrm.Show();
                // fill mdiParent with connexion form 
                ConxFrm.Dock = DockStyle.Fill;
                // mdi parent object
                object_GestionIn = this;
            }
            else
            {


                FormLogin ConxFrm = new FormLogin();
                ConxFrm.MdiParent = this;
                ConxFrm.Dock = DockStyle.Fill;
                ConxFrm.Show();
                object_GestionIn = this;


                GestionInscrit.object_GestionIn.TooStrip.Enabled = false;
                GestionInscrit.object_GestionIn.notationsToolStrip.Enabled = false;
                GestionInscrit.object_GestionIn.FilieresToolStrip.Enabled = false;
                GestionInscrit.object_GestionIn.gestionUtilisateurToolStrip.Enabled = false;
                GestionInscrit.object_GestionIn.inscrptionsToolStrip.Enabled = false;
                GestionInscrit.object_GestionIn.FilieresToolStrip.Enabled = false;
                GestionInscrit.object_GestionIn.inscrptionsToolStrip.Enabled = false;
                GestionInscrit.object_GestionIn.notesToolStrip.Enabled = false;
                GestionInscrit.object_GestionIn.modulesToolStrip.Enabled = false;
                GestionInscrit.object_GestionIn.parametresToolStrip.Enabled = false;
                GestionInscrit.object_GestionIn.inscriptionsToolStrip.Enabled = false; 
                GestionInscrit.object_GestionIn.connexionToolStripMenuItem.Text = "Connexion";
                //gestion_Utilisateur.object_gestionUtilisateur.closeformthis();
            }

        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void TooStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void GestionInscrit_Load(object sender, EventArgs e)
        {
            
        }

        private void BtnNewinscrit_Click(object sender, EventArgs e)
        {
            gestion_Utilisateur geform = new gestion_Utilisateur();
            geform.MdiParent = this;
            geform.Show();
            // fill mdiParent with connexion form 
            geform.Dock = DockStyle.Fill;
            // mdi parent object
            object_GestionIn = this;
        }

        private void gestionUtilisateurToolStrip_Click(object sender, EventArgs e)
        {
            GestionInscrit.object_GestionIn.LabelForUpperName.Text = string.Empty;
            gestion_Utilisateur geform = new gestion_Utilisateur();
            geform.MdiParent = this;
            geform.Show();
            // fill mdiParent with connexion form 
            geform.Dock = DockStyle.Fill;
            // mdi parent object
            object_GestionIn = this;
        }

        private void modulesToolStrip_Click(object sender, EventArgs e)
        {
            FrmAjoModModule ModuleFrm = new FrmAjoModModule();
            ModuleFrm.MdiParent = this;
            ModuleFrm.Show();
            // fill mdiParent with connexion form 
            ModuleFrm.Dock = DockStyle.Fill;
            // mdi parent object
            object_GestionIn = this;
        }
    }
}
