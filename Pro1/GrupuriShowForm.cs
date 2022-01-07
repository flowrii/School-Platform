using System;
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
            string sqlQueryGrupuri = "select grup.grup_id as ID, grup.curs_id as CURS, grup.nume as NumeGrup from grup join student_grup using (grup_id) join student using (student_id);";
            MySqlDataAdapter sda = new MySqlDataAdapter(sqlQueryGrupuri, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
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
    }
}
