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
    public partial class doctoradddeleupdate : Form
    {
        private int c = 1;
        public doctoradddeleupdate()
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
            contact.Text = "";
            qualification.Text = "";
            sex.Text = "";
            email.Text = "";
        }
        void fillcombo()
        {

            string mysql = "datasource=localhost;port=3306;username=root;password=@password";
            MySqlConnection myconn = new MySqlConnection(mysql);
            string q = "select * from hospmg.doctor_details";

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
            string mysql = "datasource=localhost;port=3306;username=root;password=@password";
            MySqlConnection myconn = new MySqlConnection(mysql);

            MySqlCommand cmdDataBase = new MySqlCommand("select * from hospmg.doctor_details", myconn);

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


        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
           doctormenu dm = new doctormenu();
            dm.ShowDialog();
            this.Close();
        }

        private void select_Click(object sender, EventArgs e)
        {
            c = 0;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string a = comboBox1.Text;


            string mysql = "datasource=localhost;port=3306;username=root;password=@password";
            MySqlConnection myconn = new MySqlConnection(mysql);

            string q = "select * from hospmg.doctor_details where Name='" + comboBox1.Text + "';";

            MySqlCommand SelectCommand = new MySqlCommand(q, myconn);
            MySqlDataReader myreader;
            try
            {



                myconn.Open();
                myreader = SelectCommand.ExecuteReader();

                while (myreader.Read())
                {
                    string sid = myreader.GetInt32("ID").ToString();
                    string sname = myreader.GetString("Name");
                    string saddress = myreader.GetString("Address");
                    string scontact = myreader.GetString("Phone Number");
                    string squalification = myreader.GetString("Qualification");
                    string sgender = myreader.GetString("Gender");
                    string semail = myreader.GetString("email id");
                    

                    no.Text = sid;
                    name.Text = sname;

                    address.Text = saddress;
                    contact.Text = scontact;
                    qualification.Text = squalification;
                    sex.Text = sgender;
                    email.Text = semail;



                }

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "message", MessageBoxButtons.OK);
            }
        }

        private void add_Click(object sender, EventArgs e)
        {

            string mysql = "datasource=localhost;port=3306;username=root;password=@password";
            MySqlConnection myconn = new MySqlConnection(mysql);
            string q = "insert into hospmg.doctor_details values ('" + this.no.Text + "','" + this.name.Text + "','" + this.address.Text + "','" + this.contact.Text + "','" + this.qualification.Text + "','"+this.sex.Text+"','"+this.email.Text+"');";

            MySqlCommand SelectCommand = new MySqlCommand(q, myconn);
            MySqlDataReader myreader;
            try
            {


                myconn.Open();
                myreader = SelectCommand.ExecuteReader();
                MessageBox.Show("new Doctor added");


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

                string mysql = "datasource=localhost;port=3306;username=root;password=@password";
                MySqlConnection myconn = new MySqlConnection(mysql);
                string q = "UPDATE `hospmg`.`doctor_details` SET `ID`= '" + this.no.Text + "', `Name`= '" + this.name.Text + "', `Address`= '" + this.address.Text + "', `Phone Number`= '" + this.contact.Text + "', `Qualification`= '" + this.qualification.Text + "',`Gender`='"+this.sex.Text+"',`email id`='"+this.email.Text+"'WHERE `ID`= '" + this.no.Text + "';";

                MySqlCommand SelectCommand = new MySqlCommand(q, myconn);
                MySqlDataReader myreader;
                try
                {


                    myconn.Open();
                    myreader = SelectCommand.ExecuteReader();
                    MessageBox.Show("Doctor details updated", "message", MessageBoxButtons.OK, MessageBoxIcon.Information);


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

                string mysql = "datasource=localhost;port=3306;username=root;password=@password";
                MySqlConnection myconn = new MySqlConnection(mysql);
                string q = "DELETE FROM `hospmg`.`doctor_details` WHERE `ID`= '" + this.no.Text + "';";

                MySqlCommand SelectCommand = new MySqlCommand(q, myconn);
                MySqlDataReader myreader;
                try
                {


                    myconn.Open();
                    myreader = SelectCommand.ExecuteReader();
                    string q2 = "selected doctor=" + this.name.Text + " is successfully deleted";
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
