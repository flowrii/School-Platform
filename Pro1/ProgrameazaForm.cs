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
    public partial class ProgrameazaForm : Form
    {
        MySqlConnection con;
        string userID;
        MainFormProfesor profForm;
        public ProgrameazaForm()
        {
            InitializeComponent();
        }

        public ProgrameazaForm(string userID, MySqlConnection con, MainFormProfesor profForm)
        {
            InitializeComponent();
            this.con = con;
            this.userID = userID;
            this.profForm = profForm;
        }

        private void ProgrameazaForm_Load(object sender, EventArgs e)
        {
            con.Open();
            string selectQuery = "Select curs.denumire as denumire from curs join profesor_curs on curs.curs_id=profesor_curs.curs_id where profesor_curs.prof_id=" + userID + ";";
            MySqlCommand cmd = new MySqlCommand(selectQuery, con);
            MySqlDataReader reader = cmd.ExecuteReader();
            while(reader.Read())
            {
                CursComboBox.Items.Add(reader.GetString("denumire"));
            }
            reader.Close();
        }

        private void PondereTrackBar_Scroll(object sender, EventArgs e)
        {
            labelTrackBar.Text = (PondereTrackBar.Value*10).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string curs, ora, zi, pondere, nrMax = "0", tip;
            int ziP;
            DateTime dataIncepere, dataFinalizare;
            try
            {
                tip = ActComboBox.SelectedIndex.ToString();
                curs = CursComboBox.SelectedItem.ToString();
                ora = oraComboBox.SelectedItem.ToString();
                zi = ZiComboBox.SelectedItem.ToString();
                switch (zi)
                {
                    case "Luni":
                        ziP = 2;
                        break;
                    case "Marti":
                        ziP = 3;
                        break;
                    case "Miercuri":
                        ziP = 4;
                        break;
                    case "Joi":
                        ziP = 5;
                        break;
                    case "Vineri":
                        ziP = 6;
                        break;
                    case "Sambata":
                        ziP = 7;
                        break;
                    default:
                        ziP = 1;
                        break;
                }
                pondere = labelTrackBar.Text.ToString();
                nrMax = nrStudTextBox.Text.ToString();
                dataIncepere = incepereDateTimePicker1.Value;
                dataFinalizare = finalizareDateTimePicker1.Value;
                int pondere_locala = 0;
                MySqlCommand cmd1 = new MySqlCommand("select pondere_locala(" + userID + ",'" + curs + "');", con);
                pondere_locala = (int)cmd1.ExecuteScalar();
                if (pondere_locala + Int32.Parse(pondere) <= 100)
                {
                    try
                    {
                        int nrStud = Int32.Parse(nrMax);

                        string sqlProcExe = "call prof_asign_act(" + userID + ", '" + curs + "', " + ora + ", " + ziP + ", " + pondere + ", "
                            + nrStud + ", " + tip + ", '" + dataIncepere.ToString("yyyy-MM-dd") + "', '" + dataFinalizare.ToString("yyyy-MM-dd") + "');";

                        //MessageBox.Show(sqlProcExe);

                        MySqlCommand cmd = new MySqlCommand(sqlProcExe, con);
                        cmd.ExecuteNonQuery();


                        MessageBox.Show("Activitatea a fost adaugata cu succes!");
                        con.Close();
                        this.Close();
                        profForm.Show();
                    }
                    catch (FormatException exception)
                    {
                        MessageBox.Show("Introduceti un numar intreg valid de studenti");
                    }
                }
                else
                {
                    MessageBox.Show("Ati depasit ponderea maxima admisa (100) cu " + (pondere_locala + Int32.Parse(pondere) - 100));
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("Completati toate campurile inainte de a finaliza");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.Close();
            this.Close();
            profForm.Show();
        }

    }
}
