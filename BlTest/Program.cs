using BL.BlApi;
using BL.BO;
using System;

namespace BlTest
{
    class Program
    {
        static readonly IBl s_bl = BL.BlApi.Factory.Get();

        public static void Start()
        {
            Order order = new Order();

            Console.WriteLine("הכנס תעודת זהות של הלקוח:");
            int clientId = int.Parse(Console.ReadLine());
            


            bool addMore = true;
            while (addMore)
            {
                

                try
                {
                    //if (clientId != 0)
                    //{
                    //    s_bl.Order.SearchSaleForProduct(productId, order.IsPreferredCustomer);
                    //}
                    Console.WriteLine("הכנס מזהה מוצר:");
                    int productId = int.Parse(Console.ReadLine());

                    Console.WriteLine("הכנס כמות להזמנה:");
                    int amount = int.Parse(Console.ReadLine());
                    s_bl.Order.AddProductToOrder(order, productId, amount);
                    s_bl.Order.CalcTotalPrice(order);
                    Console.WriteLine($"מחיר ההזמנה כעת: {order.TotalPrice} ");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"שגיאה: {ex.Message}");
                }

                Console.WriteLine("להוסיף מוצר נוסף? (כן/לא)");
                string response = Console.ReadLine().Trim().ToLower();
                addMore = response == "כן" || response == "yes";
            }

            if (order.Products.Count > 0)
            {
                bool add = true;
                s_bl.Order.DoOrder(order);
                Console.WriteLine($"ההזמנה הסתיימה. סכום סופי לתשלום: {order.TotalPrice}");
                Console.WriteLine("האם אתה רוצה לבצע קנייה נוספת? (כן/לא)");
                string res = Console.ReadLine().Trim().ToLower();
                add = res == "כן" || res == "yes";
                if (add)
                {
                    Start();
                }
                else
                {
                    Console.WriteLine("יום טוב!");
                }

            }
            else
            {
                Console.WriteLine("לא נוספו מוצרים להזמנה. ביטול.");
            }
        }

        static void Main(string[] args)
        {
            DalTest.Initialization.Initialize();
            Start();
        }
    }
}
