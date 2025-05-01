using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.BO
{
    public class SaleInProduct
    {
        /// <summary>
        /// מזהה מבצע
        /// </summary>
        public int SaleId { get; set; }

        /// <summary>
        /// כמות למבצע

        public int QuantityForSale { get; set; }

        /// <summary>
        /// מחיר
        /// </summary>
        public double SalePrice { get; set; }

        /// <summary>
        /// האם המבצע מיועד לכל הלקוחות
        /// </summary>
        public bool IsForAllCustomers { get; set; }

        /// <summary>
        /// בנאי מלא ליצירת מבצע
        /// </summary>
        public SaleInProduct(int saleId, int quantityForSale, double salePrice, bool isForAllCustomers)
        {
            SaleId = saleId;
            QuantityForSale = quantityForSale;
            SalePrice = salePrice;
            IsForAllCustomers = isForAllCustomers;
        }
 
        /// <summary>
        /// בנאי ריק (לשימוש במידת הצורך)
        /// </summary>
        public SaleInProduct() { }
        public override string ToString() => Tools.ToStringPropety< SaleInProduct>(this);

    }
}
