namespace DO
{
    public record Product(int ProductId, string ProductName, Category CategoryName, double Price, int AmountInStock)
    {
        public Product() :this(0, null,default, 0, 0)
        {
        }
    }
}