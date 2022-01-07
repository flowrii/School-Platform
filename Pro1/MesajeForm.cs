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
    public partial class MesajeForm : Form
    {
        string userID;
        string grupID;
        MySqlConnection con;
        DetaliiGrupForm dgf;
        public MesajeForm()
        {
            InitializeComponent();
        }

        public MesajeForm(string userID, string grupID, MySqlConnection con, DetaliiGrupForm dgf)
        {
            InitializeComponent();
            this.userID = userID;
            this.grupID = grupID;
            this.con = con;
            this.dgf = dgf;
        }

        private void inapoiBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            dgf.Show();
        }

        private void MesajeForm_Load(object sender, EventArgs e)
        {
            string sqlQueryMesaje = "select utilizator.nume as Nume, utilizator.prenume as Prenume, mesaj.continut as Mesaj " +
                "from utilizator join student on user_id=student_id join student_grup using (student_id) join mesaj using (student_grup_id) " +
                "where student_grup.grup_id=" + grupID + ";";
            MySqlDataAdapter sda = new MySqlDataAdapter(sqlQueryMesaje, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MesajNouForm mesajNou = new MesajNouForm(userID, grupID, con, this);
            this.Hide();
            mesajNou.Show();
        }
    }
}
