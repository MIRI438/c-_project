using DO;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;


namespace BL.BO
{
    public static class Tools
    {
        /// <summary>
        /// פונקציה שמחזירה בצורה יפה את התכונות
        /// </summary>
        /// <typeparam name="T">סוג האוביקט</typeparam>
        /// <param name="obj">שם האוביקט</param>
        /// <returns></returns>
        public static string? ToStringPropety<T>(this T obj) {

            if (obj == null) return null;
           
            StringBuilder sb = new StringBuilder();

            foreach (var propety in obj.GetType().GetProperties() ){
                sb.Append($"{propety.Name} {propety.GetValue(obj)}");
            }
            return sb.ToString();
        }

        /// <summary>
        /// פונקציית המרה מDO.Customer ל-BO.Customer
        /// </summary>
        /// <param name="c">האוביקט שדורש המרה</param>
        /// <returns></returns>
        public static BO.Customer? ConvertCustomerToBO(DO.Customer? c)
        {
            if (c == null) return null;
            return new BO.Customer { Id = c.Id, Name = c.Name, Address = c.Address, Phone = c.Phone, inClub = c.inClub };
        }

        /// <summary>
        /// פונקציית המרה מBO.Customer ל-DO.Customer
        /// </summary>
        /// <param name="c">האוביקט שדורש המרה</param>
        /// <returns></returns>
        public static DO.Customer ConvertCustomerToDO(BO.Customer c) => new DO.Customer { Id = c.Id, Name = c.Name, Address = c.Address, Phone = c.Phone , inClub = c.inClub };

        /// <summary>
        /// פונקציית המרה מDO.Sale ל-BO.Sale
        /// </summary>
        /// <param name="s">האוביקט שדורש המרה</param>
        /// <returns></returns>
        public static BO.Sale ConvertSaleToBO(DO.Sale s) => new BO.Sale { Code = s.Code, ProductId = s.ProductId, MinQuantity = s.MinQuantity, Price = s.Price, InClab = s.InClab, BeginSale = s.BeginSale, EndSale = s.EndSale};

        /// <summary>
        /// פונקציית המרה מBO.Sale ל-DO.Sale
        /// </summary>
        /// <param name="s">האוביקט שדורש המרה</param>
        /// <returns></returns>
        public static DO.Sale ConvertSaleToDO(BO.Sale s) => new DO.Sale { Code = s.Code, ProductId = s.ProductId, MinQuantity = s.MinQuantity, Price = s.Price, InClab = s.InClab, BeginSale = s.BeginSale, EndSale = s.EndSale = s.EndSale = s.EndSale };

        /// <summary>
        /// פונקציית המרה מDO.Product ל-BO.Product
        /// </summary>
        /// <param name="p">האוביקט שדורש המרה</param>
        /// <returns></returns>
        public static BO.Product? ConvertProductToBO(DO.Product? p)
        {
            if (p == null) return null;

            return new BO.Product
            {
                Id = p.Id,
                ProductName = p.ProductName,
                Price = p.Price,
                QuantityInStock = p.QuantityInStock,
                Category = p.Category.ToString()
            };
        }

        /// <summary>
        /// פונקציית המרה מBO.Product ל-DO.Product
        /// </summary>
        /// <param name="p">האוביקט שדורש המרה</param>
        /// <returns></returns>
        public static DO.Product ConvertProductToDO(BO.Product p) => new DO.Product
        {
            Id = p.Id,
            ProductName = p.ProductName,
            Price = p.Price,
            QuantityInStock = p.QuantityInStock,
            Category = Enum.Parse<DO.Category>(p.Category) // Fix: Convert string to DO.Category
        };

        /// <summary>
        /// פונקציית המרת פילטר Sale מBO לDO
        /// </summary>
        /// <param name="boFilter">הפילטר שאני מקבלת בפונקציה</param>
        /// <returns></returns>
        public static Func<DO.Sale, bool> ConvertFilterSaleBOtoDO(Func<BO.Sale, bool> boFilter)
        {
            return doSale => boFilter(BO.Tools.ConvertSaleToBO(doSale));
        }

        /// <summary>
        /// פונקציית המרת פילטר Sale מDO לBO
        /// </summary>
        /// <param name="boFilter">הפילטר שאני מקבלת בפונקציה</param>
        /// <returns></returns>
        public static Func<BO.Sale?, bool> ConvertFilterSaleDOtoBO(Func<DO.Sale?, bool> boFilter = null)
        {
            return doSale => boFilter(BO.Tools.ConvertSaleToDO(doSale));
        }

        /// <summary>
        /// פונקציית המרת פילטר Product מBO לDO
        /// </summary>
        /// <param name="boFilter">הפילטר שאני מקבלת בפונקציה</param>
        /// <returns></returns>
        public static Func<DO.Product?, bool> ConvertFilterProductBOtoDO(Func<BO.Product?, bool> boFilter = null)
        {
            return doSale => boFilter(BO.Tools.ConvertProductToBO(doSale));
        }

        /// <summary>
        /// פונקציית המרת פילטר Customer מBO לDO
        /// </summary>
        /// <param name="boFilter">הפילטר שאני מקבלת בפונקציה</param>
        /// <returns></returns>
        public static Func<DO.Customer, bool> ConvertFilterCustomerBOtoDO(Func<BO.Customer, bool> boFilter)
        {
            return doSale => boFilter(BO.Tools.ConvertCustomerToBO(doSale));
        }


        /// <summary>
        /// פונקציית המרת רשימה של DO.SALE לBO.SALEINPRODUCT
        /// </summary>
        /// <param name="sales"></param>
        /// <returns></returns>
        public static List<BO.SaleInProduct> ConvertDOSalesToBOSaleInProducts(List<DO.Sale> sales)
        {
            return sales.Select(s => new BO.SaleInProduct
            {
                SaleId = s.Code,
                QuantityForSale = s.MinQuantity,
                SalePrice = s.Price,
                IsForAllCustomers = s.InClab
            }).ToList();
        }


    }
}
