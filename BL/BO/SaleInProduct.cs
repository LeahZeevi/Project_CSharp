using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    public class SaleInProduct
    {
        public int ProductId { get; init; }
        public int CountForSale { get; set; }
        public double Price { get; set; }
        public bool IsForAll { get; set; }
        public SaleInProduct(int productId,int countForSale,double price,bool isForAll)
        {
            ProductId = productId;
            CountForSale = countForSale;
            Price = price;
            IsForAll = isForAll;
        }
    }
}
