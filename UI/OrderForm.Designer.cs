namespace UI
{
    partial class OrderForm
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
            lblProductIDtoOrder = new Label();
            nudAmountToOrder = new NumericUpDown();
            lblAmountToOrder = new Label();
            btnAddToBag = new Button();
            lblTotalPrice = new Label();
            label1 = new Label();
            btnPay = new Button();
            txtNameToAdd = new TextBox();
            lblHello = new Label();
            ((System.ComponentModel.ISupportInitialize)nudAmountToOrder).BeginInit();
            SuspendLayout();
            // 
            // lblProductIDtoOrder
            // 
            lblProductIDtoOrder.AutoSize = true;
            lblProductIDtoOrder.Location = new Point(946, 149);
            lblProductIDtoOrder.Name = "lblProductIDtoOrder";
            lblProductIDtoOrder.Size = new Size(83, 15);
            lblProductIDtoOrder.TabIndex = 1;
            lblProductIDtoOrder.Text = "הכנס שם מוצר";
            // 
            // nudAmountToOrder
            // 
            nudAmountToOrder.Location = new Point(810, 179);
            nudAmountToOrder.Maximum = new decimal(new int[] { 276447232, 23283, 0, 0 });
            nudAmountToOrder.Name = "nudAmountToOrder";
            nudAmountToOrder.Size = new Size(120, 23);
            nudAmountToOrder.TabIndex = 4;
            // 
            // lblAmountToOrder
            // 
            lblAmountToOrder.AutoSize = true;
            lblAmountToOrder.Location = new Point(946, 181);
            lblAmountToOrder.Name = "lblAmountToOrder";
            lblAmountToOrder.Size = new Size(59, 15);
            lblAmountToOrder.TabIndex = 3;
            lblAmountToOrder.Text = "בחר כמות";
            // 
            // btnAddToBag
            // 
            btnAddToBag.Location = new Point(933, 241);
            btnAddToBag.Name = "btnAddToBag";
            btnAddToBag.Size = new Size(96, 23);
            btnAddToBag.TabIndex = 5;
            btnAddToBag.Text = "הוסף לעגלה";
            btnAddToBag.UseVisualStyleBackColor = true;
            btnAddToBag.Click += btnAddToBag_Click;
            // 
            // lblTotalPrice
            // 
            lblTotalPrice.AutoSize = true;
            lblTotalPrice.Location = new Point(309, 541);
            lblTotalPrice.Name = "lblTotalPrice";
            lblTotalPrice.Size = new Size(74, 15);
            lblTotalPrice.TabIndex = 7;
            lblTotalPrice.Text = "הסכום הסופי";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(102, 68);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 8;
            // 
            // btnPay
            // 
            btnPay.Location = new Point(810, 241);
            btnPay.Name = "btnPay";
            btnPay.Size = new Size(96, 23);
            btnPay.TabIndex = 9;
            btnPay.Text = "סיום ההזמנה";
            btnPay.UseVisualStyleBackColor = true;
            btnPay.Click += btnPay_Click_1;
            // 
            // txtNameToAdd
            // 
            txtNameToAdd.Location = new Point(810, 146);
            txtNameToAdd.Name = "txtNameToAdd";
            txtNameToAdd.Size = new Size(120, 23);
            txtNameToAdd.TabIndex = 10;
            // 
            // lblHello
            // 
            lblHello.AutoSize = true;
            lblHello.Location = new Point(902, 56);
            lblHello.Name = "lblHello";
            lblHello.Size = new Size(0, 15);
            lblHello.TabIndex = 11;
            // 
            // OrderForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ScrollBar;
            ClientSize = new Size(1184, 613);
            Controls.Add(lblHello);
            Controls.Add(txtNameToAdd);
            Controls.Add(btnPay);
            Controls.Add(label1);
            Controls.Add(lblTotalPrice);
            Controls.Add(btnAddToBag);
            Controls.Add(nudAmountToOrder);
            Controls.Add(lblAmountToOrder);
            Controls.Add(lblProductIDtoOrder);
            Name = "OrderForm";
            Text = "Ordder";
            ((System.ComponentModel.ISupportInitialize)nudAmountToOrder).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblProductIDtoOrder;
        private NumericUpDown nudAmountToOrder;
        private Label lblAmountToOrder;
        private Button btnAddToBag;
        private Label lblTotalPrice;
        private Label label1;
        private Button btnPay;
        private TextBox txtNameToAdd;
        private Label lblHello;
    }
}