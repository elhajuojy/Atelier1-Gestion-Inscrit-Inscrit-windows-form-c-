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

            FormLogin c1 = new FormLogin();
            c1.MdiParent = this;
            c1.Show();
            // fill mdiParent with connexion form 
            c1.Dock = DockStyle.Fill;
            // mdi parent object
            object_GestionIn = this;

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
    }
}
