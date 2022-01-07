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
    public partial class MainFormAdmin : Form
    {
        string username;
        LoginForm lf;
        MySqlConnection con;
        string userID;
        int tip; //2-admin, 3-super admin;
        public MainFormAdmin()
        {
            InitializeComponent();
        }

        public MainFormAdmin(string username, LoginForm lf, MySqlConnection con, string userID, int tip)
        {
            InitializeComponent();
            this.username = username;
            label2.Text = username + "!";
            this.lf = lf;
            this.con = con;
            this.userID = userID;
            this.tip = tip;
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

        private void detaliiContBtn_Click(object sender, EventArgs e)
        {
            DetaliiContForm df = new DetaliiContForm(userID, con, this);
            this.Hide();
            df.Show();
        }

        private void profesoriBtn_Click(object sender, EventArgs e)
        {
            AdminShowForm profi = new AdminShowForm(this, con, userID, 1);
            this.Hide();
            profi.Show();
        }

        private void stdentiBtn_Click(object sender, EventArgs e)
        {
            AdminShowForm studenti = new AdminShowForm(this, con, userID, 0);
            this.Hide();
            studenti.Show();
        }

        private void cursuriBtn_Click(object sender, EventArgs e)
        {
            AdminShowForm cursuri = new AdminShowForm(this, con, userID, 4);
            this.Hide();
            cursuri.Show();
        }

        private void MainFormAdmin_Load(object sender, EventArgs e)
        {
            if (tip == 2)
                adminiBtn.Visible = false;
        }

        private void adminiBtn_Click(object sender, EventArgs e)
        {
            AdminShowForm admini = new AdminShowForm(this, con, userID, 2);
            this.Hide();
            admini.Show();
        }
    }
}
