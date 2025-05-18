using BL.BlApi;
using BL.BO;
using Microsoft.VisualBasic;
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
    public partial class SaleMenu : Form
    {
        private static IBl _bl = BL.BlApi.Factory.Get();

        public SaleMenu()
        {
            InitializeComponent();
            readAll();
        }

        private void btnAddSale_Click(object sender, EventArgs e)
        {
            Sale sale = new Sale();

            sale.ProductId = (int)nudProductId.Value;
            sale.MinQuantity = (int)nudMinQuantity.Value;
            sale.Price = (double)nudPriceSale.Value;
            sale.InClab = rbtnNoInClub.Checked ? false : true;
            sale.BeginSale = dtBeginSale.Value;
            sale.EndSale = dtEndSale.Value;
            try
            {
                _bl.Sale.Create(sale);
                readAll();
                MessageBox.Show("Sale added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                List<Sale?> sales = _bl.Sale.ReadAll();
                if (sales == null || !sales.Any())
                {
                    lblRadAllSales.Text = "No sale available.";
                    return;
                }
                string saleListText = "Sale List:\n";
                saleListText += "-----------------------------\n";
                saleListText += string.Join(Environment.NewLine, sales.Select(s =>
                    $"Code: {s.Code}\n" +
                    $"Product ID: {s.ProductId}\n" +
                    $"Sale price: {s.Price}\n" +
                    $"Is only vip persons ?: {s.InClab}\n" +
                    $"Minimum quantity to sale: {s.MinQuantity}\n" +
                    $"Date begin Sale: {s.BeginSale}\n" +
                    $"Date finish Sale: {s.EndSale}\n" +
                    "-----------------------------"));

                lblRadAllSales.Text = saleListText;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdateSale_Click(object sender, EventArgs e)
        {
            Sale sale = new Sale();
            sale.Code = (int)nudCodeSaleToUpdate.Value;
            sale.ProductId = (int)nudProductIDtoUpdate.Value;
            sale.MinQuantity = (int)nudNewMinQantity.Value;
            sale.Price = (double)nudNewPriceSale.Value;
            sale.InClab = rbtnNewYes.Checked ? true : false;
            sale.BeginSale = dtNewStartSale.Value;
            sale.EndSale = dtNewEndSale.Value;
            try
            {
                _bl.Sale.Update(sale);
                readAll();
                MessageBox.Show("Sale updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void lblProductIDtOUpdate_Click(object sender, EventArgs e)
        {

        }

        private void btnDeleteSale_Click(object sender, EventArgs e)
        {
            try
            {
                _bl.Sale.Delete((int)nudCodetoDelete.Value);
                readAll();
                MessageBox.Show("Sale deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnReadSale_Click(object sender, EventArgs e)
        {
            try
            {
                Sale s = _bl.Sale.Read((int)nudReadCodeSale.Value);
                MessageBox.Show(
                    $"Code: {s.Code}\n" +
                    $"Product ID: {s.ProductId}\n" +
                    $"Sale price: {s.Price}\n" +
                    $"Is only vip persons ?: {s.InClab}\n" +
                    $"Minimum quantity to sale: {s.MinQuantity}\n" +
                    $"Date begin Sale: {s.BeginSale}\n" +
                    $"Date finish Sale: {s.EndSale}\n" +
                    "-----------------------------");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void nudProductIDtoUpdate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void SaleMenu_Load(object sender, EventArgs e)
        {

        }
    }
}
