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
using System.Data.Common;

namespace Gestion_inscription
{
    public partial class group : Form
    {
        public group()
        {
            InitializeComponent();
        }
        // connection string 
        string CnxString = ConfigurationManager.ConnectionStrings["CtnStrinscrits"].ConnectionString;
        DataTable table;
        SqlDataAdapter da = new SqlDataAdapter();
        DataSet ds = new DataSet();
        BindingSource bds = new BindingSource();

        private void btnFrmer_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        int Anne;
        private void btnAjouter_Click(object sender, EventArgs e)
        {
            
            if (radioButton1.Checked == true)
            {
                Anne = 1;
            }
            else
            {
                Anne = 2;
            }

            DataRow ligne = table.NewRow();


            ligne["code_groupe"] = textcode_groupe.Text;
            ligne["nom_groupe"] = textnom_groupe.Text;
            ligne["anee"] = Anne;

            table.Rows.Add(ligne);

            MessageBox.Show(ligne[1].ToString() + "  est Ajouter ", "Ajouter groupe");
        }

        private void group_Load(object sender, EventArgs e)
        {
            SqlConnection ctn = new SqlConnection(CnxString);

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = ctn;

            cmd.CommandText = " select * from  groupe ";
            da.SelectCommand = cmd;

            da.Fill(ds, "groupe");
            table = ds.Tables["groupe"];

           
            bds.DataSource = ds.Tables["groupe"];
            textcode_groupe.DataBindings.Add(new Binding("Text", bds, "code_groupe"));
            textnom_groupe.DataBindings.Add(new Binding("Text", bds, "nom_groupe"));
            



        }
        int index;
        private void btnRecherche_Click(object sender, EventArgs e)
        {

            table.DefaultView.Sort = ("code_gorupe ASC");


            index = table.DefaultView.Find(textcode_groupe.Text);



            if (textcode_groupe.Text == string.Empty || textnom_groupe.Text == string.Empty)
            {
                MessageBox.Show(" fill les zone de text  ");
            }
            else if (index == -1)
            {


                MessageBox.Show("il ezxiste aucan statgaire ");
            }
            else
            {
                int anne = int.Parse(table.Rows[index][2].ToString());

                textcode_groupe.Text = table.Rows[index][0].ToString();
                textnom_groupe.Text = table.Rows[index][1].ToString();
                if (anne == 1)
                {
                    radioButton1.Checked = true;
                }
                else
                {
                    radioButton2.Checked = true;
                }


            }
        }

        private void BtnEnrg_Click(object sender, EventArgs e)
        {
            SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(da);


            

            da.Update(table);

            MessageBox.Show("Bien Enrigtere");

           
        }

        private void btnModifi_Click(object sender, EventArgs e)
        {
            table.DefaultView.Sort = ("code_groupe ASC");


            int index;
            index = table.DefaultView.Find(textcode_groupe.Text);

            table.Rows[index][1] = textnom_groupe.Text;
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            bds.MoveNext();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            bds.MovePrevious();
        }
    }
}
