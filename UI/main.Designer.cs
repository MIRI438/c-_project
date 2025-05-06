namespace UI
{
    partial class main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnSohpkeeperMenu = new Button();
            btnManegerMenu = new Button();
            SuspendLayout();
            // 
            // btnSohpkeeperMenu
            // 
            btnSohpkeeperMenu.Location = new Point(233, 120);
            btnSohpkeeperMenu.Name = "btnSohpkeeperMenu";
            btnSohpkeeperMenu.Size = new Size(115, 50);
            btnSohpkeeperMenu.TabIndex = 0;
            btnSohpkeeperMenu.Text = "קופאי";
            btnSohpkeeperMenu.UseVisualStyleBackColor = true;
            // 
            // btnManegerMenu
            // 
            btnManegerMenu.Location = new Point(366, 120);
            btnManegerMenu.Name = "btnManegerMenu";
            btnManegerMenu.Size = new Size(115, 50);
            btnManegerMenu.TabIndex = 0;
            btnManegerMenu.Text = "מנהל";
            btnManegerMenu.UseVisualStyleBackColor = true;
            btnManegerMenu.Click += btnManegerMenu_Click;
            // 
            // main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(btnManegerMenu);
            Controls.Add(btnSohpkeeperMenu);
            Margin = new Padding(3, 2, 3, 2);
            Name = "main";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btnSohpkeeperMenu;
        private Button btnManegerMenu;
    }
}
