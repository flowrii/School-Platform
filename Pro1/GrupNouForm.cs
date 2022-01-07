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
    public partial class GrupNouForm : Form
    {
        MySqlConnection con;
        string userID;
        GrupuriShowForm gsf;
        public GrupNouForm()
        {
            InitializeComponent();
        }
        public GrupNouForm(string userID, MySqlConnection con, GrupuriShowForm gsf)
        {
            InitializeComponent();
            this.userID = userID;
            this.con = con;
            this.gsf = gsf;
        }

        private void inapoiBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            gsf.Show();
        }

        private void GrupNouForm_Load(object sender, EventArgs e)
        {
            MySqlCommand cmd = new MySqlCommand("select denumire from curs;", con);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                comboBox1.Items.Add(reader.GetString("denumire"));
            }
            reader.Close();
        }
    }
}
