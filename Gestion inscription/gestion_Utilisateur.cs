using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;


namespace Gestion_inscription
{
    public partial class gestion_Utilisateur : Form
    {
        // connection string 
        string CnxString = ConfigurationManager.ConnectionStrings["CtnStrinscrits"].ConnectionString;
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

        private void Modification_Click(object sender, EventArgs e)
        {

            //CnxString is defined as public 

            SqlConnection ctn = new SqlConnection(CnxString);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText= "select * from utilisateurs where profile='a';";
            cmd.Connection = ctn;
            ctn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            this.TreeView_utilisateurs.Nodes.Add("Administra");
            while (dr.Read())
            {
                TreeNode node = new TreeNode(dr["login"].ToString());
                node.Nodes.Add(dr["profile"].ToString());
                node.Nodes.Add(dr["nom"].ToString());
                this.TreeView_utilisateurs.Nodes.Add(node);


            }
            ctn.Close();
            dr.Close();



            cmd.CommandText = "select * from utilisateurs where profile='u';";
            cmd.Connection = ctn;
            ctn.Open();
            SqlDataReader dr1 = cmd.ExecuteReader();
            this.TreeView_utilisateurs.Nodes.Add("Utilisat");
            
            while (dr1.Read())
            {
                TreeNode node1 = new TreeNode(dr1["login"].ToString());
                node1.Nodes.Add(dr1["profile"].ToString());
                node1.Nodes.Add(dr1["nom"].ToString());
                this.TreeView_utilisateurs.Nodes.Add(node1);


            }
            ctn.Close();
            dr1.Close();


        }
    }
}
