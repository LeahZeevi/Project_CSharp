using DO;

namespace DAL;

internal static class DataSource
{
    //רשימות שאמורות לכלןל הפניות לישויות
    internal static List<Customer?> customer = new();
    internal static List<Product?> prudacts = new();
    internal static List<Sale?> sails = new();

    internal static class Config
    {
        //עבור כל תכונת קוד שיצרנו בפרויקט יצרנו 2 שדות
        internal const int MinProductId = 100;
        internal const int MinSaleId = 10;
        private static int productId = MinProductId;

        public static int ProductId
        {
            get
            {
                return productId += 10;
            }
        }
        private static int saleId = MinSaleId;

        public static int SaleId
        {
            get
            {
                return saleId++;
            }
        }
    }
}
