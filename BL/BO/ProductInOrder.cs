using System;
using System.Collections.Generic;

namespace BL.BO
{
    /// <summary>
    /// ישות עזר לתיאור מוצר בהזמנה
    /// </summary>
    public class ProductInOrder
    {
        private int id;
        private double price;
        private int amount;
        private Sale sale;

        /// <summary>
        /// מזהה מוצר
        /// </summary>
        public int ProductId { get; set; }

        /// <summary>
        /// שם מוצר
        /// </summary>
        public string ProductName { get; set; }

        /// <summary>
        /// מחיר בסיס למוצר
        /// </summary>
        public double BasePrice { get; set; }

        /// <summary>
        /// כמות בהזמנה
        /// </summary>
        public int QuantityInOrder { get; set; }

        /// <summary>
        /// רשימת מבצעים למוצר זה
        /// </summary>
        public List<SaleInProduct> Sales { get; set; }

        /// <summary>
        /// מחיר סופי למוצר
        /// </summary>
        public double FinalPrice { get; set; }

        /// <summary>
        /// בנאי מלא ליצירת מוצר בהזמנה
        /// </summary>
        public ProductInOrder(int productId, string productName, double basePrice, int quantityInOrder, List<SaleInProduct> sales, double finalPrice)
        {
            ProductId = productId;
            ProductName = productName;
            BasePrice = basePrice;
            QuantityInOrder = quantityInOrder;
            Sales = sales ?? new List<SaleInProduct>(); // רשימה ריקה אם לא נמסרה רשימה
            FinalPrice = finalPrice;
        }

        /// <summary>
        /// בנאי ריק (לשימוש במידת הצורך)
        /// </summary>
        public ProductInOrder()
        {
            Sales = new List<SaleInProduct>(); // אתחול לרשימה ריקה
        }



        public override string ToString() => Tools.ToStringPropety< ProductInOrder>(this);

    }
}