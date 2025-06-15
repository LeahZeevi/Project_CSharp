using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    public class Sale
    {
        public int SaleId { get; init; }
        public int ProductId { get; init; }
        public int CountForSale { get; set; }
        public double FinalPrice { get; set; }
        public bool IsForAll { get; set; }
        public DateTime DateStartSale { get; set; }
        public DateTime DateEndSale { get; set; }

        public Sale(int saleId, int productId, int countForSale, double finalPrice, bool isForSale, DateTime dateStartSale, DateTime dateEndSale)
        {
            SaleId = saleId;
            ProductId = productId;
            CountForSale = countForSale;
            FinalPrice = finalPrice;
            IsForAll = isForSale;
            DateStartSale = dateStartSale;
            DateEndSale = dateEndSale;
        }

        public Sale(int saleId, int productId, int countForSale, bool isForAll, double finalPrice, DateTime dateStartSale, DateTime dateEndSale)
        {
            SaleId = saleId;
            ProductId = productId;
            CountForSale = countForSale;
            IsForAll = isForAll;
            FinalPrice = finalPrice;
            DateStartSale = dateStartSale;
            DateEndSale = dateEndSale;
        }

        public override string ToString()
        {
            return $"קוד מבצע: {SaleId}\nקוד מוצר: {ProductId}\nכמות למבצע: {CountForSale}\n האם המבצע מיועד לכולם?:{IsForAll}\nמחיר לאחר מבצע: {FinalPrice}\n תאריך תחילת הבצע:{DateStartSale} תאריך סיום המבצע:{DateEndSale}";
        }
    }
}
