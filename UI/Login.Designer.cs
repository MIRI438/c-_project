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
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)nudIDtoStartShopping).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblIDtoStartShopping
            // 
            lblIDtoStartShopping.AutoSize = true;
            lblIDtoStartShopping.Location = new Point(581, 169);
            lblIDtoStartShopping.Name = "lblIDtoStartShopping";
            lblIDtoStartShopping.Size = new Size(99, 15);
            lblIDtoStartShopping.TabIndex = 0;
            lblIDtoStartShopping.Text = "הכנס תעודת זהות";
            // 
            // nudIDtoStartShopping
            // 
            nudIDtoStartShopping.BackColor = SystemColors.ControlLight;
            nudIDtoStartShopping.Location = new Point(545, 206);
            nudIDtoStartShopping.Maximum = new decimal(new int[] { -159383552, 46653770, 5421, 0 });
            nudIDtoStartShopping.Name = "nudIDtoStartShopping";
            nudIDtoStartShopping.Size = new Size(178, 23);
            nudIDtoStartShopping.TabIndex = 1;
            nudIDtoStartShopping.ValueChanged += nudIDtoStartShopping_ValueChanged;
            // 
            // btnSaerchIDinCustomers
            // 
            btnSaerchIDinCustomers.Location = new Point(595, 288);
            btnSaerchIDinCustomers.Name = "btnSaerchIDinCustomers";
            btnSaerchIDinCustomers.Size = new Size(75, 25);
            btnSaerchIDinCustomers.TabIndex = 2;
            btnSaerchIDinCustomers.Text = "חפש";
            btnSaerchIDinCustomers.UseVisualStyleBackColor = true;
            btnSaerchIDinCustomers.Click += btnSaerchIDinCustomers_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Leonardo_Phoenix_10_Heres_the_description_of_the_image_in_Engl_3_copy;
            pictureBox1.Location = new Point(45, 478);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(144, 93);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ScrollBar;
            ClientSize = new Size(1182, 609);
            Controls.Add(pictureBox1);
            Controls.Add(btnSaerchIDinCustomers);
            Controls.Add(nudIDtoStartShopping);
            Controls.Add(lblIDtoStartShopping);
            Name = "Login";
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)nudIDtoStartShopping).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblIDtoStartShopping;
        private NumericUpDown nudIDtoStartShopping;
        private Button btnSaerchIDinCustomers;
        private PictureBox pictureBox1;
    }
}