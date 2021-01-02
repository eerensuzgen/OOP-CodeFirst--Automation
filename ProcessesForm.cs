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
using System.Data.Entity;

namespace S_CupCoffee
{
    
    public partial class ProcessesForm : Form
    {
        public ProcessesForm()
        {
            InitializeComponent();

            
        }
        private void ProcessesForm_Load(object sender, EventArgs e)
        {
            
            showProducts();
            ShowCarts();
            writeTotalPrice();
            timer1.Enabled = true;
        }
        public static double a = 0;
        MainForm mainFrm = new MainForm();       
        
        Entity.Context dbcontext = new Entity.Context();

        SqlConnection conn = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=dbSCupCoffee;Integrated Security=True;Pooling=False");
        private void showProducts()
        {
            listView1.Items.Clear();
            conn.Open();
            SqlCommand cmd = new SqlCommand("select *from Products", conn);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                ListViewItem add = new ListViewItem();
                add.Text = dr["productID"].ToString();
                add.SubItems.Add(dr["productName"].ToString());
                add.SubItems.Add((dr["unitPrice"].ToString()));//+ " ₺"


                listView1.Items.Add(add);
            }
            conn.Close();
        }

        private void ShowCarts()
        {
            listView2.Items.Clear();
            conn.Open();
            string sorgu = "Select Carts.cartID,Products.productName,Products.unitPrice,Tables.tableID From Carts INNER JOIN Products ON Carts.productID = Products.productID INNER JOIN Tables ON Tables.tableID = Carts.tableID";
            SqlCommand cmd = new SqlCommand(sorgu, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                if (dr["tableID"].ToString() == MainForm.btnWasClicked.ToString())
                {
                    ListViewItem add = new ListViewItem();
                    add.Text = dr["cartID"].ToString();
                    add.SubItems.Add(dr["productName"].ToString());
                    add.SubItems.Add(dr["unitPrice"].ToString());


                    listView2.Items.Add(add);
                }
            }
            conn.Close();
        }

        public void clearCartList()
        {
            var order = dbcontext.Carts.Where(x => x.tableID == MainForm.btnWasClicked).ToList();
            dbcontext.Carts.RemoveRange(order);
            dbcontext.SaveChanges();
            lblTotalPrice.Text = "0";
            lblPayPrice.Text = "0";
            ShowCarts();
        }
        public void writeTotalPrice()
        {
            var order = dbcontext.Carts.Where(x => x.tableID == MainForm.btnWasClicked).ToList();
            if (order.Count == 0) lblTotalPrice.Text = "0";
            else
            {
                foreach (var item in order)
                {
                    int c = item.productID;
                    var b = dbcontext.Products.FirstOrDefault(y => y.productID == c);
                    a += b.unitPrice;
                    lblTotalPrice.Text = a.ToString();
                }
            }            
            a = 0;

        }
        

        private void btnAddOrder_Click(object sender, EventArgs e)
        {
            try
            {
                var cart = new Entity.Cart
                {
                    productID = Convert.ToInt32(listView1.SelectedItems[0].SubItems[0].Text),
                    tableID = MainForm.btnWasClicked
                };
                dbcontext.Carts.Add(cart);
                dbcontext.SaveChanges();
                writeTotalPrice();
                ShowCarts();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Hata: " + ex);
            }
        }
        
        
        private void btnRemoveOrder_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(listView2.SelectedItems[0].SubItems[0].Text);
                var cart = dbcontext.Carts.FirstOrDefault(x => x.cartID == id);
                dbcontext.Carts.Remove(cart);
                dbcontext.SaveChanges();
                ShowCarts();
                writeTotalPrice();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Hata: " + ex);
            }          
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT Categories.categoryName,Products.productID,Products.productName,Products.unitPrice From Categories INNER JOIN Products ON Categories.categoryID = Products.categoryID", conn);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                if (comboBox1.SelectedItem.ToString() == dr["categoryName"].ToString())
                {
                    ListViewItem add = new ListViewItem();
                    add.Text = dr["productID"].ToString();
                    add.SubItems.Add(dr["productName"].ToString());
                    add.SubItems.Add(dr["unitPrice"].ToString());


                    listView1.Items.Add(add);
                }
            }
            conn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                lblPayPrice.Visible = true;
                NoSale noSale = new NoSale();
                StudentSale studentSale = new StudentSale();
                PersonelSale personelSale = new PersonelSale();
                if (rdbtnNoSale.Checked) { lblPayPrice.Text = noSale.SalePrice(Convert.ToDecimal(lblTotalPrice.Text)).ToString(); }
                else if (rdbtnStudentSale.Checked) { lblPayPrice.Text = studentSale.SalePrice(Convert.ToDecimal(lblTotalPrice.Text)).ToString(); }
                else if (rdbtnPersonelSale.Checked) { lblPayPrice.Text = personelSale.SalePrice(Convert.ToDecimal(lblTotalPrice.Text)).ToString(); }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Hata: " + ex);
            }
        }
        private void btnPayToKredit_Click(object sender, EventArgs e)
        {
            CreditCard creditCard = new CreditCard();
            MessageBox.Show(creditCard.payPrice());
            clearCartList();
            ShowCarts();
        }

        private void btnPayToCash_Click(object sender, EventArgs e)
        {
            Cash cash = new Cash();
            MessageBox.Show(cash.payPrice());
            clearCartList();
            ShowCarts();
        }

        private void btnCloseTable_Click(object sender, EventArgs e)
        {

            DialogResult choose = MessageBox.Show("Masayı kapatmak istiyor musunuz","Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if(choose == DialogResult.Yes)
            {
                clearCartList();
                mainFrm.masaBosalt(MainForm.btnWasClicked - 1);
                this.Close();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToLongTimeString();
        }
    }
}
