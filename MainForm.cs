using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using System.IO;

namespace S_CupCoffee
{
    public partial class MainForm : Form
    {
        Entity.Context dbcontext = new Entity.Context();
        PersonelList personel;
        public MainForm()
        {
            InitializeComponent();
            personel = new PersonelList();
            addForTest();
            updateList();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
            
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            dataGridView1.DataSource = dbcontext.Products.ToList();
            ReadNotes();
        }

        public void ClearTextBox()
        {
            foreach (Control item in Controls)
            {
                if (item is TextBox) item.Text = "";
            }
        }

        private void addForTest()
        {
            personel.addPersonel(new Personel("Enes Eren", "Süzgen", 21, 2, 3000M));
            personel.addPersonel(new Manager("Enes Eren", "Süzgen", 21, 2, 3000M, 1500M));
            personel.addPersonel(new Worker("Enes Eren", "Süzgen", 21, 2, 3000M, 500));

        }
        private void updateList()
        {
            listBox1.Items.Clear();
            foreach (Personel p in personel.personelInfos)
            {
                listBox1.Items.Add(p.ToString());
            }
        }

        public void ReadNotes()
        {
            string filePath = @"C:\Users\Eren\source\repos\S-CupCoffee\Notlar.txt";
            FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read);
            using (StreamReader sr = new StreamReader(fs))
            {
                while (true)
                {
                    string row = sr.ReadLine();
                    richTextBox1.Text += row + "\n";
                    if (row == null) break;
                }
                sr.Close();
            }
            fs.Close();
        }

        public void WriteNotes()
        {
            string filePath = @"C:\Users\Eren\source\repos\S-CupCoffee\Notlar.txt";
            File.WriteAllText(filePath, string.Empty);
            FileStream fs = new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.Write);
            using (StreamWriter sw = new StreamWriter(fs))
            {
                sw.WriteLine(richTextBox1.Text);
                sw.Close();
            }
            fs.Close();
            MessageBox.Show("Kayıt Yapıldı");

        }

        private void dataGridView1_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            txtProductName.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtProductPrice.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtProductName.Text == "" && txtProductPrice.Text =="" && comboBox1.Text == "")
                {
                    MessageBox.Show("ALANLARI DOLDURUNUZ");
                }
                else
                {
                    var product = new Entity.Product();
                    product.productName = txtProductName.Text;
                    product.unitPrice = Convert.ToDouble(txtProductPrice.Text);
                    product.categoryID = comboBox1.SelectedIndex + 1;
                    dbcontext.Products.Add(product);
                    dbcontext.SaveChanges();
                    MessageBox.Show("Ürün kayıt edildi.", "Kayıt", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearTextBox();
                    dataGridView1.DataSource = dbcontext.Products.ToList();
                }
            }
            catch (Exception)
            { }
            
        }       

        private void btnUpdateProduct_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                var product = dbcontext.Products.FirstOrDefault(x => x.productID == id);
                product.productName = txtProductName.Text;
                product.unitPrice = Convert.ToDouble(txtProductPrice.Text);
                dbcontext.SaveChanges();
                MessageBox.Show("Ürün güncellendi.", "Güncelleme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearTextBox();
                dataGridView1.DataSource = dbcontext.Products.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex);
                
            }
            
        }

        private void btnRemoveProduct_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                var product = dbcontext.Products.FirstOrDefault(x => x.productID == id);
                dbcontext.Products.Remove(product);
                dbcontext.SaveChanges();
                MessageBox.Show("Ürün silindi.", "Silme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridView1.DataSource = dbcontext.Products.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex);
                
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            var search = from x in dbcontext.Products select x;
            if(txtSearch.Text != null)
            {
                dataGridView1.DataSource = search.Where(x => x.productName.Contains(txtSearch.Text)).ToList();
            }
        }

        public static int btnWasClicked;
        public static string[] clock = new string[12];
        

        private void btn1_Click(object sender, EventArgs e)
        {
            ProcessesForm processes = new ProcessesForm();
            DateTime stLogin = DateTime.Now;
            btnWasClicked = 1;
            if (clock[0] == null || clock[0] == "bos")// saat var ise sıfırlamasın diye
            {
                clock[0] = stLogin.ToString("H:mm:ss");
            }
            processes.ShowDialog();
        }
        private void btn2_Click(object sender, EventArgs e)
        {
            ProcessesForm processes = new ProcessesForm();
            DateTime stLogin = DateTime.Now;
            btnWasClicked = 2;
            if (clock[1] == null || clock[1] == "bos")
            {
                clock[1] = stLogin.ToString("H:mm:ss");
            }
            processes.ShowDialog();
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            ProcessesForm processes = new ProcessesForm();
            DateTime stLogin = DateTime.Now;
            btnWasClicked = 3;
            if (clock[2] == null || clock[2] == "bos")
            {
                clock[2] = stLogin.ToString("H:mm:ss");
            }
            processes.ShowDialog();
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            ProcessesForm processes = new ProcessesForm();
            DateTime stLogin = DateTime.Now;
            btnWasClicked = 4;
            if (clock[3] == null || clock[3] == "bos")
            {
                clock[3] = stLogin.ToString("H:mm:ss");
            }
            processes.ShowDialog();
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            ProcessesForm processes = new ProcessesForm();
            DateTime stLogin = DateTime.Now;
            btnWasClicked = 5;
            if (clock[4] == null || clock[4] == "bos")
            {
                clock[4] = stLogin.ToString("H:mm:ss");
            }
            processes.ShowDialog();
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            ProcessesForm processes = new ProcessesForm();
            DateTime stLogin = DateTime.Now;
            btnWasClicked = 6;
            if (clock[5] == null || clock[5] == "bos")
            {
                clock[5] = stLogin.ToString("H:mm:ss");
            }
            processes.ShowDialog();
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            ProcessesForm processes = new ProcessesForm();
            DateTime stLogin = DateTime.Now;
            btnWasClicked = 7;
            if (clock[6] == null || clock[6] == "bos")
            {
                clock[6] = stLogin.ToString("H:mm:ss");
            }
            processes.ShowDialog();
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            ProcessesForm processes = new ProcessesForm();
            DateTime stLogin = DateTime.Now;
            btnWasClicked = 8;
            if (clock[7] == null || clock[7] == "bos")
            {
                clock[7] = stLogin.ToString("H:mm:ss");
            }
            processes.ShowDialog();
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            ProcessesForm processes = new ProcessesForm();
            DateTime stLogin = DateTime.Now;
            btnWasClicked = 9;
            if (clock[8] == null || clock[8] == "bos")
            {
                clock[8] = stLogin.ToString("H:mm:ss");
            }
            processes.ShowDialog();
        }

        private void btn10_Click(object sender, EventArgs e)
        {
            ProcessesForm processes = new ProcessesForm();
            DateTime stLogin = DateTime.Now;
            btnWasClicked = 10;
            if (clock[9] == null || clock[9] == "bos")
            {
                clock[9] = stLogin.ToString("H:mm:ss");
            }
            processes.ShowDialog();
        }

        private void btn11_Click(object sender, EventArgs e)
        {
            ProcessesForm processes = new ProcessesForm();
            DateTime stLogin = DateTime.Now;
            btnWasClicked = 11;
            if (clock[10] == null || clock[10] == "bos")
            {
                clock[10] = stLogin.ToString("H:mm:ss");
            }
            processes.ShowDialog();
        }

        private void btn12_Click(object sender, EventArgs e)
        {
            ProcessesForm processes = new ProcessesForm();
            DateTime stLogin = DateTime.Now;
            btnWasClicked = 12;
            if (clock[11] == null || clock[11] == "bos")
            {
                clock[11] = stLogin.ToString("H:mm:ss");
            }
            processes.ShowDialog();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToString();
            DateTime dtS = DateTime.Now;
            string simdi = dtS.ToString("H:mm:ss");
            TimeSpan[] sub = new TimeSpan[12];
            try
            {

                for (int i = 0; i < 12; i++) //masaları kontrol etmek için
                {
                    if (clock[i] == null || clock[i] == "bos") // tekrar tekrar kontrol için
                    {

                        clock[i] = "bos";

                    }
                    else
                    {
                        sub[i] = DateTime.Parse(simdi).Subtract(DateTime.Parse(clock[i]));//farkı burda alır
                    }
                }

            }
            catch (Exception)
            { }
            if (clock[0].ToString() != "bos") //her masa için burayı tanımla
            {
                lblMasa1.Text = sub[0].ToString();
            }

            else
            {
                lblMasa1.Text = "Müsait";
            }

            if (clock[1].ToString() != "bos")
            {

                lblMasa2.Text = sub[1].ToString();
            }
            else
            {
                lblMasa2.Text = "Müsait";
            }
            if (clock[2].ToString() != "bos")
            {

                lblMasa3.Text = sub[2].ToString();
            }
            else
            {
                lblMasa3.Text = "Müsait";
            }
            if (clock[3].ToString() != "bos")
            {

                lblMasa4.Text = sub[3].ToString();
            }
            else
            {
                lblMasa4.Text = "Müsait";
            }
            if (clock[4].ToString() != "bos")
            {

                lblMasa5.Text = sub[4].ToString();
            }
            else
            {
                lblMasa5.Text = "Müsait";
            }
            if (clock[5].ToString() != "bos")
            {

                lblMasa6.Text = sub[5].ToString();
            }
            else
            {
                lblMasa6.Text = "Müsait";
            }
            if (clock[6].ToString() != "bos")
            {

                lblMasa7.Text = sub[6].ToString();
            }
            else
            {
                lblMasa7.Text = "Müsait";
            }
            if (clock[7].ToString() != "bos")
            {

                lblMasa8.Text = sub[7].ToString();
            }
            else
            {
                lblMasa8.Text = "Müsait";
            }
            if (clock[8].ToString() != "bos")
            {

                lblMasa9.Text = sub[8].ToString();
            }
            else
            {
                lblMasa9.Text = "Müsait";
            }
            if (clock[9].ToString() != "bos")
            {

                lblMasa10.Text = sub[9].ToString();
            }
            else
            {
                lblMasa10.Text = "Müsait";
            }
            if (clock[10].ToString() != "bos")
            {

                lblMasa11.Text = sub[10].ToString();             
            }
            else
            {
                lblMasa11.Text = "Müsait";
            }
            if (clock[11].ToString() != "bos")
            {

                lblMasa12.Text = sub[11].ToString();
            }
            else
            {
                lblMasa12.Text = "Müsait";
            }
        }
        public string masaBosalt(int masaId)
        {
            //masanın içerisindeki saati sıfırlama için
            return clock[masaId] = null;
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            Age age = new Age(int.Parse(txtPersonelAge.Text));
            try
            {
                if (int.Parse(txtPersonelAge.Text) < 18)
                {
                    age.showAge();
                }
                else
                {
                    if (rdBtnManager.Checked)
                    {
                        Manager p = new Manager(txtPersonelName.Text, txtPersonelSurname.Text, int.Parse(txtPersonelAge.Text), int.Parse(txtWorkTime.Text), Convert.ToDecimal(txtSalary.Text), Convert.ToDecimal(txtBonus.Text));
                        personel.addPersonel(p);
                        updateList();
                    }
                    else if (rdBtnWorker.Checked)
                    {
                        Worker p = new Worker(txtPersonelName.Text, txtPersonelSurname.Text, int.Parse(txtPersonelAge.Text), int.Parse(txtWorkTime.Text), Convert.ToDecimal(txtSalary.Text), Convert.ToDecimal(txtBonus.Text));
                        personel.addPersonel(p);
                        updateList();
                    }
                }
            }
            catch (ExceptionHandling ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }           
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Age age = new Age(int.Parse(txtPersonelAge.Text));
            try
            {
                if (int.Parse(txtPersonelAge.Text) < 18)
                {
                    age.showAge();
                }
                else
                {
                    if (rdBtnManager.Checked)
                    {
                        Manager p = new Manager(txtPersonelName.Text, txtPersonelSurname.Text, int.Parse(txtPersonelAge.Text), int.Parse(txtWorkTime.Text), Convert.ToDecimal(txtSalary.Text), Convert.ToDecimal(txtBonus.Text));
                        personel.addPersonel(p);
                        updateList();
                    }
                    else if (rdBtnWorker.Checked)
                    {
                        Worker p = new Worker(txtPersonelName.Text, txtPersonelSurname.Text, int.Parse(txtPersonelAge.Text), int.Parse(txtWorkTime.Text), Convert.ToDecimal(txtSalary.Text), Convert.ToDecimal(txtBonus.Text));
                        personel.addPersonel(p);
                        updateList();
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Hata: " + ex.Message);
            }           
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int pos = listBox1.SelectedIndex;
            personel.removePersonel(pos);
            updateList();
        }
        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            Personel p = personel.getKayit(listBox1.SelectedIndex);
            txtPersonelName.Text = p.Name;
            txtPersonelSurname.Text = p.Surname;
            txtPersonelAge.Text = p.Age.ToString();
            txtWorkTime.Text = p.workTime.ToString();
            txtSalary.Text = p.salary.ToString();
        }

        private void btnAddNote_Click(object sender, EventArgs e)
        {
            WriteNotes();
        }
    }
}
