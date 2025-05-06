using DalApi;
using DalTest;
using DO;
using Tools;
using System.Reflection;

internal class Program
{
    //private static readonly IDal _dal = DalApi.Factory.Get;
    private static readonly IDal _dal = DalApi.Factory.Get;



    /// <summary>
    /// הפונקציה הראשית של התוכנית שמאתחלת את הממשקים ומציגה את התפריט הראשי.
    /// </summary>
    private static void Main(string[] args)
    {
      Initialization.Initialize();
        try
        {
            int select1;
            select1 = PrintMenu();
            //int select2;
            while (select1 != 0)
            {
                switch (select1)
                {
                    case 1:
                        ProductMenu();
                        break;
                    case 2:
                        CustomerMenu();
                        break;
                    case 3:
                        SaleMenu();
                        break;
                    case 4:
                        LogManager.CleanLog();
                        break;
                    default:
                        Console.WriteLine(" בחירה שגויה אנא הקש שוב");
                        break;

                }
                select1 = PrintMenu();
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }

    }



    /// <summary>
    /// מציגה את תפריט המשנה לפעולות שניתן לבצע על פריט (מוצר, לקוח, או מבצע).
    /// </summary>
    private static int PrintSubMenu(string item)
    {
        int select;
        Console.WriteLine($"To add {item}, press 1");
        Console.WriteLine($"To receive one {item}, press 2");
        Console.WriteLine($"To receive all {item} products, press 3");
        Console.WriteLine($"To update {item}, press 4");
        Console.WriteLine($"To delete {item}, press 5");



        if (!int.TryParse(Console.ReadLine(), out select))
            select = -1;
        return select;

    }




    /// <summary>
    /// מציגה את תפריט הבחירות הראשי ומחזירה את הבחירה של המשתמש
    /// </summary>
    public static int PrintMenu()
    {
        Console.WriteLine("For products, press 1.");
        Console.WriteLine("For customers, press 2.");
        Console.WriteLine("For sales, press 3");
        Console.WriteLine("To delete the logs folder, press 4.");
        Console.WriteLine("For exit, press 0.");

        int select;
        if (!int.TryParse(Console.ReadLine(), out select))

            select = -1;
        return select;


    }




    /// <summary>
    /// מציג את תפריט המוצרים ומאפשר למשתמש לבצע פעולות שונות על המוצרים.
    /// </summary>
    private static void ProductMenu()
    {
        int select;
        select = PrintSubMenu("product");
        while (select != 0)
        {
            switch (select)
            {
                case 1:
                    AddProduct();
                    break;
                case 2:
                    Read(_dal.Product);
                    break;
                case 3:
                    ReadAll(_dal.Product.ReadAll());
                    break;
                case 4:
                    UpdateProduct();
                    break;
                case 5:
                    DeleteProduct();
                    break;
                default:
                    Console.WriteLine("worng choice");
                    break;
            }
            select = PrintSubMenu("product"); // Re-prompt for new selection
        }
    }




    /// <summary>
    /// הוספת מוצר
    /// </summary>

    private static void AddProduct()
    {
        Random random = new Random();

        Console.WriteLine("Enter product name:");
        string? productName = Console.ReadLine();

        Console.WriteLine("Select a category between 0-5:");
        if (!int.TryParse(Console.ReadLine(), out int catInput) || catInput < 0 || catInput > 5)
        {
            Console.WriteLine("Invalid category. Defaulting to 0.");
            catInput = 0;
        }
        Category category = (Category)catInput;

        Console.WriteLine("Enter price:");
        if (!double.TryParse(Console.ReadLine(), out double price))
        {
            Console.WriteLine("Invalid price. Defaulting to 10.");
            price = 10;
        }

        Console.WriteLine("Enter quantity:");
        if (!int.TryParse(Console.ReadLine(), out int quantityInStock))
        {
            Console.WriteLine("Invalid quantity. Defaulting to 0.");
            quantityInStock = 0;
        }

        Product p = new Product
        (

            Id: random.Next(1000,10000),
            ProductName: productName!,
            Category: category,
            Price: price,
            QuantityInStock: quantityInStock
        );

        _dal.Product.Create(p);

        

        Console.WriteLine("The product was created successfully!");
        Console.WriteLine(p);
    }





    /// <summary>
    /// המרת מספר הקטגוריה לאובייקט מסוג Category.
    /// </summary>
    private static Category Category(int cat)
    {
        LogManager.WriteToLog($"Attempted to convert category number", " {cat} to Category enum.");
        throw new NotImplementedException();

    }




    /// <summary>
    /// קורא ומציג פריט לפי קוד.
    /// </summary>
    private static void Read<T>(ICrud<T> ICrud)
    {
        try
        {
            Console.WriteLine("enter code");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine(ICrud.Read(id));
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }

    }




    /// <summary>
    /// מחיקת מוצר
    /// </summary>
    private static void DeleteProduct()
    {
        int id;
        Console.WriteLine("To delete the product enter the code");
        if (!int.TryParse(Console.ReadLine(), out id)) id = 0;
        _dal.Product.Delete(id);
        Console.WriteLine("the product deleted!");
    }




    /// <summary>
    /// מציגה את המוצרים
    /// </summary>
    private static void ReadAll<T>(List<T> list)
    {
        foreach (var item in list)
        {
            Console.WriteLine(item);
        }
    }




    /// <summary>
    /// מעדכנת מוצר
    /// </summary>
    private static void UpdateProduct()
    {
        string productName;
        Category category;
        double price;
        int quantityInStock;

        Console.WriteLine("enter product name");
        productName = Console.ReadLine();

        Product productToUpdate = _dal.Product.ReadAll().FirstOrDefault(p => p.ProductName.Equals(productName, StringComparison.OrdinalIgnoreCase));

        if (productToUpdate == null)
        {
            Console.WriteLine("not fount product with a fit name");
            return;
        }

        Console.WriteLine($"The product found: {productToUpdate}");
        Console.WriteLine("What do you want to change?");
        Console.WriteLine("1 - price");
        Console.WriteLine("2 - amount");
        Console.WriteLine("3 - category");
        Console.WriteLine("0 - exsit");

        int choice = int.TryParse(Console.ReadLine(), out choice) ? choice : -1;

        Product updatedProduct = productToUpdate; 

        switch (choice)
        {
            case 1:  // שינוי מחיר
                Console.WriteLine("enter new price");
                if (!double.TryParse(Console.ReadLine(), out price)) price = productToUpdate.Price; 
                updatedProduct = updatedProduct with { Price = price };
                break;

            case 2:  // שינוי כמות
                Console.WriteLine("enter new quantity");
                if (!int.TryParse(Console.ReadLine(), out quantityInStock)) quantityInStock = productToUpdate.QuantityInStock; // אם לא הכנס כמות תקנית, שמור את הכמות הנוכחית
                updatedProduct = updatedProduct with { QuantityInStock = quantityInStock }; 
                break;

            case 3:  // שינוי קטגוריה
                Console.WriteLine("enter new category");
                if (int.TryParse(Console.ReadLine(), out int cat))
                    category = (Category)cat;  
                else
                    category = productToUpdate.Category; 
                updatedProduct = updatedProduct with { Category = category };
                break;
            case 0:
                return;

            default:
                Console.WriteLine("worng choice");
                break;
        }

        _dal.Product.Update(updatedProduct);

        Console.WriteLine($"the product updeted {updatedProduct}");

        ProductMenu();  
    }





    /// <summary>
    /// מציגה את תפריט המבצעים
    /// </summary>
    private static void SaleMenu()
    {
        int select;
        select = PrintSubMenu("Sale");
        while (select != 0)
        {
            switch (select)
            {
                case 1:
                    AddSale();
                    break;
                case 2:
                    Read(_dal.Sale);
                    break;
                case 3:
                    ReadAll(_dal.Sale.ReadAll());
                    break;
                case 4:
                    UpdateSale();
                    break;
                case 5:
                    DeleteSale();
                    break;
                default:
                    break;
            }
            select = PrintSubMenu("Sale");
        }
    }




    /// <summary>
    /// הוספת מבצע
    /// </summary>
    private static void AddSale()
    {
        Console.WriteLine("Enter the product ID:");
        if (!int.TryParse(Console.ReadLine(), out int productId))
        {
            Console.WriteLine("Invalid product ID. Operation canceled.");
            return;
        }
        var product = _dal.Product.Read(productId); 
        if (product == null)
        {
            Console.WriteLine($"No product found with ID {productId}. Operation canceled.");
            return;
        }
        Console.WriteLine("Enter the sale price:");
        if (!double.TryParse(Console.ReadLine(), out double price))
            price = 10;

        Console.WriteLine("Enter the minimal quantity for sale:");
        if (!int.TryParse(Console.ReadLine(), out int minQuantity))
            minQuantity = 1;

        Console.WriteLine("Is this sale for club members only? (true/false)");
        if (!bool.TryParse(Console.ReadLine(), out bool inClub))
            inClub = false;

        Console.WriteLine("Enter the sale start date (yyyy-MM-dd):");
        if (!DateTime.TryParse(Console.ReadLine(), out DateTime beginSale))
            beginSale = DateTime.Now;

        Console.WriteLine("Enter the sale end date (yyyy-MM-dd):");
        if (!DateTime.TryParse(Console.ReadLine(), out DateTime endSale))
            endSale = beginSale.AddDays(1); 

        if (endSale <= beginSale)
        {
            Console.WriteLine("End date must be after start date. Operation canceled.");
            return;
        }
        Random random = new Random();
        Sale sale = new Sale(random.Next(1000,10000), productId, minQuantity, price, inClub, beginSale, endSale);
        _dal.Sale.Create(sale);


        Console.WriteLine("The sale was added successfully!");
        Console.WriteLine(sale);
    }





    /// <summary>
    /// מחיקת מבצע
    /// </summary>
    private static void DeleteSale()
    {
        int id;
        Console.WriteLine("To delete sale, enter ID:");

        if (!int.TryParse(Console.ReadLine(), out id))
        {
            Console.WriteLine("Invalid ID. Operation canceled.");
            return;
        }

        _dal.Sale.Delete(id);
        Console.WriteLine($"Sale with ID {id} has been successfully deleted.");
    }






    /// <summary>
    /// עדכון מבצע קיים
    /// </summary>
    private static void UpdateSale()
    {
        int ProductId;
        int MinQuantity;
        double price;
        bool inClob;
        DateTime beginSale;
        DateTime endSale;

        Console.WriteLine("Enter sale ID to update:");
        int saleId;
        if (!int.TryParse(Console.ReadLine(), out saleId))
        {
            Console.WriteLine("Invalid sale ID. Operation canceled.");
            return;
        }

        Console.WriteLine("Enter new product code:");
        if (!int.TryParse(Console.ReadLine(), out ProductId))
        {
            Console.WriteLine("Invalid product code. Operation canceled.");
            return;
        }

        Console.WriteLine("Enter new price:");
        if (!double.TryParse(Console.ReadLine(), out price))
        {
            Console.WriteLine("Invalid price. Operation canceled.");
            return;
        }

        Console.WriteLine("Enter new minimum quantity for sale:");
        if (!int.TryParse(Console.ReadLine(), out MinQuantity))
        {
            Console.WriteLine("Invalid quantity. Operation canceled.");
            return;
        }

        Console.WriteLine("Is this a club sale (true/false)?");
        if (!bool.TryParse(Console.ReadLine(), out inClob))
        {
            Console.WriteLine("Invalid input for club status. Operation canceled.");
            return;
        }

        Console.WriteLine("Enter new start date:");
        if (!DateTime.TryParse(Console.ReadLine(), out beginSale))
        {
            Console.WriteLine("Invalid start date. Operation canceled.");
            return;
        }

        Console.WriteLine("Enter new end date:");
        if (!DateTime.TryParse(Console.ReadLine(), out endSale))
        {
            Console.WriteLine("Invalid end date. Operation canceled.");
            return;
        }

        Sale updatedSale = new Sale(saleId, ProductId, MinQuantity, price, inClob, beginSale, endSale);
        _dal.Sale.Update(updatedSale);
        Console.WriteLine("the sale updeted!");

    }





    /// <summary>
    /// מציגה את תפריט הלקוחות
    /// </summary>
    private static void CustomerMenu()
    {
        int select;
        select = PrintSubMenu("Customer");
        while (select != 0)
        {
            switch (select)
            {
                case 1:
                    AddCustomer();
                    break;
                case 2:
                    Read(_dal.Customer);
                    break;
                case 3:
                    ReadAll(_dal.Customer.ReadAll());
                    break;
                case 4:
                    UpdateCustomer();
                    break;
                case 5:
                    DeleteCustomer();
                    break;
                default:
                    break;
            }
            select = PrintSubMenu("Customer");

        }
    }




    /// <summary>
    /// הוספת לקוח
    /// </summary>
    private static void AddCustomer()
    {
        int id;
        string name;
        string address;
        int phone;
        bool inClub = true;

        Console.WriteLine("enter customer id");
        if (!int.TryParse(Console.ReadLine(), out id)) id = 0;

        Console.WriteLine("enter name");
        name = Console.ReadLine();

        Console.WriteLine("enter address");
        address = Console.ReadLine();

        Console.WriteLine("enter phone number");
        if (!int.TryParse(Console.ReadLine(), out phone)) phone = 0;

        Customer c = new Customer(id, name, address, phone,inClub);
         _dal.Customer.Create(c);
        

        Console.WriteLine("the customer added");
        Console.WriteLine(c);
    }




    /// <summary>
    /// מחיקת לקוח
    /// </summary>
    private static void DeleteCustomer()
    {
        Console.WriteLine("To delete a customer, enter the ID:");
        if (!int.TryParse(Console.ReadLine(), out int id))
        {
            Console.WriteLine("Invalid ID. Deletion canceled.");
            return;
        }

        try
        {
            _dal.Customer.Delete(id);
            Console.WriteLine("Customer deleted successfully.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error deleting customer: {ex.Message}");
        }
    }





    /// <summary>
    /// עדכון לקוח קיים
    /// </summary>
    private static void UpdateCustomer()
    {
        Console.WriteLine("Enter customer ID:");
        if (!int.TryParse(Console.ReadLine(), out int id))
        {
            Console.WriteLine("Invalid ID. Update canceled.");
            return;
        }

        Console.WriteLine("Enter new customer name:");
        string? name = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(name))
        {
            Console.WriteLine("Invalid name. Update canceled.");
            return;
        }

        Console.WriteLine("Enter new customer address:");
        string? address = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(address))
        {
            Console.WriteLine("Invalid address. Update canceled.");
            return;
        }

        Console.WriteLine("Enter new phone number:");
        if (!int.TryParse(Console.ReadLine(), out int phone))
        {
            Console.WriteLine("Invalid phone number. Update canceled.");
            return;
        }
        bool inClub = true; // Assuming inClub is always true for the updated customer

        Customer updatedCustomer = new Customer(id, name, address, phone , inClub);

        try
        {
            _dal.Customer.Update(updatedCustomer); // לא Create אלא Update
            Console.WriteLine("The customer was updated successfully:");
            Console.WriteLine(updatedCustomer);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error updating customer: {ex.Message}");
        }
    }

}