using BL.BlApi;
using BL.BlImplementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.BO
{
    public class Sale
    {

        /// <summary>
        /// קוד המבצע
        /// </summary>
        public int Code { get; set; }

        /// <summary>
        /// מזהה המוצר שהמבצע חל עליו
        /// </summary>
        public int ProductId { get; set; }

        /// <summary>
        /// הכמות המינימלית לקבלת המבצע
        /// </summary>
        public int MinQuantity { get; set; }

        /// <summary>
        /// המחיר במבצע
        /// </summary>
        public double Price { get; set; }

        /// <summary>
        /// האם המבצע חל בקלב
        /// </summary>
        public bool InClab { get; set; }

        /// <summary>
        /// תאריך תחילת המבצע
        /// </summary>
        public DateTime BeginSale { get; set; }

        /// <summary>
        /// תאריך סיום המבצע
        /// </summary>
        public DateTime EndSale { get; set; }

        /// <summary>
        /// בנאי לקבלת כל הנתונים הדרושים ליצירת מבצע
        /// </summary>
        public Sale(int code, int productId, int minQuantity, double price, bool inClab, DateTime beginSale, DateTime endSale)
        {
            Code = code;
            ProductId = productId;
            MinQuantity = minQuantity;
            Price = price;
            InClab = inClab;
            BeginSale = beginSale;
            EndSale = endSale;
        }

        /// <summary>
        /// בנאי ריק (לשימוש במידת הצורך)
        /// </summary>
        public Sale() { 
            Code = 0;
            ProductId = 0;
            MinQuantity = 0;
            Price = 0;
            InClab = false;
            BeginSale = DateTime.MinValue;
            EndSale = DateTime.MinValue;
        }

        /// <summary>
        /// פונקציית העמסה של- tostring
        /// </summary>
        /// <returns></returns>
        public override string ?ToString() => Tools.ToStringPropety(this);

    }


}
