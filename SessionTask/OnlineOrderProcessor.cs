using SessionTask.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace SessionTask
{
    internal class OnlineOrderProcessor : IOrderProcessor
    {
        public decimal CalculateDiscount(decimal OrderAmount)
        {
            return OrderAmount * .90M;
        }

        public void ProcessOrder(Order order)
        {
            CalculateDiscount(order.OrderAmount);
            WriteLine($"Order {order.OrderId} processed for {order.CustomerName}. Final amount after 10% discount: ${order.OrderAmount:F2}");
        }
    }
}
