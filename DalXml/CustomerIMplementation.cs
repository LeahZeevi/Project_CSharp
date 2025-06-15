using DalApi;
using DO;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Dal
{
    internal class CustomerIMplementation : ICustomer
    {
        const string PATH_CUSTOMERS = "../xml/customers.xml";
        const string CUSTOMER = "Customer";
        const string CUSTOMERID = "CustomerId";
        const string CUSTOMERNAME = "CustomerName";
        const string ADRESS = "Adress";
        const string CUSTOMERPHONE = "CustomerPhone";

        XElement root;
        public int Create(Customer item)
        {
            root = XElement.Load(PATH_CUSTOMERS);
            XElement customer = root.Elements(CUSTOMER).FirstOrDefault(c => c.Element(CUSTOMERID).Value == item.CustomerId.ToString());
            if (customer != null)
                throw new DalIdExistsException($"לקוח עם תעודת זהות זו קיים במערכת!");
            root.Add(new XElement(CUSTOMER,
               new XElement(CUSTOMERID, item.CustomerId)
                , new XElement(CUSTOMERNAME, item.CustomerName),
                     new XElement(ADRESS, item.Adress),
                     new XElement(CUSTOMERPHONE, item.CustomerPhone)));
            root.Save(PATH_CUSTOMERS);
            return item.CustomerId;
        }

        public void Delete(int id)
        {
            root = XElement.Load(PATH_CUSTOMERS);

            XElement customer = root.Descendants(CUSTOMERID).FirstOrDefault(c => c.Value == id.ToString()).Parent;
            if (customer == null)
                throw new DalIdNotExistsException("תעודת זהות  זו אינה קיימת במערכת!!");
            customer.Remove();
            root.Save(PATH_CUSTOMERS);
        }

        public Customer? Read(int id)
        {
            root = XElement.Load(PATH_CUSTOMERS);

            XElement customer = root.Descendants(CUSTOMERID).FirstOrDefault(c => c.Value == id.ToString()).Parent;
            if (customer != null)
            {
                return new Customer(int.Parse(customer.Element(CUSTOMERID).Value),
                    customer.Element(CUSTOMERNAME).Value,
                    customer.Element(ADRESS).Value,
                    int.Parse(customer.Element(CUSTOMERPHONE).Value));
            }
            throw new DalIdNotExistsException("לא נמצא לקוח עם תעודת זהות זו!");

        }

   

        public Customer? Read(Func<Customer, bool> filter)
        {
            root = XElement.Load(PATH_CUSTOMERS);

            var customers = root.Descendants(CUSTOMER)
                .Select(c => new Customer(
                    int.Parse(c.Element(CUSTOMERID).Value)
                    , c.Element(CUSTOMERNAME).Value,
                    c.Element(ADRESS).Value,
                    int.Parse(c.Element(CUSTOMERPHONE).Value)));

            Customer c = customers.FirstOrDefault(filter);
            if (c == null)
                throw new DalNotFound("לא נמצא לקוח!");
            return c;
        }

        public List<Customer?> ReadAll(Func<Customer, bool>? filter=null)
        {
            root = XElement.Load(PATH_CUSTOMERS);

            List<Customer> customers = root.Descendants(CUSTOMER)
                     .Select(c => new Customer(
                     int.Parse(c.Element(CUSTOMERID).Value)
                    , c.Element(CUSTOMERNAME).Value,
                         c.Element(ADRESS).Value,
                         int.Parse(c.Element(CUSTOMERPHONE).Value))).ToList();

            if (filter != null)
                customers = customers.Where(c => filter(c)).ToList();
            if (customers == null)
                throw new DalNotFound("לא נמצאו לקוחות!");
            return customers;
        }
        public void Update(Customer item)
        {
            root = XElement.Load(PATH_CUSTOMERS);
            try
            {
                Delete(item.CustomerId);
                Create(item);
                root.Save(PATH_CUSTOMERS);
            }

            catch(Exception ex)
            {
                throw new DalIdNotExistsException("עדכון הלקוח נכשל! לא קיימת תעודת זהות זו");
            }
        }
    }
}
