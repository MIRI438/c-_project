namespace DalTest;
using DO;
using DalApi;
using Tools;
using System.Reflection;


public static class Initialization
{

    private static IDal? _dal;

    static string projectName = MethodBase.GetCurrentMethod().DeclaringType.FullName!;

    private static void createProduct()
    {
        string functionName = MethodBase.GetCurrentMethod().Name!;

        if (_dal.Product != null)
        {
            LogManager.WriteToLog(projectName, $"Starting {functionName}");
            _dal.Product.Create(new Product(123, "קרם לחות", Category.טיפוח_אישי, 50.00, 100));
            _dal.Product.Create(new Product(244, "קרם הגנה", Category.טיפוח_אישי, 70.00, 200));
            _dal.Product.Create(new Product(032, "אלוורה", Category.משקאות, 130.00, 20));
            _dal.Product.Create(new Product(447, "דבש", Category.מוצרי_כוורת, 20.00, 300));
            _dal.Product.Create(new Product(245, "פילינג", Category.טיפוח_העור, 80.00, 70));
            LogManager.WriteToLog(projectName, $"{functionName} completed successfully.");
        }
    }

    private static void createCustomer()
    {
        string functionName = MethodBase.GetCurrentMethod().Name!;

        if (_dal.Customer != null)
        {
            LogManager.WriteToLog(projectName, $"Starting {functionName}");
            _dal.Customer.Create(new Customer(327824371, "מירי", "מתתיהו", 0534198438));
            _dal.Customer.Create(new Customer(214915266, "חיה", "ברכפלד", 0534192458));
            _dal.Customer.Create(new Customer(025547241, "שושי", "ברכפלד", 0502446876));
            _dal.Customer.Create(new Customer(354788898, "שרה", "קרית ספר", 089741004));
            LogManager.WriteToLog(projectName, $"{functionName} completed successfully.");
        }
    }

    private static void createSale()
    {
        string functionName = MethodBase.GetCurrentMethod().Name!;

        if (_dal.Sale != null)
        {
            LogManager.WriteToLog(projectName, $"Starting {functionName}");
            _dal.Sale.Create(new Sale(3552, 032, 3, 300, true, DateTime.Now, DateTime.Now.AddDays(8)));
            _dal.Sale.Create(new Sale(3699, 245, 2, 140, false, DateTime.Now, DateTime.Now.AddDays(6)));
            LogManager.WriteToLog(projectName, $"{functionName} completed successfully.");
        }
    }

    public static void Initialize()
    {
        _dal = Factory.Get;

        string functionName = MethodBase.GetCurrentMethod().Name!;

        LogManager.WriteToLog(projectName, $"Starting {functionName}");

        createProduct();
        createCustomer();
        createSale();

        LogManager.WriteToLog(projectName, $"{functionName} completed successfully.");
    }
}
