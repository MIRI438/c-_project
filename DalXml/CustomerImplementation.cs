using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using DalApi;
using DO;

namespace Dal
{
    internal class CustomerImplementation : ICustomer
    {
        const string pathCustomer = "../xml/customers.xml";

        XmlSerializer serializer = new XmlSerializer(typeof(List<Customer>));

        public int Create(Customer item)
        {
            List<Customer> customers = ReadAll() ?? new List<Customer>();

            customers.Add(item);

            using (FileStream XmlWriter = new FileStream(pathCustomer, FileMode.Create, FileAccess.Write))
            {
                serializer.Serialize(XmlWriter, customers);
            }

            return customers.Count;

        }

        public void Delete(int id)

        {
            List<Customer> customers = ReadAll() ?? new List<Customer>();

            Customer customerToRemove = customers.Find(c => c.Id == id);
            if (customerToRemove == null)
                throw new Exception("Customer not found to delete");

            customers.Remove(customerToRemove);

            using (FileStream XmlWriter = new FileStream(pathCustomer, FileMode.Create, FileAccess.Write))
            {
                serializer.Serialize(XmlWriter, customers);
            }
        }

        public Customer? Read(int id)
        {
            return ReadAll(c => c.Id == id).FirstOrDefault();
        }

        public Customer? Read(Func<Customer, bool> filter)
        {
            return ReadAll(filter).FirstOrDefault();
        }

        public List<Customer?> ReadAll(Func<Customer, bool>? filter = null)
        {
            try
            {
                if (!File.Exists(pathCustomer)) return new List<Customer>();

                using (FileStream fs = new FileStream(pathCustomer, FileMode.Open))
                {
                    List<Customer> customers = (List<Customer>)serializer.Deserialize(fs);
                    if (filter == null)
                        return customers.Cast<Customer?>().ToList();
                    return customers.Where(filter).Cast<Customer?>().ToList();
                }
            }
            catch (Exception e)
            {
                throw new Exception("Error in ReadAll xml: " + e.Message, e);
            }
        }

        public void Update(Customer item)
        {

            Delete(item.Id);
            Create(item);

        }
    }
}
