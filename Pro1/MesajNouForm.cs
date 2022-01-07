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
    public partial class MesajNouForm : Form
    {
        string userID;
        string grupID;
        MySqlConnection con;
        MesajeForm mesaje;
        public MesajNouForm()
        {
            InitializeComponent();
        }

        public MesajNouForm(string userID, string grupID, MySqlConnection con, MesajeForm mesaje)
        {
            InitializeComponent();
            this.userID = userID;
            this.grupID = grupID;
            this.con = con;
            this.mesaje = mesaje;
        }

        private void inapoiBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            mesaje.Show();
        }

        private void trimiteBtn_Click(object sender, EventArgs e)
        {
            string mesaj;
            if (mesajTxtBox.Text.Length > 0)
                mesaj = mesajTxtBox.Text;
        }
    }
}
