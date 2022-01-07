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
    public partial class MainFormStudent : Form
    {
        string username;
        LoginForm lf;
        MySqlConnection con;
        string userID;
        public MainFormStudent()
        {
            InitializeComponent();
        }

        public MainFormStudent(string username, LoginForm lf, MySqlConnection con, string userID)
        {
            InitializeComponent();
            this.username = username;
            label2.Text = username + "!";
            this.lf = lf;
            this.con = con;
            this.userID = userID;
        }

        private void detaliiContBtn_Click(object sender, EventArgs e)
        {
            DetaliiContForm df = new DetaliiContForm(userID, con, this);
            this.Hide();
            df.Show();
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

        private void inscriereBtn_Click(object sender, EventArgs e)
        {
            InscriereStudentCurs isc = new InscriereStudentCurs(userID, this, con);
            this.Hide();
            isc.Show();
        }

        private void vizualizareNoteBtn_Click(object sender, EventArgs e)
        {
            VizCatalogForm note = new VizCatalogForm(userID, con, this);
            this.Hide();
            note.Show();
        }
    }
}
