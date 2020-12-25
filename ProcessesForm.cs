using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace S_CupCoffee
{
    
    public partial class ProcessesForm : Form
    {
        MainForm mainFrm = new MainForm();       
        public ProcessesForm()
        {           
            InitializeComponent();
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            lblPayPrice.Visible = true;
            NoSale noSale = new NoSale();
            StudentSale studentSale = new StudentSale();
            PersonelSale personelSale = new PersonelSale();
            if (rdbtnNoSale.Checked) { lblPayPrice.Text = noSale.SalePrice(Convert.ToDecimal(lblTotalPrice.Text)).ToString(); }
            else if (rdbtnStudentSale.Checked) { lblPayPrice.Text = studentSale.SalePrice(Convert.ToDecimal(lblTotalPrice.Text)).ToString(); }
            else if (rdbtnPersonelSale.Checked) { lblPayPrice.Text = personelSale.SalePrice(Convert.ToDecimal(lblTotalPrice.Text)).ToString(); }
        }
        private void btnPayToKredit_Click(object sender, EventArgs e)
        {
            CreditCard creditCard = new CreditCard();
            MessageBox.Show(creditCard.payPrice());
        }

        private void btnPayToCash_Click(object sender, EventArgs e)
        {
            Cash cash = new Cash();
            MessageBox.Show(cash.payPrice());
        }

        private void btnCloseTable_Click(object sender, EventArgs e)
        {
            DialogResult choose = MessageBox.Show("Masayı kapatmak istiyor musunuz","Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if(choose == DialogResult.Yes)
            {               
                mainFrm.ShowDialog();
            }
        }
        int a = 0;
        
        private void btnAddOrder_Click(object sender, EventArgs e)
        {
            string pp = listView1.SelectedItems[0].SubItems[1].Text;
            string pn = listView1.SelectedItems[0].SubItems[0].Text;
            Cart cart = new Cart(pn, pp);
            cart.addCart(cart);
            foreach (var item in cart.cartList)
            {
                lstOrder.Items.Add(cart.ToString());
            } 
            a = a + Convert.ToInt32(pp); 
            lblTotalPrice.Text = a.ToString();
            Convert.ToInt32(a);         
        }

        private void btnRemoveOrder_Click(object sender, EventArgs e)
        { 
            string pp = listView1.SelectedItems[0].SubItems[1].Text;
            string pn = listView1.SelectedItems[0].SubItems[0].Text;
            Cart cart = new Cart(pn, pp);
            int pos = lstOrder.SelectedIndex;
            MessageBox.Show(cart.cartList[0].ToString());
            MessageBox.Show(Convert.ToInt32(cart.getCart(pos)).ToString()); 
            lblTotalPrice.Text = a.ToString();
            cart.cartList.RemoveAt(pos);
            Convert.ToInt32(a);
          
        }
    }
}
