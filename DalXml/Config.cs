using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace DalXml
{
    internal static class Config
    {
        const string DATA_CONFIG = "data-config";
        const string PRODUCTID = "productId";
        const string SALEID = "saleId";


        public static int ProductId
        {
            get
            {
                XElement root = XElement.Load(DATA_CONFIG);
                int productId = int.Parse(root.Element(PRODUCTID).Value);
                root.Element(PRODUCTID).SetValue(productId += 10);
                return productId;
            }
        }
        private static int saleId;

        public static int SaleId
        {
            get
            {
                XElement root = XElement.Load(DATA_CONFIG);
                int saleId = int.Parse(root.Element(SALEID).Value);
                root.Element(SALEID).SetValue(saleId++);
                return saleId;
            }
        }
    }

}

