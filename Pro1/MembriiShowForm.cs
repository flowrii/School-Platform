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
    public partial class MembriiShowForm : Form
    {
        string grupID;
        MySqlConnection con;
        DetaliiGrupForm dgf;
        int prof; // 0-se afiseaza membrii, 1-se afiseaza profesorul
        public MembriiShowForm()
        {
            InitializeComponent();
        }

        public MembriiShowForm(string grupID, MySqlConnection con, DetaliiGrupForm dgf, int prof)
        {
            InitializeComponent();
            this.grupID = grupID;
            this.con = con;
            this.dgf = dgf;
            this.prof = prof;
        }

        private void MembriiShowForm_Load(object sender, EventArgs e)
        {
            if (prof == 0)
            {
                adaugaProfBtn.Visible = false;
                string sqlQueryMembrii = "select utilizator.nume as Nume, utilizator.prenume as Prenume from utilizator join student on" +
                    "user_id=student_id join student_grup using (student_id) where student_grup.grup_id=" + grupID + ");";
                MySqlDataAdapter sda = new MySqlDataAdapter(sqlQueryMembrii, con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            else
            {
                //Afisare Profesor
                //Daca exista profesor,  adaugaProfBtn.Visible = false;
            }
        }

        private void inapoiBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            dgf.Show();
        }
    }
}
