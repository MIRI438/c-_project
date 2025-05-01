using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using DalApi;

namespace Dal
{
    internal static class Config
    {
        public const string data_config = @"..\xml\data-config.xml";


        public static int ProductCode => int.Parse(XmlTools.GetValueByName("ProductCode"));
        public static int SaleCode => int.Parse(XmlTools.GetValueByName("SaleCode"));





    }
}
