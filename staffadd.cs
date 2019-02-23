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
    public partial class staffadd : Form
    {
        public staffadd()
        {
            InitializeComponent();
            refreshdb();
        }
        void refreshdb()
        {
            string mysql = "datasource=localhost;port=3306;username=root;password=@password1";
            MySqlConnection myconn = new MySqlConnection(mysql);

            MySqlCommand cmdDataBase = new MySqlCommand("select * from hospmg.staff_list;", myconn);

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

        private void button2_Click(object sender, EventArgs e)
        {


            string mysql = "datasource=localhost;port=3306;username=root;password=@password";
            MySqlConnection myconn = new MySqlConnection(mysql);
            string q = "insert into hospmg.staff_list values ('" + this.id.Text + "','" + this.name.Text + "','" + this.age.Text + "','" + this.sex.Text + "','" + this.address.Text + "','" + this.contact.Text + "','" + this.reports.Text + "','"+this.email.Text+"');";

            MySqlCommand SelectCommand = new MySqlCommand(q, myconn);
            MySqlDataReader myreader;
            try
            {


                myconn.Open();
                myreader = SelectCommand.ExecuteReader();
                MessageBox.Show("new staff added");


                while (myreader.Read())
                {


                }
                refreshdb();

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "message", MessageBoxButtons.OK);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            staffmenu sm = new staffmenu();
            sm.ShowDialog();
            this.Close();
        }

        private void email_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
