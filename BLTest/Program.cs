using BLApi;
using BO;
using DallTest;



class Program
{
    static readonly BLApi.IBI s_bl = BLApi.Factory.Get();

    static void StartNewOrder()
    {
        Console.WriteLine("enter user id or 0 for unregistered:");
        int userId;
        int.TryParse(Console.ReadLine(), out userId);

        Order order = new Order { ProductList = new List<ProductInOrder>() };

        bool continueAdding = true;

        while (continueAdding)
        {
            Console.WriteLine("enter Product ID:");
            int productId;
            int.TryParse(Console.ReadLine(), out productId);

            Console.WriteLine("enter Quantity:");
            int quantity;
            int.TryParse(Console.ReadLine(), out quantity);

            try
            {
                var sales = s_bl.order.AddProductToOrder(order, productId, quantity);
                Console.WriteLine($"product added: {string.Join(", ", sales.Select(s => s.ProductId))}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            s_bl.order.CalcTotalPrice(order);
             Console.WriteLine("add another product? (y/n)");
            continueAdding = Console.ReadLine().ToLower() == "y";
        }

        Console.WriteLine("order completed. Start a new order? (y/n)");
        if (Console.ReadLine().ToLower() == "y")
        {
            StartNewOrder();
        }
    }
    static void Main(string[] args)
    {
        Console.WriteLine("you wont to initilization? y/n");
        string answer = Console.ReadLine();
        if (answer == "y")
            Initialization.Initialize();

        bool exit = false;
        while (!exit)
        {
            Console.WriteLine("select an option:");
            Console.WriteLine("1. start New Order");
            Console.WriteLine("2. exit");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                StartNewOrder();
            }
            else if (choice == "2")
            {
                exit = true;
            }
        }
    }


}

