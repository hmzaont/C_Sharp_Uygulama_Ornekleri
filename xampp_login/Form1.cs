using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Net;
using System.Net.Mail;
 

namespace xampp_login
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("server=DESKTOP-L73JNH1\\HAMZAONAT;initial catalog=forgotPassword;integrated security=TRUE");

        


        private void button1_Click(object sender, EventArgs e)
        {
            string ka = textBox1.Text;
            string sifre = textBox2.Text;
            conn.Open();
            SqlCommand cmd = new SqlCommand("select*from forgotPassword", conn);
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                if (ka == dr["username"].ToString() && sifre == dr["password"].ToString()) {
                MessageBox.Show("Giris Basarili");
                Form2 frm = new Form2();
                frm.Show();
                this.Hide();
                }
               else
                {
                    MessageBox.Show("Tekrar deneyin!");
            }     
            }
            conn.Close();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form3 ffp = new Form3();
            ffp.ShowDialog();
            this.Hide();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                Properties.Settings.Default.UserName = textBox1.Text;
                Properties.Settings.Default.Password = textBox2.Text;
                Properties.Settings.Default.Save();
            }
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if(Properties.Settings.Default.UserName != string.Empty)
            {
                textBox1.Text = Properties.Settings.Default.UserName;
                textBox2.Text = Properties.Settings.Default.Password; 
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}


