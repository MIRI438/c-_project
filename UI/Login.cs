using BL.BlApi;
using BL.BO;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace UI
{
    public partial class Login : Form
    {
        private static IBl _bl = BL.BlApi.Factory.Get();
        public static Customer customer = new Customer();

        public Login()
        {
            InitializeComponent();
        }

        private void btnSaerchIDinCustomers_Click(object sender, EventArgs e)
        {
            if (nudIDtoStartShopping != null)
            {
                int customerId = (int)nudIDtoStartShopping.Value;
                customer.Id = customerId;

                try
                {

                    OpenOrderForm();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("Invalid input.");
            }
        }

        private void OpenOrderForm()
        {
            OrderForm order = new OrderForm();
            Point currentFormLocation = this.Location;
            order.StartPosition = FormStartPosition.Manual;
            order.Location = currentFormLocation;
            order.TopMost = true;
            order.Show();
        }

        private void nudIDtoStartShopping_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
