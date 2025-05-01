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

namespace Dal
{
    internal class SaleImplementation : ISale
    {
        const string pathSale = "../xml/sales.xml";


        public int Create(Sale item)
        {
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

            return item.Code;

        }

        public void Delete(int id)
        {
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

                
            }
        }

        public Sale? Read(int id)
        {
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
        }

        public Sale? Read(Func<Sale, bool> filter)
        {
            return ReadAll(filter).FirstOrDefault();
        }

        public List<Sale?> ReadAll(Func<Sale, bool>? filter = null)
        {
            XElement xelement;
            if (!File.Exists(pathSale))
                return new List<Sale?>();
            
            xelement = XElement.Load(pathSale);
            List<Sale> sales = xelement.Elements("Sale").Select(s => new Sale
            {
                Code = int.Parse(s.Element("Code").Value),
                ProductId = int.Parse(s.Element("ProductId").Value),
                MinQuantity = int.Parse(s.Element("MinQuantity").Value),
                Price = int.Parse(s.Element("Price").Value),
                InClab = bool.Parse(s.Element("InClab").Value),
                BeginSale = DateTime.Parse(s.Element("BeginSale").Value),
                EndSale = DateTime.Parse(s.Element("EndSale").Value)
            }).ToList();

            return filter != null ? sales.Where(filter).ToList() : sales;
        }

        public void Update(Sale item)
        {
            Delete(item.Code);
            Create(item);
            
        }
    }
}
