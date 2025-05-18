using DO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DalApi;
using System.Xml.Serialization;
using System.Xml.Linq;
using System.Xml;
using System.Diagnostics;
using System.Reflection;
using Tools;

namespace Dal
{
    internal class SaleImplementation : ISale
    {
        const string pathSale = "../xml/sales.xml";
        static string projectName = MethodBase.GetCurrentMethod().DeclaringType.FullName!;

        public int Create(Sale item)
        {
            string functionName = MethodBase.GetCurrentMethod().Name!;
            LogManager.WriteToLog(projectName, $"Starting {functionName}");


            XElement xelement;
            if (File.Exists(pathSale))
            {
                xelement = XElement.Load(pathSale);
            }
            else
            {
                xelement = new XElement("Sales");
            }
            XElement newXel = new XElement("Sale",
               new XElement("Code", Config.SaleCode),
               new XElement("ProductId", item.ProductId),
               new XElement("MinQuantity", item.MinQuantity),
               new XElement("Price", item.Price),
               new XElement("InClab", item.InClab),
               new XElement("BeginSale", item.BeginSale),
               new XElement("EndSale", item.EndSale)
               );

            
            xelement.Add(newXel);
            xelement.Save(pathSale);
            LogManager.WriteToLog(projectName, $"{functionName} completed successfully.");

            return item.Code;

        }

        public void Delete(int id)
        {
            string functionName = MethodBase.GetCurrentMethod().Name!;
            LogManager.WriteToLog(projectName, $"Starting {functionName}");

            XElement xelement;
            if (!File.Exists(pathSale))
            {
                throw new Exception("the file not found");
            }
            else
            {
                xelement = XElement.Load(pathSale);
                XElement toRemove = xelement.Elements("Sale").FirstOrDefault(s => (int)s.Element("Code") == id);
                if (toRemove == null)
                    throw new Exception("לא נמצא הקוד מבצע");
                
             
                    toRemove.Remove();
                    xelement.Save(pathSale);
                LogManager.WriteToLog(projectName, $"{functionName} completed successfully.");


            }
        }

        public Sale? Read(int id)
        {
            string functionName = MethodBase.GetCurrentMethod().Name!;
            LogManager.WriteToLog(projectName, $"Starting {functionName}");

            XElement xelement;
            if (!File.Exists(pathSale))
                throw new Exception("the file not found");


            xelement = XElement.Load(pathSale);
            XElement find = xelement.Elements("Sale").FirstOrDefault(s => (int)s.Element("Code") == id);
            if (find == null)
                return null;

            if (!int.TryParse(find.Element("Code")?.Value, out int tCode))
                throw new InvalidDataException("Invalid Code value.");
            int tProductId;
            int.TryParse(find.Element("ProductId").Value, out tProductId);
            int tMinQuantity;
            int.TryParse(find.Element("MinQuantity").Value, out tMinQuantity);
            int tPrice;
            int.TryParse(find.Element("Price").Value, out tPrice);


            return new Sale {
                Code = tCode,
                ProductId = tProductId,
                MinQuantity = tMinQuantity,
                Price = tPrice,
                InClab = bool.Parse(find.Element("InClab").Value),
                BeginSale = DateTime.Parse(find.Element("BeginSale").Value),
                EndSale = DateTime.Parse(find.Element("EndSale").Value)
            };
            LogManager.WriteToLog(projectName, $"{functionName} completed successfully.");

        }

        public Sale? Read(Func<Sale, bool> filter)
        {
            string functionName = MethodBase.GetCurrentMethod().Name!;
            LogManager.WriteToLog(projectName, $"Starting {functionName}");

            return ReadAll(filter).FirstOrDefault();
            LogManager.WriteToLog(projectName, $"{functionName} completed successfully.");

        }

        public List<Sale?> ReadAll(Func<Sale, bool>? filter = null)
        {
            string functionName = MethodBase.GetCurrentMethod().Name!;
            LogManager.WriteToLog(projectName, $"Starting {functionName}");

            if (!File.Exists(pathSale))
                return new List<Sale?>();

            XElement xelement = XElement.Load(pathSale);
            List<Sale> sales = xelement.Elements("Sale").Select(s =>
            {
                try
                {
                    return new Sale
                    {
                        Code = int.TryParse(s.Element("Code")?.Value, out int code) ? code : throw new InvalidDataException("Invalid Code value."),
                        ProductId = int.TryParse(s.Element("ProductId")?.Value, out int productId) ? productId : throw new InvalidDataException("Invalid ProductId value."),
                        MinQuantity = int.TryParse(s.Element("MinQuantity")?.Value, out int minQuantity) ? minQuantity : throw new InvalidDataException("Invalid MinQuantity value."),
                        Price = double.TryParse(s.Element("Price")?.Value, out double price) ? price : throw new InvalidDataException("Invalid Price value."),
                        InClab = bool.TryParse(s.Element("InClab")?.Value, out bool inClab) ? inClab : throw new InvalidDataException("Invalid InClab value."),
                        BeginSale = DateTime.TryParse(s.Element("BeginSale")?.Value, out DateTime beginSale) ? beginSale : throw new InvalidDataException("Invalid BeginSale value."),
                        EndSale = DateTime.TryParse(s.Element("EndSale")?.Value, out DateTime endSale) ? endSale : throw new InvalidDataException("Invalid EndSale value.")
                    };
                }
                catch (Exception ex)
                {
                    Debug.WriteLine($"Error parsing Sale: {ex.Message}");
                    return null; // החזר null במקרה של שגיאה
                }
            }).Where(s => s != null).ToList();
            LogManager.WriteToLog(projectName, $"{functionName} completed successfully.");

            return filter != null ? sales.Where(filter).ToList() : sales;

        }


        public void Update(Sale item)
        {
            string functionName = MethodBase.GetCurrentMethod().Name!;
            LogManager.WriteToLog(projectName, $"Starting {functionName}");

            Delete(item.Code);
            Create(item);
            LogManager.WriteToLog(projectName, $"{functionName} completed successfully.");

        }
    }
}
