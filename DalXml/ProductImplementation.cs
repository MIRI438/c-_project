using System.Xml.Serialization;
using DalApi;
using DO;

namespace Dal
{
    internal class ProductImplementation : IProduct
    {
        const string pathProduct = "../xml/products.xml";

        XmlSerializer serializer = new XmlSerializer(typeof(List<Product>));

        public int Create(Product item)
        {
            List<Product> products = ReadAll() ?? new List<Product>();

            products.Add(item with { Id = Config.ProductCode});

            using (FileStream XmlWriter = new FileStream(pathProduct, FileMode.Create, FileAccess.Write))
            {
                serializer.Serialize(XmlWriter, products);
            }

            return products.Count;

        }

        public void Delete(int id)

        {
            List<Product> products = ReadAll() ?? new List<Product>();

            Product? productToRemove = products.Find(p => p.Id == id);
            if (productToRemove == null)
                throw new Exception(($"Product with ID {id} not found."));
            
            products.Remove(productToRemove);

            using (FileStream XmlWriter = new FileStream(pathProduct, FileMode.Create, FileAccess.Write))
            {
                serializer.Serialize(XmlWriter, products);
            }
        }

        public Product? Read(int id)
        {
            return ReadAll(p => p.Id == id).FirstOrDefault();
        }

        public Product? Read(Func<Product, bool> filter)
        {
            return ReadAll(filter).FirstOrDefault();
        }

        public List<Product?> ReadAll(Func<Product, bool>? filter = null)
        {
            try
            {
                if (!File.Exists(pathProduct)) return new List<Product>();

                using (FileStream fs = new FileStream(pathProduct, FileMode.Open))
                {
                    List<Product> products = (List<Product>)serializer.Deserialize(fs);
                    if(filter == null)
                        return products.Cast<Product?>().ToList();
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
            Delete(item.Id);
            Create(item);
        }

    }
}
