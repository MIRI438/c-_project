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
            lblReadAllCustomers = new Label();
            lblReadNew = new Label();
            nudReadCustomer = new NumericUpDown();
            btnRead = new Button();
            lblReadCustomer = new Label();
            lblReadAll = new Label();
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
            products.Location = new Point(38, 24);
            products.Margin = new Padding(3, 2, 3, 2);
            products.Name = "products";
            products.RightToLeft = RightToLeft.No;
            products.RightToLeftLayout = true;
            products.SelectedIndex = 0;
            products.Size = new Size(1091, 559);
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
            tabAddCustomer.Location = new Point(4, 24);
            tabAddCustomer.Margin = new Padding(3, 2, 3, 2);
            tabAddCustomer.Name = "tabAddCustomer";
            tabAddCustomer.Padding = new Padding(3, 2, 3, 2);
            tabAddCustomer.RightToLeft = RightToLeft.Yes;
            tabAddCustomer.Size = new Size(1083, 531);
            tabAddCustomer.TabIndex = 0;
            tabAddCustomer.Text = "הוספת לקוח";
            tabAddCustomer.UseVisualStyleBackColor = true;
            // 
            // txtAddressCustomer
            // 
            txtAddressCustomer.Location = new Point(675, 162);
            txtAddressCustomer.Margin = new Padding(3, 2, 3, 2);
            txtAddressCustomer.Name = "txtAddressCustomer";
            txtAddressCustomer.Size = new Size(133, 23);
            txtAddressCustomer.TabIndex = 6;
            // 
            // lblAddressCustomer
            // 
            lblAddressCustomer.AutoSize = true;
            lblAddressCustomer.Location = new Point(815, 164);
            lblAddressCustomer.Name = "lblAddressCustomer";
            lblAddressCustomer.Size = new Size(42, 15);
            lblAddressCustomer.TabIndex = 5;
            lblAddressCustomer.Text = "כתובת";
            // 
            // btnAddCustomer
            // 
            btnAddCustomer.Location = new Point(514, 345);
            btnAddCustomer.Margin = new Padding(3, 2, 3, 2);
            btnAddCustomer.Name = "btnAddCustomer";
            btnAddCustomer.Size = new Size(82, 22);
            btnAddCustomer.TabIndex = 4;
            btnAddCustomer.Text = "הוספה";
            btnAddCustomer.UseVisualStyleBackColor = true;
            btnAddCustomer.Click += btnAddCustomer_Click;
            // 
            // nudIDCustomer
            // 
            nudIDCustomer.Location = new Point(675, 95);
            nudIDCustomer.Margin = new Padding(3, 2, 3, 2);
            nudIDCustomer.Maximum = new decimal(new int[] { -727379968, 232, 0, 0 });
            nudIDCustomer.Name = "nudIDCustomer";
            nudIDCustomer.Size = new Size(131, 23);
            nudIDCustomer.TabIndex = 2;
            // 
            // nudPhoneCustomer
            // 
            nudPhoneCustomer.Location = new Point(675, 199);
            nudPhoneCustomer.Margin = new Padding(3, 2, 3, 2);
            nudPhoneCustomer.Maximum = new decimal(new int[] { -727379968, 232, 0, 0 });
            nudPhoneCustomer.Name = "nudPhoneCustomer";
            nudPhoneCustomer.Size = new Size(131, 23);
            nudPhoneCustomer.TabIndex = 2;
            // 
            // tbxNameCustomer
            // 
            tbxNameCustomer.Location = new Point(675, 128);
            tbxNameCustomer.Margin = new Padding(3, 2, 3, 2);
            tbxNameCustomer.Name = "tbxNameCustomer";
            tbxNameCustomer.Size = new Size(133, 23);
            tbxNameCustomer.TabIndex = 1;
            // 
            // lblDCustomer
            // 
            lblDCustomer.AutoSize = true;
            lblDCustomer.Location = new Point(815, 97);
            lblDCustomer.Name = "lblDCustomer";
            lblDCustomer.Size = new Size(68, 15);
            lblDCustomer.TabIndex = 0;
            lblDCustomer.Text = "תעודת זהות";
            // 
            // lblPhoneCustomer
            // 
            lblPhoneCustomer.AutoSize = true;
            lblPhoneCustomer.Location = new Point(811, 200);
            lblPhoneCustomer.Name = "lblPhoneCustomer";
            lblPhoneCustomer.Size = new Size(78, 15);
            lblPhoneCustomer.TabIndex = 0;
            lblPhoneCustomer.Text = "מספר פלאפון";
            // 
            // lblNameCustomer
            // 
            lblNameCustomer.AutoSize = true;
            lblNameCustomer.Location = new Point(815, 130);
            lblNameCustomer.Name = "lblNameCustomer";
            lblNameCustomer.Size = new Size(53, 15);
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
            tabUpdateCustomer.Location = new Point(4, 24);
            tabUpdateCustomer.Margin = new Padding(3, 2, 3, 2);
            tabUpdateCustomer.Name = "tabUpdateCustomer";
            tabUpdateCustomer.Padding = new Padding(3, 2, 3, 2);
            tabUpdateCustomer.Size = new Size(1083, 531);
            tabUpdateCustomer.TabIndex = 1;
            tabUpdateCustomer.Text = "עדכון לקוח";
            tabUpdateCustomer.UseVisualStyleBackColor = true;
            // 
            // nudNewPhoneCustomer
            // 
            nudNewPhoneCustomer.Location = new Point(668, 212);
            nudNewPhoneCustomer.Margin = new Padding(3, 2, 3, 2);
            nudNewPhoneCustomer.Maximum = new decimal(new int[] { -727379968, 232, 0, 0 });
            nudNewPhoneCustomer.Name = "nudNewPhoneCustomer";
            nudNewPhoneCustomer.Size = new Size(131, 23);
            nudNewPhoneCustomer.TabIndex = 12;
            // 
            // lblNewPhoneCustomer
            // 
            lblNewPhoneCustomer.AutoSize = true;
            lblNewPhoneCustomer.Location = new Point(809, 214);
            lblNewPhoneCustomer.Name = "lblNewPhoneCustomer";
            lblNewPhoneCustomer.Size = new Size(104, 15);
            lblNewPhoneCustomer.TabIndex = 11;
            lblNewPhoneCustomer.Text = "מספר פלאפון חדש";
            // 
            // lblNewAddressCustomer
            // 
            lblNewAddressCustomer.AutoSize = true;
            lblNewAddressCustomer.Location = new Point(809, 180);
            lblNewAddressCustomer.Name = "lblNewAddressCustomer";
            lblNewAddressCustomer.Size = new Size(76, 15);
            lblNewAddressCustomer.TabIndex = 11;
            lblNewAddressCustomer.Text = "כתובת חדשה";
            // 
            // nudIDCustomerToUpdate
            // 
            nudIDCustomerToUpdate.Location = new Point(667, 113);
            nudIDCustomerToUpdate.Margin = new Padding(3, 2, 3, 2);
            nudIDCustomerToUpdate.Maximum = new decimal(new int[] { -727379968, 232, 0, 0 });
            nudIDCustomerToUpdate.Name = "nudIDCustomerToUpdate";
            nudIDCustomerToUpdate.Size = new Size(131, 23);
            nudIDCustomerToUpdate.TabIndex = 10;
            // 
            // txtNewAddressCustomer
            // 
            txtNewAddressCustomer.Location = new Point(666, 177);
            txtNewAddressCustomer.Margin = new Padding(3, 2, 3, 2);
            txtNewAddressCustomer.Name = "txtNewAddressCustomer";
            txtNewAddressCustomer.Size = new Size(133, 23);
            txtNewAddressCustomer.TabIndex = 8;
            // 
            // txtNewNameCustomer
            // 
            txtNewNameCustomer.Location = new Point(667, 143);
            txtNewNameCustomer.Margin = new Padding(3, 2, 3, 2);
            txtNewNameCustomer.Name = "txtNewNameCustomer";
            txtNewNameCustomer.Size = new Size(133, 23);
            txtNewNameCustomer.TabIndex = 8;
            // 
            // lblNewNameCustomer
            // 
            lblNewNameCustomer.AutoSize = true;
            lblNewNameCustomer.Location = new Point(807, 145);
            lblNewNameCustomer.Name = "lblNewNameCustomer";
            lblNewNameCustomer.Size = new Size(50, 15);
            lblNewNameCustomer.TabIndex = 7;
            lblNewNameCustomer.Text = "שם חדש";
            // 
            // btnUpdateCustomer
            // 
            btnUpdateCustomer.Location = new Point(534, 350);
            btnUpdateCustomer.Margin = new Padding(3, 2, 3, 2);
            btnUpdateCustomer.Name = "btnUpdateCustomer";
            btnUpdateCustomer.Size = new Size(82, 22);
            btnUpdateCustomer.TabIndex = 2;
            btnUpdateCustomer.Text = "עדכון";
            btnUpdateCustomer.UseVisualStyleBackColor = true;
            btnUpdateCustomer.Click += btnUpdateCustomer_Click;
            // 
            // lblIDCustomerToUpdate
            // 
            lblIDCustomerToUpdate.AutoSize = true;
            lblIDCustomerToUpdate.Location = new Point(809, 114);
            lblIDCustomerToUpdate.Name = "lblIDCustomerToUpdate";
            lblIDCustomerToUpdate.Size = new Size(88, 15);
            lblIDCustomerToUpdate.TabIndex = 0;
            lblIDCustomerToUpdate.Text = "הכנס ת.ז. לזיהוי";
            // 
            // tabDeleteCustomer
            // 
            tabDeleteCustomer.Controls.Add(btnDeleteCustomer);
            tabDeleteCustomer.Controls.Add(nudIDtoDeleteCustomer);
            tabDeleteCustomer.Controls.Add(lblIDtoDeleteCustomer);
            tabDeleteCustomer.Location = new Point(4, 24);
            tabDeleteCustomer.Margin = new Padding(3, 2, 3, 2);
            tabDeleteCustomer.Name = "tabDeleteCustomer";
            tabDeleteCustomer.Padding = new Padding(3, 2, 3, 2);
            tabDeleteCustomer.Size = new Size(1083, 531);
            tabDeleteCustomer.TabIndex = 2;
            tabDeleteCustomer.Text = "מחיקת לקוח";
            tabDeleteCustomer.UseVisualStyleBackColor = true;
            // 
            // btnDeleteCustomer
            // 
            btnDeleteCustomer.Location = new Point(526, 345);
            btnDeleteCustomer.Margin = new Padding(3, 2, 3, 2);
            btnDeleteCustomer.Name = "btnDeleteCustomer";
            btnDeleteCustomer.Size = new Size(82, 22);
            btnDeleteCustomer.TabIndex = 13;
            btnDeleteCustomer.Text = "למחיקה";
            btnDeleteCustomer.UseVisualStyleBackColor = true;
            btnDeleteCustomer.Click += btnDeleteCustomer_Click_1;
            // 
            // nudIDtoDeleteCustomer
            // 
            nudIDtoDeleteCustomer.Location = new Point(596, 141);
            nudIDtoDeleteCustomer.Margin = new Padding(3, 2, 3, 2);
            nudIDtoDeleteCustomer.Maximum = new decimal(new int[] { -727379968, 232, 0, 0 });
            nudIDtoDeleteCustomer.Name = "nudIDtoDeleteCustomer";
            nudIDtoDeleteCustomer.Size = new Size(131, 23);
            nudIDtoDeleteCustomer.TabIndex = 12;
            // 
            // lblIDtoDeleteCustomer
            // 
            lblIDtoDeleteCustomer.AutoSize = true;
            lblIDtoDeleteCustomer.Location = new Point(733, 142);
            lblIDtoDeleteCustomer.Name = "lblIDtoDeleteCustomer";
            lblIDtoDeleteCustomer.Size = new Size(149, 15);
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
            tabDesineCustomers.Location = new Point(4, 24);
            tabDesineCustomers.Margin = new Padding(3, 2, 3, 2);
            tabDesineCustomers.Name = "tabDesineCustomers";
            tabDesineCustomers.Padding = new Padding(3, 2, 3, 2);
            tabDesineCustomers.Size = new Size(1083, 531);
            tabDesineCustomers.TabIndex = 3;
            tabDesineCustomers.Text = "הצגת לקוחות";
            tabDesineCustomers.UseVisualStyleBackColor = true;
            // 
            // lblReadAllCustomers
            // 
            lblReadAllCustomers.AutoSize = true;
            lblReadAllCustomers.Location = new Point(18, 24);
            lblReadAllCustomers.Name = "lblReadAllCustomers";
            lblReadAllCustomers.Size = new Size(0, 15);
            lblReadAllCustomers.TabIndex = 6;
            // 
            // lblReadNew
            // 
            lblReadNew.AutoSize = true;
            lblReadNew.Location = new Point(39, 31);
            lblReadNew.Name = "lblReadNew";
            lblReadNew.Size = new Size(0, 15);
            lblReadNew.TabIndex = 5;
            // 
            // nudReadCustomer
            // 
            nudReadCustomer.Location = new Point(577, 121);
            nudReadCustomer.Margin = new Padding(3, 2, 3, 2);
            nudReadCustomer.Maximum = new decimal(new int[] { 1410065408, 2, 0, 0 });
            nudReadCustomer.Name = "nudReadCustomer";
            nudReadCustomer.Size = new Size(131, 23);
            nudReadCustomer.TabIndex = 4;
            // 
            // btnRead
            // 
            btnRead.Location = new Point(532, 315);
            btnRead.Margin = new Padding(3, 2, 3, 2);
            btnRead.Name = "btnRead";
            btnRead.Size = new Size(82, 22);
            btnRead.TabIndex = 3;
            btnRead.Text = "חפש";
            btnRead.UseVisualStyleBackColor = true;
            btnRead.Click += btnRead_Click;
            // 
            // lblReadCustomer
            // 
            lblReadCustomer.AutoSize = true;
            lblReadCustomer.Location = new Point(717, 122);
            lblReadCustomer.Name = "lblReadCustomer";
            lblReadCustomer.Size = new Size(101, 15);
            lblReadCustomer.TabIndex = 1;
            lblReadCustomer.Text = "חפש לקוח לפי ת.ז";
            // 
            // lblReadAll
            // 
            lblReadAll.AutoSize = true;
            lblReadAll.Location = new Point(136, 44);
            lblReadAll.Name = "lblReadAll";
            lblReadAll.Size = new Size(0, 15);
            lblReadAll.TabIndex = 0;
            // 
            // CustomersMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1181, 612);
            Controls.Add(products);
            Margin = new Padding(3, 2, 3, 2);
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