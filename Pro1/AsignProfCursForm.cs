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
    public partial class AsignProfCursForm : Form
    {
        string idProf;
        AdminShowForm af; 
        MySqlConnection con;
        public AsignProfCursForm()
        {
            InitializeComponent();
        }

        public AsignProfCursForm(string idProf, AdminShowForm af, MySqlConnection con)
        {
            InitializeComponent();
            this.idProf = idProf;
            this.af = af;
            this.con = con;
        }

        private void AsignProfCursForm_Load(object sender, EventArgs e)
        {
            con.Close();
            con.Open();
            MySqlCommand cmd = new MySqlCommand("select denumire from curs where denumire not in(select denumire from curs join profesor_curs on curs.curs_id=profesor_curs.curs_id where prof_id=" + idProf + ");", con);
            MySqlDataReader reader = cmd.ExecuteReader();
            //MySqlDataAdapter sda = new MySqlDataAdapter("select denumire from curs join profesor_curs on curs.curs_id=profesor_curs.curs_id where prof_id=" + idProf + ";", con);
            //DataTable dt = new DataTable();
            //sda.Fill(dt);
            while (reader.Read())
            {
                //string cursCrt = reader.GetString("denumire");
                
                //for(int i=0;i<dt.Rows.Count;i++)
                    //if (cursCrt!=dt.Rows[i][0])
                        comboBox1.Items.Add(reader.GetString("denumire"));

            }
            reader.Close();
        }

        private void inregistreazaBtn_Click(object sender, EventArgs e)
        {
            string curs;
            curs = comboBox1.SelectedItem.ToString();
            MySqlDataAdapter sda = new MySqlDataAdapter("select curs_id from curs where denumire='" + curs + "';", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            string idCurs = dt.Rows[0][0].ToString();
            MySqlCommand cmd = new MySqlCommand("insert into profesor_curs (curs_id, prof_id, nr_stud) values (" + idCurs + ", " + idProf + ", 0);", con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Profesor atribuit cu succes!");
        }

        private void inapoiBtn_Click(object sender, EventArgs e)
        {
            con.Close();
            this.Close();
            af.Show();
        }
    }
}
