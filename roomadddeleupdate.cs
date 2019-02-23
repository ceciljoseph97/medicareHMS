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
    public partial class roomadddeleupdate : Form
        
    {
        private int c = 1;
        public roomadddeleupdate()
             
        {
            InitializeComponent();
            refreshdb();
            fillcombo();
            refreshtexts();
        }
        void refreshtexts()
        {
            no.Text = "";
            type.Text = "";

            block.Text = "";
            capacity.Text = "";
            status.Text = "";
            
        }
        void fillcombo()
        {

            string mysql = "datasource=localhost;port=3306;username=root;password=@password";
            MySqlConnection myconn = new MySqlConnection(mysql);
            string q = "select * from hospmg.room_details";

            MySqlCommand SelectCommand = new MySqlCommand(q, myconn);
            MySqlDataReader myreader;
            try
            {


                myconn.Open();
                myreader = SelectCommand.ExecuteReader();

                while (myreader.Read())
                {
                    string sid = myreader.GetInt32("no").ToString();
                    comboBox1.Items.Add(sid);

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

            MySqlCommand cmdDataBase = new MySqlCommand("select * from hospmg.room_details;", myconn);

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

        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
            roomavailability ra = new roomavailability();
            ra.ShowDialog();
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string a = comboBox1.Text;


            string mysql = "datasource=localhost;port=3306;username=root;password=@password";
            MySqlConnection myconn = new MySqlConnection(mysql);

            string q = "select * from hospmg.room_details where no='" + comboBox1.Text + "';";

            MySqlCommand SelectCommand = new MySqlCommand(q, myconn);
            MySqlDataReader myreader;
            try
            {



                myconn.Open();
                myreader = SelectCommand.ExecuteReader();

                while (myreader.Read())
                {
                    string sid = myreader.GetInt32("no").ToString();
                    string stype = myreader.GetString("rtype");
                    string sreports = myreader.GetString("reports");
                    string scapacity = myreader.GetInt32("capacity").ToString();
                   

                    string sblock = myreader.GetString("block");
                    
                    no.Text = sid;
                    type.Text = stype;

                    status.Text = sreports;
                    capacity.Text = scapacity;
                    block.Text = sblock;
                    


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
                string q = "UPDATE `hospmg`.`room_details` SET `no`= '" + this.no.Text + "', `rtype`= '" + this.type.Text + "', `reports`= '" + this.status.Text + "', `capacity`= '" + this.capacity.Text + "', `block`= '" + this.block.Text + "'WHERE `no`= '" + this.no.Text + "';";

                MySqlCommand SelectCommand = new MySqlCommand(q, myconn);
                MySqlDataReader myreader;
                try
                {


                    myconn.Open();
                    myreader = SelectCommand.ExecuteReader();
                    MessageBox.Show("room details updated", "message", MessageBoxButtons.OK, MessageBoxIcon.Information);


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
                string q = "DELETE FROM `hospmg`.`room_details` WHERE `no`= '" + this.no.Text + "';";

                MySqlCommand SelectCommand = new MySqlCommand(q, myconn);
                MySqlDataReader myreader;
                try
                {


                    myconn.Open();
                    myreader = SelectCommand.ExecuteReader();
                    string q2 = "selected room=" + this.no.Text + " is successfully deleted";
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

        private void add_Click(object sender, EventArgs e)
        {


            string mysql = "datasource=localhost;port=3306;username=root;password=@password";
            MySqlConnection myconn = new MySqlConnection(mysql);
            string q = "insert into hospmg.room_details values ('" + this.no.Text + "','" + this.type.Text + "','" + this.status.Text + "','" + this.capacity.Text + "','" + this.block.Text + "');";

            MySqlCommand SelectCommand = new MySqlCommand(q, myconn);
            MySqlDataReader myreader;
            try
            {


                myconn.Open();
                myreader = SelectCommand.ExecuteReader();
                MessageBox.Show("new room added");


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

        private void select_Click(object sender, EventArgs e)
        {
            c = 0;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
