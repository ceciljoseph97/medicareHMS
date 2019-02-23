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
    public partial class search : Form
    {
        private string a;
        private string b;

        public search()
        {
            InitializeComponent();
            fillcombo();
        }
        void fillcombo()
        {
            comboBox1.Items.Add("Doctor");
            comboBox1.Items.Add("Staffs");
            comboBox1.Items.Add("Patients");
           
            
        }
        void fillcombo1()
        {
            try
            {

                string mysql = "datasource=localhost;port=3306;username=root;password=@password";
                MySqlConnection myconn = new MySqlConnection(mysql);
                if (comboBox1.Text == "Doctor")
                {
                    a = "doctor_details";
                    b = "Name";
                    string q = "select * from hospmg.doctor_details";

                    MySqlCommand SelectCommand = new MySqlCommand(q, myconn);
                    MySqlDataReader myreader;
                    try
                    {


                        myconn.Open();
                        myreader = SelectCommand.ExecuteReader();

                        while (myreader.Read())
                        {
                            string sid = myreader.GetString("Name");
                            comboBox2.Items.Add(sid);

                        }

                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "message", MessageBoxButtons.OK);
                    }
                }
                else if (comboBox1.Text == "Patients")
                {
                    a = "patient_details";
                    b = "Name";
                    string q = "select * from hospmg.patient_details";

                    MySqlCommand SelectCommand = new MySqlCommand(q, myconn);
                    MySqlDataReader myreader;
                    try
                    {


                        myconn.Open();
                        myreader = SelectCommand.ExecuteReader();

                        while (myreader.Read())
                        {
                            string sid = myreader.GetString("Name");
                            comboBox2.Items.Add(sid);

                        }

                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "message", MessageBoxButtons.OK);
                    }
                }
                else
                {
                    a = "staff_list";
                    b = "staff_name";
                    string q = "select * from hospmg.staff_list";

                    MySqlCommand SelectCommand = new MySqlCommand(q, myconn);
                    MySqlDataReader myreader;
                    try
                    {


                        myconn.Open();
                        myreader = SelectCommand.ExecuteReader();

                        while (myreader.Read())
                        {
                            string sid = myreader.GetString("staff_name");
                            comboBox2.Items.Add(sid);

                        }

                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "message", MessageBoxButtons.OK);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "message", MessageBoxButtons.OK);
            }
        }
        
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f2 = new Form2();
            f2.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {   
                string mysql = "datasource=localhost;port=3306;username=root;password=@password";
                MySqlConnection myconn = new MySqlConnection(mysql);
                string query = "select * from `hospmg`.`" + a + "` where `" + b + "`='" + this.comboBox2.Text + "';";
                MySqlCommand cmdDataBase = new MySqlCommand(query, myconn);


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
            comboBox2.Items.Clear();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
            fillcombo1();


        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
        
        }
    }
    }
    

