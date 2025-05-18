using BL.BO;
using DalApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.BlImplementation
{
    internal class OrderImplementation : BlApi.IOrder
    {
        private DalApi.IDal? _dal = DalApi.Factory.Get;

        /// <param name="order"></param>
        public List<SaleInProduct> AddProductToOrder(Order order, string name, int amount)
        {
            // Validate product existence
            var productEntity = _dal.Product.Read(p => p.ProductName.Equals(name));
            if (productEntity == null)
                throw new Exception("המוצר לא קיים במערכת");
            if (amount <= 0)
                throw new Exception("הכמות לא טובה");

            // Convert product to BO
            BO.Product product = BO.Tools.ConvertProductToBO(productEntity);

            // Find product in order
            var productInOrder = order.Products.FirstOrDefault(p => p.ProductId == product.Id);

            if (productInOrder != null)
            {
                // Update quantity if sufficient stock exists
                if (product.QuantityInStock >= (productInOrder.QuantityInOrder + amount))
                {
                    productInOrder.QuantityInOrder += amount;
                }
                else
                {
                    throw new Exception("אין מספיק מלאי עבור הכמות המבוקשת.");
                }
            }
            else
            {
                // Add new product to order if sufficient stock exists
                if (product.QuantityInStock >= amount)
                {
                    productInOrder = new BO.ProductInOrder(
                        product.Id,
                        product.ProductName,
                        product.Price,
                        amount,
                        new List<SaleInProduct>(),
                        0
                    );
                    order.Products.Add(productInOrder);
                }
                else
                {
                    throw new Exception("אין מספיק מלאי עבור הכמות המבוקשת.");
                }
            }

            // Process order and calculate prices
            DoOrder(order);
            SearchSaleForProduct(productInOrder, order.IsPreferredCustomer);
            CalcTotalPriceForProduct(productInOrder);
            CalcTotalPrice(order);

            return productInOrder.Sales;
        }


        /// <summary>
        /// פונקציה המחשבת את המחיר הסופי של ההזמנה
        /// </summary>
        /// <param name="order"></param>
        public void CalcTotalPrice(Order order)
        {
            order.TotalPrice = order.Products.Sum(p => p.FinalPrice);
        }


        /// <summary>
        /// פונקציה המחשבת את המחיר הסופי של המוצר ושומרת את כל מה שעודכן ברשימה חדשה
        /// </summary>
        /// <param name="product"></param>
        public void CalcTotalPriceForProduct(BO.ProductInOrder product)
        {
            try
            {
                double sum = 0;
                int count = product.QuantityInOrder;
                if (product.Sales.Count == 0)
                {
                    product.FinalPrice = product.BasePrice * count;
                    return;
                }

                List<BO.SaleInProduct> usedSales = new List<BO.SaleInProduct>();
                foreach (var sale in product.Sales)
                {
                    if (count < sale.QuantityForSale)
                        continue;
                    int applicableCount = count / sale.QuantityForSale;
                    sum += applicableCount * sale.SalePrice;
                    count %= sale.QuantityForSale;
                    usedSales.Add(sale);

                    if (count == 0)
                        break;
                }
                if (count > 0)
                {
                    sum += product.BasePrice * count;
                }
                product.FinalPrice = sum;
                product.Sales = usedSales;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }


        /// הפונקציה מעדכנת את המבצעים המתאימים למוצר
        /// </summary>
        /// <param name="order"></param>
        public void DoOrder(Order order)
        {
            try
            {
                foreach (BO.ProductInOrder p in order.Products)
                {
                    DO.Product p1 = _dal.Product.Read(p.ProductId);
                    BO.Product p2 = BO.Tools.ConvertProductToBO(p1);

                    if (p2 == null)
                    {
                        throw new NullReferenceException("The product object (p2) is null.");
                    }

                    p2.QuantityInStock -= p.QuantityInOrder;
                    DO.Product p1Updated = BO.Tools.ConvertProductToDO(p2); // השתמש במשתנה חדש
                    _dal.Product.Update(p1Updated); // עדכן באמצעות האובייקט המעודכן

                    Console.WriteLine($"Product {p.ProductId} updated. New QuantityInStock: {p2.QuantityInStock}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error processing product: {ex.Message}");
                throw;
            }
        }
    
        


        /// <summary>
        /// הפונקציה מדפיסה ומעדכנת את כל המבצעים המתאימים למוצר בהזמנה
        /// </summary>
        /// <param name="order"></param>
        /// <param name="IsNew"></param>
        public void SearchSaleForProduct(ProductInOrder order, bool IsNew)
        {
            try
            {
                order.Sales = BO.Tools.ConvertDOSalesToBOSaleInProducts(
                    _dal.Sale.ReadAll(s =>
                        s.ProductId == order.ProductId &&
                        s.BeginSale <= DateTime.Now &&
                        s.EndSale > DateTime.Now &&
                        s.MinQuantity <= order.QuantityInOrder &&
                        !IsNew &&
                        !s.InClab
                    )
                );

                foreach (var sale in order.Sales)
                {
                    Console.WriteLine(sale);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error fetching sales: {ex.Message}");
            }
        }

    }
}
