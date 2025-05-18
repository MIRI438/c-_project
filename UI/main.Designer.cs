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
            Button btnSohpkeeperMenu;
            btnManegerMenu = new Button();
            pictureBox1 = new PictureBox();
            btnSohpkeeperMenu = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnSohpkeeperMenu
            // 
            btnSohpkeeperMenu.AllowDrop = true;
            btnSohpkeeperMenu.BackColor = Color.LightGray;
            btnSohpkeeperMenu.BackgroundImageLayout = ImageLayout.Center;
            btnSohpkeeperMenu.FlatStyle = FlatStyle.Flat;
            btnSohpkeeperMenu.ForeColor = Color.Black;
            btnSohpkeeperMenu.Location = new Point(226, 557);
            btnSohpkeeperMenu.Name = "btnSohpkeeperMenu";
            btnSohpkeeperMenu.Size = new Size(91, 35);
            btnSohpkeeperMenu.TabIndex = 0;
            btnSohpkeeperMenu.Text = "קופאי";
            btnSohpkeeperMenu.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnSohpkeeperMenu.UseVisualStyleBackColor = false;
            btnSohpkeeperMenu.Click += btnSohpkeeperMenu_Click;
            // 
            // btnManegerMenu
            // 
            btnManegerMenu.BackColor = Color.LightGray;
            btnManegerMenu.FlatStyle = FlatStyle.Flat;
            btnManegerMenu.ForeColor = Color.Black;
            btnManegerMenu.ImageAlign = ContentAlignment.BottomCenter;
            btnManegerMenu.Location = new Point(120, 557);
            btnManegerMenu.Name = "btnManegerMenu";
            btnManegerMenu.Size = new Size(91, 35);
            btnManegerMenu.TabIndex = 0;
            btnManegerMenu.Text = "מנהל";
            btnManegerMenu.UseVisualStyleBackColor = false;
            btnManegerMenu.Click += btnManegerMenu_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ActiveCaption;
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = Properties.Resources.Leonardo_Phoenix_10_Heres_the_description_of_the_image_in_Engl_3__1_;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1181, 616);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1181, 616);
            Controls.Add(btnManegerMenu);
            Controls.Add(btnSohpkeeperMenu);
            Controls.Add(pictureBox1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "main";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnSohpkeeperMenu;
        private Button btnManegerMenu;
        private PictureBox pictureBox1;
    }
}
