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
    public partial class VizCatalogForm : Form
    {
        MySqlConnection con;
        string userID;
        CatalogForm catalog;
        string cursNume;
        string tipActivitate;
        int cursID;
        MainFormStudent ms;
        int caz;
        public VizCatalogForm()
        {
            InitializeComponent();
        }

        public VizCatalogForm(string userID, MySqlConnection con, CatalogForm catalog, string cursNume, string tipActivitate)
        {
            InitializeComponent();
            this.con = con;
            this.userID = userID;
            this.catalog = catalog;
            this.cursNume = cursNume;
            this.tipActivitate = tipActivitate;
            caz = 1;
        }

        public VizCatalogForm(string userID, MySqlConnection con, MainFormStudent ms)
        {
            InitializeComponent();
            this.con = con;
            this.userID = userID;
            this.ms = ms;
            caz = 2;
        }

        private void inapoiBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            if (caz == 1)
                catalog.Show();
            else
                ms.Show();
        }

        private void VizCatalogForm_Load(object sender, EventArgs e)
        {
            if (caz == 1) //profesor
            {
                string sqlIDcurs = "select curs_id from curs where curs.denumire= '" + cursNume + "' limit 1";
                MySqlDataAdapter sda = new MySqlDataAdapter(sqlIDcurs, con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                cursID = Int32.Parse(dt.Rows[0][0].ToString());
                string sqlQuery;
                switch (tipActivitate)
                {
                    case "5":
                        sqlQuery = "select utilizator.user_id,utilizator.nume as Nume, utilizator.prenume as Prenume, student_curs.nota as Nota from utilizator " +
                        " join student on utilizator.user_id=student.student_id join student_curs on student_curs.student_id=student.student_id where student_curs.curs_id='" +
                        cursID + "' and student_curs.prof_id='" + userID + "';";
                        sda = new MySqlDataAdapter(sqlQuery, con);
                        dt = new DataTable();
                        sda.Fill(dt);
                        dataGridView.DataSource = dt;
                        dataGridView.Columns[0].Visible = false;
                        updateBtn.Visible = false;
                        notaTextBox.Visible = false;
                        label2.Visible = false;
                        break;
                    default:
                        sqlQuery = "select utilizator.user_id,utilizator.nume as Nume, utilizator.prenume as Prenume, participare.nota as Nota from utilizator " +
                                    "join student on student.student_id = utilizator.user_id " +
                                    "join participare on student.student_id=participare.student_id " +
                                    "join activitate on participare.activitate_id = activitate.activitate_id " +
                                    "join profesor_curs on profesor_curs.prof_curs_id = activitate.prof_curs_id " +
                                    "where profesor_curs.prof_id = " + userID + " and activitate.tip = " + tipActivitate +
                                    " and profesor_curs.curs_id = " + cursID + " order by utilizator.nume;";
                        sda = new MySqlDataAdapter(sqlQuery, con);
                        dt = new DataTable();
                        sda.Fill(dt);
                        dataGridView.DataSource = dt;
                        dataGridView.Columns[0].Visible = false;
                        break;
                }
            }
            else if (caz == 2)//student
            {
                updateBtn.Visible = false;
                label2.Visible = false;
                notaTextBox.Visible = false;

                string query = "select participare.nota as Nota, activitate.tip as Activitate, curs.denumire as CURS from participare join activitate " +
                "using (activitate_id) join profesor_curs using(prof_curs_id) join curs using (curs_id)" +
                "where student_id = " + userID + " union select student_curs.nota as Nota, \"NOTA FINALA\" as Activitate, curs.denumire as CURS from curs join student_curs using (curs_id)" +
                "where student_id = " + userID + " order by CURS;";

                MySqlDataAdapter sda = new MySqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView.DataSource = dt;
            }

        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int nota = Int32.Parse(notaTextBox.Text);
                if (nota > 10 || nota < 1)
                    throw new FormatException();

                string idStud;
                
                int index = dataGridView.CurrentCell.RowIndex;

                if (dataGridView.SelectedCells.Count == 1)
                {
                    idStud = dataGridView.Rows[index].Cells[0].Value.ToString();
                    string sqlProcExe = "call prof_nota_act(" + nota + ", " + cursID + ", " + userID + ", " + tipActivitate + ", " + idStud + ");";
                    MySqlCommand cmd = new MySqlCommand(sqlProcExe, con);
                    cmd.ExecuteNonQuery();


                    MessageBox.Show("Nota a fost actualizata cu succes!");

                    dataGridView.Rows[index].Cells[3].Value=notaTextBox.Text;
                }

                else
                    MessageBox.Show("Selectati un singur Nume");

            }
            catch (FormatException exception)
            {
                MessageBox.Show("Introduceti o nota valida \n(numar natural intre 1 si 10)");
            }
        }
    }
}
