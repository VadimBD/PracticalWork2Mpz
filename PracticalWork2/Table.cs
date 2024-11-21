using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticalWork2
{
    internal class Table
    {

        public int TableId { get; set; }
        public int Capacity { get; set; }  
        public TableStatuses Status { get; set; } 
        public Table(int tableId, int capacity, TableStatuses status)
        {
            TableId = tableId;
            Capacity = capacity;
            Status = status;
        }
        public void DisplayTableInfo()
        {
            Console.WriteLine($"Table {TableId}  Seats: {Capacity} Status: {Status}");
        }
    }
    internal enum TableStatuses
    {
        available,
        occupied,
        reserved
    }
}
