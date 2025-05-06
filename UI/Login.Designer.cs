namespace UI
{
    partial class Login
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
            lblIDtoStartShopping = new Label();
            nudIDtoStartShopping = new NumericUpDown();
            btnSaerchIDinCustomers = new Button();
            ((System.ComponentModel.ISupportInitialize)nudIDtoStartShopping).BeginInit();
            SuspendLayout();
            // 
            // lblIDtoStartShopping
            // 
            lblIDtoStartShopping.AutoSize = true;
            lblIDtoStartShopping.Location = new Point(546, 82);
            lblIDtoStartShopping.Name = "lblIDtoStartShopping";
            lblIDtoStartShopping.Size = new Size(99, 15);
            lblIDtoStartShopping.TabIndex = 0;
            lblIDtoStartShopping.Text = "הכנס תעודת זהות";
            // 
            // nudIDtoStartShopping
            // 
            nudIDtoStartShopping.Location = new Point(420, 80);
            nudIDtoStartShopping.Maximum = new decimal(new int[] { -159383552, 46653770, 5421, 0 });
            nudIDtoStartShopping.Name = "nudIDtoStartShopping";
            nudIDtoStartShopping.Size = new Size(120, 23);
            nudIDtoStartShopping.TabIndex = 1;
            // 
            // btnSaerchIDinCustomers
            // 
            btnSaerchIDinCustomers.Location = new Point(239, 77);
            btnSaerchIDinCustomers.Name = "btnSaerchIDinCustomers";
            btnSaerchIDinCustomers.Size = new Size(75, 25);
            btnSaerchIDinCustomers.TabIndex = 2;
            btnSaerchIDinCustomers.Text = "חפש";
            btnSaerchIDinCustomers.UseVisualStyleBackColor = true;
            btnSaerchIDinCustomers.Click += btnSaerchIDinCustomers_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSaerchIDinCustomers);
            Controls.Add(nudIDtoStartShopping);
            Controls.Add(lblIDtoStartShopping);
            Name = "Login";
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)nudIDtoStartShopping).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblIDtoStartShopping;
        private NumericUpDown nudIDtoStartShopping;
        private Button btnSaerchIDinCustomers;
    }
}