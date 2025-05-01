using BL.BlApi;
using BL.BlImplementation;
using System;
using System.Collections.Generic;

namespace BL.BO {
    public class Order
    {

        // האם זה לקוח מועדף או מזדמן
        public bool IsPreferredCustomer { get; set; }

        // רשימת מוצרים בהזמנה
        public List<ProductInOrder> Products { get; set; }

        /// <summary>
        /// סכום הסופי
        /// </summary>
        public object TotalPrice { get; internal set; }


        /// <summary>
        /// בנאי ריק
        /// </summary>
        public Order() {
            Products = new List<ProductInOrder>();
            IsPreferredCustomer = false;
        }

   
        /// <summary>
        /// בנאי מלא
        /// </summary>
        /// <param name="isPreferredCustomer"></param>
        public Order(bool isPreferredCustomer)
        {
            IsPreferredCustomer = isPreferredCustomer;
            Products = new List<ProductInOrder>();
        }

        public override string? ToString() => Tools.ToStringPropety(this);

    }
}