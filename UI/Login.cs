using BL.BlApi;
using BL.BO;
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
    public partial class Login : Form
    {
        private static IBl _bl = BL.BlApi.Factory.Get();

        public Login()
        {
            InitializeComponent();
        }

        private void btnSaerchIDinCustomers_Click(object sender, EventArgs e)
        {
            if (nudIDtoStartShopping != null)
            {
                int customerId = (int)nudIDtoStartShopping.Value;
                Customer customer = _bl.Customer.Read(customerId);
                if (customer!=null)
                {
                    customer.inClub = true;
                    MessageBox.Show($"Welcome {customer.Name} to the club!");
                    OrderForm order = new OrderForm();
                    Point currentFormLocation = this.Location;
                    order.StartPosition = FormStartPosition.Manual;
                    order.Location = currentFormLocation;
                    order.TopMost = true;
                    order.Show();

                }
                else
                {
                    MessageBox.Show("Hello new customer");
                    OrderForm order = new OrderForm();
                    Point currentFormLocation = this.Location;
                    order.StartPosition = FormStartPosition.Manual;
                    order.Location = currentFormLocation;
                    order.TopMost = true;
                    order.Show();

                }
            }
            else
            {
                MessageBox.Show("Invalid input.");
            }
        }
    }
}
