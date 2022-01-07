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
    public partial class AdaugaGrupForm : Form
    {
        MySqlConnection con;
        AdminShowForm af;
        int[] cursID = new int[100];
        int nrC = 0;
        public AdaugaGrupForm()
        {
            InitializeComponent();
        }

        public AdaugaGrupForm(MySqlConnection con, AdminShowForm af)
        {
            InitializeComponent();
            this.con = con;
            this.af = af;
        }

        private void AdaugaGrupForm_Load(object sender, EventArgs e)
        {
            con.Close();
            con.Open();
            string selectQuery = "Select curs_id as id, curs.denumire as denumire from curs;";
            MySqlCommand cmd = new MySqlCommand(selectQuery, con);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                cursID[nrC++] = reader.GetInt32("id");
                cursuriComboBox.Items.Add(reader.GetString("denumire"));
            }
            reader.Close();
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
            MySqlCommand cmd = new MySqlCommand("insert into grup (curs_id, nume) values ('" + cursID[cursuriComboBox.SelectedIndex] + "', '" + numeGrupTxtBox.Text + "');", con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Grup adaugat cu succes!");
            this.Close();
            af.Close();
            af = new AdminShowForm(this.af.ma, con, this.af.userID, 2);
            af.Show();
        }
    }
}
