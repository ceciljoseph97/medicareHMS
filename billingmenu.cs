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
    public partial class billingmenu : Form
    {
        private int c;
        public billingmenu()
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

            date.Text = "";
            age.Text = "";
            
            sex.Text = "";
         
          
            
            dateadmission.Text = "";
            datedischarge.Text = "";
            pid.Text = "";
            roomcharges.Text = "0";
            pathofee.Text = "0";
            docfee.Text = "0";
            miscefee.Text = "0";
            totalfee.Text = "0";

        }
        void findtotal()
        {
            int rf, pf, mf, tf, df;
            rf = int.Parse(roomcharges.Text);
            pf = int.Parse(pathofee.Text);
            mf = int.Parse(miscefee.Text);
            df = int.Parse(docfee.Text);
            tf = rf + pf + mf + df;
            totalfee.Text = tf.ToString();
        }
        void fillcombo()
        {

            string mysql = "datasource=localhost;port=3306;username=root;password=@password";
            MySqlConnection myconn = new MySqlConnection(mysql);
            string q = "select * from hospmg.bill_details";

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

            MySqlCommand cmdDataBase = new MySqlCommand("select * from hospmg.bill_details", myconn);

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

        private void check_Click(object sender, EventArgs e)
        {
            c = 0;
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f2 = new Form2();
            f2.ShowDialog();
            this.Close();
        }

        private void add_Click(object sender, EventArgs e)
        {

            string mysql = "datasource=localhost;port=3306;username=root;password=@password";
            MySqlConnection myconn = new MySqlConnection(mysql);
            string q = "insert into hospmg.bill_details values ('" + this.no.Text + "','" + this.date.Text + "','" + this.pid.Text + "','" + this.name.Text + "','" + this.age.Text + "','" + this.sex.Text + "','" + this.dateadmission.Text + "','" + this.datedischarge.Text + "','"+this.roomcharges.Text+"','"+this.pathofee.Text+"','"+this.docfee.Text+"','"+this.miscefee.Text+"','"+this.totalfee.Text+"');";

            MySqlCommand SelectCommand = new MySqlCommand(q, myconn);
            MySqlDataReader myreader;
            try
            {


                myconn.Open();
                myreader = SelectCommand.ExecuteReader();
                MessageBox.Show("new bill is generated");


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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            string a = comboBox1.Text;


            string mysql = "datasource=localhost;port=3306;username=root;password=@password";
            MySqlConnection myconn = new MySqlConnection(mysql);

            string q = "select * from hospmg.bill_details where Name='" + comboBox1.Text + "';";

            MySqlCommand SelectCommand = new MySqlCommand(q, myconn);
            MySqlDataReader myreader;
            try
            {



                myconn.Open();
                myreader = SelectCommand.ExecuteReader();

                while (myreader.Read())
                {
                    string sid = myreader.GetInt32("Bill_no").ToString();
                    string sdate = myreader.GetString("Date");
                    string spid = myreader.GetString("Patient Id");
                    string sname = myreader.GetString("Name");
                    string sage = myreader.GetInt32("Age").ToString();
                    string sgender = myreader.GetString("Gender");
                    string sdateadmission = myreader.GetString("Date of Admission");
                    
                    string sdatedischarge = myreader.GetString("Date of Discharge");
                    string sroomfee = myreader.GetString("Room Charges");

                    string spathofee = myreader.GetString("Pathology fees");
                    string sdocfee = myreader.GetString("Doctor Fees");
                    string smiscefee = myreader.GetString("Miscellaneous");
                    string stotal = myreader.GetString("Total Amount");


                    no.Text = sid;
                    name.Text = sname;

                    date.Text = sdate;
                    pid.Text = spid;
                    dateadmission.Text = sdateadmission;
                    sex.Text = sgender;
                    age.Text = sage;
                    datedischarge.Text = sdatedischarge;
                    roomcharges.Text = sroomfee;
                    pathofee.Text = spathofee;
                    docfee.Text = sdocfee;
                    miscefee.Text = smiscefee;
                    totalfee.Text = stotal;





                }

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "message", MessageBoxButtons.OK);
            }
        }

        private void update_Click(object sender, EventArgs e)
        {
            if (c == 0)
            {

                string mysql = "datasource=localhost;port=3306;username=root;password=@password";
                MySqlConnection myconn = new MySqlConnection(mysql);
                string q = "UPDATE `hospmg`.`bill_details` SET `Bill_no`= '" + this.no.Text + "', `Name`= '" + this.name.Text + "', `Date`= '" + this.date.Text + "', `Patient Id`= '" + this.pid.Text + "', `Age`= '" + this.age.Text + "',`Gender`='" + this.sex.Text + "',`Date of Admission`='" + this.dateadmission.Text + "',`Date of Discharge`='"+this.datedischarge.Text+ "',`Room Charges`='"+this.roomcharges.Text+ "',`Pathology fees`='"+this.pathofee.Text+ "',`Doctor Fees`='"+this.docfee.Text+ "',`Miscellaneous`='"+this.miscefee.Text+ "',`Total Amount`='"+this.totalfee.Text+"'WHERE `Bill_no`= '" + this.no.Text + "';";

                MySqlCommand SelectCommand = new MySqlCommand(q, myconn);
                MySqlDataReader myreader;
                try
                {


                    myconn.Open();
                    myreader = SelectCommand.ExecuteReader();
                    MessageBox.Show("bill details updated", "message", MessageBoxButtons.OK, MessageBoxIcon.Information);


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
                string q = "DELETE FROM `hospmg`.`bill_details` WHERE `Bill_no`= '" + this.no.Text + "';";

                MySqlCommand SelectCommand = new MySqlCommand(q, myconn);
                MySqlDataReader myreader;
                try
                {


                    myconn.Open();
                    myreader = SelectCommand.ExecuteReader();
                    string q2 = "selected bill for=" + this.name.Text + " is successfully deleted";
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

        private void total_Click(object sender, EventArgs e)
        {
            findtotal();
        }

        private void miscefee_TextChanged(object sender, EventArgs e)
        {
            
           
        }

        private void docfee_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void pathofee_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void roomcharges_TextChanged(object sender, EventArgs e)
        {

           

        }

        private void totalfee_TextChanged(object sender, EventArgs e)
        {
            findtotal();
        }

        private void ok_Click(object sender, EventArgs e)
        {
            
           

          
        }

        private void label12_Click(object sender, EventArgs e)
        {
           
        }
    }
}
