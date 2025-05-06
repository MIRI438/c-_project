using BL.BO;
using DalApi;
using DO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.BlImplementation
{
    internal class CustomerImplementation : BlApi.ICustomer
    {
        /// <summary>
        /// משתנה מסוג DO שמעביר את הפונקציות
        /// </summary>
        private DalApi.IDal _dal = DalApi.Factory.Get;


        /// <summary>
        /// פונקציה לייצירת לקוח חדש
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public int Create(BO.Customer item)
        {
            try
            {
                DO.Customer c1 = BO.Tools.ConvertCustomerToDO(item);
                return _dal.Customer.Create(c1);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }


        /// <summary>
        /// פונקציה למחזירה לקוח מסוים לפי ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public BO.Customer Read(int id)
        {
            try
            {
                if(id < 0)
                    throw new BlIdNotFoundException($"Product with ID {id} does not exist.");
                BO.Customer? s = BO.Tools.ConvertCustomerToBO(_dal.Customer.Read(id));
                return s;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }


        /// <summary>
        /// פונקציה שמחזירה TRUE אם לקוח קיים אחרת מחזירה FALSE
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool IsExsit(int id)
        {
            try
            {
                BO.Customer c = Read(id);
                if (c != null)
                    return true;
                return false;
                throw new BlIdNotFoundException($"Product with ID {id} does not exist.");
                
            }
            catch (Exception e)
            {
                return false;
            }
        }


        /// <summary>
        /// פונקציה שמחזירה לקוח מסוים לפי סינון
        /// </summary>
        /// <param name="filter"></param>
        /// <returns></returns>
        public BO.Customer Read(Func<BO.Customer, bool> filter)
        {
            try
            {
                var newFilter = BO.Tools.ConvertFilterCustomerBOtoDO(filter);
                var customerDO = _dal.Customer.Read(newFilter);

                if (customerDO == null)
                    throw new BlIdNotFoundException("Customer not found with the given filter.");

                return BO.Tools.ConvertCustomerToBO(customerDO);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }


        /// <summary>
        /// פונקציה לעדכון לקוח קיים 
        /// </summary>
        /// <param name="item"></param>
        public void Update(BO.Customer item)
        {
            try
            {
                DO.Customer s = BO.Tools.ConvertCustomerToDO(item);
                _dal.Customer.Update(s);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

        }


        /// <summary>
        /// פונקציה שמחזירה רשימה של לקוחות שעומדים בדרישות הסינון
        /// </summary>
        /// <param name="filter">דרישות הסינון</param>
        /// <returns></returns>
        List<BO.Customer> BlApi.ICustomer.ReadAll(Func<BO.Customer, bool>? filter)
        {
            try
            {
                List<DO.Customer> dalSales = _dal.Customer.ReadAll();
                if (filter != null)
                {
                    Func<DO.Customer, bool> dalFilter = doSale => filter(BO.Tools.ConvertCustomerToBO(doSale));
                    dalSales = dalSales.Where(dalFilter).ToList();
                }

                return dalSales.Select(BO.Tools.ConvertCustomerToBO).ToList();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }


        /// <summary>
        /// פונקציה למחיקת לקוח לפי ID
        /// </summary>
        /// <param name="id"></param>
        /// <exception cref="Exception"></exception>
        public void Delete(int id)
        {
            try
            {
                _dal.Customer.Delete(id);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
