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

        int[] grupuriID = new int[100];
        int ctG = 0;
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
            con.Close();
            con.Open();
            comboBox1.Text = "Selecteaza Grup";
            string query = "select distinct grup_id as id, nume from grup join curs using(curs_id)" +
                "join student_curs using (curs_id) where student_curs.student_id = " + userID +
                " and grup.grup_id not in (select grup_id from student_grup where student_id =" + userID + ");";
            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                grupuriID[ctG++] = reader.GetInt32("id");
                comboBox1.Items.Add(reader.GetString("nume"));
            }
            reader.Close();
        }

        private void joinBtn_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text.Equals("Selecteaza Grup"))
                MessageBox.Show("Nu ati selectat niciun grup!");
            else
            {
                string insertQ = "insert into student_grup(student_id, grup_id) values (" + userID + ", " + grupuriID[comboBox1.SelectedIndex] + ");";
                MySqlCommand cmd = new MySqlCommand(insertQ, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Inscriere realizata cu succes!");
            }
        }
        
    }
}
