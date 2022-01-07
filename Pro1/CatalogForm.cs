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
    public partial class CatalogForm : Form
    {
        MySqlConnection con;
        string userID;
        MainFormProfesor profForm;
        public CatalogForm()
        {
            InitializeComponent();
        }

        public CatalogForm(string userID, MySqlConnection con, MainFormProfesor profForm)
        {
            InitializeComponent();
            this.con = con;
            this.userID = userID;
            this.profForm = profForm;
        }

        private void inapoiBtn_Click(object sender, EventArgs e)
        {
            con.Close();
            this.Close();
            profForm.Show();
        }

        private void CatalogForm_Load(object sender, EventArgs e)
        {
            con.Open();
            string selectQuery = "Select curs.denumire as denumire from curs join profesor_curs on curs.curs_id=profesor_curs.curs_id where profesor_curs.prof_id=" + userID + ";";
            MySqlCommand cmd = new MySqlCommand(selectQuery, con);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                CursComboBox.Items.Add(reader.GetString("denumire"));
            }
            reader.Close();
        }

        private void afisareBtn_Click(object sender, EventArgs e)
        {
            VizCatalogForm vizualizare = new VizCatalogForm(userID, con, this, CursComboBox.SelectedItem.ToString(), ActComboBox.SelectedIndex.ToString());
            this.Hide();
            vizualizare.Show();
        }
    }
}
