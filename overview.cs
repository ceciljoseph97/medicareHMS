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
    public partial class overview : Form
    {
        public overview()
        {
            InitializeComponent();
            getstuffs();
            getstuffs1();
            getstuffs2();
            getstuffs3();
            chart_1();
           

        }
        void chart_1()
        {
            string a = docno.Text;
            string b = roomno.Text;
            string c = patientno.Text;
            string d = staffno.Text;
            int a1 = Int32.Parse(a);
            int b1 = Int32.Parse(b);
            int c1 = Int32.Parse(c);
            int d1 = Int32.Parse(d);
            this.chart1.Series["Doctors"].Points.AddXY("Doctors",a1);
            this.chart1.Series["Patients"].Points.AddXY("Patients",c1);
            this.chart1.Series["Rooms"].Points.AddXY("Rooms", b1);
            this.chart1.Series["Staffs"].Points.AddXY("Staffs", d1);
        }
        
        
        void getstuffs()
        {
           

            string mysql = "datasource=localhost;port=3306;username=root;password=Mariagorethi007@";
            MySqlConnection myconn = new MySqlConnection(mysql);

            string q = "select count(no) from hospmg.room_details ;";

            MySqlCommand SelectCommand = new MySqlCommand(q, myconn);
            MySqlDataReader myreader;
            try
            {



                myconn.Open();
                myreader = SelectCommand.ExecuteReader();
                while (myreader.Read())
                {

                    string sid = myreader.GetInt32("count(no)").ToString();
                    roomno.Text= sid;
                }
                myconn.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "message", MessageBoxButtons.OK);
            }
           
        }
        void getstuffs1()
        {


            string mysql = "datasource=localhost;port=3306;username=root;password=Mariagorethi007@";
            MySqlConnection myconn = new MySqlConnection(mysql);

            string q = "select count(Patient_no) from hospmg.patient_details ;";

            MySqlCommand SelectCommand = new MySqlCommand(q, myconn);
            MySqlDataReader myreader;
            try
            {



                myconn.Open();
                myreader = SelectCommand.ExecuteReader();
                while (myreader.Read())
                {

                    string sid = myreader.GetInt32("count(Patient_no)").ToString();
                    patientno.Text = sid;
                }
                myconn.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "message", MessageBoxButtons.OK);
            }

        }
        void getstuffs2()
        {


            string mysql = "datasource=localhost;port=3306;username=root;password=Mariagorethi007@";
            MySqlConnection myconn = new MySqlConnection(mysql);

            string q = "select count(ID) from hospmg.doctor_details ;";

            MySqlCommand SelectCommand = new MySqlCommand(q, myconn);
            MySqlDataReader myreader;
            try
            {



                myconn.Open();
                myreader = SelectCommand.ExecuteReader();
                while (myreader.Read())
                {

                    string sid = myreader.GetInt32("count(ID)").ToString();
                    docno.Text = sid;
                }
                myconn.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "message", MessageBoxButtons.OK);
            }

        }
        void getstuffs3()
        {


            string mysql = "datasource=localhost;port=3306;username=root;password=Mariagorethi007@";
            MySqlConnection myconn = new MySqlConnection(mysql);

            string q = "select count(staff_id) from hospmg.staff_list ;";

            MySqlCommand SelectCommand = new MySqlCommand(q, myconn);
            MySqlDataReader myreader;
            try
            {



                myconn.Open();
                myreader = SelectCommand.ExecuteReader();
                while (myreader.Read())
                {

                    string sid = myreader.GetInt32("count(staff_id)").ToString();
                    staffno.Text = sid;
                }
                myconn.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "message", MessageBoxButtons.OK);
            }

        }
        private void Back_Click(object sender, EventArgs e)
        {

            this.Hide();
            Form2 f2 = new Form2();
            f2.ShowDialog();
            this.Close();
        }

        private void chart2_Click(object sender, EventArgs e)
        {

        }
    }
}
