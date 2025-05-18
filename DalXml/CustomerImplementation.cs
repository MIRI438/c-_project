using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using DalApi;
using DO;
using Tools;

namespace Dal
{
    internal class CustomerImplementation : ICustomer
    {
        const string pathCustomer = "../xml/customers.xml";

        XmlSerializer serializer = new XmlSerializer(typeof(List<Customer>));
        static string projectName = MethodBase.GetCurrentMethod().DeclaringType.FullName!;


        public int Create(Customer item)
        {
            string functionName = MethodBase.GetCurrentMethod().Name!;

            List<Customer> customers = ReadAll() ?? new List<Customer>();

            customers.Add(item);
            LogManager.WriteToLog(projectName, $"Starting {functionName}");

            using (FileStream XmlWriter = new FileStream(pathCustomer, FileMode.Create, FileAccess.Write))
            {
                serializer.Serialize(XmlWriter, customers);
            }
            LogManager.WriteToLog(projectName, $"{functionName} completed successfully.");


            return customers.Count;

        }

        public void Delete(int id)
        {
            string functionName = MethodBase.GetCurrentMethod().Name!;
            LogManager.WriteToLog(projectName, $"Starting {functionName}");


            List<Customer> customers = ReadAll() ?? new List<Customer>();

            Customer customerToRemove = customers.Find(c => c.Id == id);
            if (customerToRemove == null)
                throw new Exception("Customer not found to delete");

            customers.Remove(customerToRemove);

            using (FileStream XmlWriter = new FileStream(pathCustomer, FileMode.Create, FileAccess.Write))
            {
                serializer.Serialize(XmlWriter, customers);
            }
            LogManager.WriteToLog(projectName, $"{functionName} completed successfully.");

        }

        public Customer? Read(int id)
        {
            try
            {
                string functionName = MethodBase.GetCurrentMethod().Name!;
                LogManager.WriteToLog(projectName, $"Starting {functionName}");
                LogManager.WriteToLog(projectName, $"{functionName} completed successfully.");
                return ReadAll(c => c.Id == id).FirstOrDefault();
            }
            catch (Exception ex)
            {
                throw new Exception("לא נמצא ID");
            }

        }

        public Customer? Read(Func<Customer, bool> filter)
        {
            string functionName = MethodBase.GetCurrentMethod().Name!;
            LogManager.WriteToLog(projectName, $"Starting {functionName}");
            LogManager.WriteToLog(projectName, $"{functionName} completed successfully.");
            return ReadAll(filter).FirstOrDefault();

        }

        public List<Customer?> ReadAll(Func<Customer, bool>? filter = null)
        {
            try
            {
                string functionName = MethodBase.GetCurrentMethod().Name!;
                if (!File.Exists(pathCustomer)) return new List<Customer>();
                LogManager.WriteToLog(projectName, $"Starting {functionName}");

                using (FileStream fs = new FileStream(pathCustomer, FileMode.Open))
                {
                    List<Customer> customers = (List<Customer>)serializer.Deserialize(fs);
                    if (filter == null)
                        return customers.Cast<Customer?>().ToList();
                    return customers.Where(filter).Cast<Customer?>().ToList();
                }
                LogManager.WriteToLog(projectName, $"{functionName} completed successfully.");

            }
            catch (Exception e)
            {
                throw new Exception("Error in ReadAll xml: " + e.Message, e);
            }
        }

        public void Update(Customer item)
        {
            string functionName = MethodBase.GetCurrentMethod().Name!;
            LogManager.WriteToLog(projectName, $"Starting {functionName}");
            Delete(item.Id);
            Create(item);
            LogManager.WriteToLog(projectName, $"{functionName} completed successfully.");

        }
    }
}
