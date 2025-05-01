using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DO
{
    /// <summary>
    /// תכונות של לקוח
    /// </summary>
    /// <param name="Id"></param>
    /// <param name="Name">שם לקוח</param>
    /// <param name="Address">כתובת לקוח</param>
    /// <param name="Phone">טלפון לקוח</param>
    public record Customer
        (int Id, string Name, string Address, int Phone)
    {
        /// <summary>
        /// בנאי ריק של מחלקת Customer
        /// </summary>
        public Customer() : this(0, "מירי", "מושב מתתיהו", 0534198438)
        {

        }

    }
}
