
namespace S_CupCoffee
{
    partial class ProcessesForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.listView1 = new System.Windows.Forms.ListView();
            this.productId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.productName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ProductPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnPayToCash = new System.Windows.Forms.Button();
            this.btnAddOrder = new System.Windows.Forms.Button();
            this.btnRemoveOrder = new System.Windows.Forms.Button();
            this.btnPayToKredit = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnUseSale = new System.Windows.Forms.Button();
            this.lblPay = new System.Windows.Forms.Label();
            this.lblPayPrice = new System.Windows.Forms.Label();
            this.rdbtnPersonelSale = new System.Windows.Forms.RadioButton();
            this.rdbtnNoSale = new System.Windows.Forms.RadioButton();
            this.rdbtnStudentSale = new System.Windows.Forms.RadioButton();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnCloseTable = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.listView2 = new System.Windows.Forms.ListView();
            this.procartId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.procartName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.procartPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.productId,
            this.productName,
            this.ProductPrice});
            this.listView1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.FullRowSelect = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 83);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(381, 652);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // productId
            // 
            this.productId.Text = "ID";
            this.productId.Width = 40;
            // 
            // productName
            // 
            this.productName.Text = "Ürün Adı";
            this.productName.Width = 165;
            // 
            // ProductPrice
            // 
            this.ProductPrice.Text = "Fiyat";
            this.ProductPrice.Width = 55;
            // 
            // btnPayToCash
            // 
            this.btnPayToCash.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPayToCash.Location = new System.Drawing.Point(1138, 543);
            this.btnPayToCash.Name = "btnPayToCash";
            this.btnPayToCash.Size = new System.Drawing.Size(144, 84);
            this.btnPayToCash.TabIndex = 1;
            this.btnPayToCash.Text = "NAKİT";
            this.btnPayToCash.UseVisualStyleBackColor = true;
            this.btnPayToCash.Click += new System.EventHandler(this.btnPayToCash_Click);
            // 
            // btnAddOrder
            // 
            this.btnAddOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddOrder.Location = new System.Drawing.Point(413, 249);
            this.btnAddOrder.Name = "btnAddOrder";
            this.btnAddOrder.Size = new System.Drawing.Size(85, 85);
            this.btnAddOrder.TabIndex = 3;
            this.btnAddOrder.Text = ">";
            this.btnAddOrder.UseVisualStyleBackColor = true;
            this.btnAddOrder.Click += new System.EventHandler(this.btnAddOrder_Click);
            // 
            // btnRemoveOrder
            // 
            this.btnRemoveOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveOrder.Location = new System.Drawing.Point(413, 403);
            this.btnRemoveOrder.Name = "btnRemoveOrder";
            this.btnRemoveOrder.Size = new System.Drawing.Size(85, 85);
            this.btnRemoveOrder.TabIndex = 4;
            this.btnRemoveOrder.Text = "<";
            this.btnRemoveOrder.UseVisualStyleBackColor = true;
            this.btnRemoveOrder.Click += new System.EventHandler(this.btnRemoveOrder_Click);
            // 
            // btnPayToKredit
            // 
            this.btnPayToKredit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPayToKredit.Location = new System.Drawing.Point(939, 543);
            this.btnPayToKredit.Name = "btnPayToKredit";
            this.btnPayToKredit.Size = new System.Drawing.Size(144, 84);
            this.btnPayToKredit.TabIndex = 5;
            this.btnPayToKredit.Text = "KREDİ";
            this.btnPayToKredit.UseVisualStyleBackColor = true;
            this.btnPayToKredit.Click += new System.EventHandler(this.btnPayToKredit_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnUseSale);
            this.groupBox1.Controls.Add(this.lblPay);
            this.groupBox1.Controls.Add(this.lblPayPrice);
            this.groupBox1.Controls.Add(this.rdbtnPersonelSale);
            this.groupBox1.Controls.Add(this.rdbtnNoSale);
            this.groupBox1.Controls.Add(this.rdbtnStudentSale);
            this.groupBox1.Controls.Add(this.lblTotalPrice);
            this.groupBox1.Controls.Add(this.lblTotal);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(939, 103);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(343, 406);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ödeme İşlemleri";
            // 
            // btnUseSale
            // 
            this.btnUseSale.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUseSale.Location = new System.Drawing.Point(107, 232);
            this.btnUseSale.Name = "btnUseSale";
            this.btnUseSale.Size = new System.Drawing.Size(115, 50);
            this.btnUseSale.TabIndex = 8;
            this.btnUseSale.Text = "İndirim Uygula";
            this.btnUseSale.UseVisualStyleBackColor = true;
            this.btnUseSale.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblPay
            // 
            this.lblPay.AutoSize = true;
            this.lblPay.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPay.Location = new System.Drawing.Point(6, 321);
            this.lblPay.Name = "lblPay";
            this.lblPay.Size = new System.Drawing.Size(220, 32);
            this.lblPay.TabIndex = 7;
            this.lblPay.Text = "Ödenecek Tutar: ";
            // 
            // lblPayPrice
            // 
            this.lblPayPrice.AutoSize = true;
            this.lblPayPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPayPrice.Location = new System.Drawing.Point(235, 321);
            this.lblPayPrice.Name = "lblPayPrice";
            this.lblPayPrice.Size = new System.Drawing.Size(0, 29);
            this.lblPayPrice.TabIndex = 6;
            this.lblPayPrice.Visible = false;
            // 
            // rdbtnPersonelSale
            // 
            this.rdbtnPersonelSale.AutoSize = true;
            this.rdbtnPersonelSale.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbtnPersonelSale.Location = new System.Drawing.Point(246, 176);
            this.rdbtnPersonelSale.Name = "rdbtnPersonelSale";
            this.rdbtnPersonelSale.Size = new System.Drawing.Size(91, 23);
            this.rdbtnPersonelSale.TabIndex = 4;
            this.rdbtnPersonelSale.TabStop = true;
            this.rdbtnPersonelSale.Text = "Personel";
            this.rdbtnPersonelSale.UseVisualStyleBackColor = true;
            // 
            // rdbtnNoSale
            // 
            this.rdbtnNoSale.AutoSize = true;
            this.rdbtnNoSale.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbtnNoSale.Location = new System.Drawing.Point(6, 176);
            this.rdbtnNoSale.Name = "rdbtnNoSale";
            this.rdbtnNoSale.Size = new System.Drawing.Size(99, 23);
            this.rdbtnNoSale.TabIndex = 3;
            this.rdbtnNoSale.TabStop = true;
            this.rdbtnNoSale.Text = "İndirimsiz";
            this.rdbtnNoSale.UseVisualStyleBackColor = true;
            // 
            // rdbtnStudentSale
            // 
            this.rdbtnStudentSale.AutoSize = true;
            this.rdbtnStudentSale.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbtnStudentSale.Location = new System.Drawing.Point(107, 176);
            this.rdbtnStudentSale.Name = "rdbtnStudentSale";
            this.rdbtnStudentSale.Size = new System.Drawing.Size(144, 23);
            this.rdbtnStudentSale.TabIndex = 2;
            this.rdbtnStudentSale.TabStop = true;
            this.rdbtnStudentSale.Text = "Öğrenci İndirimi";
            this.rdbtnStudentSale.UseVisualStyleBackColor = true;
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPrice.Location = new System.Drawing.Point(196, 59);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(0, 29);
            this.lblTotalPrice.TabIndex = 1;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(6, 59);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(192, 32);
            this.lblTotal.TabIndex = 0;
            this.lblTotal.Text = "Toplam Tutar: ";
            // 
            // btnCloseTable
            // 
            this.btnCloseTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseTable.Location = new System.Drawing.Point(1138, 651);
            this.btnCloseTable.Name = "btnCloseTable";
            this.btnCloseTable.Size = new System.Drawing.Size(144, 84);
            this.btnCloseTable.TabIndex = 7;
            this.btnCloseTable.Text = "KAPAT";
            this.btnCloseTable.UseVisualStyleBackColor = true;
            this.btnCloseTable.Click += new System.EventHandler(this.btnCloseTable_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(867, 249);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 44);
            this.label2.TabIndex = 9;
            this.label2.Text = "=>";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // listView2
            // 
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.procartId,
            this.procartName,
            this.procartPrice});
            this.listView2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView2.FullRowSelect = true;
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(523, 83);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(338, 652);
            this.listView2.TabIndex = 10;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            // 
            // procartId
            // 
            this.procartId.Text = "ID";
            this.procartId.Width = 40;
            // 
            // procartName
            // 
            this.procartName.Text = "Ürün Adı";
            this.procartName.Width = 160;
            // 
            // procartPrice
            // 
            this.procartPrice.Text = "Fiyat";
            this.procartPrice.Width = 65;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Kahveler",
            "Frozen",
            "Frappe",
            "Sütlü İçecekler",
            "Yiyecekler",
            "Pastalar",
            "İçecekler"});
            this.comboBox1.Location = new System.Drawing.Point(154, 13);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(193, 24);
            this.comboBox1.TabIndex = 11;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(1080, 13);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(15, 20);
            this.lblDate.TabIndex = 12;
            this.lblDate.Text = "-";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 21);
            this.label1.TabIndex = 13;
            this.label1.Text = "Kategoriler:";
            // 
            // ProcessesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1294, 736);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCloseTable);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnPayToKredit);
            this.Controls.Add(this.btnRemoveOrder);
            this.Controls.Add(this.btnAddOrder);
            this.Controls.Add(this.btnPayToCash);
            this.Controls.Add(this.listView1);
            this.ForeColor = System.Drawing.Color.Orange;
            this.Name = "ProcessesForm";
            this.Text = "ProcessesForm";
            this.Load += new System.EventHandler(this.ProcessesForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button btnPayToCash;
        private System.Windows.Forms.Button btnAddOrder;
        private System.Windows.Forms.Button btnRemoveOrder;
        private System.Windows.Forms.Button btnPayToKredit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblPayPrice;
        private System.Windows.Forms.RadioButton rdbtnPersonelSale;
        private System.Windows.Forms.RadioButton rdbtnNoSale;
        private System.Windows.Forms.RadioButton rdbtnStudentSale;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblPay;
        private System.Windows.Forms.Button btnUseSale;
        private System.Windows.Forms.Button btnCloseTable;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ColumnHeader procartId;
        private System.Windows.Forms.ColumnHeader procartName;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ColumnHeader productId;
        private System.Windows.Forms.ColumnHeader productName;
        private System.Windows.Forms.ColumnHeader ProductPrice;
        private System.Windows.Forms.ColumnHeader procartPrice;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
    }
}