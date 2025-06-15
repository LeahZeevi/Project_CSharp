using DalApi;

namespace DAL;

internal sealed class DalList : IDal
{
    public ICustomer Customer => new CustomerImplementation();
    public IProduct Product => new ProductImplementation();
    public ISale Sale => new SaleImplementation();
    public static DalList Instance { get; } = new DalList();
    private DalList()
    {

    }

}
