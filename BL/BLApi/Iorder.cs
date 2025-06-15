using BO;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLApi
{
    public interface Iorder
    {
        List<SaleInProduct> AddProductToOrder(Order order, int productId, int amountInOrder);
        void CalcTotalPriceForProduct(ProductInOrder productInOrder);
        void CalcTotalPrice(Order order);
        void DoOrder(Order order);
        void SearchSaleForProduct(ProductInOrder productIn,bool isFavorate);

    }
}
