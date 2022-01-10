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
        Form backForm;
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
            this.backForm = dgf;
        }

        public MesajeForm(string userID, MySqlConnection con, MainFormStudent student)
        {
            InitializeComponent();
            this.userID = userID;
            this.con = con;
            this.backForm = student;
        }

        public MesajeForm(string userID, MySqlConnection con, MainFormProfesor profesor)
        {
            InitializeComponent();
            this.userID = userID;
            this.con = con;
            this.backForm = profesor;
        }

        private void inapoiBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            backForm.Show();
        }

        private void MesajeForm_Load(object sender, EventArgs e)
        {
            if (backForm is DetaliiContForm)
            {
                string sqlQueryMesaje = "select utilizator.nume as Nume, utilizator.prenume as Prenume, mesaj.continut as Mesaj " +
                  "from utilizator join student on user_id=student_id join student_grup using (student_id) join mesaj using (student_grup_id) " +
                  "where student_grup.grup_id=" + grupID + ";";
                MySqlDataAdapter sda = new MySqlDataAdapter(sqlQueryMesaje, con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            else if(backForm is MainFormStudent || backForm is MainFormProfesor)
            {
                button1.Visible = false;
                string sqlQueryNotificari = "select continut as Mesaj, descriere_activitate as NumeActivitate, data as Data from notificare where user_id = " + userID + ";";
                MySqlDataAdapter sda = new MySqlDataAdapter(sqlQueryNotificari, con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MesajNouForm mesajNou = new MesajNouForm(userID, grupID, con, this);
            this.Hide();
            mesajNou.Show();
        }
    }
}
