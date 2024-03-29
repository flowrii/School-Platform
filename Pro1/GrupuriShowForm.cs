﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Pro1
{
    public partial class GrupuriShowForm : Form
    {
        MySqlConnection con;
        string userID;
        MainFormStudent ms;
        public GrupuriShowForm()
        {
            InitializeComponent();
        }

        public GrupuriShowForm(string userID, MySqlConnection con, MainFormStudent ms)
        {
            InitializeComponent();
            this.userID = userID;
            this.con = con;
            this.ms = ms;
        }

        private void GrupuriShowForm_Load(object sender, EventArgs e)
        {
            con.Close();
            con.Open();
            string sqlQueryGrupuri = "select grup.grup_id as IDGrup, curs.denumire as CURS, grup.nume as NumeGrup from curs join grup using(curs_id) join student_grup using (grup_id)" +
                " join student using (student_id) where student.student_id=" + userID + ";";
            MySqlDataAdapter sda = new MySqlDataAdapter(sqlQueryGrupuri, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Columns[0].Visible = false;
        }

        private void inapoiBtn_Click(object sender, EventArgs e)
        {
           this.Close();
           ms.Show();
        }

        private void detaliiBtn_Click(object sender, EventArgs e)
        {
            int index = dataGridView1.CurrentCell.RowIndex;
            string grupID;
            if (dataGridView1.SelectedCells.Count == 1)
            {
                grupID = dataGridView1.Rows[index].Cells[0].Value.ToString();
                DetaliiGrupForm dgf = new DetaliiGrupForm(userID, grupID, con, this);
                this.Hide();
                dgf.Show();
            }
            else
                MessageBox.Show("Selectati un singur Grup!");
        }

        private void grupNouBtn_Click(object sender, EventArgs e)
        {
            GrupNouForm grupNou = new GrupNouForm(userID, con, this);
            this.Hide();
            grupNou.Show();
        }

        private void leaveBtn_Click(object sender, EventArgs e)
        {
            int index = dataGridView1.CurrentCell.RowIndex;
            string grupID;
            if (dataGridView1.SelectedCells.Count == 1)
            {
                grupID = dataGridView1.Rows[index].Cells[0].Value.ToString();
                string query1 = "update activitate_grup join participare_activitate_grup using(activitate_grup_id)" +
                    "set nr_participanti=nr_participanti-1 where participare_activitate_grup.student_id=" + userID + " and activitate_grup.grup_id=" + grupID + ";";
                MySqlCommand com = new MySqlCommand(query1, con);
                com.ExecuteNonQuery();

                string query = "delete from student_grup where student_id=" + userID + " and grup_id=" + grupID + ";";
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.ExecuteNonQuery();
                query = "delete p from participare_activitate_grup p join activitate_grup a using (activitate_grup_id) " +
                    "where p.student_id=" + userID + " and a.grup_id=" + grupID+";";
                cmd = new MySqlCommand(query, con);
                cmd.ExecuteNonQuery();
             

                MessageBox.Show("Ati parasit grupul!");
            }
            else
                MessageBox.Show("Selectati un singur grup!");
        }
    }
}
