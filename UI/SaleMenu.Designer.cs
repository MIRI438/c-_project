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
            lblEndSale = new Label();
            dtEndSale = new DateTimePicker();
            dtBeginSale = new DateTimePicker();
            lblBeginSale = new Label();
            rbtnNoInClub = new RadioButton();
            rbtYesInClub = new RadioButton();
            lblInClub = new Label();
            nudPriceSale = new NumericUpDown();
            lblPriceSale = new Label();
            nudProductId = new NumericUpDown();
            btnAddSale = new Button();
            nudMinQuantity = new NumericUpDown();
            lblMinQuantity = new Label();
            lblProductIdForSale = new Label();
            tabUpdateSale = new TabPage();
            nudCodeSaleToUpdate = new NumericUpDown();
            lblCodeSaleToUpdate = new Label();
            lblNewEndSale = new Label();
            dtNewEndSale = new DateTimePicker();
            dtNewStartSale = new DateTimePicker();
            lblNewStartSale = new Label();
            rbtnNewNo = new RadioButton();
            rbtnNewYes = new RadioButton();
            lblNewInClub = new Label();
            nudNewPriceSale = new NumericUpDown();
            lblNewPriceSale = new Label();
            nudNewMinQantity = new NumericUpDown();
            lblNewMinQentity = new Label();
            nudProductIDtoUpdate = new NumericUpDown();
            btnUpdateSale = new Button();
            lblProductIDtOUpdate = new Label();
            tabDeleteSale = new TabPage();
            btnDeleteSale = new Button();
            nudCodetoDelete = new NumericUpDown();
            lblCodetoDelete = new Label();
            tabDesineSales = new TabPage();
            lblRadAllSales = new Label();
            lblReadAllCustomers = new Label();
            lblReadNew = new Label();
            nudReadCodeSale = new NumericUpDown();
            btnReadSale = new Button();
            lblReadCodeSale = new Label();
            lblReadAll = new Label();
            products.SuspendLayout();
            tabAddSale.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudPriceSale).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudProductId).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudMinQuantity).BeginInit();
            tabUpdateSale.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudCodeSaleToUpdate).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudNewPriceSale).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudNewMinQantity).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudProductIDtoUpdate).BeginInit();
            tabDeleteSale.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudCodetoDelete).BeginInit();
            tabDesineSales.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudReadCodeSale).BeginInit();
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
            tabAddSale.Controls.Add(lblEndSale);
            tabAddSale.Controls.Add(dtEndSale);
            tabAddSale.Controls.Add(dtBeginSale);
            tabAddSale.Controls.Add(lblBeginSale);
            tabAddSale.Controls.Add(rbtnNoInClub);
            tabAddSale.Controls.Add(rbtYesInClub);
            tabAddSale.Controls.Add(lblInClub);
            tabAddSale.Controls.Add(nudPriceSale);
            tabAddSale.Controls.Add(lblPriceSale);
            tabAddSale.Controls.Add(nudProductId);
            tabAddSale.Controls.Add(btnAddSale);
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
            // lblEndSale
            // 
            lblEndSale.AutoSize = true;
            lblEndSale.Location = new Point(515, 255);
            lblEndSale.Name = "lblEndSale";
            lblEndSale.Size = new Size(139, 20);
            lblEndSale.TabIndex = 13;
            lblEndSale.Text = "תאריך אחרון למבצע";
            // 
            // dtEndSale
            // 
            dtEndSale.Location = new Point(268, 250);
            dtEndSale.Name = "dtEndSale";
            dtEndSale.Size = new Size(238, 27);
            dtEndSale.TabIndex = 12;
            // 
            // dtBeginSale
            // 
            dtBeginSale.Location = new Point(267, 205);
            dtBeginSale.Name = "dtBeginSale";
            dtBeginSale.Size = new Size(238, 27);
            dtBeginSale.TabIndex = 11;
            // 
            // lblBeginSale
            // 
            lblBeginSale.AutoSize = true;
            lblBeginSale.Location = new Point(515, 205);
            lblBeginSale.Name = "lblBeginSale";
            lblBeginSale.Size = new Size(155, 20);
            lblBeginSale.TabIndex = 10;
            lblBeginSale.Text = "תאריך התחלת המבצע";
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
            // lblInClub
            // 
            lblInClub.AutoSize = true;
            lblInClub.Location = new Point(515, 163);
            lblInClub.Name = "lblInClub";
            lblInClub.Size = new Size(159, 20);
            lblInClub.TabIndex = 8;
            lblInClub.Text = "המבצע רק לחבר מועדון";
            // 
            // nudPriceSale
            // 
            nudPriceSale.Location = new Point(356, 122);
            nudPriceSale.Maximum = new decimal(new int[] { 276447232, 23283, 0, 0 });
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
            // nudProductId
            // 
            nudProductId.Location = new Point(355, 35);
            nudProductId.Maximum = new decimal(new int[] { -727379968, 232, 0, 0 });
            nudProductId.Name = "nudProductId";
            nudProductId.Size = new Size(150, 27);
            nudProductId.TabIndex = 5;
            // 
            // btnAddSale
            // 
            btnAddSale.Location = new Point(98, 264);
            btnAddSale.Name = "btnAddSale";
            btnAddSale.Size = new Size(94, 29);
            btnAddSale.TabIndex = 4;
            btnAddSale.Text = "הוספה";
            btnAddSale.UseVisualStyleBackColor = true;
            btnAddSale.Click += btnAddSale_Click;
            // 
            // nudMinQuantity
            // 
            nudMinQuantity.Location = new Point(356, 76);
            nudMinQuantity.Maximum = new decimal(new int[] { 1410065408, 2, 0, 0 });
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
            tabUpdateSale.Controls.Add(nudCodeSaleToUpdate);
            tabUpdateSale.Controls.Add(lblCodeSaleToUpdate);
            tabUpdateSale.Controls.Add(lblNewEndSale);
            tabUpdateSale.Controls.Add(dtNewEndSale);
            tabUpdateSale.Controls.Add(dtNewStartSale);
            tabUpdateSale.Controls.Add(lblNewStartSale);
            tabUpdateSale.Controls.Add(rbtnNewNo);
            tabUpdateSale.Controls.Add(rbtnNewYes);
            tabUpdateSale.Controls.Add(lblNewInClub);
            tabUpdateSale.Controls.Add(nudNewPriceSale);
            tabUpdateSale.Controls.Add(lblNewPriceSale);
            tabUpdateSale.Controls.Add(nudNewMinQantity);
            tabUpdateSale.Controls.Add(lblNewMinQentity);
            tabUpdateSale.Controls.Add(nudProductIDtoUpdate);
            tabUpdateSale.Controls.Add(btnUpdateSale);
            tabUpdateSale.Controls.Add(lblProductIDtOUpdate);
            tabUpdateSale.Location = new Point(4, 29);
            tabUpdateSale.Name = "tabUpdateSale";
            tabUpdateSale.Padding = new Padding(3);
            tabUpdateSale.Size = new Size(707, 353);
            tabUpdateSale.TabIndex = 1;
            tabUpdateSale.Text = "עדכון מבצע";
            tabUpdateSale.UseVisualStyleBackColor = true;
            // 
            // nudCodeSaleToUpdate
            // 
            nudCodeSaleToUpdate.Location = new Point(346, 25);
            nudCodeSaleToUpdate.Maximum = new decimal(new int[] { -727379968, 232, 0, 0 });
            nudCodeSaleToUpdate.Name = "nudCodeSaleToUpdate";
            nudCodeSaleToUpdate.Size = new Size(150, 27);
            nudCodeSaleToUpdate.TabIndex = 26;
            // 
            // lblCodeSaleToUpdate
            // 
            lblCodeSaleToUpdate.AutoSize = true;
            lblCodeSaleToUpdate.Location = new Point(506, 27);
            lblCodeSaleToUpdate.Name = "lblCodeSaleToUpdate";
            lblCodeSaleToUpdate.Size = new Size(103, 20);
            lblCodeSaleToUpdate.TabIndex = 25;
            lblCodeSaleToUpdate.Text = "קוד מבצע קיים";
            // 
            // lblNewEndSale
            // 
            lblNewEndSale.AutoSize = true;
            lblNewEndSale.Location = new Point(505, 295);
            lblNewEndSale.Name = "lblNewEndSale";
            lblNewEndSale.Size = new Size(139, 20);
            lblNewEndSale.TabIndex = 24;
            lblNewEndSale.Text = "תאריך אחרון למבצע";
            // 
            // dtNewEndSale
            // 
            dtNewEndSale.Location = new Point(258, 290);
            dtNewEndSale.Name = "dtNewEndSale";
            dtNewEndSale.Size = new Size(238, 27);
            dtNewEndSale.TabIndex = 23;
            // 
            // dtNewStartSale
            // 
            dtNewStartSale.Location = new Point(257, 245);
            dtNewStartSale.Name = "dtNewStartSale";
            dtNewStartSale.Size = new Size(238, 27);
            dtNewStartSale.TabIndex = 22;
            // 
            // lblNewStartSale
            // 
            lblNewStartSale.AutoSize = true;
            lblNewStartSale.Location = new Point(505, 245);
            lblNewStartSale.Name = "lblNewStartSale";
            lblNewStartSale.Size = new Size(155, 20);
            lblNewStartSale.TabIndex = 21;
            lblNewStartSale.Text = "תאריך התחלת המבצע";
            // 
            // rbtnNewNo
            // 
            rbtnNewNo.AutoSize = true;
            rbtnNewNo.Location = new Point(448, 203);
            rbtnNewNo.Name = "rbtnNewNo";
            rbtnNewNo.Size = new Size(48, 24);
            rbtnNewNo.TabIndex = 19;
            rbtnNewNo.TabStop = true;
            rbtnNewNo.Text = "לא";
            rbtnNewNo.UseVisualStyleBackColor = true;
            // 
            // rbtnNewYes
            // 
            rbtnNewYes.AutoSize = true;
            rbtnNewYes.Location = new Point(345, 203);
            rbtnNewYes.Name = "rbtnNewYes";
            rbtnNewYes.Size = new Size(42, 24);
            rbtnNewYes.TabIndex = 20;
            rbtnNewYes.TabStop = true;
            rbtnNewYes.Text = "כן";
            rbtnNewYes.UseVisualStyleBackColor = true;
            // 
            // lblNewInClub
            // 
            lblNewInClub.AutoSize = true;
            lblNewInClub.Location = new Point(505, 203);
            lblNewInClub.Name = "lblNewInClub";
            lblNewInClub.Size = new Size(159, 20);
            lblNewInClub.TabIndex = 18;
            lblNewInClub.Text = "המבצע רק לחבר מועדון";
            // 
            // nudNewPriceSale
            // 
            nudNewPriceSale.Location = new Point(346, 162);
            nudNewPriceSale.Maximum = new decimal(new int[] { -1530494976, 232830, 0, 0 });
            nudNewPriceSale.Name = "nudNewPriceSale";
            nudNewPriceSale.Size = new Size(150, 27);
            nudNewPriceSale.TabIndex = 17;
            // 
            // lblNewPriceSale
            // 
            lblNewPriceSale.AutoSize = true;
            lblNewPriceSale.Location = new Point(505, 167);
            lblNewPriceSale.Name = "lblNewPriceSale";
            lblNewPriceSale.Size = new Size(82, 20);
            lblNewPriceSale.TabIndex = 16;
            lblNewPriceSale.Text = "מחיר מבצע";
            // 
            // nudNewMinQantity
            // 
            nudNewMinQantity.Location = new Point(346, 116);
            nudNewMinQantity.Maximum = new decimal(new int[] { 1316134912, 2328, 0, 0 });
            nudNewMinQantity.Name = "nudNewMinQantity";
            nudNewMinQantity.Size = new Size(150, 27);
            nudNewMinQantity.TabIndex = 15;
            // 
            // lblNewMinQentity
            // 
            lblNewMinQentity.AutoSize = true;
            lblNewMinQentity.Location = new Point(505, 121);
            lblNewMinQentity.Name = "lblNewMinQentity";
            lblNewMinQentity.Size = new Size(148, 20);
            lblNewMinQentity.TabIndex = 14;
            lblNewMinQentity.Text = "כמות מנימלית למבצע";
            // 
            // nudProductIDtoUpdate
            // 
            nudProductIDtoUpdate.Location = new Point(346, 70);
            nudProductIDtoUpdate.Maximum = new decimal(new int[] { -727379968, 232, 0, 0 });
            nudProductIDtoUpdate.Name = "nudProductIDtoUpdate";
            nudProductIDtoUpdate.Size = new Size(150, 27);
            nudProductIDtoUpdate.TabIndex = 10;
            nudProductIDtoUpdate.ValueChanged += nudProductIDtoUpdate_ValueChanged;
            // 
            // btnUpdateSale
            // 
            btnUpdateSale.Location = new Point(76, 266);
            btnUpdateSale.Name = "btnUpdateSale";
            btnUpdateSale.Size = new Size(94, 29);
            btnUpdateSale.TabIndex = 2;
            btnUpdateSale.Text = "עדכון";
            btnUpdateSale.UseVisualStyleBackColor = true;
            btnUpdateSale.Click += btnUpdateSale_Click;
            // 
            // lblProductIDtOUpdate
            // 
            lblProductIDtOUpdate.AutoSize = true;
            lblProductIDtOUpdate.Location = new Point(506, 72);
            lblProductIDtOUpdate.Name = "lblProductIDtOUpdate";
            lblProductIDtOUpdate.Size = new Size(65, 20);
            lblProductIDtOUpdate.TabIndex = 0;
            lblProductIDtOUpdate.Text = "קוד מוצר";
            lblProductIDtOUpdate.Click += lblProductIDtOUpdate_Click;
            // 
            // tabDeleteSale
            // 
            tabDeleteSale.Controls.Add(btnDeleteSale);
            tabDeleteSale.Controls.Add(nudCodetoDelete);
            tabDeleteSale.Controls.Add(lblCodetoDelete);
            tabDeleteSale.Location = new Point(4, 29);
            tabDeleteSale.Name = "tabDeleteSale";
            tabDeleteSale.Padding = new Padding(3);
            tabDeleteSale.Size = new Size(707, 353);
            tabDeleteSale.TabIndex = 2;
            tabDeleteSale.Text = "מחיקת מבצע";
            tabDeleteSale.UseVisualStyleBackColor = true;
            // 
            // btnDeleteSale
            // 
            btnDeleteSale.Location = new Point(120, 255);
            btnDeleteSale.Name = "btnDeleteSale";
            btnDeleteSale.Size = new Size(94, 29);
            btnDeleteSale.TabIndex = 13;
            btnDeleteSale.Text = "למחיקה";
            btnDeleteSale.UseVisualStyleBackColor = true;
            btnDeleteSale.Click += btnDeleteSale_Click;
            // 
            // nudCodetoDelete
            // 
            nudCodetoDelete.Location = new Point(334, 73);
            nudCodetoDelete.Maximum = new decimal(new int[] { -727379968, 232, 0, 0 });
            nudCodetoDelete.Name = "nudCodetoDelete";
            nudCodetoDelete.Size = new Size(150, 27);
            nudCodetoDelete.TabIndex = 12;
            // 
            // lblCodetoDelete
            // 
            lblCodetoDelete.AutoSize = true;
            lblCodetoDelete.Location = new Point(507, 78);
            lblCodetoDelete.Name = "lblCodetoDelete";
            lblCodetoDelete.Size = new Size(113, 20);
            lblCodetoDelete.TabIndex = 11;
            lblCodetoDelete.Text = "הכנס קוד מבצע ";
            // 
            // tabDesineSales
            // 
            tabDesineSales.AutoScroll = true;
            tabDesineSales.Controls.Add(lblRadAllSales);
            tabDesineSales.Controls.Add(lblReadAllCustomers);
            tabDesineSales.Controls.Add(lblReadNew);
            tabDesineSales.Controls.Add(nudReadCodeSale);
            tabDesineSales.Controls.Add(btnReadSale);
            tabDesineSales.Controls.Add(lblReadCodeSale);
            tabDesineSales.Controls.Add(lblReadAll);
            tabDesineSales.Location = new Point(4, 29);
            tabDesineSales.Name = "tabDesineSales";
            tabDesineSales.Padding = new Padding(3);
            tabDesineSales.Size = new Size(707, 353);
            tabDesineSales.TabIndex = 3;
            tabDesineSales.Text = "הצגת מבצעים";
            tabDesineSales.UseVisualStyleBackColor = true;
            // 
            // lblRadAllSales
            // 
            lblRadAllSales.AutoSize = true;
            lblRadAllSales.Location = new Point(43, 35);
            lblRadAllSales.Name = "lblRadAllSales";
            lblRadAllSales.Size = new Size(0, 20);
            lblRadAllSales.TabIndex = 7;
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
            // nudReadCodeSale
            // 
            nudReadCodeSale.Location = new Point(371, 51);
            nudReadCodeSale.Maximum = new decimal(new int[] { 1410065408, 2, 0, 0 });
            nudReadCodeSale.Name = "nudReadCodeSale";
            nudReadCodeSale.Size = new Size(150, 27);
            nudReadCodeSale.TabIndex = 4;
            // 
            // btnReadSale
            // 
            btnReadSale.Location = new Point(560, 107);
            btnReadSale.Name = "btnReadSale";
            btnReadSale.Size = new Size(94, 29);
            btnReadSale.TabIndex = 3;
            btnReadSale.Text = "חפש";
            btnReadSale.UseVisualStyleBackColor = true;
            btnReadSale.Click += btnReadSale_Click;
            // 
            // lblReadCodeSale
            // 
            lblReadCodeSale.AutoSize = true;
            lblReadCodeSale.Location = new Point(527, 53);
            lblReadCodeSale.Name = "lblReadCodeSale";
            lblReadCodeSale.Size = new Size(131, 20);
            lblReadCodeSale.TabIndex = 1;
            lblReadCodeSale.Text = "חפש לפי קוד מבצע";
            // 
            // lblReadAll
            // 
            lblReadAll.AutoSize = true;
            lblReadAll.Location = new Point(155, 58);
            lblReadAll.Name = "lblReadAll";
            lblReadAll.Size = new Size(0, 20);
            lblReadAll.TabIndex = 0;
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
            ((System.ComponentModel.ISupportInitialize)nudPriceSale).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudProductId).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudMinQuantity).EndInit();
            tabUpdateSale.ResumeLayout(false);
            tabUpdateSale.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudCodeSaleToUpdate).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudNewPriceSale).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudNewMinQantity).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudProductIDtoUpdate).EndInit();
            tabDeleteSale.ResumeLayout(false);
            tabDeleteSale.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudCodetoDelete).EndInit();
            tabDesineSales.ResumeLayout(false);
            tabDesineSales.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudReadCodeSale).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl products;
        private TabPage tabAddSale;
        private Button btnAddSale;
        private NumericUpDown nudMinQuantity;
        private Label lblMinQuantity;
        private Label lblProductIdForSale;
        private TabPage tabUpdateSale;
        private NumericUpDown nudProductIDtoUpdate;
        private Button btnUpdateSale;
        private Label lblProductIDtOUpdate;
        private TabPage tabDeleteSale;
        private Button btnDeleteSale;
        private NumericUpDown nudCodetoDelete;
        private Label lblCodetoDelete;
        private TabPage tabDesineSales;
        private Label lblReadAllCustomers;
        private Label lblReadNew;
        private NumericUpDown nudReadCodeSale;
        private Button btnReadSale;
        private Label lblReadCodeSale;
        private Label lblReadAll;
        private NumericUpDown nudProductId;
        private NumericUpDown nudPriceSale;
        private Label lblPriceSale;
        private RadioButton rbtnNoInClub;
        private RadioButton rbtYesInClub;
        private Label lblInClub;
        private Label lblEndSale;
        private DateTimePicker dtEndSale;
        private DateTimePicker dtBeginSale;
        private Label lblBeginSale;
        private Label lblNewEndSale;
        private DateTimePicker dtNewEndSale;
        private DateTimePicker dtNewStartSale;
        private Label lblNewStartSale;
        private RadioButton rbtnNewNo;
        private RadioButton rbtnNewYes;
        private Label lblNewInClub;
        private NumericUpDown nudNewPriceSale;
        private Label lblNewPriceSale;
        private NumericUpDown nudNewMinQantity;
        private Label lblNewMinQentity;
        private NumericUpDown nudCodeSaleToUpdate;
        private Label lblCodeSaleToUpdate;
        private Label lblRadAllSales;
    }
}