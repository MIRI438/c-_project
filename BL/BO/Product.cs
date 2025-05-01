using BL.BlApi;
using BL.BlImplementation;
using DO;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.BO
{
    public class Product
    {

        /// <summary>
        /// מספר מזהה יחודי למוצר
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// שם מוצר
        /// </summary>
        public string ProductName { get; set; }

        /// <summary>
        /// קטגוריה של המוצר
        /// </summary>
        public string Category { get; set; }

        /// <summary>
        /// מחיר המוצר
        /// </summary>
        public double Price { get; set; }

        /// <summary>
        /// כמות במלאי
        /// </summary>
        public int QuantityInStock { get; set; }

        /// <summary>
        /// רשימת מבצעים למוצר
        /// </summary>
        public List<SaleInProduct> Sales { get; set; }

        /// <summary>
        /// בנאי מלא ליצירת מוצר
        /// </summary>
        public Product(int id, string productName, string category, double price, int quantityInStock, List<SaleInProduct> sales)
        {
            Id = id;
            ProductName = productName;
            Category = category;
            Price = price;
            QuantityInStock = quantityInStock;
            Sales = sales ?? new List<SaleInProduct>();
        }

        /// <summary>
        /// בנאי ריק (לשימוש במידת הצורך)
        /// </summary>
        public Product()
        {
        }

        /// <summary>
        /// פונקציית העמסה של- tostring
        /// </summary>
        /// <returns></returns>
        public override string? ToString() => Tools.ToStringPropety(this);

    }

}

