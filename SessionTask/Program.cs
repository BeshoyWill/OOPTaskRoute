using SessionTask.interfaces;
using static System.Console;

namespace SessionTask
{
    internal class Program
    {
        private static int orderId;
        private static decimal orderAmount;
        private static string customerName;



        static IOrderProcessor GetOrderProcessor(string orderType)
        {
            return orderType.ToLower() switch
            {
                "online" => new OnlineOrderProcessor(),
                "in-store" => new InStoreOrderProcessor(),
                _ => throw new ArgumentException("Invalid order type. Please enter 'Online' or 'In-Store'.")
            };
        }


        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter Order ID: ");
                int OrderId = int.Parse(ReadLine());

                Console.WriteLine("Enter Customer Name: ");
                string CustomerName = ReadLine();

                Console.WriteLine("Enter Order Amount: ");
                decimal OrderAmount = decimal.Parse(ReadLine());


                Console.Write("Enter Order Type (Online/In-Store): ");
                string orderType = Console.ReadLine();

                Order order = new Order
                {
                    OrderId = orderId,
                    CustomerName = customerName,
                    OrderAmount = orderAmount,
                    OrderProcessor = GetOrderProcessor(orderType)
                };

                order.OrderProcessor.ProcessOrder(order);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}
