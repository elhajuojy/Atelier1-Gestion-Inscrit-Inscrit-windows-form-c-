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
using System.Data.Common;
using System.Configuration;

namespace Gestion_inscription
{
    public partial class Gestion_des_Notes : Form
    {
        public Gestion_des_Notes()
        {
            InitializeComponent();
        }

        // connection string 
        string CnxString = ConfigurationManager.ConnectionStrings["CtnStrinscrits"].ConnectionString;



        DataTable table;
        DataTable tb1;
        DataTable tb2;
        SqlDataAdapter da = new SqlDataAdapter();
        SqlDataAdapter da1 = new SqlDataAdapter();
        SqlDataAdapter da2 = new SqlDataAdapter();

        DataSet ds = new DataSet();
        DataSet ds1 = new DataSet();
        DataSet ds2 = new DataSet();
        BindingSource tbinding = new BindingSource();
        BindingSource tbinding1 = new BindingSource();
        BindingSource tbinding2 = new BindingSource();

        SqlConnection ctn;


        private void btnFremer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void Gestion_des_Notes_Load(object sender, EventArgs e)
        {

            table = new DataTable();
            ctn = new SqlConnection(CnxString);
            SqlCommand cmd = new SqlCommand("select * from inscrits", ctn);
            
            da.SelectCommand = cmd;

            da.Fill(ds, "inscrits");
            table = ds.Tables["inscrits"];


            tbinding.DataSource = ds.Tables["inscrits"];

            


            tb1 = new DataTable();
            SqlCommand cmd1 = new SqlCommand();
             
            cmd1.Connection = ctn;
            cmd1.CommandText = "select * from modules";
            da1.SelectCommand = cmd1;

            da1.Fill(ds1, "modules");
            //tbinding1.DataSource = ds1.Tables["modules"];
            tb1 = ds1.Tables["modules"];

            tb2 = new DataTable();
            SqlCommand cmd2 = new SqlCommand();
            SqlDataAdapter da2 = new SqlDataAdapter();
            cmd2.Connection = ctn;
            cmd2.CommandText = "select * from notes inner join  inscrits on notes.num_inscrit = inscrits.num_inscrit ";
            da2.SelectCommand = cmd2;
            da2.Fill(ds2, "notes");
            tb2 = ds2.Tables["notes"];
            



            float c1 = float.Parse(textControle1.Text);
            float c2 = float.Parse(textControle2.Text);
            float NoteEfm = float.Parse(textEFM.Text);

            Moyenne = (c1 + c2 + NoteEfm + 2) / 4;



        }
        int index;
        private void btnRecherche_Click(object sender, EventArgs e)
        {





            



            table.DefaultView.Sort = ("num_inscrit ASC");

            
            index = table.DefaultView.Find(textNumStagaire.Text);



            if (textNumStagaire.Text==string.Empty & textNom.Text==string.Empty & textPrenom.Text==string.Empty)
            {
                MessageBox.Show(" fill les zone de text  ");
            }
            else if (index == -1)
            {
                

                MessageBox.Show("il ezxiste aucan statgaire ");
            }
            else
            {

                textNumStagaire.Text= table.Rows[index][0].ToString() ;
                textNom.Text = table.Rows[index][1].ToString();
                textPrenom.Text= table.Rows[index][2].ToString() ;

                comboBoxModule.DataSource = ds1.Tables["modules"];
                comboBoxModule.DisplayMember = "lib_module";
                comboBoxModule.ValueMember = "code_module";


                comboBoxModule.DataSource = ds2.Tables["notes"];
                comboBoxModule.DisplayMember = "num_semestre";
                comboBoxModule.ValueMember = "num_semestre";

               
              
            }
        }

        private void btnSuivant_Click(object sender, EventArgs e)
        {

           
            table.DefaultView.Sort = ("num_inscrit ASC");


            index = table.DefaultView.Find(textNumStagaire.Text);

            
            if (index > -1)
            {

                textNumStagaire.Text = table.Rows[index+1][0].ToString();
                textNom.Text = table.Rows[index+1][1].ToString();
                textPrenom.Text = table.Rows[index+1][2].ToString();

            }
            else
            {
                MessageBox.Show("last one");
            }
           
        }

        float Moyenne;
        private void btnPre_Click(object sender, EventArgs e)
        {

            try
            {
                table.DefaultView.Sort = ("num_inscrit ASC");


                index = table.DefaultView.Find(textNumStagaire.Text);


                if (index > -1)
                {

                    textNumStagaire.Text = table.Rows[index - 1][0].ToString();
                    textNom.Text = table.Rows[index - 1][1].ToString();
                    textPrenom.Text = table.Rows[index - 1][2].ToString();

                }
                else
                {
                    MessageBox.Show(" one");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Exception");
            }

           

        }

        private void btnEnrrgistrer_Click(object sender, EventArgs e)
        {
            SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(da2);


            tb2.Rows[index][3] = Moyenne;

            da.Update(tb2);
           
            labelMoyenne.Text = Moyenne.ToString();   
        }

        private void btnsupprimer_Click(object sender, EventArgs e)
        {


            if (textControle1.Text == string.Empty & textControle2.Text == string.Empty & textEFM.Text == string.Empty)
            {
                MessageBox.Show(" fill les zone de text  ");
            }
            else
            {
                tb1.DefaultView.Sort = ("num_inscrit ASC");


                index = table.DefaultView.Find(textNumStagaire.Text);
                tb1.DefaultView.Delete(index); 
                tb1.AcceptChanges();



            }


        }
    }
}
