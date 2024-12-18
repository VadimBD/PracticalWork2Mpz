using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticalWork2
{
    internal class OrderEventArgs:EventArgs
    {
        public Order Order { get; }
        public Employee Employee { get; }

        public OrderEventArgs(Order order, Employee employee)
        {
            Order = order;
            Employee = employee;
        }
    }
}
