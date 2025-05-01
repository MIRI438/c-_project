namespace UI
{
    partial class SaleMenu
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
            tabAddSale = new TabPage();
            btnAdd = new Button();
            nudMinQuantity = new NumericUpDown();
            lblMinQuantity = new Label();
            lblProductIdForSale = new Label();
            tabUpdateSale = new TabPage();
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
            tabDeleteSale = new TabPage();
            btnDelete = new Button();
            nudIDtoDelete = new NumericUpDown();
            lblIDtoDelete = new Label();
            tabDesineSales = new TabPage();
            lblReadAllCustomers = new Label();
            lblReadNew = new Label();
            nudRead = new NumericUpDown();
            btnReadCustomer = new Button();
            lblRead = new Label();
            lblReadAll = new Label();
            nudProductId = new NumericUpDown();
            nudPriceSale = new NumericUpDown();
            lblPriceSale = new Label();
            lblInClub = new Label();
            rbtYesInClub = new RadioButton();
            rbtnNoInClub = new RadioButton();
            products.SuspendLayout();
            tabAddSale.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudMinQuantity).BeginInit();
            tabUpdateSale.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudNewQuantityInStock).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudID).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudNewPrice).BeginInit();
            tabDeleteSale.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudIDtoDelete).BeginInit();
            tabDesineSales.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudRead).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudProductId).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudPriceSale).BeginInit();
            SuspendLayout();
            // 
            // products
            // 
            products.Controls.Add(tabAddSale);
            products.Controls.Add(tabUpdateSale);
            products.Controls.Add(tabDeleteSale);
            products.Controls.Add(tabDesineSales);
            products.Location = new Point(43, 32);
            products.Name = "products";
            products.RightToLeft = RightToLeft.No;
            products.RightToLeftLayout = true;
            products.SelectedIndex = 0;
            products.Size = new Size(715, 386);
            products.TabIndex = 3;
            // 
            // tabAddSale
            // 
            tabAddSale.Controls.Add(rbtnNoInClub);
            tabAddSale.Controls.Add(rbtYesInClub);
            tabAddSale.Controls.Add(lblInClub);
            tabAddSale.Controls.Add(nudPriceSale);
            tabAddSale.Controls.Add(lblPriceSale);
            tabAddSale.Controls.Add(nudProductId);
            tabAddSale.Controls.Add(btnAdd);
            tabAddSale.Controls.Add(nudMinQuantity);
            tabAddSale.Controls.Add(lblMinQuantity);
            tabAddSale.Controls.Add(lblProductIdForSale);
            tabAddSale.Location = new Point(4, 29);
            tabAddSale.Name = "tabAddSale";
            tabAddSale.Padding = new Padding(3);
            tabAddSale.RightToLeft = RightToLeft.Yes;
            tabAddSale.Size = new Size(707, 353);
            tabAddSale.TabIndex = 0;
            tabAddSale.Text = "הוספת מבצע";
            tabAddSale.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(98, 264);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "הוספה";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // nudMinQuantity
            // 
            nudMinQuantity.Location = new Point(356, 76);
            nudMinQuantity.Name = "nudMinQuantity";
            nudMinQuantity.Size = new Size(150, 27);
            nudMinQuantity.TabIndex = 2;
            // 
            // lblMinQuantity
            // 
            lblMinQuantity.AutoSize = true;
            lblMinQuantity.Location = new Point(515, 81);
            lblMinQuantity.Name = "lblMinQuantity";
            lblMinQuantity.Size = new Size(148, 20);
            lblMinQuantity.TabIndex = 0;
            lblMinQuantity.Text = "כמות מנימלית למבצע";
            // 
            // lblProductIdForSale
            // 
            lblProductIdForSale.AutoSize = true;
            lblProductIdForSale.Location = new Point(515, 35);
            lblProductIdForSale.Name = "lblProductIdForSale";
            lblProductIdForSale.Size = new Size(65, 20);
            lblProductIdForSale.TabIndex = 0;
            lblProductIdForSale.Text = "קוד מוצר";
            // 
            // tabUpdateSale
            // 
            tabUpdateSale.Controls.Add(cbxNewCategory);
            tabUpdateSale.Controls.Add(nudNewQuantityInStock);
            tabUpdateSale.Controls.Add(nudID);
            tabUpdateSale.Controls.Add(nudNewPrice);
            tabUpdateSale.Controls.Add(txtNewName);
            tabUpdateSale.Controls.Add(lblNewQuantityInStock);
            tabUpdateSale.Controls.Add(lblNewCategory);
            tabUpdateSale.Controls.Add(lblNewPrice);
            tabUpdateSale.Controls.Add(lblNewName);
            tabUpdateSale.Controls.Add(btnUpdate);
            tabUpdateSale.Controls.Add(lblID);
            tabUpdateSale.Location = new Point(4, 29);
            tabUpdateSale.Name = "tabUpdateSale";
            tabUpdateSale.Padding = new Padding(3);
            tabUpdateSale.Size = new Size(707, 353);
            tabUpdateSale.TabIndex = 1;
            tabUpdateSale.Text = "עדכון מבצע";
            tabUpdateSale.UseVisualStyleBackColor = true;
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
            lblNewQuantityInStock.Location = new Point(494, 250);
            lblNewQuantityInStock.Name = "lblNewQuantityInStock";
            lblNewQuantityInStock.Size = new Size(87, 20);
            lblNewQuantityInStock.TabIndex = 4;
            lblNewQuantityInStock.Text = "כמות במלאי";
            // 
            // lblNewCategory
            // 
            lblNewCategory.AutoSize = true;
            lblNewCategory.Location = new Point(494, 207);
            lblNewCategory.Name = "lblNewCategory";
            lblNewCategory.Size = new Size(62, 20);
            lblNewCategory.TabIndex = 5;
            lblNewCategory.Text = "קטגוריה";
            // 
            // lblNewPrice
            // 
            lblNewPrice.AutoSize = true;
            lblNewPrice.Location = new Point(494, 162);
            lblNewPrice.Name = "lblNewPrice";
            lblNewPrice.Size = new Size(41, 20);
            lblNewPrice.TabIndex = 6;
            lblNewPrice.Text = "מחיר";
            // 
            // lblNewName
            // 
            lblNewName.AutoSize = true;
            lblNewName.Location = new Point(494, 116);
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
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.Location = new Point(507, 78);
            lblID.Name = "lblID";
            lblID.Size = new Size(66, 20);
            lblID.TabIndex = 0;
            lblID.Text = "לשינוי ID";
            // 
            // tabDeleteSale
            // 
            tabDeleteSale.Controls.Add(btnDelete);
            tabDeleteSale.Controls.Add(nudIDtoDelete);
            tabDeleteSale.Controls.Add(lblIDtoDelete);
            tabDeleteSale.Location = new Point(4, 29);
            tabDeleteSale.Name = "tabDeleteSale";
            tabDeleteSale.Padding = new Padding(3);
            tabDeleteSale.Size = new Size(707, 353);
            tabDeleteSale.TabIndex = 2;
            tabDeleteSale.Text = "מחיקת מבצע";
            tabDeleteSale.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(120, 255);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 13;
            btnDelete.Text = "למחיקה";
            btnDelete.UseVisualStyleBackColor = true;
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
            lblIDtoDelete.Location = new Point(507, 78);
            lblIDtoDelete.Name = "lblIDtoDelete";
            lblIDtoDelete.Size = new Size(130, 20);
            lblIDtoDelete.TabIndex = 11;
            lblIDtoDelete.Text = " ID הכנס  למחיקה ";
            // 
            // tabDesineSales
            // 
            tabDesineSales.AutoScroll = true;
            tabDesineSales.Controls.Add(lblReadAllCustomers);
            tabDesineSales.Controls.Add(lblReadNew);
            tabDesineSales.Controls.Add(nudRead);
            tabDesineSales.Controls.Add(btnReadCustomer);
            tabDesineSales.Controls.Add(lblRead);
            tabDesineSales.Controls.Add(lblReadAll);
            tabDesineSales.Location = new Point(4, 29);
            tabDesineSales.Name = "tabDesineSales";
            tabDesineSales.Padding = new Padding(3);
            tabDesineSales.Size = new Size(707, 353);
            tabDesineSales.TabIndex = 3;
            tabDesineSales.Text = "הצגת מבצעים";
            tabDesineSales.UseVisualStyleBackColor = true;
            // 
            // lblReadAllCustomers
            // 
            lblReadAllCustomers.AutoSize = true;
            lblReadAllCustomers.Location = new Point(40, 36);
            lblReadAllCustomers.Name = "lblReadAllCustomers";
            lblReadAllCustomers.Size = new Size(0, 20);
            lblReadAllCustomers.TabIndex = 6;
            // 
            // lblReadNew
            // 
            lblReadNew.AutoSize = true;
            lblReadNew.Location = new Point(45, 41);
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
            // 
            // lblRead
            // 
            lblRead.AutoSize = true;
            lblRead.Location = new Point(573, 58);
            lblRead.Name = "lblRead";
            lblRead.Size = new Size(84, 20);
            lblRead.TabIndex = 1;
            lblRead.Text = "ID חפש לפי";
            // 
            // lblReadAll
            // 
            lblReadAll.AutoSize = true;
            lblReadAll.Location = new Point(155, 58);
            lblReadAll.Name = "lblReadAll";
            lblReadAll.Size = new Size(0, 20);
            lblReadAll.TabIndex = 0;
            // 
            // nudProductId
            // 
            nudProductId.Location = new Point(355, 35);
            nudProductId.Name = "nudProductId";
            nudProductId.Size = new Size(150, 27);
            nudProductId.TabIndex = 5;
            // 
            // nudPriceSale
            // 
            nudPriceSale.Location = new Point(356, 122);
            nudPriceSale.Name = "nudPriceSale";
            nudPriceSale.Size = new Size(150, 27);
            nudPriceSale.TabIndex = 7;
            // 
            // lblPriceSale
            // 
            lblPriceSale.AutoSize = true;
            lblPriceSale.Location = new Point(515, 127);
            lblPriceSale.Name = "lblPriceSale";
            lblPriceSale.Size = new Size(82, 20);
            lblPriceSale.TabIndex = 6;
            lblPriceSale.Text = "מחיר מבצע";
            // 
            // lblInClub
            // 
            lblInClub.AutoSize = true;
            lblInClub.Location = new Point(515, 163);
            lblInClub.Name = "lblInClub";
            lblInClub.Size = new Size(159, 20);
            lblInClub.TabIndex = 8;
            lblInClub.Text = "המבצע רק לחבר מועדון";
            // 
            // rbtYesInClub
            // 
            rbtYesInClub.AutoSize = true;
            rbtYesInClub.Location = new Point(355, 163);
            rbtYesInClub.Name = "rbtYesInClub";
            rbtYesInClub.Size = new Size(42, 24);
            rbtYesInClub.TabIndex = 9;
            rbtYesInClub.TabStop = true;
            rbtYesInClub.Text = "כן";
            rbtYesInClub.UseVisualStyleBackColor = true;
            // 
            // rbtnNoInClub
            // 
            rbtnNoInClub.AutoSize = true;
            rbtnNoInClub.Location = new Point(458, 163);
            rbtnNoInClub.Name = "rbtnNoInClub";
            rbtnNoInClub.Size = new Size(48, 24);
            rbtnNoInClub.TabIndex = 9;
            rbtnNoInClub.TabStop = true;
            rbtnNoInClub.Text = "לא";
            rbtnNoInClub.UseVisualStyleBackColor = true;
            // 
            // SaleMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(products);
            Name = "SaleMenu";
            Text = "SaleMenu";
            products.ResumeLayout(false);
            tabAddSale.ResumeLayout(false);
            tabAddSale.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudMinQuantity).EndInit();
            tabUpdateSale.ResumeLayout(false);
            tabUpdateSale.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudNewQuantityInStock).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudID).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudNewPrice).EndInit();
            tabDeleteSale.ResumeLayout(false);
            tabDeleteSale.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudIDtoDelete).EndInit();
            tabDesineSales.ResumeLayout(false);
            tabDesineSales.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudRead).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudProductId).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudPriceSale).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl products;
        private TabPage tabAddSale;
        private Button btnAdd;
        private NumericUpDown nudMinQuantity;
        private Label lblMinQuantity;
        private Label lblProductIdForSale;
        private TabPage tabUpdateSale;
        private ComboBox cbxNewCategory;
        private NumericUpDown nudNewQuantityInStock;
        private NumericUpDown nudID;
        private NumericUpDown nudNewPrice;
        private TextBox txtNewName;
        private Label lblNewQuantityInStock;
        private Label lblNewCategory;
        private Label lblNewPrice;
        private Label lblNewName;
        private Button btnUpdate;
        private Label lblID;
        private TabPage tabDeleteSale;
        private Button btnDelete;
        private NumericUpDown nudIDtoDelete;
        private Label lblIDtoDelete;
        private TabPage tabDesineSales;
        private Label lblReadAllCustomers;
        private Label lblReadNew;
        private NumericUpDown nudRead;
        private Button btnReadCustomer;
        private Label lblRead;
        private Label lblReadAll;
        private NumericUpDown nudProductId;
        private NumericUpDown nudPriceSale;
        private Label lblPriceSale;
        private RadioButton rbtnNoInClub;
        private RadioButton rbtYesInClub;
        private Label lblInClub;
    }
}