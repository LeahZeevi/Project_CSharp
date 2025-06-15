using DO;
using DalApi;

namespace DallTest;


public static class Initialization
{
    static IDal? s_dal;

    private static void CreateCustomer()
    {
        s_dal.Customer.Create(new Customer(214943045, "מיכל אפשטיין", "פוניבז 8", 0548599390));
        s_dal.Customer.Create(new Customer(214981144, "לאה זאבי", "אבני נזר 2", 0534161821));
        s_dal.Customer.Create(new Customer(215698741, "שירה כהן", "רימונים 20", 0527165072));
        s_dal.Customer.Create(new Customer(312546978, "מירב לב", "ילדי אוסלו 9", 0504142002));
        s_dal.Customer.Create(new Customer(024956879, "אפרת מכאלוב", "התקומה 88", 0548495622));
        s_dal.Customer.Create(new Customer(024985652, "דוד אלבז", "חפץ חיים 16", 0548495632));
        s_dal.Customer.Create(new Customer(214658978, "יעל שחר", "הזית 101 ", 0566060563));
        s_dal.Customer.Create(new Customer(315313152, "יעקוב ורדי", "העצמאות 67", 0527165072));
        s_dal.Customer.Create(new Customer(315698545, "יאיר בן-הרוש", "השלום 5", 0556798564));
        s_dal.Customer.Create(new Customer(215698574, "יוסף שי", "רשי 9", 0524569825));
    }
    private static void CreateProduct()
    {
        s_dal.Product.Create(new Product(1,"לאפה שאורמה", Category.MainCourse, 48,50));
        s_dal.Product.Create(new Product(2, "פטריה במילוי אסדו",Category.MainCourse,70,20));
        s_dal.Product.Create(new Product(3, "צ'יפס",Category.Extras,22,10));
        s_dal.Product.Create(new Product(4, "מוקפצים",Category.Extras,35,30));
        s_dal.Product.Create(new Product(5, "כדורי פירה",Category.Extras,25,33));
        s_dal.Product.Create(new Product(6, "טבעות בצל", Category.Extras, 30, 40));
        s_dal.Product.Create(new Product(7, "קישואים מאודים", Category.Extras, 18, 28));
        s_dal.Product.Create(new Product(8, "גלידת קרמל", Category.Desserts, 25, 30));
        s_dal.Product.Create(new Product(9, "גלידת הבית", Category.Desserts, 25, 18));
        s_dal.Product.Create(new Product(10, "חצילים", Category.Salads, 15, 30));
        s_dal.Product.Create(new Product(11, "סלט איטלקי", Category.Salads, 15, 30));
        s_dal.Product.Create(new Product(12, "סלט ישראלי", Category.Salads, 15, 30));
        s_dal.Product.Create(new Product(13, "חמוצים", Category.Salads, 15, 30));
        s_dal.Product.Create(new Product(14, "קולה זירו", Category.Driks, 12, 45));
        s_dal.Product.Create(new Product(15, "קולה רגיל", Category.Driks, 12, 45));
        s_dal.Product.Create(new Product(16, "ספרייט דיאט", Category.Driks, 12, 45));
        s_dal.Product.Create(new Product(17, "ספרייט רגיל", Category.Driks, 12, 45));
        s_dal.Product.Create(new Product(18, "מים בטעמים", Category.Driks, 12, 45));
    }
    private static void CreateSale()
    {
        s_dal.Sale.Create(new Sale(11, 1, 2, 35, true, DateTime.Now, DateTime.Now.AddDays(7)));
        s_dal.Sale.Create(new Sale(22,2, 2,55,true,DateTime.Now,DateTime.Now.AddDays(30)));
        s_dal.Sale.Create(new Sale(33,3,1, 17.5,true,DateTime.Now,DateTime.Now.AddDays(20)));
        s_dal.Sale.Create(new Sale(44,4,3, 15.5,true,DateTime.Now, DateTime.Now.AddDays(40)));
    }
    public static void Initialize()
    {
        s_dal = DalApi.Factory.Get;
        //CreateSale();
        CreateCustomer();
        //CreateProduct();

    }
}
