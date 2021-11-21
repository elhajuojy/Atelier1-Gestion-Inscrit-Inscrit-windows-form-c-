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
        //create mdiparent object for active toolstrip in connexion form 
        public static gestion_Utilisateur object_gestionUtilisateur;
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
            SqlConnection ctn = new SqlConnection(CnxString);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "UPDATE utilisateurs SET  pw = @pw, profile = @profile, nom =@nom, prenom = @prenom ,fonction= @function where login = @wherelogin ";
            cmd.Connection = ctn;

            cmd.Parameters.AddWithValue("@login", textloginProfile.Text);
            cmd.Parameters.AddWithValue("@wherelogin", textloginProfile.Text);
            cmd.Parameters.AddWithValue("@pw", textMotePasseProfile.Text);
            cmd.Parameters.AddWithValue("@nom", idNom.Text);
            cmd.Parameters.AddWithValue("@prenom", idPrenom.Text);
            

            if (radioAdmin.Checked == true)
             {
                 cmd.Parameters.AddWithValue("@profile", 'a');
                 cmd.Parameters.AddWithValue("@function", "Administra");

             }
             else if (radioUtilisat.Checked == true)
             {
                 cmd.Parameters.AddWithValue("@profile", 'u');
                 cmd.Parameters.AddWithValue("@function", "Utilisat");
             }
             else
             {
                 cmd.Parameters.AddWithValue("@profile", 'o');
                 cmd.Parameters.AddWithValue("@function", "Operat");
             }

            ctn.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            if (textloginProfile.Text == string.Empty & textMotePasseProfile.Text==string.Empty)
            {
                MessageBox.Show("les zone de text login est vide");
                
            }

            else if (textloginProfileTobeRemmberd == textloginProfile.Text)
            {
               

                MessageBox.Show(" Profile de :  " + textloginProfile.Text + " est Modifi", "Rows Effected");
            }
            else
            {
                MessageBox.Show("no possible de changer le login ");
            }
            ctn.Close();
            dr.Close();
            

        }

        private void toolStripBtnAjouter_Click(object sender, EventArgs e)
        {

            try
            {

                SqlConnection ctn = new SqlConnection(CnxString);
                SqlCommand cmd = new SqlCommand();

                cmd.CommandText = "insert into utilisateurs values (@login,@pw,@profile,@nom,@prenom,@function);";
                cmd.Connection = ctn;




                cmd.Parameters.AddWithValue("@login", textloginProfile.Text);
                cmd.Parameters.AddWithValue("@pw", textMotePasseProfile.Text);
                cmd.Parameters.AddWithValue("@nom", idNom.Text);
                cmd.Parameters.AddWithValue("@prenom", idPrenom.Text);

                if (textloginProfile.Text != string.Empty & textMotePasseProfile.Text != string.Empty)
                {
                    if (radioAdmin.Checked == true)
                    {
                        cmd.Parameters.AddWithValue("@profile", 'a');
                        cmd.Parameters.AddWithValue("@function", "Administra");

                    }
                    else if (radioUtilisat.Checked == true)
                    {
                        cmd.Parameters.AddWithValue("@profile", 'u');
                        cmd.Parameters.AddWithValue("@function", "Utilisat");
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@profile", 'o');
                        cmd.Parameters.AddWithValue("@function", "Operat");
                    }

                    ctn.Open();

                    int rowseffected = cmd.ExecuteNonQuery();
                    MessageBox.Show("New inscrit is add :  " + textloginProfile.Text, "new inscrit");

                    ctn.Close();

                    textloginProfile.Enabled = true;
                    textloginProfile.Text = string.Empty;
                    textMotePasseProfile.Text = string.Empty;
                    idNom.Text = string.Empty;
                    idPrenom.Text = string.Empty;
                    radioAdmin.Checked = false;
                    radioUtilisat.Checked = false;
                    radioOperat.Checked = false;
                    TreeView_utilisateurs.Nodes.Clear();
                    txtlogin.Text = string.Empty;
                    txtNom.Text = string.Empty;
                    txtPrenom.Text = string.Empty;
                    txtpw.Text = string.Empty;
                    splitContainer1.Panel1Collapsed = true;
                }
                else
                {
                    MessageBox.Show("Fill les zone de text ", "excpetion");
                }

            }
            catch
            {
                MessageBox.Show("ne peut pas ajouter le meme login ", "Exception");
            }


        }
        string textloginProfileTobeRemmberd;
        private void btnchercher_Click(object sender, EventArgs e)
        {
            SqlConnection ctn = new SqlConnection(CnxString);
            SqlCommand cmd = new SqlCommand();
            
           

            cmd.CommandText = "select * from utilisateurs where login=@login or pw=@pw or nom=@nom or prenom=@prenom";
            cmd.Connection = ctn;

            cmd.Parameters.AddWithValue("@login", txtlogin.Text);
            cmd.Parameters.AddWithValue("@pw", txtpw.Text);
            cmd.Parameters.AddWithValue("@nom", txtNom.Text);
            cmd.Parameters.AddWithValue("@prenom", txtPrenom.Text);

            ctn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            
            if (dr.Read())
            {
                TreeView_utilisateurs.Nodes.Clear();

                TreeNode node = new TreeNode(dr["login"].ToString());
                node.Nodes.Add("Password    :  "+dr["pw"].ToString());
                node.Nodes.Add("Profile     :  "+dr["profile"].ToString());
                node.Nodes.Add("nom         :  "+dr["nom"].ToString());
                node.Nodes.Add("prenom      :   "+dr["prenom"].ToString());
                node.Nodes.Add("fonction    :   "+dr["fonction"].ToString());
                node.Nodes.Add("code_utilisateur :   "+dr["code_utilisateur"].ToString());

                


                this.TreeView_utilisateurs.Nodes.Add(node);


                textloginProfile.Text = dr["login"].ToString();
                textMotePasseProfile.Text = dr["pw"].ToString();
                textloginProfileTobeRemmberd = dr["login"].ToString();
                idNom.Text = dr["nom"].ToString();
                idPrenom.Text = dr["prenom"].ToString();
                if (dr["profile"].ToString() == "a")
                {
                    radioAdmin.Checked = true;
                }
                else if(dr["profile"].ToString() == "u")
                {
                    radioUtilisat.Checked = true;
                }
                else
                {
                    radioOperat.Checked = true;
                }
                textloginProfile.Enabled = false;

                btnAfficher_Click(sender,e);

            }
            else
            {
                MessageBox.Show("no personne trouve ");
            }
            ctn.Close();
            dr.Close();

        }

        private void btnAfficher_Click(object sender, EventArgs e)
        {
            TreeView_utilisateurs.Nodes.Clear();
            //CnxString is defined as public 

            SqlConnection ctn = new SqlConnection(CnxString);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "select * from utilisateurs where profile='a';";
            cmd.Connection = ctn;
            ctn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            this.TreeView_utilisateurs.Nodes.Add("Administra");
            
            {

            }
            while (dr.Read())
            {
                
                TreeNode node = new TreeNode(dr["login"].ToString());
                node.Nodes.Add("Password    :  " + dr["pw"].ToString());
                node.Nodes.Add("Profile     :  " + dr["profile"].ToString());
                node.Nodes.Add("nom         :  " + dr["nom"].ToString());
                node.Nodes.Add("prenom      :   " + dr["prenom"].ToString());
                node.Nodes.Add("fonction    :   " + dr["fonction"].ToString());
                node.Nodes.Add("code_utilisateur :   " + dr["code_utilisateur"].ToString());

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
                
                node1.Nodes.Add("Password    :  " + dr1["pw"].ToString());
                node1.Nodes.Add("Profile     :  " + dr1["profile"].ToString());
                node1.Nodes.Add("nom         :  " + dr1["nom"].ToString());
                node1.Nodes.Add("prenom      :   " + dr1["prenom"].ToString());
                node1.Nodes.Add("fonction    :   " + dr1["fonction"].ToString());
                node1.Nodes.Add("code_utilisateur :   " + dr1["code_utilisateur"].ToString());

                this.TreeView_utilisateurs.Nodes.Add(node1);
                this.TreeView_utilisateurs.ForeColor = Color.Blue;

            }
            ctn.Close();
            dr1.Close();

            cmd.CommandText = "select * from utilisateurs where profile='o';";
            cmd.Connection = ctn;

            ctn.Open();

            SqlDataReader dr2 = cmd.ExecuteReader();

            this.TreeView_utilisateurs.Nodes.Add("Operat");
            

            while (dr2.Read())
            {
               
                TreeNode node2 = new TreeNode(dr2["login"].ToString());
                node2.Nodes.Add("Password    :  " + dr2["pw"].ToString());
                node2.Nodes.Add("Profile     :  " + dr2["profile"].ToString());
                node2.Nodes.Add("nom         :  " + dr2["nom"].ToString());
                node2.Nodes.Add("prenom      :   " + dr2["prenom"].ToString());
                node2.Nodes.Add("fonction    :   " + dr2["fonction"].ToString());
                node2.Nodes.Add("code_utilisateur :   " + dr2["code_utilisateur"].ToString());

                this.TreeView_utilisateurs.Nodes.Add(node2);


            }
            ctn.Close();
            dr2.Close();
        }

        private void Suppression_Click(object sender, EventArgs e)
        {
            SqlConnection ctn = new SqlConnection(CnxString);
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "DELETE FROM utilisateurs where login=@login ";
            cmd.Connection = ctn;
            cmd.Parameters.AddWithValue("@login", txtlogin.Text);
            

            ctn.Open();
            int deleteLines =  cmd.ExecuteNonQuery();
            MessageBox.Show("la suppersion bien effectuer ! "+txtlogin.Text);





        }

        private void btnclear_Click(object sender, EventArgs e)
        {

            textloginProfile.Enabled = true;
            textloginProfile.Text = string.Empty;
            textMotePasseProfile.Text = string.Empty;
            idNom.Text = string.Empty;
            idPrenom.Text = string.Empty;
            radioAdmin.Checked = false;
            radioUtilisat.Checked = false;
            radioOperat.Checked = false;
            TreeView_utilisateurs.Nodes.Clear();
            txtlogin.Text = string.Empty;
            txtNom.Text = string.Empty;
            txtPrenom.Text = string.Empty;
            txtpw.Text = string.Empty;
            splitContainer1.Panel1Collapsed = true;
        }


    }
}
