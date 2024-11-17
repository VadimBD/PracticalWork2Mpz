using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticalWork2
{
    internal class Employee
    {
        public int EmployeeId { get; set; }
        public string Name { get; set; }
        public Positions Position { get; set; }  
        public string WorkSchedule { get; set; } // "9:00-18:00"
        public List<Order> AssignedOrders { get; set; } = [];

        public Employee(int employeeId, string name, Positions position, string workSchedule)
        {
            EmployeeId = employeeId;
            Name = name;
            Position = position;
            WorkSchedule = workSchedule;
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
