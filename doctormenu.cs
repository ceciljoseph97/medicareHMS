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
    public partial class doctormenu : Form
    {
        public doctormenu()
        {
            InitializeComponent();
            refreshdb();
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

        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f2 = new Form2();
            f2.ShowDialog();
            this.Close();
        }

        private void proceed_Click(object sender, EventArgs e)
        {
            this.Hide();
            doctoradddeleupdate dadu = new doctoradddeleupdate();
            dadu.ShowDialog();
            this.Close();
        }
    }
}
