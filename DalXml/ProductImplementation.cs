using DalApi;
using DO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Dal
{
    internal class ProductImplementation : IProduct
    {
        const string PATH_PRODUCTS = "../xml/products.xml";
        XmlSerializer serializer = new XmlSerializer(typeof(List<Product>));
        List<Product> products;
        public int Create(Product item)
        {
            using (StreamReader streamReader = new StreamReader(PATH_PRODUCTS))
            {
                products = serializer.Deserialize(streamReader) as List<Product>;
            }
           
            Product p = products.FirstOrDefault(p => p.ProductId == item.ProductId);
            if (p != null)
            {
                throw new DalIdExistsException("!קוד מוצר זה קיים כבר במערכת!");
            }
            products.Add(item);
            using (StreamWriter streamWriter = new StreamWriter(PATH_PRODUCTS))
            {
                serializer.Serialize(streamWriter, products);
            }
            return item.ProductId;
        }

        public void Delete(int id)
        {
            using (StreamReader streamReader = new StreamReader(PATH_PRODUCTS))
            {
                products = serializer.Deserialize(streamReader) as List<Product>;
                Product p = products.FirstOrDefault(p => p.ProductId == id);
                if (p == null) throw new Dalfailed("מחיקת המוצר נכשלה לא נמצא מוצר עם קוד זה!");
            }
            using (StreamWriter streamWriter = new StreamWriter(PATH_PRODUCTS))
            {
                serializer.Serialize(streamWriter, products);
            }
        }

        public Product? Read(int id)
        {
            Product p;
            using (StreamReader streamReader = new StreamReader(PATH_PRODUCTS))
            {
                products = serializer.Deserialize(streamReader) as List<Product>;
                p = products.FirstOrDefault(p => p.ProductId == id);
                if (p == null)
                    throw new DalIdNotExistsException($"לא נמצא מוצר עם קוד {id}");
            }
            using (StreamWriter streamWriter = new StreamWriter(PATH_PRODUCTS))
            {
                serializer.Serialize(streamWriter, products);
            }
            return p;
        }

        public Product? Read(Func<Product, bool> filter)
        {
            Product p;
            using (StreamReader streamReader = new StreamReader(PATH_PRODUCTS))
            {
                products = serializer.Deserialize(streamReader) as List<Product>;
                p = products.FirstOrDefault(p => filter(p));
                if (p == null)
                    throw new DalIdNotExistsException($"לא נמצא מוצר!");
            }
            using (StreamWriter streamWriter = new StreamWriter(PATH_PRODUCTS))
            {
                serializer.Serialize(streamWriter, products);
            }
            return p;
        }

        public List<Product?> ReadAll(Func<Product, bool>? filter = null)
        {
            using (StreamReader streamReader = new StreamReader(PATH_PRODUCTS))
            {
                products = serializer.Deserialize(streamReader) as List<Product>;
            }
            if (products == null) throw new DalNotFound("לא קיימים מוצרים במערכת!");
            using (StreamWriter streamWriter = new StreamWriter(PATH_PRODUCTS))
            {
                serializer.Serialize(streamWriter, products);
            }
            if (filter != null)
                products = products.Where(p => filter(p)).ToList();
            if (products == null)
                throw new DalNotFound($"לא נמצאו מוצרים!");
            return products;
        }

        public void Update(Product item)
        {
            Product p;
            using (StreamReader streamReader = new StreamReader(PATH_PRODUCTS))
            {
                products = serializer.Deserialize(streamReader) as List<Product>;
                p = products.FirstOrDefault(p => p.ProductId == item.ProductId);

                if (p == null) throw new DalIdNotExistsException("לא קיים מוצר עם קוד זה!");
                products.Remove(p);
                products.Add(item);
            }
            using (StreamWriter streamWriter = new StreamWriter(PATH_PRODUCTS))
            {
                serializer.Serialize(streamWriter, products);
            }
        }
    }
}
