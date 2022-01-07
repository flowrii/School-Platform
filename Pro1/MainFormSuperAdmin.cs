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
    public partial class MainFormSuperAdmin : Form
    {
        string username;
        LoginForm lf;
        MySqlConnection con;
        string userID;

        public MainFormSuperAdmin()
        {
            InitializeComponent();
        }

        public MainFormSuperAdmin(string username, LoginForm lf, MySqlConnection con, string userID)
        {
            InitializeComponent();
            this.username = username;
            label2.Text = username + "!";
            this.lf = lf;
            this.con = con;
            this.userID = userID;
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
    }
}
