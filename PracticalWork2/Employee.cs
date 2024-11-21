using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static PracticalWork2.Order;

namespace PracticalWork2
{
    internal class Employee
    {
        public int EmployeeId { get; set; }
        public string Name { get; set; }
        public Positions Position { get; set; }
        public string WorkSchedule { get; set; } // "9:00-18:00"
        public List<Order> AssignedOrders { get; set; } = new List<Order>();

        public Employee(int employeeId, string name, Positions position, string workSchedule)
        {
            EmployeeId = employeeId;
            Name = name;
            Position = position;
            WorkSchedule = workSchedule;
        }

       
        public void AssignOrder(Order order)
        {
            if (order != null)
            {
                AssignedOrders.Add(order);
                Console.WriteLine($"Order {order.OrderId} assigned to {Name} ({Position}).");
            }
        }

        
        public int GetOrderCount()
        {
            return AssignedOrders.Count;
        }

        
        public TimeSpan CalculateAverageServiceTime()
        {
            if (AssignedOrders.Count == 0) return TimeSpan.Zero;

            TimeSpan totalTime = TimeSpan.Zero;
            foreach (var order in AssignedOrders)
            {
                if (order.Status == OrderStatuses.Completed)
                {
                    totalTime += DateTime.Now - order.OrderDate;
                }
            }
            return TimeSpan.FromTicks(totalTime.Ticks / AssignedOrders.Count);
        }
    }

    internal enum Positions
    {
        None,
        Waiter, 
        Cook, 
        Courier, 
       Administrator
    }
}
