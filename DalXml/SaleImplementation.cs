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
    internal class SaleImplementation : ISale
    {
        const string PATH_SALE = "../xml/sales.xml";
        XmlSerializer serializer = new XmlSerializer(typeof(List<Sale>));
        List<Sale> sales;
        public int Create(Sale item)
        {
            List<Sale> sales;
            using (StreamReader streamReader = new StreamReader(PATH_SALE))
            {
                sales = serializer.Deserialize(streamReader) as List<Sale>;
            }
          
            Sale s = sales.FirstOrDefault(s => s.SaleId == item.SaleId);
            if (s != null)
            {
                throw new DalIdExistsException("קוד מבצע זה כבר קיים !!");
            }
                sales.Add(item);
            using (StreamWriter streamWriter = new StreamWriter(PATH_SALE))
            {
                serializer.Serialize(streamWriter, sales);
            }
            return item.SaleId;
        }

        public void Delete(int id)
        {
            using (StreamReader streamReader = new StreamReader(PATH_SALE))
            {
                sales = serializer.Deserialize(streamReader) as List<Sale>;
            }
            Sale s = sales.FirstOrDefault(s => s.SaleId == id);
            if (s == null)
                throw new DalIdNotExistsException("לא קיים מבצע עם קוד זה!");
            sales.Remove(s);
            using (StreamWriter streamWriter = new StreamWriter(PATH_SALE))
            {
                serializer.Serialize(streamWriter, sales);
            }
        }

        public Sale? Read(int id)
        {
            Sale s;
            using (StreamReader streamReader = new StreamReader(PATH_SALE))
            {
                sales = serializer.Deserialize(streamReader) as List<Sale>;
                s = sales.FirstOrDefault(s => s.SaleId == id);
            }
            if (s == null) throw new DalIdNotExistsException("לא קיים מבצע עם קוד זה!");
            using (StreamWriter streamWriter = new StreamWriter(PATH_SALE))
            {
                serializer.Serialize(streamWriter, sales);
            }
            return s;
        }

        public Sale? Read(Func<Sale, bool> filter)
        {
            Sale s;
            using (StreamReader streamReader = new StreamReader(PATH_SALE))
            {
                sales = serializer.Deserialize(streamReader) as List<Sale>;
                s = sales.FirstOrDefault(s => filter(s));
            }
            if (s == null) throw new DalNotFound("לא קיים מבצע כזה!!");
            using (StreamWriter streamWriter = new StreamWriter(PATH_SALE))
            {
                serializer.Serialize(streamWriter, sales);
            }
            return s;
        }

        public List<Sale?> ReadAll(Func<Sale, bool>? filter = null)
        {
            using (StreamReader streamReader = new StreamReader(PATH_SALE))
            {
                sales = serializer.Deserialize(streamReader) as List<Sale>;
            }
                if (sales == null) throw new DalNotFound("לא קיימים מבצעים במערכת!");
                
                using (StreamWriter streamWriter = new StreamWriter(PATH_SALE))
                {
                    serializer.Serialize(streamWriter, sales);
                }
            
            if (filter != null)
                sales = sales.Where(s => filter(s)).ToList();
            if (sales == null) throw new  DalNotFound("לא נמצאו מבצעים");
       
            return sales; 
        }

        public void Update(Sale item)
        {
            using (StreamReader streamReader = new StreamReader(PATH_SALE))
            {
                sales = serializer.Deserialize(streamReader) as List<Sale>;
            }
            Sale s = sales.First(s => s.SaleId == item.SaleId);
            if (s == null)
                throw new DalIdNotExistsException($"the saleId: {item.SaleId} not exist");
            sales.Remove(s);
            sales.Add(item);
            using (StreamWriter streamWriter = new StreamWriter(PATH_SALE))
            {
                serializer.Serialize(streamWriter, sales);
            }
        }
    }
}
