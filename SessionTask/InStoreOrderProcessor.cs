using SessionTask.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace SessionTask
{
    internal class InStoreOrderProcessor : IOrderProcessor
    {
        public decimal CalculateDiscount(decimal OrderAmount)
        {
            return OrderAmount * .95M;
        }

        public void ProcessOrder(Order order)
        {
            decimal discountAmount = CalculateDiscount(order.OrderAmount);
            WriteLine($"Order {order.OrderId} processed for {order.CustomerName}. Final amount after 5% discount: ${discountAmount:F@}");
        }
    }
}
