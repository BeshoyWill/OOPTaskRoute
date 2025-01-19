using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SessionTask.interfaces
{
    public interface IOrderProcessor
    {
        void ProcessOrder(Order order);

        decimal CalculateDiscount(decimal OrderAmount);
    }
}
