using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DO
{
    /// <summary>
    /// תכונות של מוצר
    /// <summary>
    /// </summary>
    /// <param name="Id">מספר מזהה יחודי למוצר</param>
    /// <param name="ProductName">שם מוצר</param>
    /// <param name="Category">קטגוריה</param>
    /// <param name="Price">מחיר</param>
    /// <param name="QuantityInStock">כמות במלאי</param>
    /// 
    public record Product
        (int Id, string ProductName, Category Category, double Price, int QuantityInStock)
    {

        /// <summary>
        /// בנאי ריק
        /// </summary>
        public Product() : this(0, "ספה", Category.טיפוח_עור_הפנים, 5000, 10)
        {

        }
    }
}


