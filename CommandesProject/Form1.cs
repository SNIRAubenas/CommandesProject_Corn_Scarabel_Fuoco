using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CommandesProject
{
    public partial class Form1 : System.Windows.Forms.Form
    {
        SQLiteConnection bdd;

        public Form1()
        {
            InitializeComponent();
        }




        private void Form1_Load(object sender, EventArgs e)
        {
            if (!File.Exists("CommandesProject.db"))
            {
                MessageBox.Show("Base de données absente.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
                return;
            }
            SQLiteConnectionStringBuilder csb = new SQLiteConnectionStringBuilder();
            csb.DataSource = "CommandesProject.db";
            //
            bdd = new SQLiteConnection(csb.ToString());
            bdd.Open();
            //
            SQLiteCommand cmd = new SQLiteCommand("Select * From client", bdd);
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);
            //
            DataTable table = new DataTable();
            adapter.Fill(table);
            //
            this.grilleInfos.DataSource = table;
            this.grilleInfos.Columns[0].Visible = false;
            this.grilleInfos.Columns[3].Visible = false;
            this.grilleInfos.Columns[4].Visible = false;
            this.grilleInfos.Columns[5].Visible = false;
            this.grilleInfos.Columns[6].Visible = false;
            this.grilleInfos.Columns[7].Visible = false;
            this.grilleInfos.Columns[8].Visible = false;
        }



        private void grilleInfos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv = sender as DataGridView;

            if (dgv == null)
                return;
            if (dgv.CurrentRow.Selected)
            {
                int clientId = Convert.ToInt32(dgv.CurrentRow.Cells["id"].Value);
                this.ShowCommandes(clientId);
            }


            var ligne = this.grilleInfos.Rows[e.RowIndex];
            var element = ligne.Cells["id"];

            try
            {
                long id = (long)element.Value;
                
                SQLiteCommand cmd = new SQLiteCommand("Select * FROM client WHERE id=" + id.ToString(), bdd);
                var dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    this.firstNameBox.Text = dataReader.GetString(dataReader.GetOrdinal("prenom"));
                    this.nameBox.Text = dataReader.GetString(dataReader.GetOrdinal("nom"));
                }
            } catch { }
        }

        private void ShowCommandes(int clientId)
        {
            SQLiteConnectionStringBuilder csb = new SQLiteConnectionStringBuilder();
            csb.DataSource = "Commandes.db";
            //
            bdd = new SQLiteConnection(csb.ToString());
            bdd.Open();
            //
            SQLiteCommand cmd = new SQLiteCommand("Select * From Commandes WHERE idclient=@idclient", bdd);
            cmd.Parameters.AddWithValue("@idclient", clientId);

            SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);
            //
            DataTable table = new DataTable();

            adapter.Fill(table);
            
            //
            this.cmdGrid.DataSource = table;
            this.cmdGrid.Columns["id"].Visible = false;
            this.cmdGrid.Columns["idclient"].Visible = false;
        }
    }
}
