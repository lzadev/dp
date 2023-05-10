using DP.Shared.Models;
using DP.Shared.Strategy;

namespace DP.ConsoleApplication.Examples
{
    public static class StrategyExample
    {
        public static void DoWork()
        {
            Console.WriteLine("Proccessing");

            IDiscountStrategy discountStrategy;
            foreach (var item in GetOrders())
            {
                discountStrategy = DiscountStrategyContext.GetStrategy(item.Customer.CustomerType);
                item.Discount = discountStrategy.Calculate(item.Products);
                item.Total = item.SubTotal - item.Discount;
                Console.WriteLine($"Subtotal:{item.SubTotal} - Discount:{item.Discount} - Total Order:{item.Total}");
            }

            Console.WriteLine("Proccessed");
        }

        private static List<Order> GetOrders()
        {
            List<Order> orders = new()
            {
               new Order
               {
                   Customer = new()
                   {
                       Id = 1,
                       Name = "Pedro",
                       CustomerType = CustomerType.PREMIUM
                   },
                   OrderNumber = "0001",

                   Products = new List<Product>
                   {
                       new Product
                       {
                           Name = "Juice",
                           Price = 50.0
                       },
                       new Product
                       {
                           Name = "Bread",
                           Price = 20.0
                       },
                       new Product
                       {
                           Name = "Water",
                           Price = 15.0
                       }
                   },
               },


               new Order
               {
                   Customer = new()
                   {
                       Id = 1,
                       Name = "Tomas",
                       CustomerType = CustomerType.REGULAR
                   },
                   OrderNumber = "0002",

                   Products = new List<Product>
                   {
                       new Product
                       {
                           Name = "Juice",
                           Price = 50.0
                       },
                       new Product
                       {
                           Name = "Bread",
                           Price = 20.0
                       },
                       new Product
                       {
                           Name = "Water",
                           Price = 15.0
                       }
                   },
               }

            };
            return orders;
        }
    }
}
