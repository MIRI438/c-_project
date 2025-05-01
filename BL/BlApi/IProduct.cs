﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.BlApi
{
    public interface IProduct
    {
        int Create(BO.Product item);
        BO.Product Read(int id);
        BO.Product Read(Func<BO.Product, bool> filter);

        List<BO.Product> ReadAll(Func<BO.Product, bool>? filter = null);
        void Update(BO.Product item);
        void Delete(int id);
        void ListOfAllCurrentPromotions(int id, bool IsExcess);
    }
}
