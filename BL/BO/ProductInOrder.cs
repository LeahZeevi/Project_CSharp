using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    public class ProductInOrder
    {
        public int ProductId { get; init; }
        public string ProductName { get; init; }
        public double BasicPrice { get; set; }
        public int AmountInOrder { get; set; }
        public List<SaleInProduct> SaleList=new List<SaleInProduct>();
        public double FinalPrice { get; set; }
        public ProductInOrder(int productId,string productName,double basicPrice,int amontInOrder)
        {
            ProductId = productId;
            ProductName = productName;
            BasicPrice = basicPrice;
            AmountInOrder = amontInOrder;
        }

    }
}
