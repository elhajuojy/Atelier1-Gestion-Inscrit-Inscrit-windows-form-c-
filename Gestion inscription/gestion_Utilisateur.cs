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
    public partial class gestion_Utilisateur : Form
    {
        public gestion_Utilisateur()
        {
            InitializeComponent();
        }

        private void gestion_Utilisateur_Load(object sender, EventArgs e)
        {
            splitContainer1.Panel1Collapsed = true;
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void Recherche_Click(object sender, EventArgs e)
        {
            if (splitContainer1.Panel1Collapsed == true)
            {
                splitContainer1.Panel1Collapsed = false;
            }
            else
            {
                splitContainer1.Panel1Collapsed = true;
            }
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
