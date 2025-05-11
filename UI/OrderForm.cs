using BL.BlApi;
using BL.BO;
using System;
using System.Windows.Forms;

namespace UI
{
    public partial class OrderForm : Form
    {
        private static IBl _bl = BL.BlApi.Factory.Get();
        private static Order order = new Order();
        private BindingSource bindingSource = new BindingSource();
        private DataGridView dgvOrderProducts = new DataGridView();

        public OrderForm()
        {
            InitializeComponent();

            if (Login.customer != null)
            {
                // בדיקה אם הלקוח קיים במערכת
                if (_bl.Customer.IsExsit(Login.customer.Id))
                {
                    order.IsPreferredCustomer = true;
                }
                else
                {
                    order.IsPreferredCustomer = false;
                }
            }
            else
            {
                MessageBox.Show("שגיאה: נתוני הלקוח חסרים.");
                Close();
            }

            // שאר הקוד נשאר ללא שינוי
            dgvOrderProducts.Location = new System.Drawing.Point(10, 50);
            dgvOrderProducts.Size = new System.Drawing.Size(500, 200);
            dgvOrderProducts.AutoGenerateColumns = false;

            dgvOrderProducts.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "ProductId",
                HeaderText = "מזהה מוצר"
            });
            dgvOrderProducts.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "ProductName",
                HeaderText = "שם מוצר"
            });
            dgvOrderProducts.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "BasePrice",
                HeaderText = "מחיר ליחידה לפני הנחה"
            });
            dgvOrderProducts.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "QuantityInOrder",
                HeaderText = "כמות בהזמנה"
            });
            dgvOrderProducts.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "FinalPrice",
                HeaderText = "מחיר סופי"
            });

            this.Controls.Add(dgvOrderProducts);

            bindingSource.DataSource = order.Products;
            dgvOrderProducts.DataSource = bindingSource;

            lblTotalPrice.Text = $"סה\"כ לתשלום: {order.TotalPrice}";
        }


        private void btnAddToBag_Click(object sender, EventArgs e)
        {
            if (nudAmountToOrder.Value <= 0 || nudProductIDtoOrder == null)
            {
                MessageBox.Show("יש למלא בערכים תקינים");
                return;
            }

            try
            {
                // הוספת מוצר להזמנה
                int productId = (int)nudProductIDtoOrder.Value;
                int amount = (int)nudAmountToOrder.Value;

                _bl.Order.AddProductToOrder(order, productId, amount);

                // רענון הטבלה
                bindingSource.ResetBindings(false);

                // הצגת מחיר כולל
                lblTotalPrice.Text = $"סה\"כ לתשלום: {order.TotalPrice}";
                MessageBox.Show("המוצר נוסף להזמנה בהצלחה");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"שגיאה: {ex.Message}");
            }
        }

        private void btnPay_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (order.Products.Count == 0)
                {
                    MessageBox.Show("לא נוספו מוצרים להזמנה. לא ניתן להשלים את ההזמנה.");
                    return;
                }

                MessageBox.Show($"ההזמנה הושלמה בהצלחה! סה\"כ לתשלום: {order.TotalPrice}");
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"שגיאה בסיום ההזמנה: {ex.Message}");
            }
        }
    }
}
