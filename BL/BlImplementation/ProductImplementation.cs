using BL.BO;
using DalApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.BlImplementation
{
    internal class ProductImplementation : BlApi.IProduct
    {
        private DalApi.IDal? _dal = DalApi.Factory.Get;


        /// <summary>
        /// פונקציה ליצירת מוצר חדש
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public int Create(Product item)
        {
            try
            {
                DO.Product s1 = BO.Tools.ConvertProductToDO(item);
                return _dal.Product.Create(s1);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }


        /// <summary>
        /// פונקציה למחיקת מוצר לפי ID
        /// </summary>
        /// <param name="id"></param>
        /// <exception cref="Exception"></exception>
        public void Delete(int id)
        {
            try
            {
                _dal.Product.Delete(id);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }


        /// <summary>
        /// מדפיס את כל המבצעים הנוכחיים
        /// </summary>
        /// <param name="id"></param>
        /// <param name="IsExcess"></param>
        public void ListOfAllCurrentPromotions(int id, bool IsExcess)
        {
            List<DO.Sale> sales = _dal.Sale.ReadAll(s => s.ProductId == id && s.InClab == IsExcess).ToList();

            Console.WriteLine(string.Join("\n", sales.Select(s => s.ToString())));

        }


        /// <summary>
        /// פונקציה שמחזירה מוצר לפי ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public Product Read(int id)
        {
            try
            {
                BO.Product? p = BO.Tools.ConvertProductToBO(_dal.Product.Read(id));
                return p;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }


        /// <summary>
        /// פונקציה המחזירה מוצר לפי סינון מסוים
        /// </summary>
        /// <param name="filter"></param>
        /// <returns></returns>
        public Product Read(Func<Product, bool> filter)
        {
            var newFilter = BO.Tools.ConvertFilterProductBOtoDO(filter);
            return BO.Tools.ConvertProductToBO(_dal.Product.Read(newFilter));
        }


        /// <summary>
        /// פונקציה המחזירה את כל המוצרים שעומדים בסינון מסוים
        /// </summary>
        /// <param name="filter"></param>
        /// <returns></returns>
        public List<Product> ReadAll(Func<Product, bool>? filter = null)
        {
            List<DO.Product> dalSales = _dal.Product.ReadAll();
            if (filter != null)
            {
                Func<DO.Product, bool> dalFilter = doSale => filter(BO.Tools.ConvertProductToBO(doSale));
                dalSales = dalSales.Where(dalFilter).ToList();
            }

            return dalSales.Select(BO.Tools.ConvertProductToBO).ToList();
        }


        /// <summary>
        /// פונקציה המעדכנת את המוצר
        /// </summary>
        /// <param name="item"></param>
        public void Update(Product item)
        {
            DO.Product p = BO.Tools.ConvertProductToDO(item);
            _dal.Product.Update(p);
        }
    }
}
