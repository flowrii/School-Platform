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
    public partial class DetaliiGrupForm : Form
    {
        string userID;
        string grupID;
        MySqlConnection con;
        GrupuriShowForm gsf;
        public DetaliiGrupForm()
        {
            InitializeComponent();
        }

        public DetaliiGrupForm(string userID, string grupID, MySqlConnection con, GrupuriShowForm gsf)
        {
            InitializeComponent();
            this.userID = userID;
            this.grupID = grupID;
            this.con = con;
            this.gsf = gsf;
        }

        private void inapoiBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            gsf.Show();
        }

        private void membriiBtn_Click(object sender, EventArgs e)
        {
            MembriiShowForm msf = new MembriiShowForm(grupID, con, this, 0);
            this.Hide();
            msf.Show();
        }

        private void profBtn_Click(object sender, EventArgs e)
        {
            MembriiShowForm msf = new MembriiShowForm(grupID, con, this, 1);
            this.Hide();
            msf.Show();
        }
    }
}
