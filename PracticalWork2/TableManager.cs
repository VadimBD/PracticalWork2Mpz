using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticalWork2
{
    internal class TableManager
    {
        private List<Table> tables = new List<Table>();

        public void AddTable(int tableId, int capacity, TableStatuses status)
        {
            tables.Add(new Table(tableId, capacity, status));
        }

        public void DisplayTables()
        {
            Console.WriteLine("Current table statuses:");
            foreach (var table in tables)
            {
                table.DisplayTableInfo();
            }
        }

        public void ReserveTable(int tableId)
        {
            var table = tables.Find(t => t.TableId == tableId);
            if (table != null)
            {
                if (table.Status == TableStatuses.available)
                {
                    table.Status = TableStatuses.reserved;
                    Console.WriteLine($"Table {tableId} has been reserved.");
                }
                else
                {
                    Console.WriteLine($"Table {tableId} is not available for reservation.");
                }
            }
            else
            {
                Console.WriteLine($"Table {tableId} does not exist.");
            }
        }

        public void UpdateTableStatus(int tableId, TableStatuses newStatus)
        {
            var table = tables.Find(t => t.TableId == tableId);
            if (table != null)
            {
                table.Status = newStatus;
                Console.WriteLine($"Table {tableId} status updated to {newStatus}.");
            }
            else
            {
                Console.WriteLine($"Table {tableId} does not exist.");
            }
        }
    }
}
