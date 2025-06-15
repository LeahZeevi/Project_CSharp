namespace DO
{
    public record Sale
        (int SaleId, int ProductId, int CountForSale, double FinalPrice,
        bool IsForAll, DateTime DateStartSale, DateTime DateEndSale)
    {
        public bool IsForAllSale { get; set; }
        public Sale():this(0,0,0,0,false,default,default)
        {

        }
    }
}
