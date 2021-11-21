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
    public partial class FrmAjoModModule : Form
    {
        // connection string 
        string CnxString = ConfigurationManager.ConnectionStrings["CtnStrinscrits"].ConnectionString;

        public FrmAjoModModule()
        {
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }



        DataTable table;
        SqlDataAdapter da = new SqlDataAdapter();
        DataSet ds = new DataSet();

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            SqlConnection ctn = new SqlConnection(CnxString);

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = ctn;
            
            cmd.CommandText = " select * from  modules ";
            da.SelectCommand = cmd;
            
            da.Fill(ds, "modules");
            table = ds.Tables["modules"];
            DataRow ligne = table.NewRow();

            ligne["lib_module"] = textNomModule.Text;
            table.Rows.Add(ligne);

            MessageBox.Show(ligne[1].ToString()+"  est Ajouter ","Ajouter Module");



        }

      

        private void btnValider_Click(object sender, EventArgs e)
        {

            SqlCommandBuilder bldr = new SqlCommandBuilder(da);
            
            da.Update(table);
            MessageBox.Show("les information est valider  sur la base de donne","valider");

        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {

            SqlConnection ctn = new SqlConnection(CnxString);

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = ctn;

            cmd.CommandText = " select * from  modules ";
            da.SelectCommand = cmd;

            da.Fill(ds, "modules");
            table = ds.Tables["modules"];

            try
            {
                int pos = -1;
                for (int i = 0; i < table.Rows.Count; i++)
                {
                    if (table.Rows[i][1].ToString() == textNomModule.Text)
                    {
                        pos = i;
                        table.Rows[pos].Delete();
                        MessageBox.Show("supprimer", table.Rows[pos][1].ToString());
                        break;
                    }

                }
            }
            catch (Exception ex )
            {
                MessageBox.Show(ex.ToString(),"expception");
            }

            

         
            
          
        }

        
        private void btnAnnuler_Click(object sender, EventArgs e)
        {

            table.DefaultView.RowStateFilter = DataViewRowState.OriginalRows;
            // on affiche la version originale des lignes supprimees
            table.DefaultView.RowStateFilter = DataViewRowState.Deleted;
            MessageBox.Show("Annuler est bien effecte ");

        }
        int next = 0;
        
        
        private void btnSuivant_Click(object sender, EventArgs e)
        {
            SqlConnection ctn = new SqlConnection(CnxString);

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = ctn;

            cmd.CommandText = " select * from  modules ";
            da.SelectCommand = cmd;

            da.Fill(ds, "modules");
            table = ds.Tables["modules"];
            int index = table.DefaultView.Find(textNomModule.Text);
            if (index > -1)
            {
                textNomModule.Text = table.Rows[index + 1][1].ToString();
            }
            else
            {
                textNomModule.Text = table.Rows[next][1].ToString();
            }
            next += 1;



        }

        private void FrmAjoModModule_Load(object sender, EventArgs e)
        {

        }

        private void btnPre_Click(object sender, EventArgs e)
        {
            
            SqlConnection ctn = new SqlConnection(CnxString);

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = ctn;

            cmd.CommandText = " select * from  modules ";
            da.SelectCommand = cmd;

            da.Fill(ds, "modules");
            table = ds.Tables["modules"];

            textNomModule.Text = table.Rows[next][1].ToString();




        }
    }
}
