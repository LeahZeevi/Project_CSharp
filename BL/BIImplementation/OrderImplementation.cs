using BLApi;
using BO;
using DO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIImplementation
{
    internal class OrderImplementation : Iorder
    {
        private DalApi.IDal _dal = DalApi.Factory.Get;
        public List<SaleInProduct> AddProductToOrder(Order order, int productId, int amountInOrder)
        {
            try
            {
                BO.Product product = _dal.Product.Read(productId).ConvertDoProductToBoProduct();

                BO.ProductInOrder p = order.ProductList.FirstOrDefault(p => p.ProductId == productId);
                if (p != null)
                {
                    if (product.AmountInStock < p.AmountInOrder)
                        throw new BLMissingDataException("אין מספיק ממוצר זה במלאי!!");
                    else
                        p.AmountInOrder += amountInOrder;
                    return p.SaleList;
                }

                else
                {
                    if (product.AmountInStock < amountInOrder)
                        throw new BLMissingDataException("אין מספיק ממוצר זה במלאי!!");
                    ProductInOrder newProduct = new ProductInOrder(product.ProductId, product.ProductName, product.Price, amountInOrder);
                    SearchSaleForProduct(newProduct, order.IsFavorite);
                    CalcTotalPriceForProduct(newProduct);
                    order.ProductList.Add(newProduct);
                    CalcTotalPrice(order);
                    return newProduct.SaleList;
                }
            }
            catch (DalIdNotExistsException ex)
            {
                throw new BlIdNotExistsException(ex.Message, ex);
            }
        }

        public void CalcTotalPrice(Order order)
        {
            order.OrderPrice = order.ProductList.Sum(p => p.FinalPrice);
        }

        public void CalcTotalPriceForProduct(ProductInOrder productInOrder)
        {
            List<SaleInProduct> useSaleInOrder = new List<SaleInProduct>();
            int count = productInOrder.AmountInOrder;
            if (count <= 0)
            {
                return;
            }
            foreach (var item in productInOrder.SaleList)
            {
                if (count < item.CountForSale) continue;
                productInOrder.FinalPrice += count / item.CountForSale * item.Price;
                count %= item.CountForSale;
                useSaleInOrder.Add(item);
                if (count == 0) break;
            }
            if (count != 0)
            {
                productInOrder.FinalPrice = count * productInOrder.BasicPrice;
            }
            productInOrder.SaleList = useSaleInOrder;
        }

        public void DoOrder(Order order)
        {
            try
            {
                var update = order.ProductList.Select(p =>
                {
                    var x = _dal.Product.Read(p.ProductId);
                    if (x.AmountInStock < p.AmountInOrder)
                        throw new BLMissingDataException("אין מספיק מלאי למוצר");
                    return x with { AmountInStock = x.AmountInStock - p.AmountInOrder };
                }).ToList();
                foreach (var x in update)
                {
                    _dal.Product.Update(x);
                }
            }
            catch(DalIdNotExistsException ex)
            {
                throw new BlIdNotExistsException(ex.Message, ex);
            }

        }


        public void SearchSaleForProduct(ProductInOrder productInOrder, bool isFavorate)
        {
            try
            {
                productInOrder.SaleList = _dal.Sale.ReadAll(s => s.ProductId == productInOrder.ProductId &&
                s.DateStartSale <= DateTime.Now && s.DateEndSale >= DateTime.Now && s.CountForSale <= productInOrder.AmountInOrder && (isFavorate == false && s.IsForAll == true) || (isFavorate == true))
                    .Select(s => new BO.SaleInProduct(s.ProductId, s.CountForSale, s.FinalPrice, s.IsForAll))
                    .OrderBy(s => s.Price).ToList();
             
            }
            catch(DalNotFound ex)
            {
                throw new BLMissingDataException(ex.Message, ex);
            }
        }
    }
}
