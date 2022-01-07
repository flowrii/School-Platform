using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Pro1
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        public void refresh()
        {
            this.userTextBox.Text = null;
            this.passTextBox.Text = null;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void accesBtn_Click(object sender, EventArgs e)
        {

            string userInput = userTextBox.Text;
            string passInput = passTextBox.Text;
            string userID;

            string myConString = "server=localhost;uid=root;" + "pwd=root;database=prototype1";

            MySqlConnection con = new MySqlConnection(myConString);
            try
            {
                con.Open();
                MySqlDataAdapter sda = new MySqlDataAdapter("Select Count(*) from UTILIZATOR where USERNAME='" + userInput + "' and PASSWORD='" + passInput + "'", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows[0][0].ToString() == "1")
                {
                    MySqlDataAdapter sda_id = new MySqlDataAdapter("Select user_id from UTILIZATOR where USERNAME='" + userInput + "' and PASSWORD='" + passInput + "'", con);
                    DataTable dtID = new DataTable();
                    sda_id.Fill(dtID);
                    userID = dtID.Rows[0][0].ToString();

                    MySqlDataAdapter sda_tip = new MySqlDataAdapter("Select tip from UTILIZATOR where USERNAME='" + userInput + "' and PASSWORD='" + passInput + "'", con);
                    DataTable dt2 = new DataTable();
                    sda_tip.Fill(dt2);
                    switch(dt2.Rows[0][0].ToString())
                    {
                        case "0":
                            this.Hide();
                            MainFormStudent ms = new MainFormStudent(userTextBox.Text, this, con, userID);
                            ms.Show();
                            break;
                        case "1":
                            this.Hide();
                            MainFormProfesor mp = new MainFormProfesor(userTextBox.Text, this, con, userID);
                            mp.Show();
                            break;
                        default:
                            this.Hide();
                            MainFormAdmin ma = new MainFormAdmin(userTextBox.Text, this, con, userID, Int32.Parse(dt2.Rows[0][0].ToString()));
                            ma.Show();
                            break;
                    }
                }
                else
                    MessageBox.Show("User sau parolă greșite!");
            }
            catch (MySqlException exception)
            {
                MessageBox.Show("Nu s-a putut realiza conectarea. Încercati mai tarziu!");
            }
            finally
            {
                con.Close();
            }
            
        }

    }
}
