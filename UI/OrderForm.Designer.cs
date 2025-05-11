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
            nudProductIDtoOrder = new NumericUpDown();
            nudAmountToOrder = new NumericUpDown();
            lblAmountToOrder = new Label();
            btnAddToBag = new Button();
            lblTotalPrice = new Label();
            label1 = new Label();
            btnPay = new Button();
            ((System.ComponentModel.ISupportInitialize)nudProductIDtoOrder).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudAmountToOrder).BeginInit();
            SuspendLayout();
            // 
            // lblProductIDtoOrder
            // 
            lblProductIDtoOrder.AutoSize = true;
            lblProductIDtoOrder.Location = new Point(674, 141);
            lblProductIDtoOrder.Name = "lblProductIDtoOrder";
            lblProductIDtoOrder.Size = new Size(83, 15);
            lblProductIDtoOrder.TabIndex = 1;
            lblProductIDtoOrder.Text = "הכנס קוד מוצר";
            // 
            // nudProductIDtoOrder
            // 
            nudProductIDtoOrder.Location = new Point(538, 139);
            nudProductIDtoOrder.Maximum = new decimal(new int[] { -1486618624, 232830643, 0, 0 });
            nudProductIDtoOrder.Name = "nudProductIDtoOrder";
            nudProductIDtoOrder.Size = new Size(120, 23);
            nudProductIDtoOrder.TabIndex = 2;
            // 
            // nudAmountToOrder
            // 
            nudAmountToOrder.Location = new Point(538, 171);
            nudAmountToOrder.Maximum = new decimal(new int[] { 276447232, 23283, 0, 0 });
            nudAmountToOrder.Name = "nudAmountToOrder";
            nudAmountToOrder.Size = new Size(120, 23);
            nudAmountToOrder.TabIndex = 4;
            // 
            // lblAmountToOrder
            // 
            lblAmountToOrder.AutoSize = true;
            lblAmountToOrder.Location = new Point(674, 173);
            lblAmountToOrder.Name = "lblAmountToOrder";
            lblAmountToOrder.Size = new Size(59, 15);
            lblAmountToOrder.TabIndex = 3;
            lblAmountToOrder.Text = "בחר כמות";
            // 
            // btnAddToBag
            // 
            btnAddToBag.Location = new Point(661, 233);
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
            lblTotalPrice.Location = new Point(289, 325);
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
            btnPay.Location = new Point(538, 233);
            btnPay.Name = "btnPay";
            btnPay.Size = new Size(96, 23);
            btnPay.TabIndex = 9;
            btnPay.Text = "סיום ההזמנה";
            btnPay.UseVisualStyleBackColor = true;
            btnPay.Click += btnPay_Click_1;
            // 
            // OrderForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnPay);
            Controls.Add(label1);
            Controls.Add(lblTotalPrice);
            Controls.Add(btnAddToBag);
            Controls.Add(nudAmountToOrder);
            Controls.Add(lblAmountToOrder);
            Controls.Add(nudProductIDtoOrder);
            Controls.Add(lblProductIDtoOrder);
            Name = "OrderForm";
            Text = "Ordder";
            ((System.ComponentModel.ISupportInitialize)nudProductIDtoOrder).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudAmountToOrder).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblProductIDtoOrder;
        private NumericUpDown nudProductIDtoOrder;
        private NumericUpDown nudAmountToOrder;
        private Label lblAmountToOrder;
        private Button btnAddToBag;
        private Label lblTotalPrice;
        private Label label1;
        private Button btnPay;
    }
}