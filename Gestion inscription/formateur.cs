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
    public partial class formateur : Form
    {
        public formateur()
        {
            InitializeComponent();
        }
        // connection string 
        string CnxString = ConfigurationManager.ConnectionStrings["CtnStrinscrits"].ConnectionString;
        DataTable table;
        SqlDataAdapter da = new SqlDataAdapter();
        DataSet ds = new DataSet();
        BindingSource bds = new BindingSource();
        private void btnAjouter_Click(object sender, EventArgs e)
        {
            DataRow ligne = table.NewRow();


            ligne["matricule"] = textMatricule.Text;
            ligne["nom_formateur"] = textNom.Text;
            ligne["Prenom_formateur"] = textprenom.Text;
            ligne["Date_amnauche"] = dateTimePicker1.Value;

            table.Rows.Add(ligne);

            MessageBox.Show( " bien Ajouter ", "Ajouter formateur");
        }

        private void formateur_Load(object sender, EventArgs e)
        {

        }

        private void BtnEnrg_Click(object sender, EventArgs e)
        {
            SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(da);

            da.Update(table);

            MessageBox.Show("Bien Enrigtere");
        }
        int pos;
        private void btnRecherche_Click(object sender, EventArgs e)
        {

            table.DefaultView.Sort = ("matricule ASC");


            pos = table.DefaultView.Find(textMatricule.Text);



            if (textNom.Text == string.Empty || textprenom.Text == string.Empty)
            {
                MessageBox.Show(" fill les zone de text  ");
            }
            else if (pos == -1)
            {


                MessageBox.Show("il ezxiste aucan statgaire ");
            }
            else
            {
                
                textprenom.Text = table.Rows[pos][0].ToString();
                textNom.Text = table.Rows[pos][1].ToString();
                textprenom.Text=table.Rows[pos][2].ToString();
                //dateTimePicker1.Value(table.Rows[pos][3].ToString());

            }
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            table.Rows[pos].Delete();
        }

        private void btnModifi_Click(object sender, EventArgs e)
        {

            table.DefaultView.Sort = ("code_groupe ASC");


            int pos;
            pos = table.DefaultView.Find(textMatricule.Text);

            table.Rows[pos][1] = textNom.Text;
            table.Rows[pos][2] = textprenom.Text;
            table.Rows[pos][3] = dateTimePicker1.Value;
        }

        private void btnFrmer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSuivant_Click(object sender, EventArgs e)
        {
            table.DefaultView.Sort = ("matricule ASC");
            int pos1;

            pos1 = table.DefaultView.Find(textMatricule.Text);



            
            if (pos1 == -1)
            {


                MessageBox.Show("il ezxiste aucan statgaire ");
            }
            else
            {

                textMatricule.Text = table.Rows[pos1+1][0].ToString();
                textNom.Text = table.Rows[pos1 + 1][1].ToString();
                textprenom.Text = table.Rows[pos1 + 1][2].ToString();
                dateTimePicker1.Value= dateTimePicker1.Value( table.Rows[pos1 + 1][2].ToString());




            }
        }

        private void btnprecedent_Click(object sender, EventArgs e)
        {
            table.DefaultView.Sort = ("matricule ASC");
            int pos1;

            pos1 = table.DefaultView.Find(textMatricule.Text);




            if (pos1 == -1)
            {


                MessageBox.Show("il ezxiste aucan statgaire ");
            }
            else
            {

                textMatricule.Text = table.Rows[pos1 - 1][0].ToString();
                textNom.Text = table.Rows[pos1 - 1][1].ToString();
                textprenom.Text = table.Rows[pos1 - 1][2].ToString();
               // dateTimePicker1.Value = dateTimePicker1.Value(table.Rows[pos1 - 1][2].ToString());




            }
        }
    }
}
