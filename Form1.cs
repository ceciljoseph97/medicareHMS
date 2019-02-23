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
 

namespace medicare_hms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            passcode_txt.PasswordChar = '*';
            passcode_txt.MaxLength = 10;
            username_txt.MaxLength = 20;


            timer1.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string mysql = "datasource=localhost;port=3306;username=root;password=@password";
                MySqlConnection myconn = new MySqlConnection(mysql);
                string q = "select * from hospmg.admin_list where name='" + this.username_txt.Text + "' and password='" + this.passcode_txt.Text + "' ;";
                MySqlCommand SelectCommand = new MySqlCommand(q, myconn);
                MySqlDataReader myreader;
                myconn.Open();
                myreader = SelectCommand.ExecuteReader();
                int count = 0;
                while (myreader.Read())
                {
                    count = count + 1;

                }
                if(count==1)
                {
                    
                    this.Hide();
                    Form2 f2 = new Form2();
                    f2.ShowDialog();
                    this.Close();
                }
                if (count > 1)
                {
                    MessageBox.Show("Duplicate Username and password ..... Access denied", "message", MessageBoxButtons.OK);


                }
                else
                    MessageBox.Show("Incorrect username or password .... please try again later", "message", MessageBoxButtons.OK);
            
                myconn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"message",MessageBoxButtons.OK);
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            this.timelbl.Text = dt.ToString();

        }

        private void timelbl_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
