﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Pro1
{
    public partial class ActivitateNouaForm : Form
    {
        string userID;
        string grupID;
        MySqlConnection con;
        ActivitatiGRUPForm activitati;

        int[] profiID = new int[100];
        int ctP = 0;
        public ActivitateNouaForm()
        {
            InitializeComponent();
        }

        public ActivitateNouaForm(string userID, string grupID, MySqlConnection con, ActivitatiGRUPForm activitati)
        {
            InitializeComponent();
            this.userID = userID;
            this.grupID = grupID;
            this.con = con;
            this.activitati = activitati;
        }

        private void inapoiBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            activitati.Show();
        }

        private void adaugaBtn_Click(object sender, EventArgs e)
        {
            string profDeInserat;
            string descriere;
            int nrMin = 0, ora, timpInscriere;
            DateTime dataT;
            try
            {
                descriere = descriereTxtBox.Text;
                nrMin = Int32.Parse(nrMinTxtBox.Text);
                dataT = dateTimePicker1.Value;

                if(dataT.CompareTo(DateTime.Today)<0)
                {
                    MessageBox.Show("Data aleasa este invalida!");
                    return;
                }

                ora = Int32.Parse(oraComboBox.SelectedItem.ToString());
                timpInscriere = Int32.Parse(timpExpirareTxtBox.Text);
                
                if(profiComboBox.Text.Equals("Selectati un profesor"))
                {
                    profDeInserat = "null";
                }
                else
                {
                    profDeInserat = profiID[profiComboBox.SelectedIndex].ToString();
                }

                string insertProf = "insert into activitate_grup(descriere, nr_min_participanti, data_activitate, ora, timp_expirare, grup_id, nr_participanti, prof_id) " +
                    "values ('" + descriere + "', " + nrMin + ", '" + dataT.ToString("yyyy-MM-dd") + "', " + ora + ", " + timpInscriere + ", " + grupID + ", 0, " + profDeInserat + ");";
                MySqlCommand cmd1 = new MySqlCommand(insertProf, con);
                cmd1.ExecuteNonQuery();

                string adaugaPart = "call auto_inserare(" + userID + ");";
                cmd1 = new MySqlCommand(adaugaPart, con);
                cmd1.ExecuteNonQuery();

                MessageBox.Show("Activitate adaugata cu succes!");

            }
            catch (Exception exception)
            {
                MessageBox.Show("Completati toate campurile inainte de a finaliza");
            }
        }

        private void ActivitateNouaForm_Load(object sender, EventArgs e)
        {
            con.Close();
            con.Open();

            profiComboBox.Visible = false;

            string sugestie = "call sugerare_fereastra("+grupID+");";
            MySqlCommand cmd1 = new MySqlCommand(sugestie, con);
            cmd1.ExecuteNonQuery();
            string rezSugestie="select freq, ora as Ora, case when ziua = 1 then \"Duminica\" when ziua = 2 then \"Luni\" " +
            " when ziua = 3 then \"Marti\" when ziua = 4 then \"Miercuri\" when ziua = 5 then \"Joi\" when ziua = 6 then \"Vineri\" else \"Sambata\" end as Zi " +
            " from freq_search order by freq asc limit 1; ";
            MySqlCommand cmd2 = new MySqlCommand(rezSugestie, con);
            MySqlDataReader reader = cmd2.ExecuteReader();

            string zi="default", ora="default";

            while(reader.Read())
            {
                ora = reader.GetString("Ora");
                zi = reader.GetString("Zi");
            }

            reader.Close();

            if (ora != "default" && zi != "default")
                labelSugestie.Text = labelSugestie.Text + zi + ", la ora " + ora;
            else
                labelSugestie.Visible = false;

            profiComboBox.Text = "Selectati un profesor";
            string query = "select prof_id as id, utilizator.nume as Nume, utilizator.prenume as Prenume from curs " +
                        "join profesor_curs using(curs_id) join profesor using(prof_id) join utilizator on user_id=profesor.prof_id " +
                        "where curs.curs_id=(select curs_id from grup where grup_id=" + grupID + ");";
            MySqlCommand cmd = new MySqlCommand(query, con);
            reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                profiID[ctP++] = reader.GetInt32("id");
                profiComboBox.Items.Add(reader.GetString("Nume") + " " + reader.GetString("Prenume"));
            }
            reader.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                profiComboBox.Visible = true;
            }
            else
            {
                profiComboBox.Visible = false;
            }
        }
    }
}
