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
            Button b = new Button
            {
                Text = "Giriş",
                Size = new Size(65, 42),
                Location = new Point(165, 250),
                BackColor = Color.Gray,
                ForeColor = Color.Black,
                BackgroundImageLayout = ImageLayout.Tile
            };
            this.Controls.Add(b);
            b.Click += new EventHandler(b_click);

        }
        public void login()
        {
            try
            {
                if(txtUserName.Text == "" && txtPassword.Text == "")
                {
                    MessageBox.Show("Kullanıcı Adı ve Şifre alanları boş olamaz");
                }
                else
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
                        this.Close();                       
                    }
                    else MessageBox.Show("Giriş Bilgilerinizi Kontrol Ediniz");
                    scon.Close();
                }                               
            }
            catch (Exception ex)
            {
                MessageBox.Show("Giriş Bilgilerinizi Kontrol Ediniz " + ex.Message);
            }
        }
        private void b_click(object senders, EventArgs e)
        {
            login();
        }
       
 
    }
}
