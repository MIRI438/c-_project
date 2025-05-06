namespace UI
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

        private void btnManegerMenu_Click(object sender, EventArgs e)
        {
            ManegerMenu m = new ManegerMenu();
            Point currentFormLocation = this.Location;
            m.StartPosition = FormStartPosition.Manual;
            m.Location = currentFormLocation;
            m.Show();
            m.TopMost = true;
        }

        private void btnSohpkeeperMenu_Click(object sender, EventArgs e)
        {
            Login l = new Login();
            Point currentFormLocation = this.Location;
            l.StartPosition = FormStartPosition.Manual;
            l.Location = currentFormLocation;
            l.Show();
            l.TopMost = true;
        }
    }
}
