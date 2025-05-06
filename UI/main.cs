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
    }
}
