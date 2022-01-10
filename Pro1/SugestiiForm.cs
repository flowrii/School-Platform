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
    public partial class SugestiiForm : Form
    {
        MySqlConnection con;
        string userID;
        Form backForm;
        string grupID;
        public SugestiiForm()
        {
            InitializeComponent();
        }

        public SugestiiForm(string userID, MySqlConnection con, MainFormStudent student)
        {
            InitializeComponent();
            this.userID = userID;
            this.con = con;
            this.backForm = student;
        }

        public SugestiiForm(string grupID, MySqlConnection con, MembriiShowForm membrii)
        {
            InitializeComponent();
            this.grupID = grupID;
            this.con = con;
            this.backForm = membrii;
        }

        private void inapoiBtn_Click(object sender, EventArgs e)
        {
            con.Close();
            this.Close();
            backForm.Show();
        }

        private void SugestiiActivitatiForm_Load(object sender, EventArgs e)
        {
            con.Close();
            con.Open();

            if (backForm is MainFormStudent)
            {
                invitaBtn.Visible = false;
                string activitati = "SELECT activitate_id, case when tip = 0 then \"Curs\" when tip = 1 then \"Seminar\" when tip = 2 then \"Laborator\" " +
                " when tip = 3 then \"Colocviu\" else \"Examen\" end as Tip ,denumire as Materie,ziua as Zi,ora as Ora from activitate join profesor_curs " +
                " using (prof_curs_id) join curs using (curs_id) join student_curs using (curs_id) where student_curs.student_id =" + userID +
                " and ora not in ( select ora from activitate join participare using (activitate_id) where student_id =" + userID + ")" +
                " and ziua not in (select ora from activitate join participare using (activitate_id) where student_id =" + userID + ");";
                MySqlDataAdapter sda = new MySqlDataAdapter(activitati, con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
                dataGridView1.Columns[0].Visible = false;
            }
            else if (backForm is MembriiShowForm)
            {
                string membrii = "select student_id,nume,prenume from utilizator join student_curs on student_curs.student_id = utilizator.user_id where" +
                    " student_curs.curs_id = (select curs_id from grup where grup.grup_id =" + grupID + ") and student_id not in (select student_id from " +
                    "student_grup where grup_id =" + grupID + "); ";
                MySqlDataAdapter sda = new MySqlDataAdapter(membrii, con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
                dataGridView1.Columns[0].Visible = false;
            }
        }

        private void invitaBtn_Click(object sender, EventArgs e)
        {
            int index = dataGridView1.CurrentCell.RowIndex;
            string idStud = dataGridView1.Rows[index].Cells[0].Value.ToString();

            string query = "insert into Notificare(continut,descriere_activitate,user_id,data) values(\"Aveti o noua sugestie de grup.\", (select grup.nume " +
            "from grup where grup_id =" + grupID + ")," + idStud + ",curtime()); ";
            MySqlCommand cmd = new MySqlCommand(query, con);
            cmd.ExecuteNonQuery();

            MessageBox.Show("Invitatia a fost trimisa!");
        }

        private void inscriereBtn_Click(object sender, EventArgs e)
        {
            int index = dataGridView1.CurrentCell.RowIndex;
            string idActivitate = dataGridView1.Rows[index].Cells[0].Value.ToString();

            string act = "insert into participare (student_id, activitate_id, nota) values (" + userID + ", " + idActivitate + ", 0);";
            MySqlCommand cmd = new MySqlCommand(act, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Inscrierea a fost realizata!");
        }
    }
}
