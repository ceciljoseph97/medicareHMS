using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace medicare_hms
{
    public partial class patientadddeleupdate : Form
    {
        private int c;

        public patientadddeleupdate()
        {
            InitializeComponent();
            refreshdb();
            fillcombo();
            refreshtexts();
        }
        void refreshtexts()
        {
            no.Text = "";
            name.Text = "";

            address.Text = "";
            age.Text = "";
            contact1.Text = "";
            sex.Text = "";
            contact2.Text = "";
            room.Text = "";

        }
        void fillcombo()
        {

            string mysql = "datasource=localhost;port=3306;username=root;password=Mariagorethi007@";
            MySqlConnection myconn = new MySqlConnection(mysql);
            string q = "select * from hospmg.patient_details";

            MySqlCommand SelectCommand = new MySqlCommand(q, myconn);
            MySqlDataReader myreader;
            try
            {


                myconn.Open();
                myreader = SelectCommand.ExecuteReader();

                while (myreader.Read())
                {
                    string sname = myreader.GetString("Name");
                   
                    comboBox1.Items.Add(sname);

                }

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "message", MessageBoxButtons.OK);
            }

        }
        void refreshdb()
        {
            string mysql = "datasource=localhost;port=3306;username=root;password=Mariagorethi007@";
            MySqlConnection myconn = new MySqlConnection(mysql);

            MySqlCommand cmdDataBase = new MySqlCommand("select * from hospmg.patient_details", myconn);

            try
            {
                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand = cmdDataBase;
                DataTable dbdataset = new DataTable();
                sda.Fill(dbdataset);
                BindingSource bsource = new BindingSource();

                bsource.DataSource = dbdataset;
                dataGridView1.DataSource = bsource;
                sda.Update(dbdataset);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "message", MessageBoxButtons.OK);


            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
         patientmenu pm = new patientmenu();
            pm.ShowDialog();
            this.Close();
        }

        private void check_Click(object sender, EventArgs e)
        {
            c= 0;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            string a = comboBox1.Text;


            string mysql = "datasource=localhost;port=3306;username=root;password=Mariagorethi007@";
            MySqlConnection myconn = new MySqlConnection(mysql);

            string q = "select * from hospmg.patient_details where Name='" + comboBox1.Text + "';";

            MySqlCommand SelectCommand = new MySqlCommand(q, myconn);
            MySqlDataReader myreader;
            try
            {



                myconn.Open();
                myreader = SelectCommand.ExecuteReader();

                while (myreader.Read())
                {
                    string sid = myreader.GetInt32("Patient_no").ToString();
                    
                    string sname = myreader.GetString("Name");
                    string sage = myreader.GetInt32("Age").ToString();
                    string saddress = myreader.GetString("Address");
                    string sgender = myreader.GetString("Gender");
                    string scontact = myreader.GetString("Contact Number");
                    string scontact2 = myreader.GetString("Contact Number 2");
                    
                    string sroom = myreader.GetInt32("Room No").ToString();


                    no.Text = sid;
                    name.Text = sname;

                    address.Text = saddress;
                    contact1.Text = scontact;
                    contact2.Text = scontact2;
                    sex.Text = sgender;
                    age.Text = sage;
                    room.Text = sroom;




                }

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "message", MessageBoxButtons.OK);
            }
        }

        private void add_Click(object sender, EventArgs e)
        {

            string mysql = "datasource=localhost;port=3306;username=root;password=Mariagorethi007@";
            MySqlConnection myconn = new MySqlConnection(mysql);
            string q = "insert into hospmg.patient_details values ('" + this.no.Text + "','" + this.name.Text + "','"+this.age.Text+"','"+ this.sex.Text + "','" + this.address.Text + "','" + this.contact1.Text + "','" + this.contact2.Text + "','" + this.room.Text + "');";

            MySqlCommand SelectCommand = new MySqlCommand(q, myconn);
            MySqlDataReader myreader;
            try
            {


                myconn.Open();
                myreader = SelectCommand.ExecuteReader();
                MessageBox.Show("new patient is  added");


                while (myreader.Read())
                {


                }
                refreshdb();

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "message", MessageBoxButtons.OK);
            }
            comboBox1.Items.Clear();
            fillcombo();
            refreshtexts();
        }

        private void update_Click(object sender, EventArgs e)
        {
            if (c == 0)
            {

                string mysql = "datasource=localhost;port=3306;username=root;password=Mariagorethi007@";
                MySqlConnection myconn = new MySqlConnection(mysql);
                string q = "UPDATE `hospmg`.`patient_details` SET `Patient_no`= '" + this.no.Text + "', `Name`= '" + this.name.Text + "', `Address`= '" + this.address.Text + "', `Contact Number`= '" + this.contact1.Text + "', `Contact Number 2`= '" + this.contact2.Text + "',`Gender`='" + this.sex.Text + "',`Room No`='" + this.room.Text + "'WHERE `Patient_no`= '" + this.no.Text + "';";

                MySqlCommand SelectCommand = new MySqlCommand(q, myconn);
                MySqlDataReader myreader;
                try
                {


                    myconn.Open();
                    myreader = SelectCommand.ExecuteReader();
                    MessageBox.Show("patient details updated", "message", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    while (myreader.Read())
                    {


                    }
                    refreshdb();
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            c = 1;
            refreshtexts();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            if (c == 0)
            {

                string mysql = "datasource=localhost;port=3306;username=root;password=Mariagorethi007@";
                MySqlConnection myconn = new MySqlConnection(mysql);
                string q = "DELETE FROM `hospmg`.`patient_details` WHERE `Patient_no`= '" + this.no.Text + "';";

                MySqlCommand SelectCommand = new MySqlCommand(q, myconn);
                MySqlDataReader myreader;
                try
                {


                    myconn.Open();
                    myreader = SelectCommand.ExecuteReader();
                    string q2 = "selected patient=" + this.name.Text + " is successfully deleted";
                    MessageBox.Show(q2, "message", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    while (myreader.Read())
                    {


                    }
                    comboBox1.Items.Clear();
                    fillcombo();
                    refreshdb();
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            c = 1;
            comboBox1.Items.Clear();
            fillcombo();
            refreshtexts();
        }
    }
}
