using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace OOP_Task
{
    internal class Library
    {
        public int ItemID { get; set; }
        public bool IsAvailable { get; set; } = true;

        public virtual void CheckOut()
        {
            if (IsAvailable)
            {
                IsAvailable = false;
                WriteLine("The item is available");
            }
            else
            {
                WriteLine("The item is unavailable");
            }
        }

        public virtual void ReturnItem()
        {
            if (!IsAvailable)
            {
                IsAvailable = true;
                WriteLine("The item is returned");
            }
            else
            {
                WriteLine("The item is available");
            }
        }
    }
}
