﻿using System;
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
        SQLiteConnection sqlite_conn;

        public Form1()
        {
            InitializeComponent();
        }




        private void Form1_Load(object sender, EventArgs e)
        {
            if (!File.Exists("CommandesProject.db"))
            {
                MessageBox.Show("Le fichier CommandesProject.db est absent","Erreur",MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
            sqlite_conn = new SQLiteConnection("Data Source=CommandesProject.db ");

            try
            {
                sqlite_conn.Open();

            }
            catch(Exception ex)
            {
                MessageBox.Show("Erreur à l'ouverture " + Environment.NewLine + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
            //
            SQLiteCommand cmd;
            cmd = new SQLiteCommand("SELECT id , nom , prenom FROM client" , sqlite_conn);
            //
            DataTable extrait = new DataTable();
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);
            adapter.Fill(extrait);
            this.grilleInfos.DataSource = extrait;
            this.grilleInfos.Columns[0].Visible = false;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!File.Exists("CommandesProject.db"))
            {
                MessageBox.Show("Le fichier CommandesProject.db est absent", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
            sqlite_conn = new SQLiteConnection("Data Source=CommandesProject.db ");

            try
            {
                sqlite_conn.Open();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur à l'ouverture " + Environment.NewLine + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
            //
            SQLiteCommand cmd2;
            cmd2 = new SQLiteCommand("SELECT id , nom , prenom FROM Commandes", sqlite_conn);
            //
            DataTable extrait2 = new DataTable();
            SQLiteDataAdapter adapter2 = new SQLiteDataAdapter(cmd2);
            adapter2.Fill(extrait2);
            this.cmdGrid.DataSource = extrait2;
            this.cmdGrid.Columns[0].Visible = false;
            this.cmdGrid.Columns[1].Visible = false;

        }
    }
}
