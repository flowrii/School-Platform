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
    public partial class ActivitatiGRUPForm : Form
    {
        string userID;
        string grupID;
        MySqlConnection con;
        DetaliiGrupForm detaliiG;
        public ActivitatiGRUPForm()
        {
            InitializeComponent();
        }

        public ActivitatiGRUPForm(string userID, string grupID, MySqlConnection con, DetaliiGrupForm detaliiG)
        {
            InitializeComponent();
            this.userID = userID;
            this.grupID = grupID;
            this.con = con;
            this.detaliiG = detaliiG;
        }

        private void inapoiBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            detaliiG.Show();
        }

        private void ActivitatiGRUPForm_Load(object sender, EventArgs e)
        {
            string activitatiGrup = "select activitate_grup_id as ID, activitate_grup.descriere as Nume, data_activitate as DataActivitate, ora as OraActivitate, nr_participanti as Participanti" +
                " from activitate_grup where activitate_grup.grup_id="+grupID+ " and (activitate_grup.activitate_grup_id not in (select activitate_grup_id " +
                "from participare_activitate_grup where student_id =" + userID + "));";
            MySqlDataAdapter sda = new MySqlDataAdapter(activitatiGrup, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridViewG.DataSource = dt;

            string activitatileMele = "select activitate_grup_id as ID, activitate_grup.descriere as Nume, data_activitate as DataActivitate, ora as OraActivitate, nr_participanti as Participanti" +
                " from activitate_grup where activitate_grup.grup_id=" + grupID + " and (activitate_grup.activitate_grup_id in (select activitate_grup_id " +
                "from participare_activitate_grup where student_id =" + userID + "));";
            sda = new MySqlDataAdapter(activitatileMele, con);
            DataTable dt2 = new DataTable();
            sda.Fill(dt2);
            dataGridViewS.DataSource = dt2;
        }

        private void adaugaBtn_Click(object sender, EventArgs e)
        {
            ActivitateNouaForm activitateNoua = new ActivitateNouaForm(userID, grupID, con, this);
            this.Hide();
            activitateNoua.Show();
        }

        private void newActBtn_Click(object sender, EventArgs e)
        {
            int index = dataGridViewG.CurrentCell.RowIndex;
            string actID;
            if (dataGridViewG.SelectedCells.Count == 1)
            {
                actID = dataGridViewG.Rows[index].Cells[0].Value.ToString();
                string insertQ = "insert into participare_activitate_grup(activitate_grup_id, student_id) values (" + actID + ", " + userID + ");";
                MySqlCommand cmd = new MySqlCommand(insertQ, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("V-ati inscris cu succes!");
            }
            else
                MessageBox.Show("Selectati un singur Grup!");
        }
    }
}
