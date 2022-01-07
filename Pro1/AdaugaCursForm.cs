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
    public partial class AdaugaCursForm : Form
    {
        MySqlConnection con;
        AdminShowForm af;
        public AdaugaCursForm()
        {
            InitializeComponent();
        }

        public AdaugaCursForm(MySqlConnection con, AdminShowForm af)
        {
            InitializeComponent();
            this.con = con;
            this.af = af;
        }

        private void inapoiBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            af.Show();
            con.Close();
        }

        private void adaugaBtn_Click(object sender, EventArgs e)
        {
            con.Close();
            con.Open();
            MySqlCommand cmd = new MySqlCommand("insert into curs (denumire, nr_max_stud) values ('" + numeTxtBox.Text + "', " + nrMaxTxtBox.Text + ");", con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Curs adaugat cu succes!");
            this.Close();
            af.Close();
            af = new AdminShowForm(this.af.ma, con, this.af.userID, 2);
            af.Show();
        }
    }
}
