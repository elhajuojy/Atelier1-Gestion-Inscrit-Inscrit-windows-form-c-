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
            MessageBox.Show("les information est valider et enrgiter sur la base de donne","valider");

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



            int counter = 0;
            table.DefaultView.RowStateFilter = DataViewRowState.Deleted;
            foreach (DataRowView ligne in table.DefaultView)
            {

                counter += 1;
                if (ligne[1].ToString() == textNomModule.Text)
                {
                    
                    //table.Rows[counter].remove();

                    MessageBox.Show("done");
                }
                
                
               
            }
            
            // on annule le filtre
            //table.DefaultView.RowFilter = "";
        }
    }
}
