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
    public partial class adminupdate : Form
    {
        private int c=1;

        public adminupdate()
        {
            InitializeComponent();
            fillcombo();
            refreshdb();
        }
        void refreshdb()
        {
            string mysql = "datasource=localhost;port=3306;username=root;password=@password";
            MySqlConnection myconn = new MySqlConnection(mysql);

            MySqlCommand cmdDataBase = new MySqlCommand("select * from hospmg.admin_list;", myconn);

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
        void fillcombo()
        {

            string mysql = "datasource=localhost;port=3306;username=root;password=@password";
            MySqlConnection myconn = new MySqlConnection(mysql);
            string q = "select * from hospmg.admin_list";

            MySqlCommand SelectCommand = new MySqlCommand(q, myconn);
            MySqlDataReader myreader;
            try
            {


                myconn.Open();
                myreader = SelectCommand.ExecuteReader();
               
                while (myreader.Read())
                {
                    string sname = myreader.GetString("name");
                    comboBox1.Items.Add(sname);

                }

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "message", MessageBoxButtons.OK);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (c == 0)
            {

                string mysql = "datasource=localhost;port=3306;username=root;password=@password";
                MySqlConnection myconn = new MySqlConnection(mysql);
                string q = "UPDATE `hospmg`.`admin_list` SET `name`= '" + this.name.Text + "', `password`= '" + this.password.Text + "', `gender`= '" + this.sex.Text + "', `age`= '" + this.age.Text + "', `address`= '" + this.address.Text + "', `contact no`= '" + this.contact.Text + "', `email id`= '" + this.email.Text + "' WHERE `admin id`= '" + this.adminid.Text + "';";

                MySqlCommand SelectCommand = new MySqlCommand(q, myconn);
                MySqlDataReader myreader;
                try
                {

                    
                    myconn.Open();
                    myreader = SelectCommand.ExecuteReader();
                    MessageBox.Show("admin table updated","message",MessageBoxButtons.OK,MessageBoxIcon.Information);


                    while (myreader.Read())
                    {


                    }
                    refreshdb();
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "message", MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }c = 1;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string mysql = "datasource=localhost;port=3306;username=root;password=@password";
            MySqlConnection myconn = new MySqlConnection(mysql);

            MySqlCommand cmdDataBase = new MySqlCommand("select * from hospmg.admin_list;", myconn);

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

        private void button4_Click(object sender, EventArgs e)
        {
           c = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 f3 = new Form3();
            f3.ShowDialog();
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string mysql = "datasource=localhost;port=3306;username=root;password=@password";
            MySqlConnection myconn = new MySqlConnection(mysql);
            string q = "select * from hospmg.admin_list where name='"+comboBox1.Text+"';" ;

            MySqlCommand SelectCommand = new MySqlCommand(q, myconn);
            MySqlDataReader myreader;
            try
            {


                myconn.Open();
                myreader = SelectCommand.ExecuteReader();

                while (myreader.Read())
                {
                    string sid = myreader.GetInt32("admin id").ToString();
                    string sname = myreader.GetString("name");
                    string spass = myreader.GetString("password");
                    string sgender = myreader.GetString("gender");
                    string sage = myreader.GetInt32("age").ToString();
                    string saddress = myreader.GetString("address");
                    string scontact = myreader.GetString("contact no");
                    string semail = myreader.GetString("email id");
                    adminid.Text = sid;
                    name.Text = sname;
                    password.Text = spass;
                    sex.Text = sgender;
                    age.Text = sage;
                    address.Text = saddress;
                    contact.Text = scontact;
                    email.Text = semail;

                }

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "message", MessageBoxButtons.OK);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (c == 0)
            {

                string mysql = "datasource=localhost;port=3306;username=root;password=@password";
                MySqlConnection myconn = new MySqlConnection(mysql);
                string q = "DELETE FROM `hospmg`.`admin_list` WHERE `admin id`= '" + this.adminid.Text + "';";

                MySqlCommand SelectCommand = new MySqlCommand(q, myconn);
                MySqlDataReader myreader;
                try
                {


                    myconn.Open();
                    myreader = SelectCommand.ExecuteReader();
                    string q2 = "selected id=" + this.adminid.Text + " is successfully deleted";
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
            }c = 1;  
        }
    }
}
