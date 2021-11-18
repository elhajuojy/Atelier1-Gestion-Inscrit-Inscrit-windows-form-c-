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
            try
            {

                //CnxString is defined as public 

                SqlConnection ctn = new SqlConnection(CnxString);

                SqlCommand cmd = new SqlCommand("select login , pw  from utilisateurs where login = @login and pw = @pw;", ctn);

                // using paramters 
                SqlParameter paramLogin = new SqlParameter("@login", textLogin.Text);
                paramLogin.Direction = ParameterDirection.Input;
                cmd.Parameters.Add(paramLogin);

                SqlParameter paramPW = new SqlParameter("@pw", textpass.Text);
                paramPW.Direction = ParameterDirection.Input;
                cmd.Parameters.Add(paramPW);

                ctn.Open();
                SqlDataReader dr;
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {

                    // passe login information from form to another using static classe 

                    LoginPass.varlog = textLogin.Text;
                    LoginPass.varlpass = textpass.Text;



                    //Enbabled Toostrip from MdiParent1
                    GestionInscrit.mdiobject.TooStrip.Enabled = true;
                    GestionInscrit.mdiobject.LabelForUpperName.Text = LoginPass.varlog.ToString();
                    GestionInscrit.mdiobject.notationsToolStrip.Enabled = true;
                    GestionInscrit.mdiobject.FilieresToolStrip.Enabled = true;
                    GestionInscrit.mdiobject.gestionUtilisateurToolStrip.Enabled = true;
                    GestionInscrit.mdiobject.inscrptionsToolStrip.Enabled = true;
                    GestionInscrit.mdiobject.FilieresToolStrip.Enabled = true;
                    GestionInscrit.mdiobject.inscrptionsToolStrip.Enabled = true;
                    GestionInscrit.mdiobject.notesToolStrip.Enabled = true;
                    GestionInscrit.mdiobject.modulesToolStrip.Enabled = true;
                    GestionInscrit.mdiobject.parametresToolStrip.Enabled = true;
                    GestionInscrit.mdiobject.inscriptionsToolStrip.Enabled = true;

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
            }

            catch (Exception ex)
            {
                MessageBox.Show("Exception", ex.ToString());
            }
            finally
            {

            }
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
    }
}
