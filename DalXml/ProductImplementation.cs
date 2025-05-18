using System.Reflection;
using System.Xml.Serialization;
using DalApi;
using DO;
using Tools;

namespace Dal
{
    internal class ProductImplementation : IProduct
    {
        const string pathProduct = "../xml/products.xml";
        static string projectName = MethodBase.GetCurrentMethod().DeclaringType.FullName!;

        XmlSerializer serializer = new XmlSerializer(typeof(List<Product>));

        public int Create(Product item)
        {
            string functionName = MethodBase.GetCurrentMethod().Name!;
            LogManager.WriteToLog(projectName, $"Starting {functionName}");
            List<Product> products = ReadAll() ?? new List<Product>();

            products.Add(item with { Id = Config.ProductCode});

            using (FileStream XmlWriter = new FileStream(pathProduct, FileMode.Create, FileAccess.Write))
            {
                serializer.Serialize(XmlWriter, products);
            }
            LogManager.WriteToLog(projectName, $"{functionName} completed successfully.");

            return products.Count;

        }

        public void Delete(int id)

        {
            string functionName = MethodBase.GetCurrentMethod().Name!;
            LogManager.WriteToLog(projectName, $"Starting {functionName}");
            List<Product> products = ReadAll() ?? new List<Product>();

            Product? productToRemove = products.Find(p => p.Id == id);
            if (productToRemove == null)
                throw new Exception(($"Product with ID {id} not found."));
            
            products.Remove(productToRemove);

            using (FileStream XmlWriter = new FileStream(pathProduct, FileMode.Create, FileAccess.Write))
            {
                serializer.Serialize(XmlWriter, products);
            }
            LogManager.WriteToLog(projectName, $"{functionName} completed successfully.");

        }

        public Product? Read(int id)
        {
            string functionName = MethodBase.GetCurrentMethod().Name!;
            LogManager.WriteToLog(projectName, $"Starting {functionName}");
            LogManager.WriteToLog(projectName, $"{functionName} completed successfully.");
            return ReadAll(p => p.Id == id).FirstOrDefault();

        }

        public Product? Read(Func<Product, bool> filter)
        {
            string functionName = MethodBase.GetCurrentMethod().Name!;
            LogManager.WriteToLog(projectName, $"Starting {functionName}");
            LogManager.WriteToLog(projectName, $"{functionName} completed successfully.");
            return ReadAll(filter).FirstOrDefault();

        }

        public List<Product?> ReadAll(Func<Product, bool>? filter = null)
        {
            try
            {
                string functionName = MethodBase.GetCurrentMethod().Name!;
                LogManager.WriteToLog(projectName, $"Starting {functionName}");
                if (!File.Exists(pathProduct)) return new List<Product>();

                using (FileStream fs = new FileStream(pathProduct, FileMode.Open))
                {
                    List<Product> products = (List<Product>)serializer.Deserialize(fs);
                    if(filter == null)
                        return products.Cast<Product?>().ToList();
                    LogManager.WriteToLog(projectName, $"{functionName} completed successfully.");
                    return products.Where(filter).Cast<Product?>().ToList();
                }

            }
            catch (Exception e)
            {
                throw new Exception("Error in ReadAll xml: " + e.Message, e);
            }
        }

        public void Update(Product item)
        {
            string functionName = MethodBase.GetCurrentMethod().Name!;
            LogManager.WriteToLog(projectName, $"Starting {functionName}");
            Delete(item.Id);
            Create(item);
            LogManager.WriteToLog(projectName, $"{functionName} completed successfully.");

        }

    }
}
