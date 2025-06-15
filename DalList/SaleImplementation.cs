using DalApi;
using DO;
using System.Reflection;
using Tools;

namespace DAL;
public class SaleImplementation : ISale
{
    public int Create(Sale s)
    {
        LogManager.Enter();
       DO.Sale sale = s with { SaleId = DataSource.Config.SaleId };
        DataSource.sails.Add(sale);
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"add sale for the system id:{sale.ProductId}");
        LogManager.Exit();
        return sale.ProductId;
    }

    public void Delete(int id)
    {
        LogManager.Enter();
        Sale s = Read(id);
        if (s != null)
        {
            LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"delete sale from the system id:{id}");
            DataSource.sails.Remove(s);
            LogManager.Exit();
        }
        else
        {
            LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "the sale not exist");
            LogManager.Exit();
            throw new Exception("the sale not exist");
        }
    }

    public Sale? Read(int id)
    {
        LogManager.Enter();
        if (DataSource.sails[id] == null)
        {
            LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "the sale not exist");
            LogManager.Exit();
            throw new Exception("the sale not exist");
        }
        else
        {
            LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"read sale from the system id:{id}");
            LogManager.Exit();
            return DataSource.sails[id];
        }
    }

    public Sale? Read(Func<Sale, bool> filter)
    {
        LogManager.Enter();
        Sale s = DataSource.sails.FirstOrDefault(s => filter(s));
        if (s == default)
        {
            LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "the sale not exist");
            LogManager.Exit();
            throw new DalIdNotExistsException("the sale not exists");
        }
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"read sale from the system id:{s.ProductId}");
        LogManager.Exit();
        return s;
    }

    public List<Sale?> ReadAll(Func<Sale, bool>? filter = null)
    {
        LogManager.Enter();
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"read all sales from the system");
        if (filter == null)
        {
            LogManager.Exit();
            return new List<Sale>(DataSource.sails);
        }

        var allSaleFilter = DataSource.sails.Where(s => filter(s)).ToList();
        LogManager.Exit();
        return allSaleFilter;
    }

    public void Update(Sale item)
    {
        LogManager.Enter();
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"update sale in the system id:{item.ProductId}");
        Delete(item.SaleId);
        DataSource.sails.Add(item);
        LogManager.Exit();
    }
}
