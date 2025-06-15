using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    public class Order
    {
        public bool IsFavorite { get; set; }
        public List<ProductInOrder> ProductList = new List<ProductInOrder>();
        public double OrderPrice;
     
    }
}
