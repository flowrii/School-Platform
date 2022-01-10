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
    public partial class InscriereStudentCurs : Form
    {
        MySqlConnection con;
        string userID;
        MainFormStudent ms;
        int[] CURS = new int[100];

        int[] cursuri_id = new int[100];
        int[] seminarii_id = new int[100];
        int[] laboratoare_id = new int[100];

        string prof_id = "";

        int ct;
        public InscriereStudentCurs()
        {
            InitializeComponent();
        }

        public InscriereStudentCurs(string userID, MainFormStudent ms, MySqlConnection con)
        {
            InitializeComponent();
            this.con = con;
            this.userID = userID;
            this.ms = ms;
            this.ct = 0;
        }

        private void inapoiBtn_Click(object sender, EventArgs e)
        {
            if (ct == 1)
            {
                cursuriComboBox.Visible = true;
                selectatiLabel.Visible = true;
                label3.Visible = false;
                cursLabel.Visible = false;
                cursActComboBox.Visible = false;
                seminarLabel.Visible = false;
                seminarActComboBox.Visible = false;
                laboratorLabel.Visible = false;
                labActComboBox.Visible = false;
                ct--;

                cursActComboBox.Items.Clear();
                seminarActComboBox.Items.Clear();
                labActComboBox.Items.Clear();
            }
            else
            {
                ms.Show();
                this.Close();
                con.Close();
            }
        }

        private string nr_to_Zi(string nr)
        {
            switch (nr)
            {
                case "2":
                    return "Luni";
    
                case "3":
                    return "Marti";
                   
                case "4":
                    return "Miercuri";
                    
                case "5":
                    return "Joi";
                   
                case "6":
                    return "Vineri";
                    
                case "7":
                    return "Sambata";

                default:
                    return "Duminica";
            }
        }

        private void InscriereStudentCurs_Load(object sender, EventArgs e)
        {
            con.Close();
            con.Open();

            label3.Visible = false;
            cursLabel.Visible = false;
            cursActComboBox.Visible = false;
            seminarLabel.Visible = false;
            seminarActComboBox.Visible = false;
            laboratorLabel.Visible = false;
            labActComboBox.Visible = false;

            string cursuri = "select curs_id, denumire from curs";
            MySqlCommand cmd = new MySqlCommand(cursuri, con);
            MySqlDataReader reader = cmd.ExecuteReader();

            int ct_curs=0;

            while (reader.Read())
            {
                CURS[ct_curs++] = reader.GetInt32("curs_id");
                cursuriComboBox.Items.Add(reader.GetString("denumire"));
            }
            reader.Close();

        }

        private void cursuriComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            string profQuery = "select prof_id from profesor_curs where curs_id =" + CURS[cursuriComboBox.SelectedIndex]+ " order by nr_stud limit 1;";
            MySqlCommand cmd = new MySqlCommand(profQuery, con);
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                prof_id = reader.GetString("prof_id");
            }

            reader.Close();

            //verificam daca e inscris la curs deja
            string qry = "select count(*) as nr from student_curs where curs_id =" + CURS[cursuriComboBox.SelectedIndex] + " and student_id = " + userID + ";";
            cmd = new MySqlCommand(qry, con);
            reader = cmd.ExecuteReader();

            int este_la_curs = 0;

            while (reader.Read())
            {
                este_la_curs = reader.GetInt32("nr");
            }
            reader.Close();

            if (este_la_curs == 0)
            {
                ct = 1;
                cursuriComboBox.Visible = false;
                selectatiLabel.Visible = false;

                label3.Visible = true;

                cursLabel.Visible = true;
                cursActComboBox.Visible = true;

                string cursuri = "select activitate_id, ziua, ora from activitate join profesor_curs using (prof_curs_id) where tip=0 and prof_id=" + prof_id + " and profesor_curs.curs_id="+ CURS[cursuriComboBox.SelectedIndex]+"; ";
               
                int k1 = 0;

                cmd = new MySqlCommand(cursuri, con);
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    cursuri_id[k1++] = reader.GetInt32("activitate_id");
                    cursActComboBox.Items.Add(nr_to_Zi(reader.GetString("ziua")) + ", Ora: " + reader.GetString("ora"));
                }
                cursActComboBox.Items.Add("Liber");
                reader.Close();

                seminarLabel.Visible = true;
                seminarActComboBox.Visible = true;

                string seminarii = "select activitate_id, ziua, ora from activitate join profesor_curs using (prof_curs_id) where tip=1 and prof_id=" + prof_id + " and profesor_curs.curs_id=" + CURS[cursuriComboBox.SelectedIndex] + "; ";

                int k2 = 0;

                cmd = new MySqlCommand(seminarii, con);
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    seminarii_id[k2++] = reader.GetInt32("activitate_id");
                    seminarActComboBox.Items.Add(nr_to_Zi(reader.GetString("ziua")) + ", Ora: " + reader.GetString("ora"));
                }
                seminarActComboBox.Items.Add("Liber");
                reader.Close();

                laboratorLabel.Visible = true;
                labActComboBox.Visible = true;

                string laboratoare = "select activitate_id, ziua, ora from activitate join profesor_curs using (prof_curs_id) where tip=2 and prof_id=" + prof_id + " and profesor_curs.curs_id=" + CURS[cursuriComboBox.SelectedIndex] + "; ";

                int k3 = 0;

                cmd = new MySqlCommand(laboratoare, con);
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    laboratoare_id[k3++] = reader.GetInt32("activitate_id");
                    labActComboBox.Items.Add(nr_to_Zi(reader.GetString("ziua")) + ", Ora: " + reader.GetString("ora"));
                }
                labActComboBox.Items.Add("Liber");
                reader.Close();
            }
            else
            {
                MessageBox.Show("Te-ai inscris deja la cursul selectat! Mai incearca!");

            }
        }

        private void inscrieBtn_Click(object sender, EventArgs e)
        {
            int okCurs = 0;
            int okSeminar = 0;
            int okLab = 0;

            try
            {
                if (cursActComboBox.SelectedItem.ToString().Equals("Liber"))
                {
                    okCurs = 2;
                }
                else
                {
                    //verificam daca e curs valid ales

                    string queryC = "select nr_max_stud from activitate where activitate_id =" + cursuri_id[cursActComboBox.SelectedIndex] + ";";
                    MySqlCommand cmd = new MySqlCommand(queryC, con);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    int nrMaxStudCurs = 0;
                    while (reader.Read())
                    {
                        nrMaxStudCurs = reader.GetInt32("nr_max_stud");
                    }
                    reader.Close();

                    string query = "select count(*) as nr_part from participare where activitate_id = " + cursuri_id[cursActComboBox.SelectedIndex] + ";";
                    cmd = new MySqlCommand(query, con);
                    reader = cmd.ExecuteReader();
                    int nrPartCrt = 0;
                    while (reader.Read())
                    {
                        nrPartCrt = reader.GetInt32("nr_part");
                    }
                    reader.Close();

                    if (nrPartCrt < nrMaxStudCurs)
                    {
                        string oraActQ = "select ora from activitate where activitate_id = " + cursuri_id[cursActComboBox.SelectedIndex] + ";";
                        string ziuaActQ = "select ziua from activitate where activitate_id = " + cursuri_id[cursActComboBox.SelectedIndex] + ";";
                        MySqlCommand cmd1 = new MySqlCommand(oraActQ, con);
                        MySqlCommand cmd2 = new MySqlCommand(ziuaActQ, con);
                        reader = cmd1.ExecuteReader();
                        int oraAct = 0;
                        while (reader.Read())
                        {
                            oraAct = reader.GetInt32("ora");
                        }
                        reader.Close();

                        reader = cmd2.ExecuteReader();
                        int ziAct = 0;
                        while (reader.Read())
                        {
                            ziAct = reader.GetInt32("ziua");
                        }
                        reader.Close();

                        string qry = "select count(*) as nrSuprapuneri from activitate join participare using (activitate_id) where ora = " + oraAct + " and ziua = " + ziAct + " and student_id =" + userID + ";";
                        int nrSuprapuneri = 0;
                        cmd = new MySqlCommand(qry, con);
                        reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            nrSuprapuneri = reader.GetInt32("nrSuprapuneri");
                        }
                        reader.Close();

                        if (nrSuprapuneri == 0)
                        {
                            okCurs = 1;
                        }
                        else
                        {
                            MessageBox.Show("Aveti deja o activitate programata in acelasai timp cu cursul ales!");
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Nu mai sunt locuri la activitatea de curs selectata!");
                        return;
                    }
                }

                if (seminarActComboBox.SelectedItem.ToString().Equals("Liber"))
                {
                    okSeminar = 2;
                }
                else
                {
                    //verificam daca e seminar valid ales

                    string queryS = "select nr_max_stud from activitate where activitate_id =" + seminarii_id[seminarActComboBox.SelectedIndex] + ";";
                    MySqlCommand cmd = new MySqlCommand(queryS, con);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    int nrMaxStudSeminar = 0;
                    while (reader.Read())
                    {
                        nrMaxStudSeminar = reader.GetInt32("nr_max_stud");
                    }
                    reader.Close();

                    string query2 = "select count(*) as nr_part from participare where activitate_id = " + seminarii_id[seminarActComboBox.SelectedIndex] + ";";
                    cmd = new MySqlCommand(query2, con);
                    reader = cmd.ExecuteReader();
                    int nrPartCrtS = 0;
                    while (reader.Read())
                    {
                        nrPartCrtS = reader.GetInt32("nr_part");
                    }
                    reader.Close();

                    if (nrPartCrtS < nrMaxStudSeminar)
                    {
                        string oraActQ = "select ora from activitate where activitate_id = " + seminarii_id[seminarActComboBox.SelectedIndex] + ";";
                        string ziuaActQ = "select ziua from activitate where activitate_id = " + seminarii_id[seminarActComboBox.SelectedIndex] + ";";
                        MySqlCommand cmd1 = new MySqlCommand(oraActQ, con);
                        MySqlCommand cmd2 = new MySqlCommand(ziuaActQ, con);
                        reader = cmd1.ExecuteReader();
                        int oraAct = 0;
                        while (reader.Read())
                        {
                            oraAct = reader.GetInt32("ora");
                        }
                        reader.Close();

                        reader = cmd2.ExecuteReader();
                        int ziAct = 0;
                        while (reader.Read())
                        {
                            ziAct = reader.GetInt32("ziua");
                        }
                        reader.Close();

                        string qry = "select count(*) as nrSuprapuneri from activitate join participare using (activitate_id) where ora = " + oraAct + " and ziua = " + ziAct + " and student_id =" + userID + ";";
                        int nrSuprapuneri = 0;
                        cmd = new MySqlCommand(qry, con);
                        reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            nrSuprapuneri = reader.GetInt32("nrSuprapuneri");
                        }
                        reader.Close();

                        if (nrSuprapuneri == 0)
                        {
                            okSeminar = 1;
                        }
                        else
                        {
                            MessageBox.Show("Aveti deja o activitate programata in acelasai timp cu seminarul ales!");
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Nu mai sunt locuri la seminarul selectat!");
                        return;
                    }
                }

                if (labActComboBox.SelectedItem.ToString().Equals("Liber"))
                {
                    okLab = 2;
                }
                else
                {
                    //verificam daca e laborator valid ales

                    string queryL = "select nr_max_stud from activitate where activitate_id =" + laboratoare_id[seminarActComboBox.SelectedIndex] + ";";
                    MySqlCommand cmd = new MySqlCommand(queryL, con);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    int nrMaxStudLab = 0;
                    while (reader.Read())
                    {
                        nrMaxStudLab = reader.GetInt32("nr_max_stud");
                    }
                    reader.Close();

                    string query3 = "select count(*) as nr_part from participare where activitate_id = " + laboratoare_id[seminarActComboBox.SelectedIndex] + ";";
                    cmd = new MySqlCommand(query3, con);
                    reader = cmd.ExecuteReader();
                    int nrPartCrtL = 0;
                    while (reader.Read())
                    {
                        nrPartCrtL = reader.GetInt32("nr_part");
                    }
                    reader.Close();

                    if (nrPartCrtL < nrMaxStudLab)
                    {
                        string oraActQ = "select ora from activitate where activitate_id = " + laboratoare_id[seminarActComboBox.SelectedIndex] + ";";
                        string ziuaActQ = "select ziua from activitate where activitate_id = " + laboratoare_id[seminarActComboBox.SelectedIndex] + ";";
                        MySqlCommand cmd1 = new MySqlCommand(oraActQ, con);
                        MySqlCommand cmd2 = new MySqlCommand(ziuaActQ, con);
                        reader = cmd1.ExecuteReader();
                        int oraAct = 0;
                        while (reader.Read())
                        {
                            oraAct = reader.GetInt32("ora");
                        }
                        reader.Close();

                        reader = cmd2.ExecuteReader();
                        int ziAct = 0;
                        while (reader.Read())
                        {
                            ziAct = reader.GetInt32("ziua");
                        }
                        reader.Close();

                        string qry = "select count(*) as nrSuprapuneri from activitate join participare using (activitate_id) where ora = " + oraAct + " and ziua = " + ziAct + " and student_id =" + userID + ";";
                        int nrSuprapuneri = 0;
                        cmd = new MySqlCommand(qry, con);
                        reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            nrSuprapuneri = reader.GetInt32("nrSuprapuneri");
                        }
                        reader.Close();

                        if (nrSuprapuneri == 0)
                        {
                            okLab = 1;
                        }
                        else
                        {
                            MessageBox.Show("Aveti deja o activitate programata in acelasai timp cu laboratorul ales!");
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Nu mai sunt locuri la laboratorul selectat!");
                        return;
                    }
                }

                if ((okCurs != 0 && okSeminar != 0 && okLab != 0) && (okCurs != 2 || okSeminar != 2 || okLab != 2))
                {
                    string insertCursQuery = "insert into student_curs(student_id, curs_id, prof_id, nota) values (" + userID + ", "
                        + CURS[cursuriComboBox.SelectedIndex] + ", " + prof_id + ", 0);";
                    MySqlCommand cmd = new MySqlCommand(insertCursQuery, con);
                    cmd.ExecuteNonQuery();

                    if (okCurs == 1)
                    {
                        string actC = "insert into participare (student_id, activitate_id, nota) values (" + userID + ", " + cursuri_id[cursActComboBox.SelectedIndex] + ", 0);";
                        cmd = new MySqlCommand(actC, con);
                        cmd.ExecuteNonQuery();
                    }
                    if (okSeminar == 1)
                    {
                        string actS = "insert into participare (student_id, activitate_id, nota) values (" + userID + ", " + seminarii_id[seminarActComboBox.SelectedIndex] + ", 0);";
                        cmd = new MySqlCommand(actS, con);
                        cmd.ExecuteNonQuery();
                    }
                    if (okLab == 1)
                    {
                        string actL = "insert into participare (student_id, activitate_id, nota) values (" + userID + ", " + laboratoare_id[labActComboBox.SelectedIndex] + ", 0);";
                        cmd = new MySqlCommand(actL, con);
                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Te-ai inscris cu succes!");
                }
                else
                {
                    MessageBox.Show("Trebuie sa va inscrieti la cel putin o activitate a cursului selectat!");
                }
            }
            catch (NullReferenceException exception)
            {
                MessageBox.Show("Completati toate campurile inainte de a finaliza");
            }
        }
    }
}
