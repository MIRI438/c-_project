using BL.BlApi;
using BL.BlImplementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.BO
{
    public class Customer
    {

        /// <summary>
        /// מזהה ייחודי של הלקוח
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// שם הלקוח
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// כתובת הלקוח
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// טלפון הלקוח
        /// </summary>
        public int Phone { get; set; }

        public bool inClub { get; set; }

        /// <summary>
        /// בנאי מלא של המחלקה-Customer
        /// </summary>
        /// <param name="id">מזהה ייחודי</param>
        /// <param name="name">שם הלקוח</param>
        /// <param name="address">כתובת הלקוח</param>
        /// <param name="phone">טלפון הלקוח</param>
        /// <param name="inClub">טלפון הלקוח</param>

        public Customer(int id, string name, string address, int phone, bool inClub)
        {
            Id = id;
            Name = name;
            Address = address;
            Phone = phone;
            this.inClub = inClub;

        }

        /// <summary>
        /// בנאי ריק של המחלקה-Customer
        /// </summary>
        /// <param name="id">מזהה ייחודי</param>
        /// <param name="name">שם הלקוח</param>
        /// <param name="address">כתובת הלקוח</param>
        /// <param name="phone">טלפון הלקוח</param>
        /// <param name="inClub">האם לקוח רשום</param>"
        public Customer()
        {
            Id = 0;
            Name = "";
            Address = "";
            Phone = 0;
            inClub = true;
        }

        /// <summary>
        /// פונקציית העמסה של- tostring
        /// </summary>
        /// <returns></returns>
        public override string? ToString() => Tools.ToStringPropety(this);
    }

}
