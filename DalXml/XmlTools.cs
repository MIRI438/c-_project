using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DalApi;
using System.Xml.Linq;

namespace Dal
{
    internal static class XmlTools
    {
        public static string GetValueByName(string name)
        {
            // טוען את קובץ ה-XML
            XElement dataConfig = XElement.Load(Config.data_config) ??
                throw new DalConfigException("data config is missing");

            // מוצא את האלמנט לפי השם
            XElement? element = dataConfig.Element(name) ??
                throw new DalConfigException($"<{name}> element is missing");

            // מעלה את הערך ב-1
            int val = int.Parse(element.Value) + 1;

            // מעדכן את הערך ב-XML
            element.Value = val.ToString();

            // שומר את הקובץ
            dataConfig.Save(Config.data_config);

            // מחזיר את הערך החדש
            return val.ToString();
        }
    }

}
