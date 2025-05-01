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
            btnShopeKeeper = new Button();
            btnBoss = new Button();
            SuspendLayout();
            // 
            // btnShopeKeeper
            // 
            btnShopeKeeper.BackColor = SystemColors.Control;
            btnShopeKeeper.Location = new Point(418, 168);
            btnShopeKeeper.Name = "btnShopeKeeper";
            btnShopeKeeper.Size = new Size(120, 62);
            btnShopeKeeper.TabIndex = 0;
            btnShopeKeeper.Text = "קופאי";
            btnShopeKeeper.UseVisualStyleBackColor = false;
            btnShopeKeeper.Click += button1_Click;
            // 
            // btnBoss
            // 
            btnBoss.BackColor = SystemColors.ButtonFace;
            btnBoss.Location = new Point(280, 168);
            btnBoss.Name = "btnBoss";
            btnBoss.Size = new Size(120, 62);
            btnBoss.TabIndex = 0;
            btnBoss.Text = "מנהל";
            btnBoss.UseVisualStyleBackColor = false;
            btnBoss.Click += button1_Click;
            // 
            // main
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnBoss);
            Controls.Add(btnShopeKeeper);
            Name = "main";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btnShopeKeeper;
        private Button btnBoss;
    }
}
