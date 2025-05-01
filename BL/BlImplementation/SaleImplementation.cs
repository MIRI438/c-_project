using BL.BO;
using DalApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.BlImplementation
{
    internal class SaleImplementation : BlApi.ISale
    {
        /// <summary>
        /// משתנה מסוג DO שמעביר את הפונקציות
        /// </summary>
        private DalApi.IDal _dal = DalApi.Factory.Get;

        /// <summary>
        /// פונקציה ליצירת מבצע חדש
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public int Create(BO.Sale s)
        {
            try
            { 
                DO.Sale s1 = BO.Tools.ConvertSaleToDO(s);
                return _dal.Sale.Create(s1);
            }
            catch(Exception e) {
                throw new Exception(e.Message);
            }
        }

        /// <summary>
        /// פונקציית למחיקת מבצע קיים
        /// </summary>
        /// <param name="id">משתנה שלפיו מוחקים את המבצע</param>
        /// <exception cref="Exception"></exception>
        public void Delete(int id)
        {
            try
            {
                _dal.Sale.Delete(id);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        /// <summary>
        /// פונקציה שמחזירה מבצע מסוים לפי ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public Sale? Read(int id)
        {
            try
            {
                BO.Sale? s = BO.Tools.ConvertSaleToBO(_dal.Sale.Read(id));
                return s;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        /// <summary>
        /// פונקציה שמחזירה מבצע מסוים לפי סינון
        /// </summary>
        /// <param name="filter"></param>
        /// <returns></returns>
        public Sale Read(Func<BO.Sale, bool>? filter)
        {
           var newFilter = BO.Tools.ConvertFilterSaleBOtoDO(filter);
            return BO.Tools.ConvertSaleToBO(_dal.Sale.Read(newFilter));
        }

        /// <summary>
        /// פונקציה שמחזירה רשימה של מבצעים שעומדים בדרישות הסינון
        /// </summary>
        /// <param name="filter">דרישות הסינון</param>
        /// <returns></returns>
        public List<Sale> ReadAll(Func<BO.Sale, bool>? filter = null)
        {
            List<DO.Sale> dalSales = _dal.Sale.ReadAll();
            if (filter != null)
            {
                Func<DO.Sale, bool> dalFilter = doSale => filter(BO.Tools.ConvertSaleToBO(doSale));
                dalSales = dalSales.Where(dalFilter).ToList();
            }

            return dalSales.Select(BO.Tools.ConvertSaleToBO).ToList();
        }

        /// <summary>
        /// פונקציה לעדכון מבצע קיים 
        /// </summary>
        /// <param name="item"></param>
        public void Update(BO.Sale item)
        {
            DO.Sale s = BO.Tools.ConvertSaleToDO(item);
            _dal.Sale.Update(s);

        }


    }
}
