using DO;
using DalApi;
using System.Reflection;
using Tools;

namespace DAL;

public class CustomerImplementation : ICustomer
{
    public int Create(Customer c)
    {
        LogManager.Enter();
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"insert customer in the system id:{c.CustomerId}");
        foreach (Customer item in DataSource.customer)
        {
            if (c.CustomerId == item.CustomerId)
            {
                LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "This customer exists an the system on this id");
                LogManager.Exit();
                throw new Exception("קיים לקוח במערכת על תעודת זהות זו ");
            }
        }
        DataSource.customer.Add(c);
        LogManager.Exit();
        return c.CustomerId;
    }

    public void Delete(int id)
    {
        LogManager.Enter();
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"delete customer in the system id:{id}");
        Customer c = Read(id);
        if (c != null)
        {
            DataSource.customer.Remove(c);
        }
        else
        {
            LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "This customer not exists an the system");
            LogManager.Exit();
            throw new Exception("the customer is not exists");
        }
        LogManager.Exit();
    }

    public Customer? Read(int id)
    {
        LogManager.Enter();
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"read customer from the system id:{id}");
        foreach (Customer customer in DataSource.customer)
        {
            if (customer.CustomerId == id)
                LogManager.Exit();
            return customer;
        }
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "This customer not exists an the system");
        LogManager.Exit();
        throw new Exception("the customer is not exists");


    }

    public Customer? Read(Func<Customer, bool> filter)
    {
        LogManager.Enter();
        var customer = DataSource.customer.FirstOrDefault(c => filter(c));
        if (customer == default)
        {
            LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "This customer not exists an the system");
            LogManager.Exit();
            throw new DalIdNotExistsException("the customer is not exists");
        }
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"read customer from the system id:{customer.CustomerId}");
        LogManager.Exit();
        return customer;
    }

    public List<Customer?> ReadAll(Func<Customer, bool>? filter = null)
    {
        LogManager.Enter();
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"read allcustomers from the system");
        if (filter == null)
        {
            LogManager.Exit();
            return new List<Customer>(DataSource.customer);
        }
        var readAllFilter = DataSource.customer.Where(c => filter(c)).ToList();
        LogManager.Exit();
        return readAllFilter;
    }

    public void Update(Customer item)
    {
        LogManager.Enter();
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"update customer from the system id:{item.CustomerId}");
        bool exist = false;
        foreach (Customer customer in DataSource.customer)
        {
            if (customer.CustomerId == item.CustomerId)
            {
                Delete(customer.CustomerId);
                DataSource.customer.Add(item);
                exist = true;
                break;
            }
        }
        if (!exist)
        {
            LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "update not sucessful the customer not exists");
            LogManager.Exit();
            throw new Exception("update not sucessful the customer not exists");
        }
        LogManager.Exit();
    }
}
