using DalApi;
using DO;
using System.Reflection;
using Tools;

namespace DAL;

public class ProductImplementation : IProduct
{
    public int Create(Product p)
    {
        LogManager.Enter();
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"insert product from the system id:{p.ProductId}");
        Product product = p with { ProductId = DataSource.Config.ProductId };
        DataSource.prudacts.Add(product);
        LogManager.Exit();
        return product.ProductId;
    }

    public void Delete(int id)
    {
        LogManager.Enter();
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"delete product from the system id:{id}");
        Product p = Read(id);
        if (p != null)
        {
            DataSource.prudacts.Remove(p);
        }
        else
        {
            LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "the product not exist");
            LogManager.Exit();
            throw new Exception("the product not exist");
        }
        LogManager.Exit();
    }

    public Product? Read(int id)
    {
        LogManager.Enter();
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"read product from the system id:{id}");
        foreach (Product p in DataSource.prudacts)
        {
            if (p.ProductId == id)
            {
                LogManager.Exit();
                return p;
            }
        }
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "the product not exist");
        LogManager.Exit();
        throw new Exception("the product not exist");
    }

    public Product? Read(Func<Product, bool> filter)
    {
        LogManager.Enter();
        Product p = DataSource.prudacts.FirstOrDefault(p => filter(p));
        if (p == default)
        {
            LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "the product not exist");
            LogManager.Exit();
            throw new DalIdNotExistsException("the product is not exists");
        }
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"read product from the system id:{p.ProductId}");
        LogManager.Exit();
        return p;
    }

    public List<Product?> ReadAll(Func<Product, bool>? filter = null)
    {
        LogManager.Enter();
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"read all products from the system");
        if (filter == null)
        {
            LogManager.Exit();
            return new List<Product>(DataSource.prudacts);
        }
        var allProductFilter = DataSource.prudacts.Where(p => filter(p)).ToList();
        LogManager.Exit();
        return allProductFilter;
    }

    public void Update(Product item)
    {
        LogManager.Enter();
        Delete(item.ProductId);
        DataSource.prudacts.Add(item);

        bool exist = false;
        foreach (Product p in DataSource.prudacts)
        {
            if (p.ProductId == item.ProductId)
            {
                LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"update product from the system id:{item.ProductId}");
                Delete(p.ProductId);
                DataSource.prudacts.Add(item);
                exist = true;
                break;
            }
        }
        if (!exist)
        {
            LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"update not sucessful the product id:{item.ProductId}is not exists ");
            LogManager.Exit();
            throw new Exception("update not sucessful the product not exists");
        }
        LogManager.Exit();
    }
}
