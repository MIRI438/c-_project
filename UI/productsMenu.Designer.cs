namespace UI
{
    partial class productsMenu
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
            products = new TabControl();
            tabAdd = new TabPage();
            btnAdd = new Button();
            cbxCategory = new ComboBox();
            nudQuantityInStock = new NumericUpDown();
            nudPrice = new NumericUpDown();
            tbxNameProduct = new TextBox();
            lblQuantityInStock = new Label();
            lblCategory = new Label();
            lblPrice = new Label();
            lblNameAproduct = new Label();
            tabUpdate = new TabPage();
            cbxNewCategory = new ComboBox();
            nudNewQuantityInStock = new NumericUpDown();
            nudID = new NumericUpDown();
            nudNewPrice = new NumericUpDown();
            txtNewName = new TextBox();
            lblNewQuantityInStock = new Label();
            lblNewCategory = new Label();
            lblNewPrice = new Label();
            lblNewName = new Label();
            btnUpdate = new Button();
            lblID = new Label();
            tabDelete = new TabPage();
            btnDelete = new Button();
            nudIDtoDelete = new NumericUpDown();
            lblIDtoDelete = new Label();
            tabDesine = new TabPage();
            lblReadNew = new Label();
            nudRead = new NumericUpDown();
            btnReadCustomer = new Button();
            lblRead = new Label();
            lblReadAll = new Label();
            openFileDialog1 = new OpenFileDialog();
            lblReadAllCustomers = new Label();
            products.SuspendLayout();
            tabAdd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudQuantityInStock).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudPrice).BeginInit();
            tabUpdate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudNewQuantityInStock).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudID).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudNewPrice).BeginInit();
            tabDelete.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudIDtoDelete).BeginInit();
            tabDesine.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudRead).BeginInit();
            SuspendLayout();
            // 
            // products
            // 
            products.Controls.Add(tabAdd);
            products.Controls.Add(tabUpdate);
            products.Controls.Add(tabDelete);
            products.Controls.Add(tabDesine);
            products.Location = new Point(51, 26);
            products.Name = "products";
            products.RightToLeft = RightToLeft.No;
            products.RightToLeftLayout = true;
            products.SelectedIndex = 0;
            products.Size = new Size(715, 386);
            products.TabIndex = 2;
            // 
            // tabAdd
            // 
            tabAdd.Controls.Add(btnAdd);
            tabAdd.Controls.Add(cbxCategory);
            tabAdd.Controls.Add(nudQuantityInStock);
            tabAdd.Controls.Add(nudPrice);
            tabAdd.Controls.Add(tbxNameProduct);
            tabAdd.Controls.Add(lblQuantityInStock);
            tabAdd.Controls.Add(lblCategory);
            tabAdd.Controls.Add(lblPrice);
            tabAdd.Controls.Add(lblNameAproduct);
            tabAdd.Location = new Point(4, 29);
            tabAdd.Name = "tabAdd";
            tabAdd.Padding = new Padding(3);
            tabAdd.RightToLeft = RightToLeft.Yes;
            tabAdd.Size = new Size(707, 353);
            tabAdd.TabIndex = 0;
            tabAdd.Text = "הוספת מוצר";
            tabAdd.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(98, 264);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "הוספה";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // cbxCategory
            // 
            cbxCategory.Items.AddRange(new object[] { " טיפוח_עור_הפנים", "טיפוח_אישי", "טיפוח_העור", "משקאות", "מוצרי_כוורת " });
            cbxCategory.Location = new Point(398, 119);
            cbxCategory.Name = "cbxCategory";
            cbxCategory.Size = new Size(151, 28);
            cbxCategory.TabIndex = 3;
            cbxCategory.Text = "טיפוח העור";
            // 
            // nudQuantityInStock
            // 
            nudQuantityInStock.Location = new Point(399, 163);
            nudQuantityInStock.Name = "nudQuantityInStock";
            nudQuantityInStock.Size = new Size(150, 27);
            nudQuantityInStock.TabIndex = 2;
            // 
            // nudPrice
            // 
            nudPrice.Location = new Point(399, 75);
            nudPrice.Name = "nudPrice";
            nudPrice.Size = new Size(150, 27);
            nudPrice.TabIndex = 2;
            // 
            // tbxNameProduct
            // 
            tbxNameProduct.Location = new Point(398, 31);
            tbxNameProduct.Name = "tbxNameProduct";
            tbxNameProduct.Size = new Size(151, 27);
            tbxNameProduct.TabIndex = 1;
            // 
            // lblQuantityInStock
            // 
            lblQuantityInStock.AutoSize = true;
            lblQuantityInStock.Location = new Point(555, 165);
            lblQuantityInStock.Name = "lblQuantityInStock";
            lblQuantityInStock.Size = new Size(87, 20);
            lblQuantityInStock.TabIndex = 0;
            lblQuantityInStock.Text = "כמות במלאי";
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Location = new Point(555, 122);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(62, 20);
            lblCategory.TabIndex = 0;
            lblCategory.Text = "קטגוריה";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(555, 77);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(41, 20);
            lblPrice.TabIndex = 0;
            lblPrice.Text = "מחיר";
            // 
            // lblNameAproduct
            // 
            lblNameAproduct.AutoSize = true;
            lblNameAproduct.Location = new Point(555, 31);
            lblNameAproduct.Name = "lblNameAproduct";
            lblNameAproduct.Size = new Size(66, 20);
            lblNameAproduct.TabIndex = 0;
            lblNameAproduct.Text = "שם מוצר";
            // 
            // tabUpdate
            // 
            tabUpdate.Controls.Add(cbxNewCategory);
            tabUpdate.Controls.Add(nudNewQuantityInStock);
            tabUpdate.Controls.Add(nudID);
            tabUpdate.Controls.Add(nudNewPrice);
            tabUpdate.Controls.Add(txtNewName);
            tabUpdate.Controls.Add(lblNewQuantityInStock);
            tabUpdate.Controls.Add(lblNewCategory);
            tabUpdate.Controls.Add(lblNewPrice);
            tabUpdate.Controls.Add(lblNewName);
            tabUpdate.Controls.Add(btnUpdate);
            tabUpdate.Controls.Add(lblID);
            tabUpdate.Location = new Point(4, 29);
            tabUpdate.Name = "tabUpdate";
            tabUpdate.Padding = new Padding(3);
            tabUpdate.Size = new Size(707, 353);
            tabUpdate.TabIndex = 1;
            tabUpdate.Text = "עדכון מוצר";
            tabUpdate.UseVisualStyleBackColor = true;
            // 
            // cbxNewCategory
            // 
            cbxNewCategory.Items.AddRange(new object[] { " טיפוח_עור_הפנים", "טיפוח_אישי", "טיפוח_העור", "משקאות", "מוצרי_כוורת " });
            cbxNewCategory.Location = new Point(334, 201);
            cbxNewCategory.Name = "cbxNewCategory";
            cbxNewCategory.Size = new Size(151, 28);
            cbxNewCategory.TabIndex = 11;
            cbxNewCategory.Text = "טיפוח העור";
            // 
            // nudNewQuantityInStock
            // 
            nudNewQuantityInStock.Location = new Point(335, 245);
            nudNewQuantityInStock.Name = "nudNewQuantityInStock";
            nudNewQuantityInStock.Size = new Size(150, 27);
            nudNewQuantityInStock.TabIndex = 9;
            // 
            // nudID
            // 
            nudID.Location = new Point(334, 73);
            nudID.Maximum = new decimal(new int[] { -727379968, 232, 0, 0 });
            nudID.Name = "nudID";
            nudID.Size = new Size(150, 27);
            nudID.TabIndex = 10;
            // 
            // nudNewPrice
            // 
            nudNewPrice.Location = new Point(335, 157);
            nudNewPrice.Name = "nudNewPrice";
            nudNewPrice.Size = new Size(150, 27);
            nudNewPrice.TabIndex = 10;
            // 
            // txtNewName
            // 
            txtNewName.Location = new Point(334, 113);
            txtNewName.Name = "txtNewName";
            txtNewName.Size = new Size(151, 27);
            txtNewName.TabIndex = 8;
            // 
            // lblNewQuantityInStock
            // 
            lblNewQuantityInStock.AutoSize = true;
            lblNewQuantityInStock.Location = new Point(491, 247);
            lblNewQuantityInStock.Name = "lblNewQuantityInStock";
            lblNewQuantityInStock.Size = new Size(87, 20);
            lblNewQuantityInStock.TabIndex = 4;
            lblNewQuantityInStock.Text = "כמות במלאי";
            // 
            // lblNewCategory
            // 
            lblNewCategory.AutoSize = true;
            lblNewCategory.Location = new Point(491, 204);
            lblNewCategory.Name = "lblNewCategory";
            lblNewCategory.Size = new Size(62, 20);
            lblNewCategory.TabIndex = 5;
            lblNewCategory.Text = "קטגוריה";
            // 
            // lblNewPrice
            // 
            lblNewPrice.AutoSize = true;
            lblNewPrice.Location = new Point(491, 159);
            lblNewPrice.Name = "lblNewPrice";
            lblNewPrice.Size = new Size(41, 20);
            lblNewPrice.TabIndex = 6;
            lblNewPrice.Text = "מחיר";
            // 
            // lblNewName
            // 
            lblNewName.AutoSize = true;
            lblNewName.Location = new Point(491, 113);
            lblNewName.Name = "lblNewName";
            lblNewName.Size = new Size(66, 20);
            lblNewName.TabIndex = 7;
            lblNewName.Text = "שם מוצר";
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(76, 266);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 2;
            btnUpdate.Text = "עדכון";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += button1_Click;
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.Location = new Point(504, 75);
            lblID.Name = "lblID";
            lblID.Size = new Size(66, 20);
            lblID.TabIndex = 0;
            lblID.Text = "לשינוי ID";
            // 
            // tabDelete
            // 
            tabDelete.Controls.Add(btnDelete);
            tabDelete.Controls.Add(nudIDtoDelete);
            tabDelete.Controls.Add(lblIDtoDelete);
            tabDelete.Location = new Point(4, 29);
            tabDelete.Name = "tabDelete";
            tabDelete.Padding = new Padding(3);
            tabDelete.Size = new Size(707, 353);
            tabDelete.TabIndex = 2;
            tabDelete.Text = "מחיקת מוצר";
            tabDelete.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(120, 255);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 13;
            btnDelete.Text = "למחיקה";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // nudIDtoDelete
            // 
            nudIDtoDelete.Location = new Point(334, 73);
            nudIDtoDelete.Maximum = new decimal(new int[] { -727379968, 232, 0, 0 });
            nudIDtoDelete.Name = "nudIDtoDelete";
            nudIDtoDelete.Size = new Size(150, 27);
            nudIDtoDelete.TabIndex = 12;
            // 
            // lblIDtoDelete
            // 
            lblIDtoDelete.AutoSize = true;
            lblIDtoDelete.Location = new Point(504, 75);
            lblIDtoDelete.Name = "lblIDtoDelete";
            lblIDtoDelete.Size = new Size(130, 20);
            lblIDtoDelete.TabIndex = 11;
            lblIDtoDelete.Text = " ID הכנס  למחיקה ";
            // 
            // tabDesine
            // 
            tabDesine.AutoScroll = true;
            tabDesine.Controls.Add(lblReadAllCustomers);
            tabDesine.Controls.Add(lblReadNew);
            tabDesine.Controls.Add(nudRead);
            tabDesine.Controls.Add(btnReadCustomer);
            tabDesine.Controls.Add(lblRead);
            tabDesine.Controls.Add(lblReadAll);
            tabDesine.Location = new Point(4, 29);
            tabDesine.Name = "tabDesine";
            tabDesine.Padding = new Padding(3);
            tabDesine.Size = new Size(707, 353);
            tabDesine.TabIndex = 3;
            tabDesine.Text = "קבלת מוצר";
            tabDesine.UseVisualStyleBackColor = true;
            tabDesine.Click += tabDesine_Click;
            // 
            // lblReadNew
            // 
            lblReadNew.AutoSize = true;
            lblReadNew.Location = new Point(42, 38);
            lblReadNew.Name = "lblReadNew";
            lblReadNew.Size = new Size(0, 20);
            lblReadNew.TabIndex = 5;
            // 
            // nudRead
            // 
            nudRead.Location = new Point(404, 53);
            nudRead.Maximum = new decimal(new int[] { 1410065408, 2, 0, 0 });
            nudRead.Name = "nudRead";
            nudRead.Size = new Size(150, 27);
            nudRead.TabIndex = 4;
            // 
            // btnReadCustomer
            // 
            btnReadCustomer.Location = new Point(560, 107);
            btnReadCustomer.Name = "btnReadCustomer";
            btnReadCustomer.Size = new Size(94, 29);
            btnReadCustomer.TabIndex = 3;
            btnReadCustomer.Text = "חפש";
            btnReadCustomer.UseVisualStyleBackColor = true;
            btnReadCustomer.Click += btnRead_Click;
            // 
            // lblRead
            // 
            lblRead.AutoSize = true;
            lblRead.Location = new Point(570, 55);
            lblRead.Name = "lblRead";
            lblRead.Size = new Size(84, 20);
            lblRead.TabIndex = 1;
            lblRead.Text = "ID חפש לפי";
            // 
            // lblReadAll
            // 
            lblReadAll.AutoSize = true;
            lblReadAll.Location = new Point(152, 55);
            lblReadAll.Name = "lblReadAll";
            lblReadAll.Size = new Size(0, 20);
            lblReadAll.TabIndex = 0;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // lblReadAllCustomers
            // 
            lblReadAllCustomers.AutoSize = true;
            lblReadAllCustomers.Location = new Point(37, 33);
            lblReadAllCustomers.Name = "lblReadAllCustomers";
            lblReadAllCustomers.Size = new Size(0, 20);
            lblReadAllCustomers.TabIndex = 6;
            // 
            // productsMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(products);
            Name = "productsMenu";
            RightToLeftLayout = true;
            Text = "productsMenu";
            products.ResumeLayout(false);
            tabAdd.ResumeLayout(false);
            tabAdd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudQuantityInStock).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudPrice).EndInit();
            tabUpdate.ResumeLayout(false);
            tabUpdate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudNewQuantityInStock).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudID).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudNewPrice).EndInit();
            tabDelete.ResumeLayout(false);
            tabDelete.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudIDtoDelete).EndInit();
            tabDesine.ResumeLayout(false);
            tabDesine.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudRead).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private TabControl products;
        private TabPage tabAdd;
        private TabPage tabUpdate;
        private TabPage tabDelete;
        private TabPage tabDesine;
        private TextBox tbxNameProduct;
        private Label lblNameAproduct;
        private NumericUpDown nudPrice;
        private Label lblPrice;
        private OpenFileDialog openFileDialog1;
        private ComboBox cbxCategory;
        private Label lblCategory;
        private Label lblQuantityInStock;
        private Button btnAdd;
        private NumericUpDown nudQuantityInStock;
        private Button btnUpdate;
        private Label lblID;
        private ComboBox cbxNewCategory;
        private NumericUpDown nudNewQuantityInStock;
        private NumericUpDown nudNewPrice;
        private TextBox txtNewName;
        private Label lblNewQuantityInStock;
        private Label lblNewCategory;
        private Label lblNewPrice;
        private Label lblNewName;
        private NumericUpDown nudID;
        private Button btnDelete;
        private NumericUpDown nudIDtoDelete;
        private Label lblIDtoDelete;
        private Label lblReadAll;
        private Button btnReadCustomer;
        private Label lblRead;
        private NumericUpDown nudRead;
        private Label lblReadNew;
        private Label lblReadAllCustomers;
    }
}