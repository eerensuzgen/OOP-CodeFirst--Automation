using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using S_CupCoffee.Entity;
using System.Data.SqlClient;

namespace S_CupCoffee
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        public void login()
        {
            try
            {
                SqlConnection scon = new SqlConnection("Server=localhost\\SQLEXPRESS;Database=dbSCupCoffee;Trusted_Connection=True");
                scon.Open();
                string scom = "SELECT * From Admins where(userName=@username and password=@pass)";
                SqlCommand cmd = new SqlCommand(scom, scon);
                cmd.Parameters.AddWithValue("@username", txtUserName.Text);
                cmd.Parameters.AddWithValue("@pass", txtPassword.Text);
                SqlDataReader sdr = cmd.ExecuteReader();
                if (sdr.Read())
                {
                    MainForm mainFrm = new MainForm();
                    mainFrm.ShowDialog();
                }
                else MessageBox.Show("Giriş Bilgilerinizi Kontrol Ediniz");
                scon.Close();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Giriş Bilgilerinizi Kontrol Ediniz " + ex);
            }
        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            login();
        }
    }
}
