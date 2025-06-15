namespace DO
{
    public record Customer
        (int CustomerId, string CustomerName, string Adress, int CustomerPhone)
    {
        public Customer() : this(0, "", "", 0)
        {

        }
      
        
            
        
    }
}

