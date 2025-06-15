using DO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    public class Product
    {

        public int ProductId { get; init; }
        public string ProductName { get; init; }
        public Category CategoryName { get; set; }
        public double Price { get; set; }
        public int AmountInStock { get; set; }

        public List<SaleInProduct> SaleList;

        public Product(int productId, string productName, Category categoryName, double price, int amountInStock)
        {
            ProductId = productId;
            ProductName = productName;
            CategoryName = categoryName;
            Price = price;
            AmountInStock = amountInStock;
            SaleList = new List<SaleInProduct>();
        }

        public override string ToString()
        {
            return $"Id: {ProductId}\nProduct name: {ProductName}\nCategory: {CategoryName}\nPrice: {Price}\nA mount in stock: {AmountInStock}";
        }
    }
}
