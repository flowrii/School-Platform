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
    public partial class DetaliiContForm : Form
    {
        string userID;
        MySqlConnection con;
        MainFormProfesor profForm;
        MainFormStudent studentForm;
        MainFormAdmin adminForm;
        MainFormSuperAdmin superAdminForm;
        Form previewForm;
        public DetaliiContForm()
        {
            InitializeComponent();
        }

        public DetaliiContForm(string userID, MySqlConnection con, MainFormProfesor profForm)
        {
            InitializeComponent();
            this.userID = userID;
            this.con = con;
            this.profForm = profForm;
            this.previewForm = profForm;
        }

        public DetaliiContForm(string userID, MySqlConnection con, MainFormStudent studentForm)
        {
            InitializeComponent();
            this.userID = userID;
            this.con = con;
            this.studentForm = studentForm;
            this.previewForm = studentForm;
        }

        public DetaliiContForm(string userID, MySqlConnection con, MainFormAdmin adminForm)
        {
            InitializeComponent();
            this.userID = userID;
            this.con = con;
            this.adminForm = adminForm;
            this.previewForm = adminForm;
        }

        public DetaliiContForm(string userID, MySqlConnection con, MainFormSuperAdmin superAdminForm)
        {
            InitializeComponent();
            this.userID = userID;
            this.con = con;
            this.superAdminForm = superAdminForm;
            this.previewForm = studentForm;
        }

        private void DetaliiContForm_Load(object sender, EventArgs e)
        {
            con.Close();
            con.Open();
            string selectQuery = "Select nume, prenume, adresa, nr_tel, email, nr_contract from utilizator where user_id=" + userID + ";";
            MySqlDataAdapter sda = new MySqlDataAdapter(selectQuery, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            labelNume.Text = dt.Rows[0][0].ToString();
            labelPrenume.Text = dt.Rows[0][1].ToString();
            labelAdresa.Text = dt.Rows[0][2].ToString();
            labelTel.Text = dt.Rows[0][3].ToString();
            labelEmail.Text = dt.Rows[0][4].ToString();
            labelContract.Text = dt.Rows[0][5].ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Close();
            this.Close();
            previewForm.Show();
        }
    }
}
