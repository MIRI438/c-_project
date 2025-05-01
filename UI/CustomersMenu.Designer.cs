namespace UI
{
    partial class CustomersMenu
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
            tabAddCustomer = new TabPage();
            txtAddressCustomer = new TextBox();
            lblAddressCustomer = new Label();
            btnAddCustomer = new Button();
            nudIDCustomer = new NumericUpDown();
            nudPhoneCustomer = new NumericUpDown();
            tbxNameCustomer = new TextBox();
            lblDCustomer = new Label();
            lblPhoneCustomer = new Label();
            lblNameCustomer = new Label();
            tabUpdateCustomer = new TabPage();
            nudNewPhoneCustomer = new NumericUpDown();
            lblNewPhoneCustomer = new Label();
            lblNewAddressCustomer = new Label();
            nudIDCustomerToUpdate = new NumericUpDown();
            txtNewAddressCustomer = new TextBox();
            txtNewNameCustomer = new TextBox();
            lblNewNameCustomer = new Label();
            btnUpdateCustomer = new Button();
            lblIDCustomerToUpdate = new Label();
            tabDeleteCustomer = new TabPage();
            btnDeleteCustomer = new Button();
            nudIDtoDeleteCustomer = new NumericUpDown();
            lblIDtoDeleteCustomer = new Label();
            tabDesineCustomers = new TabPage();
            lblReadNew = new Label();
            nudReadCustomer = new NumericUpDown();
            btnRead = new Button();
            lblReadCustomer = new Label();
            lblReadAll = new Label();
            lblReadAllCustomers = new Label();
            products.SuspendLayout();
            tabAddCustomer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudIDCustomer).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudPhoneCustomer).BeginInit();
            tabUpdateCustomer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudNewPhoneCustomer).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudIDCustomerToUpdate).BeginInit();
            tabDeleteCustomer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudIDtoDeleteCustomer).BeginInit();
            tabDesineCustomers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudReadCustomer).BeginInit();
            SuspendLayout();
            // 
            // products
            // 
            products.Controls.Add(tabAddCustomer);
            products.Controls.Add(tabUpdateCustomer);
            products.Controls.Add(tabDeleteCustomer);
            products.Controls.Add(tabDesineCustomers);
            products.Location = new Point(43, 32);
            products.Name = "products";
            products.RightToLeft = RightToLeft.No;
            products.RightToLeftLayout = true;
            products.SelectedIndex = 0;
            products.Size = new Size(715, 386);
            products.TabIndex = 3;
            // 
            // tabAddCustomer
            // 
            tabAddCustomer.Controls.Add(txtAddressCustomer);
            tabAddCustomer.Controls.Add(lblAddressCustomer);
            tabAddCustomer.Controls.Add(btnAddCustomer);
            tabAddCustomer.Controls.Add(nudIDCustomer);
            tabAddCustomer.Controls.Add(nudPhoneCustomer);
            tabAddCustomer.Controls.Add(tbxNameCustomer);
            tabAddCustomer.Controls.Add(lblDCustomer);
            tabAddCustomer.Controls.Add(lblPhoneCustomer);
            tabAddCustomer.Controls.Add(lblNameCustomer);
            tabAddCustomer.Location = new Point(4, 29);
            tabAddCustomer.Name = "tabAddCustomer";
            tabAddCustomer.Padding = new Padding(3);
            tabAddCustomer.RightToLeft = RightToLeft.Yes;
            tabAddCustomer.Size = new Size(707, 353);
            tabAddCustomer.TabIndex = 0;
            tabAddCustomer.Text = "הוספת לקוח";
            tabAddCustomer.UseVisualStyleBackColor = true;
            // 
            // txtAddressCustomer
            // 
            txtAddressCustomer.Location = new Point(385, 144);
            txtAddressCustomer.Name = "txtAddressCustomer";
            txtAddressCustomer.Size = new Size(151, 27);
            txtAddressCustomer.TabIndex = 6;
            // 
            // lblAddressCustomer
            // 
            lblAddressCustomer.AutoSize = true;
            lblAddressCustomer.Location = new Point(545, 147);
            lblAddressCustomer.Name = "lblAddressCustomer";
            lblAddressCustomer.Size = new Size(52, 20);
            lblAddressCustomer.TabIndex = 5;
            lblAddressCustomer.Text = "כתובת";
            // 
            // btnAddCustomer
            // 
            btnAddCustomer.Location = new Point(98, 264);
            btnAddCustomer.Name = "btnAddCustomer";
            btnAddCustomer.Size = new Size(94, 29);
            btnAddCustomer.TabIndex = 4;
            btnAddCustomer.Text = "הוספה";
            btnAddCustomer.UseVisualStyleBackColor = true;
            btnAddCustomer.Click += btnAddCustomer_Click;
            // 
            // nudIDCustomer
            // 
            nudIDCustomer.Location = new Point(385, 55);
            nudIDCustomer.Maximum = new decimal(new int[] { -727379968, 232, 0, 0 });
            nudIDCustomer.Name = "nudIDCustomer";
            nudIDCustomer.Size = new Size(150, 27);
            nudIDCustomer.TabIndex = 2;
            // 
            // nudPhoneCustomer
            // 
            nudPhoneCustomer.Location = new Point(385, 193);
            nudPhoneCustomer.Maximum = new decimal(new int[] { -727379968, 232, 0, 0 });
            nudPhoneCustomer.Name = "nudPhoneCustomer";
            nudPhoneCustomer.Size = new Size(150, 27);
            nudPhoneCustomer.TabIndex = 2;
            // 
            // tbxNameCustomer
            // 
            tbxNameCustomer.Location = new Point(385, 99);
            tbxNameCustomer.Name = "tbxNameCustomer";
            tbxNameCustomer.Size = new Size(151, 27);
            tbxNameCustomer.TabIndex = 1;
            // 
            // lblDCustomer
            // 
            lblDCustomer.AutoSize = true;
            lblDCustomer.Location = new Point(545, 57);
            lblDCustomer.Name = "lblDCustomer";
            lblDCustomer.Size = new Size(85, 20);
            lblDCustomer.TabIndex = 0;
            lblDCustomer.Text = "תעודת זהות";
            // 
            // lblPhoneCustomer
            // 
            lblPhoneCustomer.AutoSize = true;
            lblPhoneCustomer.Location = new Point(541, 195);
            lblPhoneCustomer.Name = "lblPhoneCustomer";
            lblPhoneCustomer.Size = new Size(94, 20);
            lblPhoneCustomer.TabIndex = 0;
            lblPhoneCustomer.Text = "מספר פלאפון";
            // 
            // lblNameCustomer
            // 
            lblNameCustomer.AutoSize = true;
            lblNameCustomer.Location = new Point(545, 102);
            lblNameCustomer.Name = "lblNameCustomer";
            lblNameCustomer.Size = new Size(67, 20);
            lblNameCustomer.TabIndex = 0;
            lblNameCustomer.Text = "שם לקוח";
            // 
            // tabUpdateCustomer
            // 
            tabUpdateCustomer.Controls.Add(nudNewPhoneCustomer);
            tabUpdateCustomer.Controls.Add(lblNewPhoneCustomer);
            tabUpdateCustomer.Controls.Add(lblNewAddressCustomer);
            tabUpdateCustomer.Controls.Add(nudIDCustomerToUpdate);
            tabUpdateCustomer.Controls.Add(txtNewAddressCustomer);
            tabUpdateCustomer.Controls.Add(txtNewNameCustomer);
            tabUpdateCustomer.Controls.Add(lblNewNameCustomer);
            tabUpdateCustomer.Controls.Add(btnUpdateCustomer);
            tabUpdateCustomer.Controls.Add(lblIDCustomerToUpdate);
            tabUpdateCustomer.Location = new Point(4, 29);
            tabUpdateCustomer.Name = "tabUpdateCustomer";
            tabUpdateCustomer.Padding = new Padding(3);
            tabUpdateCustomer.Size = new Size(707, 353);
            tabUpdateCustomer.TabIndex = 1;
            tabUpdateCustomer.Text = "עדכון לקוח";
            tabUpdateCustomer.UseVisualStyleBackColor = true;
            // 
            // nudNewPhoneCustomer
            // 
            nudNewPhoneCustomer.Location = new Point(335, 206);
            nudNewPhoneCustomer.Maximum = new decimal(new int[] { -727379968, 232, 0, 0 });
            nudNewPhoneCustomer.Name = "nudNewPhoneCustomer";
            nudNewPhoneCustomer.Size = new Size(150, 27);
            nudNewPhoneCustomer.TabIndex = 12;
            // 
            // lblNewPhoneCustomer
            // 
            lblNewPhoneCustomer.AutoSize = true;
            lblNewPhoneCustomer.Location = new Point(496, 208);
            lblNewPhoneCustomer.Name = "lblNewPhoneCustomer";
            lblNewPhoneCustomer.Size = new Size(127, 20);
            lblNewPhoneCustomer.TabIndex = 11;
            lblNewPhoneCustomer.Text = "מספר פלאפון חדש";
            // 
            // lblNewAddressCustomer
            // 
            lblNewAddressCustomer.AutoSize = true;
            lblNewAddressCustomer.Location = new Point(496, 162);
            lblNewAddressCustomer.Name = "lblNewAddressCustomer";
            lblNewAddressCustomer.Size = new Size(95, 20);
            lblNewAddressCustomer.TabIndex = 11;
            lblNewAddressCustomer.Text = "כתובת חדשה";
            // 
            // nudIDCustomerToUpdate
            // 
            nudIDCustomerToUpdate.Location = new Point(334, 73);
            nudIDCustomerToUpdate.Maximum = new decimal(new int[] { -727379968, 232, 0, 0 });
            nudIDCustomerToUpdate.Name = "nudIDCustomerToUpdate";
            nudIDCustomerToUpdate.Size = new Size(150, 27);
            nudIDCustomerToUpdate.TabIndex = 10;
            // 
            // txtNewAddressCustomer
            // 
            txtNewAddressCustomer.Location = new Point(333, 159);
            txtNewAddressCustomer.Name = "txtNewAddressCustomer";
            txtNewAddressCustomer.Size = new Size(151, 27);
            txtNewAddressCustomer.TabIndex = 8;
            // 
            // txtNewNameCustomer
            // 
            txtNewNameCustomer.Location = new Point(334, 113);
            txtNewNameCustomer.Name = "txtNewNameCustomer";
            txtNewNameCustomer.Size = new Size(151, 27);
            txtNewNameCustomer.TabIndex = 8;
            // 
            // lblNewNameCustomer
            // 
            lblNewNameCustomer.AutoSize = true;
            lblNewNameCustomer.Location = new Point(494, 116);
            lblNewNameCustomer.Name = "lblNewNameCustomer";
            lblNewNameCustomer.Size = new Size(64, 20);
            lblNewNameCustomer.TabIndex = 7;
            lblNewNameCustomer.Text = "שם חדש";
            // 
            // btnUpdateCustomer
            // 
            btnUpdateCustomer.Location = new Point(76, 266);
            btnUpdateCustomer.Name = "btnUpdateCustomer";
            btnUpdateCustomer.Size = new Size(94, 29);
            btnUpdateCustomer.TabIndex = 2;
            btnUpdateCustomer.Text = "עדכון";
            btnUpdateCustomer.UseVisualStyleBackColor = true;
            btnUpdateCustomer.Click += btnUpdateCustomer_Click;
            // 
            // lblIDCustomerToUpdate
            // 
            lblIDCustomerToUpdate.AutoSize = true;
            lblIDCustomerToUpdate.Location = new Point(496, 75);
            lblIDCustomerToUpdate.Name = "lblIDCustomerToUpdate";
            lblIDCustomerToUpdate.Size = new Size(108, 20);
            lblIDCustomerToUpdate.TabIndex = 0;
            lblIDCustomerToUpdate.Text = "הכנס ת.ז. לזיהוי";
            // 
            // tabDeleteCustomer
            // 
            tabDeleteCustomer.Controls.Add(btnDeleteCustomer);
            tabDeleteCustomer.Controls.Add(nudIDtoDeleteCustomer);
            tabDeleteCustomer.Controls.Add(lblIDtoDeleteCustomer);
            tabDeleteCustomer.Location = new Point(4, 29);
            tabDeleteCustomer.Name = "tabDeleteCustomer";
            tabDeleteCustomer.Padding = new Padding(3);
            tabDeleteCustomer.Size = new Size(707, 353);
            tabDeleteCustomer.TabIndex = 2;
            tabDeleteCustomer.Text = "מחיקת לקוח";
            tabDeleteCustomer.UseVisualStyleBackColor = true;
            // 
            // btnDeleteCustomer
            // 
            btnDeleteCustomer.Location = new Point(120, 255);
            btnDeleteCustomer.Name = "btnDeleteCustomer";
            btnDeleteCustomer.Size = new Size(94, 29);
            btnDeleteCustomer.TabIndex = 13;
            btnDeleteCustomer.Text = "למחיקה";
            btnDeleteCustomer.UseVisualStyleBackColor = true;
            btnDeleteCustomer.Click += btnDeleteCustomer_Click_1;
            // 
            // nudIDtoDeleteCustomer
            // 
            nudIDtoDeleteCustomer.Location = new Point(334, 73);
            nudIDtoDeleteCustomer.Maximum = new decimal(new int[] { -727379968, 232, 0, 0 });
            nudIDtoDeleteCustomer.Name = "nudIDtoDeleteCustomer";
            nudIDtoDeleteCustomer.Size = new Size(150, 27);
            nudIDtoDeleteCustomer.TabIndex = 12;
            // 
            // lblIDtoDeleteCustomer
            // 
            lblIDtoDeleteCustomer.AutoSize = true;
            lblIDtoDeleteCustomer.Location = new Point(490, 75);
            lblIDtoDeleteCustomer.Name = "lblIDtoDeleteCustomer";
            lblIDtoDeleteCustomer.Size = new Size(185, 20);
            lblIDtoDeleteCustomer.TabIndex = 11;
            lblIDtoDeleteCustomer.Text = "הכנס ת.ז. למחיקת משתמש";
            // 
            // tabDesineCustomers
            // 
            tabDesineCustomers.AutoScroll = true;
            tabDesineCustomers.Controls.Add(lblReadAllCustomers);
            tabDesineCustomers.Controls.Add(lblReadNew);
            tabDesineCustomers.Controls.Add(nudReadCustomer);
            tabDesineCustomers.Controls.Add(btnRead);
            tabDesineCustomers.Controls.Add(lblReadCustomer);
            tabDesineCustomers.Controls.Add(lblReadAll);
            tabDesineCustomers.Location = new Point(4, 29);
            tabDesineCustomers.Name = "tabDesineCustomers";
            tabDesineCustomers.Padding = new Padding(3);
            tabDesineCustomers.Size = new Size(707, 353);
            tabDesineCustomers.TabIndex = 3;
            tabDesineCustomers.Text = "הצגת לקוחות";
            tabDesineCustomers.UseVisualStyleBackColor = true;
            // 
            // lblReadNew
            // 
            lblReadNew.AutoSize = true;
            lblReadNew.Location = new Point(45, 41);
            lblReadNew.Name = "lblReadNew";
            lblReadNew.Size = new Size(0, 20);
            lblReadNew.TabIndex = 5;
            // 
            // nudReadCustomer
            // 
            nudReadCustomer.Location = new Point(367, 53);
            nudReadCustomer.Maximum = new decimal(new int[] { 1410065408, 2, 0, 0 });
            nudReadCustomer.Name = "nudReadCustomer";
            nudReadCustomer.Size = new Size(150, 27);
            nudReadCustomer.TabIndex = 4;
            // 
            // btnRead
            // 
            btnRead.Location = new Point(560, 107);
            btnRead.Name = "btnRead";
            btnRead.Size = new Size(94, 29);
            btnRead.TabIndex = 3;
            btnRead.Text = "חפש";
            btnRead.UseVisualStyleBackColor = true;
            btnRead.Click += btnRead_Click;
            // 
            // lblReadCustomer
            // 
            lblReadCustomer.AutoSize = true;
            lblReadCustomer.Location = new Point(527, 55);
            lblReadCustomer.Name = "lblReadCustomer";
            lblReadCustomer.Size = new Size(124, 20);
            lblReadCustomer.TabIndex = 1;
            lblReadCustomer.Text = "חפש לקוח לפי ת.ז";
            // 
            // lblReadAll
            // 
            lblReadAll.AutoSize = true;
            lblReadAll.Location = new Point(155, 58);
            lblReadAll.Name = "lblReadAll";
            lblReadAll.Size = new Size(0, 20);
            lblReadAll.TabIndex = 0;
            // 
            // lblReadAllCustomers
            // 
            lblReadAllCustomers.AutoSize = true;
            lblReadAllCustomers.Location = new Point(20, 32);
            lblReadAllCustomers.Name = "lblReadAllCustomers";
            lblReadAllCustomers.Size = new Size(0, 20);
            lblReadAllCustomers.TabIndex = 6;
            // 
            // CustomersMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(products);
            Name = "CustomersMenu";
            Text = "CustomersMenu";
            products.ResumeLayout(false);
            tabAddCustomer.ResumeLayout(false);
            tabAddCustomer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudIDCustomer).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudPhoneCustomer).EndInit();
            tabUpdateCustomer.ResumeLayout(false);
            tabUpdateCustomer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudNewPhoneCustomer).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudIDCustomerToUpdate).EndInit();
            tabDeleteCustomer.ResumeLayout(false);
            tabDeleteCustomer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudIDtoDeleteCustomer).EndInit();
            tabDesineCustomers.ResumeLayout(false);
            tabDesineCustomers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudReadCustomer).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl products;
        private TabPage tabAddCustomer;
        private Button btnAddCustomer;
        private ComboBox cbxCategory;
        private NumericUpDown nudPhoneCustomer;
        private NumericUpDown nudPrice;
        private TextBox tbxNameCustomer;
        private Label lblPhoneCustomer;
        private Label lblCategory;
        private Label lblPrice;
        private Label lblNameCustomer;
        private TabPage tabUpdateCustomer;
        private NumericUpDown nudNewPhoneCustomer;
        private ComboBox cbxNewCategory;
        private NumericUpDown nudNewQuantityInStock;
        private NumericUpDown nudIDCustomerToUpdate;
        private NumericUpDown nudNewPrice;
        private TextBox txtNewNameCustomer;
        private Label lblNewQuantityInStock;
        private Label lblNewCategory;
        private Label lblNewPrice;
        private Label lblNewNameCustomer;
        private Button btnUpdateCustomer;
        private Label lblIDCustomerToUpdate;
        private TabPage tabDeleteCustomer;
        private Button btnDeleteCustomer;
        private NumericUpDown nudIDtoDeleteCustomer;
        private Label lblIDtoDeleteCustomer;
        private TabPage tabDesineCustomers;
        private Label lblReadNew;
        private NumericUpDown nudReadCustomer;
        private Button btnRead;
        private Label lblReadCustomer;
        private Label lblReadAll;
        private TextBox txtAddressCustomer;
        private Label lblAddressCustomer;
        private TextBox txtNewAddressCustomer;
        private Label lblNewPhoneCustomer;
        private Label lblNewAddressCustomer;
        private Label lblDCustomer;
        private NumericUpDown nudIDCustomer;
        private Label lblReadAllCustomers;
    }
}