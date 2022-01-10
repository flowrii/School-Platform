using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO;

namespace Pro1
{
    public partial class ProgramProfForm : Form
    {
        MySqlConnection con;
        string userID;
        Form backForm;
        public ProgramProfForm()
        {
            InitializeComponent();
        }

        public ProgramProfForm(string userID, MySqlConnection con, MainFormProfesor profForm)
        {
            InitializeComponent();
            this.userID = userID;
            this.con = con;
            this.backForm = profForm;
        }

        public ProgramProfForm(string userID, MySqlConnection con, MainFormStudent studForm)
        {
            InitializeComponent();
            this.userID = userID;
            this.con = con;
            this.backForm = studForm;
        }

        private void ProgramProfForm_Load(object sender, EventArgs e)
        {
            con.Close();
            con.Open();
            if (backForm is MainFormProfesor)
            {
                MySqlDataAdapter sda = new MySqlDataAdapter("select activitate.ziua as Zi, activitate.ora as Ora, activitate.tip as Tip,curs.denumire as Materie " +
                "from activitate join profesor_curs on activitate.prof_curs_id = profesor_curs.prof_curs_id join curs on curs.curs_id = profesor_curs.curs_id " +
            "where profesor_curs.prof_id = " + userID + " order by Zi, Ora, Materie asc;", con);

                DataTable dt = new DataTable();
                sda.Fill(dt);

                DataTable dtCloned = dt.Clone();
                dtCloned.Columns[0].DataType = typeof(string);
                dtCloned.Columns[2].DataType = typeof(string);
                foreach (DataRow row in dt.Rows)
                {
                    dtCloned.ImportRow(row);
                }

                for (int i = 0; i < dtCloned.Rows.Count; i++)
                {
                    switch (dtCloned.Rows[i].ItemArray[0])
                    {
                        case "1":
                            dtCloned.Rows[i].SetField("Zi", "Duminica");
                            break;
                        case "2":
                            dtCloned.Rows[i].SetField("Zi", "Luni");
                            break;
                        case "3":
                            dtCloned.Rows[i].SetField("Zi", "Marti");
                            break;
                        case "4":
                            dtCloned.Rows[i].SetField("Zi", "Miercuri");
                            break;
                        case "5":
                            dtCloned.Rows[i].SetField("Zi", "Joi");
                            break;
                        case "6":
                            dtCloned.Rows[i].SetField("Zi", "Vineri");
                            break;
                        case "7":
                            dtCloned.Rows[i].SetField("Zi", "Sambata");
                            break;
                    }
                    switch (dtCloned.Rows[i].ItemArray[2])
                    {
                        case "0":
                            dtCloned.Rows[i].SetField("Tip", "Curs");
                            break;
                        case "1":
                            dtCloned.Rows[i].SetField("Tip", "Seminar");
                            break;
                        case "2":
                            dtCloned.Rows[i].SetField("Tip", "Laborator");
                            break;
                        case "3":
                            dtCloned.Rows[i].SetField("Tip", "Colocviu");
                            break;
                        case "4":
                            dtCloned.Rows[i].SetField("Tip", "Examen");
                            break;
                    }
                }

                programDataGridView.DataSource = dtCloned;
            }
            else if(backForm is MainFormStudent)
            {
                MySqlDataAdapter sda = new MySqlDataAdapter("select activitate.ziua as Zi, activitate.ora as Ora, activitate.tip as Tip,curs.denumire as Materie " +
                "from participare join activitate using(activitate_id) join profesor_curs on activitate.prof_curs_id = profesor_curs.prof_curs_id join curs on curs.curs_id = profesor_curs.curs_id " +
            "where participare.student_id = " + userID + " order by Zi, Ora, Materie asc", con);

                DataTable dt = new DataTable();
                sda.Fill(dt);

                DataTable dtCloned = dt.Clone();
                dtCloned.Columns[0].DataType = typeof(string);
                dtCloned.Columns[2].DataType = typeof(string);
                foreach (DataRow row in dt.Rows)
                {
                    dtCloned.ImportRow(row);
                }

                for (int i = 0; i < dtCloned.Rows.Count; i++)
                {
                    switch (dtCloned.Rows[i].ItemArray[0])
                    {
                        case "1":
                            dtCloned.Rows[i].SetField("Zi", "Duminica");
                            break;
                        case "2":
                            dtCloned.Rows[i].SetField("Zi", "Luni");
                            break;
                        case "3":
                            dtCloned.Rows[i].SetField("Zi", "Marti");
                            break;
                        case "4":
                            dtCloned.Rows[i].SetField("Zi", "Miercuri");
                            break;
                        case "5":
                            dtCloned.Rows[i].SetField("Zi", "Joi");
                            break;
                        case "6":
                            dtCloned.Rows[i].SetField("Zi", "Vineri");
                            break;
                        case "7":
                            dtCloned.Rows[i].SetField("Zi", "Sambata");
                            break;
                    }
                    switch (dtCloned.Rows[i].ItemArray[2])
                    {
                        case "0":
                            dtCloned.Rows[i].SetField("Tip", "Curs");
                            break;
                        case "1":
                            dtCloned.Rows[i].SetField("Tip", "Seminar");
                            break;
                        case "2":
                            dtCloned.Rows[i].SetField("Tip", "Laborator");
                            break;
                        case "3":
                            dtCloned.Rows[i].SetField("Tip", "Colocviu");
                            break;
                        case "4":
                            dtCloned.Rows[i].SetField("Tip", "Examen");
                            break;
                    }
                }

                programDataGridView.DataSource = dtCloned;
            }
            con.Close();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            backForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TextWriter writer = new StreamWriter(@"C:\Users\iften\Desktop\ProgramActivitati.txt");
            writer.Write(String.Format("{0, -10} \t{1,-10} \t{2, -10} \t{3, -10} \t\n", "Zi", "Ora", "Tip", "Materie"));
            writer.WriteLine("");
            for (int i = 0; i < programDataGridView.Rows.Count; i++)
            {
                for (int j = 0; j < programDataGridView.Columns.Count; j++)
                {
                    writer.Write(String.Format("{0, -10} \t" ,programDataGridView.Rows[i].Cells[j].Value));
                }
                writer.WriteLine("");
            }
            writer.Close();
            MessageBox.Show("Programul activitatilor a fost descarcat!");

        }
    }
}
