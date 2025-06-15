
using DAL;
using DalApi;
using DO;
using System.Reflection;
using Tools;
namespace DallTest;

internal class Program
{
    public static IDal s_dal = DalApi.Factory.Get;

    static ICustomer customer = new CustomerImplementation();
    static IProduct product = new ProductImplementation();
    static ISale sale = new SaleImplementation();

    public delegate void CreateUpDateDel();
    public static Product AskProduct()
    {
        Console.WriteLine("enter name category of product" +
            "\n MainCourse press 0" +
            " \n Salads press 1" +
            "\nExtras press 2 " +
            "\n Desserts press 3" +
            "\nDriks press 4");
        Category categoryName = (Category)int.Parse(Console.ReadLine());
        Console.WriteLine("enter name of Product");
        string prudactName = Console.ReadLine();
        Console.WriteLine("enter amount in stock");
        int amountInStock = int.Parse(Console.ReadLine());
        Console.WriteLine("enter Price");
        double price = double.Parse(Console.ReadLine());
        Product p = new Product(0, prudactName, categoryName, price, amountInStock);
        return p;
    }
    public static Customer AskCustomer()
    {
        Console.WriteLine("enter your id:");
        int customerIdd = int.Parse(Console.ReadLine());
        Console.WriteLine("enter your name");
        string customerName = Console.ReadLine();
        Console.WriteLine("enter your adress");
        string adress = Console.ReadLine();
        Console.WriteLine("enter your phone");
        int customerPhone = int.Parse(Console.ReadLine());
        Customer c = new Customer(customerIdd, customerName, adress, customerPhone);
        return c;
    }
    public static Sale AskSale()
    {
        Console.WriteLine("enter product id:");
        int productId = int.Parse(Console.ReadLine());
        Console.WriteLine("enter count for sale :");
        int countForSale = int.Parse(Console.ReadLine());
        Console.WriteLine("entere final price");
        double finalPrice = double.Parse(Console.ReadLine());
        Console.WriteLine("the sale is for all customer? enter true/false");
        bool IsForAll = bool.Parse(Console.ReadLine());
        Console.WriteLine("when the sale start enter count days");
        int countDay = int.Parse(Console.ReadLine());
        Console.WriteLine("how many days sale go to be");
        int countSale = int.Parse(Console.ReadLine());
        Sale s = new Sale(0, productId, countForSale, finalPrice, IsForAll, DateTime.Now.AddDays(countDay), DateTime.Now.AddDays(countDay + countSale));
        return s;
    }
    public static void Read<T>(ICrud<T> icrud)
    {
        try
        {
            Console.WriteLine("enter id");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine(icrud.Read(id).ToString());
        }
        catch (Exception ex)
        {
            LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, ex.ToString());
            Console.WriteLine(ex.ToString());
        }

    }
    public static void ReadAll<T>(ICrud<T> type)
    {
        List<T> list = type.ReadAll();
        foreach (T t in list)
            Console.WriteLine(t.ToString());
    }
    public static void Delete<T>(ICrud<T> icrud)
    {
        try
        {
            Console.WriteLine("enter id for delete");
            int id = int.Parse(Console.ReadLine());
            icrud.Delete(id);
        }
        catch (Exception ex)
        {
            LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, ex.ToString());
            Console.WriteLine(ex.ToString());
        }
    }
    public static void PrintMenue()
    {
        int select = 1;
        while (select > 0)
        {
            try
            {
                Console.WriteLine("FOR PRODUCT PRESS 1");
                Console.WriteLine("FOR CUSTOMER PRESS 2");
                Console.WriteLine("FOR SALE PRESS 3");
                Console.WriteLine("FOR DELETE  LOG DIRECTORY PRESS 4");
                Console.WriteLine("TO EXIT PRESS 0");
                if (!int.TryParse(Console.ReadLine(), out select))
                    select = -1;
                switch (select)
                {
                    case 1:
                        PrintSubMenue("product", s_dal.Product, CreatProduct, UpdateProduct);

                        break;
                    case 2:
                        PrintSubMenue("customer", s_dal.Customer, CreatCustomer, UpdatCustomer);
                        break;
                    case 3:
                        PrintSubMenue("sale", s_dal.Sale, CreatSale, UpdateSale);
                        break;
                    case 4:
                        LogManager.deleteOldFolder();
                        break;
                    default:
                        Console.WriteLine("please choose again number");
                        break;

                }
            }
            catch (Exception ex)
            {
                LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, ex.ToString());
                Console.WriteLine(ex.ToString());
            }
        }
    }
    public static void PrintSubMenue<T>(string select, ICrud<T> icrud, CreateUpDateDel createDel, CreateUpDateDel updateDel)
    {
        Console.WriteLine($"TO ADD {select} PRESS 1");
        Console.WriteLine($"TO READ ONE {select} PRESS 2");
        Console.WriteLine($"TO READ ALL {select} PRESS 3");
        Console.WriteLine($"TO UPDATE {select} PRESS 4");
        Console.WriteLine($"TO DELETE {select} PRESS 5");
        Console.WriteLine($"TO GO BACK {select} PRESS 0");
        int number = 1;
        while (number > 0)
        {
            try
            {
                if (!int.TryParse(Console.ReadLine(), out number))
                    number = -1;
                switch (number)
                {
                    case 0: PrintMenue(); break;
                    case 1: createDel(); break;
                    case 2: Read(icrud); break;
                    case 3: ReadAll(icrud); break;
                    case 4: updateDel(); break;
                    case 5: Delete(icrud); break;
                    default: Console.WriteLine("error!! not faund"); break;
                }
            }
            catch (Exception ex)
            {
                LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, ex.ToString());
                Console.WriteLine(ex.ToString());
            }
        }
    }
    public static void CreatProduct()
    {
        try
        {
            Product product = AskProduct();
            int productId = s_dal.Product.Create(product);
            Console.WriteLine("registration was successful the id of product: " + productId);
        }
        catch (Exception ex)
        {
            LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, ex.ToString());
            Console.WriteLine(ex.ToString());
        }
    }
    public static void CreatCustomer()
    {
        try
        {
            Customer customer = AskCustomer();
            int id = s_dal.Customer.Create(customer);
            Console.WriteLine("registration was successful your id is: " + id);

        }
        catch (Exception ex)
        {
            LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, ex.ToString());
            Console.WriteLine(ex.ToString());
        }
    }
    public static void CreatSale()
    {
        try
        {
            Sale sale = AskSale();
            int id = s_dal.Sale.Create(sale);
            Console.WriteLine("registration was successful the id of sale: " + id);
        }
        catch (Exception ex)
        {
            LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, ex.ToString());
            Console.WriteLine(ex.ToString());
        }
    }
    public static void UpdateProduct()
    {
        try
        {
            Console.WriteLine("enter id of product");
            int id = int.Parse(Console.ReadLine());
            Product product = s_dal.Product.Read(id);
            Product newProduct = AskProduct();
            Console.WriteLine($"productId: {newProduct.ProductId} productName={newProduct.ProductName} custegoryName={newProduct.CategoryName} price={newProduct.Price}0");
            s_dal.Product.Update(product);
        }
        catch (Exception ex)
        {
            LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, ex.ToString());
            Console.WriteLine(ex.ToString());
        }
    }
    public static void UpdatCustomer()
    {
        try
        {
            Console.WriteLine("enter id of customer");
            int id = int.Parse(Console.ReadLine());
            Customer customer = s_dal.Customer.Read(id);
            Customer newCustomer = AskCustomer();
            Console.WriteLine($"id={newCustomer.CustomerId} name={newCustomer.CustomerName} address={newCustomer.Adress} phone={newCustomer.CustomerPhone}");
            s_dal.Customer.Update(newCustomer);
        }

        catch (Exception ex)
        {
            LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, ex.ToString());
            Console.WriteLine(ex.ToString());
        }
    }
    public static void UpdateSale()
    {
        try
        {
            Console.WriteLine("enter id of Sale");
            int id = int.Parse(Console.ReadLine());
            Sale sale = s_dal.Sale.Read(id);
            Sale newSale = AskSale();
            Console.WriteLine($"saleId={newSale.ProductId} DateStartSale={newSale.DateStartSale} countforSale={newSale.CountForSale} finalPrice={newSale.FinalPrice}");
            s_dal.Sale.Update(newSale);
        }
        catch (Exception ex)
        {
            LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, ex.ToString());
            Console.WriteLine(ex.ToString());
        }
    }
    public static void Main(string[] args)
    {
        Initialization.Initialize();
        PrintMenue();

        Console.WriteLine("Hello, World!");

    }
}
