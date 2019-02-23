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
    public partial class Form2 : Form
    {
        string a;
        public Form2()
        {
            InitializeComponent();
            webBrowser1.Url = new Uri("https://www.livescience.com/health");
            animate();
        }

        void animate()
        {
            a = label3.Text;
        }

        private void button8_Click(object sender, EventArgs e)
        {
        }
        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.ShowDialog();
            this.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 f3 = new Form3();
            f3.ShowDialog();
            this.Close();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            roomavailability ra = new roomavailability();
            ra.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            staffmenu sm = new staffmenu();
            sm.ShowDialog();
            this.Close();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            doctormenu dm = new doctormenu();
            dm.ShowDialog();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            patientmenu pm = new patientmenu();
            pm.ShowDialog();
            this.Close();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Hide();
            billingmenu bm = new billingmenu();
            bm.ShowDialog();
            this.Close();
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            qplate qp = new qplate();
            qp.ShowDialog();
            this.Close();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.Hide();
            overview ov = new overview();
            ov.ShowDialog();
            this.Close();
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
        






        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Hide();
            search sh = new search();
            sh.ShowDialog();
            this.Close();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            webBrowser1.Url = new Uri("https://www.livescience.com/health");
        }

        private void label3_Click(object sender, EventArgs e)
        {
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (label3.Text != "                                                       St John's Hospital (Karukachal)")
            {
                label3.Text = " " + label3.Text;
                if (label3.ForeColor == Color.White)
                {
                    label3.ForeColor = Color.Blue;
                   
                }
                else if(label3.ForeColor==Color.Blue)
                {
                    label3.ForeColor = Color.Red;
                }
                else
                {
                    label3.ForeColor = Color.White;
                }
            }
            else
            {
                label3.Text = a;
                
            }   
        }
    }
}
