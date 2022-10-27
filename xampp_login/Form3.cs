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
    public partial class Form3 : Form
    {
        string randomCode;
        public static string to;
        SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-L73JNH1\\HAMZAONAT;initial catalog=forgotPassword;integrated security=TRUE");

        public Form3()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
             
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'dataSet1.forgotPassword' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.forgotPasswordTableAdapter.Fill(this.dataSet1.forgotPassword);



        }
        private void button1_Click(object sender, EventArgs e)
        {
            string ka = textBox2.Text;
            string email = textBox3.Text;
            baglan.Open();
            SqlCommand komut = new SqlCommand("select * from forgotPassword", baglan);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                if(ka==oku["username"].ToString() && email == oku["email"].ToString())
                {
                    SmtpClient smtpserver = new SmtpClient();
                    MailMessage mail = new MailMessage();
                    String mailadresim = ("hamzaonat88@outlook.com");
                    String sifre = ("Asdfghjkl838");
                    String smtpsrvr = "smtp-mail.outlook.com";
                    String kime = (oku["email"].ToString());
                    String konu = ("Sifre Hatirlatma");
                    String yaz = ("Sifreniz: " + oku["password"].ToString());
                    smtpserver.Credentials = new NetworkCredential(mailadresim, sifre);
                    smtpserver.Port = 587;
                    smtpserver.Host = smtpsrvr;
                    smtpserver.EnableSsl = true;
                    mail.From = new MailAddress(mailadresim);
                    mail.To.Add(kime);
                    mail.Subject = konu;
                    mail.Body = yaz;
                    smtpserver.Send(mail);

                    MessageBox.Show("Sifreniz sistemde kayitli olan e-posta adresinize gonderildi.");
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Kullanici adi ile e-posta eslesmiyor!");
                }
               
            }baglan.Close();

        }
    }
}
