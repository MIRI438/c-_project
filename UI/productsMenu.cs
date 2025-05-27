using BL.BlApi;
using BL.BO;
using DO;
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
    public partial class productsMenu : Form
    {
        private static IBl _bl = BL.BlApi.Factory.Get();
        public productsMenu()
        {
            InitializeComponent();
            readAll();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                BL.BO.Product product = new BL.BO.Product();
                product.ProductName = tbxNameProduct.Text;
                product.Price = (double)nudPrice.Value;
                product.Category = cbxCategory.SelectedIndex.ToString();
                product.QuantityInStock = (int)nudQuantityInStock.Value;
                _bl.Product.Create(product);
                readAll();
                MessageBox.Show("Product added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbxNewCategory.SelectedItem == null)
                {
                    MessageBox.Show("Please select a category.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                BL.BO.Product product = new BL.BO.Product();
                product.Id = (int)nudID.Value;
                product.ProductName = txtNewName.Text;
                product.Price = (double)nudNewPrice.Value;
                product.Category = cbxCategory.SelectedIndex.ToString();
                product.QuantityInStock = (int)nudNewQuantityInStock.Value;

                _bl.Product.Update(product);
                readAll();
                MessageBox.Show("Product updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                _bl.Product.Delete((int)nudIDtoDelete.Value);
                readAll();
                MessageBox.Show("Product deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                List<BL.BO.Product?> products = _bl.Product.ReadAll();
                if (products == null || !products.Any())
                {
                    lblReadNew.Text = "No products available.";
                    return;
                }
                string productListText = "Product List:\n";
                productListText += "-----------------------------\n";
                productListText += string.Join(Environment.NewLine, products.Select(p =>
                    $"ID: {p.Id}\n" +
                    $"Name: {p.ProductName}\n" +
                    $"Price: {p.Price:C}\n" +
                    $"Category: {(p.Category != null ? p.Category.ToString() : "לא נבחרה קטגוריה")}\n" +
                    $"Quantity: {p.QuantityInStock}\n" +
                    "-----------------------------"));

                lblReadNew.Text = productListText;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRead_Click(object sender, EventArgs e)
        {

        }

        private void tabDesine_Click(object sender, EventArgs e)
        {

        }

        private void nudRead_ValueChanged(object sender, EventArgs e)
        {
            BL.BO.Product p = _bl.Product.Read((int)nudRead.Value);
            MessageBox.Show($"ID: {p.Id}\n" +
                    $"Name: {p.ProductName}\n" +
                    $"Price: {p.Price:C}\n" +
                    $"Category: {(p.Category != null ? p.Category.ToString() : "לא נבחרה קטגוריה")}\n" +
                    $"Quantity: {p.QuantityInStock}\n" +
                    "-----------------------------");
        }

        private void cbxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
