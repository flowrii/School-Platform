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
    public partial class AdaugaUserForm : Form
    {
        AdminShowForm af;
        MySqlConnection con;
        int tip;
        public AdaugaUserForm()
        {
            InitializeComponent();
        }

        public AdaugaUserForm(AdminShowForm af, MySqlConnection con, int tip)
        {
            InitializeComponent();
            this.af = af;
            this.con = con;
            this.tip = tip;
            switch (tip)
            {
                case 0:
                    this.labelNrMinOre.Visible = false;
                    this.nrMinOreTxtBox.Visible = false;
                    this.labelNrMaxOre.Visible = false;
                    this.nrMaxOreTxtBox.Visible = false;
                    break;
                case 1:
                    this.labelAn.Visible = false;
                    this.anTxtBox.Visible = false;
                    this.labelNrOre.Visible = false;
                    this.nrOreTxtBox.Visible = false;
                    break;
                default:
                    this.labelNrMinOre.Visible = false;
                    this.nrMinOreTxtBox.Visible = false;
                    this.labelNrMaxOre.Visible = false;
                    this.nrMaxOreTxtBox.Visible = false;
                    this.labelAn.Visible = false;
                    this.anTxtBox.Visible = false;
                    this.labelNrOre.Visible = false;
                    this.nrOreTxtBox.Visible = false;
                    break;
            }
        }

        private void inapoiBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            af.Show();
        }

        private void adaugaBtn_Click(object sender, EventArgs e)
        {
            con.Close();
            con.Open();
            string var1;
            string var2;
            switch (tip)
            {
                case 1:
                    var1 = nrMinOreTxtBox.Text;
                    var2 = nrMaxOreTxtBox.Text;
                    break;
                case 2:
                    var1 = nrOreTxtBox.Text;
                    var2 = anTxtBox.Text;
                    break;
                default:
                    var1 = "0";
                    var2 = "0";
                    break;
            }
            string sqlCmd = "call creare_utilizator('" + cnpTxtBox.Text + "', '" + numeTxtBox.Text + "', '" + prenumeTxtBox.Text + "', '" +
                adresaTxtBox.Text + "', '" + telTxtBox.Text + "', '" + emailTxtBox.Text + "', '" + ibanTxtBox.Text + "', '" +
                contractTxtBox.Text + "', '" + userTxtBox.Text + "', '" + parolaTxtBox.Text + "', " + tip + ", '" + var1 + "', '" + var2 + "');";
            MySqlCommand cmd = new MySqlCommand(sqlCmd, con);
            cmd.ExecuteNonQuery();

            if (tip == 1)
                MessageBox.Show("Profesorul a fost adaugat cu succes!");
            if (tip == 0)
                MessageBox.Show("Studentul a fost adaugat cu succes!");
            if (tip == 2)
                MessageBox.Show("Adminul a fost adaugat cu succes!");
            con.Close();
            this.Close();
            af.Close();
            af = new AdminShowForm(this.af.ma, con, this.af.userID, tip);
            af.Show();
        }
    }
}
