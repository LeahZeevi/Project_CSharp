
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    internal static class Tools
    {
        public static BO.Customer ConvertDoClientToBoClient(this DO.Customer customer)
        {
            return new BO.Customer(customer.CustomerId, customer.CustomerName, customer.Adress, customer.CustomerPhone);
        }
        public static BO.Product ConvertDoProductToBoProduct(this DO.Product product)
        {
            try
            {
                return new BO.Product(product.ProductId, product.ProductName, (BO.Category)product.CategoryName, product.Price, product.AmountInStock);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static BO.Sale ConvertDoSaleToBoSale(this DO.Sale sale)
        {
            return new BO.Sale(sale.SaleId, sale.ProductId, sale.CountForSale, sale.FinalPrice, sale.IsForAll, sale.DateStartSale, sale.DateEndSale);
        }

        public static DO.Customer ConvertBoClientToDoClient(this BO.Customer customer)
        {
            return new DO.Customer(customer.CustomerId, customer.CustomerName, customer.Adress, customer.CustomerPhone);
        }
        public static DO.Product ConvertBoProductToDoProduct(this BO.Product product)
        {
            return new DO.Product(product.ProductId, product.ProductName, (DO.Category)product.CategoryName, product.Price, product.AmountInStock);
        }
        public static DO.Sale ConvertBoSaleToDoSale(this BO.Sale sale)
        {
            return new DO.Sale(sale.SaleId, sale.ProductId, sale.CountForSale, sale.FinalPrice, sale.IsForAll, sale.DateStartSale, sale.DateEndSale);
        }
        public static string ToStringProperty<T>(this T obj)
        {
            if (obj == null) return "null";

            Type type = typeof(T);
            StringBuilder sb = new StringBuilder();
            PropertyInfo[] properties = type.GetProperties();

            foreach (PropertyInfo p in properties)
            {
                sb.AppendLine($"{p.Name}: {p.GetValue(obj)?.ToString() ?? "null"}");
            }

            return sb.ToString();
        }

        internal static Product ConvertBoProductToDoClient(DO.Product p)
        {
            throw new NotImplementedException();
        }
    }
}
