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
    public partial class MainFormProfesor : Form
    {
        string username;
        LoginForm lf;
        MySqlConnection con;
        string userID;
        public MainFormProfesor()
        {
            InitializeComponent();
        }

        public MainFormProfesor(string username, LoginForm lf, MySqlConnection con, string userID)
        {
            InitializeComponent();
            this.username = username;
            label2.Text = username + "!";
            this.lf = lf;
            this.con = con;
            this.userID = userID;
        }

        private void MainFormProfesor_Load(object sender, EventArgs e)
        {
        
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void logOutBtn_Click(object sender, EventArgs e)
        {
            lf.refresh();
            lf.Show();
            this.Close();
        }

        private void programeazaActBtn_Click(object sender, EventArgs e)
        {
            ProgrameazaForm pf = new ProgrameazaForm(userID, con, this);
            this.Hide();
            pf.Show();
        }

        private void programProfBtn_Click(object sender, EventArgs e)
        {
            ProgramProfForm progProf = new ProgramProfForm(userID, con, this);
            this.Hide();
            progProf.Show();
        }

        private void contProfBtn_Click(object sender, EventArgs e)
        {
            DetaliiContForm df = new DetaliiContForm(userID, con, this);
            this.Hide();
            df.Show();
        }

        private void catalogBtn_Click(object sender, EventArgs e)
        {
            CatalogForm catalog = new CatalogForm(userID, con, this);
            this.Hide();
            catalog.Show();
        }

        private void notificariBtn_Click(object sender, EventArgs e)
        {
            MesajeForm notificari = new MesajeForm(userID, con, this);
            this.Hide();
            notificari.Show();
        }
    }
}
