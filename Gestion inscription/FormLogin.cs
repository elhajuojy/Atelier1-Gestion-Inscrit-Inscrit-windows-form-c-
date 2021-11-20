using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace Gestion_inscription
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        // connection string 
        string CnxString = ConfigurationManager.ConnectionStrings["CtnStrinscrits"].ConnectionString;
        private void btnConneter_Click(object sender, EventArgs e)
        {
            //try
            //{

                //CnxString is defined as public 

                SqlConnection ctn = new SqlConnection(CnxString);

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = ctn;
                cmd.CommandText = "sp_authentification";
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter paramLogin = new SqlParameter();
                paramLogin.Direction = ParameterDirection.Input;

                // using paramters 
                paramLogin = new SqlParameter("@login", textLogin.Text);
                paramLogin.Direction = ParameterDirection.Input;
                cmd.Parameters.Add(paramLogin);

                SqlParameter paramPW = new SqlParameter("@pw", textpass.Text);
                paramPW.Direction = ParameterDirection.Input;
                cmd.Parameters.Add(paramPW);
                
                //open 
                ctn.Open();
                SqlDataReader dr;
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {

                    // passe login information from form to another using static classe 

                    LoginPass.varlog = textLogin.Text;
                    LoginPass.varlpass = textpass.Text;



                    //Enbabled Toostrip from MdiParent1
                    GestionInscrit.object_GestionIn.TooStrip.Enabled = true;
                    GestionInscrit.object_GestionIn.LabelForUpperName.Text = LoginPass.varlog.ToString();
                    GestionInscrit.object_GestionIn.notationsToolStrip.Enabled = true;
                    GestionInscrit.object_GestionIn.FilieresToolStrip.Enabled = true;
                    GestionInscrit.object_GestionIn.gestionUtilisateurToolStrip.Enabled = true;
                    GestionInscrit.object_GestionIn.inscrptionsToolStrip.Enabled = true;
                    GestionInscrit.object_GestionIn.FilieresToolStrip.Enabled = true;
                    GestionInscrit.object_GestionIn.inscrptionsToolStrip.Enabled = true;
                    GestionInscrit.object_GestionIn.notesToolStrip.Enabled = true;
                    GestionInscrit.object_GestionIn.modulesToolStrip.Enabled = true;
                    GestionInscrit.object_GestionIn.parametresToolStrip.Enabled = true;
                    GestionInscrit.object_GestionIn.inscriptionsToolStrip.Enabled = true;
                    GestionInscrit.object_GestionIn.connexionToolStripMenuItem.Text = "Deconnexion";

                    //notify me when login is true 

                    notifyMe.ShowBalloonTip(1000, "les connection ", "you are in ", ToolTipIcon.Info);

                    this.Close();



                }
                else
                {
                    labelPasswordfalse.Text = "your password is incorrect";

                }
                ctn.Close();
                dr.Close();
            //}

            //catch (Exception ex)
            //{
            //    MessageBox.Show("Exception", ex.ToString());
            //}
            //finally
            //{

            //}
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == false)
            {
                textpass.UseSystemPasswordChar = false;



            }

            if (checkBox1.Checked)
            {
                textpass.UseSystemPasswordChar = true;


            }
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            textLogin.Text = string.Empty;
            textpass.Text = string.Empty;
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
           
        }
    }
}
