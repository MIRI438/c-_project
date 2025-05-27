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
            lblReadAllCustomers = new Label();
            lblReadNew = new Label();
            nudRead = new NumericUpDown();
            btnReadCustomer = new Button();
            lblRead = new Label();
            lblReadAll = new Label();
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
            products.Location = new Point(45, 20);
            products.Margin = new Padding(3, 2, 3, 2);
            products.Name = "products";
            products.RightToLeft = RightToLeft.No;
            products.RightToLeftLayout = true;
            products.SelectedIndex = 0;
            products.Size = new Size(1083, 559);
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
            tabAdd.Location = new Point(4, 24);
            tabAdd.Margin = new Padding(3, 2, 3, 2);
            tabAdd.Name = "tabAdd";
            tabAdd.Padding = new Padding(3, 2, 3, 2);
            tabAdd.RightToLeft = RightToLeft.Yes;
            tabAdd.Size = new Size(1075, 531);
            tabAdd.TabIndex = 0;
            tabAdd.Text = "הוספת מוצר";
            tabAdd.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(492, 343);
            btnAdd.Margin = new Padding(3, 2, 3, 2);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(82, 22);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "הוספה";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // cbxCategory
            // 
            cbxCategory.Items.AddRange(new object[] { " טיפוח_עור_הפנים", "טיפוח_אישי", "טיפוח_העור", "משקאות", "מוצרי_כוורת " });
            cbxCategory.Location = new Point(646, 155);
            cbxCategory.Margin = new Padding(3, 2, 3, 2);
            cbxCategory.Name = "cbxCategory";
            cbxCategory.Size = new Size(133, 23);
            cbxCategory.TabIndex = 3;
            cbxCategory.Text = "טיפוח העור";
            cbxCategory.SelectedIndexChanged += cbxCategory_SelectedIndexChanged;
            // 
            // nudQuantityInStock
            // 
            nudQuantityInStock.Location = new Point(647, 188);
            nudQuantityInStock.Margin = new Padding(3, 2, 3, 2);
            nudQuantityInStock.Name = "nudQuantityInStock";
            nudQuantityInStock.Size = new Size(131, 23);
            nudQuantityInStock.TabIndex = 2;
            // 
            // nudPrice
            // 
            nudPrice.Location = new Point(647, 122);
            nudPrice.Margin = new Padding(3, 2, 3, 2);
            nudPrice.Name = "nudPrice";
            nudPrice.Size = new Size(131, 23);
            nudPrice.TabIndex = 2;
            // 
            // tbxNameProduct
            // 
            tbxNameProduct.Location = new Point(646, 89);
            tbxNameProduct.Margin = new Padding(3, 2, 3, 2);
            tbxNameProduct.Name = "tbxNameProduct";
            tbxNameProduct.Size = new Size(133, 23);
            tbxNameProduct.TabIndex = 1;
            // 
            // lblQuantityInStock
            // 
            lblQuantityInStock.AutoSize = true;
            lblQuantityInStock.Location = new Point(784, 190);
            lblQuantityInStock.Name = "lblQuantityInStock";
            lblQuantityInStock.Size = new Size(70, 15);
            lblQuantityInStock.TabIndex = 0;
            lblQuantityInStock.Text = "כמות במלאי";
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Location = new Point(784, 158);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(49, 15);
            lblCategory.TabIndex = 0;
            lblCategory.Text = "קטגוריה";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(784, 124);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(33, 15);
            lblPrice.TabIndex = 0;
            lblPrice.Text = "מחיר";
            // 
            // lblNameAproduct
            // 
            lblNameAproduct.AutoSize = true;
            lblNameAproduct.Location = new Point(784, 89);
            lblNameAproduct.Name = "lblNameAproduct";
            lblNameAproduct.Size = new Size(52, 15);
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
            tabUpdate.Location = new Point(4, 24);
            tabUpdate.Margin = new Padding(3, 2, 3, 2);
            tabUpdate.Name = "tabUpdate";
            tabUpdate.Padding = new Padding(3, 2, 3, 2);
            tabUpdate.Size = new Size(1075, 531);
            tabUpdate.TabIndex = 1;
            tabUpdate.Text = "עדכון מוצר";
            tabUpdate.UseVisualStyleBackColor = true;
            // 
            // cbxNewCategory
            // 
            cbxNewCategory.Items.AddRange(new object[] { " טיפוח_עור_הפנים", "טיפוח_אישי", "טיפוח_העור", "משקאות", "מוצרי_כוורת " });
            cbxNewCategory.Location = new Point(667, 204);
            cbxNewCategory.Margin = new Padding(3, 2, 3, 2);
            cbxNewCategory.Name = "cbxNewCategory";
            cbxNewCategory.Size = new Size(133, 23);
            cbxNewCategory.TabIndex = 11;
            cbxNewCategory.Text = "טיפוח העור";
            // 
            // nudNewQuantityInStock
            // 
            nudNewQuantityInStock.Location = new Point(668, 237);
            nudNewQuantityInStock.Margin = new Padding(3, 2, 3, 2);
            nudNewQuantityInStock.Name = "nudNewQuantityInStock";
            nudNewQuantityInStock.Size = new Size(131, 23);
            nudNewQuantityInStock.TabIndex = 9;
            // 
            // nudID
            // 
            nudID.Location = new Point(667, 108);
            nudID.Margin = new Padding(3, 2, 3, 2);
            nudID.Maximum = new decimal(new int[] { -727379968, 232, 0, 0 });
            nudID.Name = "nudID";
            nudID.Size = new Size(131, 23);
            nudID.TabIndex = 10;
            // 
            // nudNewPrice
            // 
            nudNewPrice.Location = new Point(668, 171);
            nudNewPrice.Margin = new Padding(3, 2, 3, 2);
            nudNewPrice.Name = "nudNewPrice";
            nudNewPrice.Size = new Size(131, 23);
            nudNewPrice.TabIndex = 10;
            // 
            // txtNewName
            // 
            txtNewName.Location = new Point(667, 138);
            txtNewName.Margin = new Padding(3, 2, 3, 2);
            txtNewName.Name = "txtNewName";
            txtNewName.Size = new Size(133, 23);
            txtNewName.TabIndex = 8;
            // 
            // lblNewQuantityInStock
            // 
            lblNewQuantityInStock.AutoSize = true;
            lblNewQuantityInStock.Location = new Point(805, 238);
            lblNewQuantityInStock.Name = "lblNewQuantityInStock";
            lblNewQuantityInStock.Size = new Size(70, 15);
            lblNewQuantityInStock.TabIndex = 4;
            lblNewQuantityInStock.Text = "כמות במלאי";
            // 
            // lblNewCategory
            // 
            lblNewCategory.AutoSize = true;
            lblNewCategory.Location = new Point(805, 206);
            lblNewCategory.Name = "lblNewCategory";
            lblNewCategory.Size = new Size(49, 15);
            lblNewCategory.TabIndex = 5;
            lblNewCategory.Text = "קטגוריה";
            // 
            // lblNewPrice
            // 
            lblNewPrice.AutoSize = true;
            lblNewPrice.Location = new Point(805, 172);
            lblNewPrice.Name = "lblNewPrice";
            lblNewPrice.Size = new Size(33, 15);
            lblNewPrice.TabIndex = 6;
            lblNewPrice.Text = "מחיר";
            // 
            // lblNewName
            // 
            lblNewName.AutoSize = true;
            lblNewName.Location = new Point(805, 138);
            lblNewName.Name = "lblNewName";
            lblNewName.Size = new Size(52, 15);
            lblNewName.TabIndex = 7;
            lblNewName.Text = "שם מוצר";
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(508, 352);
            btnUpdate.Margin = new Padding(3, 2, 3, 2);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(82, 22);
            btnUpdate.TabIndex = 2;
            btnUpdate.Text = "עדכון";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += button1_Click;
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.Location = new Point(816, 109);
            lblID.Name = "lblID";
            lblID.Size = new Size(51, 15);
            lblID.TabIndex = 0;
            lblID.Text = "לשינוי ID";
            // 
            // tabDelete
            // 
            tabDelete.Controls.Add(btnDelete);
            tabDelete.Controls.Add(nudIDtoDelete);
            tabDelete.Controls.Add(lblIDtoDelete);
            tabDelete.Location = new Point(4, 24);
            tabDelete.Margin = new Padding(3, 2, 3, 2);
            tabDelete.Name = "tabDelete";
            tabDelete.Padding = new Padding(3, 2, 3, 2);
            tabDelete.Size = new Size(1075, 531);
            tabDelete.TabIndex = 2;
            tabDelete.Text = "מחיקת מוצר";
            tabDelete.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(501, 330);
            btnDelete.Margin = new Padding(3, 2, 3, 2);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(82, 22);
            btnDelete.TabIndex = 13;
            btnDelete.Text = "למחיקה";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // nudIDtoDelete
            // 
            nudIDtoDelete.Location = new Point(636, 114);
            nudIDtoDelete.Margin = new Padding(3, 2, 3, 2);
            nudIDtoDelete.Maximum = new decimal(new int[] { -727379968, 232, 0, 0 });
            nudIDtoDelete.Name = "nudIDtoDelete";
            nudIDtoDelete.Size = new Size(131, 23);
            nudIDtoDelete.TabIndex = 12;
            // 
            // lblIDtoDelete
            // 
            lblIDtoDelete.AutoSize = true;
            lblIDtoDelete.Location = new Point(785, 115);
            lblIDtoDelete.Name = "lblIDtoDelete";
            lblIDtoDelete.Size = new Size(103, 15);
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
            tabDesine.Location = new Point(4, 24);
            tabDesine.Margin = new Padding(3, 2, 3, 2);
            tabDesine.Name = "tabDesine";
            tabDesine.Padding = new Padding(3, 2, 3, 2);
            tabDesine.Size = new Size(1075, 531);
            tabDesine.TabIndex = 3;
            tabDesine.Text = "קבלת מוצר";
            tabDesine.UseVisualStyleBackColor = true;
            tabDesine.Click += tabDesine_Click;
            // 
            // lblReadAllCustomers
            // 
            lblReadAllCustomers.AutoSize = true;
            lblReadAllCustomers.Location = new Point(32, 25);
            lblReadAllCustomers.Name = "lblReadAllCustomers";
            lblReadAllCustomers.Size = new Size(0, 15);
            lblReadAllCustomers.TabIndex = 6;
            // 
            // lblReadNew
            // 
            lblReadNew.AutoSize = true;
            lblReadNew.Location = new Point(37, 28);
            lblReadNew.Name = "lblReadNew";
            lblReadNew.Size = new Size(0, 15);
            lblReadNew.TabIndex = 5;
            // 
            // nudRead
            // 
            nudRead.Location = new Point(624, 119);
            nudRead.Margin = new Padding(3, 2, 3, 2);
            nudRead.Maximum = new decimal(new int[] { 1410065408, 2, 0, 0 });
            nudRead.Name = "nudRead";
            nudRead.Size = new Size(131, 23);
            nudRead.TabIndex = 4;
            nudRead.ValueChanged += nudRead_ValueChanged;
            // 
            // btnReadCustomer
            // 
            btnReadCustomer.Location = new Point(516, 345);
            btnReadCustomer.Margin = new Padding(3, 2, 3, 2);
            btnReadCustomer.Name = "btnReadCustomer";
            btnReadCustomer.Size = new Size(82, 22);
            btnReadCustomer.TabIndex = 3;
            btnReadCustomer.Text = "חפש";
            btnReadCustomer.UseVisualStyleBackColor = true;
            btnReadCustomer.Click += btnRead_Click;
            // 
            // lblRead
            // 
            lblRead.AutoSize = true;
            lblRead.Location = new Point(769, 120);
            lblRead.Name = "lblRead";
            lblRead.Size = new Size(67, 15);
            lblRead.TabIndex = 1;
            lblRead.Text = "ID חפש לפי";
            // 
            // lblReadAll
            // 
            lblReadAll.AutoSize = true;
            lblReadAll.Location = new Point(133, 41);
            lblReadAll.Name = "lblReadAll";
            lblReadAll.Size = new Size(0, 15);
            lblReadAll.TabIndex = 0;
            // 
            // productsMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1179, 613);
            Controls.Add(products);
            Margin = new Padding(3, 2, 3, 2);
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