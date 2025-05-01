using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.BlApi
{
    public interface IBl
    {
         ICustomer? Customer { get; }
         IProduct? Product { get; }
         ISale? Sale { get; }
         IOrder? Order { get; }
    }
}
