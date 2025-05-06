using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class ManegerMenu : Form
    {
        public ManegerMenu()
        {
            InitializeComponent();
        }

        private void btnSaleManeger_Click(object sender, EventArgs e)
        {
            SaleMenu s = new SaleMenu();
            Point currentFormLocation = this.Location;
            s.StartPosition = FormStartPosition.Manual;
            s.Location = currentFormLocation;
            s.Show();
            s.TopMost = true;
        }

        private void btnProductsManeger_Click(object sender, EventArgs e)
        {
            productsMenu p = new productsMenu();
            Point currentFormLocation = this.Location;
            p.StartPosition = FormStartPosition.Manual;
            p.Location = currentFormLocation;
            p.Show();
            p.TopMost = true;
        }

        private void btnCustomersManeger_Click(object sender, EventArgs e)
        {
            CustomersMenu c = new CustomersMenu();
            c.Show();
            Point currentFormLocation = this.Location;
            c.StartPosition = FormStartPosition.Manual;
            c.Location = currentFormLocation;
            c.TopMost = true;
        }
    }
}
