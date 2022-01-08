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
    public partial class AdminShowForm : Form
    {
        public MainFormAdmin ma;
        MySqlConnection con;
        public string userID;
        int tip; //0-studenti, 1-profi, 2-admini, 4-cursuri, 5-grupuri
        int admin; //2-admin 3-superadmin
        public AdminShowForm()
        {
            InitializeComponent();
        }

        public AdminShowForm(MainFormAdmin ma, MySqlConnection con, string userID, int tip)
        {
            InitializeComponent();
            this.ma = ma;
            this.con = con;
            this.userID = userID;
            this.tip = tip;
        }

        private void AdminShowForm_Load(object sender, EventArgs e)
        {
            switch (tip)
            {
                case 0:
                    asignCursBtn.Visible = false;
                    adaugaBtn.Text = "Adauga Student";
                    string sqlQueryStudenti = "select* from utilizator join student on utilizator.user_id=student.student_id order by an, nume asc";
                    MySqlDataAdapter sda2 = new MySqlDataAdapter(sqlQueryStudenti, con);
                    DataTable dt2 = new DataTable();
                    sda2.Fill(dt2);
                    dataGridView1.DataSource = dt2;
                    dataGridView1.Columns[11].Visible = false;
                    dataGridView1.Columns[12].Visible = false;
                    break;
                case 1:
                    string sqlQueryProfi = "select* from utilizator join profesor on utilizator.user_id=profesor.prof_id order by nume asc";
                    MySqlDataAdapter sda = new MySqlDataAdapter(sqlQueryProfi, con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    dataGridView1.DataSource = dt;
                    dataGridView1.Columns[11].Visible = false;
                    dataGridView1.Columns[12].Visible = false;
                    break;
                case 2:
                    asignCursBtn.Visible = false;
                    adaugaBtn.Text = "Adauga Admin";
                    string sqlQueryAdmini = "select* from utilizator where tip=2";
                    MySqlDataAdapter sda4 = new MySqlDataAdapter(sqlQueryAdmini, con);
                    DataTable dt4 = new DataTable();
                    sda4.Fill(dt4);
                    dataGridView1.DataSource = dt4;
                    break;
                case 4:
                    asignCursBtn.Visible = false;
                    //de facut stergerea
                    stergeBtn.Visible = false;
                    adaugaBtn.Text = "Adauga Curs";
                    string sqlQueryCursuri = "select* from curs order by denumire asc";
                    MySqlDataAdapter sda3 = new MySqlDataAdapter(sqlQueryCursuri, con);
                    DataTable dt3 = new DataTable();
                    sda3.Fill(dt3);
                    dataGridView1.DataSource = dt3;
                    break;
                case 5:
                    asignCursBtn.Visible = false;
                    stergeBtn.Visible = false;
                    adaugaBtn.Text = "Adauga Grup";
                    string sqlQueryGrupuri = "select grup_id, curs.denumire, nume from grup join curs using (curs_id) order by curs.denumire asc";
                    MySqlDataAdapter sda5 = new MySqlDataAdapter(sqlQueryGrupuri, con);
                    DataTable dt5 = new DataTable();
                    sda5.Fill(dt5);
                    dataGridView1.DataSource = dt5;
                    break;
            }
        }

        private void inapoiBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            ma.Show();
        }

        private void adaugaBtn_Click(object sender, EventArgs e)
        {
            if (tip == 0 || tip == 1 || tip == 2)
            {
                AdaugaUserForm adauga = new AdaugaUserForm(this, con, tip);
                this.Hide();
                adauga.Show();
            }
            else
                if (tip == 4)
            {
                AdaugaCursForm adaugaCurs = new AdaugaCursForm(con, this);
                this.Hide();
                adaugaCurs.Show();
            }
            else
            {
                AdaugaGrupForm adaugaGrup = new AdaugaGrupForm(con, this);
                this.Hide();
                adaugaGrup.Show();
            }
        }

        private void stergeBtn_Click(object sender, EventArgs e)
        {
            con.Open();
            string message;
            string title;
            if (tip == 4)
            {
                message = "Sunteti sigur ca doriti sa stergeti acest curs?";
                title = "Sterge curs";
            }
            else
            {
                message = "Sunteti sigur ca doriti sa stergeti acest utilizator?";
                title = "Sterge utilizator";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, title, buttons);
                string idUserDeSters;
                if (result == DialogResult.Yes)
                {
                    int index = dataGridView1.CurrentCell.RowIndex;

                    if (dataGridView1.SelectedCells.Count == 1)
                    {
                        idUserDeSters = dataGridView1.Rows[index].Cells[0].Value.ToString();
                        string sqlCmd = "delete from utilizator where user_id=" + idUserDeSters + ";";
                        MySqlCommand cmd = new MySqlCommand(sqlCmd, con);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Utilizatorul a fost sters!");
                        con.Close();
                    }

                    else
                        MessageBox.Show("Selectati un singur Nume");
                }
                else
                {
                    this.Close();
                }
            }
        }

        private void asignCursBtn_Click(object sender, EventArgs e)
        {
            con.Close();
            con.Open();

            int index = dataGridView1.CurrentCell.RowIndex;

            string idProf;

            if (dataGridView1.SelectedCells.Count == 1)
            {
                idProf = dataGridView1.Rows[index].Cells[0].Value.ToString();
                AsignProfCursForm assignProf = new AsignProfCursForm(idProf, this, con);
                assignProf.Show();
                this.Hide();
            }

            else
                MessageBox.Show("Selectati un singur Nume");
        }

        private void cautaBtn_Click(object sender, EventArgs e)
        {
            string searchValue = textBox1.Text;

            dataGridView1.ClearSelection();
            try
            {

                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    for (int i = 0; i < dataGridView1.Columns.Count; i++)
                        if (row.Cells[i].Value.ToString().Equals(searchValue))
                        {
                            row.Cells[i].Selected = true;
                        }
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }
    }
}