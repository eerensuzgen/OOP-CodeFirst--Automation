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


namespace S_CupCoffee
{
    public partial class MainForm : Form
    {
        Entity.Context dbcontext = new Entity.Context();
        public MainForm()
        {
            InitializeComponent();
        }
        private void btn1_Click(object sender, EventArgs e)
        {
            ProcessesForm processes = new ProcessesForm();
            processes.ShowDialog();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = dbcontext.Products.ToList();
        }
        public void ClearTextBox()
        {
            foreach (Control item in Controls)
            {
                if (item is TextBox) item.Text = "";
            }
        }
        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            var product = new Entity.Product();
            product.productName = txtProductName.Text;
            product.unitPrice = Convert.ToDouble(txtProductPrice.Text);
            dbcontext.Products.Add(product);
            dbcontext.SaveChanges();
            MessageBox.Show("Ürün kayıt edildi.","Kayıt",MessageBoxButtons.OK,MessageBoxIcon.Information);
            ClearTextBox();
            dataGridView1.DataSource = dbcontext.Products.ToList();
        }       

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
            txtProductName.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtProductPrice.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();

        }

        private void btnUpdateProduct_Click(object sender, EventArgs e)
        {
            int id = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            var product = dbcontext.Products.FirstOrDefault(x => x.productID ==  id);
            product.productName = txtProductName.Text;
            product.unitPrice = Convert.ToDouble(txtProductPrice.Text);           
            dbcontext.SaveChanges();
            MessageBox.Show("Ürün güncellendi.", "Güncelleme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ClearTextBox();
            dataGridView1.DataSource = dbcontext.Products.ToList();
        }

        private void btnRemoveProduct_Click(object sender, EventArgs e)
        {
            int id = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            var product = dbcontext.Products.FirstOrDefault(x => x.productID == id);
            dbcontext.Products.Remove(product);
            dbcontext.SaveChanges();
            MessageBox.Show("Ürün silindi.", "Silme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dataGridView1.DataSource = dbcontext.Products.ToList();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            var search = from x in dbcontext.Products select x;
            if(txtSearch.Text != null)
            {
                dataGridView1.DataSource = search.Where(x => x.productName.Contains(txtSearch.Text)).ToList();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
