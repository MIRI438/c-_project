using BL.BlApi;
using Microsoft.VisualBasic.Devices;
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
    public partial class CustomersMenu : Form
    {
        private static IBl _bl = BL.BlApi.Factory.Get();

        public CustomersMenu()
        {
            InitializeComponent();
            readAll();
        }


        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            try
            {
                BL.BO.Customer customer = new BL.BO.Customer();
                customer.Id = (int)nudIDCustomer.Value;
                customer.Name = tbxNameCustomer.Text;
                customer.Address = txtAddressCustomer.Text;
                customer.Phone = (int)nudPhoneCustomer.Value;


                _bl.Customer.Create(customer);
                readAll();
                MessageBox.Show("Customer added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void readAll()
        {
            try
            {
                List<BL.BO.Customer?> customers = _bl.Customer.ReadAll();
                if (customers == null || !customers.Any())
                {
                    lblReadAllCustomers.Text = "No customers available.";
                    return;
                }
                string customerListText = "Customer List:\n";
                customerListText += "-----------------------------\n";
                customerListText += string.Join(Environment.NewLine, customers.Select(c =>
                    $"ID: {c.Id}\n" +
                    $"Name: {c.Name}\n" +
                    $"Address: {c.Address}\n" +
                    $"Phone: {c.Phone}\n" +
                    "-----------------------------"));

                lblReadAllCustomers.Text = customerListText;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDeleteCustomer_Click_1(object sender, EventArgs e)
        {
            try
            {
                _bl.Customer.Delete((int)nudIDtoDeleteCustomer.Value);
                readAll();
                MessageBox.Show("Customer deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            BL.BO.Customer c = _bl.Customer.Read((int)nudReadCustomer.Value);
            MessageBox.Show($"ID: {c.Id}\n" +
                    $"Name: {c.Name}\n" +
                    $"Address: {c.Address}\n" +
                    $"Phone: {c.Phone}\n" +
                    "-----------------------------");
        }

        private void btnUpdateCustomer_Click(object sender, EventArgs e)
        {
            try
            {
                BL.BO.Customer customer = new BL.BO.Customer();
                customer.Id = (int)nudIDCustomerToUpdate.Value;
                customer.Name = txtNewNameCustomer.Text;
                customer.Address = txtNewAddressCustomer.Text;
                customer.Phone = (int)nudNewPhoneCustomer.Value;

                _bl.Customer.Update(customer);
                readAll();
                MessageBox.Show("Customer updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }

}
