namespace UI
{
    partial class ManegerMenu
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
            btnSaleManeger = new Button();
            btnProductsManeger = new Button();
            btnCustomersManeger = new Button();
            SuspendLayout();
            // 
            // btnSaleManeger
            // 
            btnSaleManeger.Location = new Point(354, 243);
            btnSaleManeger.Name = "btnSaleManeger";
            btnSaleManeger.Size = new Size(139, 56);
            btnSaleManeger.TabIndex = 0;
            btnSaleManeger.Text = "מבצעים";
            btnSaleManeger.UseVisualStyleBackColor = true;
            btnSaleManeger.Click += btnSaleManeger_Click;
            // 
            // btnProductsManeger
            // 
            btnProductsManeger.Location = new Point(517, 243);
            btnProductsManeger.Name = "btnProductsManeger";
            btnProductsManeger.Size = new Size(139, 56);
            btnProductsManeger.TabIndex = 0;
            btnProductsManeger.Text = "מוצרים";
            btnProductsManeger.UseVisualStyleBackColor = true;
            btnProductsManeger.Click += btnProductsManeger_Click;
            // 
            // btnCustomersManeger
            // 
            btnCustomersManeger.Location = new Point(679, 243);
            btnCustomersManeger.Name = "btnCustomersManeger";
            btnCustomersManeger.Size = new Size(139, 56);
            btnCustomersManeger.TabIndex = 0;
            btnCustomersManeger.Text = "לקוחות";
            btnCustomersManeger.UseVisualStyleBackColor = true;
            btnCustomersManeger.Click += btnCustomersManeger_Click;
            // 
            // ManegerMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1178, 613);
            Controls.Add(btnCustomersManeger);
            Controls.Add(btnProductsManeger);
            Controls.Add(btnSaleManeger);
            Name = "ManegerMenu";
            Text = "ManegerMenu";
            ResumeLayout(false);
        }

        #endregion

        private Button btnSaleManeger;
        private Button btnProductsManeger;
        private Button btnCustomersManeger;
    }
}